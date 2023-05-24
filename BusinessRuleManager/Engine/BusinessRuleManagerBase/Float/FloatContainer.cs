// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
	/// <summary>
	/// Implements a simple float container, used to evaluate
	/// a single child float grammar expression.
	/// </summary>
	public class FloatContainer
		: GrammarBase,
		IGrammarFloat
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public FloatContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public FloatContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarFloat Members
		public virtual double EvaluateFloat(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(double);

			// Expects 1 child implementing IGrammarFloat
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
			IGrammarFloat floatGrammar = (IGrammarFloat)GrammarBase.CreateInstance(childNodes[0], typeof(IGrammarFloat), this);
			return floatGrammar.EvaluateFloat(pDataNode);
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
		public static double EvaluateFloat(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarFloat grammar = new FloatContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			return grammar.EvaluateFloat(pDataNode);
		}
		#endregion
	}
}
