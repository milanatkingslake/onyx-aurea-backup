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
	/// Provide information on all folders from the local file system
	/// that match a provided path and name search.
	/// </summary>
	public class ForEachFolderInfo
		: FolderInfoBase,
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
			DirectoryInfo[] folders = directory.GetDirectories(name);

			// Process child rules for each folder
			foreach (DirectoryInfo folder in folders)
			{
				// Store the folder info in the cache temporarily
				this.engine.cache.Write(this.GetCacheKey(), folder);

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

				// Remove folder info from cache
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
