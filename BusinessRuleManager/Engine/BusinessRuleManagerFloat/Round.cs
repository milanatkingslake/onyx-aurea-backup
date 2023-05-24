// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Rounds a floating point value to a specified number of decimal places.
	/// </summary>
	public class Round
		: GrammarBase,
		IGrammarFloat
	{
		#region Public methods
		public double EvaluateFloat(System.Xml.XmlNode pDataNode)
		{
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			double value = FloatContainer.EvaluateFloat(childNode, this.engine, pDataNode, this.namespaceManager);

			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:number", this.namespaceManager);
			long number = IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);

			return Math.Round(value, (int)number);
		}
		#endregion
	}
}
