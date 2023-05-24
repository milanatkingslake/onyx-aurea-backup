// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Base class for operator grammar.
	/// </summary>
	public abstract class OperatorBase<T>
		: GrammarBase
	{
		#region Private fields
		private T m_leftValue = default(T);
		private T m_rightValue = default(T);
		#endregion

		#region Protected properties
		/// <summary>
		/// Left comparison value.
		/// </summary>
		protected T leftValue
		{
			get
			{
				return m_leftValue;
			}
			set
			{
				m_leftValue = value;
			}
		}
		/// <summary>
		/// Right comparison value.
		/// </summary>
		protected T rightValue
		{
			get
			{
				return m_rightValue;
			}
			set
			{
				m_rightValue = value;
			}
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Gets the left and right values for the operator.
		/// </summary>
		protected void GetValues(XmlNode pDataNode)
		{
			// Get left, right values - use type-specific override in final class
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:left", this.namespaceManager);
			this.leftValue = this.EvaluateValue(valueNode, pDataNode);

			valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:right", this.namespaceManager);
			this.rightValue = this.EvaluateValue(valueNode, pDataNode);
		}
		/// <summary>
		/// Override this method to evaluate a child expression
		/// of a defined type.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node.</param>
		/// <param name="pDataNode">Data node.</param>
		/// <returns>Value of specific type.</returns>
		protected abstract T EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode);
		#endregion
	}
}
