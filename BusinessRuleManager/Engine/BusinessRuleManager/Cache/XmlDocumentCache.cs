// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Cache
{
	/// <summary>
	/// Provides access to cached XML documents.
	/// </summary>
	public class XmlDocumentCache
	{
		#region Private fields
		private XmlDocument m_xmlDoc;
		private string m_cachePrefix = "";
		private string m_cachePrefixNamespaceMgr = "";
		private LocalCache m_cache = null;
		private bool m_enableCaching = false;
		private XmlNamespaceManager m_namespaceManager = null;
		#endregion

		#region Public properties
		/// <summary>
		/// XML document in cache.
		/// </summary>
		public XmlDocument xmlDoc
		{
			get
			{
				return m_xmlDoc;
			}
		}
		/// <summary>
		/// Cache key prefix to use when caching documents.
		/// </summary>
		public string cachePrefix
		{
			get
			{
				return m_cachePrefix;
			}
			set
			{
				m_cachePrefix = value;
			}
		}
		/// <summary>
		/// Cache key prefix to use when caching namespace managers.
		/// </summary>
		public string cachePrefixNamespaceMgr
		{
			get
			{
				return m_cachePrefixNamespaceMgr;
			}
			set
			{
				m_cachePrefixNamespaceMgr = value;
			}
		}
		/// <summary>
		/// Cache to use when caching documents.
		/// </summary>
		public LocalCache cache
		{
			get
			{
				return m_cache;
			}
			set
			{
				m_cache = value;
			}
		}
		/// <summary>
		/// Indicates if caching is enabled
		/// </summary>
		public bool enableCaching
		{
			get
			{
				return m_enableCaching;
			}
			set
			{
				m_enableCaching = value;
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
		/// Construct an instance using provided cache settings.
		/// </summary>
		/// <param name="pbEnableCaching">Indicates if caching is enabled.</param>
		/// <param name="psCachePrefix">Cache key prefix to use when caching documents.</param>
		/// <param name="psNamespaceManagerSuffix">Cache key suffix to use when caching namespace managers.</param>
		/// <param name="pCache">Cache to use when caching documents.</param>
		public XmlDocumentCache(bool pbEnableCaching, string psCachePrefix, string psNamespaceManagerSuffix, LocalCache pCache)
		{
			this.enableCaching = pbEnableCaching;
			this.cachePrefix = psCachePrefix;
			this.cachePrefixNamespaceMgr = psCachePrefix + psNamespaceManagerSuffix;
			this.cache = pCache;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Load the XML document.
		/// Checks for a cached version first, and if not found, loads from file.
		/// </summary>
		/// <param name="filePath">Path to XML file to cache.</param>
		public virtual void Load(string filePath)
		{
			string cacheKey = this.cachePrefix + filePath;
			string cacheKeyNamespaceMgr = this.cachePrefixNamespaceMgr + filePath;

			// Get from cache first
			if (this.enableCaching)
			{
				if (this.cache.ContainsKey(cacheKey))
				{
					m_xmlDoc = (XmlDocument)cache.Read(cacheKey);
					m_namespaceManager = (XmlNamespaceManager)cache.Read(cacheKeyNamespaceMgr);
					return;
				}
			}
			// Load from file if not in cache
			m_xmlDoc = new XmlDocument();
			try
			{
				m_xmlDoc.Load(filePath);
				// Create namespace manager, assume document element has BRM namespace
				m_namespaceManager = new XmlNamespaceManager(m_xmlDoc.NameTable);
				m_namespaceManager.AddNamespace("brm", m_xmlDoc.DocumentElement.NamespaceURI);
			}
			catch (Exception e)
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ErrorLoadingMetadataFile,
					filePath,
					e.Message,
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Write to cache
			if (this.enableCaching)
			{
				this.cache.Write(cacheKey, m_xmlDoc);
				this.cache.Write(cacheKeyNamespaceMgr, m_namespaceManager);
			}
		}
		/// <summary>
		/// Remove the document from the cache.
		/// </summary>
		/// <param name="filePath">Path to XML file to cache.</param>
		public virtual void Remove(string filePath)
		{
			string cacheKey = this.cachePrefix + filePath;

			// Check if the document is in the cache
			if (this.enableCaching)
			{
				if (this.cache.ContainsKey(cacheKey))
				{
					this.cache.Remove(cacheKey);
				}
			}
		}
		#endregion
	}
}
