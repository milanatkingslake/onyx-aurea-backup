// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Returns the literal value of a node converted to the type required
	/// by the grammar interfaces.
	/// </summary>
	public class Literal
		: GrammarBase,
		IGrammarBoolean,
		IGrammarDateTime,
		IGrammarFloat,
		IGrammarInteger,
		IGrammarString
	{
		#region IGrammarBoolean Members
		public bool EvaluateBoolean(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(bool);

			// Convert string value to boolean
			// 1 = true, 0 or empty = false
			string nodeValue = this.EvaluateString(pDataNode);
			switch (nodeValue)
			{
				case "1":
					return true;
				case "0":
				case "":
					return false;
			}
			// Throw exception for invalid value
			throw new BusinessRuleManagerException(this.assemblyClassName,
				(long)SystemMessage.MessageId.ErrorConvertingDataType,
				"boolean~" + nodeValue,
				this.metadataNode.OuterXml,
				BusinessRuleManagerErrorType.BusinessLogic,
				BusinessRuleManagerSourceType.Component,
				MethodBase.GetCurrentMethod().Name);
		}
		#endregion

		#region IGrammarDateTime Members
		public DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			return DateTime.Parse(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarFloat Members
		public double EvaluateFloat(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(double);

			return float.Parse(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarInteger Members
		public long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			return Literal.ConvertToInt(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarString Members
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			return this.metadataNode.InnerText;
		}
		#endregion

		#region Public static methods
		/// <summary>
		/// Convert a boolean value to a string value.
		/// </summary>
		/// <param name="pbValue">Boolean value to convert.</param>
		/// <returns>Converted string value.</returns>
		public static string ConvertToString(bool pbValue)
		{
			return pbValue ? "1" : "0";
		}
		/// <summary>
		/// Convert a DateTime value to a string value.
		/// </summary>
		/// <param name="pValue">DateTime value to convert.</param>
		/// <returns>Converted string value.</returns>
		public static string ConvertToString(DateTime pValue)
		{
			return XmlUtil.DateTimeToTimestamp(pValue);
		}
		/// <summary>
		/// Convert an integer value to a string value.
		/// </summary>
		/// <param name="piValue">Integer value to convert.</param>
		/// <returns>Converted string value.</returns>
		public static string ConvertToString(long piValue)
		{
			return piValue.ToString();
		}
		/// <summary>
		/// Convert a floating point value to a string value.
		/// </summary>
		/// <param name="pValue">Floating point value to convert.</param>
		/// <returns>Converted string value.</returns>
		public static string ConvertToString(double pValue)
		{
			return pValue.ToString();
		}
		/// <summary>
		/// Convert a binary value to a string value using hexadecimal notation.
		/// </summary>
		/// <param name="pValue"></param>
		/// <returns></returns>
		public static string ConvertToString(byte[] pValue)
		{
            char[] hexDigits = {
                    '0', '1', '2', '3', '4', '5', '6', '7',
                    '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'
                    };
			char[] chars = new char[pValue.Length * 2];

			for (int i = 0; i < pValue.Length; i++)
			{
				int b = pValue[i];
				chars[i * 2] = hexDigits[b >> 4];
				chars[i * 2 + 1] = hexDigits[b & 0xF];
			}
			return new string(chars);
		}
		/// <summary>
		/// Convert a string to an integer value.
		/// </summary>
		/// <param name="psValue">String value to convert</param>
		/// <returns>Integer value.</returns>
		public static long ConvertToInt(string psValue)
		{
			return Convert.ToInt64(double.Parse(psValue, System.Globalization.NumberStyles.Number));
		}
		/// <summary>
		/// Convert a boolean value to an integer value.
		/// </summary>
		/// <param name="pbValue">Boolean value to convert</param>
		/// <returns>Integer value.</returns>
		public static long ConvertToInt(bool pbValue)
		{
			return pbValue ? 1 : 0;
		}
		/// <summary>
		/// Convert a floating point value to an integer value.
		/// </summary>
		/// <param name="pValue">Floating point value to convert</param>
		/// <returns>Integer value.</returns>
		public static long ConvertToInt(double pValue)
		{
			return Convert.ToInt64(pValue);
		}
		/// <summary>
		/// Convert a date/time value to an integer value.
		/// </summary>
		/// <param name="pValue">Date/time value to convert</param>
		/// <returns>Integer value.</returns>
		public static long ConvertToInt(DateTime pValue)
		{
			return pValue.Ticks;
		}
		/// <summary>
		/// Convert a string to a floating point value.
		/// </summary>
		/// <param name="psValue">String value to convert</param>
		/// <returns>Floating point value.</returns>
		public static double ConvertToFloat(string psValue)
		{
			return double.Parse(psValue, System.Globalization.NumberStyles.Number);
		}
		/// <summary>
		/// Convert a boolean value to a floating point value.
		/// </summary>
		/// <param name="pbValue">Boolean value to convert</param>
		/// <returns>Floating point value.</returns>
		public static double ConvertToFloat(bool pbValue)
		{
			return pbValue ? 1.0 : 0.0;
		}
		/// <summary>
		/// Convert an integer value to a floating point value.
		/// </summary>
		/// <param name="pValue">Integer value to convert</param>
		/// <returns>Floating point value.</returns>
		public static double ConvertToFloat(long pValue)
		{
			return Convert.ToDouble(pValue);
		}
		/// <summary>
		/// Convert a date/time value to a floating point value.
		/// </summary>
		/// <param name="pValue">Date/time value to convert</param>
		/// <returns>Floating point value.</returns>
		public static double ConvertToFloat(DateTime pValue)
		{
			return pValue.Ticks;
		}
		/// <summary>
		/// Convert a string value to a date/time value.
		/// </summary>
		/// <param name="pValue">String value to convert</param>
		/// <returns>Date/time point value.</returns>
		public static DateTime ConvertToDateTime(string pValue)
		{
			return DateTime.Parse(pValue);
		}
		#endregion
	}
}
