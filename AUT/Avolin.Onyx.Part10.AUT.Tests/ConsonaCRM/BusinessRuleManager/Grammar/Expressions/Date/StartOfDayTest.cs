using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date.StartOfDay" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StartOfDayTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StartOfDay" />)
        /// </summary>
        public StartOfDayTest() : base(typeof(StartOfDay))
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

        #region General Initializer : Class (StartOfDay) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _startOfDayInstanceType;
        private StartOfDay _startOfDayInstance;
        private StartOfDay _startOfDayInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StartOfDay" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _startOfDayInstanceType = typeof(StartOfDay);
            _startOfDayInstanceFixture = this.Create<StartOfDay>(false);
            _startOfDayInstance = _startOfDayInstanceFixture ?? this.Create<StartOfDay>(true);
            CurrentInstance = _startOfDayInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StartOfDay) Initializer

        #region Methods

        private const string MethodEvaluateDateTime = "EvaluateDateTime";

        #endregion

        #endregion

        #region General Initializer : Class (StartOfDay) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StartOfDay" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StartOfDay_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StartOfDay)

        #region General Initializer : Class (StartOfDay) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StartOfDay" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateDateTime, 0)]
        public void AUT_StartOfDay_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (StartOfDay) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StartOfDay" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StartOfDay_Is_Instance_Present_Test()
        {
            // Assert
            _startOfDayInstanceType.ShouldNotBeNull();
            _startOfDayInstance.ShouldNotBeNull();
            _startOfDayInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StartOfDay) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StartOfDay" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StartOfDay_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _startOfDayInstance.ShouldBeAssignableTo<StartOfDay>();
            _startOfDayInstanceFixture.ShouldBeAssignableTo<StartOfDay>();
            CurrentInstance.ShouldBeAssignableTo<StartOfDay>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StartOfDay) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StartOfDay_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StartOfDay instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StartOfDay_EvaluateDateTime_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _startOfDayInstance.EvaluateDateTime(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StartOfDay_EvaluateDateTime_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = _startOfDayInstance.EvaluateDateTime(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DateTime>(_startOfDayInstanceFixture, out exception1, parametersOfEvaluateDateTime);
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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_startOfDayInstanceFixture, parametersOfEvaluateDateTime);

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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_StartOfDay_EvaluateDateTime_Method_Call_Parameters_Count_Verification_Test()
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

        #endregion

        #endregion
    }
}