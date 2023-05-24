using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Literal" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LiteralTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Literal" />)
        /// </summary>
        public LiteralTest() : base(typeof(Literal))
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

        #region General Initializer : Class (Literal) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _literalInstanceType;
        private Literal _literalInstance;
        private Literal _literalInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Literal" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _literalInstanceType = typeof(Literal);
            _literalInstanceFixture = this.Create<Literal>(false);
            _literalInstance = _literalInstanceFixture ?? this.Create<Literal>(true);
            CurrentInstance = _literalInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Literal) Initializer

        #region Methods

        private const string MethodEvaluateBoolean = "EvaluateBoolean";
        private const string MethodEvaluateDateTime = "EvaluateDateTime";
        private const string MethodEvaluateFloat = "EvaluateFloat";
        private const string MethodEvaluateInteger = "EvaluateInteger";
        private const string MethodEvaluateString = "EvaluateString";
        private const string MethodConvertToString = "ConvertToString";
        private const string MethodConvertToInt = "ConvertToInt";
        private const string MethodConvertToFloat = "ConvertToFloat";
        private const string MethodConvertToDateTime = "ConvertToDateTime";

        #endregion

        #endregion

        #region General Initializer : Class (Literal) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Literal" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Literal_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Literal)

        #region General Initializer : Class (Literal) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Literal" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateBoolean, 0)]
        [TestCase(MethodEvaluateDateTime, 0)]
        [TestCase(MethodEvaluateFloat, 0)]
        [TestCase(MethodEvaluateInteger, 0)]
        [TestCase(MethodEvaluateString, 0)]
        [TestCase(MethodConvertToString, 0)]
        [TestCase(MethodConvertToString, 1)]
        [TestCase(MethodConvertToString, 2)]
        [TestCase(MethodConvertToString, 3)]
        [TestCase(MethodConvertToString, 4)]
        [TestCase(MethodConvertToInt, 0)]
        [TestCase(MethodConvertToInt, 1)]
        [TestCase(MethodConvertToInt, 2)]
        [TestCase(MethodConvertToInt, 3)]
        [TestCase(MethodConvertToFloat, 0)]
        [TestCase(MethodConvertToFloat, 1)]
        [TestCase(MethodConvertToFloat, 2)]
        [TestCase(MethodConvertToFloat, 3)]
        [TestCase(MethodConvertToDateTime, 0)]
        public void AUT_Literal_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Literal) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Literal" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Literal_Is_Instance_Present_Test()
        {
            // Assert
            _literalInstanceType.ShouldNotBeNull();
            _literalInstance.ShouldNotBeNull();
            _literalInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Literal) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Literal" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Literal_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _literalInstance.ShouldBeAssignableTo<Literal>();
            _literalInstanceFixture.ShouldBeAssignableTo<Literal>();
            CurrentInstance.ShouldBeAssignableTo<Literal>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Literal) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Literal_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Literal instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateBoolean_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _literalInstance.EvaluateBoolean(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateBoolean_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_literalInstanceFixture, parametersOfEvaluateBoolean);
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_literalInstanceFixture, out exception1, parametersOfEvaluateBoolean);
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfEvaluateBoolean);

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
        public void AUT_Literal_EvaluateBoolean_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_Literal_EvaluateBoolean_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_EvaluateDateTime_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _literalInstance.EvaluateDateTime(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = _literalInstance.EvaluateDateTime(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DateTime>(_literalInstanceFixture, out exception1, parametersOfEvaluateDateTime);
            var result2 = this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfEvaluateDateTime);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodEvaluateDateTime, parametersOfEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            parametersOfEvaluateDateTime.ShouldNotBeNull();
            parametersOfEvaluateDateTime.Length.ShouldBe(1);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateDateTime_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_EvaluateFloat_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateFloat_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _literalInstance.EvaluateFloat(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateFloat_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_literalInstanceFixture, parametersOfEvaluateFloat);
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
        public void AUT_Literal_EvaluateFloat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_literalInstanceFixture, out exception1, parametersOfEvaluateFloat);
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
        public void AUT_Literal_EvaluateFloat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfEvaluateFloat);

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
        public void AUT_Literal_EvaluateFloat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_Literal_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_Literal_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_Literal_EvaluateFloat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_Literal_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_Literal_EvaluateFloat_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (EvaluateInteger) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_EvaluateInteger_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateIntegerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _literalInstance.EvaluateInteger(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_literalInstanceFixture, parametersOfEvaluateInteger);
            var result2 = this.GetResultOfMethod<long>(MethodEvaluateInteger, parametersOfEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateInteger.ShouldNotBeNull();
            parametersOfEvaluateInteger.Length.ShouldBe(1);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_literalInstanceFixture, out exception1, parametersOfEvaluateInteger);
            var result2 = this.GetResultOfMethod<long>(MethodEvaluateInteger, parametersOfEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfEvaluateInteger.ShouldNotBeNull();
            parametersOfEvaluateInteger.Length.ShouldBe(1);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfEvaluateInteger);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateInteger.ShouldNotBeNull();
            parametersOfEvaluateInteger.Length.ShouldBe(1);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodEvaluateInteger, parametersOfEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            parametersOfEvaluateInteger.ShouldNotBeNull();
            parametersOfEvaluateInteger.Length.ShouldBe(1);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateInteger_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_EvaluateString_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateString, methodEvaluateStringParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _literalInstance.EvaluateString(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _literalInstance.EvaluateString(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_literalInstanceFixture, parametersOfEvaluateString);
            var result2 = this.GetResultOfMethod<string>(MethodEvaluateString, parametersOfEvaluateString, methodEvaluateStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfEvaluateString.ShouldNotBeNull();
            parametersOfEvaluateString.Length.ShouldBe(1);
            methodEvaluateStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfEvaluateString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEvaluateString.ShouldNotBeNull();
            parametersOfEvaluateString.Length.ShouldBe(1);
            methodEvaluateStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodEvaluateString, parametersOfEvaluateString, methodEvaluateStringParametersTypes);

            // Assert
            parametersOfEvaluateString.ShouldNotBeNull();
            parametersOfEvaluateString.Length.ShouldBe(1);
            methodEvaluateStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodEvaluateString, methodEvaluateStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodEvaluateStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateString, methodEvaluateStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_EvaluateString_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToString_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pbValue = this.CreateType<bool>();

            // Act
            Action executeAction = () => Literal.ConvertToString(pbValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pbValue = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToString(pbValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pbValue = this.CreateType<bool>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToString = { pbValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pbValue = this.CreateType<bool>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToString = { pbValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pbValue = this.CreateType<bool>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToString = { pbValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToString_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodConvertToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Literal.ConvertToString(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<DateTime>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToString(pValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToString = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToString_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodConvertToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var piValue = this.CreateType<long>();

            // Act
            Action executeAction = () => Literal.ConvertToString(piValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_2_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var piValue = this.CreateType<long>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToString(piValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var piValue = this.CreateType<long>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToString = { piValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var piValue = this.CreateType<long>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToString = { piValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var piValue = this.CreateType<long>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToString = { piValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(long) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(long) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToString_Static_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodConvertToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_3_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<double>();

            // Act
            Action executeAction = () => Literal.ConvertToString(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_3_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<double>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToString(pValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<double>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<double>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<double>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToString = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(double) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 3);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToString_Static_Method_Overloading_Of_4_Call_Internally(Type[] types)
        {
            var methodConvertToStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_4_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<byte[]>();

            // Act
            Action executeAction = () => Literal.ConvertToString(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_DirectCall_Overloading_Of_4_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<byte[]>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToString(pValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<byte[]>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<byte[]>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfConvertToString = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, methodConvertToStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var pValue = this.CreateType<byte[]>();
            var methodConvertToStringParametersTypes = new Type[] { typeof(byte[]) };
            object[] parametersOfConvertToString = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodConvertToString, parametersOfConvertToString, methodConvertToStringParametersTypes);

            // Assert
            parametersOfConvertToString.ShouldNotBeNull();
            parametersOfConvertToString.Length.ShouldBe(1);
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(byte[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var methodConvertToStringParametersTypes = new Type[] { typeof(byte[]) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToString, methodConvertToStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 4);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToString_Static_Method_Call_Overloading_Of_4_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToString);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToString, 4);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToInt_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertToIntParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var psValue = this.CreateType<string>();

            // Act
            Action executeAction = () => Literal.ConvertToInt(psValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var psValue = this.CreateType<string>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertToInt = { psValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToIntParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToInt_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodConvertToIntParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pbValue = this.CreateType<bool>();

            // Act
            Action executeAction = () => Literal.ConvertToInt(pbValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pbValue = this.CreateType<bool>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToInt = { pbValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
            var result2 = this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pbValue = this.CreateType<bool>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToInt = { pbValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToInt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pbValue = this.CreateType<bool>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToInt = { pbValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToIntParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToInt_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodConvertToIntParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<double>();

            // Act
            Action executeAction = () => Literal.ConvertToInt(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<double>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToInt = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
            var result2 = this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<double>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToInt = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToInt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<double>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };
            object[] parametersOfConvertToInt = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(double) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToIntParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToInt_Static_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodConvertToIntParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_DirectCall_Overloading_Of_3_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Literal.ConvertToInt(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToInt = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);
            var result2 = this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToInt = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, methodConvertToIntParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToInt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToInt = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<long>(MethodConvertToInt, parametersOfConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            parametersOfConvertToInt.ShouldNotBeNull();
            parametersOfConvertToInt.Length.ShouldBe(1);
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToIntParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var methodConvertToIntParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToInt, methodConvertToIntParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToIntParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToInt) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToInt_Static_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToInt);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToInt, 3);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToFloat_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertToFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var psValue = this.CreateType<string>();

            // Act
            Action executeAction = () => Literal.ConvertToFloat(psValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var psValue = this.CreateType<string>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertToFloat = { psValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToFloat_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodConvertToFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pbValue = this.CreateType<bool>();

            // Act
            Action executeAction = () => Literal.ConvertToFloat(pbValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pbValue = this.CreateType<bool>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToFloat = { pbValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
            var result2 = this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pbValue = this.CreateType<bool>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToFloat = { pbValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToFloat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pbValue = this.CreateType<bool>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfConvertToFloat = { pbValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 1);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToFloat_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodConvertToFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<long>();

            // Act
            Action executeAction = () => Literal.ConvertToFloat(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<long>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToFloat = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
            var result2 = this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<long>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToFloat = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToFloat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<long>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };
            object[] parametersOfConvertToFloat = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(long) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToFloat_Static_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodConvertToFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_DirectCall_Overloading_Of_3_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<DateTime>();

            // Act
            Action executeAction = () => Literal.ConvertToFloat(pValue);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToFloat = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);
            var result2 = this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes));
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToFloat = { pValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, methodConvertToFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_literalInstanceFixture, parametersOfConvertToFloat);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var pValue = this.CreateType<DateTime>();
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };
            object[] parametersOfConvertToFloat = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodConvertToFloat, parametersOfConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            parametersOfConvertToFloat.ShouldNotBeNull();
            parametersOfConvertToFloat.Length.ShouldBe(1);
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodConvertToFloatParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var methodConvertToFloatParametersTypes = new Type[] { typeof(DateTime) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToFloat, methodConvertToFloatParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToFloatParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToFloat) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToFloat_Static_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToFloat);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToFloat, 3);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Literal_ConvertToDateTime_Static_Method_Call_Internally(Type[] types)
        {
            var methodConvertToDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodConvertToDateTime, methodConvertToDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var pValue = this.CreateType<string>();

            // Act
            Action executeAction = () => Literal.ConvertToDateTime(pValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var pValue = this.CreateType<string>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = Literal.ConvertToDateTime(pValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var pValue = this.CreateType<string>();
            var methodConvertToDateTimeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfConvertToDateTime = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DateTime>(MethodConvertToDateTime, parametersOfConvertToDateTime, methodConvertToDateTimeParametersTypes);

            // Assert
            parametersOfConvertToDateTime.ShouldNotBeNull();
            parametersOfConvertToDateTime.Length.ShouldBe(1);
            methodConvertToDateTimeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var methodConvertToDateTimeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodConvertToDateTime, methodConvertToDateTimeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodConvertToDateTimeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var methodConvertToDateTimeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodConvertToDateTime, methodConvertToDateTimeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodConvertToDateTimeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToDateTime, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ConvertToDateTime) (Return Type : DateTime) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Literal_ConvertToDateTime_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodConvertToDateTime);
            var currentMethodInfo = this.GetMethodInfo(MethodConvertToDateTime, 0);
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