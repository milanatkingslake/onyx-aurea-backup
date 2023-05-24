// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Implements "floatGreaterThanEqualTo" grammar.
	/// </summary>
	public class FloatGreaterThanEqualTo
		: FloatCompare
	{
		#region Protected methods
		protected override bool CompareValues(double pLeftValue, double pRightValue)
		{
			return pLeftValue >= pRightValue;
		}
		#endregion
	}
}
