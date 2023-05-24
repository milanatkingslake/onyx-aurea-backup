using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Converts a date/time value from local timezone to UTC.
	/// </summary>
	public class LocalToUTC
		: DateTimeContainer
	{
		#region IGrammarDateTime Members
		public override DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			return base.EvaluateDateTime(pDataNode).ToUniversalTime();
		}
		#endregion
	}
}
