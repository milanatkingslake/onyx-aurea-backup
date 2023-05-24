// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Converts an ODBC table to an Onyx rowSet.
	/// </summary>
	public class OdbcConvertToRowSet
		: OdbcBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get dataset
			DataSet dataSet = this.GetCachedDataset();

			// Check there is a data table
			if (dataSet.Tables.Count == 0)
			{
				return;
			}

			// Get data table, return column count
			DataTable table = dataSet.Tables[0];

			// Get starting national language message ID
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:msgId", this.namespaceManager);
			int msgId = (int)IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);

			// Get path
			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);
			string path = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					childNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Use path to get 1st matching node
			XmlNode destNode = XmlUtil.GetRequiredNode(pDataNode, path);
			// Append a rowSet instance
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			XmlNode rowSetNode = XmlUtil.AppendXmlFromString(destNode,
				stepComponent.dictionaryCache.GetObjectInstance("rowSet"));

			// Set rowCount & columnCount attributes
			XmlUtil.SetChildNodeValue(rowSetNode, "@rowCount", table.Rows.Count.ToString(), true);
			XmlUtil.SetChildNodeValue(rowSetNode, "@columnCount", table.Columns.Count.ToString(), true);

			// Add column definitions
			XmlNode columnDefNode;
			XmlNode columnDefsNode = XmlUtil.GetRequiredNode(rowSetNode, "columnDefinitions");
			columnDefsNode.RemoveAll();

			// Get National Language messages
			Array messages = null;
			if (msgId > 0)
			{
				messages = stepComponent.natLangCache.RetrieveStringList(msgId, msgId + table.Columns.Count - 1);
			}

			foreach (DataColumn column in table.Columns)
			{
				// Add column definition instance
				columnDefNode = XmlUtil.AppendXmlFromString(columnDefsNode,
					stepComponent.dictionaryCache.GetObjectInstance("columnDefinition"));

				// Set definition properties
				if (msgId > 0)
				{
					XmlUtil.SetChildNodeValue(columnDefNode, "columnHeading", messages.GetValue(column.Ordinal, 1).ToString(), true);
				}
				XmlUtil.SetChildNodeValue(columnDefNode, "columnName", column.ColumnName, true);
				XmlUtil.SetChildNodeValue(columnDefNode, "columnOrdinal", (column.Ordinal + 1).ToString(), true);
				XmlUtil.SetChildNodeValue(columnDefNode, "columnType", this.GetDataTypeName(column.DataType), true);
			}

			// Add row data
			XmlNode rowNode;
			XmlNode rowsNode = XmlUtil.GetRequiredNode(rowSetNode, "rows");
			rowsNode.RemoveAll();

			foreach (DataRow row in table.Rows)
			{
				// Add column definition instance
				rowNode = XmlUtil.AddChildNode(rowsNode, "row");

				for (int i = 0; i < table.Columns.Count; i++)
				{
					XmlUtil.SetChildNodeValue(rowNode, "c" + i.ToString(), this.GetTypedValue(row[i]), true);
				}
			}
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Dynamically determine the OEAS datatype based on the returned ODBC column type.
		/// </summary>
		/// <param name="pType">Column data type.</param>
		/// <returns>OEAS data type.</returns>
		protected string GetDataTypeName(Type pType)
		{
			if ((pType == typeof(string)) ||
				(pType == typeof(char)))
			{
				return "string";
			}

			if (pType == typeof(bool))
			{
				return "boolean";
			}

			if ((pType == typeof(Int16)) ||
				(pType == typeof(Int32)) ||
				(pType == typeof(Int64)) ||
				(pType == typeof(UInt16)) ||
				(pType == typeof(UInt32)) ||
				(pType == typeof(UInt64)) ||
				(pType == typeof(byte)) ||
				(pType == typeof(sbyte)))
			{
				return "i4";
			}

			if (pType == typeof(decimal))
			{
				return "number";
			}

			if ((pType == typeof(double)) ||
				(pType == typeof(Single)))
			{
				return "float";
			}

			if (pType == typeof(DateTime))
			{
				return "dateTime";
			}

			if (pType == typeof(Guid))
			{
				return "uuid";
			}

			if (pType == typeof(byte[]))
			{
				return "string";
			}

			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.OdbcUnsupportedFieldDataType,
				pType.FullName,
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}
		#endregion
	}
}
