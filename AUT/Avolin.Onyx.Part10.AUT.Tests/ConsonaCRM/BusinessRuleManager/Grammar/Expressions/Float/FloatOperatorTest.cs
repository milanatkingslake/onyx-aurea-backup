using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.FloatOperator" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FloatOperatorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FloatOperator" />)
        /// </summary>
        public FloatOperatorTest() : base(typeof(FloatOperator))
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

        #region General Initializer : Class (FloatOperator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _floatOperatorInstanceType;
        private FloatOperator _floatOperatorInstance;
        private FloatOperator _floatOperatorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FloatOperator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _floatOperatorInstanceType = typeof(FloatOperator);
            _floatOperatorInstanceFixture = this.Create<FloatOperator>(false);
            _floatOperatorInstance = _floatOperatorInstanceFixture ?? this.Create<FloatOperator>(true);
            CurrentInstance = _floatOperatorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FloatOperator) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";
        private const string MethodApplyOperator = "ApplyOperator";
        private const string MethodEvaluateFloat = "EvaluateFloat";

        #endregion

        #endregion

        #region General Initializer : Class (FloatOperator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FloatOperator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FloatOperator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FloatOperator)

        #region General Initializer : Class (FloatOperator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FloatOperator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        [TestCase(MethodApplyOperator, 0)]
        [TestCase(MethodEvaluateFloat, 0)]
        public void AUT_FloatOperator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FloatOperator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FloatOperator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatOperator_Is_Instance_Present_Test()
        {
            // Assert
            _floatOperatorInstanceType.ShouldNotBeNull();
            _floatOperatorInstance.ShouldNotBeNull();
            _floatOperatorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FloatOperator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FloatOperator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatOperator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _floatOperatorInstance.ShouldBeAssignableTo<FloatOperator>();
            _floatOperatorInstanceFixture.ShouldBeAssignableTo<FloatOperator>();
            CurrentInstance.ShouldBeAssignableTo<FloatOperator>();
        }

        #endregion

        #endregion

        #endregion
    }
}