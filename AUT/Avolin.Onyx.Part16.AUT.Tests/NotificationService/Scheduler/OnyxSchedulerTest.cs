using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Scheduler;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Scheduler
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Scheduler.OnyxScheduler" />)
    ///     and namespace <see cref="NotificationService.Scheduler"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxSchedulerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxSchedulerNonPublicTypeName" />) using
        ///     Using a public type <see cref="Administration" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxSchedulerTest() : base(publicType: typeof(global::NotificationService.Scheduler.Administration), classNameWithNamespace: OnyxSchedulerNonPublicTypeName)
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

        private Type _onyxSchedulerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxSchedulerNonPublicTypeName = "NotificationService.Scheduler.OnyxScheduler";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxSchedulerInstance;
        private object _onyxSchedulerInstanceFixture;

        #region General Initializer : Class (OnyxScheduler) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxScheduler" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxSchedulerInstanceFixture = this.CreateNonPublicType(OnyxSchedulerNonPublicTypeName);
            _onyxSchedulerInstance = _onyxSchedulerInstanceFixture;
            CurrentInstance = _onyxSchedulerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxScheduler) Initializer

        #region Methods

        private const string MethodUpdateXML = "UpdateXML";
        private const string MethodClean = "Clean";

        #endregion

        #region Fields

        private const string Field_CallendarSync = "_CallendarSync";
        private const string FieldTRIGGERS_CONFIGURATION_APPKEY = "TRIGGERS_CONFIGURATION_APPKEY";
        private const string FieldtriggersConfigFilePath = "triggersConfigFilePath";
        private const string FieldIsFirstStart = "IsFirstStart";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxScheduler)

        #region General Initializer : Class (OnyxScheduler) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxScheduler" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodUpdateXML, 0)]
        [TestCase(MethodClean, 0)]
        [Category("AUT Explore")]
        public void AUT_OnyxScheduler_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxScheduler) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxScheduler" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxScheduler_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxScheduler) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxScheduler" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_CallendarSync)]
        [TestCase(FieldTRIGGERS_CONFIGURATION_APPKEY)]
        [TestCase(FieldtriggersConfigFilePath)]
        [TestCase(FieldIsFirstStart)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxScheduler_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxScheduler) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxScheduler" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxScheduler_Explore_Reflection_Based_NonListed_Fields_Test()
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