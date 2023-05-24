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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.SearchFilterConfiguration" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SearchFilterConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SearchFilterConfiguration" />)
        /// </summary>
        public SearchFilterConfigurationTest() : base(typeof(SearchFilterConfiguration))
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

        #region General Initializer : Class (SearchFilterConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _searchFilterConfigurationInstanceType;
        private SearchFilterConfiguration _searchFilterConfigurationInstance;
        private SearchFilterConfiguration _searchFilterConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SearchFilterConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _searchFilterConfigurationInstanceType = typeof(SearchFilterConfiguration);
            _searchFilterConfigurationInstanceFixture = this.Create<SearchFilterConfiguration>(false);
            _searchFilterConfigurationInstance = _searchFilterConfigurationInstanceFixture ?? this.Create<SearchFilterConfiguration>(true);
            CurrentInstance = _searchFilterConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SearchFilterConfiguration) Initializer

        #region Properties

        private const string Propertyexpanded = "expanded";

        #endregion

        #region Fields

        private const string Fieldchildren = "children";

        #endregion

        #endregion

        #region General Initializer : Class (SearchFilterConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilterConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchFilterConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilterConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchFilterConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilterConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SearchFilterConfiguration)

        #region General Initializer : Class (SearchFilterConfiguration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyexpanded)]
        [Category("AUT Property")]
        public void AUT_SearchFilterConfiguration_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (SearchFilterConfiguration) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldchildren)]
        [Category("AUT Fields")]
        public void AUT_SearchFilterConfiguration_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SearchFilterConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchFilterConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _searchFilterConfigurationInstanceType.ShouldNotBeNull();
            _searchFilterConfigurationInstance.ShouldNotBeNull();
            _searchFilterConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SearchFilterConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SearchFilterConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchFilterConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _searchFilterConfigurationInstance.ShouldBeAssignableTo<SearchFilterConfiguration>();
            _searchFilterConfigurationInstanceFixture.ShouldBeAssignableTo<SearchFilterConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<SearchFilterConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SearchFilterConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilterConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SearchFilterConfiguration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SearchFilterConfiguration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyexpanded)]
        public void AUT_SearchFilterConfiguration_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (SearchFilterConfiguration) => Property (expanded) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilterConfiguration_Public_Class_expanded_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyexpanded);
            var propertyInfo = this.GetPropertyInfo(Propertyexpanded);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #endregion
    }
}