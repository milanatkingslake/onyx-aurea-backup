// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Implements "stringEqualTo" grammar.
	/// </summary>
	public class StringEqualTo
		: StringCompare
	{
		#region Protected methods
		protected override bool CompareValues(string pLeftValue, string pRightValue)
		{
			return pLeftValue == pRightValue;
		}
		#endregion
	}
}
