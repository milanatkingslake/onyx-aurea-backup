using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ApplicationConfiguration" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ApplicationConfiguration.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ApplicationConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ApplicationConfiguration" />)
        /// </summary>
        public ApplicationConfigurationTest() : base(typeof(ApplicationConfiguration))
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

        #region General Initializer : Class (ApplicationConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _applicationConfigurationInstanceType;
        private ApplicationConfiguration _applicationConfigurationInstance;
        private ApplicationConfiguration _applicationConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ApplicationConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _applicationConfigurationInstanceType = typeof(ApplicationConfiguration);
            _applicationConfigurationInstanceFixture = this.Create<ApplicationConfiguration>(false);
            _applicationConfigurationInstance = _applicationConfigurationInstanceFixture ?? this.Create<ApplicationConfiguration>(true);
            CurrentInstance = _applicationConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ApplicationConfiguration) Initializer

        #region Methods

        private const string MethodBrowseNavigatorSearchEntities = "BrowseNavigatorSearchEntities";
        private const string MethodGetOnyxMobileHomePage = "GetOnyxMobileHomePage";
        private const string MethodCheckUIResourcePermission = "CheckUIResourcePermission";
        private const string MethodGetOnyxMobileUserLinks = "GetOnyxMobileUserLinks";
        private const string MethodGetOnyxMobileConfiguration = "GetOnyxMobileConfiguration";

        #endregion

        #endregion

    }
}