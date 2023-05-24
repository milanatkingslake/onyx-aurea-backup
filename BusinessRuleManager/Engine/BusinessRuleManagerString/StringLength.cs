// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Gets the length of a string.
	/// </summary>
	public class StringLength
		: GrammarBase,
		IGrammarInteger
	{
		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			// Get string length
			return StringContainer.EvaluateString(this.metadataNode, this.engine, pDataNode, this.namespaceManager).Length;
		}
		#endregion
	}
}
