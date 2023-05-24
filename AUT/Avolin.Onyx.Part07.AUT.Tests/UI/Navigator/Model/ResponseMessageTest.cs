using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResponseMessage" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResponseMessageTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResponseMessage" />)
        /// </summary>
        public ResponseMessageTest() : base(typeof(ResponseMessage))
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

        #region General Initializer : Class (ResponseMessage) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _responseMessageInstanceType;
        private ResponseMessage _responseMessageInstance;
        private ResponseMessage _responseMessageInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResponseMessage" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _responseMessageInstanceType = typeof(ResponseMessage);
            _responseMessageInstanceFixture = this.Create<ResponseMessage>(false);
            _responseMessageInstance = _responseMessageInstanceFixture ?? this.Create<ResponseMessage>(true);
            CurrentInstance = _responseMessageInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResponseMessage) Initializer

        #region Properties

        private const string PropertyResult = "Result";
        private const string PropertyErrorCode = "ErrorCode";
        private const string PropertyErrorType = "ErrorType";
        private const string PropertyErrorText = "ErrorText";
        private const string PropertyErrorDetails = "ErrorDetails";
        private const string PropertyPayload = "Payload";
        private const string PropertyLocalizedErrorText = "LocalizedErrorText";
        private const string PropertySuccess = "Success";

        #endregion

        #endregion

        #region General Initializer : Class (ResponseMessage) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResponseMessage_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResponseMessage) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResponseMessage_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResponseMessage) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResponseMessage_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResponseMessage)

        #region General Initializer : Class (ResponseMessage) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyErrorCode)]
        [TestCase(PropertyErrorType)]
        [TestCase(PropertyErrorText)]
        [TestCase(PropertyErrorDetails)]
        [TestCase(PropertyPayload)]
        [TestCase(PropertyLocalizedErrorText)]
        [TestCase(PropertySuccess)]
        [Category("AUT Property")]
        public void AUT_ResponseMessage_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ResponseMessage) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResponseMessage_Is_Instance_Present_Test()
        {
            // Assert
            _responseMessageInstanceType.ShouldNotBeNull();
            _responseMessageInstance.ShouldNotBeNull();
            _responseMessageInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResponseMessage) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResponseMessage_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _responseMessageInstance.ShouldBeAssignableTo<ResponseMessage>();
            _responseMessageInstanceFixture.ShouldBeAssignableTo<ResponseMessage>();
            CurrentInstance.ShouldBeAssignableTo<ResponseMessage>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResponseMessage) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResponseMessage instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var payload = this.CreateType<object>();
            ResponseMessage instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResponseMessage(payload);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _responseMessageInstance.ShouldNotBeNull();
            _responseMessageInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ResponseMessage>();
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var payload = this.CreateType<object>();
            ResponseMessage instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ResponseMessage(payload);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _responseMessageInstance.ShouldNotBeNull();
            _responseMessageInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) instance created

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Is_Created_Test()
        {
            // Assert
            _responseMessageInstance.ShouldNotBeNull();
            _responseMessageInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ResponseMessage" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ResponseMessage_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ResponseMessage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ResponseMessage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodResponseMessageParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodResponseMessageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ResponseMessage" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodResponseMessageParametersTypes = new Type[] { typeof(object) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodResponseMessageParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ResponseMessage) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResponseMessage_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var responseMessageInstance  = new ResponseMessage();

            // Asserts
            responseMessageInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResponseMessage) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResult)]
        [TestCase(PropertyErrorCode)]
        [TestCase(PropertyErrorType)]
        [TestCase(PropertyErrorText)]
        [TestCase(PropertyErrorDetails)]
        [TestCase(PropertyPayload)]
        [TestCase(PropertyLocalizedErrorText)]
        [TestCase(PropertySuccess)]
        public void AUT_ResponseMessage_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResponseMessage) => Property (ErrorCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_ErrorCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorCode);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (ErrorDetails) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_ErrorDetails_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorDetails);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorDetails);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (ErrorText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_ErrorText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorText);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (ErrorType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_ErrorType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorType);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (LocalizedErrorText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_LocalizedErrorText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLocalizedErrorText);
            var propertyInfo = this.GetPropertyInfo(PropertyLocalizedErrorText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (Payload) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_Payload_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPayload);
            var propertyInfo = this.GetPropertyInfo(PropertyPayload);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var propertyInfo = this.GetPropertyInfo(PropertyResult);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResponseMessage) => Property (Success) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResponseMessage_Public_Class_Success_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySuccess);
            var propertyInfo = this.GetPropertyInfo(PropertySuccess);

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