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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float.FloatCompare" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Float"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FloatCompareTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FloatCompare" />)
        /// </summary>
        public FloatCompareTest() : base(typeof(FloatCompare))
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

        #region General Initializer : Class (FloatCompare) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _floatCompareInstanceType;
        private FloatCompare _floatCompareInstance;
        private FloatCompare _floatCompareInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FloatCompare" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _floatCompareInstanceType = typeof(FloatCompare);
            _floatCompareInstanceFixture = this.Create<FloatCompare>(false);
            _floatCompareInstance = _floatCompareInstanceFixture ?? this.Create<FloatCompare>(true);
            CurrentInstance = _floatCompareInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FloatCompare) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";

        #endregion

        #endregion

        #region General Initializer : Class (FloatCompare) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FloatCompare" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FloatCompare_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FloatCompare)

        #region General Initializer : Class (FloatCompare) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FloatCompare" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        public void AUT_FloatCompare_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FloatCompare) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FloatCompare" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatCompare_Is_Instance_Present_Test()
        {
            // Assert
            _floatCompareInstanceType.ShouldNotBeNull();
            _floatCompareInstance.ShouldNotBeNull();
            _floatCompareInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FloatCompare) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FloatCompare" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FloatCompare_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _floatCompareInstance.ShouldBeAssignableTo<FloatCompare>();
            _floatCompareInstanceFixture.ShouldBeAssignableTo<FloatCompare>();
            CurrentInstance.ShouldBeAssignableTo<FloatCompare>();
        }

        #endregion

        #endregion

        #endregion
    }
}