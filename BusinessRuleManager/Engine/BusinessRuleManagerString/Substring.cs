// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Change string case to lower case.
	/// </summary>
	public class Substring
		: GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get starting index
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:start", this.namespaceManager);
			int start = (int)IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);

			// Get value
			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			string value = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);

			// Check start is in range
			if (start >= value.Length)
			{
				return string.Empty;
			}

			// Get length (optional)
			childNode = this.metadataNode.SelectSingleNode("brm:length", this.namespaceManager);
			if (childNode != null)
			{
				int length = (int)IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);

				// Check length is in range
				if ((start + length) <= value.Length)
				{
					return value.Substring(start, length);
				}
			}
			
			return value.Substring(start);
		}
		#endregion
	}
}
