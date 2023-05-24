// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Implement "otmCall" grammar expression.
	/// Executes an OTM call using the internal OTM interface.
	/// </summary>
	public class OTMCall
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

			// Get child nodes in metadata
			bool mergeMethodStatus = XmlUtil.GetNodeValue(this.metadataNode, "brm:mergeMethodStatus", this.namespaceManager, true, "1") == "1";
			XmlNode objectNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:object", this.namespaceManager);
			XmlNode methodNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:method", this.namespaceManager);
			XmlNode inputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:inputParameters", this.namespaceManager);
			XmlNode outputParamsNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:outputParameters", this.namespaceManager);
			string onError = XmlUtil.GetNodeValue(this.metadataNode, "brm:onError", this.namespaceManager, true, "continue");

			// Validate onError value
			if (onError != "stop" && onError != "continue")
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.InvalidPropertyValue,
					this.metadataNode.Name + "~onError~" + onError,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get object, method
			string objectName = StringContainer.EvaluateString(objectNode, this.engine, pDataNode, this.namespaceManager);
			if (objectName == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					objectNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			string methodName = StringContainer.EvaluateString(methodNode, this.engine, pDataNode, this.namespaceManager);
			if (methodName == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					methodNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Create Internal OTM call instance
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			InternalOTM otm = new InternalOTM(stepComponent.stepPackage.context.applicationName,
				stepComponent.stepPackage);

			// Process input parameters
			IGrammarProcess2 processGrammar;
			XmlNodeList inputParams = this.GetChildElements(inputParamsNode);
			foreach (XmlNode inputParam in inputParams)
			{
				processGrammar = (IGrammarProcess2)GrammarBase.CreateInstance(inputParam, typeof(IGrammarProcess2), this);
				processGrammar.Process(pDataNode, otm.stepPackage.paramsNode);
			}

			// Execute the OTM call
			otm.Execute(objectName, methodName);

			// Merge method status
			if (mergeMethodStatus)
			{
				stepComponent.stepPackage.MergeMethodStatus(otm.stepPackage);
			}

			// Handle errors
			if (otm.stepPackage.statusType == StepPackageStatusType.Failure)
			{
				// Stop if requested
				if (onError == "stop")
				{
					throw new BusinessRuleManagerStopException(BusinessRuleManagerReturnValue.Stop);
				}
			}
			else
			{
				// Parse out embedded XML nodes from CDATA sections
				XmlNodeList embeddedNodes = otm.stepPackage.paramsReturnNode.SelectNodes(".//embeddedXml");
				foreach (XmlNode embeddedNode in embeddedNodes)
				{
					if (embeddedNode.HasChildNodes)
					{
						// Parse contents of CDATA section using XML fragment
						XmlCDataSection cdataNode = (XmlCDataSection)embeddedNode.FirstChild;
						XmlDocumentFragment xmlFragment = cdataNode.OwnerDocument.CreateDocumentFragment();
						xmlFragment.InnerXml = cdataNode.InnerText;
						embeddedNode.ParentNode.AppendChild(xmlFragment.FirstChild);
					}
					// Remove embedded node
					embeddedNode.ParentNode.RemoveChild(embeddedNode);
				}

				// Process output parameters
				XmlNodeList outputParams = this.GetChildElements(outputParamsNode);
				foreach (XmlNode outputParam in outputParams)
				{
					processGrammar = (IGrammarProcess2)GrammarBase.CreateInstance(outputParam, typeof(IGrammarProcess2), this);
					processGrammar.Process(otm.stepPackage.paramsReturnNode, pDataNode);
				}
			}
		}
		#endregion
	}
}
