using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.OEDBEntities" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OEDBEntitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEDBEntities" />)
        /// </summary>
        public OEDBEntitiesTest() : base(typeof(OEDBEntities))
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

        #region General Initializer : Class (OEDBEntities) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEDBEntitiesInstanceType;
        private OEDBEntities _oEDBEntitiesInstance;
        private OEDBEntities _oEDBEntitiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEDBEntities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEDBEntitiesInstanceType = typeof(OEDBEntities);
            _oEDBEntitiesInstanceFixture = this.Create<OEDBEntities>(false);
            _oEDBEntitiesInstance = _oEDBEntitiesInstanceFixture ?? this.Create<OEDBEntities>(true);
            CurrentInstance = _oEDBEntitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEDBEntities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEDBEntities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEDBEntities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEDBEntities) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OEDBEntities" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEDBEntities_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEDBEntities) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEDBEntities" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEDBEntities_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OEDBEntities) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEDBEntities" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEDBEntities_Is_Instance_Present_Test()
        {
            // Assert
            _oEDBEntitiesInstanceType.ShouldNotBeNull();
            _oEDBEntitiesInstance.ShouldNotBeNull();
            _oEDBEntitiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OEDBEntities) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEDBEntities" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEDBEntities_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEDBEntitiesInstance.ShouldBeAssignableTo<OEDBEntities>();
            _oEDBEntitiesInstanceFixture.ShouldBeAssignableTo<OEDBEntities>();
            CurrentInstance.ShouldBeAssignableTo<OEDBEntities>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OEDBEntities) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEDBEntities_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var nameOrConnectionString = this.CreateType<string>();
            OEDBEntities instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEDBEntities(nameOrConnectionString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEDBEntitiesInstance.ShouldNotBeNull();
            _oEDBEntitiesInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OEDBEntities>();
        }

        #endregion

        #region General Constructor : Class (OEDBEntities) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEDBEntities_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var nameOrConnectionString = this.CreateType<string>();
            OEDBEntities instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEDBEntities(nameOrConnectionString);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEDBEntitiesInstance.ShouldNotBeNull();
            _oEDBEntitiesInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}