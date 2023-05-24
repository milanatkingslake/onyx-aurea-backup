using Action = System.Action;
using Should = Shouldly.Should;

namespace Onyx.GatewayProxy.WindowsService
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Configuration.Install;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Reflection;
    using System.ServiceProcess;
    using System.Text;
    using Action = System.Action;
    using AUT.TestProjects.Analyzer;
    using AUT.TestProjects.BaseSetup;
    using AUT.TestProjects.BaseSetup.Version;
    using AUT.TestProjects.BaseSetup.Version.V1;
    using AUT.TestProjects.BaseSetup.Version.V2;
    using AUT.TestProjects.Extensions;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
    using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
    using AUT.TestProjects.Interfaces;
    using AUT.TestProjects.Interfaces.BaseSetup.Version;
    using AUT.TestProjects.Interfaces.BaseSetup.Version.V2;
    using AUT.TestProjects.Model;
    using AUT.TestProjects.NUnitExtensionAttribute;
    using AUT.TestProjects.StaticTypes;
    using Moq;
    using NUnit.Framework;
    using Should = Shouldly.Should;
    using Shouldly;
    using Onyx.GatewayProxy.WindowsService;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyServiceInstaller" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxGatewayProxyServiceInstallerDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="OnyxGatewayProxyServiceInstallerNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public OnyxGatewayProxyServiceInstallerDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: OnyxGatewayProxyServiceInstallerNonPublicTypeName)
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

        private Type _onyxGatewayProxyServiceInstallerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string OnyxGatewayProxyServiceInstallerNonPublicTypeName = "Onyx.GatewayProxy.WindowsService.OnyxGatewayProxyServiceInstaller";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _onyxGatewayProxyServiceInstallerInstance;
        private object _onyxGatewayProxyServiceInstallerInstanceFixture;

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayProxyServiceInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayProxyServiceInstallerInstanceFixture = this.CreateNonPublicType(OnyxGatewayProxyServiceInstallerNonPublicTypeName);
            _onyxGatewayProxyServiceInstallerInstance = _onyxGatewayProxyServiceInstallerInstanceFixture;
            CurrentInstance = _onyxGatewayProxyServiceInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Initializer

        #region Methods

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayProxyServiceInstaller)
        
        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_OnyxGatewayProxyServiceInstallerDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxGatewayProxyServiceInstaller) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayProxyServiceInstaller" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayProxyServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}