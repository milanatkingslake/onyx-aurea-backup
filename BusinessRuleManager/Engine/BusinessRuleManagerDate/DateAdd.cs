// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Adds a specified date/time amount to a provided date/time value.
	/// </summary>
	public class DateAdd
		: GrammarBase,
		IGrammarDateTime
	{
		#region IGrammarDateTime Members
		public DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			// Get configured details
			string part = XmlUtil.GetRequiredNodeValue(this.metadataNode, "brm:part", this.namespaceManager);
			XmlNode numberNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:number", this.namespaceManager);
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Get number using IntegerContainer
			int number = (int)IntegerContainer.EvaluateInteger(numberNode, this.engine, pDataNode, this.namespaceManager);

			// Get value using DateTimeContainer
			DateTime dateValue = DateTimeContainer.EvaluateDateTime(valueNode, this.engine, pDataNode, this.namespaceManager);

			// Add part to date
			switch (part)
			{
				case "year":
					dateValue = dateValue.AddYears(number);
					break;
				case "month":
					dateValue = dateValue.AddMonths(number);
					break;
				case "week":
					dateValue = dateValue.AddDays(number * 7);
					break;
				case "day":
					dateValue = dateValue.AddDays(number);
					break;
				case "hour":
					dateValue = dateValue.AddHours(number);
					break;
				case "minute":
					dateValue = dateValue.AddMinutes(number);
					break;
				case "second":
					dateValue = dateValue.AddSeconds(number);
					break;
				case "millisecond":
					dateValue = dateValue.AddMilliseconds(number);
					break;
				default:
					// Throw exception if part value is invalid
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.InvalidPropertyValue,
						"dateAdd~part~" + part,
						metadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.BusinessLogic,
						MethodBase.GetCurrentMethod().Name);
			}

			return dateValue;
		}
		#endregion
	}
}
