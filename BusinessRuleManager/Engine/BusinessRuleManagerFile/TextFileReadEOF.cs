// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Read a string from a text file.
	/// </summary>
	public class TextFileReadEOF
		: TextFileReadBase,
		IGrammarBoolean
	{
		#region IGrammarBoolean Members
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(bool);

			// Read from file
			TextReader reader = this.GetCachedInfo();
			return (reader.Peek() == -1);
		}
		#endregion
	}
}
