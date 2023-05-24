using Action = System.Action;
using Should = Shouldly.Should;

namespace NotificationService.WindowsService
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
    using NotificationService.WindowsService;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.WindowsService.NotificationWindowsServiceInstaller" />)
    ///     and namespace <see cref="NotificationService.WindowsService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NotificationWindowsServiceInstallerDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="NotificationWindowsServiceInstallerNonPublicTypeName" />) using
        ///     Using a public type <see cref="Constants" /> to
        ///     create a non-public type.
        /// </summary>
        public NotificationWindowsServiceInstallerDesignerTest() : base(publicType: typeof(Constants), classNameWithNamespace: NotificationWindowsServiceInstallerNonPublicTypeName)
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

        private Type _notificationWindowsServiceInstallerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string NotificationWindowsServiceInstallerNonPublicTypeName = "NotificationService.WindowsService.NotificationWindowsServiceInstaller";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _notificationWindowsServiceInstallerInstance;
        private object _notificationWindowsServiceInstallerInstanceFixture;

        #region General Initializer : Class (NotificationWindowsServiceInstaller) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="NotificationWindowsServiceInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationWindowsServiceInstallerInstanceFixture = this.CreateNonPublicType(NotificationWindowsServiceInstallerNonPublicTypeName);
            _notificationWindowsServiceInstallerInstance = _notificationWindowsServiceInstallerInstanceFixture;
            CurrentInstance = _notificationWindowsServiceInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationWindowsServiceInstaller) Initializer

        #region Methods

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationWindowsServiceInstaller)

        #region General Initializer : Class (NotificationWindowsServiceInstaller) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationWindowsServiceInstaller" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationWindowsServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NotificationWindowsServiceInstaller) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NotificationWindowsServiceInstaller" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationWindowsServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (NotificationWindowsServiceInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationWindowsServiceInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [Category("AUT Fields")]
        public void AUT_NotificationWindowsServiceInstallerDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (NotificationWindowsServiceInstaller) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationWindowsServiceInstaller" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationWindowsServiceInstallerDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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