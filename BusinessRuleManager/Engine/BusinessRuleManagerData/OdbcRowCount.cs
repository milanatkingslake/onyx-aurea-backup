// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using System.Data;
using System.Data.Odbc;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Returns the count of rows returned from an ODBC query.
	/// </summary>
	public class OdbcRowCount
		: OdbcBase,
		IGrammarInteger
	{
		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(long);

			// Get dataset
			DataSet dataSet = this.GetCachedDataset();

			// Check there is a data table
			if (dataSet.Tables.Count == 0)
			{
				return 0;
			}

			// Get data table, return column count
			DataTable table = dataSet.Tables[0];
			return table.Rows.Count;
		}
		#endregion
	}
}
