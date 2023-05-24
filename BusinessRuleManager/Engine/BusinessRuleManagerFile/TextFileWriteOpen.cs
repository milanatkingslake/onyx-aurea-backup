// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Open a text file for writing.
	/// </summary>
	public class TextFileWriteOpen
		: TextFileWriteBase,
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

			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			XmlNode appendNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:append", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get name, flag to append
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			bool append = BooleanContainer.EvaluateBoolean(appendNode, this.engine, pDataNode, this.namespaceManager);

			// Open file
			TextWriter writer = new StreamWriter(name, append);

			// Store the writer in the cache temporarily
			this.engine.cache.Write(this.GetCacheKey(), writer);

			try
			{
				// Execute the child rules
				ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);
			}
			finally
			{
				// Remove file info from cache
				this.engine.cache.Remove(this.GetCacheKey());
				writer.Close();
			}
		}
		#endregion
	}
}
