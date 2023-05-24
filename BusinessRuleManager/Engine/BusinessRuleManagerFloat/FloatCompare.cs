// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Base class for float comparison grammar.
	/// </summary>
	public abstract class FloatCompare
		: CompareBase<double>,
		IGrammarBoolean
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
		#endregion
	}
}
