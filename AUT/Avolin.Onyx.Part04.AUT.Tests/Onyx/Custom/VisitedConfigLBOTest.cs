using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.VisitedConfigLBO" />)
    ///     and namespace <see cref="Onyx.Custom"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class VisitedConfigLBOTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="VisitedConfigLBO" />)
        /// </summary>
        public VisitedConfigLBOTest() : base(typeof(VisitedConfigLBO))
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

        #region General Initializer : Class (VisitedConfigLBO) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _visitedConfigLBOInstanceType;
        private VisitedConfigLBO _visitedConfigLBOInstance;
        private VisitedConfigLBO _visitedConfigLBOInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="VisitedConfigLBO" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _visitedConfigLBOInstanceType = typeof(VisitedConfigLBO);
            _visitedConfigLBOInstanceFixture = this.Create<VisitedConfigLBO>(false);
            _visitedConfigLBOInstance = _visitedConfigLBOInstanceFixture ?? this.Create<VisitedConfigLBO>(true);
            CurrentInstance = _visitedConfigLBOInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (VisitedConfigLBO) Initializer

        #region Fields

        private const string FieldlboConfigId = "lboConfigId";
        private const string FieldlboPrimaryId = "lboPrimaryId";
        private const string FieldlboSecondaryId = "lboSecondaryId";
        private const string FieldisVisited = "isVisited";
        private const string FieldisError = "isError";
        private const string FieldbyPassed = "byPassed";

        #endregion

        #endregion

        #region General Initializer : Class (VisitedConfigLBO) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="VisitedConfigLBO" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_VisitedConfigLBO_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (VisitedConfigLBO)

        #region General Initializer : Class (VisitedConfigLBO) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="VisitedConfigLBO" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldlboConfigId)]
        [TestCase(FieldlboPrimaryId)]
        [TestCase(FieldlboSecondaryId)]
        [TestCase(FieldisVisited)]
        [TestCase(FieldisError)]
        [TestCase(FieldbyPassed)]
        [Category("AUT Fields")]
        public void AUT_VisitedConfigLBO_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Category : Instance

        #region General Instance : Class (VisitedConfigLBO) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="VisitedConfigLBO" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_VisitedConfigLBO_Is_Instance_Present_Test()
        {
            // Assert
            _visitedConfigLBOInstanceType.ShouldNotBeNull();
            _visitedConfigLBOInstance.ShouldNotBeNull();
            _visitedConfigLBOInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (VisitedConfigLBO) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="VisitedConfigLBO" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_VisitedConfigLBO_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _visitedConfigLBOInstance.ShouldBeAssignableTo<VisitedConfigLBO>();
            _visitedConfigLBOInstanceFixture.ShouldBeAssignableTo<VisitedConfigLBO>();
            CurrentInstance.ShouldBeAssignableTo<VisitedConfigLBO>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (VisitedConfigLBO) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_VisitedConfigLBO_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var configId = this.CreateType<string>();
            VisitedConfigLBO instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new VisitedConfigLBO(configId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _visitedConfigLBOInstance.ShouldNotBeNull();
            _visitedConfigLBOInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<VisitedConfigLBO>();
        }

        #endregion

        #region General Constructor : Class (VisitedConfigLBO) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_VisitedConfigLBO_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var configId = this.CreateType<string>();
            VisitedConfigLBO instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new VisitedConfigLBO(configId);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _visitedConfigLBOInstance.ShouldNotBeNull();
            _visitedConfigLBOInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #endregion
    }
}