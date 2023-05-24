// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Base class for simple integer operator grammar that
	/// takes 2 integer operator
	/// </summary>
	public abstract class IntegerOperator
		: OperatorBase<long>,
		IGrammarInteger
	{
		#region Protected methods
		/// <summary>
		/// Override this method to evaluate a child expression
		/// of a defined type.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node.</param>
		/// <param name="pDataNode">Data node.</param>
		/// <returns>Value of specific type.</returns>
		protected override long EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			return IntegerContainer.EvaluateInteger(pMetadataNode, this.engine, pDataNode, this.namespaceManager);
		}
		/// <summary>
		/// Override this method to apply an operator 2 values.
		/// </summary>
		/// <param name="pLeftValue">Left comparison value.</param>
		/// <param name="pRightValue">Right comparison value.</param>
		/// <returns>Operator results.</returns>
		protected abstract long ApplyOperator(long pLeftValue, long pRightValue);
		#endregion

		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(long);

			// Get left and right values
			this.GetValues(pDataNode);

			return this.ApplyOperator(this.leftValue, this.rightValue);
		}
		#endregion
	}
}
