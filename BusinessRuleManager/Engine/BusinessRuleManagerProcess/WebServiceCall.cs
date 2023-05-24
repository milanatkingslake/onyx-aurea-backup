// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Security.Cryptography.X509Certificates;
using System.Web.Services.Description;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "webServiceCall" grammar expression.
	/// Executes an OTM call using the internal OTM interface.
	/// </summary>
	public class WebServiceCall
		: GrammarBase,
		IGrammarProcess
	{
		#region Protected constants
		/// <summary>
		/// Cache key prefixes.
		/// </summary>
		protected struct CachePrefix
		{
			/// <summary>
			/// Cache prefix for web service definitions.
			/// </summary>
			public const string ServiceDefinition = "SVCDEF_";
		}
		#endregion

		#region Private fields
		private string m_wsdlUrl = string.Empty;
		private string m_requestUrl = string.Empty;
		private string m_serviceName = string.Empty;
		private string m_bindingName = string.Empty;
		private string m_methodName = string.Empty;
		private ServiceDescription m_svcDescription = null;
		private XmlDocument m_requestDoc = null;
		private XmlDocument m_responseDoc = null;
		private XmlNode m_requestHeaderNode = null;
		private XmlNode m_requestBodyNode = null;
		private XmlNode m_responseBodyNode = null;
		#endregion

		#region Protected properties
		/// <summary>
		/// URL for web service description.
		/// </summary>
		protected string wsdlUrl
		{
			get
			{
				return m_wsdlUrl;
			}
			set
			{
				m_wsdlUrl = value;
			}
		}
		/// <summary>
		/// URL for method request.
		/// </summary>
		protected string requestUrl
		{
			get
			{
				return m_requestUrl;
			}
			set
			{
				m_requestUrl = value;
			}
		}
		/// <summary>
		/// Service name.
		/// </summary>
		protected string serviceName
		{
			get
			{
				return m_serviceName;
			}
			set
			{
				m_serviceName = value;
			}
		}
		/// <summary>
		/// Binding name.
		/// </summary>
		protected string bindingName
		{
			get
			{
				return m_bindingName;
			}
			set
			{
				m_bindingName = value;
			}
		}
		/// <summary>
		/// Method name.
		/// </summary>
		protected string methodName
		{
			get
			{
				return m_methodName;
			}
			set
			{
				m_methodName = value;
			}
		}
		/// <summary>
		/// Service description loaded from WSDL.
		/// </summary>
		protected ServiceDescription serviceDescription
		{
			get
			{
				return m_svcDescription;
			}
			set
			{
				m_svcDescription = value;
			}
		}
		/// <summary>
		/// XML document for request.
		/// </summary>
		protected XmlDocument requestDoc
		{
			get
			{
				return m_requestDoc;
			}
			set
			{
				m_requestDoc = value;
			}
		}
		/// <summary>
		/// XML document for response.
		/// </summary>
		protected XmlDocument responseDoc
		{
			get
			{
				return m_responseDoc;
			}
			set
			{
				m_responseDoc = value;
			}
		}
		/// <summary>
		/// XML node for request header.
		/// </summary>
		protected XmlNode requestHeaderNode
		{
			get
			{
				return m_requestHeaderNode;
			}
			set
			{
				m_requestHeaderNode = value;
			}
		}
		/// <summary>
		/// XML node for request body.
		/// </summary>
		protected XmlNode requestBodyNode
		{
			get
			{
				return m_requestBodyNode;
			}
			set
			{
				m_requestBodyNode = value;
			}
		}
		/// <summary>
		/// XML node for response body.
		/// </summary>
		protected XmlNode responseBodyNode
		{
			get
			{
				return m_responseBodyNode;
			}
			set
			{
				m_responseBodyNode = value;
			}
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get child nodes in metadata
			XmlNode wsdlNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:wsdl", this.namespaceManager);
			XmlNode serviceNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:service", this.namespaceManager);
			XmlNode methodNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:method", this.namespaceManager);
			XmlNode inputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:inputParameters", this.namespaceManager);
			XmlNode outputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:outputParameters", this.namespaceManager);

			// Get wsdl, service, method
			this.wsdlUrl = StringContainer.EvaluateString(wsdlNode, this.engine, pDataNode, this.namespaceManager);
			if (this.wsdlUrl == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					wsdlNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			this.serviceName = StringContainer.EvaluateString(serviceNode, this.engine, pDataNode, this.namespaceManager);
			if (this.serviceName == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					serviceNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			this.methodName = StringContainer.EvaluateString(methodNode, this.engine, pDataNode, this.namespaceManager);
			if (this.methodName == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					methodNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Set callback for certificate validation
			ServicePointManager.ServerCertificateValidationCallback = this.RemoteCertificateValidationCallback;

			// Load WSDL
			this.LoadServiceDescription();

			// Get request URL from service description
			this.GetRequestUrl();

			// Create SOAP package
			this.GetSoapRequestPackage();

			// Process input parameters
			IGrammarProcess2 processGrammar;
			XmlNodeList inputParams = this.GetChildElements(inputParamsNode);
			foreach (XmlNode inputParam in inputParams)
			{
				processGrammar = (IGrammarProcess2)GrammarBase.CreateInstance(inputParam, typeof(IGrammarProcess2), this);
				processGrammar.Process(pDataNode, this.requestBodyNode);
			}

			// Set request namespace to service target namespace
			if (this.requestHeaderNode.FirstChild != null)
			{
				XmlAttribute xmlnsAttr = this.requestDoc.CreateAttribute("xmlns");
				xmlnsAttr.InnerText = this.serviceDescription.TargetNamespace;
				this.requestHeaderNode.FirstChild.Attributes.SetNamedItem(xmlnsAttr);
			}
			if (this.requestBodyNode.FirstChild != null)
			{
				XmlAttribute xmlnsAttr = this.requestDoc.CreateAttribute("xmlns");
				xmlnsAttr.InnerText = this.serviceDescription.TargetNamespace;
				this.requestBodyNode.FirstChild.Attributes.SetNamedItem(xmlnsAttr);
			}

			// Execute the method call
			this.ExecuteMethod();

			// Process output parameters
			XmlNodeList outputParams = this.GetChildElements(outputParamsNode);
			foreach (XmlNode outputParam in outputParams)
			{
				processGrammar = (IGrammarProcess2)GrammarBase.CreateInstance(outputParam, typeof(IGrammarProcess2), this);
				processGrammar.Process(this.responseBodyNode, pDataNode);
			}
		}
		#endregion

		#region Protected methods
		protected void LoadServiceDescription()
		{
			// Check if service definition is in cache
			if (this.engine.settingsCache.enableCaching)
			{
				this.serviceDescription = (ServiceDescription)this.engine.cache.Read(CachePrefix.ServiceDefinition + this.wsdlUrl);
				if (this.serviceDescription != null)
				{
					return;
				}
			}
			
			// Create HTTP GET request for WSDL
			HttpWebRequest wsdlRequest = (HttpWebRequest)HttpWebRequest.Create(this.wsdlUrl);
			wsdlRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
			wsdlRequest.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
			wsdlRequest.Method = "GET";
			// Execute request
			HttpWebResponse response;
			try
			{
				response = (HttpWebResponse)wsdlRequest.GetResponse();
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorLoadingWsdl,
					this.wsdlUrl,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}
			// Read response into service description
			try
			{
				Stream responseStream = response.GetResponseStream();
				this.serviceDescription = ServiceDescription.Read(responseStream);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorParsingServiceDescription,
					this.wsdlUrl,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Add to cache
			if (this.engine.settingsCache.enableCaching)
			{
				this.engine.cache.Write(CachePrefix.ServiceDefinition + this.wsdlUrl, this.serviceDescription);
			}
		}

		protected void GetSoapRequestPackage()
		{
			// Create XML document with empty soap package
			this.requestDoc = new XmlDocument();
			this.requestDoc.LoadXml("<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
				"<soap:Envelope xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:soap=\"http://schemas.xmlsoap.org/soap/envelope/\">" +
					"<soap:Header/>" +
					"<soap:Body/>" +
				"</soap:Envelope>");

			// Get soap body node
			this.requestHeaderNode = this.requestDoc.DocumentElement.SelectSingleNode("child::*[local-name()='Header']");
			this.requestBodyNode = this.requestDoc.DocumentElement.SelectSingleNode("child::*[local-name()='Body']");
		}

		protected string GetSoapAction()
		{
			// Find the operation binding for the method, get soap binding
			foreach (OperationBinding opBinding in this.serviceDescription.Bindings[this.bindingName].Operations)
			{
				if (opBinding.Name == this.methodName)
				{
					foreach (ServiceDescriptionFormatExtension ext in opBinding.Extensions)
					{
						if (ext.GetType() == typeof(SoapOperationBinding))
						{
							// Return soap action
							SoapOperationBinding soapOpBinding = (SoapOperationBinding)ext;
							return soapOpBinding.SoapAction;
						}
					}
				}
			}

			// Exception if soap operation binding not found
			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.SOAPActionNotFound,
				this.serviceName + "~" + this.methodName,
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}

		protected void GetRequestUrl()
		{
			// Find requested service
			Service service = this.serviceDescription.Services[this.serviceName];
			if (service == null)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ServiceNotFound,
					this.serviceName,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Find port that has soap address binding
			foreach (Port port in service.Ports)
			{
				foreach (ServiceDescriptionFormatExtension ext in port.Extensions)
				{
					if (ext.GetType() == typeof(SoapAddressBinding))
					{
						// Get request URL and binding name
						SoapAddressBinding addrBinding = (SoapAddressBinding)ext;
						this.requestUrl = addrBinding.Location;
						this.bindingName = port.Binding.Name;
						return;
					}
				}
			}

			// Exception if request URL not found
			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.RequestUrlNotFound,
				this.serviceName,
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}

		protected void ExecuteMethod()
		{
			// Convert string content to bytes
			byte[] byteData = new ASCIIEncoding().GetBytes(this.requestDoc.OuterXml);

			// Create HTTP POST request for request
			HttpWebRequest soapRequest = (HttpWebRequest)HttpWebRequest.Create(this.requestUrl);
			soapRequest.Credentials = CredentialCache.DefaultNetworkCredentials;
			soapRequest.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;
			soapRequest.Method = "POST";

			// Add headers and content type/length
			soapRequest.Headers.Add("MessageType", "CALL");
			soapRequest.Headers.Add("SOAPAction", this.GetSoapAction());
			soapRequest.ContentType = "text/xml";
			soapRequest.ContentLength = byteData.Length;

			// Write soap package content
			Stream reqStream = soapRequest.GetRequestStream();
			reqStream.Write(byteData, 0, byteData.Length);
			reqStream.Close();

			// Execute request
			Stream responseStream;
			try
			{
				responseStream = soapRequest.GetResponse().GetResponseStream();
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorExecutingWSMethod,
					this.serviceName + "~" + this.methodName + "~" + this.wsdlUrl,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Load response doc
			try
			{
				this.responseDoc = new XmlDocument();
				this.responseDoc.Load(responseStream);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorExecutingWSMethod,
					this.serviceName + "~" + this.methodName,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Get response body node
			this.responseBodyNode = this.responseDoc.DocumentElement.SelectSingleNode("child::*[local-name()='Body']");
			// Default response node to root if body not found
			if (this.responseBodyNode == null)
			{
				this.responseBodyNode = this.responseDoc.DocumentElement;
			}
		}

		protected bool RemoteCertificateValidationCallback(Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
		{
			// Ignore all certificate errors
			return true;
		}
		#endregion
	}
}
