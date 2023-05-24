using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Scheduler;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Scheduler
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Scheduler.OnyxSettings" />)
    ///     and namespace <see cref="NotificationService.Scheduler"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSettingsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxSettingsNonPublicTypeName" />) using
        ///     Using a public type <see cref="Administration" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxSettingsTest() : base(publicType: typeof(global::NotificationService.Scheduler.Administration), classNameWithNamespace: OnyxSettingsNonPublicTypeName)
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
        private const string OnyxSettingsNonPublicTypeName = "NotificationService.Scheduler.OnyxSettings";

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

        private const string FieldNonStopTrigger = "NonStopTrigger";
        private const string FieldONSHeartBeatTime = "ONSHeartBeatTime";
        private const string FieldRetryONSWaitTime = "RetryONSWaitTime";
        private const string FieldConfigRefreshTime = "ConfigRefreshTime";
        private const string FieldMinutesInDay = "MinutesInDay";

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
        [TestCase(FieldNonStopTrigger)]
        [TestCase(FieldONSHeartBeatTime)]
        [TestCase(FieldRetryONSWaitTime)]
        [TestCase(FieldConfigRefreshTime)]
        [TestCase(FieldMinutesInDay)]
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