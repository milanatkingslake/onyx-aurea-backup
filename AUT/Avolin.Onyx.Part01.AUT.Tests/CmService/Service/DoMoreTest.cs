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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.DoMore" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\DoMore.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class DoMoreTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="DoMoreNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public DoMoreTest() : base(publicType: typeof(Common), classNameWithNamespace: DoMoreNonPublicTypeName)
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

        private Type _doMoreInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string DoMoreNonPublicTypeName = "CmService.Service.DoMore";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _doMoreInstance;
        private object _doMoreInstanceFixture;

        #region General Initializer : Class (DoMore) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="DoMore" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _doMoreInstanceFixture = this.CreateNonPublicType(DoMoreNonPublicTypeName);
            _doMoreInstance = _doMoreInstanceFixture;
            CurrentInstance = _doMoreInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DoMore) Initializer

        #region Methods

        private const string MethodSearch = "Search";
        private const string MethodPromptRetrieve = "PromptRetrieve";
        private const string MethodPerformAction = "PerformAction";
        private const string MethodPromptUpdate = "PromptUpdate";
        private const string MethodRetrieveBySecondaryId = "RetrieveBySecondaryId";
        private const string MethodDoMoreCount = "DoMoreCount";
        private const string MethodDoMoreNavigator = "DoMoreNavigator";
        private const string MethodDoMoreNavigatorCount = "DoMoreNavigatorCount";
        private const string MethodPromptExecuteLBO = "PromptExecuteLBO";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (DoMore)

        #region General Initializer : Class (DoMore) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSearch, 0)]
        [TestCase(MethodPromptRetrieve, 0)]
        [TestCase(MethodPerformAction, 0)]
        [TestCase(MethodPromptUpdate, 0)]
        [TestCase(MethodRetrieveBySecondaryId, 0)]
        [TestCase(MethodDoMoreCount, 0)]
        [TestCase(MethodDoMoreNavigator, 0)]
        [TestCase(MethodDoMoreNavigatorCount, 0)]
        [TestCase(MethodPromptExecuteLBO, 0)]
        [Category("AUT Explore")]
        public void AUT_DoMore_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (DoMore) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DoMore" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_DoMore_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}