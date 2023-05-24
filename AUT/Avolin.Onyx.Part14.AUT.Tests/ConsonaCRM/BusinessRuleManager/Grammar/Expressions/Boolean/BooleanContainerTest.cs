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
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean.BooleanContainer" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Boolean"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BooleanContainerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BooleanContainer" />)
        /// </summary>
        public BooleanContainerTest() : base(typeof(BooleanContainer))
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

        #region General Initializer : Class (BooleanContainer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _booleanContainerInstanceType;
        private BooleanContainer _booleanContainerInstance;
        private BooleanContainer _booleanContainerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BooleanContainer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _booleanContainerInstanceType = typeof(BooleanContainer);
            _booleanContainerInstanceFixture = this.Create<BooleanContainer>(false);
            _booleanContainerInstance = _booleanContainerInstanceFixture ?? this.Create<BooleanContainer>(true);
            CurrentInstance = _booleanContainerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (BooleanContainer) Initializer

        #region Methods

        private const string MethodEvaluateBoolean = "EvaluateBoolean";

        #endregion

        #endregion

        #region General Initializer : Class (BooleanContainer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BooleanContainer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (BooleanContainer)

        #region General Initializer : Class (BooleanContainer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateBoolean, 0)]
        [TestCase(MethodEvaluateBoolean, 1)]
        public void AUT_BooleanContainer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (BooleanContainer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BooleanContainer_Is_Instance_Present_Test()
        {
            // Assert
            _booleanContainerInstanceType.ShouldNotBeNull();
            _booleanContainerInstance.ShouldNotBeNull();
            _booleanContainerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BooleanContainer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BooleanContainer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _booleanContainerInstance.ShouldBeAssignableTo<BooleanContainer>();
            _booleanContainerInstanceFixture.ShouldBeAssignableTo<BooleanContainer>();
            CurrentInstance.ShouldBeAssignableTo<BooleanContainer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BooleanContainer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            BooleanContainer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            BooleanContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BooleanContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _booleanContainerInstance.ShouldNotBeNull();
            _booleanContainerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<BooleanContainer>();
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            BooleanContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BooleanContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _booleanContainerInstance.ShouldNotBeNull();
            _booleanContainerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) instance created

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Is_Created_Test()
        {
            // Assert
            _booleanContainerInstance.ShouldNotBeNull();
            _booleanContainerInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="BooleanContainer" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_BooleanContainer_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (BooleanContainer) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="BooleanContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="BooleanContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodBooleanContainerParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodBooleanContainerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (BooleanContainer) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="BooleanContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BooleanContainer_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodBooleanContainerParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodBooleanContainerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _booleanContainerInstance.EvaluateBoolean(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_booleanContainerInstanceFixture, parametersOfEvaluateBoolean);
            var result2 = this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(1);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_booleanContainerInstanceFixture, out exception1, parametersOfEvaluateBoolean);
            var result2 = this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(1);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_booleanContainerInstanceFixture, parametersOfEvaluateBoolean);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(1);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(1);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEvaluateBooleanParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => BooleanContainer.EvaluateBoolean(pMetadataNode, pEngine, pDataNode, pNamespaceManager);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateBoolean = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(4);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes));
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateBoolean = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_booleanContainerInstanceFixture, parametersOfEvaluateBoolean);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(4);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateBoolean = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodEvaluateBoolean, parametersOfEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            parametersOfEvaluateBoolean.ShouldNotBeNull();
            parametersOfEvaluateBoolean.Length.ShouldBe(4);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateBooleanParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BooleanContainer_EvaluateBoolean_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, 1);
            const int parametersCount = 4;

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