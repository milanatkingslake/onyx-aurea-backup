// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;
using ConsonaCRM.BusinessRuleManager.Cache;

namespace ConsonaCRM.BusinessRuleManager.Grammar
{
	/// <summary>
	/// Abstract base class for all grammar expression classes.
	/// </summary>
	public abstract class GrammarBase
	{
		#region Private fields
		private InternalEngine m_engine = null;
		private XmlNode m_metadataNode = null;
		private XmlNamespaceManager m_namespaceManager = null;
		#endregion

		#region Public properties
		/// <summary>
		/// Base rules engine for use in processing rules grammar.
		/// </summary>
		public InternalEngine engine
		{
			get
			{
				return m_engine;
			}
			set
			{
				m_engine = value;
			}
		}
		/// <summary>
		/// XML metadata node containing rules grammar definition.
		/// </summary>
		public XmlNode metadataNode
		{
			get
			{
				return m_metadataNode;
			}
			set
			{
				m_metadataNode = value;
			}
		}
		/// <summary>
		/// Indicates if the grammar node is active.
		/// </summary>
		public bool isActive
		{
			get
			{
				// Not active if there's no metadata node
				if (this.metadataNode == null)
				{
					return false;
				}
				// Default active if there's no active attribute
				if (this.metadataNode.SelectSingleNode("@active[.='0']") != null)
				{
					return false;
				}
				return true;
			}
		}
		/// <summary>
		/// XML namespace manager for the document.
		/// </summary>
		public XmlNamespaceManager namespaceManager
		{
			get
			{
				return m_namespaceManager;
			}
			set
			{
				m_namespaceManager = value;
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
/* Don't display full assembly and class name
				return Assembly.GetAssembly(GetType()).GetName().Name +
						" : " + GetType().FullName;
*/
				return GetType().Name;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor
		/// </summary>
		public GrammarBase()
		{
		}
		/// <summary>
		/// Construct using reference to dependent objects.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		public GrammarBase(XmlNode pMetadataNode,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager)
		{
			this.metadataNode = pMetadataNode;
			this.engine = pEngine;
			this.namespaceManager = pNamespaceManager;
		}
		#endregion

		#region Public static methods
		/// <summary>
		/// Creates a new instance of the grammar processing class
		/// mapped to the provided metadata node.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pRequiredInterfaceType">Type of the grammar interface that the instance must implement.
		/// Use null value if any interface will be accepted.</param>
		/// <param name="pEngine">Base rules engine for use in processing rules grammar.</param>
		/// <param name="pNamespaceManager">XML namespace manager for the grammar document.</param>
		/// <remarks>Uses the grammar definition cache to lookup the class mapped to the metadata node,
		/// then attempts to create an instance of the required node.</remarks>
		/// <returns>Grammar process class derived from GrammarBase.</returns>
		public static GrammarBase CreateInstance(XmlNode pMetadataNode,
			Type pRequiredInterfaceType,
			InternalEngine pEngine,
			XmlNamespaceManager pNamespaceManager)
		{
			string assemblyClassName = MethodBase.GetCurrentMethod().DeclaringType.Name;

			// Get name of class to create
			GrammarDefinition definition = pEngine.grammarDefinitionCache.GetDefinition(pMetadataNode.LocalName);

			// Check that the required interface is implemented
			if (pRequiredInterfaceType != null)
			{
				if (!definition.ImplementsInterface(pRequiredInterfaceType))
				{
					throw new BusinessRuleManagerException(assemblyClassName,
						(long)SystemMessage.MessageId.InterfaceNotImplemented,
						definition.className + "~" + pRequiredInterfaceType.FullName,
						pMetadataNode.OuterXml,
						BusinessRuleManagerErrorType.BusinessLogic,
						BusinessRuleManagerSourceType.Component,
						MethodBase.GetCurrentMethod().Name);
				}
			}

			// Get reference to current assembly
			Assembly thisAssembly = Assembly.Load(definition.assemblyName);

			// Create instance of required type
			GrammarBase newInstance = (GrammarBase)thisAssembly.CreateInstance(definition.className);
			if (newInstance == null)
			{
				throw new BusinessRuleManagerException(assemblyClassName,
					(long)SystemMessage.MessageId.ErrorCreatingInstance,
					definition.className,
					pMetadataNode.OuterXml,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Initialize instance and return
			newInstance.metadataNode = pMetadataNode;
			newInstance.engine = pEngine;
			newInstance.namespaceManager = pNamespaceManager;

			return newInstance;
		}
		/// <summary>
		/// Creates a new instance of the grammar processing class
		/// mapped to the provided metadata node.
		/// </summary>
		/// <param name="pMetadataNode">Metadata node to create an instance for.</param>
		/// <param name="pRequiredInterfaceType">Type of the grammar interface that the instance must implement.</param>
		/// <param name="pGrammarBase">Reference to another grammar definition instance
		/// (used to copy member references).</param>
		/// <remarks>Uses the grammar definition cache to lookup the class mapped to the metadata node,
		/// then attempts to create an instance of the required node.</remarks>
		/// <returns>Grammar process class derived from GrammarBase.</returns>
		public static GrammarBase CreateInstance(XmlNode pMetadataNode,
			Type pRequiredInterfaceType,
			GrammarBase pGrammarBase)
		{
			// Call other override, passing reference to helper classes
			return CreateInstance(pMetadataNode,
				pRequiredInterfaceType,
				pGrammarBase.engine,
				pGrammarBase.namespaceManager);
		}
		#endregion

		#region Protected methods
		/// <summary>
		/// Returns a list of all child elements (excludes comments and other types of nodes).
		/// </summary>
		/// <returns>XmlNodeList containing list of child elements.</returns>
		protected XmlNodeList GetChildElements()
		{
			return this.GetChildElements(this.metadataNode);
		}
		/// <summary>
		/// Returns a list of all child elements (excludes comments and other types of nodes).
		/// </summary>
		/// <param name="pParentNode">Parent metadata node.</param>
		/// <returns>XmlNodeList containing list of child elements.</returns>
		protected XmlNodeList GetChildElements(XmlNode pParentNode)
		{
			return pParentNode.SelectNodes("./brm:*[not(@active='0') and not(@mode!='" + this.engine.settingsCache.GetSetting("mode") + "')]", this.namespaceManager);
		}
		#endregion
	}
}
