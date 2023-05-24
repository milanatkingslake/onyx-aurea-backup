using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultGridConfiguration" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultGridConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultGridConfiguration" />)
        /// </summary>
        public ResultGridConfigurationTest() : base(typeof(ResultGridConfiguration))
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

        #region General Initializer : Class (ResultGridConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultGridConfigurationInstanceType;
        private ResultGridConfiguration _resultGridConfigurationInstance;
        private ResultGridConfiguration _resultGridConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultGridConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultGridConfigurationInstanceType = typeof(ResultGridConfiguration);
            _resultGridConfigurationInstanceFixture = this.Create<ResultGridConfiguration>(false);
            _resultGridConfigurationInstance = _resultGridConfigurationInstanceFixture ?? this.Create<ResultGridConfiguration>(true);
            CurrentInstance = _resultGridConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultGridConfiguration) Initializer

        #region Properties

        private const string PropertyPageSize = "PageSize";

        #endregion

        #region Fields

        private const string FieldResultGridProfileList = "ResultGridProfileList";

        #endregion

        #endregion

        #region General Initializer : Class (ResultGridConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGridConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGridConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultGridConfiguration)

        #region General Initializer : Class (ResultGridConfiguration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldResultGridProfileList)]
        [Category("AUT Fields")]
        public void AUT_ResultGridConfiguration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResultGridConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _resultGridConfigurationInstanceType.ShouldNotBeNull();
            _resultGridConfigurationInstance.ShouldNotBeNull();
            _resultGridConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultGridConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultGridConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGridConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultGridConfigurationInstance.ShouldBeAssignableTo<ResultGridConfiguration>();
            _resultGridConfigurationInstanceFixture.ShouldBeAssignableTo<ResultGridConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<ResultGridConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultGridConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultGridConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultGridConfiguration instance = null;

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