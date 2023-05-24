using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxWindowsService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxWindowsService
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxWindowsService.OnyxServiceInstaller" />)
    ///     and namespace <see cref="OnyxWindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxServiceInstallerDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxServiceInstallerNonPublicTypeName" />) using
        ///     Using a public type <see cref="OnyxServiceInstaller" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxServiceInstallerDesignerTest() : base(publicType: typeof(OnyxServiceInstaller), classNameWithNamespace: OnyxServiceInstallerNonPublicTypeName)
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

        private Type _onyxServiceInstallerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxServiceInstallerNonPublicTypeName = "OnyxWindowsService.OnyxServiceInstaller";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxServiceInstallerInstance;
        private object _onyxServiceInstallerInstanceFixture;

        #region General Initializer : Class (OnyxServiceInstaller) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxServiceInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxServiceInstallerInstanceFixture = this.CreateNonPublicType(OnyxServiceInstallerNonPublicTypeName);
            _onyxServiceInstallerInstance = _onyxServiceInstallerInstanceFixture;
            CurrentInstance = _onyxServiceInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxServiceInstaller) Initializer

        #region Methods

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxServiceInstaller)

        #region General Initializer : Class (OnyxServiceInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_OnyxServiceInstallerDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion
    }
}