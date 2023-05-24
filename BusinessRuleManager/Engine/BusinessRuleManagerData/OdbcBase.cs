// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data;
using System.Data.Odbc;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Base class for ODBC connection functionality.
	/// </summary>
	public class OdbcBase
		: GrammarBase
	{
		#region Public constants
		/// <summary>
		/// File paths.
		/// </summary>
		public struct FilePath
		{
			/// <summary>
			/// Path to ODBC metadata
			/// </summary>
			public const string Odbc = "\\odbc";
			/// <summary>
			/// Name of connections file.
			/// </summary>
			public const string Connections = "\\odbc.connections.xml";
		}
		/// <summary>
		/// Cache key prefixes.
		/// </summary>
		public struct CachePrefix
		{
			/// <summary>
			/// Cache prefix for ODBC grammar.
			/// </summary>
			public const string Odbc = "ODBC.";
			/// <summary>
			/// Cache prefix for ODBC connection.
			/// </summary>
			public const string Connection = "Connection.";
			/// <summary>
			/// Cache prefix for ODBC command.
			/// </summary>
			public const string Command = "Command.";
			/// <summary>
			/// Cache prefix for ODBC dataset.
			/// </summary>
			public const string Dataset = "Dataset.";
			/// <summary>
			/// Cache prefix for ODBC row.
			/// </summary>
			public const string Row = "Row.";
			/// <summary>
			/// Cache prefix for ODBC connections metadata.
			/// </summary>
			public const string OdbcConnections = "ODBC_CONNECTIONS_";
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Returns cache key used when temporarily storing the OdbcConnection instance
		/// for ODBC grammar items.
		/// </summary>
		/// <returns>Cache key.</returns>
		protected string GetCacheKey(string psSubPrefix)
		{
			return CachePrefix.Odbc + psSubPrefix + this.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached connection object.
		/// </summary>
		/// <returns>OdbcConnection object from cache.</returns>
		protected System.Data.Odbc.OdbcConnection GetCachedConnection()
		{
			string cacheKey = this.GetCacheKey(CachePrefix.Connection);

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~odbcConnection",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (System.Data.Odbc.OdbcConnection)this.engine.cache.Read(cacheKey);
		}
		/// <summary>
		/// Retrieve the cached command object.
		/// </summary>
		/// <returns>OdbcCommand object from cache.</returns>
		protected OdbcCommand GetCachedCommand()
		{
			string cacheKey = this.GetCacheKey(CachePrefix.Command);

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~odbcCall",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (OdbcCommand)this.engine.cache.Read(cacheKey);
		}
		/// <summary>
		/// Retrieve the cached dataset object.
		/// </summary>
		/// <returns>DataSet object from cache.</returns>
		protected DataSet GetCachedDataset()
		{
			string cacheKey = this.GetCacheKey(CachePrefix.Dataset);

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~odbcCall",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (DataSet)this.engine.cache.Read(cacheKey);
		}
		/// <summary>
		/// Retrieve the cached row object.
		/// </summary>
		/// <returns>DataRow object from cache.</returns>
		protected DataRow GetCachedRow()
		{
			string cacheKey = this.GetCacheKey(CachePrefix.Row);

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~odbcForEachRow",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (DataRow)this.engine.cache.Read(cacheKey);
		}
		/// <summary>
		/// Convert the typed data field into a string representation.
		/// </summary>
		/// <param name="pValue">Value to convert.</param>
		/// <returns>String representation of value.</returns>
		protected string GetTypedValue(object pValue)
		{
			Type type = pValue.GetType();

			if ((type == typeof(string)) ||
				(type == typeof(char)))
			{
				return pValue.ToString();
			}

			if (type == typeof(bool))
			{
				return Literal.ConvertToString((bool)pValue);
			}

			if ((type == typeof(Int16)) ||
				(type == typeof(Int32)) ||
				(type == typeof(Int64)) ||
				(type == typeof(UInt16)) ||
				(type == typeof(UInt32)) ||
				(type == typeof(UInt64)) ||
				(type == typeof(byte)) ||
				(type == typeof(sbyte)))
			{
				return Literal.ConvertToString((long)Convert.ChangeType(pValue, typeof(long)));
			}

			if ((type == typeof(decimal)) ||
				(type == typeof(double)) ||
				(type == typeof(Single)))
			{
				return Literal.ConvertToString((double)Convert.ChangeType(pValue, typeof(double)));
			}

			if (type == typeof(DateTime))
			{
				return Literal.ConvertToString((DateTime)pValue);
			}

			if (type == typeof(Guid))
			{
				return XmlUtil.FormatGuid((Guid)pValue);
			}

			if (type == typeof(DBNull))
			{
				return string.Empty;
			}

			if (type == typeof(byte[]))
			{
				return Literal.ConvertToString((byte[])pValue);
			}

			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.OdbcUnsupportedFieldDataType,
				type.FullName,
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}
		#endregion
	}
}
