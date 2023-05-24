// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Writes a value to the application cache.
	/// </summary>
	public class CacheWrite
		: SetNodeValue
	{
		#region Public methods
		/// <summary>
		/// Process the provided source and target nodes using the configured grammar.
		/// </summary>
		/// <param name="pSourceNode">Source node to use when processing grammar.</param>
		/// <param name="pTargetNode">Target node to use when processing grammar.</param>
		public override void Process(XmlNode pSourceNode, XmlNode pTargetNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get name
			string name = this.GetName(pSourceNode);

			// Get value as string
			string value = this.GetValue(pSourceNode);

			// Get expiration date if provided
			XmlNode expiresNode = this.metadataNode.SelectSingleNode("brm:expires", this.namespaceManager);

			// If no expiration date, just cache the value
			if (expiresNode == null)
			{
				// Save the value in the cache
				this.engine.cache.Write(name, value);
			}
			else
			{
				// Get expiration date
				DateTime expirationDate = DateTimeContainer.EvaluateDateTime(expiresNode, this.engine, pSourceNode, this.namespaceManager);

				// Save the value in the cache
				this.engine.cache.Write(name, value, expirationDate);
			}
		}
		#endregion

		#region Protected methods
		protected string GetName(XmlNode pDataNode)
		{
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);

			// Get name
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
