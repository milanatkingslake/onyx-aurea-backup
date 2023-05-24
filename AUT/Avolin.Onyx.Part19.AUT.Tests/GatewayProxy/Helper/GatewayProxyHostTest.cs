using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy.Helper;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.Helper.GatewayProxyHost" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GatewayProxyHostTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GatewayProxyHost" />)
        /// </summary>
        public GatewayProxyHostTest() : base(typeof(GatewayProxyHost))
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

        #region General Initializer : Class (GatewayProxyHost) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _gatewayProxyHostInstanceType;
        private GatewayProxyHost _gatewayProxyHostInstance;
        private GatewayProxyHost _gatewayProxyHostInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="GatewayProxyHost" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _gatewayProxyHostInstanceType = typeof(GatewayProxyHost);
            _gatewayProxyHostInstanceFixture = this.Create<GatewayProxyHost>(false);
            _gatewayProxyHostInstance = _gatewayProxyHostInstanceFixture ?? this.Create<GatewayProxyHost>(true);
            CurrentInstance = _gatewayProxyHostInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GatewayProxyHost) Initializer

        #region Properties

        private const string PropertyServiceHost = "ServiceHost";

        #endregion

        #region Methods

        private const string MethodStart = "Start";
        private const string MethodStop = "Stop";

        #endregion

        #region Fields

        private const string FieldwebServiceHost = "webServiceHost";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (GatewayProxyHost) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GatewayProxyHost_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GatewayProxyHost) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GatewayProxyHost_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (GatewayProxyHost) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GatewayProxyHost_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (GatewayProxyHost)

        #region General Initializer : Class (GatewayProxyHost) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodStart, 0)]
        [TestCase(MethodStop, 0)]
        public void AUT_GatewayProxyHost_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (GatewayProxyHost) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyServiceHost)]
        [Category("AUT Property")]
        public void AUT_GatewayProxyHost_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (GatewayProxyHost) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldwebServiceHost)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_GatewayProxyHost_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (GatewayProxyHost) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="GatewayProxyHost" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GatewayProxyHost_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _gatewayProxyHostInstance.ShouldBeAssignableTo<GatewayProxyHost>();
            _gatewayProxyHostInstanceFixture.ShouldBeAssignableTo<GatewayProxyHost>();
            CurrentInstance.ShouldBeAssignableTo<GatewayProxyHost>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (GatewayProxyHost) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyServiceHost)]
        public void AUT_GatewayProxyHost_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (GatewayProxyHost) => Property (ServiceHost) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_GatewayProxyHost_Public_Class_ServiceHost_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyServiceHost);
            var propertyInfo = this.GetPropertyInfo(PropertyServiceHost);

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

        #region Method Call : (Start) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Start_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);

            // Act
            Action executeAction = () => _gatewayProxyHostInstance.Start();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Start_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;
            object[] parametersOfStart = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStart, methodStartParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_gatewayProxyHostInstanceFixture, parametersOfStart);

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
        public void AUT_GatewayProxyHost_Start_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;
            object[] parametersOfStart = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodStart, parametersOfStart, methodStartParametersTypes);

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
        public void AUT_GatewayProxyHost_Start_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            Type [] methodStartParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStart, methodStartParametersTypes);

            // Assert
            methodStartParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Start) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Start_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStart);
            var currentMethodInfo = this.GetMethodInfo(MethodStart, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_GatewayProxyHost_Stop_Method_Call_Internally(Type[] types)
        {
            var methodStopParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStop, methodStopParametersTypes);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Stop_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);

            // Act
            Action executeAction = () => _gatewayProxyHostInstance.Stop();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Stop_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;
            object[] parametersOfStop = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodStop, methodStopParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_gatewayProxyHostInstanceFixture, parametersOfStop);

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
        public void AUT_GatewayProxyHost_Stop_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;
            object[] parametersOfStop = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodStop, parametersOfStop, methodStopParametersTypes);

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
        public void AUT_GatewayProxyHost_Stop_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            Type [] methodStopParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStop, methodStopParametersTypes);

            // Assert
            methodStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Stop) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GatewayProxyHost_Stop_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStop);
            var currentMethodInfo = this.GetMethodInfo(MethodStop, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}