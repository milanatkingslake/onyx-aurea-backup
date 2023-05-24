using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxGatewayWindowsService;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxGatewayWindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxGatewayWindowsService.Program" />)
    ///     and namespace <see cref="OnyxGatewayWindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ProgramTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ProgramNonPublicTypeName" />) using
        ///     Using a public type <see cref="OnyxService" /> to
        ///     create a non-public type.
        /// </summary>
        public ProgramTest() : base(publicType: typeof(OnyxService), classNameWithNamespace: ProgramNonPublicTypeName)
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

        private Type _programInstanceType;
        
        private const string ProgramNonPublicTypeName = "OnyxGatewayWindowsService.Program";

        #region General Initializer : Class (Program) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Program" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Program) Initializer

        #region Methods

        private const string MethodMain = "Main";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}