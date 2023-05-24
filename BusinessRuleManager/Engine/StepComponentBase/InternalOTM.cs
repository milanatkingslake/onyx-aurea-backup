// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Runtime.InteropServices;
using OnyxTMPIA;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to Internal Onyx Transaction Manager.
	/// </summary>
	public class InternalOTM
	{
		#region Private fields
		private StepPackage m_stepPackage = null;
		private string m_applicationName = "";
		#endregion

		#region Public properties
		/// <summary>
		/// Onyx step package for the Internal OTM call.
		/// </summary>
		public StepPackage stepPackage
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

		#region Constructor
		/// <summary>
		/// Create an Internal OTM call using the logical application name
		/// and a step package to clone content from.
		/// </summary>
		/// <param name="psApplicationName">Logical application name.</param>
		/// <param name="pStepPackage">Step package to clone from.</param>
		public InternalOTM(string psApplicationName, StepPackage pStepPackage)
		{
			this.applicationName = psApplicationName;
			// Clone and reset step package
			this.stepPackage = new StepPackage(pStepPackage);
			this.stepPackage.Reset();
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Execute the Internal OTM call.
		/// </summary>
		/// <param name="psObjectName">Logical object to call.</param>
		/// <param name="psMethodName">Logical method to call.</param>
		public void Execute(string psObjectName, string psMethodName)
		{
			// Get XML string from step package
			string stepPackageXml = this.stepPackage.xmlDoc.OuterXml;

			// Call OTM then release
			IInternalStringTransactionManager internalOTM = new TransactionManagerClass();
			internalOTM.Execute(this.applicationName, psObjectName, psMethodName, ref stepPackageXml);
			Marshal.ReleaseComObject(internalOTM);

			// Put resulting XML back into step package
			this.stepPackage.SetDocument(stepPackageXml);
		}
		#endregion
	}
}
