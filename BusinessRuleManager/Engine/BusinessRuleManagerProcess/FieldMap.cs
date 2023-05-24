// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "fieldMap" grammar expression.
	/// </summary>
	public class FieldMap
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
			// Source and target node are same
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
			XmlNode sourceConfigNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:source", this.namespaceManager);
			XmlNode targetConfigNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:target", this.namespaceManager);

			// Get source, target
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

			string target = StringContainer.EvaluateString(targetConfigNode, this.engine, pSourceNode, this.namespaceManager);
			if (target == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					targetConfigNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Find source node
			XmlNode sourceNode = pSourceNode.SelectSingleNode(source);
			if (sourceNode != null)
			{
				// Find destination nodes
				XmlNodeList targetNodes = pTargetNode.SelectNodes(target);
				foreach (XmlNode targetNode in targetNodes)
				{
					targetNode.InnerXml = sourceNode.InnerXml;
					// Copy attributes for elements
					if ((sourceNode.Attributes != null) && (targetNode.Attributes != null))
					{
						foreach (XmlAttribute attr in sourceNode.Attributes)
						{
							targetNode.Attributes.SetNamedItem(attr);
						}
						// Remove null attribute
						if (targetNode.InnerXml != string.Empty)
						{
							targetNode.Attributes.RemoveNamedItem(BusinessRuleManagerAttributeName.Null);
						}
					}
				}
				// Create target if it doesn't exist
				if (targetNodes.Count == 0)
				{
					XmlNode targetNode = XmlUtil.GetOrCreateNode(pTargetNode, target);
					targetNode.InnerXml = sourceNode.InnerXml;
					// Copy attributes for elements
					if ((sourceNode.Attributes != null) && (targetNode.Attributes != null))
					{
						foreach (XmlAttribute attr in sourceNode.Attributes)
						{
							targetNode.Attributes.SetNamedItem(attr);
						}
					}
				}
			}
		}
		#endregion
	}
}
