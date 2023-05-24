// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "setNodeValue" grammar expression.
	/// </summary>
	public class SetNodeValue
		: GrammarBase,
		IGrammarProcess,
		IGrammarProcess2
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public virtual void Process(XmlNode pDataNode)
		{
			this.Process(pDataNode, pDataNode);
		}
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public virtual void Process(XmlNode pSourceNode, XmlNode pTargetNode)
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
				XmlUtil.SetChildNodeValue(matchingNode, ".", value, true);
			}
		}
		#endregion

		#region Protected methods
		protected string GetPath(XmlNode pDataNode)
		{
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);

			// Get path
			string path = StringContainer.EvaluateString(pathNode, this.engine, pDataNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return path;
		}

		protected string GetValue(XmlNode pDataNode)
		{
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Value expects 1 child implementing any interface that returns a value
			XmlNodeList childNodes = this.GetChildElements(valueNode);
			if (childNodes.Count != 1)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.WrongChildCount,
					valueNode.Name + "~1",
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get value as string
			GrammarBase valueGrammar = GrammarBase.CreateInstance(childNodes[0], null, this);
			string value = string.Empty;

			// Check for each supplied interface
			if (valueGrammar.GetType().GetInterface(typeof(IGrammarString).FullName) != null)
			{
				IGrammarString stringGrammar = (IGrammarString)valueGrammar;
				value = stringGrammar.EvaluateString(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarBoolean).FullName) != null)
			{
				IGrammarBoolean boolGrammar = (IGrammarBoolean)valueGrammar;
				value = Literal.ConvertToString(boolGrammar.EvaluateBoolean(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarDateTime).FullName) != null)
			{
				IGrammarDateTime dateGrammar = (IGrammarDateTime)valueGrammar;
				value = Literal.ConvertToString(dateGrammar.EvaluateDateTime(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarInteger).FullName) != null)
			{
				IGrammarInteger intGrammar = (IGrammarInteger)valueGrammar;
				value = Literal.ConvertToString(intGrammar.EvaluateInteger(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarFloat).FullName) != null)
			{
				IGrammarFloat floatGrammar = (IGrammarFloat)valueGrammar;
				value = Literal.ConvertToString(floatGrammar.EvaluateFloat(pDataNode));
			}
			else
			{
				// Throw exception if an invalid message type was requested
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.InterfaceNotImplemented,
					valueGrammar.GetType().FullName + "~*any interface but IGrammarProcess*",
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return value;
		}
		#endregion
	}
}
