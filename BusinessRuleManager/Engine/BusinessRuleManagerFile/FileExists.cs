// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Checks if a file exists in the file system.
	/// </summary>
	public class FileExists
		: GrammarBase,
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

			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);

			// Get name
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);

			// Get file info
			System.IO.FileInfo file = new System.IO.FileInfo(name);

			// Check that file exists
			return file.Exists;
		}
		#endregion
	}
}
