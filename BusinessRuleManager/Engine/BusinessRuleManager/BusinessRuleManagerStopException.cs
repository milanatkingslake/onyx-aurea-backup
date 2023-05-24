// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Use this exception to stop all processing for the component
	/// and return a value to the OTM.
	/// </summary>
	public class BusinessRuleManagerStopException : ApplicationException
	{
		#region Private fields
		private string m_returnValue = "";
		#endregion

		#region Public properties
		/// <summary>
		/// Value to return to OTM from the execute method.
		/// </summary>
		public string returnValue
		{
			get
			{
				return m_returnValue;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Construct an exception using the return value.
		/// </summary>
		/// <param name="psReturnValue">Value to return to the OTM.</param>
		public BusinessRuleManagerStopException(string psReturnValue)
			: base()
		{
			this.m_returnValue = psReturnValue;
		}
		#endregion
	}
}
