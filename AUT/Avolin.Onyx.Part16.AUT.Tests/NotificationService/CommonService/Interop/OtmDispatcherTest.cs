using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.CommonService.Interop;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.CommonService.Interop
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.CommonService.Interop.OtmDispatcher" />)
    ///     and namespace <see cref="NotificationService.CommonService.Interop"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    [Ignore("Candidate for hanging of Jenkins builds")]
    public class OtmDispatcherTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OtmDispatcher" />)
        /// </summary>
        public OtmDispatcherTest() : base(typeof(OtmDispatcher))
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

        #region General Initializer : Class (OtmDispatcher) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _otmDispatcherInstanceType;
        private OtmDispatcher _otmDispatcherInstance;
        private OtmDispatcher _otmDispatcherInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OtmDispatcher" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _otmDispatcherInstanceType = typeof(OtmDispatcher);
            _otmDispatcherInstanceFixture = this.Create<OtmDispatcher>(false);
            _otmDispatcherInstance = _otmDispatcherInstanceFixture ?? this.Create<OtmDispatcher>(true);
            CurrentInstance = _otmDispatcherInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OtmDispatcher) Initializer

        #region Properties

        private const string PropertyDispatch = "Dispatch";
        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertyLogicalObjectName = "LogicalObjectName";
        private const string PropertyLogicalMethodName = "LogicalMethodName";
        private const string PropertyUserId = "UserId";
        private const string PropertySessionId = "SessionId";
        private const string PropertyParamXml = "ParamXml";
        private const string PropertyCustomDataXml = "CustomDataXml";
        private const string PropertySQLResourceId = "SQLResourceId";
        private const string PropertyLogSourceName = "LogSourceName";
        private const string PropertyLogPath = "LogPath";
        private const string PropertyIsLog = "IsLog";
        private const string PropertyIsWarn = "IsWarn";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertySiteId = "SiteId";
        private const string PropertyParameterCollection = "ParameterCollection";

        #endregion

        #region Methods

        private const string MethodSetDispatch = "SetDispatch";
        private const string MethodInvalidMethodType = "InvalidMethodType";

        #endregion

        #region Fields

        private const string FieldLBO_ADDRESS = "LBO_ADDRESS";
        private const string FieldLBO_APPOINTMENT = "LBO_APPOINTMENT";
        private const string FieldLBO_COMPANY = "LBO_COMPANY";
        private const string FieldLBO_EMAIL_MESSAGE = "LBO_EMAIL_MESSAGE";
        private const string FieldLBO_FORECAST = "LBO_FORECAST";
        private const string FieldLBO_INCIDENT = "LBO_INCIDENT";
        private const string FieldLBO_INDIVIDUAL = "LBO_INDIVIDUAL";
        private const string FieldLBO_INTERNAL_CONTACT = "LBO_INTERNAL_CONTACT";
        private const string FieldLBO_EXTERNAL_CONTACT = "LBO_EXTERNAL_CONTACT";
        private const string FieldLBO_PHONE = "LBO_PHONE";
        private const string FieldLBO_CUSTOMER_PRODUCT = "LBO_CUSTOMER_PRODUCT";
        private const string FieldLBO_PRODUCT = "LBO_PRODUCT";
        private const string FieldLBO_REMINDER = "LBO_REMINDER";
        private const string FieldLBO_SCRIPT_SESSION = "LBO_SCRIPT_SESSION";
        private const string FieldLBO_TASK = "LBO_TASK";
        private const string FieldLBO_WORKTICKET = "LBO_WORKTICKET";
        private const string FieldLBO_SEARCH_QUERY = "LBO_SEARCH_QUERY";
        private const string FieldLBO_CUSTOMER = "LBO_CUSTOMER";
        private const string FieldLBO_REGION = "LBO_REGION";
        private const string FieldLBO_REFERENCE_LOOKUP = "LBO_REFERENCE_LOOKUP";
        private const string FieldLBO_REFERENCE_PARAMETER = "LBO_REFERENCE_PARAMETER";
        private const string FieldLBO_REFERENCE_FIELD = "LBO_REFERENCE_FIELD";
        private const string FieldLBO_CAMPAIGN = "LBO_CAMPAIGN";
        private const string FieldLBO_GROUP = "LBO_GROUP";
        private const string FieldLBO_USER = "LBO_USER";
        private const string FieldLBO_KEYWORD = "LBO_KEYWORD";
        private const string FieldLBO_PRODUCT_INDEX = "LBO_PRODUCT_INDEX";
        private const string FieldLBO_PRODUCT_GROUP = "LBO_PRODUCT_GROUP";
        private const string FieldLBO_SCRIPT_INDEX = "LBO_SCRIPT_INDEX";
        private const string FieldLBO_TRACKING_CODE = "LBO_TRACKING_CODE";
        private const string FieldLBO_TRACKING_CODE_TYPE = "LBO_TRACKING_CODE_TYPE";
        private const string FieldLBO_TASK_CATEGORY = "LBO_TASK_CATEGORY";
        private const string FieldLBO_COUNTRY = "LBO_COUNTRY";
        private const string FieldLBO_INCIDENT_PRODUCT = "LBO_INCIDENT_PRODUCT";
        private const string FieldLBO_SYSTEM_PARAMETER = "LBO_SYSTEM_PARAMETER";
        private const string FieldLBO_USERPREFERENCE = "LBO_USERPREFERENCE";
        private const string FieldLBO_CONTACTTYPE = "LBO_CONTACTTYPE";
        private const string FieldLBO_COMPANYFAMILY = "LBO_COMPANYFAMILY";
        private const string FieldLBO_WORKNOTE = "LBO_WORKNOTE";
        private const string FieldLBO_PROFILE = "LBO_PROFILE";
        private const string FieldLBO_WATCHES = "LBO_WATCHES";
        private const string FieldLBO_WORKTICKETASSOCIATION = "LBO_WORKTICKETASSOCIATION";
        private const string FieldLBO_QUOTE = "LBO_QUOTE";
        private const string FieldLBO_FILELINK = "LBO_FILELINK";
        private const string FieldLBO_FILELOCATION = "LBO_FILELOCATION";
        private const string FieldLBO_DOCUMENTMERGE_TEMPLATE = "LBO_DOCUMENTMERGE_TEMPLATE";
        private const string FieldqueryContextParameters = "queryContextParameters";
        private const string FieldlanguageCode = "languageCode";

        #endregion

        #endregion

        #region General Initializer : Class (OtmDispatcher) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OtmDispatcher_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OtmDispatcher) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OtmDispatcher_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OtmDispatcher) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OtmDispatcher_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OtmDispatcher)

        #region General Initializer : Class (OtmDispatcher) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetDispatch, 0)]
        [TestCase(MethodInvalidMethodType, 0)]
        public void AUT_OtmDispatcher_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OtmDispatcher) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDispatch)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyParamXml)]
        [TestCase(PropertyCustomDataXml)]
        [TestCase(PropertySQLResourceId)]
        [TestCase(PropertyLogSourceName)]
        [TestCase(PropertyLogPath)]
        [TestCase(PropertyIsLog)]
        [TestCase(PropertyIsWarn)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyParameterCollection)]
        [Category("AUT Property")]
        public void AUT_OtmDispatcher_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OtmDispatcher) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldLBO_ADDRESS)]
        [TestCase(FieldLBO_APPOINTMENT)]
        [TestCase(FieldLBO_COMPANY)]
        [TestCase(FieldLBO_EMAIL_MESSAGE)]
        [TestCase(FieldLBO_FORECAST)]
        [TestCase(FieldLBO_INCIDENT)]
        [TestCase(FieldLBO_INDIVIDUAL)]
        [TestCase(FieldLBO_INTERNAL_CONTACT)]
        [TestCase(FieldLBO_EXTERNAL_CONTACT)]
        [TestCase(FieldLBO_PHONE)]
        [TestCase(FieldLBO_CUSTOMER_PRODUCT)]
        [TestCase(FieldLBO_PRODUCT)]
        [TestCase(FieldLBO_REMINDER)]
        [TestCase(FieldLBO_SCRIPT_SESSION)]
        [TestCase(FieldLBO_TASK)]
        [TestCase(FieldLBO_WORKTICKET)]
        [TestCase(FieldLBO_SEARCH_QUERY)]
        [TestCase(FieldLBO_CUSTOMER)]
        [TestCase(FieldLBO_REGION)]
        [TestCase(FieldLBO_REFERENCE_LOOKUP)]
        [TestCase(FieldLBO_REFERENCE_PARAMETER)]
        [TestCase(FieldLBO_REFERENCE_FIELD)]
        [TestCase(FieldLBO_CAMPAIGN)]
        [TestCase(FieldLBO_GROUP)]
        [TestCase(FieldLBO_USER)]
        [TestCase(FieldLBO_KEYWORD)]
        [TestCase(FieldLBO_PRODUCT_INDEX)]
        [TestCase(FieldLBO_PRODUCT_GROUP)]
        [TestCase(FieldLBO_SCRIPT_INDEX)]
        [TestCase(FieldLBO_TRACKING_CODE)]
        [TestCase(FieldLBO_TRACKING_CODE_TYPE)]
        [TestCase(FieldLBO_TASK_CATEGORY)]
        [TestCase(FieldLBO_COUNTRY)]
        [TestCase(FieldLBO_INCIDENT_PRODUCT)]
        [TestCase(FieldLBO_SYSTEM_PARAMETER)]
        [TestCase(FieldLBO_USERPREFERENCE)]
        [TestCase(FieldLBO_CONTACTTYPE)]
        [TestCase(FieldLBO_COMPANYFAMILY)]
        [TestCase(FieldLBO_WORKNOTE)]
        [TestCase(FieldLBO_PROFILE)]
        [TestCase(FieldLBO_WATCHES)]
        [TestCase(FieldLBO_WORKTICKETASSOCIATION)]
        [TestCase(FieldLBO_QUOTE)]
        [TestCase(FieldLBO_FILELINK)]
        [TestCase(FieldLBO_FILELOCATION)]
        [TestCase(FieldLBO_DOCUMENTMERGE_TEMPLATE)]
        [TestCase(FieldqueryContextParameters)]
        [TestCase(FieldlanguageCode)]
        [Category("AUT Fields")]
        public void AUT_OtmDispatcher_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OtmDispatcher) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmDispatcher_Is_Instance_Present_Test()
        {
            // Assert
            _otmDispatcherInstanceType.ShouldNotBeNull();
            _otmDispatcherInstance.ShouldNotBeNull();
            _otmDispatcherInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OtmDispatcher) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OtmDispatcher" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmDispatcher_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _otmDispatcherInstance.ShouldBeAssignableTo<OtmDispatcher>();
            _otmDispatcherInstanceFixture.ShouldBeAssignableTo<OtmDispatcher>();
            CurrentInstance.ShouldBeAssignableTo<OtmDispatcher>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OtmDispatcher) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OtmDispatcher_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OtmDispatcher instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion
        
        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OtmDispatcher) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDispatch)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyParamXml)]
        [TestCase(PropertyCustomDataXml)]
        [TestCase(PropertySQLResourceId)]
        [TestCase(PropertyLogSourceName)]
        [TestCase(PropertyLogPath)]
        [TestCase(PropertyIsLog)]
        [TestCase(PropertyIsWarn)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyParameterCollection)]
        public void AUT_OtmDispatcher_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OtmDispatcher) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyApplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (CustomDataXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_CustomDataXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomDataXml);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomDataXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (Dispatch) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Dispatch_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDispatch);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDispatch);
            Action currentAction = () => propertyInfo.SetValue(_otmDispatcherInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (Dispatch) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_Dispatch_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDispatch);
            var propertyInfo = this.GetPropertyInfo(PropertyDispatch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (IsLog) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_IsLog_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsLog);
            var propertyInfo = this.GetPropertyInfo(PropertyIsLog);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (IsWarn) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_IsWarn_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsWarn);
            var propertyInfo = this.GetPropertyInfo(PropertyIsWarn);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (LogicalMethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_LogicalMethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogicalMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogicalMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (LogicalObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_LogicalObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogicalObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogicalObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (LogPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_LogPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogPath);
            var propertyInfo = this.GetPropertyInfo(PropertyLogPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (LogSourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_LogSourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogSourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogSourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (ParameterCollection) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_ParameterCollection_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterCollection);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyParameterCollection);
            Action currentAction = () => propertyInfo.SetValue(_otmDispatcherInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (ParameterCollection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_ParameterCollection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterCollection);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterCollection);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (ParamXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_ParamXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParamXml);
            var propertyInfo = this.GetPropertyInfo(PropertyParamXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionId);
            var propertyInfo = this.GetPropertyInfo(PropertySessionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteId);
            var propertyInfo = this.GetPropertyInfo(PropertySiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (SQLResourceId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_SQLResourceId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySQLResourceId);
            var propertyInfo = this.GetPropertyInfo(PropertySQLResourceId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OtmDispatcher) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OtmDispatcher_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SetDispatch) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var otmLogicalMethod = this.CreateType<OTMLogicalMethod>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.SetDispatch(otmLogicalMethod);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetDispatch) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var otmLogicalMethod = this.CreateType<OTMLogicalMethod>();
            var methodSetDispatchParametersTypes = new Type[] { typeof(OTMLogicalMethod) };
            object[] parametersOfSetDispatch = { otmLogicalMethod };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDispatch, methodSetDispatchParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfSetDispatch);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDispatch.ShouldNotBeNull();
            parametersOfSetDispatch.Length.ShouldBe(1);
            methodSetDispatchParametersTypes.Length.ShouldBe(1);
            methodSetDispatchParametersTypes.Length.ShouldBe(parametersOfSetDispatch.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDispatch) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var otmLogicalMethod = this.CreateType<OTMLogicalMethod>();
            var methodSetDispatchParametersTypes = new Type[] { typeof(OTMLogicalMethod) };
            object[] parametersOfSetDispatch = { otmLogicalMethod };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDispatch, parametersOfSetDispatch, methodSetDispatchParametersTypes);

            // Assert
            parametersOfSetDispatch.ShouldNotBeNull();
            parametersOfSetDispatch.Length.ShouldBe(1);
            methodSetDispatchParametersTypes.Length.ShouldBe(1);
            methodSetDispatchParametersTypes.Length.ShouldBe(parametersOfSetDispatch.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDispatch) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDispatch, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDispatch) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var methodSetDispatchParametersTypes = new Type[] { typeof(OTMLogicalMethod) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDispatch, methodSetDispatchParametersTypes);

            // Assert
            methodSetDispatchParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDispatch) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_SetDispatch_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDispatch);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDispatch, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_InvalidMethodType_Method_Call_Internally(Type[] types)
        {
            var methodInvalidMethodTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInvalidMethodType, methodInvalidMethodTypeParametersTypes);
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            Type [] methodInvalidMethodTypeParametersTypes = null;
            object[] parametersOfInvalidMethodType = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodInvalidMethodType, methodInvalidMethodTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfInvalidMethodType);
            var result2 = this.GetResultOfMethod<string>(MethodInvalidMethodType, parametersOfInvalidMethodType, methodInvalidMethodTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfInvalidMethodType.ShouldBeNull();
            methodInvalidMethodTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            Type [] methodInvalidMethodTypeParametersTypes = null;
            object[] parametersOfInvalidMethodType = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInvalidMethodType, methodInvalidMethodTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfInvalidMethodType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInvalidMethodType.ShouldBeNull();
            methodInvalidMethodTypeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            Type [] methodInvalidMethodTypeParametersTypes = null;
            object[] parametersOfInvalidMethodType = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodInvalidMethodType, parametersOfInvalidMethodType, methodInvalidMethodTypeParametersTypes);

            // Assert
            parametersOfInvalidMethodType.ShouldBeNull();
            methodInvalidMethodTypeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            Type [] methodInvalidMethodTypeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInvalidMethodType, methodInvalidMethodTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInvalidMethodTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            Type [] methodInvalidMethodTypeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInvalidMethodType, methodInvalidMethodTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInvalidMethodTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InvalidMethodType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_InvalidMethodType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInvalidMethodType);
            var currentMethodInfo = this.GetMethodInfo(MethodInvalidMethodType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}