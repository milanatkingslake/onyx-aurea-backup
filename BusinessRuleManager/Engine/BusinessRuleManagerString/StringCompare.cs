// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Base class for string comparison grammar.
	/// </summary>
	public abstract class StringCompare
		: CompareBase<string>,
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
		protected override string EvaluateValue(XmlNode pMetadataNode, XmlNode pDataNode)
		{
			return StringContainer.EvaluateString(pMetadataNode, this.engine, pDataNode, this.namespaceManager);
		}
		#endregion
	}
}
