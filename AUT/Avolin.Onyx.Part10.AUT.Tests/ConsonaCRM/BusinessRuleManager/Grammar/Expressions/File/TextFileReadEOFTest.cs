using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File.TextFileReadEOF" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TextFileReadEOFTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TextFileReadEOF" />)
        /// </summary>
        public TextFileReadEOFTest() : base(typeof(TextFileReadEOF))
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

        #region General Initializer : Class (TextFileReadEOF) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _textFileReadEOFInstanceType;
        private TextFileReadEOF _textFileReadEOFInstance;
        private TextFileReadEOF _textFileReadEOFInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TextFileReadEOF" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _textFileReadEOFInstanceType = typeof(TextFileReadEOF);
            _textFileReadEOFInstanceFixture = this.Create<TextFileReadEOF>(false);
            _textFileReadEOFInstance = _textFileReadEOFInstanceFixture ?? this.Create<TextFileReadEOF>(true);
            CurrentInstance = _textFileReadEOFInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TextFileReadEOF) Initializer

        #region Methods

        private const string MethodEvaluateBoolean = "EvaluateBoolean";

        #endregion

        #endregion

        #region General Initializer : Class (TextFileReadEOF) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TextFileReadEOF" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TextFileReadEOF_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TextFileReadEOF)

        #region General Initializer : Class (TextFileReadEOF) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TextFileReadEOF" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateBoolean, 0)]
        public void AUT_TextFileReadEOF_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TextFileReadEOF) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TextFileReadEOF" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadEOF_Is_Instance_Present_Test()
        {
            // Assert
            _textFileReadEOFInstanceType.ShouldNotBeNull();
            _textFileReadEOFInstance.ShouldNotBeNull();
            _textFileReadEOFInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TextFileReadEOF) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TextFileReadEOF" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadEOF_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _textFileReadEOFInstance.ShouldBeAssignableTo<TextFileReadEOF>();
            _textFileReadEOFInstanceFixture.ShouldBeAssignableTo<TextFileReadEOF>();
            CurrentInstance.ShouldBeAssignableTo<TextFileReadEOF>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TextFileReadEOF) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TextFileReadEOF_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TextFileReadEOF instance = null;

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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _textFileReadEOFInstance.EvaluateBoolean(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_textFileReadEOFInstanceFixture, parametersOfEvaluateBoolean);
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_textFileReadEOFInstanceFixture, out exception1, parametersOfEvaluateBoolean);
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_textFileReadEOFInstanceFixture, parametersOfEvaluateBoolean);

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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_TextFileReadEOF_EvaluateBoolean_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}