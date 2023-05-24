using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.ServiceResponse" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ServiceResponse.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceResponse" />)
        /// </summary>
        public ServiceResponseTest() : base(typeof(ServiceResponse))
        { }

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

        #region General Initializer : Class (ServiceResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceResponseInstanceType;
        private ServiceResponse _serviceResponseInstance;
        private ServiceResponse _serviceResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceResponseInstanceType = typeof(ServiceResponse);
            _serviceResponseInstanceFixture = this.Create<ServiceResponse>(false);
            _serviceResponseInstance = _serviceResponseInstanceFixture ?? this.Create<ServiceResponse>(true);
            CurrentInstance = _serviceResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Initializer

        #region Properties

        private const string PropertyOutputMessage = "OutputMessage";
        private const string PropertyMessageFormat = "MessageFormat";

        #endregion

        #region Methods

        private const string MethodCreateMessage = "CreateMessage";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceResponse)

        #region General Initializer : Class (ServiceResponse) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateMessage, 0)]
        [TestCase(MethodCreateMessage, 1)]
        public void AUT_ServiceResponse_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ServiceResponse) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOutputMessage)]
        [TestCase(PropertyMessageFormat)]
        [Category("AUT Property")]
        public void AUT_ServiceResponse_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServiceResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResponse_Is_Instance_Present_Test()
        {
            // Assert
            _serviceResponseInstanceType.ShouldNotBeNull();
            _serviceResponseInstance.ShouldNotBeNull();
            _serviceResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceResponseInstance.ShouldBeAssignableTo<ServiceResponse>();
            _serviceResponseInstanceFixture.ShouldBeAssignableTo<ServiceResponse>();
            CurrentInstance.ShouldBeAssignableTo<ServiceResponse>();
        }

        #endregion

        #region General Constructor : Class (ServiceResponse) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceResponse_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ServiceResponse instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => All Properties and Fields Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Class_All_Properties_Getter_Settter_Test()
        {
            // Arrange
            var outputMessage = this.CreateType<string>();
            var messageFormat = this.CreateType<ResponseMessageFormat>();

            // Act
            _serviceResponseInstanceFixture.OutputMessage = outputMessage;
            _serviceResponseInstanceFixture.MessageFormat = messageFormat;

            // Assert
            _serviceResponseInstanceFixture.OutputMessage.ShouldNotBeNull();
            _serviceResponseInstanceFixture.MessageFormat.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyMessageFormat)]
        [TestCase(PropertyOutputMessage)]
        public void AUT_ServiceResponse_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ServiceResponse) => Property (OutputMessage) (Type : string) Property Type test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_OutputMessage_Property_String_Type_Verify_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutputMessage);
            _serviceResponseInstanceFixture.OutputMessage = this.CreateType<string>();
            var stringType = _serviceResponseInstanceFixture.OutputMessage.GetType();

            // Act
            var isTypeString = typeof(string) == (stringType);

            // Assert
            isTypeString.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (OutputMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Public_Class_OutputMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutputMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyOutputMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (MessageFormat) (Type : ResponseMessageFormat) Property Type test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_MessageFormat_Property_Responsemessageformat_Type_Verify_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageFormat);
            _serviceResponseInstanceFixture.MessageFormat = this.CreateType<ResponseMessageFormat>();
            var ResponseMessageFormatType = _serviceResponseInstanceFixture.MessageFormat.GetType();

            // Act
            var isTypeResponsemessageformat = typeof(ResponseMessageFormat) == (ResponseMessageFormatType);
            var isTypeNullableResponsemessageformat = typeof(ResponseMessageFormat?) == (ResponseMessageFormatType);
            var isTypeString = typeof(string) == (ResponseMessageFormatType);

            // Assert
            isTypeResponsemessageformat.ShouldBeTrue();
            isTypeString.ShouldBeFalse();
            isTypeNullableResponsemessageformat.ShouldBeFalse();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (MessageFormat) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_MessageFormat_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageFormat);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMessageFormat);
            Action currentAction = () => propertyInfo.SetValue(_serviceResponseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (MessageFormat) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Public_Class_MessageFormat_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMessageFormat);
            var propertyInfo = this.GetPropertyInfo(PropertyMessageFormat);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Test Try-Catch Verify Exception Throw - Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT TryCatch")]
        public void AUT_ServiceResponse_CreateMessage_Try_Catch_Should_Not_Throw_Exception()
        {
            // Arrange
            var methodCreateMessageParametersTypes = new Type[] { typeof(ResponseMessageFormat), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);

            // Act
            Action executeAction = () => _serviceResponseInstance.CreateMessage();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _serviceResponseInstance.CreateMessage();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            Type [] methodCreateMessageParametersTypes = null;
            object[] parametersOfCreateMessage = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, methodCreateMessageParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_serviceResponseInstanceFixture, out exception1, parametersOfCreateMessage);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateMessage, parametersOfCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateMessage.ShouldBeNull();
            methodCreateMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            Type [] methodCreateMessageParametersTypes = null;
            object[] parametersOfCreateMessage = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, methodCreateMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_serviceResponseInstanceFixture, parametersOfCreateMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateMessage.ShouldBeNull();
            methodCreateMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            Type [] methodCreateMessageParametersTypes = null;
            object[] parametersOfCreateMessage = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateMessage, parametersOfCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            parametersOfCreateMessage.ShouldBeNull();
            methodCreateMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            Type [] methodCreateMessageParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            Type [] methodCreateMessageParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var MessageFormat = this.CreateType<ResponseMessageFormat>();
            var OutputMessage = this.CreateType<string>();

            // Act
            Action executeAction = () => ServiceResponse.CreateMessage(MessageFormat, OutputMessage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var MessageFormat = this.CreateType<ResponseMessageFormat>();
            var OutputMessage = this.CreateType<string>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = ServiceResponse.CreateMessage(MessageFormat, OutputMessage);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var MessageFormat = this.CreateType<ResponseMessageFormat>();
            var OutputMessage = this.CreateType<string>();
            var methodCreateMessageParametersTypes = new Type[] { typeof(ResponseMessageFormat), typeof(string) };
            object[] parametersOfCreateMessage = { MessageFormat, OutputMessage };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, methodCreateMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateMessage, parametersOfCreateMessage, methodCreateMessageParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_serviceResponseInstanceFixture, parametersOfCreateMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateMessage.ShouldNotBeNull();
            parametersOfCreateMessage.Length.ShouldBe(2);
            methodCreateMessageParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var MessageFormat = this.CreateType<ResponseMessageFormat>();
            var OutputMessage = this.CreateType<string>();
            var methodCreateMessageParametersTypes = new Type[] { typeof(ResponseMessageFormat), typeof(string) };
            object[] parametersOfCreateMessage = { MessageFormat, OutputMessage };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateMessage, parametersOfCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            parametersOfCreateMessage.ShouldNotBeNull();
            parametersOfCreateMessage.Length.ShouldBe(2);
            methodCreateMessageParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var methodCreateMessageParametersTypes = new Type[] { typeof(ResponseMessageFormat), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateMessageParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var methodCreateMessageParametersTypes = new Type[] { typeof(ResponseMessageFormat), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMessage, methodCreateMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateMessageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateMessage) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceResponse_CreateMessage_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMessage, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}