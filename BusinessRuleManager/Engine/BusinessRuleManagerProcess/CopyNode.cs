// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "copyNode" grammar expression.
	/// </summary>
	public class CopyNode
		: AddNode
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

			// Get child nodes in metadata
			XmlNode sourceConfigNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:source", this.namespaceManager);

			// Get source
			string source = StringContainer.EvaluateString(sourceConfigNode, this.engine, pSourceNode, this.namespaceManager);
			if (source == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					sourceConfigNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Find source node
			XmlNode sourceNode = pSourceNode.SelectSingleNode(source);
			if (sourceNode != null)
			{
				// Add node
				XmlNode newNode = this.CreateNewNode(pSourceNode, pTargetNode);

				// Now copy content from source
				newNode.InnerXml = sourceNode.InnerXml;
				foreach (XmlAttribute attr in sourceNode.Attributes)
				{
					newNode.Attributes.SetNamedItem(attr);
				}
			}
		}
		#endregion
	}
}
