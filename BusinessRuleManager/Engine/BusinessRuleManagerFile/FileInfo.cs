// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Provide information on a file from the local file system.
	/// </summary>
	public class FileInfo
		: FileInfoBase,
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
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);

			// Get file info
			System.IO.FileInfo file = new System.IO.FileInfo(name);

			// Check that file exists
			if (!file.Exists)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.FileNotFound,
					name,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Store the file info in the cache temporarily
			this.engine.cache.Write(this.GetCacheKey(), file);

			// Execute the child rules
			ProcessContainer.Process(rulesNode, this.engine, pDataNode, this.namespaceManager);

			// Remove file info from cache
			this.engine.cache.Remove(this.GetCacheKey());
		}
		#endregion
	}
}
