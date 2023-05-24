// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using OnyxEDCachePIA;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to the Onyx Enterprise Dictionary cache.
	/// </summary>
	public class OnyxDictionaryCache
	{
		#region Private fields
		private string m_applicationName;
		#endregion

		#region Public properties
		/// <summary>
		/// Logical application name.
		/// </summary>
		public string applicationName
		{
			get
			{
				return m_applicationName;
			}
			set
			{
				m_applicationName = value;
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
		/// Construct and initialize cache details.
		/// </summary>
		/// <param name="psApplicationName">Onyx logical application name.</param>
		public OnyxDictionaryCache(string psApplicationName)
		{
			this.applicationName = psApplicationName;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Get an empty object instance from the dictionary cache.
		/// </summary>
		/// <param name="psObjectName">Name of the object.</param>
		public string GetObjectInstance(string psObjectName)
		{
			string objectInstance = string.Empty;

			// Retrieve instance from cache
			OnyxEDCachePIA.ICache3 cache = new DictionaryCacheClass();
			OEDCacheStatusEnum result = cache.GetObjectInstance(this.applicationName, psObjectName, out objectInstance);

			// Release COM object
			Marshal.ReleaseComObject(cache);

			// Check result
			if (result != OEDCacheStatusEnum.ocsSuccess)
			{
				throw new StepComponentException(this.assemblyClassName,
					750607,
					psObjectName + "~" + this.applicationName + "~" + "OEDCacheStatusEnum." + result.ToString(),
					"",
					StepPackageErrorType.ReturnValue,
					StepPackageSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			// Return message
			return objectInstance;
		}
		#endregion
	}
}
