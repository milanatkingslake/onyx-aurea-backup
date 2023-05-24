// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Data;
using System.Data.Odbc;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
	/// <summary>
	/// Adds a parameter to an ODBC call.
	/// </summary>
	public class OdbcAddParameter
		: OdbcBase,
		IGrammarProcess
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured grammar.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		public virtual void Process(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return;

			// Get command
			OdbcCommand command = this.GetCachedCommand();

			// Add parameter
			OdbcParameter param = new OdbcParameter();

			// Get name
			XmlNode childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			param.ParameterName = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);

			// Get type
			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:type", this.namespaceManager);
			string type = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);
			try
			{
				param.OdbcType = (OdbcType)Enum.Parse(typeof(OdbcType),
					type,
					true);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.OdbcInvalidDataType,
					type,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Get direction
			childNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:direction", this.namespaceManager);
			string direction = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);
			try
			{
				param.Direction = (ParameterDirection)Enum.Parse(typeof(ParameterDirection),
					direction,
					true);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.OdbcInvalidParameterDirection,
					direction,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Get size
			childNode = this.metadataNode.SelectSingleNode("brm:size", this.namespaceManager);
			if (childNode != null)
			{
				param.Size = (int)IntegerContainer.EvaluateInteger(childNode, this.engine, pDataNode, this.namespaceManager);
			}

			// Get value
			childNode = this.metadataNode.SelectSingleNode("brm:value", this.namespaceManager);
			if (childNode != null)
			{
				param.Value = StringContainer.EvaluateString(childNode, this.engine, pDataNode, this.namespaceManager);
			}

			// Add parameter to command
			command.Parameters.Add(param);
		}
		#endregion
	}
}
