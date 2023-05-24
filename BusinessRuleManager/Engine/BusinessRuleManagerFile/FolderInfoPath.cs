// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Returns folder path for a folder from the local file system.
	/// This class expects that a parent FolderInfo instance has placed a folder
	/// in the cache.
	/// </summary>
	public class FolderInfoPath
		: FolderInfoBase,
		IGrammarString
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured string grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>string value based on grammar processing.</returns>
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			DirectoryInfo folder = this.GetCachedInfo();
			return folder.Parent.FullName;
		}
		#endregion
	}
}
