// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Cache
{
	/// <summary>
	/// Provides access to cached grammar definitions.
	/// </summary>
	public class GrammarDefinitionCache : XmlDocumentCache
	{
		#region Private constants
		private struct CacheKey
		{
			public const string DefinitionTable = "DEFN_TBL";
		}
		#endregion

		#region Private fields
		private Hashtable m_hashTable;
		#endregion

		#region Private properties
		/// <summary>
		/// Hash table of grammar definitions
		/// </summary>
		private Hashtable definitionTable
		{
			get
			{
				return m_hashTable;
			}
			set
			{
				m_hashTable = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Construct an instance using provided cache settings.
		/// </summary>
		/// <param name="pbEnableCaching">Indicates if caching is enabled.</param>
		/// <param name="psCachePrefix">Cache key prefix to use when caching metadata documents.</param>
		/// <param name="psNamespaceManagerSuffix">Cache key suffix to use when caching namespace managers.</param>
		/// <param name="pCache">Cache to use when caching metadata documents.</param>
		public GrammarDefinitionCache(bool pbEnableCaching, string psCachePrefix, string psNamespaceManagerSuffix, LocalCache pCache)
			:
			base(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache)
		{
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Load the grammar definition cache.
		/// Checks for a cached version first, and if not found, loads from file.
		/// </summary>
		/// <param name="psFolderPath">Path to find grammar definition files.</param>
		/// <param name="psSearchPattern">Search pattern to identify grammar definition files.</param>
		public void Load(string psFolderPath, string psSearchPattern)
		{
			string cacheKey = this.cachePrefix + CacheKey.DefinitionTable;

			// Get from cache first
			if (this.enableCaching)
			{
				if (this.cache.ContainsKey(cacheKey))
				{
					this.definitionTable = (Hashtable)cache.Read(cacheKey);
					return;
				}
			}

			// Get folder info
			DirectoryInfo dirInfo = new DirectoryInfo(psFolderPath);
			FileInfo[] files = dirInfo.GetFiles(psSearchPattern, SearchOption.AllDirectories);

			// Add definition table
			this.definitionTable = new Hashtable();
			GrammarDefinition definition;

			// Process each grammar definition file
			foreach (FileInfo file in files)
			{
				// Call base method if not in cache (loads and caches XML document)
				base.Load(file.FullName);

				// Remove XML document from cache (will replace with hashtable)
				this.Remove(file.FullName);

				// Process each "keyword" node (contains grammar definition)
				XmlNodeList grammarNodes = this.xmlDoc.DocumentElement.SelectNodes("grammar/keyword");
				foreach (XmlNode definitionNode in grammarNodes)
				{
					definition = GrammarDefinition.Deserialise(definitionNode);
					this.definitionTable.Add(definition.name, definition);
				}
			}

			// Write to cache
			if (this.enableCaching)
			{
				this.cache.Write(cacheKey, this.definitionTable);
			}
		}
		/// <summary>
		/// Lookup a grammar definition for a named grammar item.
		/// </summary>
		/// <param name="psName">Name of the grammar item.</param>
		/// <returns>GrammarDefinition object if found, null if not.</returns>
		public GrammarDefinition GetDefinition(string psName)
		{
			if (!this.definitionTable.ContainsKey(psName))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.UndefinedRuleGrammar,
					psName,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}
			return (GrammarDefinition)this.definitionTable[psName];
		}
		#endregion
	}
}
