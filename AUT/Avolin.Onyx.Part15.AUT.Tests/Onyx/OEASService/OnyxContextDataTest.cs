using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OEASService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OEASService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OEASService.OnyxContextData" />)
    ///     and namespace <see cref="Onyx.OEASService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxContextDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxContextData" />)
        /// </summary>
        public OnyxContextDataTest() : base(typeof(OnyxContextData))
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

        #region General Initializer : Class (OnyxContextData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxContextDataInstanceType;
        private OnyxContextData _onyxContextDataInstance;
        private OnyxContextData _onyxContextDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxContextData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxContextDataInstanceType = typeof(OnyxContextData);
            _onyxContextDataInstanceFixture = this.Create<OnyxContextData>(false);
            _onyxContextDataInstance = _onyxContextDataInstanceFixture ?? this.Create<OnyxContextData>(true);
            CurrentInstance = _onyxContextDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxContextData) Initializer

        #region Properties

        private const string PropertyUserId = "UserId";
        private const string PropertySessionId = "SessionId";
        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguage = "Language";
        private const string PropertyContentType = "ContentType";
        private const string PropertyRequestData = "RequestData";
        private const string PropertyResponseData = "ResponseData";
        private const string PropertyTransactionID = "TransactionID";
        private const string PropertyUri = "Uri";
        private const string PropertyResponseDataAsStream = "ResponseDataAsStream";
        private const string PropertyStatus = "Status";
        private const string PropertyRawMessage = "RawMessage";

        #endregion

        #region Methods

        private const string MethodRetrieveResponseContentType = "RetrieveResponseContentType";
        private const string MethodRetrieveRequestData = "RetrieveRequestData";
        private const string MethodSetResponseData = "SetResponseData";
        private const string MethodSetResponseDataXml = "SetResponseDataXml";
        private const string MethodSetResponseDataXmlCdata = "SetResponseDataXmlCdata";
        private const string MethodSetResponseDataReturnXml = "SetResponseDataReturnXml";
        private const string MethodSetResponseDataArray = "SetResponseDataArray";
        private const string MethodSetResponseSuccessStatus = "SetResponseSuccessStatus";
        private const string MethodSetResponseFailureStatus = "SetResponseFailureStatus";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxContextData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxContextData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxContextData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxContextData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxContextData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxContextData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxContextData)

        #region General Initializer : Class (OnyxContextData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetrieveResponseContentType, 0)]
        [TestCase(MethodRetrieveRequestData, 0)]
        [TestCase(MethodSetResponseData, 0)]
        [TestCase(MethodSetResponseDataXml, 0)]
        [TestCase(MethodSetResponseDataXmlCdata, 0)]
        [TestCase(MethodSetResponseDataReturnXml, 0)]
        [TestCase(MethodSetResponseDataArray, 0)]
        [TestCase(MethodSetResponseSuccessStatus, 0)]
        [TestCase(MethodSetResponseFailureStatus, 0)]
        public void AUT_OnyxContextData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxContextData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyContentType)]
        [TestCase(PropertyRequestData)]
        [TestCase(PropertyResponseData)]
        [TestCase(PropertyTransactionID)]
        [TestCase(PropertyUri)]
        [TestCase(PropertyResponseDataAsStream)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyRawMessage)]
        [Category("AUT Property")]
        public void AUT_OnyxContextData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxContextData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxContextData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxContextData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxContextData_Is_Instance_Present_Test()
        {
            // Assert
            _onyxContextDataInstanceType.ShouldNotBeNull();
            _onyxContextDataInstance.ShouldNotBeNull();
            _onyxContextDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxContextData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxContextData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxContextData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxContextDataInstance.ShouldBeAssignableTo<OnyxContextData>();
            _onyxContextDataInstanceFixture.ShouldBeAssignableTo<OnyxContextData>();
            CurrentInstance.ShouldBeAssignableTo<OnyxContextData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxContextData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxContextData_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var postData = this.CreateType<dynamic>();
            OnyxContextData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxContextData(postData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxContextDataInstance.ShouldNotBeNull();
            _onyxContextDataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxContextData>();
        }

        #endregion

        #region General Constructor : Class (OnyxContextData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxContextData_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var postData = this.CreateType<dynamic>();
            OnyxContextData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxContextData(postData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxContextDataInstance.ShouldNotBeNull();
            _onyxContextDataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxContextData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyContentType)]
        [TestCase(PropertyRequestData)]
        [TestCase(PropertyResponseData)]
        [TestCase(PropertyTransactionID)]
        [TestCase(PropertyUri)]
        [TestCase(PropertyResponseDataAsStream)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyRawMessage)]
        public void AUT_OnyxContextData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxContextData) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxContextData) => Property (ContentType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_ContentType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContentType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyContentType);
            Action currentAction = () => propertyInfo.SetValue(_onyxContextDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (ContentType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_ContentType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContentType);
            var propertyInfo = this.GetPropertyInfo(PropertyContentType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (RawMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_RawMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRawMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyRawMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (RequestData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_RequestData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyRequestData);
            Action currentAction = () => propertyInfo.SetValue(_onyxContextDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (RequestData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_RequestData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequestData);
            var propertyInfo = this.GetPropertyInfo(PropertyRequestData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (ResponseData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_ResponseData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResponseData);
            Action currentAction = () => propertyInfo.SetValue(_onyxContextDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (ResponseData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_ResponseData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseData);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (ResponseDataAsStream) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_ResponseDataAsStream_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseDataAsStream);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResponseDataAsStream);
            Action currentAction = () => propertyInfo.SetValue(_onyxContextDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (ResponseDataAsStream) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_ResponseDataAsStream_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseDataAsStream);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseDataAsStream);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxContextData) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxContextData) => Property (Status) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Status_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);
            Action currentAction = () => propertyInfo.SetValue(_onyxContextDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (TransactionID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_TransactionID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTransactionID);
            var propertyInfo = this.GetPropertyInfo(PropertyTransactionID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (Uri) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_Uri_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUri);
            var propertyInfo = this.GetPropertyInfo(PropertyUri);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxContextData) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxContextData_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);

            // Act
            Action executeAction = () => _onyxContextDataInstance.RetrieveResponseContentType();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;
            object[] parametersOfRetrieveResponseContentType = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfRetrieveResponseContentType);
            var result2 = this.GetResultOfMethod<bool>(MethodRetrieveResponseContentType, parametersOfRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRetrieveResponseContentType.ShouldBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;
            object[] parametersOfRetrieveResponseContentType = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfRetrieveResponseContentType);
            var result2 = this.GetResultOfMethod<bool>(MethodRetrieveResponseContentType, parametersOfRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRetrieveResponseContentType.ShouldBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;
            object[] parametersOfRetrieveResponseContentType = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfRetrieveResponseContentType);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRetrieveResponseContentType.ShouldBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;
            object[] parametersOfRetrieveResponseContentType = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodRetrieveResponseContentType, parametersOfRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            parametersOfRetrieveResponseContentType.ShouldBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            Type [] methodRetrieveResponseContentTypeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveResponseContentType, methodRetrieveResponseContentTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveResponseContentTypeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveResponseContentType) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_RetrieveResponseContentType_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveResponseContentType);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveResponseContentType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseData_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseData, methodSetResponseDataParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var value = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseData(value);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var value = this.CreateType<string>();
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseData = { value };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseData, methodSetResponseDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseData);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseData, parametersOfSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseData.ShouldNotBeNull();
            parametersOfSetResponseData.Length.ShouldBe(1);
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var value = this.CreateType<string>();
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseData = { value };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseData, methodSetResponseDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseData);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseData, parametersOfSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseData.ShouldNotBeNull();
            parametersOfSetResponseData.Length.ShouldBe(1);
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var value = this.CreateType<string>();
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseData = { value };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseData, methodSetResponseDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseData.ShouldNotBeNull();
            parametersOfSetResponseData.Length.ShouldBe(1);
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var value = this.CreateType<string>();
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseData = { value };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseData, parametersOfSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            parametersOfSetResponseData.ShouldNotBeNull();
            parametersOfSetResponseData.Length.ShouldBe(1);
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var methodSetResponseDataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseData, methodSetResponseDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseData) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseData);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseDataXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var returnXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseDataXml(returnXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXml = { returnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseDataXml);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataXml, parametersOfSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataXml.ShouldNotBeNull();
            parametersOfSetResponseDataXml.Length.ShouldBe(1);
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXml = { returnXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseDataXml);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataXml, parametersOfSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataXml.ShouldNotBeNull();
            parametersOfSetResponseDataXml.Length.ShouldBe(1);
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXml = { returnXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseDataXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseDataXml.ShouldNotBeNull();
            parametersOfSetResponseDataXml.Length.ShouldBe(1);
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXml = { returnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseDataXml, parametersOfSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            parametersOfSetResponseDataXml.ShouldNotBeNull();
            parametersOfSetResponseDataXml.Length.ShouldBe(1);
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var methodSetResponseDataXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXml, methodSetResponseDataXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseDataXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseDataXml) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseDataXmlCdataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var returnXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseDataXmlCdata(returnXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXmlCdata = { returnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseDataXmlCdata);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataXmlCdata, parametersOfSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.Length.ShouldBe(1);
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXmlCdata = { returnXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseDataXmlCdata);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataXmlCdata, parametersOfSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.Length.ShouldBe(1);
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXmlCdata = { returnXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseDataXmlCdata);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseDataXmlCdata.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.Length.ShouldBe(1);
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataXmlCdata = { returnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseDataXmlCdata, parametersOfSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            parametersOfSetResponseDataXmlCdata.ShouldNotBeNull();
            parametersOfSetResponseDataXmlCdata.Length.ShouldBe(1);
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var methodSetResponseDataXmlCdataParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseDataXmlCdata, methodSetResponseDataXmlCdataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseDataXmlCdataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXmlCdata, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseDataXmlCdata) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataXmlCdata_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataXmlCdata);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataXmlCdata, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseDataReturnXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var returnXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseDataReturnXml(returnXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataReturnXml = { returnXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseDataReturnXml);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataReturnXml, parametersOfSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.Length.ShouldBe(1);
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataReturnXml = { returnXml };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseDataReturnXml);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataReturnXml, parametersOfSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.Length.ShouldBe(1);
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataReturnXml = { returnXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseDataReturnXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseDataReturnXml.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.Length.ShouldBe(1);
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var returnXml = this.CreateType<string>();
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseDataReturnXml = { returnXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseDataReturnXml, parametersOfSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            parametersOfSetResponseDataReturnXml.ShouldNotBeNull();
            parametersOfSetResponseDataReturnXml.Length.ShouldBe(1);
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var methodSetResponseDataReturnXmlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseDataReturnXml, methodSetResponseDataReturnXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseDataReturnXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataReturnXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseDataReturnXml) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataReturnXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataReturnXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataReturnXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseDataArrayParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var returnArray = this.CreateType<object[,]>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseDataArray(returnArray);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var returnArray = this.CreateType<object[,]>();
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };
            object[] parametersOfSetResponseDataArray = { returnArray };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseDataArray);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataArray, parametersOfSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataArray.ShouldNotBeNull();
            parametersOfSetResponseDataArray.Length.ShouldBe(1);
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var returnArray = this.CreateType<object[,]>();
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };
            object[] parametersOfSetResponseDataArray = { returnArray };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseDataArray);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseDataArray, parametersOfSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseDataArray.ShouldNotBeNull();
            parametersOfSetResponseDataArray.Length.ShouldBe(1);
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var returnArray = this.CreateType<object[,]>();
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };
            object[] parametersOfSetResponseDataArray = { returnArray };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseDataArray);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseDataArray.ShouldNotBeNull();
            parametersOfSetResponseDataArray.Length.ShouldBe(1);
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var returnArray = this.CreateType<object[,]>();
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };
            object[] parametersOfSetResponseDataArray = { returnArray };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseDataArray, parametersOfSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            parametersOfSetResponseDataArray.ShouldNotBeNull();
            parametersOfSetResponseDataArray.Length.ShouldBe(1);
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var methodSetResponseDataArrayParametersTypes = new Type[] { typeof(object[,]) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseDataArray, methodSetResponseDataArrayParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseDataArrayParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataArray, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseDataArray) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseDataArray_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseDataArray);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseDataArray, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseSuccessStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseSuccessStatus();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;
            object[] parametersOfSetResponseSuccessStatus = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseSuccessStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseSuccessStatus, parametersOfSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseSuccessStatus.ShouldBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;
            object[] parametersOfSetResponseSuccessStatus = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseSuccessStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseSuccessStatus, parametersOfSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseSuccessStatus.ShouldBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;
            object[] parametersOfSetResponseSuccessStatus = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseSuccessStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseSuccessStatus.ShouldBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;
            object[] parametersOfSetResponseSuccessStatus = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseSuccessStatus, parametersOfSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            parametersOfSetResponseSuccessStatus.ShouldBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            Type [] methodSetResponseSuccessStatusParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseSuccessStatus, methodSetResponseSuccessStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseSuccessStatusParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetResponseSuccessStatus) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseSuccessStatus_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseSuccessStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseSuccessStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Internally(Type[] types)
        {
            var methodSetResponseFailureStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var errorDescription = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxContextDataInstance.SetResponseFailureStatus(errorDescription);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var errorDescription = this.CreateType<string>();
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseFailureStatus = { errorDescription };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, parametersOfSetResponseFailureStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseFailureStatus, parametersOfSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.Length.ShouldBe(1);
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var errorDescription = this.CreateType<string>();
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseFailureStatus = { errorDescription };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxContextDataInstanceFixture, out exception1, parametersOfSetResponseFailureStatus);
            var result2 = this.GetResultOfMethod<bool>(MethodSetResponseFailureStatus, parametersOfSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.Length.ShouldBe(1);
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var errorDescription = this.CreateType<string>();
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseFailureStatus = { errorDescription };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxContextDataInstanceFixture, parametersOfSetResponseFailureStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResponseFailureStatus.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.Length.ShouldBe(1);
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var errorDescription = this.CreateType<string>();
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetResponseFailureStatus = { errorDescription };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodSetResponseFailureStatus, parametersOfSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            parametersOfSetResponseFailureStatus.ShouldNotBeNull();
            parametersOfSetResponseFailureStatus.Length.ShouldBe(1);
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var methodSetResponseFailureStatusParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResponseFailureStatus, methodSetResponseFailureStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetResponseFailureStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseFailureStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SetResponseFailureStatus) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxContextData_SetResponseFailureStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResponseFailureStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResponseFailureStatus, 0);
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