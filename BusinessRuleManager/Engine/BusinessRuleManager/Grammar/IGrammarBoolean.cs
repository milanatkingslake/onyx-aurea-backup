// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Interface for boolean grammar processing classes.
	/// </summary>
	public interface IGrammarBoolean
	{
		#region Public methods
		/// <summary>
		/// Test the provided data node using the configured boolean grammar and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to test boolean expression against.</param>
		/// <returns>boolean value based on grammar processing.</returns>
		bool EvaluateBoolean(XmlNode pDataNode);
		#endregion
	}
}
