// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
	/// <summary>
	/// Implements a simple integer container, used to evaluate
	/// a single child integer grammar expression.
	/// </summary>
	public class IntegerContainer
		: GrammarBase,
		IGrammarInteger
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public IntegerContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pStepComponent">Base step component for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public IntegerContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarInteger Members
		public virtual long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			// Expects 1 child implementing IGrammarInteger
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
			IGrammarInteger intGrammar = (IGrammarInteger)GrammarBase.CreateInstance(childNodes[0], typeof(IGrammarInteger), this);
			return intGrammar.EvaluateInteger(pDataNode);
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
		public static long EvaluateInteger(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarInteger grammar = new IntegerContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			return grammar.EvaluateInteger(pDataNode);
		}
		#endregion
	}
}
