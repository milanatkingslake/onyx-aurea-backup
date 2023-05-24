using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.DispatchAgentManager" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DispatchAgentManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DispatchAgentManager" />)
        /// </summary>
        public DispatchAgentManagerTest() : base(typeof(DispatchAgentManager))
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

        #region General Initializer : Class (DispatchAgentManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dispatchAgentManagerInstanceType;
        private DispatchAgentManager _dispatchAgentManagerInstance;
        private DispatchAgentManager _dispatchAgentManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DispatchAgentManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dispatchAgentManagerInstanceType = typeof(DispatchAgentManager);
            _dispatchAgentManagerInstanceFixture = this.Create<DispatchAgentManager>(false);
            _dispatchAgentManagerInstance = _dispatchAgentManagerInstanceFixture ?? this.Create<DispatchAgentManager>(true);
            CurrentInstance = _dispatchAgentManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DispatchAgentManager) Initializer

        #region Methods

        private const string MethodStartCalendarDispatchAgent = "StartCalendarDispatchAgent";
        private const string MethodStopCalendarDispatchAgent = "StopCalendarDispatchAgent";

        #endregion

        #endregion

        #region General Initializer : Class (DispatchAgentManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DispatchAgentManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DispatchAgentManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #endregion

        #region Category : Instance

        #region General Instance : Class (DispatchAgentManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DispatchAgentManager" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DispatchAgentManager_Is_Instance_Present_Test()
        {
            // Assert
            _dispatchAgentManagerInstanceType.ShouldNotBeNull();
            _dispatchAgentManagerInstance.ShouldNotBeNull();
            _dispatchAgentManagerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DispatchAgentManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DispatchAgentManager" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DispatchAgentManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dispatchAgentManagerInstance.ShouldBeAssignableTo<DispatchAgentManager>();
            _dispatchAgentManagerInstanceFixture.ShouldBeAssignableTo<DispatchAgentManager>();
            CurrentInstance.ShouldBeAssignableTo<DispatchAgentManager>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DispatchAgentManager) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DispatchAgentManager_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DispatchAgentManager instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (StartCalendarDispatchAgent) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StartCalendarDispatchAgent_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCalendarDispatchAgent);
            var Duration = this.CreateType<int>();

            // Act
            Action executeAction = () => DispatchAgentManager.StartCalendarDispatchAgent(Duration);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (StartCalendarDispatchAgent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StartCalendarDispatchAgent_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCalendarDispatchAgent);
            var Duration = this.CreateType<int>();
            var methodStartCalendarDispatchAgentParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfStartCalendarDispatchAgent = { Duration };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodStartCalendarDispatchAgent, parametersOfStartCalendarDispatchAgent, methodStartCalendarDispatchAgentParametersTypes);

            // Assert
            parametersOfStartCalendarDispatchAgent.ShouldNotBeNull();
            parametersOfStartCalendarDispatchAgent.Length.ShouldBe(1);
            methodStartCalendarDispatchAgentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StartCalendarDispatchAgent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StartCalendarDispatchAgent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCalendarDispatchAgent);
            var methodStartCalendarDispatchAgentParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStartCalendarDispatchAgent, methodStartCalendarDispatchAgentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStartCalendarDispatchAgentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (StartCalendarDispatchAgent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StartCalendarDispatchAgent_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStartCalendarDispatchAgent);
            var currentMethodInfo = this.GetMethodInfo(MethodStartCalendarDispatchAgent, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StopCalendarDispatchAgent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_DispatchAgentManager_StopCalendarDispatchAgent_Static_Method_Call_Internally(Type[] types)
        {
            var methodStopCalendarDispatchAgentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStopCalendarDispatchAgent, methodStopCalendarDispatchAgentParametersTypes);
        }

        #endregion

        #region Method Call : (StopCalendarDispatchAgent) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StopCalendarDispatchAgent_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCalendarDispatchAgent);

            // Act
            Action executeAction = () => DispatchAgentManager.StopCalendarDispatchAgent();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (StopCalendarDispatchAgent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StopCalendarDispatchAgent_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCalendarDispatchAgent);
            Type [] methodStopCalendarDispatchAgentParametersTypes = null;
            object[] parametersOfStopCalendarDispatchAgent = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodStopCalendarDispatchAgent, parametersOfStopCalendarDispatchAgent, methodStopCalendarDispatchAgentParametersTypes);

            // Assert
            parametersOfStopCalendarDispatchAgent.ShouldBeNull();
            methodStopCalendarDispatchAgentParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StopCalendarDispatchAgent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StopCalendarDispatchAgent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCalendarDispatchAgent);
            Type [] methodStopCalendarDispatchAgentParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStopCalendarDispatchAgent, methodStopCalendarDispatchAgentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStopCalendarDispatchAgentParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StopCalendarDispatchAgent) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_DispatchAgentManager_StopCalendarDispatchAgent_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStopCalendarDispatchAgent);
            var currentMethodInfo = this.GetMethodInfo(MethodStopCalendarDispatchAgent, 0);

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