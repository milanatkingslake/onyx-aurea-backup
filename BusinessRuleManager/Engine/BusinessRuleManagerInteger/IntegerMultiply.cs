// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Implements "integerMultiply" grammar.
	/// </summary>
	public class IntegerMultiply
		: IntegerOperator
	{
		#region Protected methods
		protected override long ApplyOperator(long pLeftValue, long pRightValue)
		{
			return pLeftValue * pRightValue;
		}
		#endregion
	}
}
