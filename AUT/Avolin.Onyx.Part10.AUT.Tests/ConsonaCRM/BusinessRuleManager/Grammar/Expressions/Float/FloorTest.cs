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

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.Floor" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FloorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Floor" />)
        /// </summary>
        public FloorTest() : base(typeof(Floor))
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

        #region General Initializer : Class (Floor) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _floorInstanceType;
        private Floor _floorInstance;
        private Floor _floorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Floor" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _floorInstanceType = typeof(Floor);
            _floorInstanceFixture = this.Create<Floor>(false);
            _floorInstance = _floorInstanceFixture ?? this.Create<Floor>(true);
            CurrentInstance = _floorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Floor) Initializer

        #region Methods

        private const string MethodEvaluateFloat = "EvaluateFloat";

        #endregion

        #endregion

        #region General Initializer : Class (Floor) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Floor" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Floor_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Floor)

        #region General Initializer : Class (Floor) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Floor" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateFloat, 0)]
        public void AUT_Floor_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Floor) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Floor" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Floor_Is_Instance_Present_Test()
        {
            // Assert
            _floorInstanceType.ShouldNotBeNull();
            _floorInstance.ShouldNotBeNull();
            _floorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Floor) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Floor" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Floor_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _floorInstance.ShouldBeAssignableTo<Floor>();
            _floorInstanceFixture.ShouldBeAssignableTo<Floor>();
            CurrentInstance.ShouldBeAssignableTo<Floor>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Floor) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Floor_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Floor instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Floor_EvaluateFloat_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();

            // Act
            Action executeAction = () => _floorInstance.EvaluateFloat(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Floor_EvaluateFloat_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floorInstanceFixture, parametersOfEvaluateFloat);
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
        public void AUT_Floor_EvaluateFloat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floorInstanceFixture, out exception1, parametersOfEvaluateFloat);
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
        public void AUT_Floor_EvaluateFloat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_floorInstanceFixture, parametersOfEvaluateFloat);

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
        public void AUT_Floor_EvaluateFloat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Floor_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };

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
        public void AUT_Floor_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };

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
        public void AUT_Floor_EvaluateFloat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (EvaluateFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Floor_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_Floor_EvaluateFloat_Method_Call_Parameters_Count_Verification_Test()
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