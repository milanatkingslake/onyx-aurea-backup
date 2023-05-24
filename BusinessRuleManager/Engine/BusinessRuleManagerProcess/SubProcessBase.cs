// Copyright © Aptean 2018. All rights reserved.
using System;
using System.Collections.Generic;
using System.Reflection;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
	public class SubProcessBase
		: GrammarBase
	{
		#region Public static methods
		/// <summary>
		/// Returns cache key used when temporarily storing the Dictionary instance
		/// for child items.
		/// </summary>
		/// <returns>Cache key.</returns>
		public static string GetCacheKey(GrammarBase pBaseGrammar)
		{
			return "SubProcess." + pBaseGrammar.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached Dictionary object.
		/// </summary>
		/// <returns>Dictionary object from cache.</returns>
		public static Dictionary<string, string> GetCachedInfo(GrammarBase pBaseGrammar)
		{
			string cacheKey = SubProcessBase.GetCacheKey(pBaseGrammar);

			// Check that file info object is in cache
			if (!pBaseGrammar.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(pBaseGrammar.GetType().Name,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					pBaseGrammar.metadataNode.Name + "~subProcess",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (Dictionary<string, string>)pBaseGrammar.engine.cache.Read(cacheKey);
		}
		/// <summary>
		/// Set the cached Dictionary object.
		/// </summary>
		/// <param name="pCacheItem">Dictionary object to cache.</param>
		public static void SetCachedInfo(GrammarBase pBaseGrammar, Dictionary<string, string> pCacheItem)
		{
			pBaseGrammar.engine.cache.Write(SubProcessBase.GetCacheKey(pBaseGrammar), pCacheItem);
		}
		/// <summary>
		/// Remove the cached Dictionary object.
		/// </summary>
		public static void RemoveCachedInfo(GrammarBase pBaseGrammar)
		{
			pBaseGrammar.engine.cache.Remove(SubProcessBase.GetCacheKey(pBaseGrammar));
		}
		#endregion
	}
}
