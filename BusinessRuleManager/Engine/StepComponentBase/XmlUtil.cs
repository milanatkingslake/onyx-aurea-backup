// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// XML utility static functions.
	/// </summary>
	public static class XmlUtil
	{
		/// <summary>
		/// Get a required XML node given a reference node and a valid XPath expression.
		/// If the node is not found a StepComponentException is thrown.
		/// </summary>
		/// <param name="pParentNode">Parent reference node for XPath expression.</param>
		/// <param name="psXPath">XPath expression to evaluate.</param>
		/// <returns>XMLNode referencing required node.</returns>
		public static XmlNode GetRequiredNode(XmlNode pParentNode, string psXPath)
		{
			XmlNode childNode = pParentNode.SelectSingleNode(psXPath);
			if (childNode == null)
			{
				string assemblyClassName = MethodBase.GetCurrentMethod().DeclaringType.Name;
				throw new StepComponentException(assemblyClassName,
					"Required XML node not found: " + psXPath,
					pParentNode.OuterXml);
			}

			return childNode;
		}
		/// <summary>
		/// Get the value of a required node given a reference node and a valid XPath expression.
		/// If the node is not found a StepComponentException is thrown.
		/// </summary>
		/// <param name="pParentNode">Parent reference node for XPath expression.</param>
		/// <param name="psXPath">XPath expression to evaluate.</param>
		/// <returns>String value of the node.</returns>
		public static string GetRequiredNodeValue(XmlNode pParentNode, string psXPath)
		{
			return GetRequiredNode(pParentNode, psXPath).InnerText;
		}
		/// <summary>
		/// Get the value of a node given a reference node and a valid XPath expression.
		/// If the node is not found the default value is returned.
		/// </summary>
		/// <param name="pParentNode">Parent reference node for XPath expression.</param>
		/// <param name="psXPath">XPath expression to evaluate.</param>
		/// <param name="pbHandleNull">Indicates if a null value should be handled</param>
		/// <param name="psDefaultValue">Default value to return if the node is not found.</param>
		/// <returns>Value of the node.</returns>
		public static string GetNodeValue(XmlNode pParentNode, string psXPath, bool pbHandleNull, string psDefaultValue)
		{
			XmlNode childNode = pParentNode.SelectSingleNode(psXPath);
			if (childNode == null)
			{
				return psDefaultValue;
			}
			if (childNode.NodeType == XmlNodeType.Element)
			{
				if (pbHandleNull)
				{
					XmlAttribute nullAttr = (XmlAttribute)childNode.Attributes.GetNamedItem(StepPackageAttributeName.Null);
					if (nullAttr != null)
					{
						if (nullAttr.InnerText == "1")
						{
							return null;
						}
					}
				}
			}

			return childNode.InnerText;
		}
		/// <summary>
		/// Get or create a child XML node given a reference node and a valid XPath expression.
		/// </summary>
		/// <param name="pParentNode">Parent reference node for XPath expression.</param>
		/// <param name="psXPath">XPath expression for node to get or create.</param>
		/// <returns>Child node.</returns>
		public static XmlNode GetOrCreateNode(XmlNode pParentNode, string psXPath)
		{
			// Find last slash character
			int separatorIndex = psXPath.LastIndexOf("/");
			// If the xpath has a root slash, then we're looking for a named root node
			// so this is required
			if (separatorIndex == 0)
			{
				return GetRequiredNode(pParentNode, psXPath);
			}

			// Find child node
			XmlNode childNode = pParentNode.SelectSingleNode(psXPath);
			if (childNode == null)
			{
				// If there is a slash character, remove last node name and get parent node
				if (separatorIndex > 0)
				{
					pParentNode = GetOrCreateNode(pParentNode, psXPath.Remove(separatorIndex));
				}
				// Add child node (element or attribute)
				string nodeName = psXPath.Substring(separatorIndex + 1);
				if (nodeName.StartsWith("@"))
				{
					XmlAttribute childAttr = pParentNode.OwnerDocument.CreateAttribute(nodeName.Substring(1));
					childNode = pParentNode.Attributes.SetNamedItem(childAttr);
				}
				else
				{
					childNode = pParentNode.AppendChild(pParentNode.OwnerDocument.CreateElement(psXPath.Substring(separatorIndex + 1)));
				}
			}

			return childNode;
		}
		/// <summary>
		/// Create a named child node and add to a parent element.
		/// If the name starts with "@" an attribute is added, otherwise
		/// an element is added.
		/// </summary>
		/// <param name="pParentNode">Parent node.</param>
		/// <param name="psNodeName">Name of child node.</param>
		/// <returns>XmlNode for new child element.</returns>
		public static XmlNode AddChildNode(XmlNode pParentNode, string psNodeName)
		{
			if (psNodeName.StartsWith("@"))
			{
				return pParentNode.Attributes.SetNamedItem(pParentNode.OwnerDocument.CreateAttribute(psNodeName.Substring(1)));
			}
			else
			{
				return pParentNode.AppendChild(pParentNode.OwnerDocument.CreateElement(psNodeName));
			}
		}
		/// <summary>
		/// Sets the value of a named child node.
		/// If the child element does not exist, it is created and appended.
		/// </summary>
		/// <param name="pParentNode">Parent node.</param>
		/// <param name="psNodeName">Name of child element.</param>
		/// <param name="psValue">Value of child element.</param>
		/// <param name="pbHandleNull">Indicates if a null value should be handled
		/// using the Onyx null attribute.</param>
		/// <returns>Reference to child element.</returns>
		public static XmlNode SetChildNodeValue(XmlNode pParentNode,
												string psNodeName,
												string psValue,
												bool pbHandleNull)
		{
			// Find node
			XmlNode childNode = XmlUtil.GetOrCreateNode(pParentNode, psNodeName);
			// Set node value
			childNode.InnerText = psValue;
			// Handle null values
			if (childNode.NodeType == XmlNodeType.Element)
			{
				if ((psValue != null) && (psValue != string.Empty))
				{
					childNode.Attributes.RemoveNamedItem(StepPackageAttributeName.Null);
				}
				else if (pbHandleNull)
				{
					// Set null attribute
					XmlAttribute nullAttr = pParentNode.OwnerDocument.CreateAttribute(StepPackageAttributeName.Null);
					nullAttr.InnerText = "1";
					childNode.Attributes.SetNamedItem(nullAttr);
				}
			}

			return childNode;
		}
		/// <summary>
		/// Convert a DateTime object to a timestamp string in the format
		/// YYYY-MM-DD HH:MM:SS.
		/// </summary>
		/// <param name="pDateTime">DateTime value to convert.</param>
		/// <returns>String in timestamp format.</returns>
		public static string DateTimeToTimestamp(DateTime pDateTime)
		{
			return pDateTime.ToString("u", System.Globalization.DateTimeFormatInfo.InvariantInfo).Substring(0, 19);
		}
		/// <summary>
		/// Convert a Guid object to string value in the format that includes
		/// hyphens and has all characters in upper case.
		/// </summary>
		/// <param name="pGuid">Guid to format.</param>
		/// <returns>String value of Guid in standard format.</returns>
		public static string FormatGuid(Guid pGuid)
		{
			return pGuid.ToString("D").ToUpperInvariant();
		}
		/// <summary>
		/// Parse an XML string and append the resulting node to a parent node.
		/// </summary>
		/// <param name="pParentNode">Parent node.</param>
		/// <param name="psXml">XML string.</param>
		/// <returns>Child XmlNode appended to parent.</returns>
		public static XmlNode AppendXmlFromString(XmlNode pParentNode, string psXml)
		{
			XmlDocumentFragment xmlFragment = pParentNode.OwnerDocument.CreateDocumentFragment();
			xmlFragment.InnerXml = psXml;
			return pParentNode.AppendChild(xmlFragment.FirstChild);
		}
	}
}
