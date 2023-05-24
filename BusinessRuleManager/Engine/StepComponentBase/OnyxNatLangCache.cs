// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Runtime.InteropServices;
using OnyxNatLangProxyPIA;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Provides access to the Onyx National Language cache.
	/// </summary>
	public class OnyxNatLangCache
	{
		#region Private fields
		private string m_applicationName;
		private int m_siteId;
		private string m_preferredLanguage;
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
		/// <summary>
		/// Onyx site ID.
		/// </summary>
		public int siteID
		{
			get
			{
				return m_siteId;
			}
			set
			{
				m_siteId = value;
			}
		}
		/// <summary>
		/// Preferred language code.
		/// </summary>
		public string preferredLanguage
		{
			get
			{
				return m_preferredLanguage;
			}
			set
			{
				m_preferredLanguage = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Construct and initialize cache details.
		/// </summary>
		/// <param name="psApplicationName">Onyx logical application name.</param>
		/// <param name="piSiteID">Onyx site ID.</param>
		/// <param name="psPreferredLanguage">Preferred language code.</param>
		public OnyxNatLangCache(string psApplicationName,
			int piSiteID,
			string psPreferredLanguage)
		{
			this.applicationName = psApplicationName;
			this.siteID = piSiteID;
			this.preferredLanguage = psPreferredLanguage;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Retrieve a string from the National Language cache
		/// </summary>
		/// <param name='piMessageId'>ID of National Language message to retrieve</param>
		/// <param name='psArguments'>String containing a tilde-separated (~) list of items
		///  to substitute for placeholders within the retrieved string</param>
		/// <returns>National Language string value</returns>
		/// <remarks>Placeholder items are made up of a tilde and a number (for example, ~0).
		///  The items in the Arguments parameter are used to replace the placeholder items
		///   in the string retrieved from the cache.
		///   For example, if the retrieved string in the cache looks like this:
		///   <p><code>Task #~0 Entered By: ~1 @ ~2 ~3</code></p>
		///   and the Arguments parameter looks like this:
		///   <p><code>14563~johns~Nov 30, 2000~03:15 PM</code></p>
		///   the method will combine the two and return this:
		///   <p><code>Task #14563 Entered By: johns @ Nov 30, 2000 03:15 PM</code></p>
		///   If a placeholder value is repeated within a string, each instance
		///    is replaced with the same value from the Arguments list.
		///    The Arguments parameter is not optional, but if there is no need to
		///    make a replacement, submit an empty string ("").
		///    To remove a placeholder without adding any text,
		///    use consecutive tildes in the arguments parameter string.
		///    For example, the above string when changed to:
		///   <p><code>14563~johns~~03:15 PM</code></p>
		///    will generate:
		///   <p><code>Task #14563 Entered By: johns @ 03:15 PM</code></p>
		///   </remarks>
		public string RetrieveString(int piMessageId, string psArguments)
		{
			string message = null;
			NatLangProxy natLang = new NatLangProxyClass();

			// Retrieve string from cache
			object value = natLang.RetrieveString(this.applicationName, this.siteID, this.preferredLanguage, piMessageId, psArguments);
			if (value != null)
			{
				message = value.ToString();
			}
			
			// Release COM object
			Marshal.ReleaseComObject(natLang);

			// Return message
			return message;
		}

		/// <summary>
		/// Retrieve a list of strings from the National Language cache.
		/// </summary>
		/// <param name='piStartMessageId'>ID of first National Language message to retrieve</param>
		/// <param name='piEndMessageId'>ID of last National Language message to retrieve</param>
		/// <returns>2 dimensional array containing ID and message string for all message
		/// strings that were found.</returns>
		/// <remarks>
		/// <p>
		/// Unlike the <c>RetrieveString</c> method, this method does not do
		/// substitutions for placeholders in the retrieved string.
		/// </p>
		/// <p>
		/// The returned array has contains a 2 dimension array.
		/// Each row contains 2 columns. The 2st column is the message ID, the
		/// 2nd is the message string.
		/// </p> 
		/// </remarks>
		public System.Array RetrieveStringList(int piStartMessageId, int piEndMessageId)
		{
			System.Array messages = null;
			NatLangProxy natLang = new NatLangProxyClass();

			// Retrieve strings from cache
			object values = natLang.RetrieveStringList(this.applicationName, this.siteID, this.preferredLanguage, piStartMessageId, piEndMessageId);
			if (values != null)
			{
				messages = (System.Array)values;
			}

			// Release COM object
			Marshal.ReleaseComObject(natLang);

			// Return message
			return messages;
		}
		#endregion
	}
}
