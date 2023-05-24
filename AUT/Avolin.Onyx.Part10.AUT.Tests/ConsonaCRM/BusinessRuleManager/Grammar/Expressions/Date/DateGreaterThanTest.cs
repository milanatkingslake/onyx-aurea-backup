using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date.DateGreaterThan" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DateGreaterThanTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DateGreaterThan" />)
        /// </summary>
        public DateGreaterThanTest() : base(typeof(DateGreaterThan))
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

        #region General Initializer : Class (DateGreaterThan) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dateGreaterThanInstanceType;
        private DateGreaterThan _dateGreaterThanInstance;
        private DateGreaterThan _dateGreaterThanInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DateGreaterThan" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dateGreaterThanInstanceType = typeof(DateGreaterThan);
            _dateGreaterThanInstanceFixture = this.Create<DateGreaterThan>(false);
            _dateGreaterThanInstance = _dateGreaterThanInstanceFixture ?? this.Create<DateGreaterThan>(true);
            CurrentInstance = _dateGreaterThanInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DateGreaterThan) Initializer

        #region Methods

        private const string MethodCompareValues = "CompareValues";

        #endregion

        #endregion

        #region General Initializer : Class (DateGreaterThan) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DateGreaterThan" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DateGreaterThan_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DateGreaterThan)

        #region General Initializer : Class (DateGreaterThan) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DateGreaterThan" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCompareValues, 0)]
        public void AUT_DateGreaterThan_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DateGreaterThan) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DateGreaterThan" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateGreaterThan_Is_Instance_Present_Test()
        {
            // Assert
            _dateGreaterThanInstanceType.ShouldNotBeNull();
            _dateGreaterThanInstance.ShouldNotBeNull();
            _dateGreaterThanInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DateGreaterThan) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DateGreaterThan" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateGreaterThan_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dateGreaterThanInstance.ShouldBeAssignableTo<DateGreaterThan>();
            _dateGreaterThanInstanceFixture.ShouldBeAssignableTo<DateGreaterThan>();
            CurrentInstance.ShouldBeAssignableTo<DateGreaterThan>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DateGreaterThan) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_DateGreaterThan_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DateGreaterThan instance = null;

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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<DateTime>();
            var pRightValue = this.CreateType<DateTime>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dateGreaterThanInstanceFixture, parametersOfCompareValues);
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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<DateTime>();
            var pRightValue = this.CreateType<DateTime>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_dateGreaterThanInstanceFixture, out exception1, parametersOfCompareValues);
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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<DateTime>();
            var pRightValue = this.CreateType<DateTime>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };
            object[] parametersOfCompareValues = { pLeftValue, pRightValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCompareValues, methodCompareValuesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_dateGreaterThanInstanceFixture, parametersOfCompareValues);

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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var pLeftValue = this.CreateType<DateTime>();
            var pRightValue = this.CreateType<DateTime>();
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };
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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };

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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };

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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCompareValues);
            var methodCompareValuesParametersTypes = new Type[] { typeof(DateTime), typeof(DateTime) };
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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
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
        public void AUT_DateGreaterThan_CompareValues_Method_Call_Parameters_Count_Verification_Test()
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