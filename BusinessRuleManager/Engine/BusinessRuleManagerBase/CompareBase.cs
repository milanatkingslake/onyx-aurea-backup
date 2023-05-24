// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Base class for comparison grammar.
	/// </summary>
	public abstract class CompareBase<T>
		: OperatorBase<T>,
		IGrammarBoolean
	{
		#region IGrammarBoolean Members
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(bool);

			// Get left and right values
			this.GetValues(pDataNode);

			return this.CompareValues(this.leftValue, this.rightValue);
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Override this method to compare 2 values.
		/// </summary>
		/// <param name="pLeftValue">Left comparison value.</param>
		/// <param name="pRightValue">Right comparison value.</param>
		/// <returns>True if the comparison returns true.</returns>
		protected abstract bool CompareValues(T pLeftValue, T pRightValue);
		#endregion
	}
}
