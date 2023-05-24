// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Onyx Step Component step package structure.
	/// </summary>
	public class StepPackage
	{
		#region Private fields
		private XmlDocument m_xmlDoc = null;
		private XmlNode m_contextNode = null;
		private XmlNode m_methodStatusNode = null;
		private XmlNode m_statusTypeNode = null;
		private XmlNode m_paramsNode = null;
		private XmlNode m_paramsReturnNode = null;
		private XmlNode m_returnXmlNode = null;
		private StepPackageContext m_context = null;
		private bool m_initialized = false;
		#endregion

		#region Public properties
		/// <summary>
		/// XML document containing step package.
		/// </summary>
		public XmlDocument xmlDoc
		{
			get
			{
				return m_xmlDoc;
			}
			set
			{
				m_xmlDoc = value;
			}
		}
		/// <summary>
		/// Context node in step package.
		/// </summary>
		public XmlNode contextNode
		{
			get
			{
				return m_contextNode;
			}
		}
		/// <summary>
		/// Method status node in step package.
		/// </summary>
		public XmlNode methodStatusNode
		{
			get
			{
				return m_methodStatusNode;
			}
		}
		/// <summary>
		/// Parameters node in step package.
		/// </summary>
		public XmlNode paramsNode
		{
			get
			{
				return m_paramsNode;
			}
		}
		/// <summary>
		/// Parameters return node in step package.
		/// </summary>
		public XmlNode paramsReturnNode
		{
			get
			{
				return m_paramsReturnNode;
			}
		}
		/// <summary>
		/// Status type node in step package.
		/// </summary>
		public XmlNode statusTypeNode
		{
			get
			{
				return m_statusTypeNode;
			}
		}
		/// <summary>
		/// Return XML node in step package.
		/// </summary>
		public XmlNode returnXmlNode
		{
			get
			{
				return m_returnXmlNode;
			}
		}
		/// <summary>
		/// Status type value in step package, used to indicate
		/// result of logical method call.
		/// </summary>
		public string statusType
		{
			get
			{
				return this.statusTypeNode.InnerText;
			}
			set
			{
				this.statusTypeNode.InnerText = value;
			}
		}
		/// <summary>
		/// Step package context information.
		/// </summary>
		public StepPackageContext context
		{
			get
			{
				return m_context;
			}
			set
			{
				m_context = value;
			}
		}
		/// <summary>
		/// Indicates if the step package object has been initialized.
		/// </summary>
		public bool initialized
		{
			get
			{
				return m_initialized;
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
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor.
		/// </summary>
		public StepPackage()
		{
		}

		/// <summary>
		/// Constructor that sets step package content from an XML document.
		/// </summary>
		public StepPackage(XmlDocument pXmlDoc)
		{
			this.SetDocument(pXmlDoc);
		}

		/// <summary>
		/// Constructor that sets step package content from an XML string.
		/// </summary>
		public StepPackage(string psXmlString)
		{
			this.SetDocument(psXmlString);
		}

		/// <summary>
		/// Constructor that sets step package content from another step package.
		/// </summary>
		public StepPackage(StepPackage pStepPackage)
		{
			this.SetDocument(pStepPackage);
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Add a warning or error to the method status collection.
		/// </summary>
		/// <param name="pbError">Indicates if the severity should be error or warning.</param>
		/// <param name="piErrorNumber">Error number.</param>
		/// <param name="psErrorType">Error type.</param>
		/// <param name="psErrorDescription">Error description.</param>
		/// <param name="piNatLangID">National Language message ID.</param>
		/// <param name="psSourceType">Source type.</param>
		/// <param name="psSourceName">Source name.</param>
		protected void AddErrorOrWarning(bool pbError,
							long piErrorNumber,
							string psErrorType,
							string psErrorDescription,
							long piNatLangID,
							string psSourceType,
							string psSourceName)
		{
			string severity;

			// Change status type, severity
			if (pbError)
			{
				this.SetStatusType(StepPackageStatusType.Failure);
				severity = StepPackageErrorSeverity.Failure;
			}
			else
			{
				this.SetStatusType(StepPackageStatusType.SuccessWithInfo);
				severity = StepPackageErrorSeverity.Warning;
			}

			// Add error, set values
			XmlNode msgNode = XmlUtil.AddChildNode(this.methodStatusNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus.Error);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.ErrorNumber,
				piErrorNumber.ToString(),
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.ErrorType,
				psErrorType,
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.ErrorDescription,
				psErrorDescription,
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.NatLangID,
				piNatLangID.ToString(),
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.Severity,
				severity,
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.Timestamp,
				XmlUtil.DateTimeToTimestamp(DateTime.Now),
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.SourceType,
				psSourceType,
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Error.SourceName,
				psSourceName,
				true);

			// Move the node before message or warning nodes if necessary
			XmlNode lowerPriorityMsgNode = this.methodStatusNode.SelectSingleNode("*[name()='message'" + ((severity == StepPackageErrorSeverity.Failure) ? " or severity='warning'" : "") + "]");
			if (lowerPriorityMsgNode != null)
			{
				this.methodStatusNode.InsertBefore(msgNode, lowerPriorityMsgNode);
			}
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Setup the step package using an XML document.
		/// </summary>
		/// <param name="pXmlDoc">XML document that has step package content.</param>
		public void SetDocument(XmlDocument pXmlDoc)
		{
			this.xmlDoc = pXmlDoc;

			// Get reference to base step package nodes
			this.m_contextNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.Context);
			this.m_paramsNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.Parameters);
			this.m_returnXmlNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.ReturnXml);
			this.m_paramsReturnNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.ParametersReturn);
			this.m_methodStatusNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.MethodStatus);
			this.m_statusTypeNode = XmlUtil.GetRequiredNode(this.xmlDoc.DocumentElement,
				StepPackageXPath.StatusType);

			// Add context object
			this.context = new StepPackageContext(this);

			// Indicate the object is initialized
			m_initialized = true;
		}
		/// <summary>
		/// Setup the step package using an XML string.
		/// </summary>
		/// <param name="psXmlString">XML string that has step package content.</param>
		public void SetDocument(string psXmlString)
		{
			XmlDocument newDoc = new XmlDocument();
			try
			{
				newDoc.LoadXml(psXmlString);
			}
			catch (XmlException e)
			{
				throw new StepComponentException(this.assemblyClassName,
					"Error parsing step package XML.",
					psXmlString,
					e);
			}
			this.SetDocument(newDoc);
		}
		/// <summary>
		/// Setup the step package using another step package.
		/// </summary>
		/// <param name="pSourcePackage">Step package to clone content from.</param>
		public void SetDocument(StepPackage pSourcePackage)
		{
			this.SetDocument(pSourcePackage.xmlDoc.OuterXml);
		}
		/// <summary>
		/// Add a message to the method status collection.
		/// </summary>
		/// <param name="piMessageId">Message ID.</param>
		/// <param name="psMessageText">Message text.</param>
		public void AddMessage(long piMessageId, string psMessageText)
		{
			// Change status type
			this.SetStatusType(StepPackageStatusType.SuccessWithInfo);

			// Add message, set values
			XmlNode msgNode = XmlUtil.AddChildNode(this.methodStatusNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus.Message);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Message.MessageID,
				piMessageId.ToString(),
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Message.MessageText,
				psMessageText,
				true);
			XmlUtil.SetChildNodeValue(msgNode,
				StepPackageNodeName._StepPackage._ReturnXml._MethodStatus._Message.Timestamp,
				XmlUtil.DateTimeToTimestamp(DateTime.Now.ToUniversalTime()),
				true);
		}
		/// <summary>
		/// Add a warning to the method status collection.
		/// </summary>
		/// <param name="piErrorNumber">Error number.</param>
		/// <param name="psErrorType">Error type.</param>
		/// <param name="psErrorDescription">Error description.</param>
		/// <param name="piNatLangID">National Language message ID.</param>
		/// <param name="psSourceType">Source type.</param>
		/// <param name="psSourceName">Source name.</param>
		public void AddWarning(long piErrorNumber,
							string psErrorType,
							string psErrorDescription,
							long piNatLangID,
							string psSourceType,
							string psSourceName)
		{
			this.AddErrorOrWarning(false,
								piErrorNumber,
								psErrorType,
								psErrorDescription,
								piNatLangID,
								psSourceType,
								psSourceName);
		}
		/// <summary>
		/// Add an error to the method status collection.
		/// </summary>
		/// <param name="piErrorNumber">Error number.</param>
		/// <param name="psErrorType">Error type.</param>
		/// <param name="psErrorDescription">Error description.</param>
		/// <param name="piNatLangID">National Language message ID.</param>
		/// <param name="psSourceType">Source type.</param>
		/// <param name="psSourceName">Source name.</param>
		public void AddError(long piErrorNumber,
							string psErrorType,
							string psErrorDescription,
							long piNatLangID,
							string psSourceType,
							string psSourceName)
		{
			this.AddErrorOrWarning(true,
								piErrorNumber,
								psErrorType,
								psErrorDescription,
								piNatLangID,
								psSourceType,
								psSourceName);
		}
		/// <summary>
		/// Sets the status type value for the step package.
		/// Use this instead of accessing the statusType property directly to ensure
		/// that a valid value is provided.
		/// </summary>
		/// <param name="psStatusType">Status type value.</param>
		public void SetStatusType(string psStatusType)
		{
			switch (psStatusType)
			{
				case StepPackageStatusType.Failure:
					// Always change to failure
					this.statusType = psStatusType;
					break;
				case StepPackageStatusType.SuccessWithInfo:
					// Only change to success with info when not already at failure
					if (this.statusType == StepPackageStatusType.Success)
					{
						this.statusType = psStatusType;
					}
					break;
				case StepPackageStatusType.Success:
					// Don't change
					break;
				default:
					throw new StepComponentException(this.assemblyClassName,
						"Invalid status type value was provided.",
						"");
			}
		}
		/// <summary>
		/// Gets the value of a context property in the step package.
		/// </summary>
		/// <param name="psName">Name of the context property.</param>
		/// <returns>String value of the context property.</returns>
		public string GetContextProperty(string psName)
		{
			return XmlUtil.GetRequiredNodeValue(this.contextNode, psName);
		}
		/// <summary>
		/// Sets the value of a context property in the step package.
		/// </summary>
		/// <param name="psName">Name of the context property.</param>
		/// <param name="psValue">Value of the context property.</param>
		public void SetContextProperty(string psName, string psValue)
		{
			XmlUtil.SetChildNodeValue(this.contextNode, psName, psValue, true);
		}
		/// <summary>
		/// Resets all step package content to reuse the step package
		/// for another OTM call.
		/// </summary>
		public void Reset()
		{
			// Remove parameters, parameters return
			this.paramsNode.RemoveAll();
			this.paramsReturnNode.RemoveAll();

			// Remove any messages or errors
			XmlNodeList msgNodes = this.GetMessageList();
			foreach (XmlNode msgNode in msgNodes)
			{
				msgNode.ParentNode.RemoveChild(msgNode);
			}

			// Reset status type & OTM ID
			this.statusType = StepPackageStatusType.Success;
			this.context.otmID = XmlUtil.FormatGuid(Guid.NewGuid());
		}
		/// <summary>
		/// Gets the list of messages, warnings and errors in the method status.
		/// </summary>
		/// <returns>XmlNodeList containing list of message nodes.</returns>
		public XmlNodeList GetMessageList()
		{
			return this.methodStatusNode.SelectNodes("*[name()!='statusType']");
		}
		/// <summary>
		/// Merge the method status details from another step package
		/// into this step package.
		/// </summary>
		/// <param name="pStepPackage">Step package to merge method status from.</param>
		public void MergeMethodStatus(StepPackage pStepPackage)
		{
			// Copy status type using standard rules
			this.SetStatusType(pStepPackage.statusType);

			// Copy all messages
			XmlNodeList msgList = pStepPackage.GetMessageList();
			foreach (XmlNode msgNode in msgList)
			{
				this.methodStatusNode.AppendChild(this.xmlDoc.ImportNode(msgNode, true));
			}
		}
		#endregion
	}
}
