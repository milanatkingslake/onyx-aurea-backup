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

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File.TextFileReadLine" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.File"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TextFileReadLineTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TextFileReadLine" />)
        /// </summary>
        public TextFileReadLineTest() : base(typeof(TextFileReadLine))
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

        #region General Initializer : Class (TextFileReadLine) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _textFileReadLineInstanceType;
        private TextFileReadLine _textFileReadLineInstance;
        private TextFileReadLine _textFileReadLineInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TextFileReadLine" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _textFileReadLineInstanceType = typeof(TextFileReadLine);
            _textFileReadLineInstanceFixture = this.Create<TextFileReadLine>(false);
            _textFileReadLineInstance = _textFileReadLineInstanceFixture ?? this.Create<TextFileReadLine>(true);
            CurrentInstance = _textFileReadLineInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TextFileReadLine) Initializer

        #region Methods

        private const string MethodEvaluateString = "EvaluateString";

        #endregion

        #endregion

        #region General Initializer : Class (TextFileReadLine) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TextFileReadLine" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TextFileReadLine_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TextFileReadLine)

        #region General Initializer : Class (TextFileReadLine) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TextFileReadLine" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateString, 0)]
        public void AUT_TextFileReadLine_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TextFileReadLine) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TextFileReadLine" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadLine_Is_Instance_Present_Test()
        {
            // Assert
            _textFileReadLineInstanceType.ShouldNotBeNull();
            _textFileReadLineInstance.ShouldNotBeNull();
            _textFileReadLineInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TextFileReadLine) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TextFileReadLine" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TextFileReadLine_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _textFileReadLineInstance.ShouldBeAssignableTo<TextFileReadLine>();
            _textFileReadLineInstanceFixture.ShouldBeAssignableTo<TextFileReadLine>();
            CurrentInstance.ShouldBeAssignableTo<TextFileReadLine>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TextFileReadLine) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TextFileReadLine_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TextFileReadLine instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadLine_EvaluateString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _textFileReadLineInstance.EvaluateString(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadLine_EvaluateString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _textFileReadLineInstance.EvaluateString(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_textFileReadLineInstanceFixture, parametersOfEvaluateString);
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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_textFileReadLineInstanceFixture, parametersOfEvaluateString);

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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_TextFileReadLine_EvaluateString_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}