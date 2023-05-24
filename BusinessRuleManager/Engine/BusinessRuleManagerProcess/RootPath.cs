// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Returns the root configuration path.
	/// </summary>
	public class RootPath :
		GrammarBase,
		IGrammarString
	{
		#region IGrammarString Members
		/// <summary>
		/// Process the provided data node using the configured string grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>string value based on grammar processing.</returns>
		public string EvaluateString(XmlNode pDataNode)
		{
			// Return repository path
			return this.engine.repositoryPath;
		}
		#endregion
	}
}
