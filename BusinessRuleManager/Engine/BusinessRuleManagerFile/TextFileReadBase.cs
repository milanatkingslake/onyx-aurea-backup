// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Base class for text file read grammar.
	/// </summary>
	public class TextFileReadBase
		: GrammarBase
	{
		#region Protected methods
		/// <summary>
		/// Returns cache key used when temporarily storing the file stream instance
		/// for child grammar items.
		/// </summary>
		/// <returns>Cache key.</returns>
		protected string GetCacheKey()
		{
			return "TextFileRead." + this.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached TextReader object.
		/// </summary>
		/// <returns>TextReader object from cache.</returns>
		protected TextReader GetCachedInfo()
		{
			string cacheKey = this.GetCacheKey();

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~textFileReadOpen",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (TextReader)this.engine.cache.Read(cacheKey);
		}
		#endregion
	}
}
