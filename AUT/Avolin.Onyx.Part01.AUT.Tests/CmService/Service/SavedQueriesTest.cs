using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.SavedQueries" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ModelClasses.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SavedQueriesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SavedQueries" />)
        /// </summary>
        public SavedQueriesTest() : base(typeof(SavedQueries))
        { }

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

        #region General Initializer : Class (SavedQueries) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _savedQueriesInstanceType;
        private SavedQueries _savedQueriesInstance;
        private SavedQueries _savedQueriesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SavedQueries" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _savedQueriesInstanceType = typeof(SavedQueries);
            _savedQueriesInstanceFixture = this.Create<SavedQueries>(false);
            _savedQueriesInstance = _savedQueriesInstanceFixture ?? this.Create<SavedQueries>(true);
            CurrentInstance = _savedQueriesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SavedQueries) Initializer

        #region Fields

        private const string FieldRoot = "Root";

        #endregion

        #endregion

        #region General Initializer : Class (SavedQueries) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SavedQueries" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SavedQueries_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SavedQueries)

        #region General Initializer : Class (SavedQueries) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SavedQueries" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldRoot)]
        [Category("AUT Fields")]
        public void AUT_SavedQueries_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SavedQueries) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SavedQueries" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SavedQueries_Is_Instance_Present_Test()
        {
            // Assert
            _savedQueriesInstanceType.ShouldNotBeNull();
            _savedQueriesInstance.ShouldNotBeNull();
            _savedQueriesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SavedQueries) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SavedQueries" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SavedQueries_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _savedQueriesInstance.ShouldBeAssignableTo<SavedQueries>();
            _savedQueriesInstanceFixture.ShouldBeAssignableTo<SavedQueries>();
            CurrentInstance.ShouldBeAssignableTo<SavedQueries>();
        }

        #endregion

        #region General Constructor : Class (SavedQueries) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SavedQueries_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SavedQueries instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

    }
}