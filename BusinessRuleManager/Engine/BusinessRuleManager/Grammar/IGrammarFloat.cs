// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Interface for floating point grammar processing classes.
	/// </summary>
	public interface IGrammarFloat
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured floating point grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>double value based on grammar processing.</returns>
		double EvaluateFloat(XmlNode pDataNode);
		#endregion
	}
}
