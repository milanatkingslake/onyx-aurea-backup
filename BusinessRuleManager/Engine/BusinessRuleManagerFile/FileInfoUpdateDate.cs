// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Returns file update date for a file from the local file system.
	/// This class expects that a parent FileInfo instance has placed a file 
	/// </summary>
	public class FileInfoUpdateDate
		: FileInfoBase,
		IGrammarDateTime
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured date/time grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>DateTime value based on grammar processing.</returns>
		public DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			System.IO.FileInfo file = this.GetCachedInfo();
			return file.LastWriteTimeUtc;
		}
		#endregion
	}
}
