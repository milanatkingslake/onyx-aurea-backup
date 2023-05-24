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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Authenticate" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Authenticate.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AuthenticateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="AuthenticateNonPublicTypeName" />) using
        ///     Using a public type <see cref="Common" /> to
        ///     create a non-public type.
        /// </summary>
        public AuthenticateTest() : base(publicType: typeof(Common), classNameWithNamespace: AuthenticateNonPublicTypeName)
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

        private Type _authenticateInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string AuthenticateNonPublicTypeName = "CmService.Service.Authenticate";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _authenticateInstance;
        private object _authenticateInstanceFixture;

        #region General Initializer : Class (Authenticate) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Authenticate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _authenticateInstanceFixture = this.CreateNonPublicType(AuthenticateNonPublicTypeName);
            _authenticateInstance = _authenticateInstanceFixture;
            CurrentInstance = _authenticateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Authenticate) Initializer

        #region Methods

        private const string MethodAuthenticateUser = "AuthenticateUser";
        private const string MethodLogoutUser = "LogoutUser";
        private const string MethodChangePassword = "ChangePassword";
        private const string MethodGetUserProfile = "GetUserProfile";
        private const string MethodGetDefaultUserProfile = "GetDefaultUserProfile";
        private const string MethodGetUserPreferenceByName = "GetUserPreferenceByName";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Authenticate)

        #region General Initializer : Class (Authenticate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAuthenticateUser, 0)]
        [TestCase(MethodLogoutUser, 0)]
        [TestCase(MethodChangePassword, 0)]
        [TestCase(MethodGetUserProfile, 0)]
        [TestCase(MethodGetDefaultUserProfile, 0)]
        [TestCase(MethodGetUserPreferenceByName, 0)]
        [Category("AUT Explore")]
        public void AUT_Authenticate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Authenticate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Authenticate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #endregion
    }
}