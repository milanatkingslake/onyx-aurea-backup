// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Returns the value of an CData XML node converted to the type required
	/// by the grammar interfaces.
	/// Inherits from GetNodeValue to provide data type conversions.
	/// </summary>
	public class GetCDataNodeValue
		: GetNodeValue
	{
		#region IGrammarString Members
		public override string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get path
			string path = this.GetPath(pDataNode);

			// Find node
			XmlNode childNode = pDataNode.SelectSingleNode(path);
			if (childNode == null)
			{
				return default(string);
			}
			if (!childNode.HasChildNodes)
			{
				return default(string);
			}

			// Parse contents of CDATA section using XML fragment
			return childNode.FirstChild.InnerText;
		}
		#endregion
	}
}
