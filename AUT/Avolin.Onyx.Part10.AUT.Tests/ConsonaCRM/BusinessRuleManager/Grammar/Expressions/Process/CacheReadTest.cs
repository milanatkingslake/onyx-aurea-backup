using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process.CacheRead" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Process"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CacheReadTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CacheRead" />)
        /// </summary>
        public CacheReadTest() : base(typeof(CacheRead))
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

        #region General Initializer : Class (CacheRead) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cacheReadInstanceType;
        private CacheRead _cacheReadInstance;
        private CacheRead _cacheReadInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CacheRead" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cacheReadInstanceType = typeof(CacheRead);
            _cacheReadInstanceFixture = this.Create<CacheRead>(false);
            _cacheReadInstance = _cacheReadInstanceFixture ?? this.Create<CacheRead>(true);
            CurrentInstance = _cacheReadInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CacheRead) Initializer

        #region Methods

        private const string MethodEvaluateBoolean = "EvaluateBoolean";
        private const string MethodEvaluateDateTime = "EvaluateDateTime";
        private const string MethodEvaluateFloat = "EvaluateFloat";
        private const string MethodEvaluateInteger = "EvaluateInteger";
        private const string MethodEvaluateString = "EvaluateString";
        private const string MethodGetName = "GetName";

        #endregion

        #endregion

        #region General Initializer : Class (CacheRead) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CacheRead" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CacheRead_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CacheRead)

        #region General Initializer : Class (CacheRead) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CacheRead" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateBoolean, 0)]
        [TestCase(MethodEvaluateDateTime, 0)]
        [TestCase(MethodEvaluateFloat, 0)]
        [TestCase(MethodEvaluateInteger, 0)]
        [TestCase(MethodEvaluateString, 0)]
        [TestCase(MethodGetName, 0)]
        public void AUT_CacheRead_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CacheRead) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CacheRead" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CacheRead_Is_Instance_Present_Test()
        {
            // Assert
            _cacheReadInstanceType.ShouldNotBeNull();
            _cacheReadInstance.ShouldNotBeNull();
            _cacheReadInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CacheRead) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CacheRead" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CacheRead_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cacheReadInstance.ShouldBeAssignableTo<CacheRead>();
            _cacheReadInstanceFixture.ShouldBeAssignableTo<CacheRead>();
            CurrentInstance.ShouldBeAssignableTo<CacheRead>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CacheRead) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CacheRead_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CacheRead instance = null;

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
        public void AUT_CacheRead_EvaluateBoolean_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _cacheReadInstance.EvaluateBoolean(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateBoolean) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cacheReadInstanceFixture, parametersOfEvaluateBoolean);
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_cacheReadInstanceFixture, out exception1, parametersOfEvaluateBoolean);
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateBoolean);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateBooleanParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateBoolean = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateBoolean, methodEvaluateBooleanParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cacheReadInstanceFixture, parametersOfEvaluateBoolean);

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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CacheRead_EvaluateBoolean_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CacheRead_EvaluateDateTime_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateDateTimeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateDateTime_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _cacheReadInstance.EvaluateDateTime(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateDateTime_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(DateTime);

            // Act
            Action executeAction = () => returnedValue = _cacheReadInstance.EvaluateDateTime(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (EvaluateDateTime) (Return Type : DateTime) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DateTime>(_cacheReadInstanceFixture, out exception1, parametersOfEvaluateDateTime);
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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateDateTime);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateDateTimeParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateDateTime = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateDateTime, methodEvaluateDateTimeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cacheReadInstanceFixture, parametersOfEvaluateDateTime);

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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CacheRead_EvaluateDateTime_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CacheRead_EvaluateFloat_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateFloatParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateFloat, methodEvaluateFloatParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateFloat_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _cacheReadInstance.EvaluateFloat(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateFloat) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateFloat_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_cacheReadInstanceFixture, parametersOfEvaluateFloat);
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_cacheReadInstanceFixture, out exception1, parametersOfEvaluateFloat);
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateFloat);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateFloatParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateFloat = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateFloat, methodEvaluateFloatParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cacheReadInstanceFixture, parametersOfEvaluateFloat);

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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CacheRead_EvaluateFloat_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CacheRead_EvaluateInteger_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateIntegerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateInteger_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _cacheReadInstance.EvaluateInteger(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateInteger) (Return Type : long) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateInteger_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_cacheReadInstanceFixture, parametersOfEvaluateInteger);
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<long>(_cacheReadInstanceFixture, out exception1, parametersOfEvaluateInteger);
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateInteger);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateIntegerParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateInteger = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateInteger, methodEvaluateIntegerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cacheReadInstanceFixture, parametersOfEvaluateInteger);

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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_CacheRead_EvaluateInteger_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_CacheRead_EvaluateString_Method_Call_Internally(Type[] types)
        {
            var methodEvaluateStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEvaluateString, methodEvaluateStringParametersTypes);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateString_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _cacheReadInstance.EvaluateString(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateString_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _cacheReadInstance.EvaluateString(pDataNode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (EvaluateString) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_EvaluateString_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cacheReadInstanceFixture, parametersOfEvaluateString);
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
        public void AUT_CacheRead_EvaluateString_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEvaluateString);
            var pDataNode = this.CreateType<XmlNode>();
            var methodEvaluateStringParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfEvaluateString = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEvaluateString, methodEvaluateStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_cacheReadInstanceFixture, parametersOfEvaluateString);

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
        public void AUT_CacheRead_EvaluateString_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_CacheRead_EvaluateString_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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
        public void AUT_CacheRead_EvaluateString_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_CacheRead_EvaluateString_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_CacheRead_EvaluateString_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CacheRead_GetName_Method_Call_Internally(Type[] types)
        {
            var methodGetNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var pDataNode = this.CreateType<XmlNode>();
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetName = { pDataNode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, methodGetNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_cacheReadInstanceFixture, parametersOfGetName);
            var result2 = this.GetResultOfMethod<string>(MethodGetName, parametersOfGetName, methodGetNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetName.ShouldNotBeNull();
            parametersOfGetName.Length.ShouldBe(1);
            methodGetNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var pDataNode = this.CreateType<XmlNode>();
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfGetName = { pDataNode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetName, parametersOfGetName, methodGetNameParametersTypes);

            // Assert
            parametersOfGetName.ShouldNotBeNull();
            parametersOfGetName.Length.ShouldBe(1);
            methodGetNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var methodGetNameParametersTypes = new Type[] { typeof(XmlNode) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetName, methodGetNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CacheRead_GetName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetName, 0);
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