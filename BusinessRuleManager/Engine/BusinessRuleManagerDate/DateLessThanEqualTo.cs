// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Implements "dateLessThanEqualTo" grammar.
	/// </summary>
	public class DateLessThanEqualTo
		: DateCompare
	{
		#region Protected methods
		protected override bool CompareValues(DateTime pLeftValue, DateTime pRightValue)
		{
			return pLeftValue <= pRightValue;
		}
		#endregion
	}
}
