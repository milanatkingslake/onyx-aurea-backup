// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Stops processing rule grammar without error.
	/// </summary>
	public class StopProcessing
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

			// Determine if the step should return "stop" or "continue" (default is "continue")
			string returnValue = XmlUtil.GetNodeValue(metadataNode, "brm:return", this.namespaceManager, true, "continue").ToString();
			// Check that the return value is valid
			switch (returnValue)
			{
				case BusinessRuleManagerReturnValue.Stop:
				case BusinessRuleManagerReturnValue.Continue:
					break;
				default:
					// Throw exception if the return value is invalid
					throw new BusinessRuleManagerException(this.assemblyClassName,
						(long)SystemMessage.MessageId.InvalidPropertyValue,
						"stopProcessing~return~" + returnValue,
						metadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.BusinessLogic,
						MethodBase.GetCurrentMethod().Name);
			}
			// Throw a stop exception (handled by the main execute function in the engine)
			throw new BusinessRuleManagerStopException(returnValue);
		}
		#endregion
	}
}
