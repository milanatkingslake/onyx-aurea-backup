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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishingHelper" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PublishingHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="PublishingHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="IPublishEvent" /> to
        ///     create a non-public type.
        /// </summary>
        public PublishingHelperTest() : base(publicType: typeof(IPublishEvent), classNameWithNamespace: PublishingHelperNonPublicTypeName)
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

        private Type _publishingHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string PublishingHelperNonPublicTypeName = "NotificationService.PublishingHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _publishingHelperInstance;
        private object _publishingHelperInstanceFixture;

        #region General Initializer : Class (PublishingHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="PublishingHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _publishingHelperInstanceFixture = this.CreateNonPublicType(PublishingHelperNonPublicTypeName);
            _publishingHelperInstance = _publishingHelperInstanceFixture;
            CurrentInstance = _publishingHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PublishingHelper) Initializer

        #region Methods

        private const string MethodPublish = "Publish";
        private const string MethodAgentCompletedEventHandler = "AgentCompletedEventHandler";
        private const string MethodAgentUnhandledExceptionHandler = "AgentUnhandledExceptionHandler";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (PublishingHelper)

        #region General Initializer : Class (PublishingHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PublishingHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPublish, 0)]
        [TestCase(MethodAgentCompletedEventHandler, 0)]
        [TestCase(MethodAgentUnhandledExceptionHandler, 0)]
        [Category("AUT Explore")]
        public void AUT_PublishingHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PublishingHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PublishingHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishingHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (PublishingHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishingHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_PublishingHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (PublishingHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PublishingHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishingHelper_Explore_Reflection_Based_NonListed_Fields_Test()
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