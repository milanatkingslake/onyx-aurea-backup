using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.OGSServerConfigurationConstants" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSServerConfigurationConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSServerConfigurationConstants" />)
        /// </summary>
        public OGSServerConfigurationConstantsTest() : base(typeof(OGSServerConfigurationConstants))
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

        #region General Initializer : Class (OGSServerConfigurationConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSServerConfigurationConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OGSServerConfigurationConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSServerConfigurationConstantsInstanceType = typeof(OGSServerConfigurationConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSServerConfigurationConstants) Initializer

        #region Fields

        private const string FieldApplication = "Application";
        private const string FieldAuthenticationType = "AuthenticationType";
        private const string FieldBaseAddress = "BaseAddress";
        private const string FieldDomainName = "DomainName";
        private const string FieldLanguage = "Language";
        private const string FieldONYX_GATEWAY_SERVICE_CONFIGUATION = "ONYX_GATEWAY_SERVICE_CONFIGUATION";
        private const string FieldONYX_GATEWAY_SERVICE_CONFIGUATIONS = "ONYX_GATEWAY_SERVICE_CONFIGUATIONS";
        private const string FieldONYX_GATEWAY_SERVICE_CONFIGUATIONS_SECTION = "ONYX_GATEWAY_SERVICE_CONFIGUATIONS_SECTION";
        private const string FieldPassword = "Password";
        private const string FieldSite = "Site";
        private const string FieldUniqueId = "UniqueId";
        private const string FieldUserName = "UserName";

        #endregion

        #endregion

        #region General Initializer : Class (OGSServerConfigurationConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSServerConfigurationConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSServerConfigurationConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSServerConfigurationConstants)

        #region General Initializer : Class (OGSServerConfigurationConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSServerConfigurationConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldApplication)]
        [TestCase(FieldAuthenticationType)]
        [TestCase(FieldBaseAddress)]
        [TestCase(FieldDomainName)]
        [TestCase(FieldLanguage)]
        [TestCase(FieldONYX_GATEWAY_SERVICE_CONFIGUATION)]
        [TestCase(FieldONYX_GATEWAY_SERVICE_CONFIGUATIONS)]
        [TestCase(FieldONYX_GATEWAY_SERVICE_CONFIGUATIONS_SECTION)]
        [TestCase(FieldPassword)]
        [TestCase(FieldSite)]
        [TestCase(FieldUniqueId)]
        [TestCase(FieldUserName)]
        [Category("AUT Fields")]
        public void AUT_OGSServerConfigurationConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OGSServerConfigurationConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSServerConfigurationConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSServerConfigurationConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _oGSServerConfigurationConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}