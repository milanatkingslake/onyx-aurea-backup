// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Rounds a floating point value to a specified number of decimal places.
	/// </summary>
	public class Floor
		: GrammarBase,
		IGrammarFloat
	{
		#region Public methods
		public double EvaluateFloat(System.Xml.XmlNode pDataNode)
		{
			return Math.Floor(FloatContainer.EvaluateFloat(this.metadataNode, this.engine, pDataNode, this.namespaceManager));
		}
		#endregion
	}
}
