using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.FloatSubtract" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FloatSubtractTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FloatSubtract" />)
        /// </summary>
        public FloatSubtractTest() : base(typeof(FloatSubtract))
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

        #region General Initializer : Class (FloatSubtract) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _floatSubtractInstanceType;
        private FloatSubtract _floatSubtractInstance;
        private FloatSubtract _floatSubtractInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FloatSubtract" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _floatSubtractInstanceType = typeof(FloatSubtract);
            _floatSubtractInstanceFixture = this.Create<FloatSubtract>(false);
            _floatSubtractInstance = _floatSubtractInstanceFixture ?? this.Create<FloatSubtract>(true);
            CurrentInstance = _floatSubtractInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FloatSubtract) Initializer

        #region Methods

        private const string MethodApplyOperator = "ApplyOperator";

        #endregion

        #endregion

        #region General Initializer : Class (FloatSubtract) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FloatSubtract" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FloatSubtract_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FloatSubtract)

        #region General Initializer : Class (FloatSubtract) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FloatSubtract" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodApplyOperator, 0)]
        public void AUT_FloatSubtract_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FloatSubtract) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FloatSubtract" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatSubtract_Is_Instance_Present_Test()
        {
            // Assert
            _floatSubtractInstanceType.ShouldNotBeNull();
            _floatSubtractInstance.ShouldNotBeNull();
            _floatSubtractInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FloatSubtract) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FloatSubtract" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatSubtract_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _floatSubtractInstance.ShouldBeAssignableTo<FloatSubtract>();
            _floatSubtractInstanceFixture.ShouldBeAssignableTo<FloatSubtract>();
            CurrentInstance.ShouldBeAssignableTo<FloatSubtract>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FloatSubtract) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FloatSubtract_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FloatSubtract instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ApplyOperator) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var pLeftValue = this.CreateType<double>();
            var pRightValue = this.CreateType<double>();
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };
            object[] parametersOfApplyOperator = { pLeftValue, pRightValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyOperator, methodApplyOperatorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floatSubtractInstanceFixture, parametersOfApplyOperator);
            var result2 = this.GetResultOfMethod<double>(MethodApplyOperator, parametersOfApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfApplyOperator.ShouldNotBeNull();
            parametersOfApplyOperator.Length.ShouldBe(2);
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var pLeftValue = this.CreateType<double>();
            var pRightValue = this.CreateType<double>();
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };
            object[] parametersOfApplyOperator = { pLeftValue, pRightValue };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyOperator, methodApplyOperatorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<double>(_floatSubtractInstanceFixture, out exception1, parametersOfApplyOperator);
            var result2 = this.GetResultOfMethod<double>(MethodApplyOperator, parametersOfApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfApplyOperator.ShouldNotBeNull();
            parametersOfApplyOperator.Length.ShouldBe(2);
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var pLeftValue = this.CreateType<double>();
            var pRightValue = this.CreateType<double>();
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };
            object[] parametersOfApplyOperator = { pLeftValue, pRightValue };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyOperator, methodApplyOperatorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_floatSubtractInstanceFixture, parametersOfApplyOperator);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyOperator.ShouldNotBeNull();
            parametersOfApplyOperator.Length.ShouldBe(2);
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var pLeftValue = this.CreateType<double>();
            var pRightValue = this.CreateType<double>();
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };
            object[] parametersOfApplyOperator = { pLeftValue, pRightValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<double>(MethodApplyOperator, parametersOfApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            parametersOfApplyOperator.ShouldNotBeNull();
            parametersOfApplyOperator.Length.ShouldBe(2);
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodApplyOperatorParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var methodApplyOperatorParametersTypes = new Type[] { typeof(double), typeof(double) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyOperator, methodApplyOperatorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyOperatorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyOperator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ApplyOperator) (Return Type : double) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FloatSubtract_ApplyOperator_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyOperator, 0);
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