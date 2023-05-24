// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Exception class for standard exception handling.
	/// </summary>
	public class BusinessRuleManagerException : ApplicationException
	{
		#region Private fields
		private long m_messageId = 0;
		private string m_messageArguments = "";
		private string m_additionalInfo = "";
		private string m_errorType = "";
		private string m_sourceType = "";
		private string m_sourceName = "";
		#endregion

		#region Public properties
		/// <summary>
		/// Message ID related to the exception.
		/// </summary>
		public long messageId
		{
			get
			{
				return m_messageId;
			}
		}
		/// <summary>
		/// Arguments to be used when retrieving the National Language message string.
		/// </summary>
		public string messageArguments
		{
			get
			{
				return m_messageArguments;
			}
		}
		/// <summary>
		/// Additional information related to the exception.
		/// </summary>
		public string additionalInfo
		{
			get
			{
				return m_additionalInfo;
			}
		}
		/// <summary>
		/// Error type.
		/// </summary>
		public string errorType
		{
			get
			{
				return m_errorType;
			}
		}
		/// <summary>
		/// Source type.
		/// </summary>
		public string sourceType
		{
			get
			{
				return m_sourceType;
			}
		}
		/// <summary>
		/// Source name.
		/// </summary>
		public string sourceName
		{
			get
			{
				return m_sourceName;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor.
		/// </summary>
		public BusinessRuleManagerException() : base()
		{
		}

		/// <summary>
        /// Constructor used when a message ID is provided.
		/// </summary>
		/// <param name="psSource">Source of the exception.</param>
		/// <param name="plMessageId">Message ID to use for the error message.</param>
		/// <param name="psMessageArguments">Semi-colon delimited list of arguments to use when retrieving the National Language error message.</param>
		/// <param name="psAdditionalInfo">Additional error information.</param>
		/// <param name="psErrorType">Error type.</param>
		/// <param name="psSourceType">Error source type.</param>
		/// <param name="psSourceName">Error source name.</param>
		public BusinessRuleManagerException(string psSource,
			long plMessageId,
			string psMessageArguments,
			string psAdditionalInfo,
			string psErrorType,
			string psSourceType,
			string psSourceName) : base()
		{
			this.HResult = 0;

			// Set the details of the exception
			this.Source = psSource;
			this.m_messageId = plMessageId;
			this.m_messageArguments = psMessageArguments;
			this.m_additionalInfo = psAdditionalInfo;
			this.m_errorType = psErrorType;
			this.m_sourceType = psSourceType;
			this.m_sourceName = psSourceName;
		}

		/// <summary>
		/// Constructor used when a message ID is provided
		/// and the exception is based on an inner exception.
		/// </summary>
		/// <param name="psSource">Source of the exception.</param>
		/// <param name="plMessageId">Message ID to use for the error message.</param>
		/// <param name="psMessageArguments">Semi-colon delimited list of arguments to use when retrieving the National Language error message.</param>
		/// <param name="psAdditionalInfo">Additional error information.</param>
		/// <param name="psErrorType">Error type.</param>
		/// <param name="psSourceType">Error source type.</param>
		/// <param name="psSourceName">Error source name.</param>
		/// <param name="pInnerException">Exception that is the cause of the current exception.</param>
		public BusinessRuleManagerException(string psSource,
			long plMessageId,
			string psMessageArguments,
			string psAdditionalInfo,
			string psErrorType,
			string psSourceType,
			string psSourceName,
			Exception pInnerException)
			: base("", pInnerException)
		{
			this.HResult = 0;

			// Set the details of the exception
			this.Source = psSource;
			this.m_messageId = plMessageId;
			this.m_messageArguments = psMessageArguments;
			this.m_additionalInfo = psAdditionalInfo;
			this.m_errorType = psErrorType;
			this.m_sourceType = psSourceType;
			this.m_sourceName = psSourceName;
		}

		/// <summary>
        /// Constructor used when a message ID is not provided.
		/// </summary>
		/// <param name="psSource">Source of the exception.</param>
		/// <param name="psMessage">Error message for the exception.</param>
		/// <param name="psAdditionalInfo">Additional error information.</param>
		public BusinessRuleManagerException(string psSource,
			string psMessage,
			string psAdditionalInfo) : base(psMessage)
		{
			this.HResult = 0;

			// Set the details of the exception
			this.Source = psSource;
			this.m_additionalInfo = psAdditionalInfo;
		}

		/// <summary>
		/// Constructor used when a message ID is not provided
		/// and the exception is based on an inner exception.
		/// </summary>
		/// <param name="psSource">Source of the exception.</param>
		/// <param name="psMessage">Error message for the exception.</param>
		/// <param name="psAdditionalInfo">Additional error information.</param>
		/// <param name="pInnerException">Exception that is the cause of the current exception.</param>
		public BusinessRuleManagerException(string psSource,
			string psMessage,
			string psAdditionalInfo,
			Exception pInnerException)
			: base(psMessage, pInnerException)
		{
			this.HResult = 0;

			// Set the details of the exception
			this.Source = psSource;
			this.m_additionalInfo = psAdditionalInfo;
		}
		#endregion
	}
}
