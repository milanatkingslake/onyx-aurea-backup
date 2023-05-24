// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Implement "odbcForEachRow" grammar expression.
	/// </summary>
	public class OdbcForEachRow
		: OdbcBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get dataset
			DataSet dataSet = this.GetCachedDataset();

			// Check there is a data table
			if (dataSet.Tables.Count == 0)
			{
				return;
			}

			// Get data table, return column count
			DataTable table = dataSet.Tables[0];

			// Get child nodes in metadata
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Execute the child rules for each matching node
			IGrammarProcess childGrammar = new ProcessContainer(rulesNode,
				this.engine, this.namespaceManager);
			foreach (DataRow row in table.Rows)
			{
				// Store the command in the cache temporarily
				this.engine.cache.Write(this.GetCacheKey(CachePrefix.Row), row);

				bool breakDetected = false;

				try
				{
					// Process input parameters
					childGrammar.Process(pDataNode);
				}
				catch (BusinessRuleManagerBreakException)
				{
					breakDetected = true;
				}
				catch (BusinessRuleManagerContinueException)
				{
					// Allow loop to continue
				}

				// Remove command from cache
				this.engine.cache.Remove(this.GetCacheKey(CachePrefix.Row));

				// Break if requested
				if (breakDetected)
				{
					break;
				}
			}
		}
		#endregion
	}
}
