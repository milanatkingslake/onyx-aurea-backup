// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Converts a value to a date/time value.
	/// </summary>
	public class ToDateTime
		: GrammarBase,
		IGrammarDateTime
	{
		#region Public methods
		public DateTime EvaluateDateTime(System.Xml.XmlNode pDataNode)
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

			// Get value as date/time
			GrammarBase valueGrammar = GrammarBase.CreateInstance(childNodes[0], null, this);
			DateTime value = default(DateTime);

			// Check for each supplied interface
			if (valueGrammar.GetType().GetInterface(typeof(IGrammarDateTime).FullName) != null)
			{
				IGrammarDateTime dateGrammar = (IGrammarDateTime)valueGrammar;
				value = dateGrammar.EvaluateDateTime(pDataNode);
			}
			else if (valueGrammar.GetType().GetInterface(typeof(IGrammarString).FullName) != null)
			{
				IGrammarString stringGrammar = (IGrammarString)valueGrammar;
				value = Literal.ConvertToDateTime(stringGrammar.EvaluateString(pDataNode));
			}
			else
			{
				// Throw exception if an invalid message type was requested
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.InterfaceNotImplemented,
					valueGrammar.GetType().FullName + "~*IGrammarString or IGrammarDateTime*",
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
