using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Onyx.Ucf.Properties;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf.Properties
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.Properties.Settings" />)
    ///     and namespace <see cref="Onyx.Ucf.Properties"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SettingsDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="SettingsNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public SettingsDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: SettingsNonPublicTypeName)
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

        private Type _settingsInstanceType;
        
        private const string SettingsNonPublicTypeName = "Onyx.Ucf.Properties.Settings";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _settingsInstance;
        private object _settingsInstanceFixture;

        #region General Initializer : Class (Settings) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Settings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _settingsInstanceFixture = this.CreateNonPublicType(SettingsNonPublicTypeName);
            _settingsInstance = _settingsInstanceFixture;
            CurrentInstance = _settingsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Settings) Initializer

        #region Properties

        private const string PropertyDefault = "Default";

        #endregion

        #region Fields

        private const string FielddefaultInstance = "defaultInstance";

        #endregion

        #endregion

        #endregion

        #endregion
    }
}