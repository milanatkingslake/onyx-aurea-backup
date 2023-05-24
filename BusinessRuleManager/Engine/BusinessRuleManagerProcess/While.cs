// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "while" grammar expression.
	/// </summary>
	public class While
		: GrammarBase,
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

			// Get child nodes
			XmlNode testNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:test", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Evaluate the test condition to determine if child rules should be executed
			while (BooleanContainer.EvaluateBoolean(testNode, this.engine, pDataNode, this.namespaceManager))
			{
				try
				{
					// Execute child ruleset
					ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);
				}
				catch (BusinessRuleManagerBreakException)
				{
					break;
				}
				catch (BusinessRuleManagerContinueException)
				{
					// Allow loop to continue
				}
			}
		}
		#endregion
	}
}
