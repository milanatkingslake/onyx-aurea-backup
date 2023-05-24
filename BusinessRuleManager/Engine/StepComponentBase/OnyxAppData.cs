// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Runtime.InteropServices;
using OnyxGetAppDataPIA;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to Onyx logical application registry settings.
	/// </summary>
	public class OnyxAppData
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
		/// Construct and initialize application data access.
		/// </summary>
		/// <param name="psApplicationName">Onyx logical application name.</param>
		public OnyxAppData(string psApplicationName)
		{
			this.applicationName = psApplicationName;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Get the value of a registry setting for the logical application.
		/// </summary>
		/// <param name="psSubKey">Name of sub-key in the logical application registry key.</param>
		/// <param name="psName">Name of the registry setting.</param>
		/// <returns>Value of the registry setting.</returns>
		public string GetSetting(string psSubKey, string psName)
		{
			string value = null;
			GetAppDataStatusEnum result;

			// Get setting
			AppData appData = new AppData();
			appData.GetSetting(this.applicationName, psSubKey, psName, out value, out result);
			// Release COM object
			Marshal.ReleaseComObject(appData);

			// Check status
			if (result != GetAppDataStatusEnum.ogadSuccess)
			{
				throw new StepComponentException(this.assemblyClassName,
					750650,
					this.applicationName + "~" + psSubKey + "~" + psName,
					"",
					StepPackageErrorType.ReturnValue,
					StepPackageSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return value;
		}
		#endregion
	}
}
