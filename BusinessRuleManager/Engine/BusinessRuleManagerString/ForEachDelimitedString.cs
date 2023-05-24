// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Provide information on all files from the local file system
	/// that match a provided path and name search.
	/// </summary>
	public class ForEachDelimitedString
		: DelimitedStringBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public virtual void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			XmlNode valueNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:value", this.namespaceManager);
			XmlNode separatorNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:separator", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get value
			string value = StringContainer.EvaluateString(valueNode, this.engine, pDataNode, this.namespaceManager);
			string separator = StringContainer.EvaluateString(separatorNode, this.engine, pDataNode, this.namespaceManager);

			// Split string
			string[] delimitedStrings = value.Split(separator.ToCharArray());

			// Process child rules for each string
			foreach (string delimitedString in delimitedStrings)
			{
				// Store the string in the cache temporarily
				this.engine.cache.Write(this.GetCacheKey(), delimitedString);

				bool breakDetected = false;

				try
				{
					// Execute the child rules
					ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);
				}
				catch (BusinessRuleManagerBreakException)
				{
					breakDetected = true;
				}
				catch (BusinessRuleManagerContinueException)
				{
					// Allow loop to continue
				}

				// Remove string from cache
				this.engine.cache.Remove(this.GetCacheKey());

				// Break if requested
				if (breakDetected)
				{
					break;
				}
			}
		}
		#endregion
	}
}
