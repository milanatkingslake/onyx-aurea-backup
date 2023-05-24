// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections;
using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using OnyxIStepStringPIA;

namespace ConsonaCRM.Onyx
{

	/// <summary>
	/// Abstract base class for OEAS step components.
	/// </summary>
	public abstract class StepComponentBase :
		ServicedComponent,
		IStepString
	{
		#region Method handler delegate
		/// <summary>
		/// Delegate for handler for Onyx logical method.
		/// </summary>
		public delegate void LogicalMethodHandler();
		#endregion

		#region Private fields
		private string m_applicationName = "";
		private string m_logicalObjectName = "";
		private string m_logicalMethodName = "";
		private string m_stepAdditionalData = "";
		private string m_returnValue = StepReturnValue.Continue;
		private StepPackage m_stepPackage;
		private StepComponentLog m_log;
		private Hashtable m_additionalDataValues;
		private OnyxNatLangCache m_natLangCache;
		private StepComponentCache m_cache;
		private OnyxDictionaryCache m_dictionaryCache;
		private OnyxAppData m_appData;
		private OnyxSessionManager m_sessionManager;
		private XmlNode m_defaultInputNode;
		private XmlNode m_defaultReturnNode;
		private Hashtable m_supportedMethodHandlers = new Hashtable();
		#endregion

		#region Public properties
		/// <summary>
		/// Step package XML document.
		/// </summary>
		public StepPackage stepPackage
		{
			get
			{
				return m_stepPackage;
			}
		}
		/// <summary>
		/// Event log for the step component.
		/// </summary>
		public StepComponentLog log
		{
			get
			{
				return m_log;
			}
			set
			{
				m_log = value;
			}
		}
		/// <summary>
		/// Onyx national language cache.
		/// </summary>
		public OnyxNatLangCache natLangCache
		{
			get
			{
				return m_natLangCache;
			}
			set
			{
				m_natLangCache = value;
			}
		}
		/// <summary>
		/// Step component cache.
		/// </summary>
		public StepComponentCache cache
		{
			get
			{
				return m_cache;
			}
			set
			{
				m_cache = value;
			}
		}
		/// <summary>
		/// Onyx dictionary cache.
		/// </summary>
		public OnyxDictionaryCache dictionaryCache
		{
			get
			{
				return m_dictionaryCache;
			}
			set
			{
				m_dictionaryCache = value;
			}
		}
		/// <summary>
		/// Onyx application registry data.
		/// </summary>
		public OnyxAppData appData
		{
			get
			{
				return m_appData;
			}
			set
			{
				m_appData = value;
			}
		}
		/// <summary>
		/// Onyx session manager.
		/// </summary>
		public OnyxSessionManager sessionManager
		{
			get
			{
				return m_sessionManager;
			}
			set
			{
				m_sessionManager = value;
			}
		}
		/// <summary>
		/// Hash table of step additional data values.
		/// </summary>
		public Hashtable additionalDataValues
		{
			get
			{
				return m_additionalDataValues;
			}
			set
			{
				m_additionalDataValues = value;
			}
		}
		#endregion

		#region Protected properties
		/// <summary>
		/// Provides access to the assembly and class name for this class.
		/// </summary>
		protected string assemblyClassName
		{
			get
			{
				return GetType().Name;
			}
		}
		/// <summary>
		/// OEAS logical application name.
		/// </summary>
		protected string applicationName
		{
			get
			{
				return m_applicationName;
			}
			set
			{
				m_applicationName = value;
			}
		}
		/// <summary>
		/// OEAS logical object name.
		/// </summary>
		protected string logicalObjectName
		{
			get
			{
				return m_logicalObjectName;
			}
			set
			{
				m_logicalObjectName = value;
			}
		}
		/// <summary>
		/// OEAS logical method name.
		/// </summary>
		protected string logicalMethodName
		{
			get
			{
				return m_logicalMethodName;
			}
			set
			{
				m_logicalMethodName = value;
			}
		}
		/// <summary>
		/// Step additional data string.
		/// </summary>
		protected string stepAdditionalData
		{
			get
			{
				return m_stepAdditionalData;
			}
			set
			{
				m_stepAdditionalData = value;
			}
		}
		/// <summary>
		/// Value to be returned to OEAS upon completion of step execution.
		/// </summary>
		protected string returnValue
		{
			get
			{
				return m_returnValue;
			}
			set
			{
				m_returnValue = value;
			}
		}
		/// <summary>
		/// Default input parameters node.
		/// </summary>
		protected XmlNode defaultInputNode
		{
			get
			{
				return m_defaultInputNode;
			}
			set
			{
				m_defaultInputNode = value;
			}
		}
		/// <summary>
		/// Default return parameters node.
		/// </summary>
		protected XmlNode defaultReturnNode
		{
			get
			{
				return m_defaultReturnNode;
			}
			set
			{
				m_defaultReturnNode = value;
			}
		}
		/// <summary>
		/// Data path from step additional data.
		/// </summary>
		protected string dataPath
		{
			get
			{
				string path = this.GetAdditionalDataValue(StepAdditionalDataValue.DataPath);
				if (path == null) return null;
				if ((path != string.Empty) && path.EndsWith("/"))
				{
					path = path.Remove(path.Length - 1);
				}
				return path;
			}
		}
		/// <summary>
		/// Step object name from step additional data.
		/// </summary>
		protected string stepObject
		{
			get
			{
				return this.GetAdditionalDataValue(StepAdditionalDataValue.StepObject);
			}
		}
		/// <summary>
		/// Step method name from step additional data.
		/// </summary>
		protected string stepMethod
		{
			get
			{
				return this.GetAdditionalDataValue(StepAdditionalDataValue.StepMethod);
			}
		}
		/// <summary>
		/// Hash table of supported method handlers.
		/// </summary>
		protected Hashtable supportedMethodHandlers
		{
			get
			{
				return m_supportedMethodHandlers;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public StepComponentBase()
		{
			this.InitializeInstance();
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Main IStep Execute method (entry point from OEAS).
		/// </summary>
		/// <param name="psApplicationName">OEAS logical application name.</param>
		/// <param name="psLogicalObjectName">OEAS logical application name.</param>
		/// <param name="psLogicalMethodName">OEAS logical method name.</param>
		/// <param name="psStepAdditionalData">Additional input data configured for the step in the OED.</param>
		/// <param name="psXMLString">OEAS step package XML.</param>
		/// <returns>"continue" if OEAS should continue processing later steps, "stop" if not.</returns>
		public string Execute(string psApplicationName,
			string psLogicalObjectName,
			string psLogicalMethodName,
			string psStepAdditionalData,
			ref string psXMLString)
		{
			try
			{
				// Pre-execute logic
				this.PreExecute(psApplicationName,
					psLogicalObjectName,
					psLogicalMethodName,
					psStepAdditionalData,
					psXMLString);

				// Main step component logic
				this.ExecuteMain();
			}
			catch (Exception e)
			{
				// Handle the exception
				this.HandleException(e);
			}

			try
			{
				// Post-execute logic
				this.PostExecute(ref psXMLString);
			}
			catch (Exception e)
			{
				// Handle the exception
				this.HandleException(e);
			}

			return this.returnValue;
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Called from constructor to initialize this component instance.
		/// </summary>
		protected virtual void InitializeInstance()
		{
		}
		/// <summary>
		/// Implements all logic required to setup the step component prior to
		/// main method execution.
		/// </summary>
		/// <param name="psApplicationName">OEAS logical application name.</param>
		/// <param name="psLogicalObjectName">OEAS logical application name.</param>
		/// <param name="psLogicalMethodName">OEAS logical method name.</param>
		/// <param name="psStepAdditionalData">Additional input data configured for the step in the OED.</param>
		/// <param name="psXMLString">OEAS step package XML.</param>
		protected virtual void PreExecute(string psApplicationName,
			string psLogicalObjectName,
			string psLogicalMethodName,
			string psStepAdditionalData,
			string psXMLString)
		{
			// Check that required arguments were provided
			if (psApplicationName == string.Empty)
			{
				throw new StepComponentException(this.assemblyClassName,
					"A valid application name was not provided.",
					"");
			}
			if (psLogicalObjectName == string.Empty)
			{
				throw new StepComponentException(this.assemblyClassName,
					"A valid logical object name was not provided.",
					"");
			}
			if (psLogicalMethodName == string.Empty)
			{
				throw new StepComponentException(this.assemblyClassName,
					"A valid logical method name was not provided.",
					"");
			}

			// Save value of input parameters
			this.applicationName = psApplicationName;
			this.logicalObjectName = psLogicalObjectName;
			this.logicalMethodName = psLogicalMethodName;
			this.stepAdditionalData = psStepAdditionalData;

			// Load step package XML
			this.m_stepPackage = new StepPackage(psXMLString);

			// Add log component, set details
			this.log = new StepComponentLog(this.applicationName);

			// Set additional details for log
			this.log.userID = this.stepPackage.context.userID;
			this.log.otmID = this.stepPackage.context.otmID;
			this.log.logSettings = this.stepPackage.context.logSettings;

			// Check if a previous step set the status type to failure
			if (this.stepPackage.statusType == StepPackageStatusType.Failure)
			{
				this.log.LogMessage(this.assemblyClassName,
					StepComponentLog.DebugLogType.Progress,
					"A previous logical method step set statusType='failure', exiting...",
					"");
				throw new StepComponentStopException(StepReturnValue.Continue);
			}

			// Setup national language cache
			this.natLangCache = new OnyxNatLangCache(this.applicationName,
				this.stepPackage.context.siteID,
				this.stepPackage.context.preferredLanguage);

			// Parse additional data
			this.ParseAdditionalData();

			// Get default input and return nodes
			this.GetDefaultInputReturnNodes();

			// Add cache component
			this.cache = new StepComponentCache(this.applicationName + "." +
				this.stepPackage.context.siteID.ToString() + ".");

			// Add dictionary cache component
			this.dictionaryCache = new OnyxDictionaryCache(this.applicationName);

			// Add app data component
			this.appData = new OnyxAppData(this.applicationName);

			// Add session manager component
			this.sessionManager = new OnyxSessionManager(this.stepPackage.context);

			// Log start message
			this.log.LogMessage(this.assemblyClassName,
				StepComponentLog.DebugLogType.Enter,
				this.stepAdditionalData,
				"Pre-execute logic was completed, starting execution... " +
				(this.stepPackage != null ? this.stepPackage.xmlDoc.OuterXml : ""));
		}
		/// <summary>
		/// Implements all logic required to clean up component resources and return
		/// execution results to OEAS.
		/// </summary>
		/// <param name="psXMLString"></param>
		protected virtual void PostExecute(ref string psXMLString)
		{
			// Get step package XML to return
			if (this.stepPackage != null)
			{
				// Check for failure
				if (this.stepPackage.statusType == StepPackageStatusType.Failure)
				{
					ContextUtil.SetComplete();
				}
				else
				{
					ContextUtil.SetAbort();
				}
				// Set return XML string
				psXMLString = this.stepPackage.xmlDoc.OuterXml;
				this.m_stepPackage = null;
			}
			// Log end message
			if (this.log != null)
			{
				this.log.LogMessage(this.assemblyClassName,
					StepComponentLog.DebugLogType.Exit,
					this.stepAdditionalData,
					"Post-execute logic was completed, ending execution... " +
					psXMLString);
			}
		}
		/// <summary>
		/// Get the default input and return parameters nodes.
		/// Override this method to implement custom logic or to
		/// use a non-standard input or return node.
		/// </summary>
		protected virtual void GetDefaultInputReturnNodes()
		{
			string inputPath = this.dataPath;
			string returnPath = this.dataPath;

			// If the method is not:
			// retrieveList, retrieveCollection or saveCollection
			// (typically insert, update, delete, retrieve)
			// then we expect a single object as input
			switch (this.stepMethod)
			{
				case LogicalMethodName.RetrieveList:
				case LogicalMethodName.RetrieveCollection:
				case LogicalMethodName.SaveCollection:
					break;
				default:
					inputPath += (inputPath == string.Empty ? "" : "/") + this.stepObject;
					break;
			}

			// Input path is required
			if (inputPath == string.Empty)
			{
				this.defaultInputNode = this.stepPackage.paramsNode;
			}
			else
			{
				this.defaultInputNode = XmlUtil.GetRequiredNode(this.stepPackage.paramsNode, inputPath);
			}

			// Return path may be created if it doesn't exist
			if (returnPath == string.Empty)
			{
				this.defaultReturnNode = this.stepPackage.paramsReturnNode;
			}
			else
			{
				this.defaultReturnNode = XmlUtil.GetOrCreateNode(this.stepPackage.paramsReturnNode, returnPath);
			}
		}
		/// <summary>
		/// Handles any exception that is raised during execution.
		/// </summary>
		/// <param name="e">Exception to be handled.</param>
		protected virtual void HandleException(Exception e)
		{
			// Check for stop exception
			if (e.GetType() == typeof(StepComponentStopException))
			{
				StepComponentStopException ex = (StepComponentStopException)e;
				if (ex.returnValue != "")
				{
					this.returnValue = ex.returnValue;
				}
				return;
			}

			// Check for step component exception
			if (e.GetType() == typeof(StepComponentException))
			{
				StepComponentException ex = (StepComponentException)e;
				// Translate National Language ID to message
				string message = ex.Message;
				if (ex.messageId != 0)
				{
					message = this.natLangCache.RetrieveString((int)ex.messageId, ex.messageArguments);
				}
				// Log error to step package
				if (this.stepPackage != null)
				{
					if (this.stepPackage.initialized)
					{
						this.stepPackage.AddError(ex.messageId,
							ex.errorType,
							message,
							ex.messageId,
							ex.sourceType,
							ex.Source + ":" + ex.sourceName);
					}
				}
				// Log error to event log
				if (this.log != null)
				{
					this.log.LogError(ex.Source,
						ex.messageId,
						message,
						ex.additionalInfo);
				}
			}
			else
			{
				// Log error to step package
				if (this.stepPackage.initialized)
				{
					this.stepPackage.AddError(0,
						"",
						e.Message,
						0,
						"",
						"");
				}
				// Log error to event log
				if (this.log != null)
				{
					this.log.LogError(this.assemblyClassName,
						0,
						e.Message,
						e.StackTrace.ToString());
				}
			}
			// Default is to tell OEAS to stop executing method steps
			// when an exception is encountered
			ContextUtil.SetAbort();
			this.returnValue = StepReturnValue.Stop;

			// Handle inner exception
			if (e.InnerException != null)
			{
				HandleException(e.InnerException);
			}
		}
		/// <summary>
		/// Parse the step additional data string into name/value pairs in a hash table.
		/// </summary>
		protected void ParseAdditionalData()
		{
			string[] values = this.stepAdditionalData.Split(";".ToCharArray());
			this.additionalDataValues = new Hashtable(values.Length);

			foreach (string value in values)
			{
				string[] parts = value.Split("=".ToCharArray());
				if (parts.Length == 2)
				{
					this.additionalDataValues.Add(parts[0], parts[1]);
				}
				else if (parts.Length > 2)
				{
					this.additionalDataValues.Add(parts[0], value.Substring(parts[0].Length + 1));
				}
				else
				{
					this.additionalDataValues.Add(parts[0], "");
				}
			}
		}
		/// <summary>
		/// Get a step additional data value.
		/// </summary>
		/// <param name="psName">Name of the value to return.</param>
		/// <returns>String value (if found).</returns>
		protected string GetAdditionalDataValue(string psName)
		{
			object value = this.additionalDataValues[psName];
			if (value != null)
			{
				return value.ToString();
			}
			return null;
		}
		/// <summary>
		/// Adds a handler to the hash table of supported handlers.
		/// </summary>
		/// <param name="psObjectName">Logical object name.</param>
		/// <param name="psMethodName">Logical method name.</param>
		/// <param name="handler">Method handler.</param>
		protected void AddSupportedMethod(string psObjectName, string psMethodName, LogicalMethodHandler handler)
		{
			// Add to hash table of supported handlers
			this.supportedMethodHandlers.Add(psObjectName + "." + psMethodName, handler);
		}
		/// <summary>
		/// Execute a logical method handler.
		/// </summary>
		/// <param name="psObjectName">Logical object name.</param>
		/// <param name="psMethodName">Logical method name.</param>
		protected void ExecuteMethodHandler(string psObjectName, string psMethodName)
		{
			string key = psObjectName + "." + psMethodName;

			// Check if the method is supported
			if (!this.supportedMethodHandlers.ContainsKey(key))
			{
				throw new StepComponentException(this.assemblyClassName,
					700025,
					key,
					"",
					StepPackageErrorType.BusinessLogic,
					StepPackageSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Execute the method
			LogicalMethodHandler handler = (LogicalMethodHandler)this.supportedMethodHandlers[key];
			handler();
		}
		/// <summary>
		/// Main step component execution method.
		/// This method can be overridden by derived classes instead of using the supported method
		/// handlers construct.
		/// </summary>
		protected virtual void ExecuteMain()
		{
			// Simply execute a supported method based on additional data values
			this.ExecuteMethodHandler(this.stepObject, this.stepMethod);
		}
		#endregion
	}
}
