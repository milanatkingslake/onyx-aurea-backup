// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Adds a return message to the Onyx step package.
	/// </summary>
	public class ReturnMessage
		: GrammarBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get details of requested message
			string type = XmlUtil.GetRequiredNodeValue(this.metadataNode, "brm:type", this.namespaceManager);
			int msgId = System.Convert.ToInt32(XmlUtil.GetRequiredNodeValue(this.metadataNode, "brm:msgId", this.namespaceManager));

			// Use string container to evaluate arguments
			string arguments = string.Empty;
			XmlNode argsNode = this.metadataNode.SelectSingleNode("brm:arguments", this.namespaceManager);
			if (argsNode != null)
			{
				arguments = StringContainer.EvaluateString(argsNode, this.engine, pDataNode, this.namespaceManager);
			}

			// Retrieve NL string
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			string message = stepComponent.natLangCache.RetrieveString(msgId, arguments);

			// Add error, warning or message to step package
			switch (type)
			{
				// Add error
				case "error":
					stepComponent.stepPackage.AddError(msgId,
						BusinessRuleManagerErrorType.BusinessLogic,
						message,
						msgId,
						BusinessRuleManagerSourceType.BusinessLogic,
						this.assemblyClassName + "." + MethodBase.GetCurrentMethod().Name);
					break;
				// Add warning
				case "warning":
					stepComponent.stepPackage.AddWarning(msgId,
						BusinessRuleManagerErrorType.BusinessLogic,
						message,
						msgId,
						BusinessRuleManagerSourceType.BusinessLogic,
						this.assemblyClassName + "." + MethodBase.GetCurrentMethod().Name);
					break;
				// Add message
				case "message":
					stepComponent.stepPackage.AddMessage(msgId,
						message);
					break;
				default:
					// Throw exception if an invalid message type was requested
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.InvalidPropertyValue,
						this.metadataNode.Name + "~type~" + type,
						this.metadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name);
			}
		}
		#endregion
	}
}
