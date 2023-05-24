using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.OnyxSettings" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSettingsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxSettingsNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxSettingsTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: OnyxSettingsNonPublicTypeName)
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

        private Type _onyxSettingsInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxSettingsNonPublicTypeName = "NotificationService.Administration.OnyxSettings";

        #region General Initializer : Class (OnyxSettings) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxSettings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxSettings) Initializer

        #region Fields

        private const string FieldPoolingWaitTime = "PoolingWaitTime";
        private const string FieldImmediateDispatchBatchCount = "ImmediateDispatchBatchCount";
        private const string FieldCallendarSyncBatchCount = "CallendarSyncBatchCount";
        private const string FieldImmediateNotificationDeliveryTypeID = "ImmediateNotificationDeliveryTypeID";
        private const string FieldSummaryNotificationDeliveryTypeID = "SummaryNotificationDeliveryTypeID";
        private const string FieldLanguageCode = "LanguageCode";
        private const string FieldStatus_New = "Status_New";
        private const string FieldStatus_Processed = "Status_Processed";
        private const string FieldStatus_Error = "Status_Error";
        private const string FieldStatus_Invalid = "Status_Invalid";
        private const string FieldStatus_Partial = "Status_Partial";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxSettings)

        #region General Initializer : Class (OnyxSettings) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldPoolingWaitTime)]
        [TestCase(FieldImmediateDispatchBatchCount)]
        [TestCase(FieldCallendarSyncBatchCount)]
        [TestCase(FieldImmediateNotificationDeliveryTypeID)]
        [TestCase(FieldSummaryNotificationDeliveryTypeID)]
        [TestCase(FieldLanguageCode)]
        [TestCase(FieldStatus_New)]
        [TestCase(FieldStatus_Processed)]
        [TestCase(FieldStatus_Error)]
        [TestCase(FieldStatus_Invalid)]
        [TestCase(FieldStatus_Partial)]
        [Category("AUT Fields")]
        public void AUT_OnyxSettings_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxSettings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxSettings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxSettings_Explore_Reflection_Based_NonListed_Fields_Test()
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