// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections.Generic;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Implement "getArgumentValue" grammar expression.
	/// </summary>
	public class GetArgumentValue
		: CacheRead
	{
		#region Public methods
		public override string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			string name = this.GetName(pDataNode);

			// Return value from cached arguments
			Dictionary<string, string> processArgs = SubProcessBase.GetCachedInfo(this);
			if (processArgs.ContainsKey(name))
			{
				return processArgs[name];
			}

			return string.Empty;
		}
		#endregion
	}
}
