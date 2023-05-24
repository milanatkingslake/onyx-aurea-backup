// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "setCDataNodeValue" grammar expression.
	/// </summary>
	public class SetCDataNodeValue
		: SetNodeValue
	{
		#region Public methods
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public override void Process(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get path
			string path = this.GetPath(pSourceNode);

			// Get value as string
			string value = this.GetValue(pSourceNode);

			// Get all matching nodes
			XmlNodeList matchingNodes = pTargetNode.SelectNodes(path);

			// Set value of matching nodes
			foreach (XmlNode matchingNode in matchingNodes)
			{
				XmlCDataSection cdataNode = matchingNode.OwnerDocument.CreateCDataSection(value);
				matchingNode.AppendChild(cdataNode);
			}
		}
		#endregion
	}
}
