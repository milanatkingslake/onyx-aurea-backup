// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to context properties in the Onyx step package.
	/// </summary>
	public class StepPackageContext
	{
		#region Private fields
		private StepPackage m_stepPackage;
		#endregion

		#region Public properties
		/// <summary>
		/// Onyx session ID.
		/// </summary>
		public string sessionID
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.SessionID);
			}
		}
		/// <summary>
		/// Onyx user ID.
		/// </summary>
		public string userID
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.UserID);
			}
		}
		/// <summary>
		/// Partner user indicator.
		/// </summary>
		public bool partnerUser
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.PartnerUser) == "1";
			}
		}
		/// <summary>
		/// Onyx site ID.
		/// </summary>
		public int siteID
		{
			get
			{
				return Convert.ToInt32(this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.SiteID));
			}
		}
		/// <summary>
		/// Onyx logical application name.
		/// </summary>
		public string applicationName
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.ApplicationName);
			}
		}
		/// <summary>
		/// Source application.
		/// </summary>
		public string source
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.Source);
			}
		}
		/// <summary>
		/// Preferred language code.
		/// </summary>
		public string preferredLanguage
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.PreferredLanguage);
			}
		}
		/// <summary>
		/// Original calling context.
		/// </summary>
		public string originalUser
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.OriginalUser);
			}
		}
		/// <summary>
		/// Onyx security permissions bitmask.
		/// </summary>
		public string permissionMask
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.PermissionMask);
			}
		}
		/// <summary>
		/// Event log name.
		/// </summary>
		public string logName
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.LogName);
			}
		}
		/// <summary>
		/// Log setting value.
		/// </summary>
		public int logSettings
		{
			get
			{
				return Convert.ToInt32(this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.LogSettings));
			}
		}
		/// <summary>
		/// Impersonating user ID.
		/// </summary>
		public string impersonatingUser
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.ImpersonatingUser);
			}
		}
		/// <summary>
		/// Seconds remaining before Onyx session will time out.
		/// </summary>
		public int sessionSecondsRemaining
		{
			get
			{
				return Convert.ToInt32(this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.SessionSecondsRemaining));
			}
		}
		/// <summary>
		/// Unique identifier for the current OTM method call.
		/// </summary>
		public string otmID
		{
			get
			{
				return this.stepPackage.GetContextProperty(StepPackageNodeName._StepPackage._Context.OtmID);
			}
			set
			{
				this.stepPackage.SetContextProperty(StepPackageNodeName._StepPackage._Context.OtmID, value);
			}
		}
		#endregion

		#region Private properties
		/// <summary>
		/// Step package to retrieve context info from.
		/// </summary>
		private StepPackage stepPackage
		{
			get
			{
				return m_stepPackage;
			}
			set
			{
				m_stepPackage = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Construct using reference to step package.
		/// </summary>
		/// <param name="pStepPackage">Step package.</param>
		public StepPackageContext(StepPackage pStepPackage)
		{
			this.stepPackage = pStepPackage;
		}
		#endregion
	}
}
