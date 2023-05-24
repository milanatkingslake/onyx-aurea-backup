// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using System.Data.Odbc;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Returns the value of an ODBC parameter from the current ODBC command.
	/// </summary>
	public class OdbcParameterValue
		: OdbcBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get command
			OdbcCommand command = this.GetCachedCommand();

			// Get name
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			string name = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);

			// Return the value of the parameter
			return this.GetTypedValue(command.Parameters[name].Value);
		}
		#endregion
	}
}
