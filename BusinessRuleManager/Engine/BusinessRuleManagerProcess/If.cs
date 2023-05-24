// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "if" grammar expression.
	/// </summary>
	public class If
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
			XmlNode thenNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:then", this.namespaceManager);
			XmlNode elseNode = this.metadataNode.SelectSingleNode("brm:else", this.namespaceManager);

			// Evaluate the test condition to determine what path the follow
			if (BooleanContainer.EvaluateBoolean(testNode, this.engine, pDataNode, this.namespaceManager))
			{
				// Follow then logic
				ProcessContainer.Process(thenNode, this.engine, pDataNode, this.namespaceManager);
			}
			else
			{
				if (elseNode != null)
				{
					// Follow else logic
					ProcessContainer.Process(elseNode, this.engine, pDataNode, this.namespaceManager);
				}
			}
		}
		#endregion
	}
}
