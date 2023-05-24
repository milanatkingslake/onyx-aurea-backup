// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean
{
	/// <summary>
	/// Implements a simple boolean container, used to evaluate
	/// a single child boolean grammar expression.
	/// </summary>
	public class BooleanContainer
		: GrammarBase,
		IGrammarBoolean
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public BooleanContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public BooleanContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarBoolean Members
		public virtual bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return true;

			// Expects 1 child implementing IGrammarBoolean
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
			IGrammarBoolean boolGrammar = (IGrammarBoolean)GrammarBase.CreateInstance(childNodes[0], typeof(IGrammarBoolean), this);
			return boolGrammar.EvaluateBoolean(pDataNode);
		}
		#endregion

		#region Static methods
		/// <summary>
		/// Create an instance and evaluate the provided data node.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pDataNode">Node to test boolean expression against.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		/// <returns></returns>
		public static bool EvaluateBoolean(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarBoolean grammar = new BooleanContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			return grammar.EvaluateBoolean(pDataNode);
		}
		#endregion
	}
}
