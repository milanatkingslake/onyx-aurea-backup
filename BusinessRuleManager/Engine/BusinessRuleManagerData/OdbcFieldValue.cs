// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using System.Data;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Returns the value of an ODBC field from the current ODBC data row.
	/// </summary>
	public class OdbcFieldValue
		: OdbcBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get row
			DataRow row = this.GetCachedRow();

			// Get name
			XmlNode childNode = this.metadataNode.SelectSingleNode("brm:name", this.namespaceManager);
			if (childNode != null)
			{
				// Return the value of the field by name
				string name = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);
				return this.GetTypedValue(row[name]);
			}

			// Get number
			childNode = this.metadataNode.SelectSingleNode("brm:number", this.namespaceManager);
			if (childNode != null)
			{
				// Return the value of the field by number
				int number = (int)IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);
				return this.GetTypedValue(row[number]);
			}

			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.OdbcNameOrNumberRequired,
				"",
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}
		#endregion
	}
}
