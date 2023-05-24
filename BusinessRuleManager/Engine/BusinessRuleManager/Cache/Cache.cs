// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections;

namespace ConsonaCRM.BusinessRuleManager.Cache
{
	/// <summary>
	/// Custom cache component for applications.
	/// </summary>
	/// <remarks>
	/// Use this component to cache component information
	/// for use during the same method execution or a future method execution.
	/// The content will remain in the cache until the application in
	/// which the component is running terminates.
	/// </remarks>
	public class LocalCache
	{
		#region Private classes
		/// <summary>
		/// Class used to cache items in the local cache with an expiration date.
		/// </summary>
		private class LocalCacheItem
		{
			#region Private fields
			private object m_cacheValue;
			private bool m_canExpire = false;
			private DateTime m_expirationDate;
			#endregion

			#region Public properties
			/// <summary>
			/// Object that is stored in the cache.
			/// </summary>
			public object value
			{
				get
				{
					return m_cacheValue;
				}
			}
			/// <summary>
			/// Date/time when the item expires.
			/// </summary>
			public DateTime expirationDate
			{
				get
				{
					return m_expirationDate;
				}
			}
			/// <summary>
			/// Indicates if the cache item has expired.
			/// </summary>
			public bool expired
			{
				get
				{
					return m_canExpire && (DateTime.UtcNow >= m_expirationDate);
				}
			}
			#endregion

			#region Constructors
			/// <summary>
			/// Construct a cache item with an expiration date.
			/// </summary>
			/// <param name="pValue">Item to be cached.</param>
			/// <param name="pExpirationDate">Expiration date for the cache item.</param>
			public LocalCacheItem(object pValue, DateTime pExpirationDate)
			{
				m_cacheValue = pValue;
				m_canExpire = true;
				m_expirationDate = pExpirationDate;
			}
			/// <summary>
			/// Construct a cache item without an expiration date.
			/// </summary>
			/// <param name="pValue">Item to be cached.</param>
			public LocalCacheItem(object pValue)
			{
				m_cacheValue = pValue;
			}
			#endregion
		}
		#endregion

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
		public LocalCache(string psPrefix)
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
			LocalCacheItem item = new LocalCacheItem(pValue);
			lock (m_hashTable)
			{
				m_hashTable[this.GetCacheKey(psName)] = item;
			}
		}
		/// <summary>
		/// Write an object to the cache with an expiration date.
		/// </summary>
		/// <param name="psName">Name to use for the object in the cache.</param>
		/// <param name="pValue">Value to cache.</param>
		/// <param name="pExpirationDate">Expiration date for the object in the cache.</param>
		public void Write(string psName, object pValue, DateTime pExpirationDate)
		{
			LocalCacheItem item = new LocalCacheItem(pValue, pExpirationDate);
			lock (m_hashTable)
			{
				m_hashTable[this.GetCacheKey(psName)] = item;
			}
		}
		/// <summary>
		/// Read an object from the cache.
		/// </summary>
		/// <param name="psName">Name of the value to read.</param>
		/// <returns>Value from the cache.</returns>
		public object Read(string psName)
		{
			// Get the item from the cache
			LocalCacheItem item = (LocalCacheItem)m_hashTable[this.GetCacheKey(psName)];
			if (item != null)
			{
				// Remove if expired, otherwise return the cached item
				if (item.expired)
				{
					this.Remove(psName);
				}
				else
				{
					return item.value;
				}
			}
			return null;
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
			// Check if the item is in the cache
			if (!m_hashTable.ContainsKey(this.GetCacheKey(psName)))
			{
				return false;
			}
			// Read it to verify expiration date
			return (this.Read(psName) != null);
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
