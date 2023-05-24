// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Converts a non-floating point value to a floating point value.
	/// </summary>
	public class ToFloat
		: GrammarBase,
		IGrammarFloat
	{
		#region Public methods
		public double EvaluateFloat(System.Xml.XmlNode pDataNode)
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
			double value = 0;

			// Check for each supplied interface
			if (valueGrammar.GetType().GetInterface(typeof(IGrammarFloat).FullName) != null)
			{
				IGrammarFloat floatGrammar = (IGrammarFloat)valueGrammar;
				value = floatGrammar.EvaluateFloat(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarInteger).FullName) != null)
			{
				IGrammarInteger intGrammar = (IGrammarInteger)valueGrammar;
				value = Literal.ConvertToFloat(intGrammar.EvaluateInteger(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarString).FullName) != null)
			{
				IGrammarString stringGrammar = (IGrammarString)valueGrammar;
				value = Literal.ConvertToFloat(stringGrammar.EvaluateString(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarBoolean).FullName) != null)
			{
				IGrammarBoolean boolGrammar = (IGrammarBoolean)valueGrammar;
				value = Literal.ConvertToFloat(boolGrammar.EvaluateBoolean(pDataNode));
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarDateTime).FullName) != null)
			{
				IGrammarDateTime dateGrammar = (IGrammarDateTime)valueGrammar;
				value = Literal.ConvertToFloat(dateGrammar.EvaluateDateTime(pDataNode));
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
