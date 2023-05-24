// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "addNode" grammar expression.
	/// </summary>
	public class AddNode
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

			// Add node
			XmlNode newNode = this.CreateNewNode(pSourceNode, pTargetNode);

			// If requested, set the value
			XmlNode valueNode = this.metadataNode.SelectSingleNode("brm:value", this.namespaceManager);
			if (valueNode != null)
			{
				string value = this.GetValue(pSourceNode);
				XmlUtil.SetChildNodeValue(newNode, ".", value, true);
			}
		}
		#endregion

		#region Protected methods
		protected XmlNode CreateNewNode(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Get path, name
			string path = this.GetPath(pSourceNode);
			string name = this.GetName(pSourceNode);

			// Use path to get 1st matching node
			XmlNode destNode = XmlUtil.GetOrCreateNode(pTargetNode, path);

			// Now add child node
			XmlNode newNode = XmlUtil.AddChildNode(destNode, name);

			return newNode;
		}

		protected string GetName(XmlNode pDataNode)
		{
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return name;
		}
		#endregion
	}
}
