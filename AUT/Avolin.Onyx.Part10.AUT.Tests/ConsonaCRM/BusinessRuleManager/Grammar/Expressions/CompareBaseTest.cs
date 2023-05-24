using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Interfaces;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.CompareBase<IGenericArgumentSample>" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CompareBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CompareBase<IGenericArgumentSample>" />)
        /// </summary>
        public CompareBaseTest() : base(typeof(CompareBase<IGenericArgumentSample>))
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

        #region General Initializer : Class (CompareBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _compareBaseInstanceType;
        private CompareBase<IGenericArgumentSample> _compareBaseInstance;
        private CompareBase<IGenericArgumentSample> _compareBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CompareBase<IGenericArgumentSample>" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _compareBaseInstanceType = typeof(CompareBase<IGenericArgumentSample>);
            _compareBaseInstanceFixture = this.Create<CompareBase<IGenericArgumentSample>>(false);
            _compareBaseInstance = _compareBaseInstanceFixture ?? this.Create<CompareBase<IGenericArgumentSample>>(true);
            CurrentInstance = _compareBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CompareBase) Initializer

        #region Methods

        private const string MethodEvaluateBoolean = "EvaluateBoolean";
        private const string MethodCompareValues = "CompareValues";

        #endregion

        #endregion

        #region General Initializer : Class (CompareBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CompareBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CompareBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CompareBase)

        #region General Initializer : Class (CompareBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CompareBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEvaluateBoolean, 0)]
        [TestCase(MethodCompareValues, 0)]
        public void AUT_CompareBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CompareBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CompareBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompareBase_Is_Instance_Present_Test()
        {
            // Assert
            _compareBaseInstanceType.ShouldNotBeNull();
            _compareBaseInstance.ShouldNotBeNull();
            _compareBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CompareBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CompareBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompareBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _compareBaseInstance.ShouldBeAssignableTo<CompareBase<IGenericArgumentSample>>();
            _compareBaseInstanceFixture.ShouldBeAssignableTo<CompareBase<IGenericArgumentSample>>();
            CurrentInstance.ShouldBeAssignableTo<CompareBase<IGenericArgumentSample>>();
        }

        #endregion

        #endregion

        #endregion
    }
}