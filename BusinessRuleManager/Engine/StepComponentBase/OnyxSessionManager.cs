// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Runtime.InteropServices;
using OnyxSMPIA;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to the Onyx Session Manager.
	/// </summary>
	public class OnyxSessionManager
	{
		#region Private fields
		private StepPackageContext m_context;
		#endregion

		#region Public properties
		/// <summary>
		/// Context from Onyx step package.
		/// </summary>
		public StepPackageContext context
		{
			get
			{
				return m_context;
			}
			set
			{
				m_context = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Construct and initialize session manager using step package context.
		/// </summary>
		/// <param name="pContext">Context from Onyx step package.</param>
		public OnyxSessionManager(StepPackageContext pContext)
		{
			this.context = pContext;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Checks if the current Onyx session has permission to access
		/// a resource given a resource ID.
		/// </summary>
		/// <param name="psResourceId">ID of the Onyx resource.</param>
		/// <returns>True if the session has permission to access the resource.</returns>
		public bool HasPermission(string psResourceId)
		{
			bool hasPerm = false;
			ISession2 onyxSession = new OnyxSessionManagerClass();

			// Check for permission
			hasPerm = onyxSession.HasPermission(this.context.sessionID,
				this.context.applicationName,
				psResourceId,
				this.context.permissionMask);

			// Release COM object
			Marshal.ReleaseComObject(onyxSession);

			return hasPerm;
		}
		/// <summary>
		/// Set Onyx session variable value.
		/// </summary>
		/// <param name="psName">Name of the variable.</param>
		/// <param name="psValue">Value to set.</param>
		public void SetSessionItem(string psName, string psValue)
		{
			ISession2 onyxSession = new OnyxSessionManagerClass();

			// Set session item
			onyxSession.SetSessionItem(this.context.sessionID,
				this.context.applicationName,
				psName,
				psValue);

			// Release COM object
			Marshal.ReleaseComObject(onyxSession);
		}
		/// <summary>
		/// Get Onyx session variable value.
		/// </summary>
		/// <param name="psName">Name of the variable.</param>
		public string GetSessionItem(string psName)
		{
			string value;
			ISession2 onyxSession = new OnyxSessionManagerClass();

			// Get session item
			value = onyxSession.GetSessionItem(this.context.sessionID,
				this.context.applicationName,
				psName);

			// Release COM object
			Marshal.ReleaseComObject(onyxSession);

			return value;
		}
		/// <summary>
		/// Remove Onyx session variable value.
		/// </summary>
		/// <param name="psName">Name of the variable.</param>
		public void RemoveSessionItem(string psName)
		{
			ISession2 onyxSession = new OnyxSessionManagerClass();

			// Set session item
			onyxSession.RemoveSessionItem(this.context.sessionID,
				this.context.applicationName,
				psName);

			// Release COM object
			Marshal.ReleaseComObject(onyxSession);
		}
		#endregion
	}
}
