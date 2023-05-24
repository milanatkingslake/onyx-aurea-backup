// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implements the "subProcess" grammar.
	/// </summary>
	public class SubProcess
		: SubProcessBase,
		IGrammarProcess
	{
		#region Public methods
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get child nodes in metadata
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			// Arguments are optional
			XmlNode argumentsNode = this.metadataNode.SelectSingleNode("brm:arguments", this.namespaceManager);

			// Get name, prepend root path
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			name = this.engine.repositoryPath + InternalEngine.FilePath.Metadata + "\\" + name;

			// Get existing cached arguments if already in cache (allows for nesting of subprocess calls)
			Dictionary<string, string> oldCachedArgs = null;
			if (this.engine.cache.ContainsKey(GetCacheKey(this)))
			{
				oldCachedArgs = (Dictionary<string, string>)this.engine.cache.Read(GetCacheKey(this));
			}

			// Set the arguments list to a new empty list
			SetCachedInfo(this, new Dictionary<string, string>());

			try
			{
				// Process arguments
				if (argumentsNode != null)
				{
					IGrammarProcess processGrammar;
					XmlNodeList argumentNodes = this.GetChildElements(argumentsNode);
					foreach (XmlNode argumentNode in argumentNodes)
					{
						processGrammar = (IGrammarProcess)GrammarBase.CreateInstance(argumentNode, typeof(IGrammarProcess), this);
						processGrammar.Process(pDataNode);
					}
				}

				// Load subprocess metadata from file or cache
				XmlDocumentCache tempDoc = new XmlDocumentCache(this.engine.grammarDefinitionCache.enableCaching,
					InternalEngine.CachePrefix.Metadata,
					InternalEngine.CachePrefix.NamespaceManagerSuffix,
					this.engine.cache);
				tempDoc.Load(name);

				// Process the sub-process grammar
				IGrammarProcess subProcessGrammar = (IGrammarProcess)GrammarBase.CreateInstance(tempDoc.xmlDoc.DocumentElement,
					typeof(IGrammarProcess),
					this.engine,
					tempDoc.namespaceManager);
				subProcessGrammar.Process(pDataNode);
			}
			finally
			{
				// Restore existing cached arguments or remove arguments
				if (oldCachedArgs != null)
				{
					SetCachedInfo(this, oldCachedArgs);
				}
				else
				{
					RemoveCachedInfo(this);
				}
			}
		}
		#endregion
	}
}
