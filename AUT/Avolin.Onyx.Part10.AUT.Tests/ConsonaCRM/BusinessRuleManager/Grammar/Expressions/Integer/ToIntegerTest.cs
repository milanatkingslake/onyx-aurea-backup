using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer.ToInteger" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ToIntegerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ToInteger" />)
        /// </summary>
        public ToIntegerTest() : base(typeof(ToInteger))
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

        #region General Initializer : Class (ToInteger) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _toIntegerInstanceType;
        private ToInteger _toIntegerInstance;
        private ToInteger _toIntegerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ToInteger" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _toIntegerInstanceType = typeof(ToInteger);
            _toIntegerInstanceFixture = this.Create<ToInteger>(false);
            _toIntegerInstance = _toIntegerInstanceFixture ?? this.Create<ToInteger>(true);
            CurrentInstance = _toIntegerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ToInteger) Initializer

        #region Methods

        private const string MethodEvaluateInteger = "EvaluateInteger";

        #endregion

        #endregion

        #region General Initializer : Class (ToInteger) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ToInteger" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ToInteger_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ToInteger)

        #region General Initializer : Class (ToInteger) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ToInteger" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateInteger, 0)]
        public void AUT_ToInteger_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ToInteger) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ToInteger" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ToInteger_Is_Instance_Present_Test()
        {
            // Assert
            _toIntegerInstanceType.ShouldNotBeNull();
            _toIntegerInstance.ShouldNotBeNull();
            _toIntegerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ToInteger) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ToInteger" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ToInteger_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _toIntegerInstance.ShouldBeAssignableTo<ToInteger>();
            _toIntegerInstanceFixture.ShouldBeAssignableTo<ToInteger>();
            CurrentInstance.ShouldBeAssignableTo<ToInteger>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ToInteger) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ToInteger_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ToInteger instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateInteger) (Return Type : long) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();

            // Act
            Action executeAction = () => _toIntegerInstance.EvaluateInteger(pDataNode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_toIntegerInstanceFixture, parametersOfEvaluateInteger);
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
        public void AUT_ToInteger_EvaluateInteger_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_toIntegerInstanceFixture, out exception1, parametersOfEvaluateInteger);
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

        #region Method Call : (EvaluateInteger) (Return Type : long) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<System.Xml.XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
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

        #region Method Call : (EvaluateInteger) (Return Type : long) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(System.Xml.XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodEvaluateIntegerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ToInteger_EvaluateInteger_Method_Call_Parameters_Count_Verification_Test()
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