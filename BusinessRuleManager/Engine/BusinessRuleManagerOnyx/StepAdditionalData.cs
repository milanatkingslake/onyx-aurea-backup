// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Gets a step additional data value from the Onyx step component interface.
	/// </summary>
	public class StepAdditionalData
		: GrammarBase,
		IGrammarString
	{
		#region Public methods
		public string EvaluateString(XmlNode pDataNode)
		{
			// Get name
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get additional data value from step component interface
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			object value = stepComponent.additionalDataValues[name];
			if (value != null)
			{
				return value.ToString();
			}

			return string.Empty;
		}
		#endregion
	}
}
