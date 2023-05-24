// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
	/// <summary>
	/// Implements a simple date/time container, used to evaluate
	/// a single child date/time grammar expression.
	/// </summary>
	public class DateTimeContainer
		: GrammarBase,
		IGrammarDateTime
	{
		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public DateTimeContainer()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public DateTimeContainer(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager) :
			base(pMetadataNode,
				pEngine,
				pNamespaceManager)
		{
		}
		#endregion

		#region IGrammarDateTime Members
		public virtual DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			// Expects 1 child implementing IGrammarDateTime
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
			IGrammarDateTime dateGrammar = (IGrammarDateTime)GrammarBase.CreateInstance(childNodes[0], typeof(IGrammarDateTime), this);
			return dateGrammar.EvaluateDateTime(pDataNode);
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
		public static DateTime EvaluateDateTime(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNode pDataNode,
			XmlNamespaceManager pNamespaceManager)
		{
			IGrammarDateTime grammar = new DateTimeContainer(pMetadataNode,
				pEngine,
				pNamespaceManager);
			return grammar.EvaluateDateTime(pDataNode);
		}
		#endregion
	}
}
