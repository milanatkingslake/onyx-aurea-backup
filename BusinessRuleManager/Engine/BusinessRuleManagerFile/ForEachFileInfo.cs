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
	/// Provide information on all files from the local file system
	/// that match a provided path and name search.
	/// </summary>
	public class ForEachFileInfo
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
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);
			XmlNode rulesNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:rules", this.namespaceManager);

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			string path = StringContainer.EvaluateString(pathNode, this.engine, pDataNode, this.namespaceManager);

			// Get file info
			DirectoryInfo directory = new DirectoryInfo(path);
			System.IO.FileInfo[] files = directory.GetFiles(name);

			// Process child rules for each file
			foreach (System.IO.FileInfo file in files)
			{
				// Store the file info in the cache temporarily
				this.engine.cache.Write(this.GetCacheKey(), file);

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

				// Remove file info from cache
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
