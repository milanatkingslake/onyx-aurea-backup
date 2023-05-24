using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.ProcessContainer" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ProcessContainerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProcessContainer" />)
        /// </summary>
        public ProcessContainerTest() : base(typeof(ProcessContainer))
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

        #region General Initializer : Class (ProcessContainer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _processContainerInstanceType;
        private ProcessContainer _processContainerInstance;
        private ProcessContainer _processContainerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProcessContainer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _processContainerInstanceType = typeof(ProcessContainer);
            _processContainerInstanceFixture = this.Create<ProcessContainer>(false);
            _processContainerInstance = _processContainerInstanceFixture ?? this.Create<ProcessContainer>(true);
            CurrentInstance = _processContainerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProcessContainer) Initializer

        #region Methods

        private const string MethodProcess = "Process";

        #endregion

        #endregion

        #region General Initializer : Class (ProcessContainer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProcessContainer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ProcessContainer)

        #region General Initializer : Class (ProcessContainer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcess, 0)]
        [TestCase(MethodProcess, 1)]
        public void AUT_ProcessContainer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ProcessContainer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProcessContainer_Is_Instance_Present_Test()
        {
            // Assert
            _processContainerInstanceType.ShouldNotBeNull();
            _processContainerInstance.ShouldNotBeNull();
            _processContainerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ProcessContainer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProcessContainer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _processContainerInstance.ShouldBeAssignableTo<ProcessContainer>();
            _processContainerInstanceFixture.ShouldBeAssignableTo<ProcessContainer>();
            CurrentInstance.ShouldBeAssignableTo<ProcessContainer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ProcessContainer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ProcessContainer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            ProcessContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ProcessContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _processContainerInstance.ShouldNotBeNull();
            _processContainerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ProcessContainer>();
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            ProcessContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ProcessContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _processContainerInstance.ShouldNotBeNull();
            _processContainerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) instance created

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Is_Created_Test()
        {
            // Assert
            _processContainerInstance.ShouldNotBeNull();
            _processContainerInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ProcessContainer" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ProcessContainer_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ProcessContainer) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ProcessContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ProcessContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodProcessContainerParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodProcessContainerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ProcessContainer) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ProcessContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProcessContainer_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodProcessContainerParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodProcessContainerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Process) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _processContainerInstance.Process(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_processContainerInstanceFixture, parametersOfProcess);

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
        public void AUT_ProcessContainer_Process_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_ProcessContainer_Process_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_ProcessContainer_Process_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_ProcessContainer_Process_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (Process) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProcessContainer_Process_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodProcessParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => ProcessContainer.Process(pMetadataNode, pEngine, pDataNode, pNamespaceManager);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfProcess = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_processContainerInstanceFixture, parametersOfProcess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(4);
            methodProcessParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfProcess = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcess, parametersOfProcess, methodProcessParametersTypes);

            // Assert
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(4);
            methodProcessParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 1);
            const int parametersCount = 4;

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
        public void AUT_ProcessContainer_Process_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);

            // Assert
            methodProcessParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProcessContainer_Process_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 1);

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