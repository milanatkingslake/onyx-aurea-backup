// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Provide access to require system message details.
	/// </summary>
	public struct SystemMessage
	{
		#region Private constants
		private const int MSGID_BASE = 775000;
		#endregion

		#region Public constants
		/// <summary>
		/// Enumeration of base National Language message IDs.
		/// </summary>
		public enum MessageId
		{
			MissingMetadataFileName = MSGID_BASE,
			ErrorLoadingMetadataFile,
			UnknownClassType,
			UndefinedRuleGrammar,
			InterfaceNotImplemented,
			ErrorCreatingInstance,
			InvalidPropertyValue,
			ErrorConvertingDataType,
			WrongChildCount,
			EvaluatesToEmptyString,
			ErrorAccessingFile,
			MultipleFilesFound,
			ErrorDeletingFile,
			FileNotFound,
			DuplicateFileName,
			ChildWithoutParent,
			FolderNotFound,
			DuplicateFolderName,
			ErrorAccessingFolder,
			ErrorDeletingFolder,
			ErrorLoadingWsdl,
			ErrorParsingServiceDescription,
			ServiceNotFound,
			SOAPActionNotFound,
			ErrorExecutingWSMethod,
			RequestUrlNotFound,
			ErrorParsingResponse,
			OdbcConnectionNotFound,
			OdbcErrorOpeningConnection,
			OdbcErrorExecutingStatement,
			OdbcInvalidDataType,
			OdbcInvalidParameterDirection,
			OdbcNameOrNumberRequired,
			OdbcUnsupportedFieldDataType,
			StringFormatError,
			RepositoryNotFound,
			ErrorParsingInputXml,
			RequiredInputParameterMissing,
			NumberRecordsProcessed,
			ErrorExecutingHTTPPost,
			ErrorExecutingHTTPGet
		}
		#endregion
	}
	/// <summary>
	/// Possible return values for stop exceptions.
	/// </summary>
	public struct BusinessRuleManagerReturnValue
	{
		/// <summary>
		/// Indicates that OEAS step execution should continue after this logical step.
		/// </summary>
		public const string Continue = "continue";
		/// <summary>
		/// Indicates that OEAS step execution should stop after this logical step.
		/// </summary>
		public const string Stop = "stop";
	}
	/// <summary>
	/// Possible standard error type values.
	/// </summary>
	public struct BusinessRuleManagerErrorType
	{
		/// <summary>
		/// An internal component failed.
		/// </summary>
		public const string Internal = "Internal";
		/// <summary>
		/// A component discovered a problem related to data from the client or application.
		/// </summary>
		public const string BusinessLogic = "BusinessLogic";
		/// <summary>
		/// An external component or call failed.
		/// </summary>
		public const string External = "External";
	}
	/// <summary>
	/// Possible standard source type values.
	/// </summary>
	public struct BusinessRuleManagerSourceType
	{
		/// <summary>
		/// A part of data or business logic.
		/// </summary>
		public const string BusinessLogic = "BusinessLogic";
		/// <summary>
		/// The name of a component.
		/// </summary>
		public const string Component = "Component";
		/// <summary>
		/// Any miscellaneous value.
		/// </summary>
		public const string Miscellaneous = "Miscellaneous";
	}
	/// <summary>
	/// Standard attribute names (based on Onyx software standards).
	/// </summary>
	public struct BusinessRuleManagerAttributeName
	{
		/// <summary>
		/// Null attribute (used to indicate when the node value is NULL).
		/// </summary>
		public const string Null = "null";
	}
}
