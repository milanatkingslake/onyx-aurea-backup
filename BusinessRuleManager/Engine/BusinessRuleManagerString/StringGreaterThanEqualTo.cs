// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Implements "stringGreaterThanEqualTo" grammar.
	/// </summary>
	public class StringGreaterThanEqualTo
		: StringCompare
	{
		#region Protected methods
		protected override bool CompareValues(string pLeftValue, string pRightValue)
		{
			return pLeftValue.CompareTo(pRightValue) >= 0;
		}
		#endregion
	}
}
