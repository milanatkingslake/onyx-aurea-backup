using System;
using System.Diagnostics.CodeAnalysis;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String.StringCompare" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.String"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StringCompareTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StringCompare" />)
        /// </summary>
        public StringCompareTest() : base(typeof(StringCompare))
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

        #region General Initializer : Class (StringCompare) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stringCompareInstanceType;
        private StringCompare _stringCompareInstance;
        private StringCompare _stringCompareInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StringCompare" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stringCompareInstanceType = typeof(StringCompare);
            _stringCompareInstanceFixture = this.Create<StringCompare>(false);
            _stringCompareInstance = _stringCompareInstanceFixture ?? this.Create<StringCompare>(true);
            CurrentInstance = _stringCompareInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StringCompare) Initializer

        #region Methods

        private const string MethodEvaluateValue = "EvaluateValue";

        #endregion

        #endregion

        #region General Initializer : Class (StringCompare) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StringCompare" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StringCompare_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StringCompare)

        #region General Initializer : Class (StringCompare) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StringCompare" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateValue, 0)]
        public void AUT_StringCompare_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (StringCompare) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StringCompare" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringCompare_Is_Instance_Present_Test()
        {
            // Assert
            _stringCompareInstanceType.ShouldNotBeNull();
            _stringCompareInstance.ShouldNotBeNull();
            _stringCompareInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StringCompare) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StringCompare" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StringCompare_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stringCompareInstance.ShouldBeAssignableTo<StringCompare>();
            _stringCompareInstanceFixture.ShouldBeAssignableTo<StringCompare>();
            CurrentInstance.ShouldBeAssignableTo<StringCompare>();
        }

        #endregion

        #endregion

        #endregion
    }
}