// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Base class for simple float operator grammar that
	/// takes 2 float operator
	/// </summary>
	public abstract class FloatOperator
		: OperatorBase<double>,
		IGrammarFloat
	{
		#region Protected methods
		/// <summary>
		/// Override this method to evaluate a child expression
		/// of a defined type.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node.</param>
		/// <param name="pDataNode">Data node.</param>
		/// <returns>Value of specific type.</returns>
		protected override double EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			return FloatContainer.EvaluateFloat(pMetadataNode, this.engine, pDataNode, this.namespaceManager);
		}
		/// <summary>
		/// Override this method to apply an operator 2 values.
		/// </summary>
		/// <param name="pLeftValue">Left value.</param>
		/// <param name="pRightValue">Right value.</param>
		/// <returns>Operator results.</returns>
		protected abstract double ApplyOperator(double pLeftValue, double pRightValue);
		#endregion

		#region IGrammarFloat Members
		public double EvaluateFloat(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(double);

			// Get left and right values
			this.GetValues(pDataNode);

			return this.ApplyOperator(this.leftValue, this.rightValue);
		}
		#endregion
	}
}
