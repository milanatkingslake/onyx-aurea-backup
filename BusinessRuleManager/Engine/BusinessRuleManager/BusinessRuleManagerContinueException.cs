// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Use this exception to continue within a loop control grammar item.
	/// </summary>
	public class BusinessRuleManagerContinueException : ApplicationException
	{
		#region Constructor
		/// <summary>
		/// Construct a continue exception.
		/// </summary>
		public BusinessRuleManagerContinueException()
			: base("Loop control continue")
		{
		}
		#endregion
	}
}
