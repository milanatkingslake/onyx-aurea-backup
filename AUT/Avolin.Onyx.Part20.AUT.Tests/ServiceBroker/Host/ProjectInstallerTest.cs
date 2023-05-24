using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using ServiceBroker.Host;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.ServiceBroker.Host
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ServiceBroker.Host.ProjectInstaller" />)
    ///     and namespace <see cref="ServiceBroker.Host"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProjectInstallerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProjectInstaller" />)
        /// </summary>
        public ProjectInstallerTest() : base(typeof(ProjectInstaller))
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

        #region General Initializer : Class (ProjectInstaller) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _projectInstallerInstanceType;
        private ProjectInstaller _projectInstallerInstance;
        private ProjectInstaller _projectInstallerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProjectInstaller" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _projectInstallerInstanceType = typeof(ProjectInstaller);
            _projectInstallerInstanceFixture = this.Create<ProjectInstaller>(false);
            _projectInstallerInstance = _projectInstallerInstanceFixture ?? this.Create<ProjectInstaller>(true);
            CurrentInstance = _projectInstallerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProjectInstaller) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ProjectInstaller_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProjectInstaller) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ProjectInstaller_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ProjectInstaller) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ProjectInstaller_Is_Instance_Present_Test()
        {
            // Assert
            _projectInstallerInstanceType.ShouldNotBeNull();
            _projectInstallerInstance.ShouldNotBeNull();
            _projectInstallerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ProjectInstaller) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ProjectInstaller" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ProjectInstaller_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _projectInstallerInstance.ShouldBeAssignableTo<ProjectInstaller>();
            _projectInstallerInstanceFixture.ShouldBeAssignableTo<ProjectInstaller>();
            CurrentInstance.ShouldBeAssignableTo<ProjectInstaller>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ProjectInstaller) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ProjectInstaller_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ProjectInstaller instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}