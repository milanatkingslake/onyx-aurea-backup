// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Implements "integerLessThanEqualTo" grammar.
	/// </summary>
	public class IntegerLessThanEqualTo
		: IntegerCompare
	{
		#region Protected methods
		protected override bool CompareValues(long pLeftValue, long pRightValue)
		{
			return pLeftValue <= pRightValue;
		}
		#endregion
	}
}
