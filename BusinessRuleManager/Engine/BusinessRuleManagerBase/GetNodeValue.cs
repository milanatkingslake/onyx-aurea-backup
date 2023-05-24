// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
	/// <summary>
	/// Returns the value of an XML node converted to the type required
	/// by the grammar interfaces.
	/// </summary>
	public class GetNodeValue
		: GrammarBase,
		IGrammarBoolean,
		IGrammarDateTime,
		IGrammarFloat,
		IGrammarInteger,
		IGrammarString
	{
		#region IGrammarBoolean Members
		public virtual bool EvaluateBoolean(XmlNode pDataNode)
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
		public virtual DateTime EvaluateDateTime(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(DateTime);

			return DateTime.Parse(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarFloat Members
		public virtual double EvaluateFloat(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(double);

			return Literal.ConvertToFloat(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarInteger Members
		public virtual long EvaluateInteger(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(int);

			return Literal.ConvertToInt(this.EvaluateString(pDataNode));
		}
		#endregion

		#region IGrammarString Members
		public virtual string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			string path = this.GetPath(pDataNode);

			// Get value of node
			return XmlUtil.GetNodeValue(pDataNode, path, false, string.Empty);
		}
		#endregion

		#region Protected methods
		protected string GetPath(XmlNode pDataNode)
		{
			// Get path
			string path = StringContainer.EvaluateString(this.metadataNode, this.engine, pDataNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return path;
		}
		#endregion
	}
}
