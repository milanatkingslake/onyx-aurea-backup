using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date.DateCompare" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Date"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DateCompareTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DateCompare" />)
        /// </summary>
        public DateCompareTest() : base(typeof(DateCompare))
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

        #region General Initializer : Class (DateCompare) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dateCompareInstanceType;
        private DateCompare _dateCompareInstance;
        private DateCompare _dateCompareInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DateCompare" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dateCompareInstanceType = typeof(DateCompare);
            _dateCompareInstanceFixture = this.Create<DateCompare>(false);
            _dateCompareInstance = _dateCompareInstanceFixture ?? this.Create<DateCompare>(true);
            CurrentInstance = _dateCompareInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DateCompare) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";

        #endregion

        #endregion

        #region General Initializer : Class (DateCompare) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DateCompare" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DateCompare_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DateCompare)

        #region General Initializer : Class (DateCompare) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DateCompare" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        public void AUT_DateCompare_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (DateCompare) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DateCompare" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateCompare_Is_Instance_Present_Test()
        {
            // Assert
            _dateCompareInstanceType.ShouldNotBeNull();
            _dateCompareInstance.ShouldNotBeNull();
            _dateCompareInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DateCompare) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DateCompare" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_DateCompare_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dateCompareInstance.ShouldBeAssignableTo<DateCompare>();
            _dateCompareInstanceFixture.ShouldBeAssignableTo<DateCompare>();
            CurrentInstance.ShouldBeAssignableTo<DateCompare>();
        }

        #endregion

        #endregion

        #endregion
    }
}