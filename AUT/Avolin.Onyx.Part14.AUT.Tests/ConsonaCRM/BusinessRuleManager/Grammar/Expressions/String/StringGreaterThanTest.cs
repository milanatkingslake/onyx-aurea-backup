using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.StringGreaterThan" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StringGreaterThanTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StringGreaterThan" />)
        /// </summary>
        public StringGreaterThanTest() : base(typeof(StringGreaterThan))
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

        #region General Initializer : Class (StringGreaterThan) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stringGreaterThanInstanceType;
        private StringGreaterThan _stringGreaterThanInstance;
        private StringGreaterThan _stringGreaterThanInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StringGreaterThan" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stringGreaterThanInstanceType = typeof(StringGreaterThan);
            _stringGreaterThanInstanceFixture = this.Create<StringGreaterThan>(false);
            _stringGreaterThanInstance = _stringGreaterThanInstanceFixture ?? this.Create<StringGreaterThan>(true);
            CurrentInstance = _stringGreaterThanInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StringGreaterThan) Initializer

        #region Methods

        private const string MethodCompareValues = "CompareValues";

        #endregion

        #endregion

        #region General Initializer : Class (StringGreaterThan) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StringGreaterThan" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringGreaterThan_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StringGreaterThan)

        #region General Initializer : Class (StringGreaterThan) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StringGreaterThan" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCompareValues, 0)]
        public void AUT_StringGreaterThan_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (StringGreaterThan) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StringGreaterThan" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringGreaterThan_Is_Instance_Present_Test()
        {
            // Assert
            _stringGreaterThanInstanceType.ShouldNotBeNull();
            _stringGreaterThanInstance.ShouldNotBeNull();
            _stringGreaterThanInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StringGreaterThan) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StringGreaterThan" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringGreaterThan_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stringGreaterThanInstance.ShouldBeAssignableTo<StringGreaterThan>();
            _stringGreaterThanInstanceFixture.ShouldBeAssignableTo<StringGreaterThan>();
            CurrentInstance.ShouldBeAssignableTo<StringGreaterThan>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StringGreaterThan) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StringGreaterThan_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            StringGreaterThan instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CompareValues) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<string>();
            var pRightValue = this.CreateType<string>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_stringGreaterThanInstanceFixture, parametersOfCompareValues);
            var result2 = this.GetResultOfMethod<bool>(MethodCompareValues, parametersOfCompareValues, methodCompareValuesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompareValues.ShouldNotBeNull();
            parametersOfCompareValues.Length.ShouldBe(2);
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<string>();
            var pRightValue = this.CreateType<string>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_stringGreaterThanInstanceFixture, out exception1, parametersOfCompareValues);
            var result2 = this.GetResultOfMethod<bool>(MethodCompareValues, parametersOfCompareValues, methodCompareValuesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCompareValues.ShouldNotBeNull();
            parametersOfCompareValues.Length.ShouldBe(2);
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<string>();
            var pRightValue = this.CreateType<string>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stringGreaterThanInstanceFixture, parametersOfCompareValues);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCompareValues.ShouldNotBeNull();
            parametersOfCompareValues.Length.ShouldBe(2);
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<string>();
            var pRightValue = this.CreateType<string>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCompareValues, parametersOfCompareValues, methodCompareValuesParametersTypes);

            // Assert
            parametersOfCompareValues.ShouldNotBeNull();
            parametersOfCompareValues.Length.ShouldBe(2);
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompareValues, methodCompareValuesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCompareValues, methodCompareValuesParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCompareValuesParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCompareValues, methodCompareValuesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCompareValuesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CompareValues) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StringGreaterThan_CompareValues_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, 0);
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