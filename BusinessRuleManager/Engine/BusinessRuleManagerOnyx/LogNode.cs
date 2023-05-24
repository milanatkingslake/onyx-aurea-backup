// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Logs an XML node's contents to the Event Log.
	/// </summary>
	public class LogNode
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
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);

			// Get name, path
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			string path = StringContainer.EvaluateString(pathNode, this.engine, pDataNode, this.namespaceManager);

			// Find node
			XmlNode childNode = pDataNode.SelectSingleNode(path);

			// Log to event log
			if (childNode != null)
			{
				StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
				stepComponent.log.LogMessage(this.assemblyClassName,
					StepComponentLog.DebugLogType.Progress,
					name,
					childNode.OuterXml);
			}
		}
		#endregion
	}
}
