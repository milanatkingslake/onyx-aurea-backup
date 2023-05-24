using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.ServiceManager" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ServiceManagerNonPublicTypeName" />) using
        ///     Using a public type <see cref="IPublishEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public ServiceManagerTest() : base(publicType: typeof(IPublishEvent), classNameWithNamespace: ServiceManagerNonPublicTypeName)
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

        private Type _serviceManagerInstanceType;
        
        private const string ServiceManagerNonPublicTypeName = "NotificationService.ServiceManager";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _serviceManagerInstance;
        private object _serviceManagerInstanceFixture;

        #region General Initializer : Class (ServiceManager) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ServiceManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceManagerInstanceFixture = this.CreateNonPublicType(ServiceManagerNonPublicTypeName);
            _serviceManagerInstance = _serviceManagerInstanceFixture;
            CurrentInstance = _serviceManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceManager) Initializer

        #region Methods

        private const string MethodPublish = "Publish";
        private const string MethodGetStatus = "GetStatus";
        private const string MethodGenericPublish = "GenericPublish";
        private const string MethodRetrieveAvailableNotification = "RetrieveAvailableNotification";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetNotification = "GetNotification";
        private const string MethodUpdateSubscription = "UpdateSubscription";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodSaveSubscription = "SaveSubscription";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #endregion
        
        #endregion

        #endregion
    }
}