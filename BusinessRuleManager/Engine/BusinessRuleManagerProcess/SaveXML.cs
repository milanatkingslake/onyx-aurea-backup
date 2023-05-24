// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Save an XML node's contents to file.
	/// </summary>
	public class SaveXML
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

			// Default to read from source node
			string source = XmlUtil.GetNodeValue(this.metadataNode, "brm:source", this.namespaceManager, false, "source");
			XmlNode dataNode = null;
			switch (source)
			{
				case "source":
					dataNode = pSourceNode;
					break;
				case "target":
					dataNode = pTargetNode;
					break;
				default:
					// Throw exception if an invalid message type was requested
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.InvalidPropertyValue,
						this.metadataNode.Name + "~source~" + source,
						this.metadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name);
			}

			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);

			// Get name, path
			string name = StringContainer.EvaluateString(nameNode, this.engine, dataNode, this.namespaceManager);
			string path = StringContainer.EvaluateString(pathNode, this.engine, dataNode, this.namespaceManager);

			// Find node
			XmlNode childNode = dataNode.SelectSingleNode(path);

			// Log to event log
			if (childNode != null)
			{
				// Save child node contents to file path
				XmlDocument logDoc = new XmlDocument();
				logDoc.LoadXml(childNode.OuterXml);
				try
				{
					logDoc.Save(name);
				}
				catch (Exception e)
				{
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.ErrorAccessingFile,
						name,
						"",
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name,
						e);
				}
			}
		}
		#endregion
	}
}
