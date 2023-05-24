using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DetailListView" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\DetailListView.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DetailListViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DetailListViewNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public DetailListViewTest() : base(publicType: typeof(Common), classNameWithNamespace: DetailListViewNonPublicTypeName)
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

        private Type _detailListViewInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string DetailListViewNonPublicTypeName = "CmService.Service.DetailListView";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _detailListViewInstance;
        private object _detailListViewInstanceFixture;

        #region General Initializer : Class (DetailListView) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DetailListView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _detailListViewInstanceFixture = this.CreateNonPublicType(DetailListViewNonPublicTypeName);
            _detailListViewInstance = _detailListViewInstanceFixture;
            CurrentInstance = _detailListViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DetailListView) Initializer

        #region Methods

        private const string MethodGetMetaData = "GetMetaData";
        private const string MethodGetData = "GetData";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (DetailListView)

        #region General Initializer : Class (DetailListView) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMetaData, 0)]
        [TestCase(MethodGetData, 0)]
        [Category("AUT Explore")]
        public void AUT_DetailListView_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DetailListView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DetailListView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DetailListView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}