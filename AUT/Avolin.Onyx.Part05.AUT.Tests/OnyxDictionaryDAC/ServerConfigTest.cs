using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxDictionaryDAC;
using Shouldly;

namespace Avolin.Onyx.Part05.AUT.Tests.OnyxDictionaryDAC
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxDictionaryDAC.ServerConfig" />)
    ///     and namespace <see cref="OnyxDictionaryDAC"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServerConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ServerConfigNonPublicTypeName" />) using
        ///     Using a public type <see cref="Dictionary" /> to
        ///     create a non-public type.
        /// </summary>
        public ServerConfigTest() : base(publicType: typeof(Dictionary), classNameWithNamespace: ServerConfigNonPublicTypeName)
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

        private Type _serverConfigInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ServerConfigNonPublicTypeName = "OnyxDictionaryDAC.ServerConfig";

        #region General Initializer : Class (ServerConfig) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ServerConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServerConfig) Initializer

        #region Methods

        private const string MethodGetServerConfigString = "GetServerConfigString";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ServerConfig)

        #region General Initializer : Class (ServerConfig) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ServerConfig" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetServerConfigString, 0)]
        [Category("AUT Explore")]
        public void AUT_ServerConfig_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ServerConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServerConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServerConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}