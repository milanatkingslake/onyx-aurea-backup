// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Simple container that processes all child grammar expressions.
	/// </summary>
	public class ProcessContainer
		: GrammarBase,
		IGrammarProcess
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public ProcessContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public ProcessContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarProcess Members
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public virtual void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			IGrammarProcess process;
			XmlNodeList childElements = this.GetChildElements();

			// Process each child expression
			foreach (XmlNode configNode in childElements)
			{
				process = (IGrammarProcess)GrammarBase.CreateInstance(configNode, typeof(IGrammarProcess), this);
				process.Process(pDataNode);
			}
		}
		#endregion

		#region Static methods
		/// <summary>
		/// Create an instance and evaluate the provided data node.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public static void Process(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarProcess grammar = new ProcessContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			grammar.Process(pDataNode);
		}
		#endregion
	}
}
