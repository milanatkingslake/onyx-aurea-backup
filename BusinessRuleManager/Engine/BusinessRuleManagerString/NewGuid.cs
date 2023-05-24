// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Generate a new GUID value as a string.
	/// </summary>
	public class NewGuid
		: GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			return Guid.NewGuid().ToString("D");
		}
		#endregion
	}
}
