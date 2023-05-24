using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.SubscriptionWorker" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SubscriptionWorkerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscriptionWorker" />)
        /// </summary>
        public SubscriptionWorkerTest() : base(typeof(SubscriptionWorker))
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

        #region General Initializer : Class (SubscriptionWorker) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscriptionWorkerInstanceType;
        private SubscriptionWorker _subscriptionWorkerInstance;
        private SubscriptionWorker _subscriptionWorkerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscriptionWorker" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscriptionWorkerInstanceType = typeof(SubscriptionWorker);
            _subscriptionWorkerInstanceFixture = this.Create<SubscriptionWorker>(false);
            _subscriptionWorkerInstance = _subscriptionWorkerInstanceFixture ?? this.Create<SubscriptionWorker>(true);
            CurrentInstance = _subscriptionWorkerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscriptionWorker) Initializer

        #region Methods

        #endregion

        #endregion

        #region General Initializer : Class (SubscriptionWorker) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscriptionWorker" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionWorker_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SubscriptionWorker) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SubscriptionWorker" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionWorker_Is_Instance_Present_Test()
        {
            // Assert
            _subscriptionWorkerInstanceType.ShouldNotBeNull();
            _subscriptionWorkerInstance.ShouldNotBeNull();
            _subscriptionWorkerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SubscriptionWorker) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscriptionWorker" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionWorker_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscriptionWorkerInstance.ShouldBeAssignableTo<SubscriptionWorker>();
            _subscriptionWorkerInstanceFixture.ShouldBeAssignableTo<SubscriptionWorker>();
            CurrentInstance.ShouldBeAssignableTo<SubscriptionWorker>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubscriptionWorker) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscriptionWorker_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SubscriptionWorker instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}