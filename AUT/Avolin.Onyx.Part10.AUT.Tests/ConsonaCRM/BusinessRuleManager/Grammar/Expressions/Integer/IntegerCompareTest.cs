using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer.IntegerCompare" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Integer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IntegerCompareTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IntegerCompare" />)
        /// </summary>
        public IntegerCompareTest() : base(typeof(IntegerCompare))
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

        #region General Initializer : Class (IntegerCompare) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _integerCompareInstanceType;
        private IntegerCompare _integerCompareInstance;
        private IntegerCompare _integerCompareInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IntegerCompare" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _integerCompareInstanceType = typeof(IntegerCompare);
            _integerCompareInstanceFixture = this.Create<IntegerCompare>(false);
            _integerCompareInstance = _integerCompareInstanceFixture ?? this.Create<IntegerCompare>(true);
            CurrentInstance = _integerCompareInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IntegerCompare) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";

        #endregion

        #endregion

        #region General Initializer : Class (IntegerCompare) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IntegerCompare" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IntegerCompare_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IntegerCompare)

        #region General Initializer : Class (IntegerCompare) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IntegerCompare" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        public void AUT_IntegerCompare_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (IntegerCompare) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IntegerCompare" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntegerCompare_Is_Instance_Present_Test()
        {
            // Assert
            _integerCompareInstanceType.ShouldNotBeNull();
            _integerCompareInstance.ShouldNotBeNull();
            _integerCompareInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IntegerCompare) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IntegerCompare" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IntegerCompare_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _integerCompareInstance.ShouldBeAssignableTo<IntegerCompare>();
            _integerCompareInstanceFixture.ShouldBeAssignableTo<IntegerCompare>();
            CurrentInstance.ShouldBeAssignableTo<IntegerCompare>();
        }

        #endregion

        #endregion

        #endregion
    }
}