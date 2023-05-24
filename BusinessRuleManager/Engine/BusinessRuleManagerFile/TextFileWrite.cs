// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Xml;

using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Write a string to a text file.
	/// </summary>
	public class TextFileWrite
		: TextFileWriteBase,
		IGrammarProcess
	{
		#region IGrammarProcess Members
		public void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get text to write
			string textToWrite = StringContainer.EvaluateString(this.metadataNode, this.engine, pDataNode, this.namespaceManager);

			// Write to file
			TextWriter writer = this.GetCachedInfo();
			writer.Write(textToWrite);
		}
		#endregion
	}
}
