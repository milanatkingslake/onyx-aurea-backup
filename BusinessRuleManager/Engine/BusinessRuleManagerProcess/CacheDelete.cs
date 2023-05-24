// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Deletes a value from the application cache.
	/// </summary>
	public class CacheDelete
		: GrammarBase,
		IGrammarProcess,
		IGrammarProcess2
	{
		#region Public Members
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			this.Process(pDataNode, pDataNode);
		}
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public void Process(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Check if active
			if (!this.isActive) return;

			string name = this.GetName(pSourceNode);

			// Delete value from cache
			if (this.engine.cache.ContainsKey(name))
			{
				this.engine.cache.Remove(name);
			}
		}
		#endregion

		#region Protected methods
		protected string GetName(XmlNode pDataNode)
		{
			// Get name
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return name;
		}
		#endregion
	}
}
