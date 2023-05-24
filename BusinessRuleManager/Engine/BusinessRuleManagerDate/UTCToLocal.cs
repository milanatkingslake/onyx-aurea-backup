// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Converts a date/time value from UTC to local timezone.
	/// </summary>
	public class UTCToLocal
		: DateTimeContainer
	{
		#region IGrammarDateTime Members
		public override DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			return base.EvaluateDateTime(pDataNode).ToLocalTime();
		}
		#endregion
	}
}
