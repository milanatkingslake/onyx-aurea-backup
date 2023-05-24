// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Returns part of a date/time value as an integer.
	/// </summary>
	public class DatePart
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
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Get value using DateTimeContainer
			DateTime dateValue = DateTimeContainer.EvaluateDateTime(valueNode, this.engine, pDataNode, this.namespaceManager);

			// Get part from date
			int datePart = 0;
			switch (part)
			{
				case "year":
					datePart = dateValue.Year;
					break;
				case "month":
					datePart = dateValue.Month;
					break;
				case "day":
					datePart = dateValue.Day;
					break;
				case "weekday":
					datePart = (int)dateValue.DayOfWeek;
					break;
				case "hour":
					datePart = dateValue.Hour;
					break;
				case "minute":
					datePart = dateValue.Minute;
					break;
				case "second":
					datePart = dateValue.Second;
					break;
				case "millisecond":
					datePart = dateValue.Millisecond;
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
