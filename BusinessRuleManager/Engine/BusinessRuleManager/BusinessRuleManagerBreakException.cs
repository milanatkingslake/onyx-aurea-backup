// Copyright © Aptean 2018. All rights reserved.
using System;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Use this exception to break out of a loop control grammar item.
	/// </summary>
	public class BusinessRuleManagerBreakException : ApplicationException
	{
		#region Constructor
		/// <summary>
		/// Construct a break exception.
		/// </summary>
		public BusinessRuleManagerBreakException()
			: base("Loop control break")
		{
		}
		#endregion
	}
}
