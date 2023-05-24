using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.OtmDispatcher" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
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
        private const string MethodAddPrimaryIdParameter = "AddPrimaryIdParameter";
        private const string MethodAddPrimaryIdParameterForParentEntity = "AddPrimaryIdParameterForParentEntity";
        private const string MethodPrepare = "Prepare";
        private const string MethodGetSearchQueryInputXml = "GetSearchQueryInputXml";
        private const string MethodGetParameters = "GetParameters";
        private const string MethodGetUpdatedData = "GetUpdatedData";
        private const string MethodGetUpdatedDataOfParentEntity = "GetUpdatedDataOfParentEntity";
        private const string MethodGetStatus = "GetStatus";
        private const string MethodConvertJsonToLboXml = "ConvertJsonToLboXml";
        private const string MethodUpdateMruItem = "UpdateMruItem";
        private const string MethodUpdateMriItem = "UpdateMriItem";
        private const string MethodGetEntityId = "GetEntityId";
        private const string MethodGetValueFromParameterCollection = "GetValueFromParameterCollection";

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
        [TestCase(MethodAddPrimaryIdParameter, 0)]
        [TestCase(MethodAddPrimaryIdParameterForParentEntity, 0)]
        [TestCase(MethodPrepare, 0)]
        [TestCase(MethodGetSearchQueryInputXml, 0)]
        [TestCase(MethodGetParameters, 0)]
        [TestCase(MethodGetUpdatedData, 0)]
        [TestCase(MethodGetUpdatedDataOfParentEntity, 0)]
        [TestCase(MethodGetStatus, 0)]
        [TestCase(MethodConvertJsonToLboXml, 0)]
        [TestCase(MethodUpdateMruItem, 0)]
        [TestCase(MethodUpdateMriItem, 0)]
        [TestCase(MethodGetEntityId, 0)]
        [TestCase(MethodGetValueFromParameterCollection, 0)]
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

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_Call_Internally(Type[] types)
        {
            var methodAddPrimaryIdParameterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddPrimaryIdParameter, methodAddPrimaryIdParameterParametersTypes);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameter);

            // Act
            Action executeAction = () => _otmDispatcherInstance.AddPrimaryIdParameter();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameter);
            Type [] methodAddPrimaryIdParameterParametersTypes = null;
            object[] parametersOfAddPrimaryIdParameter = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddPrimaryIdParameter, methodAddPrimaryIdParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfAddPrimaryIdParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddPrimaryIdParameter.ShouldBeNull();
            methodAddPrimaryIdParameterParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameter);
            Type [] methodAddPrimaryIdParameterParametersTypes = null;
            object[] parametersOfAddPrimaryIdParameter = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddPrimaryIdParameter, parametersOfAddPrimaryIdParameter, methodAddPrimaryIdParameterParametersTypes);

            // Assert
            parametersOfAddPrimaryIdParameter.ShouldBeNull();
            methodAddPrimaryIdParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameter);
            Type [] methodAddPrimaryIdParameterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddPrimaryIdParameter, methodAddPrimaryIdParameterParametersTypes);

            // Assert
            methodAddPrimaryIdParameterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameter) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameter_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodAddPrimaryIdParameter, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_Call_Internally(Type[] types)
        {
            var methodAddPrimaryIdParameterForParentEntityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddPrimaryIdParameterForParentEntity, methodAddPrimaryIdParameterForParentEntityParametersTypes);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameterForParentEntity);

            // Act
            Action executeAction = () => _otmDispatcherInstance.AddPrimaryIdParameterForParentEntity();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameterForParentEntity);
            Type [] methodAddPrimaryIdParameterForParentEntityParametersTypes = null;
            object[] parametersOfAddPrimaryIdParameterForParentEntity = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddPrimaryIdParameterForParentEntity, methodAddPrimaryIdParameterForParentEntityParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfAddPrimaryIdParameterForParentEntity);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddPrimaryIdParameterForParentEntity.ShouldBeNull();
            methodAddPrimaryIdParameterForParentEntityParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameterForParentEntity);
            Type [] methodAddPrimaryIdParameterForParentEntityParametersTypes = null;
            object[] parametersOfAddPrimaryIdParameterForParentEntity = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddPrimaryIdParameterForParentEntity, parametersOfAddPrimaryIdParameterForParentEntity, methodAddPrimaryIdParameterForParentEntityParametersTypes);

            // Assert
            parametersOfAddPrimaryIdParameterForParentEntity.ShouldBeNull();
            methodAddPrimaryIdParameterForParentEntityParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameterForParentEntity);
            Type [] methodAddPrimaryIdParameterForParentEntityParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddPrimaryIdParameterForParentEntity, methodAddPrimaryIdParameterForParentEntityParametersTypes);

            // Assert
            methodAddPrimaryIdParameterForParentEntityParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddPrimaryIdParameterForParentEntity) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_AddPrimaryIdParameterForParentEntity_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddPrimaryIdParameterForParentEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodAddPrimaryIdParameterForParentEntity, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_Prepare_Method_Call_Internally(Type[] types)
        {
            var methodPrepareParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPrepare, methodPrepareParametersTypes);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.Prepare(parameterCollection);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodPrepareParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfPrepare = { parameterCollection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPrepare, methodPrepareParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfPrepare);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPrepare.ShouldNotBeNull();
            parametersOfPrepare.Length.ShouldBe(1);
            methodPrepareParametersTypes.Length.ShouldBe(1);
            methodPrepareParametersTypes.Length.ShouldBe(parametersOfPrepare.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var parameterCollection = this.CreateType<Hashtable>();
            var methodPrepareParametersTypes = new Type[] { typeof(Hashtable) };
            object[] parametersOfPrepare = { parameterCollection };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPrepare, parametersOfPrepare, methodPrepareParametersTypes);

            // Assert
            parametersOfPrepare.ShouldNotBeNull();
            parametersOfPrepare.Length.ShouldBe(1);
            methodPrepareParametersTypes.Length.ShouldBe(1);
            methodPrepareParametersTypes.Length.ShouldBe(parametersOfPrepare.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepare, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var methodPrepareParametersTypes = new Type[] { typeof(Hashtable) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrepare, methodPrepareParametersTypes);

            // Assert
            methodPrepareParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Prepare) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_Prepare_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepare);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepare, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchQueryInputXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var sqlQuery = this.CreateType<string>();
            var queryParameter = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetSearchQueryInputXml(sqlQuery, queryParameter);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var sqlQuery = this.CreateType<string>();
            var queryParameter = this.CreateType<Hashtable>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.GetSearchQueryInputXml(sqlQuery, queryParameter);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var sqlQuery = this.CreateType<string>();
            var queryParameter = this.CreateType<Hashtable>();
            var methodGetSearchQueryInputXmlParametersTypes = new Type[] { typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSearchQueryInputXml = { sqlQuery, queryParameter };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfGetSearchQueryInputXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetSearchQueryInputXml, parametersOfGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchQueryInputXml.ShouldNotBeNull();
            parametersOfGetSearchQueryInputXml.Length.ShouldBe(2);
            methodGetSearchQueryInputXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var sqlQuery = this.CreateType<string>();
            var queryParameter = this.CreateType<Hashtable>();
            var methodGetSearchQueryInputXmlParametersTypes = new Type[] { typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSearchQueryInputXml = { sqlQuery, queryParameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSearchQueryInputXml, parametersOfGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes);

            // Assert
            parametersOfGetSearchQueryInputXml.ShouldNotBeNull();
            parametersOfGetSearchQueryInputXml.Length.ShouldBe(2);
            methodGetSearchQueryInputXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var methodGetSearchQueryInputXmlParametersTypes = new Type[] { typeof(string), typeof(Hashtable) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchQueryInputXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var methodGetSearchQueryInputXmlParametersTypes = new Type[] { typeof(string), typeof(Hashtable) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchQueryInputXml, methodGetSearchQueryInputXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchQueryInputXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchQueryInputXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchQueryInputXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetSearchQueryInputXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchQueryInputXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchQueryInputXml, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetParameters_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var parameters = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetParameters(parameters);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var parameters = this.CreateType<string>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.GetParameters(parameters);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var parameters = this.CreateType<string>();
            var methodGetParametersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParameters = { parameters };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, methodGetParametersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Hashtable>(_otmDispatcherInstanceFixture, out exception1, parametersOfGetParameters);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetParameters, parametersOfGetParameters, methodGetParametersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetParameters.ShouldNotBeNull();
            parametersOfGetParameters.Length.ShouldBe(1);
            methodGetParametersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var parameters = this.CreateType<string>();
            var methodGetParametersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParameters = { parameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, methodGetParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_otmDispatcherInstanceFixture, parametersOfGetParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetParameters.ShouldNotBeNull();
            parametersOfGetParameters.Length.ShouldBe(1);
            methodGetParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var parameters = this.CreateType<string>();
            var methodGetParametersParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetParameters = { parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetParameters, parametersOfGetParameters, methodGetParametersParametersTypes);

            // Assert
            parametersOfGetParameters.ShouldNotBeNull();
            parametersOfGetParameters.Length.ShouldBe(1);
            methodGetParametersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var methodGetParametersParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetParametersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var methodGetParametersParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetUpdatedData_Method_Call_Internally(Type[] types)
        {
            var methodGetUpdatedDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUpdatedData, methodGetUpdatedDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var entity = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetUpdatedData(entity);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var entity = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.GetUpdatedData(entity);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var entity = this.CreateType<string>();
            var methodGetUpdatedDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUpdatedData = { entity };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedData, methodGetUpdatedDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfGetUpdatedData);
            var result2 = this.GetResultOfMethod<string>(MethodGetUpdatedData, parametersOfGetUpdatedData, methodGetUpdatedDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUpdatedData.ShouldNotBeNull();
            parametersOfGetUpdatedData.Length.ShouldBe(1);
            methodGetUpdatedDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var entity = this.CreateType<string>();
            var methodGetUpdatedDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUpdatedData = { entity };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUpdatedData, parametersOfGetUpdatedData, methodGetUpdatedDataParametersTypes);

            // Assert
            parametersOfGetUpdatedData.ShouldNotBeNull();
            parametersOfGetUpdatedData.Length.ShouldBe(1);
            methodGetUpdatedDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var methodGetUpdatedDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUpdatedData, methodGetUpdatedDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUpdatedDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var methodGetUpdatedDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUpdatedData, methodGetUpdatedDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUpdatedDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpdatedData) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_Internally(Type[] types)
        {
            var methodGetUpdatedDataOfParentEntityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var entity = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetUpdatedDataOfParentEntity(entity);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var entity = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.GetUpdatedDataOfParentEntity(entity);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var entity = this.CreateType<string>();
            var methodGetUpdatedDataOfParentEntityParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUpdatedDataOfParentEntity = { entity };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfGetUpdatedDataOfParentEntity);
            var result2 = this.GetResultOfMethod<string>(MethodGetUpdatedDataOfParentEntity, parametersOfGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUpdatedDataOfParentEntity.ShouldNotBeNull();
            parametersOfGetUpdatedDataOfParentEntity.Length.ShouldBe(1);
            methodGetUpdatedDataOfParentEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var entity = this.CreateType<string>();
            var methodGetUpdatedDataOfParentEntityParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUpdatedDataOfParentEntity = { entity };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUpdatedDataOfParentEntity, parametersOfGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes);

            // Assert
            parametersOfGetUpdatedDataOfParentEntity.ShouldNotBeNull();
            parametersOfGetUpdatedDataOfParentEntity.Length.ShouldBe(1);
            methodGetUpdatedDataOfParentEntityParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var methodGetUpdatedDataOfParentEntityParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUpdatedDataOfParentEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var methodGetUpdatedDataOfParentEntityParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUpdatedDataOfParentEntity, methodGetUpdatedDataOfParentEntityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUpdatedDataOfParentEntityParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedDataOfParentEntity, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUpdatedDataOfParentEntity) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetUpdatedDataOfParentEntity_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUpdatedDataOfParentEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUpdatedDataOfParentEntity, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetStatus_Method_Call_Internally(Type[] types)
        {
            var methodGetStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var lboReturnXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetStatus(lboReturnXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var lboReturnXml = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetStatus = { lboReturnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, methodGetStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, parametersOfGetStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(1);
            methodGetStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var lboReturnXml = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetStatus = { lboReturnXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, methodGetStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, out exception1, parametersOfGetStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(1);
            methodGetStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var lboReturnXml = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetStatus = { lboReturnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(1);
            methodGetStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var methodGetStatusParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_Internally(Type[] types)
        {
            var methodConvertJsonToLboXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var jsonAsXmlDoc = this.CreateType<XmlDocument>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.ConvertJsonToLboXml(jsonAsXmlDoc);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var jsonAsXmlDoc = this.CreateType<XmlDocument>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.ConvertJsonToLboXml(jsonAsXmlDoc);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var jsonAsXmlDoc = this.CreateType<XmlDocument>();
            var methodConvertJsonToLboXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfConvertJsonToLboXml = { jsonAsXmlDoc };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfConvertJsonToLboXml);
            var result2 = this.GetResultOfMethod<string>(MethodConvertJsonToLboXml, parametersOfConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfConvertJsonToLboXml.ShouldNotBeNull();
            parametersOfConvertJsonToLboXml.Length.ShouldBe(1);
            methodConvertJsonToLboXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var jsonAsXmlDoc = this.CreateType<XmlDocument>();
            var methodConvertJsonToLboXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            object[] parametersOfConvertJsonToLboXml = { jsonAsXmlDoc };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertJsonToLboXml, parametersOfConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes);

            // Assert
            parametersOfConvertJsonToLboXml.ShouldNotBeNull();
            parametersOfConvertJsonToLboXml.Length.ShouldBe(1);
            methodConvertJsonToLboXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var methodConvertJsonToLboXmlParametersTypes = new Type[] { typeof(XmlDocument) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertJsonToLboXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var methodConvertJsonToLboXmlParametersTypes = new Type[] { typeof(XmlDocument) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertJsonToLboXml, methodConvertJsonToLboXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertJsonToLboXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertJsonToLboXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertJsonToLboXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_ConvertJsonToLboXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertJsonToLboXml);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertJsonToLboXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_UpdateMruItem_Method_Call_Internally(Type[] types)
        {
            var methodUpdateMruItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateMruItem, methodUpdateMruItemParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var primaryId = this.CreateType<string>();
            var customerType = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.UpdateMruItem(primaryId, customerType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var primaryId = this.CreateType<string>();
            var customerType = this.CreateType<string>();
            var methodUpdateMruItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMruItem = { primaryId, customerType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMruItem, methodUpdateMruItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, parametersOfUpdateMruItem);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateMruItem, parametersOfUpdateMruItem, methodUpdateMruItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateMruItem.ShouldNotBeNull();
            parametersOfUpdateMruItem.Length.ShouldBe(2);
            methodUpdateMruItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var primaryId = this.CreateType<string>();
            var customerType = this.CreateType<string>();
            var methodUpdateMruItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMruItem = { primaryId, customerType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMruItem, methodUpdateMruItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, out exception1, parametersOfUpdateMruItem);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateMruItem, parametersOfUpdateMruItem, methodUpdateMruItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateMruItem.ShouldNotBeNull();
            parametersOfUpdateMruItem.Length.ShouldBe(2);
            methodUpdateMruItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var primaryId = this.CreateType<string>();
            var customerType = this.CreateType<string>();
            var methodUpdateMruItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMruItem = { primaryId, customerType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateMruItem, parametersOfUpdateMruItem, methodUpdateMruItemParametersTypes);

            // Assert
            parametersOfUpdateMruItem.ShouldNotBeNull();
            parametersOfUpdateMruItem.Length.ShouldBe(2);
            methodUpdateMruItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var methodUpdateMruItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateMruItem, methodUpdateMruItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateMruItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMruItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateMruItem) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMruItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMruItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMruItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_UpdateMriItem_Method_Call_Internally(Type[] types)
        {
            var methodUpdateMriItemParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateMriItem, methodUpdateMriItemParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var primaryId = this.CreateType<string>();
            var incidentType = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.UpdateMriItem(primaryId, incidentType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var primaryId = this.CreateType<string>();
            var incidentType = this.CreateType<string>();
            var methodUpdateMriItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMriItem = { primaryId, incidentType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMriItem, methodUpdateMriItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, parametersOfUpdateMriItem);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateMriItem, parametersOfUpdateMriItem, methodUpdateMriItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateMriItem.ShouldNotBeNull();
            parametersOfUpdateMriItem.Length.ShouldBe(2);
            methodUpdateMriItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var primaryId = this.CreateType<string>();
            var incidentType = this.CreateType<string>();
            var methodUpdateMriItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMriItem = { primaryId, incidentType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMriItem, methodUpdateMriItemParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_otmDispatcherInstanceFixture, out exception1, parametersOfUpdateMriItem);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateMriItem, parametersOfUpdateMriItem, methodUpdateMriItemParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateMriItem.ShouldNotBeNull();
            parametersOfUpdateMriItem.Length.ShouldBe(2);
            methodUpdateMriItemParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var primaryId = this.CreateType<string>();
            var incidentType = this.CreateType<string>();
            var methodUpdateMriItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfUpdateMriItem = { primaryId, incidentType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateMriItem, parametersOfUpdateMriItem, methodUpdateMriItemParametersTypes);

            // Assert
            parametersOfUpdateMriItem.ShouldNotBeNull();
            parametersOfUpdateMriItem.Length.ShouldBe(2);
            methodUpdateMriItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var methodUpdateMriItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateMriItem, methodUpdateMriItemParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateMriItemParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMriItem, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateMriItem) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_UpdateMriItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateMriItem);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateMriItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetEntityId_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityId, methodGetEntityIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmDispatcherInstance.GetEntityId(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmDispatcherInstance.GetEntityId(queryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<string>();
            var methodGetEntityIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEntityId = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, methodGetEntityIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfGetEntityId);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntityId, parametersOfGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityId.ShouldNotBeNull();
            parametersOfGetEntityId.Length.ShouldBe(1);
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var queryId = this.CreateType<string>();
            var methodGetEntityIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEntityId = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntityId, parametersOfGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            parametersOfGetEntityId.ShouldNotBeNull();
            parametersOfGetEntityId.Length.ShouldBe(1);
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var methodGetEntityIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var methodGetEntityIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityId, methodGetEntityIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityId) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetEntityId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_Internally(Type[] types)
        {
            var methodGetValueFromParameterCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var key = this.CreateType<string>();
            var methodGetValueFromParameterCollectionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetValueFromParameterCollection = { key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmDispatcherInstanceFixture, parametersOfGetValueFromParameterCollection);
            var result2 = this.GetResultOfMethod<string>(MethodGetValueFromParameterCollection, parametersOfGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetValueFromParameterCollection.ShouldNotBeNull();
            parametersOfGetValueFromParameterCollection.Length.ShouldBe(1);
            methodGetValueFromParameterCollectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var key = this.CreateType<string>();
            var methodGetValueFromParameterCollectionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetValueFromParameterCollection = { key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetValueFromParameterCollection, parametersOfGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes);

            // Assert
            parametersOfGetValueFromParameterCollection.ShouldNotBeNull();
            parametersOfGetValueFromParameterCollection.Length.ShouldBe(1);
            methodGetValueFromParameterCollectionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var methodGetValueFromParameterCollectionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetValueFromParameterCollectionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var methodGetValueFromParameterCollectionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetValueFromParameterCollection, methodGetValueFromParameterCollectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetValueFromParameterCollectionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodGetValueFromParameterCollection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetValueFromParameterCollection) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmDispatcher_GetValueFromParameterCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetValueFromParameterCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodGetValueFromParameterCollection, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}