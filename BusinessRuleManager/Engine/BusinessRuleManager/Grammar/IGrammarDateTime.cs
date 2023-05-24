// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Interface for date/time grammar processing classes.
	/// </summary>
	public interface IGrammarDateTime
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured date/time grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>DateTime value based on grammar processing.</returns>
		DateTime EvaluateDateTime(XmlNode pDataNode);
		#endregion
	}
}
