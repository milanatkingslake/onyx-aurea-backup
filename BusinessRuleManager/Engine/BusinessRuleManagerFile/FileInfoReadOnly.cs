// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Returns true if a file from the local file system is read-only.
	/// This class expects that a parent FileInfo instance has placed a file 
	/// </summary>
	public class FileInfoReadOnly
		: FileInfoBase,
		IGrammarBoolean
	{
		#region Public methods
		/// <summary>
		/// Test the provided data node using the configured boolean grammar and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to test boolean expression against.</param>
		/// <returns>boolean value based on grammar processing.</returns>
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(bool);

			System.IO.FileInfo file = this.GetCachedInfo();
			return file.IsReadOnly;
		}
		#endregion
	}
}
