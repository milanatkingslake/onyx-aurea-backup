// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Implements "integerLessThan" grammar.
	/// </summary>
	public class IntegerLessThan
		: IntegerCompare
	{
		#region Protected methods
		protected override bool CompareValues(long pLeftValue, long pRightValue)
		{
			return pLeftValue < pRightValue;
		}
		#endregion
	}
}
