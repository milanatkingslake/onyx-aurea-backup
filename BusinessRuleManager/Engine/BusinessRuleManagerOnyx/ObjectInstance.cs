// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Implement "objectInstance" grammar expression.
	/// Adds an instance of an Onyx LBO to a path in the XML document.
	/// </summary>
	public class ObjectInstance
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
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);

			// Get path, name
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

			string name = StringContainer.EvaluateString(nameNode, this.engine, pSourceNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					nameNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Use path to get 1st matching node
			XmlNode destNode = XmlUtil.GetRequiredNode(pTargetNode, path);
			// Append an object instance
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			XmlUtil.AppendXmlFromString(destNode,
				stepComponent.dictionaryCache.GetObjectInstance(name));
		}
		#endregion
	}
}
