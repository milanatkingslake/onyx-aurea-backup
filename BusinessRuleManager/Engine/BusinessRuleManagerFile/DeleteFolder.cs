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
	/// Deletes a new folder from the file system.
	/// </summary>
	public class DeleteFolder
		: GrammarBase,
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

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);

			// Get folder info
			DirectoryInfo folder = new DirectoryInfo(name);

			// Check that folder doesn't exist
			if (!folder.Exists)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.FolderNotFound,
					name,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Delete the folder
			try
			{
				folder.Delete();
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorDeletingFolder,
					name,
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
