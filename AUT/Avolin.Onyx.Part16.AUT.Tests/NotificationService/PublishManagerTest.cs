using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishManager" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PublishManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="PublishManagerNonPublicTypeName" />) using
        ///     Using a public type <see cref="IPublishEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public PublishManagerTest() : base(publicType: typeof(IPublishEvent), classNameWithNamespace: PublishManagerNonPublicTypeName)
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

        private Type _publishManagerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string PublishManagerNonPublicTypeName = "NotificationService.PublishManager";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _publishManagerInstance;
        private object _publishManagerInstanceFixture;

        #region General Initializer : Class (PublishManager) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="PublishManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _publishManagerInstanceFixture = this.CreateNonPublicType(PublishManagerNonPublicTypeName);
            _publishManagerInstance = _publishManagerInstanceFixture;
            CurrentInstance = _publishManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PublishManager) Initializer

        #region Methods

        private const string MethodProcessEventData = "ProcessEventData";
        private const string MethodAddApplicationNameToContext = "AddApplicationNameToContext";
        private const string MethodIsValidChangeType = "IsValidChangeType";
        private const string MethodIsValidEventData = "IsValidEventData";
        private const string MethodProcessBaseEvent = "ProcessBaseEvent";
        private const string MethodVerifyChangeFields = "VerifyChangeFields";
        private const string MethodGetBaseEvents = "GetBaseEvents";
        private const string MethodFilterEvents = "FilterEvents";
        private const string MethodPublishNotification = "PublishNotification";
        private const string MethodGetForwardedUsers = "GetForwardedUsers";
        private const string MethodBeginPublish = "BeginPublish";
        private const string MethodPushNotification = "PushNotification";
        private const string MethodIsValidObjectName = "IsValidObjectName";
        private const string MethodIsValidConnectionString = "IsValidConnectionString";
        private const string MethodIsValidMethodName = "IsValidMethodName";
        private const string MethodIsValidSiteId = "IsValidSiteId";
        private const string MethodIsValidApplicationName = "IsValidApplicationName";

        #endregion

        #region Fields

        private const string Field_EventId = "_EventId";
        private const string FieldiLog = "iLog";
        private const string Fielddb = "db";
        private const string FieldxmlEventData = "xmlEventData";
        private const string FieldchangeType = "changeType";
        private const string FieldsiteID = "siteID";
        private const string FieldappName = "appName";
        private const string FieldconnectionString = "connectionString";
        private const string FieldobjectName = "objectName";
        private const string FieldmethodName = "methodName";
        private const string FielddisposedValue = "disposedValue";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (PublishManager)

        #region General Initializer : Class (PublishManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PublishManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcessEventData, 0)]
        [TestCase(MethodAddApplicationNameToContext, 0)]
        [TestCase(MethodIsValidChangeType, 0)]
        [TestCase(MethodIsValidEventData, 0)]
        [TestCase(MethodProcessBaseEvent, 0)]
        [TestCase(MethodVerifyChangeFields, 0)]
        [TestCase(MethodGetBaseEvents, 0)]
        [TestCase(MethodFilterEvents, 0)]
        [TestCase(MethodPublishNotification, 0)]
        [TestCase(MethodGetForwardedUsers, 0)]
        [TestCase(MethodBeginPublish, 0)]
        [TestCase(MethodPushNotification, 0)]
        [TestCase(MethodIsValidObjectName, 0)]
        [TestCase(MethodIsValidConnectionString, 0)]
        [TestCase(MethodIsValidMethodName, 0)]
        [TestCase(MethodIsValidSiteId, 0)]
        [TestCase(MethodIsValidApplicationName, 0)]
        [Category("AUT Explore")]
        public void AUT_PublishManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PublishManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PublishManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PublishManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_EventId)]
        [TestCase(FieldiLog)]
        [TestCase(Fielddb)]
        [TestCase(FieldxmlEventData)]
        [TestCase(FieldchangeType)]
        [TestCase(FieldsiteID)]
        [TestCase(FieldappName)]
        [TestCase(FieldconnectionString)]
        [TestCase(FieldobjectName)]
        [TestCase(FieldmethodName)]
        [Category("AUT Fields")]
        public void AUT_PublishManager_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (PublishManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PublishManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}