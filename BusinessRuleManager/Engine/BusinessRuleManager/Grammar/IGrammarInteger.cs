// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Interface for integer grammar processing classes.
	/// </summary>
	public interface IGrammarInteger
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured integer grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>integer value based on grammar processing.</returns>
		long EvaluateInteger(XmlNode pDataNode);
		#endregion
	}
}
