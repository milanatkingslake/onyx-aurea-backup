// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Implements "setSessionItem" grammar, sets value of named session variable.
	/// </summary>
	public class SetSessionItem
		: GrammarBase,
		IGrammarProcess
	{
		#region Public methods
		public void Process(XmlNode pDataNode)
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

			// Get value
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			string value = StringContainer.EvaluateString(valueNode, this.engine, pDataNode, this.namespaceManager);

			// Set session item
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			stepComponent.sessionManager.SetSessionItem(name, value);
		}
		#endregion
	}
}
