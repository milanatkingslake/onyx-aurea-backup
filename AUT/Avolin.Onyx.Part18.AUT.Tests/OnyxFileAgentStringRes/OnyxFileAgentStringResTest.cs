using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxFileAgentStringRes
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxFileAgentStringRes.OnyxFileAgentStringRes" />)
    ///     and namespace <see cref="OnyxFileAgentStringRes"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxFileAgentStringResTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxFileAgentStringRes.OnyxFileAgentStringRes" />)
        /// </summary>
        public OnyxFileAgentStringResTest() : base(typeof(global::OnyxFileAgentStringRes.OnyxFileAgentStringRes))
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

        #region General Initializer : Class (OnyxFileAgentStringRes) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxFileAgentStringResInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxFileAgentStringRes.OnyxFileAgentStringRes" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxFileAgentStringResInstanceType = typeof(global::OnyxFileAgentStringRes.OnyxFileAgentStringRes);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxFileAgentStringRes) Initializer

        #region Methods

        private const string MethodGetResource = "GetResource";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxFileAgentStringRes)

        #region General Initializer : Class (OnyxFileAgentStringRes) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxFileAgentStringRes.OnyxFileAgentStringRes" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetResource, 0)]
        public void AUT_OnyxFileAgentStringRes_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #endregion
    }
}