// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Implements "floatSubtract" grammar.
	/// </summary>
	public class FloatSubtract
		: FloatOperator
	{
		#region Protected methods
		protected override double ApplyOperator(double pLeftValue, double pRightValue)
		{
			return pLeftValue - pRightValue;
		}
		#endregion
	}
}
