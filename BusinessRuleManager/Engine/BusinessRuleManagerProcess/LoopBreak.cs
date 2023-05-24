// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Break out of a loop control grammar item.
	/// </summary>
	public class LoopBreak
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

			// Throw exception (should be caught by loop control construct grammar
			throw new BusinessRuleManagerBreakException();
		}
		#endregion
	}
}
