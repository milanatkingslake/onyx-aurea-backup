// Copyright © Aptean 2018. All rights reserved.
using System;
using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Primary COM-accessible rules engine component.
	/// </summary>
	[ClassInterface(ClassInterfaceType.None),
	Guid("d7d053fe-f6fa-4b1f-8d09-334548e5fcf7"),
	ProgId("ConsonaCRM.BusinessRuleManager"),
	Transaction(TransactionOption.Supported),
	SecurityRole("BusinessRulePublic")]

	public class Engine : ServicedComponent
	{
		#region Private constants
		/// <summary>
		/// Data package status values.
		/// </summary>
		private struct DataPackageStatus
		{
			public const string Success = "success";
			public const string Error = "error";
		}
		/// <summary>
		/// Data package message type.
		/// </summary>
		private struct DataPackageMessageType
		{
			public const string Info = "info";
			public const string Warning = "warning";
			public const string Error = "error";
		}
		/// <summary>
		/// Default XML package structure.
		/// </summary>
		private const string DEFAULT_PACKAGE_XML =
			"<package>" +
				"<inputs/>" +
				"<outputs>" +
					"<status/>" +
					"<messages/>" +
				"</outputs>" +
			"</package>";
		/// <summary>
		/// Default XML message structure.
		/// </summary>
		private const string DEFAULT_MESSAGE_XML =
			"<message>" +
				"<type/>" +
				"<id/>" +
				"<description/>" +
				"<source/>" +
			"</message>";
		/// <summary>
		/// Message string to use when no message list was found.
		/// </summary>
		private const string NO_MESSAGE_LIST = "Message list not found: '~0'";
		/// <summary>
		/// Message string to use when a message was not found in the list.
		/// </summary>
		private const string NO_MESSAGE_ID = "Message ID not found: '~0'";
		#endregion

		#region Private fields
		private DataPackage m_dataPackage;
		private XmlDocumentCache m_messageList;
		#endregion

		#region Private properties
		/// <summary>
		/// Data package for the execute method.
		/// </summary>
		private DataPackage dataPackage
		{
			get
			{
				return m_dataPackage;
			}
			set
			{
				m_dataPackage = value;
			}
		}
		/// <summary>
		/// Application message list (resource strings).
		/// </summary>
		private XmlDocumentCache messageList
		{
			get
			{
				return m_messageList;
			}
			set
			{
				m_messageList = value;
			}
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Execute a ruleset from a repository against a provide
		/// input XML document.
		/// </summary>
		/// <param name="psRepositoryName">Name of the repository.</param>
		/// <param name="psMetadataPath">Path to the ruleset metadata in the repository.</param>
		/// <param name="psInputXml">Input XML document as a string.</param>
		/// <returns></returns>
		public string Execute(string psRepositoryName,
			string psMetadataPath,
			string psInputXml)
		{
			// Get assembly path
			string path = Assembly.GetExecutingAssembly().Location;
			path = path.Remove(path.LastIndexOf("\\") + 1);

			try
			{
				// Create data package
				this.dataPackage = new DataPackage(DEFAULT_PACKAGE_XML);
				XmlUtil.GetRequiredNode(this.dataPackage.xmlDoc.DocumentElement,
					"outputs/status").InnerText = DataPackageStatus.Success;

				// Generate reference ID
				Guid referenceId = Guid.NewGuid();

				// Create local cache
				LocalCache localCache = new LocalCache(psRepositoryName);

				// Load the message list
				this.messageList = new XmlDocumentCache(true,
					InternalEngine.CachePrefix.MessageList,
					InternalEngine.CachePrefix.NamespaceManagerSuffix,
					localCache);
				this.messageList.Load(path + InternalEngine.FilePath.MessageList);

				// Parse input XML
				try
				{
					XmlUtil.GetRequiredNode(this.dataPackage.xmlDoc.DocumentElement,
						"inputs").InnerXml = psInputXml;
				}
				catch (Exception e)
				{
					throw new BusinessRuleManagerException(GetType().Name,
						(long)SystemMessage.MessageId.ErrorParsingInputXml,
						"",
						"",
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name,
						e);
				}

				// Load the repository list
				XmlDocumentCache repositoryList = new XmlDocumentCache(true,
					InternalEngine.CachePrefix.RepositoryList,
					InternalEngine.CachePrefix.NamespaceManagerSuffix,
					localCache);
				repositoryList.Load(path + InternalEngine.FilePath.RepositoryList);

				// Lookup the repository from the list
				XmlNode repositoryNode = repositoryList.xmlDoc.SelectSingleNode("//repository[@name='" + psRepositoryName + "']");
				if (repositoryNode == null)
				{
					throw new BusinessRuleManagerException(GetType().Name,
						(long)SystemMessage.MessageId.RepositoryNotFound,
						psRepositoryName,
						"",
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name);
				}

				// Load the message list for the repository
				path = XmlUtil.GetRequiredNodeValue(repositoryNode, "@path");
				this.messageList.Load(path + "\\" + InternalEngine.FilePath.MessageList);

				// Call the internal engine
				InternalEngine engine = new InternalEngine();
				engine.Execute(XmlUtil.GetRequiredNodeValue(repositoryNode, "@path"),
					psMetadataPath,
					this.dataPackage,
					localCache.prefix,
					XmlUtil.FormatGuid(referenceId),
					this);

				// On success, indicated transaction can complete
				ContextUtil.SetComplete();
			}
			catch (Exception e)
			{
				this.HandleException(e);
			}

			// Return result
			return XmlUtil.GetRequiredNode(this.dataPackage.xmlDoc.DocumentElement,
					"outputs").OuterXml;
		}
		/// <summary>
		/// Handles any exception that is raised during execution.
		/// </summary>
		/// <param name="e">Exception to be handled.</param>
		protected void HandleException(Exception e)
		{
			// Check for stop exception & ignore
			if (e.GetType() == typeof(BusinessRuleManagerStopException))
			{
				return;
			}

			int messageId = 0;
			string message = string.Empty;
			string sourceName = e.Source;

			// Check for rules engine exception
			if (e.GetType() == typeof(BusinessRuleManagerException))
			{
				BusinessRuleManagerException ex = (BusinessRuleManagerException)e;

				// Translate message ID to message
				messageId = (int)ex.messageId;
				if (ex.messageId != 0)
				{
					message = this.GetMessageText((int)ex.messageId, ex.messageArguments);
				}
				else
				{
					message = ex.Message;
				}
				sourceName = ex.Source + "." + ex.sourceName;
			}
			else
			{
				// Use basic exception details for message
				message = e.Message;
			}

			// Create message structure
			XmlDocumentFragment msgFragment = this.dataPackage.xmlDoc.CreateDocumentFragment();
			msgFragment.InnerXml = DEFAULT_MESSAGE_XML;

			// Fill message details
			XmlUtil.SetChildNodeValue(msgFragment.FirstChild, "type", DataPackageMessageType.Error, false);
			XmlUtil.SetChildNodeValue(msgFragment.FirstChild, "id", messageId.ToString(), false);
			XmlUtil.SetChildNodeValue(msgFragment.FirstChild, "description", message, false);
			XmlUtil.SetChildNodeValue(msgFragment.FirstChild, "source", sourceName, false);

			// Add to message collection
			XmlUtil.GetRequiredNode(this.dataPackage.xmlDoc.DocumentElement,
				"outputs/messages").AppendChild(msgFragment.FirstChild);

			// Change status
			XmlUtil.GetRequiredNode(this.dataPackage.xmlDoc.DocumentElement,
				"outputs/status").InnerText = DataPackageStatus.Error;

			// Handle inner exception
			if (e.InnerException != null)
			{
				HandleException(e.InnerException);
			}

			// Abort transaction if exception was encountered
			ContextUtil.SetAbort();
		}
		/// <summary>
		/// Get a message string given a message ID and arguments.
		/// </summary>
		/// <param name="pMessageId">Message ID to retrieve.</param>
		/// <param name="psArguments">Arguments to substitute in the message.</param>
		/// <returns>Message text.</returns>
		protected string GetMessageText(int pMessageId, string psArguments)
		{
			string msg = string.Empty;

			// Check that message list was loaded
			if (this.messageList.xmlDoc.DocumentElement == null)
			{
				msg = NO_MESSAGE_LIST;
			}
			else
			{
				// Load message from list
				msg = XmlUtil.GetNodeValue(this.messageList.xmlDoc.DocumentElement,
					string.Format("//message[@id='{0}']/@value", pMessageId),
					false, string.Empty);

				if (msg == string.Empty)
				{
					msg = NO_MESSAGE_ID.Replace("~0", pMessageId.ToString());
				}
			}

			// Substitute arguments
			if (psArguments != string.Empty)
			{
				string[] args = psArguments.Split(new char['~']);
				for (int i = 0; i < args.Length; i++)
				{
					msg = msg.Replace("~" + i.ToString(), args.GetValue(i).ToString());
				}
			}

			return msg;
		}
		#endregion
	}
}
