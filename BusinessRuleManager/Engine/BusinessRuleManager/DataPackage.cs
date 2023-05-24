// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Business Rule Manager data package structure.
	/// </summary>
	public class DataPackage
	{
		#region Private fields
		private XmlDocument m_xmlDoc = null;
		private XmlNode m_contextNode = null;
		private bool m_initialized = false;
		#endregion

		#region Public properties
		/// <summary>
		/// XML document containing package data.
		/// </summary>
		public XmlDocument xmlDoc
		{
			get
			{
				return m_xmlDoc;
			}
			set
			{
				m_xmlDoc = value;
			}
		}
		/// <summary>
		/// Context node in package.
		/// </summary>
		public XmlNode contextNode
		{
			get
			{
				return m_contextNode;
			}
		}
		/// <summary>
		/// Indicates if the step package object has been initialized.
		/// </summary>
		public bool initialized
		{
			get
			{
				return m_initialized;
			}
		}
		#endregion

		#region Protected properties
		/// <summary>
		/// Provides access to the assembly and class name for this class.
		/// </summary>
		protected string assemblyClassName
		{
			get
			{
				return GetType().Name;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor.
		/// </summary>
		public DataPackage()
		{
		}

		/// <summary>
		/// Constructor that sets package content from an XML document.
		/// </summary>
		public DataPackage(XmlDocument pXmlDoc, XmlNode pContextNode)
		{
			this.SetDocument(pXmlDoc, pContextNode);
		}

		/// <summary>
		/// Constructor that sets package content from an XML string.
		/// </summary>
		public DataPackage(string psXmlString)
		{
			this.SetDocument(psXmlString);
		}

		/// <summary>
		/// Constructor that sets data package content from another data package.
		/// </summary>
		public DataPackage(DataPackage pDataPackage)
		{
			this.SetDocument(pDataPackage);
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Setup the package using an XML document.
		/// </summary>
		/// <param name="pXmlDoc">XML document that has package content.</param>
		/// <param name="pContextNode">Node containing current XML context.</param>
		public void SetDocument(XmlDocument pXmlDoc, XmlNode pContextNode)
		{
			this.xmlDoc = pXmlDoc;

			// Set context to root document element
			this.m_contextNode = pContextNode;

			// Indicate the object is initialized
			m_initialized = true;
		}
		/// <summary>
		/// Setup the step package using an XML string.
		/// </summary>
		/// <param name="psXmlString">XML string that has step package content.</param>
		public void SetDocument(string psXmlString)
		{
			XmlDocument newDoc = new XmlDocument();
			try
			{
				newDoc.LoadXml(psXmlString);
			}
			catch (XmlException e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					"Error parsing step package XML.",
					psXmlString,
					e);
			}
			this.SetDocument(newDoc, newDoc.DocumentElement);
		}
		/// <summary>
		/// Setup the step package using another step package.
		/// </summary>
		/// <param name="pSourcePackage">Step package to clone content from.</param>
		public void SetDocument(DataPackage pSourcePackage)
		{
			this.SetDocument(pSourcePackage.xmlDoc.OuterXml);
		}
		#endregion
	}
}
