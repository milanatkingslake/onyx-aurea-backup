// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Converts a non-integer value to an integer.
	/// </summary>
	public class ToInteger
		: GrammarBase,
		IGrammarInteger
	{
		#region Public methods
		public long EvaluateInteger(System.Xml.XmlNode pDataNode)
		{
			// Value expects 1 child implementing any interface that returns a value
			XmlNodeList childNodes = this.GetChildElements(this.metadataNode);
			if (childNodes.Count != 1)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.WrongChildCount,
					this.metadataNode.Name + "~1",
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get value as string
			GrammarBase valueGrammar = GrammarBase.CreateInstance(childNodes[0], null, this);
			long value = 0;

			// Check for each supplied interface
			if (valueGrammar.GetType().GetInterface(typeof(IGrammarInteger).FullName) != null)
			{
				IGrammarInteger intGrammar = (IGrammarInteger)valueGrammar;
				value = intGrammar.EvaluateInteger(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarFloat).FullName) != null)
			{
				IGrammarFloat floatGrammar = (IGrammarFloat)valueGrammar;
				value = Literal.ConvertToInt(floatGrammar.EvaluateFloat(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarString).FullName) != null)
			{
				IGrammarString stringGrammar = (IGrammarString)valueGrammar;
				value = Literal.ConvertToInt(stringGrammar.EvaluateString(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarBoolean).FullName) != null)
			{
				IGrammarBoolean boolGrammar = (IGrammarBoolean)valueGrammar;
				value = Literal.ConvertToInt(boolGrammar.EvaluateBoolean(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarDateTime).FullName) != null)
			{
				IGrammarDateTime dateGrammar = (IGrammarDateTime)valueGrammar;
				value = Literal.ConvertToInt(dateGrammar.EvaluateDateTime(pDataNode));
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
