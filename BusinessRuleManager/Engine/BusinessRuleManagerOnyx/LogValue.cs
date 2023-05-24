// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Logs a value to the Event Log.
	/// </summary>
	public class LogValue
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

			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);

			// Get name, value
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			string value = StringContainer.EvaluateString(valueNode, this.engine, pDataNode, this.namespaceManager);

			// Log to event log
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			stepComponent.log.LogMessage(this.assemblyClassName,
				StepComponentLog.DebugLogType.Progress,
				name,
				value);
		}
		#endregion
	}
}
