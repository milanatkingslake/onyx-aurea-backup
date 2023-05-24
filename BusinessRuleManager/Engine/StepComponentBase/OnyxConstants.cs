// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Possible return values from OEAS step component.
	/// </summary>
	public struct StepReturnValue
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
	/// Possible step package status type values.
	/// </summary>
	public struct StepPackageStatusType
	{
		/// <summary>
		/// Indicates method was successful.
		/// </summary>
		public const string Success = "success";
		/// <summary>
		/// Indicates method was successful and informational messages
		/// were returned.
		/// </summary>
		public const string SuccessWithInfo = "successWithInfo";
		/// <summary>
		/// Indicates method failed.
		/// </summary>
		public const string Failure = "failure";
	}
	/// <summary>
	/// Possible step package error severity values.
	/// </summary>
	public struct StepPackageErrorSeverity
	{
		/// <summary>
		/// Warning.
		/// </summary>
		public const string Warning = "warning";
		/// <summary>
		/// Failure.
		/// </summary>
		public const string Failure = "failure";
	}
	/// <summary>
	/// Possible step package error type values.
	/// </summary>
	public struct StepPackageErrorType
	{
		/// <summary>
		/// A COM call within the component failed.
		/// </summary>
		public const string HResult = "oetHresult";
		/// <summary>
		/// An internal component failed.
		/// </summary>
		public const string ReturnValue = "oetReturnValue";
		/// <summary>
		/// A component discovered a problem with the data submitted by the client.
		/// </summary>
		public const string BusinessLogic = "oetBusinessLogic";
		/// <summary>
		/// The stored procedure used by the step component returned a failure message.
		/// </summary>
		public const string StoredProcedure = "oetStoredProcedure";
	}
	/// <summary>
	/// Possible step package source type values.
	/// </summary>
	public struct StepPackageSourceType
	{
		/// <summary>
		/// A stored procedure name.
		/// </summary>
		public const string StoredProcedure = "ostStoredProcedure";
		/// <summary>
		/// The ProgId of a COM component.
		/// </summary>
		public const string Component = "ostComponent";
		/// <summary>
		/// The name of a method from the Windows API.
		/// </summary>
		public const string WinAPI = "ostWinAPI";
		/// <summary>
		/// Any miscellaneous value.
		/// </summary>
		public const string BusinessLogic = "ostMisc";
	}
	/// <summary>
	/// Standard node names for Onyx step package.
	/// </summary>
	public struct StepPackageNodeName
	{
		/// <summary>
		/// Base step package.
		/// </summary>
		public const string StepPackage = "stepPackage";
		/// <summary>
		/// Child nodes of base step package.
		/// </summary>
		public struct _StepPackage
		{
			/// <summary>
			/// Step package context information.
			/// </summary>
			public const string Context = "context";
			/// <summary>
			/// Child nodes in step package context information.
			/// </summary>
			public struct _Context
			{
				/// <summary>
				/// Onyx session ID.
				/// </summary>
				public const string SessionID = "sessionId";
				/// <summary>
				/// Onyx user ID.
				/// </summary>
				public const string UserID = "userId";
				/// <summary>
				/// Partner user indicator.
				/// </summary>
				public const string PartnerUser = "partnerUser";
				/// <summary>
				/// Onyx site ID.
				/// </summary>
				public const string SiteID = "siteId";
				/// <summary>
				/// Onyx logical application name.
				/// </summary>
				public const string ApplicationName = "applicationName";
				/// <summary>
				/// Source application.
				/// </summary>
				public const string Source = "source";
				/// <summary>
				/// Preferred language code.
				/// </summary>
				public const string PreferredLanguage = "preferredLanguage";
				/// <summary>
				/// Original calling context.
				/// </summary>
				public const string OriginalUser = "originalUser";
				/// <summary>
				/// Onyx security permissions bitmask.
				/// </summary>
				public const string PermissionMask = "permissionMask";
				/// <summary>
				/// Event log name.
				/// </summary>
				public const string LogName = "logName";
				/// <summary>
				/// Log setting value.
				/// </summary>
				public const string LogSettings = "logSettings";
				/// <summary>
				/// Impersonating user ID.
				/// </summary>
				public const string ImpersonatingUser = "impersonatingUser";
				/// <summary>
				/// Seconds remaining before Onyx session will time out.
				/// </summary>
				public const string SessionSecondsRemaining = "sessionSecondsRemaining";
				/// <summary>
				/// Unique identifier for the current OTM method call.
				/// </summary>
				public const string OtmID = "otmId";
			}
			/// <summary>
			/// Input parameters.
			/// </summary>
			public const string Parameters = "parameters";
			/// <summary>
			/// Return XML details.
			/// </summary>
			public const string ReturnXml = "returnXml";
			/// <summary>
			/// Child nodes in return XML details.
			/// </summary>
			public struct _ReturnXml
			{
				/// <summary>
				/// Output parameters.
				/// </summary>
				public const string ParametersReturn = "parametersReturn";
				/// <summary>
				/// Logical method call status information.
				/// </summary>
				public const string MethodStatus = "methodStatus";
				/// <summary>
				/// Child nodes in logical method call status information.
				/// </summary>
				public struct _MethodStatus
				{
					/// <summary>
					/// Status type.
					/// </summary>
					public const string StatusType = "statusType";
					/// <summary>
					/// Return message.
					/// </summary>
					public const string Message = "message";
					/// <summary>
					/// Child nodes in return message.
					/// </summary>
					public struct _Message
					{
						/// <summary>
						/// ID of message.
						/// </summary>
						public const string MessageID = "messageID";
						/// <summary>
						/// Text of message.
						/// </summary>
						public const string MessageText = "messageText";
						/// <summary>
						/// UTC timestamp when message was returned.
						/// </summary>
						public const string Timestamp = "timestamp";
					}
					/// <summary>
					/// Return warning or error.
					/// </summary>
					public const string Error = "error";
					/// <summary>
					/// Child nodes in return warning or error.
					/// </summary>
					public struct _Error
					{
						/// <summary>
						/// Error number.
						/// </summary>
						public const string ErrorNumber = "errorNumber";
						/// <summary>
						/// Error type.
						/// </summary>
						public const string ErrorType = "errorType";
						/// <summary>
						/// Error description.
						/// </summary>
						public const string ErrorDescription = "errorDescription";
						/// <summary>
						/// National language message ID.
						/// </summary>
						public const string NatLangID = "natLangId";
						/// <summary>
						/// Severity of error.
						/// </summary>
						public const string Severity = "severity";
						/// <summary>
						/// Name of error source.
						/// </summary>
						public const string SourceName = "sourceName";
						/// <summary>
						/// Type of error source.
						/// </summary>
						public const string SourceType = "sourceType";
						/// <summary>
						/// UTC timestamp when error was reported.
						/// </summary>
						public const string Timestamp = "timestamp";
					}
				}
			}
		}
	}
	/// <summary>
	/// Standard attribute names for Onyx step package.
	/// </summary>
	public struct StepPackageAttributeName
	{
		/// <summary>
		/// Association ID.
		/// </summary>
		public const string AssociationID = "associationId";
		/// <summary>
		/// Null attribute (used to indicate when the node value is NULL).
		/// </summary>
		public const string Null = "null";
		/// <summary>
		/// Used to indicate the content of a logical object.
		/// </summary>
		public const string Content = "content";
	}
	/// <summary>
	/// XPaths to use for step package nodes.
	/// </summary>
	public struct StepPackageXPath
	{
		/// <summary>
		/// Base step package.
		/// </summary>
		public const string StepPackage = "/" + StepPackageNodeName.StepPackage;
		/// <summary>
		/// Context.
		/// </summary>
		public const string Context = StepPackage + "/" + StepPackageNodeName._StepPackage.Context;
		/// <summary>
		/// Input parameters.
		/// </summary>
		public const string Parameters = StepPackage + "/" + StepPackageNodeName._StepPackage.Parameters;
		/// <summary>
		/// Return XML.
		/// </summary>
		public const string ReturnXml = StepPackage + "/" + StepPackageNodeName._StepPackage.ReturnXml;
		/// <summary>
		/// Return parameters.
		/// </summary>
		public const string ParametersReturn = ReturnXml + "/" + StepPackageNodeName._StepPackage._ReturnXml.ParametersReturn;
		/// <summary>
		/// Method status.
		/// </summary>
		public const string MethodStatus = ReturnXml + "/" + StepPackageNodeName._StepPackage._ReturnXml.MethodStatus;
		/// <summary>
		/// Status type.
		/// </summary>
		public const string StatusType = MethodStatus + "/" + StepPackageNodeName._StepPackage._ReturnXml._MethodStatus.StatusType;
	}
	/// <summary>
	/// Common step additional data values.
	/// </summary>
	public struct StepAdditionalDataValue
	{
		/// <summary>
		/// Step object.
		/// </summary>
		public const string StepObject = "stepObject";
		/// <summary>
		/// Step method.
		/// </summary>
		public const string StepMethod = "stepMethod";
		/// <summary>
		/// Data path (path to step data in input/output parameters).
		/// </summary>
		public const string DataPath = "dataPath";
	}
	/// <summary>
	/// Names of standard Onyx logical methods.
	/// </summary>
	public struct LogicalMethodName
	{
		/// <summary>
		/// Insert.
		/// </summary>
		public const string Insert = "insert";
		/// <summary>
		/// Update.
		/// </summary>
		public const string Update = "update";
		/// <summary>
		/// Delete.
		/// </summary>
		public const string Delete = "delete";
		/// <summary>
		/// Retrieve.
		/// </summary>
		public const string Retrieve = "retrieve";
		/// <summary>
		/// Retrieve a list.
		/// </summary>
		public const string RetrieveList = "retrieveList";
		/// <summary>
		/// Retrieve a collection.
		/// </summary>
		public const string RetrieveCollection = "retrieveCollection";
		/// <summary>
		/// Save a collection.
		/// </summary>
		public const string SaveCollection = "saveCollection";
	}
}
