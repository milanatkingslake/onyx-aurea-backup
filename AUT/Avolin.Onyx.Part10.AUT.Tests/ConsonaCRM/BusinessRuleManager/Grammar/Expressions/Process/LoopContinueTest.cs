using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.LoopContinue" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LoopContinueTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LoopContinue" />)
        /// </summary>
        public LoopContinueTest() : base(typeof(LoopContinue))
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

        #region General Initializer : Class (LoopContinue) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _loopContinueInstanceType;
        private LoopContinue _loopContinueInstance;
        private LoopContinue _loopContinueInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LoopContinue" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _loopContinueInstanceType = typeof(LoopContinue);
            _loopContinueInstanceFixture = this.Create<LoopContinue>(false);
            _loopContinueInstance = _loopContinueInstanceFixture ?? this.Create<LoopContinue>(true);
            CurrentInstance = _loopContinueInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LoopContinue) Initializer

        #region Methods

        private const string MethodProcess = "Process";

        #endregion

        #endregion

        #region General Initializer : Class (LoopContinue) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LoopContinue" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LoopContinue_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LoopContinue)

        #region General Initializer : Class (LoopContinue) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LoopContinue" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcess, 0)]
        public void AUT_LoopContinue_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (LoopContinue) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LoopContinue" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LoopContinue_Is_Instance_Present_Test()
        {
            // Assert
            _loopContinueInstanceType.ShouldNotBeNull();
            _loopContinueInstance.ShouldNotBeNull();
            _loopContinueInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LoopContinue) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LoopContinue" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LoopContinue_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _loopContinueInstance.ShouldBeAssignableTo<LoopContinue>();
            _loopContinueInstanceFixture.ShouldBeAssignableTo<LoopContinue>();
            CurrentInstance.ShouldBeAssignableTo<LoopContinue>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (LoopContinue) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_LoopContinue_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            LoopContinue instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Process) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _loopContinueInstance.Process(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loopContinueInstanceFixture, parametersOfProcess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcess, parametersOfProcess, methodProcessParametersTypes);

            // Assert
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);

            // Assert
            methodProcessParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_LoopContinue_Process_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);

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