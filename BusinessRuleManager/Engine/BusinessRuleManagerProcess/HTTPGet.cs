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
	/// Implement "httpGet" grammar expression.
	/// </summary>
	public class HTTPGet
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

			// Create web client object
			WebClient client = new WebClient();
			client.Credentials = CredentialCache.DefaultNetworkCredentials;
			client.Proxy.Credentials = CredentialCache.DefaultNetworkCredentials;

			string responseContent;

			try
			{
				responseContent = client.DownloadString(url);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorExecutingHTTPGet,
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
