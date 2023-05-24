// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Returns the count of XML nodes matching a path.
	/// </summary>
	public class GetNodeCount
		: GrammarBase,
		IGrammarInteger
	{
		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			// Get path
			string path = StringContainer.EvaluateString(this.metadataNode, this.engine, pDataNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get count of nodes matching
			return pDataNode.SelectNodes(path).Count;
		}
		#endregion
	}
}
