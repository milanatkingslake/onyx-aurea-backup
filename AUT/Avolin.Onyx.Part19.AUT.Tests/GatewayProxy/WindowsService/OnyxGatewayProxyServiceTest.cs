using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy.WindowsService;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy.WindowsService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyService" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxGatewayProxyServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayProxyService" />)
        /// </summary>
        public OnyxGatewayProxyServiceTest() : base(typeof(OnyxGatewayProxyService))
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

        #region General Initializer : Class (OnyxGatewayProxyService) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayProxyServiceInstanceType;
        private OnyxGatewayProxyService _onyxGatewayProxyServiceInstance;
        private OnyxGatewayProxyService _onyxGatewayProxyServiceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayProxyService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayProxyServiceInstanceType = typeof(OnyxGatewayProxyService);
            _onyxGatewayProxyServiceInstanceFixture = this.Create<OnyxGatewayProxyService>(false);
            _onyxGatewayProxyServiceInstance = _onyxGatewayProxyServiceInstanceFixture ?? this.Create<OnyxGatewayProxyService>(true);
            CurrentInstance = _onyxGatewayProxyServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyService) Initializer

        #region Methods

        private const string MethodOnStart = "OnStart";
        private const string MethodOnStop = "OnStop";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";
        private const string FieldrestGateway = "restGateway";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyService_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayProxyService)

        #region General Initializer : Class (OnyxGatewayProxyService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOnStart, 0)]
        [TestCase(MethodOnStop, 0)]
        public void AUT_OnyxGatewayProxyService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxGatewayProxyService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [TestCase(FieldrestGateway)]
        [Category("AUT Fields")]
        public void AUT_OnyxGatewayProxyService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxGatewayProxyService) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayProxyService_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayProxyServiceInstanceType.ShouldNotBeNull();
            _onyxGatewayProxyServiceInstance.ShouldNotBeNull();
            _onyxGatewayProxyServiceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayProxyService) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyService" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayProxyService_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayProxyServiceInstance.ShouldBeAssignableTo<OnyxGatewayProxyService>();
            _onyxGatewayProxyServiceInstanceFixture.ShouldBeAssignableTo<OnyxGatewayProxyService>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayProxyService>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxGatewayProxyService) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxGatewayProxyService_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxGatewayProxyService instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (OnStart) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStart_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStart);
            var args = this.CreateType<string[]>();
            var methodOnStartParametersTypes = new Type[] { typeof(string[]) };
            object[] parametersOfOnStart = { args };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnStart, parametersOfOnStart, methodOnStartParametersTypes);

            // Assert
            parametersOfOnStart.ShouldNotBeNull();
            parametersOfOnStart.Length.ShouldBe(1);
            methodOnStartParametersTypes.Length.ShouldBe(1);
            methodOnStartParametersTypes.Length.ShouldBe(parametersOfOnStart.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStart) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStart_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStart);
            var currentMethodInfo = this.GetMethodInfo(MethodOnStart, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnStart) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStart_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStart);
            var methodOnStartParametersTypes = new Type[] { typeof(string[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnStart, methodOnStartParametersTypes);

            // Assert
            methodOnStartParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStart) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStart_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStart);
            var currentMethodInfo = this.GetMethodInfo(MethodOnStart, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStop) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxGatewayProxyService_OnStop_Method_Call_Internally(Type[] types)
        {
            var methodOnStopParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodOnStop, methodOnStopParametersTypes);
        }

        #endregion

        #region Method Call : (OnStop) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStop_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStop);
            Type [] methodOnStopParametersTypes = null;
            object[] parametersOfOnStop = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnStop, methodOnStopParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayProxyServiceInstanceFixture, parametersOfOnStop);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnStop.ShouldBeNull();
            methodOnStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStop) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStop_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStop);
            Type [] methodOnStopParametersTypes = null;
            object[] parametersOfOnStop = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnStop, parametersOfOnStop, methodOnStopParametersTypes);

            // Assert
            parametersOfOnStop.ShouldBeNull();
            methodOnStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStop) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStop_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStop);
            Type [] methodOnStopParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnStop, methodOnStopParametersTypes);

            // Assert
            methodOnStopParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnStop) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayProxyService_OnStop_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnStop);
            var currentMethodInfo = this.GetMethodInfo(MethodOnStop, 0);

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