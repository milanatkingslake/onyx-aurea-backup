using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.StringFormat" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StringFormatTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StringFormat" />)
        /// </summary>
        public StringFormatTest() : base(typeof(StringFormat))
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

        #region General Initializer : Class (StringFormat) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stringFormatInstanceType;
        private StringFormat _stringFormatInstance;
        private StringFormat _stringFormatInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StringFormat" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stringFormatInstanceType = typeof(StringFormat);
            _stringFormatInstanceFixture = this.Create<StringFormat>(false);
            _stringFormatInstance = _stringFormatInstanceFixture ?? this.Create<StringFormat>(true);
            CurrentInstance = _stringFormatInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StringFormat) Initializer

        #region Methods

        private const string MethodEvaluateString = "EvaluateString";
        private const string MethodGetArgument = "GetArgument";

        #endregion

        #endregion

        #region General Initializer : Class (StringFormat) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StringFormat" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringFormat_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StringFormat)

        #region General Initializer : Class (StringFormat) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StringFormat" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateString, 0)]
        [TestCase(MethodGetArgument, 0)]
        public void AUT_StringFormat_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (StringFormat) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StringFormat" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringFormat_Is_Instance_Present_Test()
        {
            // Assert
            _stringFormatInstanceType.ShouldNotBeNull();
            _stringFormatInstance.ShouldNotBeNull();
            _stringFormatInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StringFormat) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StringFormat" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringFormat_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stringFormatInstance.ShouldBeAssignableTo<StringFormat>();
            _stringFormatInstanceFixture.ShouldBeAssignableTo<StringFormat>();
            CurrentInstance.ShouldBeAssignableTo<StringFormat>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StringFormat) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StringFormat_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StringFormat instance = null;

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
        public void AUT_StringFormat_EvaluateString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _stringFormatInstance.EvaluateString(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_EvaluateString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _stringFormatInstance.EvaluateString(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_EvaluateString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_stringFormatInstanceFixture, parametersOfEvaluateString);
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
        public void AUT_StringFormat_EvaluateString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stringFormatInstanceFixture, parametersOfEvaluateString);

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
        public void AUT_StringFormat_EvaluateString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_StringFormat_EvaluateString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_StringFormat_EvaluateString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_StringFormat_EvaluateString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_StringFormat_EvaluateString_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetArgument) (Return Type : object) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StringFormat_GetArgument_Method_Call_Internally(Type[] types)
        {
            var methodGetArgumentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetArgument, methodGetArgumentParametersTypes);
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var pDataNode = this.CreateType<XmlNode>();
            var pGrammarNode = this.CreateType<XmlNode>();
            var methodGetArgumentParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfGetArgument = { pDataNode, pGrammarNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetArgument, methodGetArgumentParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_stringFormatInstanceFixture, parametersOfGetArgument);
            var result2 = this.GetResultOfMethod<object>(MethodGetArgument, parametersOfGetArgument, methodGetArgumentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetArgument.ShouldNotBeNull();
            parametersOfGetArgument.Length.ShouldBe(2);
            methodGetArgumentParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var pDataNode = this.CreateType<XmlNode>();
            var pGrammarNode = this.CreateType<XmlNode>();
            var methodGetArgumentParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            object[] parametersOfGetArgument = { pDataNode, pGrammarNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodGetArgument, parametersOfGetArgument, methodGetArgumentParametersTypes);

            // Assert
            parametersOfGetArgument.ShouldNotBeNull();
            parametersOfGetArgument.Length.ShouldBe(2);
            methodGetArgumentParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var methodGetArgumentParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetArgument, methodGetArgumentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetArgumentParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var methodGetArgumentParametersTypes = new Type[] { typeof(XmlNode), typeof(XmlNode) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetArgument, methodGetArgumentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetArgumentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var currentMethodInfo = this.GetMethodInfo(MethodGetArgument, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetArgument) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringFormat_GetArgument_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetArgument);
            var currentMethodInfo = this.GetMethodInfo(MethodGetArgument, 0);
            const int parametersCount = 2;

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