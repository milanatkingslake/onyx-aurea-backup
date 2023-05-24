// Copyright © Aptean 2018. All rights reserved.
using System;
using System.EnterpriseServices;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;
using ConsonaCRM.Onyx;

namespace ConsonaCRM.BusinessRuleManager
{
	/// <summary>
	/// Main OEAS-accessible component.
	/// </summary>
	[ClassInterface(ClassInterfaceType.None),
	Guid("22a12672-4253-4817-9281-021414f0a415"),
	ProgId("ConsonaCRM.Onyx.BusinessRuleManager"),
	Transaction(TransactionOption.Supported),
	SecurityRole("BusinessRuleOnyx")]

	public class OnyxStepInterface : StepComponentBase
	{
		#region Private constants
		/// <summary>
		/// File paths.
		/// </summary>
		private struct FilePath
		{
			/// <summary>
			/// Path to configuration root (relative to application folder).
			/// </summary>
			public const string Root = "businessRuleManager";
		}
		/// <summary>
		/// Names of registry keys.
		/// </summary>
		private struct RegistryKeyName
		{
			/// <summary>
			/// Key that has path to OED.
			/// </summary>
			public const string DictionaryPath = "DictionaryPath";
		}
		/// <summary>
		/// Names of custom step additional data values.
		/// </summary>
		private struct AdditionalDataValue
		{
			public const string MetadataFilename = "metadataFile";
		}
		#endregion

		#region Main step component logic
		/// <summary>
		/// Main step component execution method.
		/// </summary>
		protected override void ExecuteMain()
		{
			// Get name of metadata file from step additional data
			string metadataFile = this.GetAdditionalDataValue(AdditionalDataValue.MetadataFilename);
			if ((metadataFile == null) || (metadataFile == string.Empty))
			{
				throw new StepComponentException(this.assemblyClassName,
					(long)SystemMessage.MessageId.MissingMetadataFileName,
					"", "",
					StepPackageErrorType.BusinessLogic,
					StepPackageSourceType.BusinessLogic,
					MethodBase.GetCurrentMethod().Name);
			}

			// Get dictionary path, remove filename
			string appPath = this.appData.GetSetting("", RegistryKeyName.DictionaryPath);
			appPath = appPath.Remove(appPath.LastIndexOf("\\") + 1);

			// Create data package for rules engine
			DataPackage dataPackage = new DataPackage(this.stepPackage.xmlDoc, this.defaultInputNode);

			try
			{
				// Call rules engine
				InternalEngine engine = new InternalEngine();
				engine.Execute(appPath + FilePath.Root,
					metadataFile,
					dataPackage,
					this.cache.prefix,
					this.stepPackage.context.otmID,
					this);
			}
			catch (Exception e)
			{
				// Handle the exception
				this.HandleException(e);
			}
		}
		/// <summary>
		/// Handles any exception that is raised during execution.
		/// </summary>
		/// <param name="e">Exception to be handled.</param>
		protected override void HandleException(Exception e)
		{
			// Check for stop exception
			if (e.GetType() == typeof(BusinessRuleManagerStopException))
			{
				BusinessRuleManagerStopException ex = (BusinessRuleManagerStopException)e;
				if (ex.returnValue != "")
				{
					this.returnValue = ex.returnValue;
				}
				return;
			}

			// Check for rules engine exception
			if (e.GetType() == typeof(BusinessRuleManagerException))
			{
				BusinessRuleManagerException ex = (BusinessRuleManagerException)e;
				// Translate National Language ID to message
				string message = ex.Message;
				if (ex.messageId != 0)
				{
					message = this.natLangCache.RetrieveString((int)ex.messageId, ex.messageArguments);
				}
				// Log error to step package
				if (this.stepPackage != null)
				{
					if (this.stepPackage.initialized)
					{
						this.stepPackage.AddError(ex.messageId,
							ex.errorType,
							message,
							ex.messageId,
							ex.sourceType,
							ex.Source + ":" + ex.sourceName);
					}
				}
				// Log error to event log
				if (this.log != null)
				{
					this.log.LogError(ex.Source,
						ex.messageId,
						message,
						ex.additionalInfo);
				}
				// Default is to tell OEAS to stop executing method steps
				// when an exception is encountered
				ContextUtil.SetAbort();
				this.returnValue = StepReturnValue.Stop;

				// Handle inner exception
				if (e.InnerException != null)
				{
					HandleException(e.InnerException);
				}
			}
			else
			{
				// Call base exception handler
				base.HandleException(e);
			}
		}
		#endregion
	}
}
