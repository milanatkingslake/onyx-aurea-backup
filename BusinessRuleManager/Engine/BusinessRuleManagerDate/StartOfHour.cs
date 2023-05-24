// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Returns the date/time value at the start of an hour.
	/// </summary>
	public class StartOfHour
		: StartOfMinute
	{
		#region IGrammarDateTime Members
		public override DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			DateTime dateValue = base.EvaluateDateTime(pDataNode);
			return dateValue.AddMinutes(-dateValue.Minute);
		}
		#endregion
	}
}
