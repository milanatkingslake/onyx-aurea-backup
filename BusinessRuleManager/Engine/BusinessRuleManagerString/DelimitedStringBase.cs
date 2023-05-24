// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
	/// <summary>
	/// Provide values from a delimited string.
	/// </summary>
	public class DelimitedStringBase
		: GrammarBase
	{
		#region Protected methods
		/// <summary>
		/// Returns cache key used when temporarily storing the delimited string instance
		/// for child items.
		/// </summary>
		/// <returns>Cache key.</returns>
		protected string GetCacheKey()
		{
			return "DelimitedString." + this.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached string object.
		/// </summary>
		/// <returns>FileInfo object from cache.</returns>
		protected string GetCachedInfo()
		{
			string cacheKey = this.GetCacheKey();

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~forEachDelimitedString",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (string)this.engine.cache.Read(cacheKey);
		}
		#endregion
	}
}
