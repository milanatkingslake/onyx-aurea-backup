// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Interface for grammar processing classes that do not return a value.
	/// </summary>
	/// <remarks>
	/// This interface is similar to IGrammarProcess, but provides both a source
	/// and target node to allow for operations that span multiple XML documents.
	/// </remarks>
	public interface IGrammarProcess2
	{
		#region Public methods
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		void Process(XmlNode pSourceNode, XmlNode pTargetNode);
		#endregion
	}
}
