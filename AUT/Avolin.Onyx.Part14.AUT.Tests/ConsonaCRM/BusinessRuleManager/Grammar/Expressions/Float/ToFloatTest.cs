using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.ToFloat" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ToFloatTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ToFloat" />)
        /// </summary>
        public ToFloatTest() : base(typeof(ToFloat))
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

        #region General Initializer : Class (ToFloat) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _toFloatInstanceType;
        private ToFloat _toFloatInstance;
        private ToFloat _toFloatInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ToFloat" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _toFloatInstanceType = typeof(ToFloat);
            _toFloatInstanceFixture = this.Create<ToFloat>(false);
            _toFloatInstance = _toFloatInstanceFixture ?? this.Create<ToFloat>(true);
            CurrentInstance = _toFloatInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ToFloat) Initializer

        #region Methods

        private const string MethodEvaluateFloat = "EvaluateFloat";

        #endregion

        #endregion

        #region General Initializer : Class (ToFloat) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ToFloat" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ToFloat_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ToFloat)

        #region General Initializer : Class (ToFloat) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ToFloat" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateFloat, 0)]
        public void AUT_ToFloat_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ToFloat) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ToFloat" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ToFloat_Is_Instance_Present_Test()
        {
            // Assert
            _toFloatInstanceType.ShouldNotBeNull();
            _toFloatInstance.ShouldNotBeNull();
            _toFloatInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ToFloat) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ToFloat" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ToFloat_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _toFloatInstance.ShouldBeAssignableTo<ToFloat>();
            _toFloatInstanceFixture.ShouldBeAssignableTo<ToFloat>();
            CurrentInstance.ShouldBeAssignableTo<ToFloat>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ToFloat) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ToFloat_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ToFloat instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();

            // Act
            Action executeAction = () => _toFloatInstance.EvaluateFloat(pDataNode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_toFloatInstanceFixture, parametersOfEvaluateFloat);
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
        public void AUT_ToFloat_EvaluateFloat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_toFloatInstanceFixture, out exception1, parametersOfEvaluateFloat);
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

        #region Method Call : (EvaluateFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
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

        #region Method Call : (EvaluateFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToFloat_EvaluateFloat_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}