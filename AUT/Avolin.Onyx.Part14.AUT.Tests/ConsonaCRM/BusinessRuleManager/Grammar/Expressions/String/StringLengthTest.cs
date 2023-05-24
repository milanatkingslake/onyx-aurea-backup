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

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.StringLength" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StringLengthTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StringLength" />)
        /// </summary>
        public StringLengthTest() : base(typeof(StringLength))
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

        #region General Initializer : Class (StringLength) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stringLengthInstanceType;
        private StringLength _stringLengthInstance;
        private StringLength _stringLengthInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StringLength" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stringLengthInstanceType = typeof(StringLength);
            _stringLengthInstanceFixture = this.Create<StringLength>(false);
            _stringLengthInstance = _stringLengthInstanceFixture ?? this.Create<StringLength>(true);
            CurrentInstance = _stringLengthInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StringLength) Initializer

        #region Methods

        private const string MethodEvaluateInteger = "EvaluateInteger";

        #endregion

        #endregion

        #region General Initializer : Class (StringLength) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StringLength" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringLength_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StringLength)

        #region General Initializer : Class (StringLength) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StringLength" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateInteger, 0)]
        public void AUT_StringLength_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (StringLength) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StringLength" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringLength_Is_Instance_Present_Test()
        {
            // Assert
            _stringLengthInstanceType.ShouldNotBeNull();
            _stringLengthInstance.ShouldNotBeNull();
            _stringLengthInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StringLength) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StringLength" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringLength_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stringLengthInstance.ShouldBeAssignableTo<StringLength>();
            _stringLengthInstanceFixture.ShouldBeAssignableTo<StringLength>();
            CurrentInstance.ShouldBeAssignableTo<StringLength>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StringLength) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StringLength_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StringLength instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateInteger) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringLength_EvaluateInteger_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _stringLengthInstance.EvaluateInteger(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringLength_EvaluateInteger_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_stringLengthInstanceFixture, parametersOfEvaluateInteger);
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_stringLengthInstanceFixture, out exception1, parametersOfEvaluateInteger);
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stringLengthInstanceFixture, parametersOfEvaluateInteger);

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
        public void AUT_StringLength_EvaluateInteger_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_StringLength_EvaluateInteger_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}