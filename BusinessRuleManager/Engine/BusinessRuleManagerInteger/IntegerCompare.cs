// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Base class for integer comparison grammar.
	/// </summary>
	public abstract class IntegerCompare
		: CompareBase<long>,
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
		protected override long EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			return IntegerContainer.EvaluateInteger(pMetadataNode, this.engine, pDataNode, this.namespaceManager);
		}
		#endregion
	}
}
