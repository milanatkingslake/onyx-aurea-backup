using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Rounds a floating point value to a specified number of decimal places.
	/// </summary>
	public class Ceiling
		: GrammarBase,
		IGrammarFloat
	{
		#region Public methods
		public double EvaluateFloat(System.Xml.XmlNode pDataNode)
		{
			return Math.Ceiling(FloatContainer.EvaluateFloat(this.metadataNode, this.engine, pDataNode, this.namespaceManager));
		}
		#endregion
	}
}
