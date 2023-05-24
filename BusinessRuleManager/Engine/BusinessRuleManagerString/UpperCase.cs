// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Change string case to upper case.
	/// </summary>
	public class UpperCase
		: StringContainer
	{
		#region IGrammarString Members
		public override string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			return base.EvaluateString(pDataNode).ToUpper();
		}
		#endregion
	}
}
