// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Copy a file in the local file system.
	/// </summary>
	public class CopyFile
		: GrammarBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			XmlNode sourceNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:source", this.namespaceManager);
			XmlNode targetNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:target", this.namespaceManager);

			// Get source, target
			string source = StringContainer.EvaluateString(sourceNode, this.engine, pDataNode, this.namespaceManager);
			string target = StringContainer.EvaluateString(targetNode, this.engine, pDataNode, this.namespaceManager);

			// Get file info
			System.IO.FileInfo file;
			try
			{
				file = new System.IO.FileInfo(source);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.FileNotFound,
					source,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Copy to target file name
			try
			{
				file.CopyTo(target, true);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorAccessingFile,
					target,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}
		}
		#endregion
	}
}
