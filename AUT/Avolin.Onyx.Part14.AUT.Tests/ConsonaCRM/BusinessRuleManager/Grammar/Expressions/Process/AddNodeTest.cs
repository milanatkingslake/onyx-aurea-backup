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

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.AddNode" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AddNodeTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AddNode" />)
        /// </summary>
        public AddNodeTest() : base(typeof(AddNode))
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

        #region General Initializer : Class (AddNode) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _addNodeInstanceType;
        private AddNode _addNodeInstance;
        private AddNode _addNodeInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AddNode" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _addNodeInstanceType = typeof(AddNode);
            _addNodeInstanceFixture = this.Create<AddNode>(false);
            _addNodeInstance = _addNodeInstanceFixture ?? this.Create<AddNode>(true);
            CurrentInstance = _addNodeInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AddNode) Initializer

        #region Methods

        private const string MethodProcess = "Process";
        private const string MethodCreateNewNode = "CreateNewNode";
        private const string MethodGetName = "GetName";

        #endregion

        #endregion

        #region General Initializer : Class (AddNode) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AddNode" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AddNode_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AddNode)

        #region General Initializer : Class (AddNode) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AddNode" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcess, 0)]
        [TestCase(MethodCreateNewNode, 0)]
        [TestCase(MethodGetName, 0)]
        public void AUT_AddNode_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (AddNode) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AddNode" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AddNode_Is_Instance_Present_Test()
        {
            // Assert
            _addNodeInstanceType.ShouldNotBeNull();
            _addNodeInstance.ShouldNotBeNull();
            _addNodeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AddNode) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AddNode" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AddNode_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _addNodeInstance.ShouldBeAssignableTo<AddNode>();
            _addNodeInstanceFixture.ShouldBeAssignableTo<AddNode>();
            CurrentInstance.ShouldBeAssignableTo<AddNode>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AddNode) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AddNode_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AddNode instance = null;

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
        public void AUT_AddNode_Process_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pSourceNode = this.CreateType<XmlNode>();
            var pTargetNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _addNodeInstance.Process(pSourceNode, pTargetNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_Process_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pSourceNode = this.CreateType<XmlNode>();
            var pTargetNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfProcess = { pSourceNode, pTargetNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_addNodeInstanceFixture, parametersOfProcess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(2);
            methodProcessParametersTypes.Length.ShouldBe(2);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_Process_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pSourceNode = this.CreateType<XmlNode>();
            var pTargetNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfProcess = { pSourceNode, pTargetNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcess, parametersOfProcess, methodProcessParametersTypes);

            // Assert
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(2);
            methodProcessParametersTypes.Length.ShouldBe(2);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_Process_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);
            const int parametersCount = 2;

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
        public void AUT_AddNode_Process_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);

            // Assert
            methodProcessParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_Process_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddNode_CreateNewNode_Method_Call_Internally(Type[] types)
        {
            var methodCreateNewNodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateNewNode, methodCreateNewNodeParametersTypes);
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var pSourceNode = this.CreateType<XmlNode>();
            var pTargetNode = this.CreateType<XmlNode>();
            var methodCreateNewNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfCreateNewNode = { pSourceNode, pTargetNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewNode, methodCreateNewNodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XmlNode>(_addNodeInstanceFixture, parametersOfCreateNewNode);
            var result2 = this.GetResultOfMethod<XmlNode>(MethodCreateNewNode, parametersOfCreateNewNode, methodCreateNewNodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateNewNode.ShouldNotBeNull();
            parametersOfCreateNewNode.Length.ShouldBe(2);
            methodCreateNewNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var pSourceNode = this.CreateType<XmlNode>();
            var pTargetNode = this.CreateType<XmlNode>();
            var methodCreateNewNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfCreateNewNode = { pSourceNode, pTargetNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XmlNode>(MethodCreateNewNode, parametersOfCreateNewNode, methodCreateNewNodeParametersTypes);

            // Assert
            parametersOfCreateNewNode.ShouldNotBeNull();
            parametersOfCreateNewNode.Length.ShouldBe(2);
            methodCreateNewNodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var methodCreateNewNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateNewNode, methodCreateNewNodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateNewNodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var methodCreateNewNodeParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateNewNode, methodCreateNewNodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateNewNodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewNode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateNewNode) (Return Type : XmlNode) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_CreateNewNode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateNewNode);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateNewNode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AddNode_GetName_Method_Call_Internally(Type[] types)
        {
            var methodGetNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var pDataNode = this.CreateType<XmlNode>();
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetName = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, methodGetNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_addNodeInstanceFixture, parametersOfGetName);
            var result2 = this.GetResultOfMethod<string>(MethodGetName, parametersOfGetName, methodGetNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetName.ShouldNotBeNull();
            parametersOfGetName.Length.ShouldBe(1);
            methodGetNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var pDataNode = this.CreateType<XmlNode>();
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetName = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetName, parametersOfGetName, methodGetNameParametersTypes);

            // Assert
            parametersOfGetName.ShouldNotBeNull();
            parametersOfGetName.Length.ShouldBe(1);
            methodGetNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AddNode_GetName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, 0);
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