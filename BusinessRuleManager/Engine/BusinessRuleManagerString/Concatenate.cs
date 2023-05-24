// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Concatenate string values.
	/// </summary>
	public class Concatenate :
		GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(System.Xml.XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Expects 1 or more children implementing IGrammarString
			XmlNodeList childNodes = this.GetChildElements();
			if (childNodes.Count == 0)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.WrongChildCount,
					this.metadataNode.Name + "~1+",
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}
			// Process all child string values, concatenate together
			IGrammarString stringGrammar;
			string result = string.Empty;

			foreach (XmlNode configNode in childNodes)
			{
				stringGrammar = (IGrammarString)GrammarBase.CreateInstance(configNode, typeof(IGrammarString), this);
				result += stringGrammar.EvaluateString(pDataNode);
			}

			return result;
		}
		#endregion
	}
}
