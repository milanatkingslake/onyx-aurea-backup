// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Cache
{
	/// <summary>
	/// Provides access to cached settings.
	/// </summary>
	public class SettingsCache : XmlDocumentCache
	{
		#region Constructor
		/// <summary>
		/// Construct an instance using provided cache settings.
		/// </summary>
		/// <param name="pbEnableCaching">Indicates if caching is enabled.</param>
		/// <param name="psCachePrefix">Cache key prefix to use when caching metadata documents.</param>
		/// <param name="psNamespaceManagerSuffix">Cache key suffix to use when caching namespace managers.</param>
		/// <param name="pCache">Cache to use when caching metadata documents.</param>
		public SettingsCache(bool pbEnableCaching, string psCachePrefix, string psNamespaceManagerSuffix, LocalCache pCache)
			:
			base(pbEnableCaching, psCachePrefix, psNamespaceManagerSuffix, pCache)
		{
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Load the grammar definition cache.
		/// Checks for a cached version first, and if not found, loads from file.
		/// </summary>
		/// <param name="filePath">Path to XML file to cache.</param>
		public override void Load(string filePath)
		{
			// Load the cache
			base.Load(filePath);

			// Check setting to determine if caching should be enabled
			this.enableCaching = this.GetSetting("enableCaching") == "1";
		}
		/// <summary>
		/// Get an application setting from the cached settings.
		/// </summary>
		/// <param name="psName">Name of the setting.</param>
		/// <returns>String value of the setting.</returns>
		public string GetSetting(string psName)
		{
			return XmlUtil.GetNodeValue(this.xmlDoc.DocumentElement, "//setting[@name='" + psName + "']/@value", false, "");
		}
		#endregion
	}
}
