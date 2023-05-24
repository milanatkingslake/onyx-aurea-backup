using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.SubscribeNotification" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\SubscribeNotification.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SubscribeNotificationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="SubscribeNotificationNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public SubscribeNotificationTest() : base(publicType: typeof(Common), classNameWithNamespace: SubscribeNotificationNonPublicTypeName)
        { }

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

        private Type _subscribeNotificationInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string SubscribeNotificationNonPublicTypeName = "CmService.Service.SubscribeNotification";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _subscribeNotificationInstance;
        private object _subscribeNotificationInstanceFixture;

        #region General Initializer : Class (SubscribeNotification) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="SubscribeNotification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscribeNotificationInstanceFixture = this.CreateNonPublicType(SubscribeNotificationNonPublicTypeName);
            _subscribeNotificationInstance = _subscribeNotificationInstanceFixture;
            CurrentInstance = _subscribeNotificationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscribeNotification) Initializer

        #region Methods

        private const string MethodGetAvailableNotification = "GetAvailableNotification";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetNotification = "GetNotification";
        private const string MethodSaveSubscription = "SaveSubscription";
        private const string MethodUpdateSubscription = "UpdateSubscription";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodPublishSubscription = "PublishSubscription";
        private const string MethodLBOPublisher = "LBOPublisher";
        private const string MethodPublishGenericEvent = "PublishGenericEvent";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscribeNotification)

        #region General Initializer : Class (SubscribeNotification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetAvailableNotification, 0)]
        [TestCase(MethodGetSubscribedNotification, 0)]
        [TestCase(MethodGetUsers, 0)]
        [TestCase(MethodGetNotification, 0)]
        [TestCase(MethodSaveSubscription, 0)]
        [TestCase(MethodUpdateSubscription, 0)]
        [TestCase(MethodDeleteSubscription, 0)]
        [TestCase(MethodPublishSubscription, 0)]
        [TestCase(MethodLBOPublisher, 0)]
        [TestCase(MethodPublishGenericEvent, 0)]
        [TestCase(MethodCheckONSService, 0)]
        [Category("AUT Explore")]
        public void AUT_SubscribeNotification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SubscribeNotification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribeNotification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}