// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Format a string using a composite format string.
	/// </summary>
	public class StringFormat
		: GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get value
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			string value = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);

			// Get arguments
			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:arguments", this.namespaceManager);
			// If there are no arguments, return the format string
			if (childNode.ChildNodes.Count == 0)
			{
				return value;
			}

			// Add arguments to an object array, then format
			object[] args = new object[childNode.ChildNodes.Count];
			for (int i = 0; i < childNode.ChildNodes.Count; i++)
			{
				args.SetValue(this.GetArgument(pDataNode, childNode.ChildNodes[i]), i);
			}

			// Catch any argument exceptions
			try
			{
				return string.Format(value, args);
			}
			catch (Exception e)
			{
				// Throw exception if an invalid message type was requested
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.StringFormatError,
					e.Message,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Get a strongly typed argument value.
		/// </summary>
		/// <param name="pDataNode">Current context node.</param>
		/// <param name="pGrammarNode">Grammar definition node.</param>
		/// <returns>Argument value as strongly typed object.</returns>
		protected object GetArgument(XmlNode pDataNode, XmlNode pGrammarNode)
		{
			// Get value as string
			GrammarBase valueGrammar = GrammarBase.CreateInstance(pGrammarNode, null, this);

			// Check for each supplied interface
			if (valueGrammar.GetType().GetInterface(typeof(IGrammarString).FullName) != null)
			{
				IGrammarString stringGrammar = (IGrammarString)valueGrammar;
				return stringGrammar.EvaluateString(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarBoolean).FullName) != null)
			{
				IGrammarBoolean boolGrammar = (IGrammarBoolean)valueGrammar;
				return boolGrammar.EvaluateBoolean(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarDateTime).FullName) != null)
			{
				IGrammarDateTime dateGrammar = (IGrammarDateTime)valueGrammar;
				return dateGrammar.EvaluateDateTime(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarInteger).FullName) != null)
			{
				IGrammarInteger intGrammar = (IGrammarInteger)valueGrammar;
				return intGrammar.EvaluateInteger(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarFloat).FullName) != null)
			{
				IGrammarFloat floatGrammar = (IGrammarFloat)valueGrammar;
				return floatGrammar.EvaluateFloat(pDataNode);
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
		}
		#endregion
	}
}
