using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using OnyxOutlookAddin.Properties;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin.Properties
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.Properties.Settings" />)
    ///     and namespace <see cref="OnyxOutlookAddin.Properties"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SettingsDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="SettingsNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public SettingsDesignerTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: SettingsNonPublicTypeName)
        { }

        #region Category : General

        #region Category : Initializer

        #region General Initializer : Overrides of IBaseSetupV1Test

        /// <summary>
        ///    Configure and ignore problematic tests.
        ///    Added tests will be ignored.
        /// </summary>
        public override void ConfigureIgnoringTests()
        {
            base.ConfigureIgnoringTests();
        }

        #endregion

        private Type _settingsInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string SettingsNonPublicTypeName = "OnyxOutlookAddin.Properties.Settings";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _settingsInstance;
        private object _settingsInstanceFixture;

        #region General Initializer : Class (Settings) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Settings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _settingsInstanceFixture = this.CreateNonPublicType(SettingsNonPublicTypeName);
            _settingsInstance = _settingsInstanceFixture;
            CurrentInstance = _settingsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Settings) Initializer

        #region Properties

        private const string PropertyDefault = "Default";
        private const string PropertyOnyxApplicationName = "OnyxApplicationName";
        private const string PropertyOnyxUserId = "OnyxUserId";
        private const string PropertyOnyxPassword = "OnyxPassword";
        private const string PropertyOnyxSiteId = "OnyxSiteId";
        private const string PropertyInFolderList = "InFolderList";
        private const string PropertyOutFolderList = "OutFolderList";
        private const string PropertyOnyxProfileId = "OnyxProfileId";
        private const string PropertyIncludeAttachmentsOnEmailSave = "IncludeAttachmentsOnEmailSave";
        private const string PropertyIncludeEmbeddedImagesOnEmailSave = "IncludeEmbeddedImagesOnEmailSave";
        private const string PropertyOnyxOutlookAddin_OEASAuth_OEASAuthWebService = "OnyxOutlookAddin_OEASAuth_OEASAuthWebService";
        private const string PropertyOnyxOutlookAddin_OEASCall_OEASWebService = "OnyxOutlookAddin_OEASCall_OEASWebService";
        private const string PropertyOEPLauncherURL = "OEPLauncherURL";
        private const string PropertyOnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService = "OnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService";
        private const string PropertyOnyxOutlookAddin_OEAS_Windows_OEASWebService = "OnyxOutlookAddin_OEAS_Windows_OEASWebService";
        private const string PropertyEnableOnyxAuthentication = "EnableOnyxAuthentication";
        private const string PropertyIncludeAttachmentsOnCustomerSave = "IncludeAttachmentsOnCustomerSave";
        private const string PropertyIncludeAttachmentsOnIncidentSave = "IncludeAttachmentsOnIncidentSave";
        private const string PropertyLogToFile = "LogToFile";
        private const string PropertyLogLevel = "LogLevel";
        private const string PropertyLogFileRetentionDays = "LogFileRetentionDays";
        private const string PropertyOnyx360Enabled = "Onyx360Enabled";
        private const string PropertyLogOnyxAdminEmail = "LogOnyxAdminEmail";
        private const string PropertyCallUpgrade = "CallUpgrade";
        private const string PropertyOnyx360HelpFile = "Onyx360HelpFile";
        private const string PropertyDisplayResolvedEmployeeRecords = "DisplayResolvedEmployeeRecords";

        #endregion

        #region Fields

        private const string FielddefaultInstance = "defaultInstance";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Settings)

        #region General Initializer : Class (Settings) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Settings" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SettingsDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Settings) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Settings" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDefault)]
        [TestCase(PropertyOnyxApplicationName)]
        [TestCase(PropertyOnyxUserId)]
        [TestCase(PropertyOnyxPassword)]
        [TestCase(PropertyOnyxSiteId)]
        [TestCase(PropertyInFolderList)]
        [TestCase(PropertyOutFolderList)]
        [TestCase(PropertyOnyxProfileId)]
        [TestCase(PropertyIncludeAttachmentsOnEmailSave)]
        [TestCase(PropertyIncludeEmbeddedImagesOnEmailSave)]
        [TestCase(PropertyOnyxOutlookAddin_OEASAuth_OEASAuthWebService)]
        [TestCase(PropertyOnyxOutlookAddin_OEASCall_OEASWebService)]
        [TestCase(PropertyOEPLauncherURL)]
        [TestCase(PropertyOnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService)]
        [TestCase(PropertyOnyxOutlookAddin_OEAS_Windows_OEASWebService)]
        [TestCase(PropertyEnableOnyxAuthentication)]
        [TestCase(PropertyIncludeAttachmentsOnCustomerSave)]
        [TestCase(PropertyIncludeAttachmentsOnIncidentSave)]
        [TestCase(PropertyLogToFile)]
        [TestCase(PropertyLogLevel)]
        [TestCase(PropertyLogFileRetentionDays)]
        [TestCase(PropertyOnyx360Enabled)]
        [TestCase(PropertyLogOnyxAdminEmail)]
        [TestCase(PropertyCallUpgrade)]
        [TestCase(PropertyOnyx360HelpFile)]
        [TestCase(PropertyDisplayResolvedEmployeeRecords)]
        [Category("AUT Property")]
        public void AUT_SettingsDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Settings) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Settings" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SettingsDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Settings) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Settings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FielddefaultInstance)]
        [Category("AUT Fields")]
        public void AUT_SettingsDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (Settings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Settings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SettingsDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Settings) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDefault)]
        [TestCase(PropertyOnyxApplicationName)]
        [TestCase(PropertyOnyxUserId)]
        [TestCase(PropertyOnyxPassword)]
        [TestCase(PropertyOnyxSiteId)]
        [TestCase(PropertyInFolderList)]
        [TestCase(PropertyOutFolderList)]
        [TestCase(PropertyOnyxProfileId)]
        [TestCase(PropertyIncludeAttachmentsOnEmailSave)]
        [TestCase(PropertyIncludeEmbeddedImagesOnEmailSave)]
        [TestCase(PropertyOnyxOutlookAddin_OEASAuth_OEASAuthWebService)]
        [TestCase(PropertyOnyxOutlookAddin_OEASCall_OEASWebService)]
        [TestCase(PropertyOEPLauncherURL)]
        [TestCase(PropertyOnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService)]
        [TestCase(PropertyOnyxOutlookAddin_OEAS_Windows_OEASWebService)]
        [TestCase(PropertyEnableOnyxAuthentication)]
        [TestCase(PropertyIncludeAttachmentsOnCustomerSave)]
        [TestCase(PropertyIncludeAttachmentsOnIncidentSave)]
        [TestCase(PropertyLogToFile)]
        [TestCase(PropertyLogLevel)]
        [TestCase(PropertyLogFileRetentionDays)]
        [TestCase(PropertyOnyx360Enabled)]
        [TestCase(PropertyLogOnyxAdminEmail)]
        [TestCase(PropertyCallUpgrade)]
        [TestCase(PropertyOnyx360HelpFile)]
        [TestCase(PropertyDisplayResolvedEmployeeRecords)]
        public void AUT_SettingsDesigner_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (CallUpgrade) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_CallUpgrade_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCallUpgrade);
            var propertyInfo = this.GetPropertyInfo(PropertyCallUpgrade);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (Default) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Default_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefault);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDefault);
            Action currentAction = () => propertyInfo.SetValue(_settingsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (Default) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_Default_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefault);
            var propertyInfo = this.GetPropertyInfo(PropertyDefault);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (DisplayResolvedEmployeeRecords) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_DisplayResolvedEmployeeRecords_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayResolvedEmployeeRecords);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayResolvedEmployeeRecords);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (EnableOnyxAuthentication) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_EnableOnyxAuthentication_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnableOnyxAuthentication);
            var propertyInfo = this.GetPropertyInfo(PropertyEnableOnyxAuthentication);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (IncludeAttachmentsOnCustomerSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_IncludeAttachmentsOnCustomerSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncludeAttachmentsOnCustomerSave);
            var propertyInfo = this.GetPropertyInfo(PropertyIncludeAttachmentsOnCustomerSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (IncludeAttachmentsOnEmailSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_IncludeAttachmentsOnEmailSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncludeAttachmentsOnEmailSave);
            var propertyInfo = this.GetPropertyInfo(PropertyIncludeAttachmentsOnEmailSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (IncludeAttachmentsOnIncidentSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_IncludeAttachmentsOnIncidentSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncludeAttachmentsOnIncidentSave);
            var propertyInfo = this.GetPropertyInfo(PropertyIncludeAttachmentsOnIncidentSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (IncludeEmbeddedImagesOnEmailSave) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_IncludeEmbeddedImagesOnEmailSave_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncludeEmbeddedImagesOnEmailSave);
            var propertyInfo = this.GetPropertyInfo(PropertyIncludeEmbeddedImagesOnEmailSave);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (InFolderList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_InFolderList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInFolderList);
            var propertyInfo = this.GetPropertyInfo(PropertyInFolderList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (LogFileRetentionDays) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_LogFileRetentionDays_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogFileRetentionDays);
            var propertyInfo = this.GetPropertyInfo(PropertyLogFileRetentionDays);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (LogLevel) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_LogLevel_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogLevel);
            var propertyInfo = this.GetPropertyInfo(PropertyLogLevel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (LogOnyxAdminEmail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_LogOnyxAdminEmail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogOnyxAdminEmail);
            var propertyInfo = this.GetPropertyInfo(PropertyLogOnyxAdminEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (LogToFile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_LogToFile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogToFile);
            var propertyInfo = this.GetPropertyInfo(PropertyLogToFile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OEPLauncherURL) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OEPLauncherURL_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOEPLauncherURL);
            var propertyInfo = this.GetPropertyInfo(PropertyOEPLauncherURL);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (Onyx360Enabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_Onyx360Enabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyx360Enabled);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyx360Enabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (Onyx360HelpFile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_Onyx360HelpFile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyx360HelpFile);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyx360HelpFile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxApplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxApplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxOutlookAddin_OEAS_Windows_OEASWebService) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxOutlookAddin_OEAS_Windows_OEASWebService_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxOutlookAddin_OEAS_Windows_OEASWebService);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxOutlookAddin_OEAS_Windows_OEASWebService);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxOutlookAddin_OEASAuth_OEASAuthWebService) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxOutlookAddin_OEASAuth_OEASAuthWebService_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxOutlookAddin_OEASAuth_OEASAuthWebService);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxOutlookAddin_OEASAuth_OEASAuthWebService);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxOutlookAddin_OEASAuth_Windows_OEASAuthWebService);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxOutlookAddin_OEASCall_OEASWebService) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxOutlookAddin_OEASCall_OEASWebService_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxOutlookAddin_OEASCall_OEASWebService);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxOutlookAddin_OEASCall_OEASWebService);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxPassword) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxPassword_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxProfileId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxProfileId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxProfileId);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxProfileId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxSiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxSiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxSiteId);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxSiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OnyxUserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OnyxUserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxUserId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Settings) => Property (OutFolderList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SettingsDesigner_Public_Class_OutFolderList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutFolderList);
            var propertyInfo = this.GetPropertyInfo(PropertyOutFolderList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}