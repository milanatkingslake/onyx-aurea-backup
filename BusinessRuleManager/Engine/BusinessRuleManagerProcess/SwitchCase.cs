// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "switch" grammar expression.
	/// </summary>
	public class Switch
		: GrammarBase,
		IGrammarProcess
	{
		#region Public methods
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get child nodes
			XmlNodeList caseNodes = this.metadataNode.SelectNodes("brm:case", this.namespaceManager);
			XmlNode defaultNode = this.metadataNode.SelectSingleNode("brm:default", this.namespaceManager);

			// Process case blocks
			bool stop = false;

			foreach (XmlNode caseNode in caseNodes)
			{
				stop = ProcessCase(caseNode, pDataNode);
				// Stop processing case blocks if one was executed
				if (stop) break;
			}

			// Execute default block if required
			if (!stop && (defaultNode != null))
			{
				XmlNode rulesNode = XmlUtil.GetRequiredNode(defaultNode, "brm:rules", this.namespaceManager);
				ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);
			}
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Processes an individual case block within a switch operation.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node for the case block.</param>
		/// <param name="pDataNode">Current data context.</param>
		/// <returns>True if the case block was executed.</returns>
		protected bool ProcessCase(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			// Get child nodes
			XmlNode testNode = XmlUtil.GetRequiredNode(pMetadataNode, "brm:test", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(pMetadataNode, "brm:rules", this.namespaceManager);

			// Evaluate the test condition to determine if child rules should be executed
			if (BooleanContainer.EvaluateBoolean(testNode, this.engine, pDataNode, this.namespaceManager))
			{
				// Execute child ruleset
				ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);
				return true;
			}

			return false;
		}
		#endregion
	}
}
