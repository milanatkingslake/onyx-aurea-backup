using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.ProfileManager" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ProfileManager.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ProfileManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProfileManager" />)
        /// </summary>
        public ProfileManagerTest() : base(typeof(ProfileManager))
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

        #region General Initializer : Class (ProfileManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _profileManagerInstanceType;
        private ProfileManager _profileManagerInstance;
        private ProfileManager _profileManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProfileManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _profileManagerInstanceType = typeof(ProfileManager);
            _profileManagerInstanceFixture = this.Create<ProfileManager>(false);
            _profileManagerInstance = _profileManagerInstanceFixture ?? this.Create<ProfileManager>(true);
            CurrentInstance = _profileManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProfileManager) Initializer

        #region Methods

        private const string MethodBrowseDataGridProfile = "BrowseDataGridProfile";
        private const string MethodUpdateDataGridProfile = "UpdateDataGridProfile";
        private const string MethodRestoreDataGridProfile = "RestoreDataGridProfile";
        private const string MethodBrowseSearchFilterProfile = "BrowseSearchFilterProfile";
        private const string MethodUpdateSearchFilterProfile = "UpdateSearchFilterProfile";
        private const string MethodValidateMaxRecordsProfile = "ValidateMaxRecordsProfile";
        private const string MethodRestoreSearchFilterProfile = "RestoreSearchFilterProfile";
        private const string MethodGetModulePrivilege = "GetModulePrivilege";
        private const string MethodGetAllUIResources = "GetAllUIResources";

        #endregion

        #endregion

    }
}