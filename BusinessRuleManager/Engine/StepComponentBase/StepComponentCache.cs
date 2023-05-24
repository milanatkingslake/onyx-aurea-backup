// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections;

namespace ConsonaCRM.Onyx
{
	/// <summary>
	/// Cache component for step component.
	/// </summary>
	/// <remarks>
	/// Use this component to cache step component information
	/// for use during the same method call or a future method call.
	/// The content will remain in the cache until the application in
	/// which the component is running terminates.
	/// </remarks>
	public class StepComponentCache
	{
		#region Private fields
		private static Hashtable m_hashTable = new Hashtable();
		private string m_prefix = string.Empty;
		#endregion

		#region Public properties
		/// <summary>
		/// Prefix to use for the name of cache keys.
		/// </summary>
		public string prefix
		{
			get
			{
				return m_prefix;
			}
			set
			{
				m_prefix = value;
			}
		}
		#endregion

		#region Constructor
		/// <summary>
		/// Create an instance of the cache using a cache prefix.
		/// </summary>
		/// <param name="psPrefix">Prefix to use for cache keys.</param>
		public StepComponentCache(string psPrefix)
		{
			this.prefix = psPrefix;
		}
		#endregion

		#region Public methods
		/// <summary>
		/// Write an object to the cache.
		/// </summary>
		/// <param name="psName">Name to use for the object in the cache.</param>
		/// <param name="pValue">Value to cache.</param>
		public void Write(string psName, object pValue)
		{
			lock (m_hashTable)
			{
				m_hashTable[this.GetCacheKey(psName)] = pValue;
			}
		}
		/// <summary>
		/// Read an object from the cache.
		/// </summary>
		/// <param name="psName">Name of the value to read.</param>
		/// <returns>Value from the cache.</returns>
		public object Read(string psName)
		{
			return m_hashTable[this.GetCacheKey(psName)];
		}
		/// <summary>
		/// Remove a named object from the cache.
		/// </summary>
		/// <param name="psName">Name of the object to remove.</param>
		public void Remove(string psName)
		{
			lock (m_hashTable)
			{
				m_hashTable.Remove(this.GetCacheKey(psName));
			}
		}
		/// <summary>
		/// Remove all objects from the cache.
		/// </summary>
		/// <param name="psName"></param>
		public void Clear(string psName)
		{
			lock (m_hashTable)
			{
				m_hashTable.Clear();
			}
		}
		/// <summary>
		/// Checks if a specified key exists in the cache.
		/// </summary>
		/// <param name="psName">Key name to search for.</param>
		/// <returns>true if the key exists, false if not.</returns>
		public bool ContainsKey(string psName)
		{
			return m_hashTable.ContainsKey(this.GetCacheKey(psName));
		}
		#endregion

		#region Private methods
		private string GetCacheKey(string psName)
		{
			return this.prefix + psName;
		}
		#endregion
	}
}
