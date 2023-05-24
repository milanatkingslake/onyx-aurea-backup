// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Provide information on a file from the local file system.
	/// </summary>
	public class FileInfoBase
		: GrammarBase
	{
		#region Protected methods
		/// <summary>
		/// Returns cache key used when temporarily storing the FileInfo instance
		/// for file info grammar items.
		/// </summary>
		/// <returns>Cache key.</returns>
		protected string GetCacheKey()
		{
			return "FileInfo." + this.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached FileInfo object.
		/// </summary>
		/// <returns>FileInfo object from cache.</returns>
		protected System.IO.FileInfo GetCachedInfo()
		{
			string cacheKey = this.GetCacheKey();

			// Check that file info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~fileInfo",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (System.IO.FileInfo)this.engine.cache.Read(cacheKey);
		}
		#endregion
	}
}
