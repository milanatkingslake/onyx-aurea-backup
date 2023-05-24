using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using ServiceBroker.Host;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.ServiceBroker.Host
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ServiceBroker.Host.ProjectInstaller" />)
    ///     and namespace <see cref="ServiceBroker.Host"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProjectInstallerDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ProjectInstallerNonPublicTypeName" />) using
        ///     Using a public type <see cref="DbSynchronizerService" /> to
        ///     create a non-public type.
        /// </summary>
        public ProjectInstallerDesignerTest() : base(publicType: typeof(DbSynchronizerService), classNameWithNamespace: ProjectInstallerNonPublicTypeName)
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

        private Type _projectInstallerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ProjectInstallerNonPublicTypeName = "ServiceBroker.Host.ProjectInstaller";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _projectInstallerInstance;
        private object _projectInstallerInstanceFixture;

        #region General Initializer : Class (ProjectInstaller) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ProjectInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _projectInstallerInstanceFixture = this.CreateNonPublicType(ProjectInstallerNonPublicTypeName);
            _projectInstallerInstance = _projectInstallerInstanceFixture;
            CurrentInstance = _projectInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProjectInstaller) Initializer

        #region Methods

        private const string MethodInitializeComponent = "InitializeComponent";

        #endregion

        #region Fields

        private const string Fieldcomponents = "components";
        private const string FieldDbSynchronizerServiceProcessInstaller = "DbSynchronizerServiceProcessInstaller";
        private const string FieldDbSynchronizerServiceInstaller = "DbSynchronizerServiceInstaller";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ProjectInstaller)
        
        #region General Initializer : Class (ProjectInstaller) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProjectInstallerDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ProjectInstaller) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldcomponents)]
        [TestCase(FieldDbSynchronizerServiceProcessInstaller)]
        [TestCase(FieldDbSynchronizerServiceInstaller)]
        [Category("AUT Fields")]
        public void AUT_ProjectInstallerDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ProjectInstaller) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProjectInstallerDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
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