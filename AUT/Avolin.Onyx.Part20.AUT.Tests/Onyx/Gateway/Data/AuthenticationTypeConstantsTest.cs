using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Gateway.Data;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.Gateway.Data
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Gateway.Data.AuthenticationTypeConstants" />)
    ///     and namespace <see cref="Onyx.Gateway.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AuthenticationTypeConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AuthenticationTypeConstants" />)
        /// </summary>
        public AuthenticationTypeConstantsTest() : base(typeof(AuthenticationTypeConstants))
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

        #region General Initializer : Class (AuthenticationTypeConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _authenticationTypeConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="AuthenticationTypeConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _authenticationTypeConstantsInstanceType = typeof(AuthenticationTypeConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AuthenticationTypeConstants) Initializer

        #region Fields

        private const string FieldBASIC = "BASIC";
        private const string FieldNTLM = "NTLM";
        private const string FieldWINDOWS = "WINDOWS";
        private const string FieldNONE = "NONE";

        #endregion

        #endregion
        
        #region General Initializer : Class (AuthenticationTypeConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AuthenticationTypeConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AuthenticationTypeConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AuthenticationTypeConstants)

        #region General Initializer : Class (AuthenticationTypeConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AuthenticationTypeConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldBASIC)]
        [TestCase(FieldNTLM)]
        [TestCase(FieldWINDOWS)]
        [TestCase(FieldNONE)]
        [Category("AUT Fields")]
        public void AUT_AuthenticationTypeConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (AuthenticationTypeConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AuthenticationTypeConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AuthenticationTypeConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _authenticationTypeConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}