using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean
{
	/// <summary>
	/// Implements "and" grammar expression.
	/// </summary>
	public class And
		: GrammarBase,
		IGrammarBoolean
	{
		#region IGrammarBoolean Members
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return true;

			// Expects 1 child implementing IGrammarBoolean
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
			// Evaluate child expression
			IGrammarBoolean boolGrammar;
			foreach (XmlNode configNode in childNodes)
			{
				boolGrammar = (IGrammarBoolean)GrammarBase.CreateInstance(configNode, typeof(IGrammarBoolean), this);
				if (!boolGrammar.EvaluateBoolean(pDataNode))
				{
					return false;
				}
			}

			return true;
		}
		#endregion
	}
}
