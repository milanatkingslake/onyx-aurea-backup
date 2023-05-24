using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.WindowsService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.WindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.WindowsService.NotificationWindowsService" />)
    ///     and namespace <see cref="NotificationService.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    [Ignore("Candidate for hanging of Jenkins builds")]
    public partial class NotificationWindowsServiceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="NotificationWindowsServiceNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public NotificationWindowsServiceTest() : base(publicType: typeof(Constants), classNameWithNamespace: NotificationWindowsServiceNonPublicTypeName)
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

        private Type _notificationWindowsServiceInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string NotificationWindowsServiceNonPublicTypeName = "NotificationService.WindowsService.NotificationWindowsService";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _notificationWindowsServiceInstance;
        private object _notificationWindowsServiceInstanceFixture;

        #region General Initializer : Class (NotificationWindowsService) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="NotificationWindowsService" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationWindowsServiceInstanceFixture = this.CreateNonPublicType(NotificationWindowsServiceNonPublicTypeName);
            _notificationWindowsServiceInstance = _notificationWindowsServiceInstanceFixture;
            CurrentInstance = _notificationWindowsServiceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationWindowsService) Initializer

        #region Methods

        private const string MethodOnStart = "OnStart";
        private const string MethodOnStop = "OnStop";

        #endregion

        #region Fields

        private const string Fieldhost = "host";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationWindowsService)

        #region General Initializer : Class (NotificationWindowsService) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NotificationWindowsService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(MethodOnStart, 0)]
        [TestCase(MethodOnStop, 0)]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_NotificationWindowsService_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NotificationWindowsService) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationWindowsService" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_NotificationWindowsService_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NotificationWindowsService) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationWindowsService" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(Fieldhost)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_NotificationWindowsService_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (NotificationWindowsService) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationWindowsService" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_NotificationWindowsService_Explore_Reflection_Based_NonListed_Fields_Test()
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