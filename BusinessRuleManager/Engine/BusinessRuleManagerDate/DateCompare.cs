// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Base class for date comparison grammar.
	/// </summary>
	public abstract class DateCompare
		: CompareBase<DateTime>,
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
		protected override DateTime EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			return DateTimeContainer.EvaluateDateTime(pMetadataNode, this.engine, pDataNode, this.namespaceManager);
		}
		#endregion
	}
}
