// Copyright © Aptean 2018. All rights reserved.
using System;
using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;
using ConsonaCRM.BusinessRuleManager.Grammar;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Rules engine component accessible to external interfaces.
	/// </summary>
	public class InternalEngine
	{
		#region Public constants
		/// <summary>
		/// File paths.
		/// </summary>
		public struct FilePath
		{
			/// <summary>
			/// Path to metadata
			/// </summary>
			public const string Metadata = "\\metadata";
			/// <summary>
			/// Name of repository list file.
			/// </summary>
			public const string RepositoryList = "businessRuleManager.repositories.xml";
			/// <summary>
			/// Name of message list file.
			/// </summary>
			public const string MessageList = "businessRuleManager.messages.xml";
			/// <summary>
			/// Name of settings file.
			/// </summary>
			public const string Settings = "\\businessRuleManager.settings.xml";
			/// <summary>
			/// Path to grammar definition files
			/// </summary>
			public const string Grammar = "\\grammar";
			/// <summary>
			/// Search pattern for grammar definition files
			/// </summary>
			public const string GrammarFiles = "*.xml";
		}
		/// <summary>
		/// Cache key prefixes.
		/// </summary>
		public struct CachePrefix
		{
			/// <summary>
			/// Cache prefix for repository list cache.
			/// </summary>
			public const string RepositoryList = "REPOSITORY_LIST_";
			/// <summary>
			/// Cache prefix for message list cache.
			/// </summary>
			public const string MessageList = "MESSAGE_LIST_";
			/// <summary>
			/// Cache prefix for settings cache.
			/// </summary>
			public const string Settings = "SETTINGS_CACHE_";
			/// <summary>
			/// Cache prefix for metadata cache.
			/// </summary>
			public const string Metadata = "METADATA_CACHE_";
			/// <summary>
			/// Cache prefix for grammar definition cache.
			/// </summary>
			public const string Definition = "DEFINITION_CACHE_";
			/// <summary>
			/// Cache suffix for namespace managers.
			/// </summary>
			public const string NamespaceManagerSuffix = "NMSPMGR_";
		}
		#endregion

		#region Private fields
		private SettingsCache m_settingsCache = null;
		private GrammarDefinitionCache m_grammarDefinitionCache = null;
		private LocalCache m_cache;
		private object m_externalComponent = null;
		private string m_repositoryPath;
		string m_referenceID;
		#endregion

		#region Public properties
		/// <summary>
		/// Settings cache.
		/// </summary>
		public SettingsCache settingsCache
		{
			get
			{
				return m_settingsCache;
			}
			set
			{
				m_settingsCache = value;
			}
		}
		/// <summary>
		/// Grammar definition cache.
		/// </summary>
		public GrammarDefinitionCache grammarDefinitionCache
		{
			get
			{
				return m_grammarDefinitionCache;
			}
			set
			{
				m_grammarDefinitionCache = value;
			}
		}
		/// <summary>
		/// Component cache.
		/// </summary>
		public LocalCache cache
		{
			get
			{
				return m_cache;
			}
			set
			{
				m_cache = value;
			}
		}
		/// <summary>
		/// Reference to external component that may be used
		/// by grammar classes for rules processing.
		/// </summary>
		public object externalComponent
		{
			get
			{
				return m_externalComponent;
			}
		}
		/// <summary>
		/// Path to rules engine repository.
		/// </summary>
		public string repositoryPath
		{
			get
			{
				return m_repositoryPath;
			}
		}
		/// <summary>
		/// Unique reference ID for this execution.
		/// </summary>
		public string referenceID
		{
			get
			{
				return m_referenceID;
			}
		}
		#endregion

		#region Protected properties
		/// <summary>
		/// Provides access to the assembly and class name for this class.
		/// </summary>
		protected string assemblyClassName
		{
			get
			{
				return GetType().Name;
			}
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Execute a ruleset from a repository against a provide
		/// input XML document.
		/// </summary>
		/// <param name="psRepositoryPath">Path to the repository.</param>
		/// <param name="psMetadataPath">Path to the ruleset metada in the repository.</param>
		/// <param name="pDataPackage">XML data package.</param>
		/// <param name="psCacheControlPrefix">Prefix to use for storing items in the rules engine cache.</param>
		/// <param name="psReferenceID">Unique reference ID for this execution.</param>
		/// <param name="pExternalComponent"></param>
		public void Execute(string psRepositoryPath,
			string psMetadataPath,
			DataPackage pDataPackage,
			string psCacheControlPrefix,
			string psReferenceID,
			object pExternalComponent)
		{
			// Check metadata file and path were provided
			if ((psMetadataPath == null) || (psMetadataPath == string.Empty))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.MissingMetadataFileName,
					"", "",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Add cache component
			this.cache = new LocalCache(psCacheControlPrefix);

			// Save properties for use by rules processing
			m_repositoryPath = psRepositoryPath;
			m_externalComponent = pExternalComponent;
			m_referenceID = psReferenceID;

			// Ensure we don't have a trailing slash for repository path
			if (m_repositoryPath.EndsWith("\\"))
			{
				m_repositoryPath = m_repositoryPath.Remove(m_repositoryPath.LastIndexOf("\\"));
			}

			// Load settings cache
			this.settingsCache = new SettingsCache(true, CachePrefix.Settings,
				CachePrefix.NamespaceManagerSuffix, this.cache);
			this.settingsCache.Load(this.repositoryPath + FilePath.Settings);

			// Load grammar definitions
			this.grammarDefinitionCache = new GrammarDefinitionCache(this.settingsCache.enableCaching,
				CachePrefix.Definition,
				CachePrefix.NamespaceManagerSuffix,
				this.cache);
			this.grammarDefinitionCache.Load(this.repositoryPath + FilePath.Grammar, FilePath.GrammarFiles);

			// Load metadata
			string metadataFile = this.repositoryPath + FilePath.Metadata + "\\" + psMetadataPath;
			XmlDocumentCache metadataCache = new XmlDocumentCache(this.settingsCache.enableCaching,
				CachePrefix.Metadata,
				CachePrefix.NamespaceManagerSuffix,
				this.cache);
			metadataCache.Load(metadataFile);

			// Start processing from root node (must implement IGrammarProcess)
			IGrammarProcess process = (IGrammarProcess)GrammarBase.CreateInstance(
				metadataCache.xmlDoc.DocumentElement,
				typeof(IGrammarProcess),
				this,
				metadataCache.namespaceManager);
			process.Process(pDataPackage.contextNode);
		}
		#endregion
	}
}
