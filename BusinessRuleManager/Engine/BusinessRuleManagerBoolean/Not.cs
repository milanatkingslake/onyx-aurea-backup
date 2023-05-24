// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean
{
	/// <summary>
	/// Implements "not" grammar expression.
	/// </summary>
	public class Not
		: BooleanContainer
	{
		#region IGrammarBoolean Members
		public override bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return true;

			return !base.EvaluateBoolean(pDataNode);
		}
		#endregion
	}
}
