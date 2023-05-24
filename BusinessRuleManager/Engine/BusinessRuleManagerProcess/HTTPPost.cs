// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Net;
using System.Net.Security;
using System.Reflection;
using System.Text;
using System.Xml;

using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "httpPost" grammar expression.
	/// </summary>
	public class HTTPPost
		: GrammarBase,
		IGrammarString
	{
		#region Public methods
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return string.Empty;

			// Get child nodes in metadata
			XmlNode urlNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:url", this.namespaceManager);
			XmlNode contentNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:content", this.namespaceManager);
			XmlNode contentTypeNode = this.metadataNode.SelectSingleNode("brm:contentType", this.namespaceManager);

			// Get URL
			string url = StringContainer.EvaluateString(urlNode, this.engine, pDataNode, this.namespaceManager);
			if (url == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					urlNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get content
			string content = StringContainer.EvaluateString(contentNode, this.engine, pDataNode, this.namespaceManager);

			// Create web client object
			WebClient client = new WebClient();
			client.Credentials = CredentialCache.DefaultNetworkCredentials;
			client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;

			// Set content type if provided
			if (contentTypeNode != null)
			{
				string contentType = StringContainer.EvaluateString(contentTypeNode, this.engine, pDataNode, this.namespaceManager);
				if (contentType != string.Empty)
				{
					client.Headers["Content-Type"] = contentType;
				}
			}

			string responseContent;
			try
			{
				responseContent = client.UploadString(url, content);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorExecutingHTTPPost,
					url + "~" + e.Message,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Return the response content
			return responseContent;
		}
		#endregion
	}
}
