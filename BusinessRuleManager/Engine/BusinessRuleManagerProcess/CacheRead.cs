// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Returns a typed value from the application cache.
	/// </summary>
	public class CacheRead
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

			string name = this.GetName(pDataNode);

			// Return value from cache
			if (this.engine.cache.ContainsKey(name))
			{
				return this.engine.cache.Read(name).ToString();
			}

			return string.Empty;
		}
		#endregion

		#region Protected methods
		protected string GetName(XmlNode pDataNode)
		{
			// Get name
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					this.metadataNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return name;
		}
		#endregion
	}
}
