// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Implement "iif" grammar expression.
	/// </summary>
	public class IIf
		: GrammarBase,
		IGrammarString
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured string grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>string value based on grammar processing.</returns>
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get child nodes
			XmlNode testNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:test", this.namespaceManager);
			XmlNode thenNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:then", this.namespaceManager);
			XmlNode elseNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:else", this.namespaceManager);

			// Evaluate the test condition to determine what path the follow
			if (BooleanContainer.EvaluateBoolean(testNode, this.engine, pDataNode, this.namespaceManager))
			{
				// Follow then logic and return result
				return StringContainer.EvaluateString(thenNode, this.engine, pDataNode, this.namespaceManager);
			}
			else
			{
				// Follow else logic and return result
				return StringContainer.EvaluateString(elseNode, this.engine, pDataNode, this.namespaceManager);
			}
		}
		#endregion
	}
}
