// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data;
using System.Data.Odbc;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Executes an ODBC call.
	/// </summary>
	public class OdbcCall
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

			// Get child nodes in metadata
			XmlNode stmtNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:statement", this.namespaceManager);
			XmlNode inputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:inputParameters", this.namespaceManager);
			XmlNode outputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:outputParameters", this.namespaceManager);

			// Get SQL statement
			string stmt = StringContainer.EvaluateString(stmtNode, this.engine, pDataNode, this.namespaceManager);
			if (stmt == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get connection
			System.Data.Odbc.OdbcConnection connection = this.GetCachedConnection();

			// Create command using query
			OdbcCommand command = new OdbcCommand(stmt, connection);
			command.CommandType = CommandType.Text;

			// Store the command in the cache temporarily
			this.engine.cache.Write(this.GetCacheKey(CachePrefix.Command), command);

			// Process input parameters
			ProcessContainer.Process(inputParamsNode, this.engine, pDataNode, this.namespaceManager);

			// Remove command from cache
			this.engine.cache.Remove(this.GetCacheKey(CachePrefix.Command));

			// Create a data adapter, use command
			OdbcDataAdapter adapter = new OdbcDataAdapter();
			adapter.SelectCommand = command;

			// Fill dataset by executing the command
			DataSet dataSet = new DataSet();
			dataSet.Clear();

			try
			{
				adapter.Fill(dataSet);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.OdbcErrorExecutingStatement,
					command.CommandText,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Store the command and dataset in the cache temporarily
			this.engine.cache.Write(this.GetCacheKey(CachePrefix.Command), command);
			this.engine.cache.Write(this.GetCacheKey(CachePrefix.Dataset), dataSet);

			// Process output parameters
			ProcessContainer.Process(outputParamsNode, this.engine, pDataNode, this.namespaceManager);

			// Remove command and dataset from cache
			this.engine.cache.Remove(this.GetCacheKey(CachePrefix.Command));
			this.engine.cache.Remove(this.GetCacheKey(CachePrefix.Dataset));
		}
		#endregion
	}
}
