// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "setArgumentValue" grammar expression.
	/// </summary>
	public class SetArgumentValue
		: CacheWrite
	{
		#region Public methods
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public override void Process(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get name
			string name = this.GetName(pSourceNode);

			// Get value as string
			string value = this.GetValue(pSourceNode);

			// Add argument to cached arguments
			Dictionary<string, string> processArgs = SubProcessBase.GetCachedInfo(this);
			processArgs.Add(name, value);
		}
		#endregion
	}
}
