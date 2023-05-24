// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implements "setNodeXML" grammar.
	/// </summary>
	public class SetNodeXML
		: GrammarBase,
		IGrammarProcess,
		IGrammarProcess2
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			this.Process(pDataNode, pDataNode);
		}
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public void Process(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get child nodes in metadata
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Get path, value
			string path = StringContainer.EvaluateString(pathNode, this.engine, pSourceNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					pathNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			string value = StringContainer.EvaluateString(valueNode, this.engine, pSourceNode, this.namespaceManager);
			if (value == string.Empty)
			{
				return;
			}

			// Get all matching nodes
			XmlNodeList matchingNodes = pTargetNode.SelectNodes(path);

			// Set value of matching nodes
			foreach (XmlNode matchingNode in matchingNodes)
			{
				matchingNode.InnerXml = value;
			}
		}

		#endregion
	}
}
