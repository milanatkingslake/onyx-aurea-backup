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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.MobileBookmark" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\MobileBookmark.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MobileBookmarkTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="MobileBookmarkNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public MobileBookmarkTest() : base(publicType: typeof(Common), classNameWithNamespace: MobileBookmarkNonPublicTypeName)
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

        private Type _mobileBookmarkInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string MobileBookmarkNonPublicTypeName = "CmService.Service.MobileBookmark";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _mobileBookmarkInstance;
        private object _mobileBookmarkInstanceFixture;

        #region General Initializer : Class (MobileBookmark) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="MobileBookmark" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mobileBookmarkInstanceFixture = this.CreateNonPublicType(MobileBookmarkNonPublicTypeName);
            _mobileBookmarkInstance = _mobileBookmarkInstanceFixture;
            CurrentInstance = _mobileBookmarkInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MobileBookmark) Initializer

        #region Methods

        private const string MethodRunQuery = "RunQuery";
        private const string MethodGetCount = "GetCount";
        private const string MethodRemoveMobileBookMark = "RemoveMobileBookMark";
        private const string MethodCreateMobileBookMark = "CreateMobileBookMark";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (MobileBookmark)

        #region General Initializer : Class (MobileBookmark) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="MobileBookmark" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRunQuery, 0)]
        [TestCase(MethodGetCount, 0)]
        [TestCase(MethodRemoveMobileBookMark, 0)]
        [TestCase(MethodCreateMobileBookMark, 0)]
        [Category("AUT Explore")]
        public void AUT_MobileBookmark_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (MobileBookmark) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MobileBookmark" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MobileBookmark_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}