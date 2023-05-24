using Action = System.Action;
using Should = Shouldly.Should;

namespace Onyx.CrossOriginSupport
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Description;
    using System.ServiceModel.Dispatcher;
    using System.Text;
    using Action = System.Action;
    using AUT.TestProjects.Analyzer;
    using AUT.TestProjects.BaseSetup;
    using AUT.TestProjects.BaseSetup.Version;
    using AUT.TestProjects.BaseSetup.Version.V1;
    using AUT.TestProjects.BaseSetup.Version.V2;
    using AUT.TestProjects.Extensions;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
    using AUT.TestProjects.Interfaces;
    using AUT.TestProjects.Interfaces.BaseSetup.Version;
    using AUT.TestProjects.Interfaces.BaseSetup.Version.V2;
    using AUT.TestProjects.Model;
    using AUT.TestProjects.NUnitExtensionAttribute;
    using AUT.TestProjects.StaticTypes;
    using Moq;
    using NUnit.Framework;
    using Onyx.Gateway.Data;
    using Onyx.LoggerService;
    using Should = Shouldly.Should;
    using Shouldly;
    using Onyx.CrossOriginSupport;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxEndPointBehavior" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxEndPointBehaviorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxEndPointBehavior" />)
        /// </summary>
        public OnyxEndPointBehaviorTest() : base(typeof(OnyxEndPointBehavior))
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

        #region General Initializer : Class (OnyxEndPointBehavior) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxEndPointBehaviorInstanceType;
        private OnyxEndPointBehavior _onyxEndPointBehaviorInstance;
        private OnyxEndPointBehavior _onyxEndPointBehaviorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxEndPointBehavior" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxEndPointBehaviorInstanceType = typeof(OnyxEndPointBehavior);
            _onyxEndPointBehaviorInstanceFixture = this.Create<OnyxEndPointBehavior>(false);
            _onyxEndPointBehaviorInstance = _onyxEndPointBehaviorInstanceFixture ?? this.Create<OnyxEndPointBehavior>(true);
            CurrentInstance = _onyxEndPointBehaviorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxEndPointBehavior) Initializer

        #region Methods

        private const string MethodAddBindingParameters = "AddBindingParameters";
        private const string MethodApplyClientBehavior = "ApplyClientBehavior";
        private const string MethodApplyDispatchBehavior = "ApplyDispatchBehavior";
        private const string MethodValidate = "Validate";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxEndPointBehavior) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEndPointBehavior_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEndPointBehavior) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEndPointBehavior_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxEndPointBehavior) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxEndPointBehavior_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxEndPointBehavior)

        #region General Initializer : Class (OnyxEndPointBehavior) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAddBindingParameters, 0)]
        [TestCase(MethodApplyClientBehavior, 0)]
        [TestCase(MethodApplyDispatchBehavior, 0)]
        [TestCase(MethodValidate, 0)]
        public void AUT_OnyxEndPointBehavior_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxEndPointBehavior) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxEndPointBehavior_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxEndPointBehavior) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEndPointBehavior_Is_Instance_Present_Test()
        {
            // Assert
            _onyxEndPointBehaviorInstanceType.ShouldNotBeNull();
            _onyxEndPointBehaviorInstance.ShouldNotBeNull();
            _onyxEndPointBehaviorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxEndPointBehavior) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxEndPointBehavior" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxEndPointBehavior_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxEndPointBehaviorInstance.ShouldBeAssignableTo<OnyxEndPointBehavior>();
            _onyxEndPointBehaviorInstanceFixture.ShouldBeAssignableTo<OnyxEndPointBehavior>();
            CurrentInstance.ShouldBeAssignableTo<OnyxEndPointBehavior>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxEndPointBehavior) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxEndPointBehavior_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxEndPointBehavior instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AddBindingParameters) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var bindingParameters = this.CreateType<BindingParameterCollection>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.AddBindingParameters(endpoint, bindingParameters);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddBindingParameters) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var bindingParameters = this.CreateType<BindingParameterCollection>();
            var methodAddBindingParametersParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(BindingParameterCollection) };
            object[] parametersOfAddBindingParameters = { endpoint, bindingParameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddBindingParameters, methodAddBindingParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfAddBindingParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddBindingParameters.ShouldNotBeNull();
            parametersOfAddBindingParameters.Length.ShouldBe(2);
            methodAddBindingParametersParametersTypes.Length.ShouldBe(2);
            methodAddBindingParametersParametersTypes.Length.ShouldBe(parametersOfAddBindingParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddBindingParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var bindingParameters = this.CreateType<BindingParameterCollection>();
            var methodAddBindingParametersParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(BindingParameterCollection) };
            object[] parametersOfAddBindingParameters = { endpoint, bindingParameters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddBindingParameters, parametersOfAddBindingParameters, methodAddBindingParametersParametersTypes);

            // Assert
            parametersOfAddBindingParameters.ShouldNotBeNull();
            parametersOfAddBindingParameters.Length.ShouldBe(2);
            methodAddBindingParametersParametersTypes.Length.ShouldBe(2);
            methodAddBindingParametersParametersTypes.Length.ShouldBe(parametersOfAddBindingParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddBindingParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodAddBindingParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddBindingParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var methodAddBindingParametersParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(BindingParameterCollection) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddBindingParameters, methodAddBindingParametersParametersTypes);

            // Assert
            methodAddBindingParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddBindingParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_AddBindingParameters_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddBindingParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodAddBindingParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Internally(Type[] types)
        {
            var methodApplyClientBehaviorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyClientBehavior, methodApplyClientBehaviorParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var clientRuntime = this.CreateType<ClientRuntime>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.ApplyClientBehavior(endpoint, clientRuntime);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var clientRuntime = this.CreateType<ClientRuntime>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.ApplyClientBehavior(endpoint, clientRuntime);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var clientRuntime = this.CreateType<ClientRuntime>();
            var methodApplyClientBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(ClientRuntime) };
            object[] parametersOfApplyClientBehavior = { endpoint, clientRuntime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyClientBehavior, methodApplyClientBehaviorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfApplyClientBehavior);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyClientBehavior.ShouldNotBeNull();
            parametersOfApplyClientBehavior.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyClientBehavior.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var clientRuntime = this.CreateType<ClientRuntime>();
            var methodApplyClientBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(ClientRuntime) };
            object[] parametersOfApplyClientBehavior = { endpoint, clientRuntime };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyClientBehavior, methodApplyClientBehaviorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfApplyClientBehavior);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyClientBehavior.ShouldNotBeNull();
            parametersOfApplyClientBehavior.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyClientBehavior.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var clientRuntime = this.CreateType<ClientRuntime>();
            var methodApplyClientBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(ClientRuntime) };
            object[] parametersOfApplyClientBehavior = { endpoint, clientRuntime };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyClientBehavior, parametersOfApplyClientBehavior, methodApplyClientBehaviorParametersTypes);

            // Assert
            parametersOfApplyClientBehavior.ShouldNotBeNull();
            parametersOfApplyClientBehavior.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyClientBehavior.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyClientBehavior, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var methodApplyClientBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(ClientRuntime) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyClientBehavior, methodApplyClientBehaviorParametersTypes);

            // Assert
            methodApplyClientBehaviorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyClientBehavior) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyClientBehavior_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyClientBehavior);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyClientBehavior, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Internally(Type[] types)
        {
            var methodApplyDispatchBehaviorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyDispatchBehavior, methodApplyDispatchBehaviorParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var endpointDispatcher = this.CreateType<EndpointDispatcher>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.ApplyDispatchBehavior(endpoint, endpointDispatcher);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var endpointDispatcher = this.CreateType<EndpointDispatcher>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.ApplyDispatchBehavior(endpoint, endpointDispatcher);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var endpointDispatcher = this.CreateType<EndpointDispatcher>();
            var methodApplyDispatchBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(EndpointDispatcher) };
            object[] parametersOfApplyDispatchBehavior = { endpoint, endpointDispatcher };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDispatchBehavior, methodApplyDispatchBehaviorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfApplyDispatchBehavior);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyDispatchBehavior.ShouldNotBeNull();
            parametersOfApplyDispatchBehavior.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyDispatchBehavior.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var endpointDispatcher = this.CreateType<EndpointDispatcher>();
            var methodApplyDispatchBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(EndpointDispatcher) };
            object[] parametersOfApplyDispatchBehavior = { endpoint, endpointDispatcher };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDispatchBehavior, methodApplyDispatchBehaviorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfApplyDispatchBehavior);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyDispatchBehavior.ShouldNotBeNull();
            parametersOfApplyDispatchBehavior.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyDispatchBehavior.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var endpointDispatcher = this.CreateType<EndpointDispatcher>();
            var methodApplyDispatchBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(EndpointDispatcher) };
            object[] parametersOfApplyDispatchBehavior = { endpoint, endpointDispatcher };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyDispatchBehavior, parametersOfApplyDispatchBehavior, methodApplyDispatchBehaviorParametersTypes);

            // Assert
            parametersOfApplyDispatchBehavior.ShouldNotBeNull();
            parametersOfApplyDispatchBehavior.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(2);
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(parametersOfApplyDispatchBehavior.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDispatchBehavior, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var methodApplyDispatchBehaviorParametersTypes = new Type[] { typeof(ServiceEndpoint), typeof(EndpointDispatcher) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyDispatchBehavior, methodApplyDispatchBehaviorParametersTypes);

            // Assert
            methodApplyDispatchBehaviorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDispatchBehavior) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_ApplyDispatchBehavior_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDispatchBehavior);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDispatchBehavior, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxEndPointBehavior_Validate_Method_Call_Internally(Type[] types)
        {
            var methodValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var endpoint = this.CreateType<ServiceEndpoint>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.Validate(endpoint);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var endpoint = this.CreateType<ServiceEndpoint>();

            // Act
            Action executeAction = () => _onyxEndPointBehaviorInstance.Validate(endpoint);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var methodValidateParametersTypes = new Type[] { typeof(ServiceEndpoint) };
            object[] parametersOfValidate = { endpoint };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfValidate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(parametersOfValidate.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var methodValidateParametersTypes = new Type[] { typeof(ServiceEndpoint) };
            object[] parametersOfValidate = { endpoint };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxEndPointBehaviorInstanceFixture, parametersOfValidate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(parametersOfValidate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var endpoint = this.CreateType<ServiceEndpoint>();
            var methodValidateParametersTypes = new Type[] { typeof(ServiceEndpoint) };
            object[] parametersOfValidate = { endpoint };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(parametersOfValidate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(ServiceEndpoint) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            methodValidateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxEndPointBehavior_Validate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);

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