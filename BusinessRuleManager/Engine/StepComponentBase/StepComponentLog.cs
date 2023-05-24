// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Diagnostics;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Class to manage Windows Event Log.
	/// </summary>
	public class StepComponentLog
	{
		#region Public constants
		/// <summary>
		/// Possible values for debug log type.
		/// </summary>
		public struct DebugLogType
		{
			/// <summary>
			/// Method or component entry.
			/// </summary>
			public const string Enter = "Enter";
			/// <summary>
			/// Method or component progress.
			/// </summary>
			public const string Progress = "Progress";
			/// <summary>
			/// Method or component exit.
			/// </summary>
			public const string Exit = "Exit";
		}
		#endregion

		#region Private constants
		/// <summary>
		/// Base ID for Onyx event instances.
		/// </summary>
		private const long ONYX_EVENT_INSTANCE_ID_BASE = 1000;
		/// <summary>
		/// Category ID 100 = "CustomComponent" in OEAS Event Log Source.
		/// </summary>
		private const int ONYX_EVENT_CATEGORY_ID = 100;
		/// <summary>
		/// Windows API allows up to 32K bytes in event logs.
		/// We defined a safe limit for additional info so that 
		/// it does not exceed Windows Event Log limits.
		/// Note that unicode characters can be between 1-4 bytes, 
		/// that is why we cannot allow 32K chars.
		/// </summary>
		private const int MAX_EVENT_LOG_SIZE_FOR_ADDITIONAL_INFO = 16000;
		/// <summary>
		/// Onyx log event enumerations (used for Event Log Instance IDs).
		/// </summary>
		private enum OnyxLogEvent : long
		{
			Error = 1,
			Warning = 2,
			Information = 4
		}
		#endregion

		#region Private fields
		private EventLog m_eventLog;
		private bool m_logErrors = true;
		private bool m_logWarnings = false;
		private bool m_logMessages = false;
		private string m_userID = "";
		private string m_otmID = "";
		private int m_logSettings = 1;
		#endregion

		#region Public properties
		/// <summary>
		/// Log settings bitmask from OEAS.
		/// </summary>
		public int logSettings
		{
			get
			{
				return m_logSettings;
			}
			set
			{
				m_logSettings = value;
				this.logErrors = (m_logSettings & (int)OnyxLogEvent.Error) == (int)OnyxLogEvent.Error;
				this.logWarnings = (m_logSettings & (int)OnyxLogEvent.Warning) == (int)OnyxLogEvent.Warning;
				this.logMessages = (m_logSettings & (int)OnyxLogEvent.Information) == (int)OnyxLogEvent.Information;
			}
		}
		/// <summary>
		/// Indicates if errors should be logged.
		/// </summary>
		public bool logErrors
		{
			get
			{
				return m_logErrors;
			}
			set
			{
				m_logErrors = value;
			}
		}
		/// <summary>
		/// Indicates if warnings should be logged.
		/// </summary>
		public bool logWarnings
		{
			get
			{
				return m_logWarnings;
			}
			set
			{
				m_logWarnings = value;
			}
		}
		/// <summary>
		/// Indicates if messages should be logged.
		/// </summary>
		public bool logMessages
		{
			get
			{
				return m_logMessages;
			}
			set
			{
				m_logMessages = value;
			}
		}
		/// <summary>
		/// Onyx user ID.
		/// </summary>
		public string userID
		{
			get
			{
				return m_userID;
			}
			set
			{
				m_userID = value;
			}
		}
		/// <summary>
		/// Onyx transaction ID.
		/// </summary>
		public string otmID
		{
			get
			{
				return m_otmID;
			}
			set
			{
				m_otmID = value;
			}
		}
		#endregion

		#region Protected properties
		/// <summary>
		/// Windows event log used by this component.
		/// </summary>
		protected EventLog eventLog
		{
			get
			{
				return m_eventLog;
			}
			set
			{
				m_eventLog = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Constructor that initializes the event log source value.
		/// </summary>
		/// <param name="psEventLogSource">Event log source to use when logging events.</param>
		public StepComponentLog(string psEventLogSource)
		{
			this.eventLog = new EventLog();
			this.eventLog.Source = psEventLogSource;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Log a debug message.
		/// </summary>
		/// <param name="psSource">Source of the message.</param>
		/// <param name="psDebugType">Type of the message.</param>
		/// <param name="psMessage">Message text.</param>
		/// <param name="psAdditionalInfo">Additional information to include in the log.</param>
		public void LogMessage(string psSource,
							string psDebugType,
							string psMessage,
							string psAdditionalInfo)
		{
			if (this.logMessages)
			{
				// Add debug type to source, then log entry
				psSource += " : " + psDebugType;
				this.WriteEventLogEntry(EventLogEntryType.Information, psSource, psMessage, psAdditionalInfo);
			}
		}
		/// <summary>
		/// Log a warning message.
		/// </summary>
		/// <param name="psSource">Source of the message.</param>
		/// <param name="piMessageID">ID of the message.</param>
		/// <param name="psMessage">Message text.</param>
		/// <param name="psAdditionalInfo">Additional information to include in the log.</param>
		public void LogWarning(string psSource,
							long piMessageID,
							string psMessage,
							string psAdditionalInfo)
		{
			if (this.logWarnings)
			{
				// Add debug type to source, then log entry
				psMessage = ((piMessageID != 0) ? piMessageID.ToString() + " : " : "") + psMessage;
				this.WriteEventLogEntry(EventLogEntryType.Warning, psSource, psMessage, psAdditionalInfo);
			}
		}
		/// <summary>
		/// Log an error message.
		/// </summary>
		/// <param name="psSource">Source of the message.</param>
		/// <param name="piMessageID">ID of the message.</param>
		/// <param name="psMessage">Message text.</param>
		/// <param name="psAdditionalInfo">Additional information to include in the log.</param>
		public void LogError(string psSource,
							long piMessageID,
							string psMessage,
							string psAdditionalInfo)
		{
			if (this.logErrors)
			{
				// Add debug type to source, then log entry
				psMessage = ((piMessageID != 0) ? piMessageID.ToString() + " : " : "") + psMessage;
				this.WriteEventLogEntry(EventLogEntryType.Error, psSource, psMessage, psAdditionalInfo);
			}
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Log a complete entry to the Windows event log.
		/// </summary>
		/// <param name="pEventLogEntryType">Event log entry type.</param>
		/// <param name="psSource">Source of the message.</param>
		/// <param name="psMessage">Message text.</param>
		/// <param name="psAdditionalInfo">Additional information to include in the log.</param>
		protected void WriteEventLogEntry(EventLogEntryType pEventLogEntryType,
									 string psSource,
									 string psMessage,
									 string psAdditionalInfo)
		{
			// Determine instance ID using Onyx convention
			var eventInstanceID = ONYX_EVENT_INSTANCE_ID_BASE;
			switch (pEventLogEntryType)
			{
				case EventLogEntryType.Information:
					eventInstanceID += (long)OnyxLogEvent.Information;
					break;
				case EventLogEntryType.Warning:
					eventInstanceID += (long)OnyxLogEvent.Warning;
					break;
				case EventLogEntryType.Error:
					eventInstanceID += (long)OnyxLogEvent.Error;
					break;
			}

			var chunkSize = MAX_EVENT_LOG_SIZE_FOR_ADDITIONAL_INFO;
			var stringLength = psAdditionalInfo.Length;
			var chunkCounter = 0;
			var totalChunkCount = (int)Math.Ceiling((double)stringLength / (double)chunkSize);

			for (var i = 0; i < stringLength; i += chunkSize)
			{
				if (i + chunkSize > stringLength)
				{
					chunkSize = stringLength - i;
				}

				chunkCounter++;
				var chunkPartInfo = "EventData part " + chunkCounter + " of " + totalChunkCount;
				var chunkStr = psAdditionalInfo.Substring(i, chunkSize);

				WriteToEvent(pEventLogEntryType, psSource, psMessage, eventInstanceID, chunkPartInfo, chunkStr);
			}
		}

		private void WriteToEvent(EventLogEntryType pEventLogEntryType, string psSource, string psMessage, long eventInstanceID, string chunkPartInfo, string chunkStr)
		{
			// Create event instance
			var eventInstance = new EventInstance(eventInstanceID, ONYX_EVENT_CATEGORY_ID, pEventLogEntryType);

			// Include OEAS event log parameters based on Onyx conventions
			string[] logValues =
			{
				this.userID,
				psSource,
				psMessage,
				this.otmID,
				XmlUtil.DateTimeToTimestamp(DateTime.Now),
				chunkPartInfo,
				chunkStr
			};

			// Write the event
			this.eventLog.WriteEvent(eventInstance, logValues);
		}
		#endregion
	}
}
