// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using ConsonaCRM.BusinessRuleManager;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	/// <summary>
	/// Perform an XSLT transform on a source node and store the output
	/// in a target node.
	/// </summary>
	public class XSLT
		: GrammarBase,
		IGrammarString
	{
		#region Public methods
		/// <summary>
		/// Process the provided data node using the configured string grammar
		/// and return the result.
		/// </summary>
		/// <param name="pDataNode">Node to use when processing grammar.</param>
		/// <returns>string value based on grammar processing.</returns>
		public string EvaluateString(XmlNode pDataNode)
		{
			// Check if active
			if (!this.isActive) return default(string);

			// Get child nodes in metadata
			XmlNode nameNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:name", this.namespaceManager);
			XmlNode pathNode = XmlUtil.GetRequiredNode(this.metadataNode, "brm:path", this.namespaceManager);

			// Get name, path
			string path = StringContainer.EvaluateString(pathNode, this.engine, pDataNode, this.namespaceManager);
			if (path == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					pathNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			string name = StringContainer.EvaluateString(nameNode, this.engine, pDataNode, this.namespaceManager);
			if (name == string.Empty)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.EvaluatesToEmptyString,
					nameNode.Name,
					this.metadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Find source node
			XmlNode sourceNode = pDataNode.SelectSingleNode(path);
			if (sourceNode == null)
			{
				return default(string);
			}

			// Load XSLT from file
			XmlDocument xsltDoc = new XmlDocument();
			try
			{
				xsltDoc.Load(name);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorAccessingFile,
					name,
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name,
					e);
			}

			// Load into transform
			XslCompiledTransform xslTransform = new XslCompiledTransform();
			xslTransform.Load(xsltDoc);

			// Perform transform
			StringWriter resultWriter = new StringWriter();
			XsltArgumentList xslArgs = new XsltArgumentList();
			xslTransform.Transform(sourceNode, xslArgs, resultWriter);

			return resultWriter.ToString();
		}
		#endregion
	}
}
