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
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.FloatContainer" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FloatContainerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FloatContainer" />)
        /// </summary>
        public FloatContainerTest() : base(typeof(FloatContainer))
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

        #region General Initializer : Class (FloatContainer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _floatContainerInstanceType;
        private FloatContainer _floatContainerInstance;
        private FloatContainer _floatContainerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FloatContainer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _floatContainerInstanceType = typeof(FloatContainer);
            _floatContainerInstanceFixture = this.Create<FloatContainer>(false);
            _floatContainerInstance = _floatContainerInstanceFixture ?? this.Create<FloatContainer>(true);
            CurrentInstance = _floatContainerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FloatContainer) Initializer

        #region Methods

        private const string MethodEvaluateFloat = "EvaluateFloat";

        #endregion

        #endregion

        #region General Initializer : Class (FloatContainer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FloatContainer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FloatContainer)

        #region General Initializer : Class (FloatContainer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateFloat, 0)]
        [TestCase(MethodEvaluateFloat, 1)]
        public void AUT_FloatContainer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FloatContainer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatContainer_Is_Instance_Present_Test()
        {
            // Assert
            _floatContainerInstanceType.ShouldNotBeNull();
            _floatContainerInstance.ShouldNotBeNull();
            _floatContainerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FloatContainer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatContainer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _floatContainerInstance.ShouldBeAssignableTo<FloatContainer>();
            _floatContainerInstanceFixture.ShouldBeAssignableTo<FloatContainer>();
            CurrentInstance.ShouldBeAssignableTo<FloatContainer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FloatContainer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FloatContainer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (FloatContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            FloatContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FloatContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _floatContainerInstance.ShouldNotBeNull();
            _floatContainerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<FloatContainer>();
        }

        #endregion

        #region General Constructor : Class (FloatContainer) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            FloatContainer instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new FloatContainer(pMetadataNode, pEngine, pNamespaceManager);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _floatContainerInstance.ShouldNotBeNull();
            _floatContainerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (FloatContainer) instance created

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Is_Created_Test()
        {
            // Assert
            _floatContainerInstance.ShouldNotBeNull();
            _floatContainerInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (FloatContainer) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="FloatContainer" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_FloatContainer_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (FloatContainer) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="FloatContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (FloatContainer) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FloatContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodFloatContainerParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFloatContainerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (FloatContainer) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="FloatContainer" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatContainer_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodFloatContainerParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNamespaceManager) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodFloatContainerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _floatContainerInstance.EvaluateFloat(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floatContainerInstanceFixture, parametersOfEvaluateFloat);
            var result2 = this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(1);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floatContainerInstanceFixture, out exception1, parametersOfEvaluateFloat);
            var result2 = this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(1);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_floatContainerInstanceFixture, parametersOfEvaluateFloat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(1);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(1);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FloatContainer_EvaluateFloat_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodEvaluateFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();

            // Act
            Action executeAction = () => FloatContainer.EvaluateFloat(pMetadataNode, pEngine, pDataNode, pNamespaceManager);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateFloat = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);
            var result2 = this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(4);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(() => this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes));
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateFloat = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_floatContainerInstanceFixture, parametersOfEvaluateFloat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(4);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pMetadataNode = this.CreateType<XmlNode>();
            var pEngine = this.CreateType<InternalEngine>();
            var pDataNode = this.CreateType<XmlNode>();
            var pNamespaceManager = this.CreateType<XmlNamespaceManager>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            object[] parametersOfEvaluateFloat = { pMetadataNode, pEngine, pDataNode, pNamespaceManager };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodEvaluateFloat, parametersOfEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            parametersOfEvaluateFloat.ShouldNotBeNull();
            parametersOfEvaluateFloat.Length.ShouldBe(4);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateFloatParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateFloatParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode), typeof(InternalEngine), typeof(XmlNode), typeof(XmlNamespaceManager) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatContainer_EvaluateFloat_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, 1);
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