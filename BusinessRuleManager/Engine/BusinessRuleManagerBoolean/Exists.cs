// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean
{
	/// <summary>
	/// Checks is a node with the provided path exists.
	/// </summary>
	public class Exists
		: GrammarBase,
		IGrammarBoolean
	{
		#region IGrammarBoolean Members
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return true;

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

			// Test if node exists
			XmlNode testNode = pDataNode.SelectSingleNode(path);
			if (testNode != null)
			{
				return true;
			}

			return false;
		}
		#endregion
	}
}
