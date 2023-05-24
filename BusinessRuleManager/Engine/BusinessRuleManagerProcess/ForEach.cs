// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "forEach" grammar expression.
	/// </summary>
	public class ForEach
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

			// Get child nodes in metadata
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get path
			string path = StringContainer.EvaluateString(pathNode, this.engine, pDataNode, this.namespaceManager);
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

			// Use path to get all matching nodes
			XmlNodeList destNodes = pDataNode.SelectNodes(path);

			// Execute the child rules for each matching node
			IGrammarProcess childGrammar = new ProcessContainer(rulesNode,
				this.engine, this.namespaceManager);
			foreach (XmlNode destNode in destNodes)
			{
				try
				{
					childGrammar.Process(destNode);
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
