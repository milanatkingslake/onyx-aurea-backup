using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.DAL;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.DAL
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DAL.persistenceDBEntities" />)
    ///     and namespace <see cref="NotificationService.DAL"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class PersistenceDBEntitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="persistenceDBEntities" />)
        /// </summary>
        public PersistenceDBEntitiesTest() : base(typeof(persistenceDBEntities))
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

        #region General Initializer : Class (persistenceDBEntities) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _persistenceDBEntitiesInstanceType;
        private persistenceDBEntities _persistenceDBEntitiesInstance;
        private persistenceDBEntities _persistenceDBEntitiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="persistenceDBEntities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _persistenceDBEntitiesInstanceType = typeof(persistenceDBEntities);
            _persistenceDBEntitiesInstanceFixture = this.Create<persistenceDBEntities>(false);
            _persistenceDBEntitiesInstance = _persistenceDBEntitiesInstanceFixture ?? this.Create<persistenceDBEntities>(true);
            CurrentInstance = _persistenceDBEntitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (persistenceDBEntities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="persistenceDBEntities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (persistenceDBEntities) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="persistenceDBEntities" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (persistenceDBEntities) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="persistenceDBEntities" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (persistenceDBEntities) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="persistenceDBEntities" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PersistenceDBEntities_Is_Instance_Present_Test()
        {
            // Assert
            _persistenceDBEntitiesInstanceType.ShouldNotBeNull();
            _persistenceDBEntitiesInstance.ShouldNotBeNull();
            _persistenceDBEntitiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (persistenceDBEntities) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="persistenceDBEntities" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PersistenceDBEntities_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _persistenceDBEntitiesInstance.ShouldBeAssignableTo<persistenceDBEntities>();
            _persistenceDBEntitiesInstanceFixture.ShouldBeAssignableTo<persistenceDBEntities>();
            CurrentInstance.ShouldBeAssignableTo<persistenceDBEntities>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (persistenceDBEntities) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PersistenceDBEntities_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var nameOrConnectionString = this.CreateType<string>();
            persistenceDBEntities instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new persistenceDBEntities(nameOrConnectionString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _persistenceDBEntitiesInstance.ShouldNotBeNull();
            _persistenceDBEntitiesInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<persistenceDBEntities>();
        }

        #endregion

        #region General Constructor : Class (persistenceDBEntities) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PersistenceDBEntities_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var nameOrConnectionString = this.CreateType<string>();
            persistenceDBEntities instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new persistenceDBEntities(nameOrConnectionString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _persistenceDBEntitiesInstance.ShouldNotBeNull();
            _persistenceDBEntitiesInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}