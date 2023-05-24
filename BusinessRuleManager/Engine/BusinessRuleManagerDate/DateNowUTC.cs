// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Gets the current date/time.
	/// </summary>
	public class DateNowUTC
		: GrammarBase,
		IGrammarDateTime
	{
		#region IGrammarDateTime Members
		public DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			return DateTime.UtcNow;
		}
		#endregion
	}
}
