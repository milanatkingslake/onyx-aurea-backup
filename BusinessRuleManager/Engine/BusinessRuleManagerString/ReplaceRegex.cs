// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Text.RegularExpressions;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Replace all instances of a search string within
	/// a string value with a replacement string using a
	/// regular expression match.
	/// </summary>
	public class ReplaceRegex :
		GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(System.Xml.XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			XmlNode findNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:find", this.namespaceManager);
			XmlNode replaceNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:replace", this.namespaceManager);
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Get parameters
			string find = StringContainer.EvaluateString(findNode, this.engine, pDataNode, this.namespaceManager);
			string replace = StringContainer.EvaluateString(replaceNode, this.engine, pDataNode, this.namespaceManager);
			string value = StringContainer.EvaluateString(valueNode, this.engine, pDataNode, this.namespaceManager);

			// Replace value using regular expression
			return Regex.Replace(value, find, replace);
		}
		#endregion
	}
}
