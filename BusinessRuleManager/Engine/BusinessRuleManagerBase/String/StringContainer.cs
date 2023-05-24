// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Implements a simple string container, used to evaluate
	/// a single child string grammar expression.
	/// </summary>
	public class StringContainer
		: GrammarBase,
		IGrammarString
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public StringContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public StringContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarString Members
		public virtual string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Expects 1 child implementing IGrammarString
			XmlNodeList childNodes = this.GetChildElements();
			if (childNodes.Count != 1)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.WrongChildCount,
					this.metadataNode.Name + "~1",
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}
			// Evaluate child expression
			IGrammarString stringGrammar = (IGrammarString)GrammarBase.CreateInstance(childNodes[0], typeof(IGrammarString), this);
			return stringGrammar.EvaluateString(pDataNode);
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
		/// <returns></returns>
		public static string EvaluateString(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarString grammar = new StringContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			return grammar.EvaluateString(pDataNode);
		}
		#endregion
	}
}
