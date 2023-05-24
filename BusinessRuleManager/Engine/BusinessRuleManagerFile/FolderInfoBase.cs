// Copyright © Aptean 2018. All rights reserved.
using System;
using System.IO;
using System.Reflection;
using System.Xml;

namespace ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
	/// <summary>
	/// Provide information on a folder from the local file system.
	/// </summary>
	public class FolderInfoBase
		: GrammarBase
	{
		#region Protected methods
		/// <summary>
		/// Returns cache key used when temporarily storing the DirectoryInfo instance
		/// for file info grammar items.
		/// </summary>
		/// <returns>Cache key.</returns>
		protected string GetCacheKey()
		{
			return "FolderInfo." + this.engine.referenceID;
		}
		/// <summary>
		/// Retrieve the cached DirectoryInfo object.
		/// </summary>
		/// <returns>DirectoryInfo object from cache.</returns>
		protected DirectoryInfo GetCachedInfo()
		{
			string cacheKey = this.GetCacheKey();

			// Check that folder info object is in cache
			if (!this.engine.cache.ContainsKey(cacheKey))
			{
				throw new BusinessRuleManagerException(this.assemblyClassName,
					(long)SystemMessage.MessageId.ChildWithoutParent,
					this.metadataNode.Name + "~folderInfo",
					"",
					BusinessRuleManagerErrorType.BusinessLogic,
					BusinessRuleManagerSourceType.Component,
					MethodBase.GetCurrentMethod().Name);
			}

			return (DirectoryInfo)this.engine.cache.Read(cacheKey);
		}
		#endregion
	}
}
