using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part14.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer.IntegerOperator" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IntegerOperatorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IntegerOperator" />)
        /// </summary>
        public IntegerOperatorTest() : base(typeof(IntegerOperator))
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

        #region General Initializer : Class (IntegerOperator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _integerOperatorInstanceType;
        private IntegerOperator _integerOperatorInstance;
        private IntegerOperator _integerOperatorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IntegerOperator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _integerOperatorInstanceType = typeof(IntegerOperator);
            _integerOperatorInstanceFixture = this.Create<IntegerOperator>(false);
            _integerOperatorInstance = _integerOperatorInstanceFixture ?? this.Create<IntegerOperator>(true);
            CurrentInstance = _integerOperatorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IntegerOperator) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";
        private const string MethodApplyOperator = "ApplyOperator";
        private const string MethodEvaluateInteger = "EvaluateInteger";

        #endregion

        #endregion

        #region General Initializer : Class (IntegerOperator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IntegerOperator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IntegerOperator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IntegerOperator)

        #region General Initializer : Class (IntegerOperator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IntegerOperator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        [TestCase(MethodApplyOperator, 0)]
        [TestCase(MethodEvaluateInteger, 0)]
        public void AUT_IntegerOperator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (IntegerOperator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IntegerOperator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntegerOperator_Is_Instance_Present_Test()
        {
            // Assert
            _integerOperatorInstanceType.ShouldNotBeNull();
            _integerOperatorInstance.ShouldNotBeNull();
            _integerOperatorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IntegerOperator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IntegerOperator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntegerOperator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _integerOperatorInstance.ShouldBeAssignableTo<IntegerOperator>();
            _integerOperatorInstanceFixture.ShouldBeAssignableTo<IntegerOperator>();
            CurrentInstance.ShouldBeAssignableTo<IntegerOperator>();
        }

        #endregion

        #endregion

        #endregion
    }
}