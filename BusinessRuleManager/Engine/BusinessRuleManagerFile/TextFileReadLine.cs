// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Read a string from a text file.
	/// </summary>
	public class TextFileReadLine
		: TextFileReadBase,
		IGrammarString
	{
		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Read from file
			TextReader reader = this.GetCachedInfo();
			return reader.ReadLine();
		}
		#endregion
	}
}
