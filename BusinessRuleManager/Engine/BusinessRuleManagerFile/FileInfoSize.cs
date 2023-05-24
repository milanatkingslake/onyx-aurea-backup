// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Returns file size for a file from the local file system.
	/// This class expects that a parent FileInfo instance has placed a file 
	/// </summary>
	public class FileInfoSize
		: FileInfoBase,
		IGrammarInteger
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured integer grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>integer value based on grammar processing.</returns>
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			System.IO.FileInfo file = this.GetCachedInfo();
			return (int)file.Length;
		}
		#endregion
	}
}
