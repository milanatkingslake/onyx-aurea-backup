using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.ServiceGateway" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceGatewayTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceGateway" />)
        /// </summary>
        public ServiceGatewayTest() : base(typeof(ServiceGateway))
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

        #region General Initializer : Class (ServiceGateway) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceGatewayInstanceType;
        private ServiceGateway _serviceGatewayInstance;
        private ServiceGateway _serviceGatewayInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceGateway" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceGatewayInstanceType = typeof(ServiceGateway);
            _serviceGatewayInstanceFixture = this.Create<ServiceGateway>(false);
            _serviceGatewayInstance = _serviceGatewayInstanceFixture ?? this.Create<ServiceGateway>(true);
            CurrentInstance = _serviceGatewayInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceGateway) Initializer

        #region Properties

        private const string PropertyWhoIs = "WhoIs";

        #endregion

        #region Methods

        private const string MethodGetBaseAddress = "GetBaseAddress";
        private const string MethodStart = "Start";
        private const string MethodStop = "Stop";

        #endregion

        #region Fields

        private const string FieldserviceHost = "serviceHost";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceGateway) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceGateway_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceGateway) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceGateway_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceGateway) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceGateway_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceGateway)

        #region General Initializer : Class (ServiceGateway) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetBaseAddress, 0)]
        [TestCase(MethodStart, 0)]
        [TestCase(MethodStop, 0)]
        public void AUT_ServiceGateway_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ServiceGateway) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyWhoIs)]
        [Category("AUT Property")]
        public void AUT_ServiceGateway_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ServiceGateway) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldserviceHost)]
        [Category("AUT Fields")]
        public void AUT_ServiceGateway_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServiceGateway) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceGateway_Is_Instance_Present_Test()
        {
            // Assert
            _serviceGatewayInstanceType.ShouldNotBeNull();
            _serviceGatewayInstance.ShouldNotBeNull();
            _serviceGatewayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceGateway) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceGateway" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceGateway_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceGatewayInstance.ShouldBeAssignableTo<ServiceGateway>();
            _serviceGatewayInstanceFixture.ShouldBeAssignableTo<ServiceGateway>();
            CurrentInstance.ShouldBeAssignableTo<ServiceGateway>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ServiceGateway) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceGateway_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ServiceGateway instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ServiceGateway) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceGateway_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var serviceGatewayInstance  = new ServiceGateway();

            // Asserts
            serviceGatewayInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ServiceGateway) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyWhoIs)]
        public void AUT_ServiceGateway_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ServiceGateway) => Property (WhoIs) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceGateway_Public_Class_WhoIs_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWhoIs);
            var propertyInfo = this.GetPropertyInfo(PropertyWhoIs);

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

        #region Method Call : (GetBaseAddress) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);

            // Act
            System.Action executeAction = () => _serviceGatewayInstance.GetBaseAddress();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _serviceGatewayInstance.GetBaseAddress();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            Type [] methodGetBaseAddressParametersTypes = null;
            object[] parametersOfGetBaseAddress = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBaseAddress, methodGetBaseAddressParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceGatewayInstanceFixture, out exception1, parametersOfGetBaseAddress);
            var result2 = this.GetResultOfMethod<string>(MethodGetBaseAddress, parametersOfGetBaseAddress, methodGetBaseAddressParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetBaseAddress.ShouldBeNull();
            methodGetBaseAddressParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            Type [] methodGetBaseAddressParametersTypes = null;
            object[] parametersOfGetBaseAddress = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBaseAddress, methodGetBaseAddressParametersTypes, out exception);

            // Act
            System.Action currentAction = () => currentMethodInfo.Invoke(_serviceGatewayInstanceFixture, parametersOfGetBaseAddress);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetBaseAddress.ShouldBeNull();
            methodGetBaseAddressParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            Type [] methodGetBaseAddressParametersTypes = null;
            object[] parametersOfGetBaseAddress = null; // no parameter present

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBaseAddress, parametersOfGetBaseAddress, methodGetBaseAddressParametersTypes);

            // Assert
            parametersOfGetBaseAddress.ShouldBeNull();
            methodGetBaseAddressParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            Type [] methodGetBaseAddressParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBaseAddress, methodGetBaseAddressParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetBaseAddressParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            Type [] methodGetBaseAddressParametersTypes = null;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBaseAddress, methodGetBaseAddressParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBaseAddressParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBaseAddress) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_GetBaseAddress_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBaseAddress);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBaseAddress, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceGateway_Start_Method_Call_Internally(Type[] types)
        {
            var methodStartParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStart, methodStartParametersTypes);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Start_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);

            // Act
            System.Action executeAction = () => _serviceGatewayInstance.Start();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Start_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;
            object[] parametersOfStart = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStart, methodStartParametersTypes, out exception);

            // Act
            System.Action currentAction = () => currentMethodInfo.Invoke(_serviceGatewayInstanceFixture, parametersOfStart);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfStart.ShouldBeNull();
            methodStartParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Start_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;
            object[] parametersOfStart = null; // no parameter present

            // Act
            System.Action currentAction = () => this.InvokeWithTypes(MethodStart, parametersOfStart, methodStartParametersTypes);

            // Assert
            parametersOfStart.ShouldBeNull();
            methodStartParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Start_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStart, methodStartParametersTypes);

            // Assert
            methodStartParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Start_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            var currentMethodInfo = this.GetMethodInfo(MethodStart, 0);

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceGateway_Stop_Method_Call_Internally(Type[] types)
        {
            var methodStopParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStop, methodStopParametersTypes);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Stop_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);

            // Act
            System.Action executeAction = () => _serviceGatewayInstance.Stop();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Stop_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;
            object[] parametersOfStop = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStop, methodStopParametersTypes, out exception);

            // Act
            System.Action currentAction = () => currentMethodInfo.Invoke(_serviceGatewayInstanceFixture, parametersOfStop);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfStop.ShouldBeNull();
            methodStopParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Stop_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;
            object[] parametersOfStop = null; // no parameter present

            // Act
            System.Action currentAction = () => this.InvokeWithTypes(MethodStop, parametersOfStop, methodStopParametersTypes);

            // Assert
            parametersOfStop.ShouldBeNull();
            methodStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Stop_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStop, methodStopParametersTypes);

            // Assert
            methodStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceGateway_Stop_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            var currentMethodInfo = this.GetMethodInfo(MethodStop, 0);

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}