// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Change string case to lower case.
	/// </summary>
	public class LowerCase
		: StringContainer
	{
		#region IGrammarString Members
		public override string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			return base.EvaluateString(pDataNode).ToLower();
		}
		#endregion
	}
}
