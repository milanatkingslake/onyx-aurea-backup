// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using Microsoft.VisualBasic;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Returns a part of the difference between 2 date/time values.
	/// </summary>
	public class DateDiff
		: GrammarBase,
		IGrammarInteger
	{
		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			// Get configured details
			string part = XmlUtil.GetRequiredNodeValue(this.metadataNode, "brm:part", this.namespaceManager);
			XmlNode leftNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:left", this.namespaceManager);
			XmlNode rightNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:right", this.namespaceManager);

			// Get value using DateTimeContainer
			DateTime leftDate = DateTimeContainer.EvaluateDateTime(leftNode, this.engine, pDataNode, this.namespaceManager);
			DateTime rightDate = DateTimeContainer.EvaluateDateTime(rightNode, this.engine, pDataNode, this.namespaceManager);
			TimeSpan dateDiff = leftDate - rightDate;
			DateTime diffDate = leftDate.AddTicks(-rightDate.Ticks);

			// Get part from date
			long datePart = 0;
			switch (part)
			{
				case "year":
					datePart = DateAndTime.DateDiff(DateInterval.Year, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "month":
					datePart = DateAndTime.DateDiff(DateInterval.Month, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "day":
					datePart = DateAndTime.DateDiff(DateInterval.Day, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "hour":
					datePart = DateAndTime.DateDiff(DateInterval.Hour, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "minute":
					datePart = DateAndTime.DateDiff(DateInterval.Minute, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "second":
					datePart = DateAndTime.DateDiff(DateInterval.Second, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System);
					break;
				case "millisecond":
					datePart = DateAndTime.DateDiff(DateInterval.Second, rightDate, leftDate, FirstDayOfWeek.System, FirstWeekOfYear.System) * 1000 +
						(leftDate - rightDate).Milliseconds;
					break;
				default:
					// Throw exception if part value is invalid
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.InvalidPropertyValue,
						metadataNode.Name + "~part~" + part,
						metadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.BusinessLogic,
						MethodBase.GetCurrentMethod().Name);
			}

			return datePart;
		}
		#endregion
	}
}
