// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data.Odbc;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Establishes an ODBC connection and makes it available to child ODBC grammar.
	/// </summary>
	public class OdbcConnection
		: OdbcBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public virtual void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);

			// Load connections metadata
			XmlDocumentCache connectionsDoc = new XmlDocumentCache(this.engine.settingsCache.enableCaching,
				CachePrefix.OdbcConnections,
				InternalEngine.CachePrefix.NamespaceManagerSuffix,
				this.engine.cache);
			connectionsDoc.Load(this.engine.repositoryPath + FilePath.Odbc + FilePath.Connections);

			// Get connection string
			string connectionString = XmlUtil.GetNodeValue(connectionsDoc.xmlDoc.DocumentElement, "//connection[@name='" + name + "' and @active=1]/@string", false, string.Empty);
			if (connectionString == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.OdbcConnectionNotFound,
					name,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.BusinessLogic,
					MethodBase.GetCurrentMethod().Name);
			}

			// Create connection
			using (System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(connectionString))
			{
				// Open the connection
				try
				{
					connection.Open();
				}
				catch (Exception e)
				{
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.OdbcErrorOpeningConnection,
						name,
						"",
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.BusinessLogic,
						MethodBase.GetCurrentMethod().Name,
						e);
				}

				// Store the connection in the cache temporarily
				this.engine.cache.Write(this.GetCacheKey(CachePrefix.Connection), connection);

				// Execute the child rules
				ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);

				// Remove connection from cache
				this.engine.cache.Remove(this.GetCacheKey(CachePrefix.Connection));

				// Close the connection.
				connection.Close();
			}
		}
		#endregion
	}
}
