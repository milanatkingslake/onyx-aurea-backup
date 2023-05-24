// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.Onyx;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
	/// <summary>
	/// Implements the "hasPermission" grammar.
	/// </summary>
	public class HasPermission
		: GrammarBase,
		IGrammarBoolean
	{
		#region Public methods
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Get resource ID
			string resourceId = StringContainer.EvaluateString(this.metadataNode, this.engine, pDataNode, this.namespaceManager);

			// Check for permission
			StepComponentBase stepComponent = (StepComponentBase)this.engine.externalComponent;
			return stepComponent.sessionManager.HasPermission(resourceId);
		}
		#endregion
	}
}
