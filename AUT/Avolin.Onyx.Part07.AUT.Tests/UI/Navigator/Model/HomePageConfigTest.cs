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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.HomePageConfig" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HomePageConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HomePageConfig" />)
        /// </summary>
        public HomePageConfigTest() : base(typeof(HomePageConfig))
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

        #region General Initializer : Class (HomePageConfig) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _homePageConfigInstanceType;
        private HomePageConfig _homePageConfigInstance;
        private HomePageConfig _homePageConfigInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HomePageConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _homePageConfigInstanceType = typeof(HomePageConfig);
            _homePageConfigInstanceFixture = this.Create<HomePageConfig>(false);
            _homePageConfigInstance = _homePageConfigInstanceFixture ?? this.Create<HomePageConfig>(true);
            CurrentInstance = _homePageConfigInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HomePageConfig) Initializer

        #region Properties

        private const string PropertyTabPosition = "TabPosition";
        private const string PropertyTabRotation = "TabRotation";

        #endregion

        #endregion

        #region General Initializer : Class (HomePageConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HomePageConfig) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageConfig_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HomePageConfig) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageConfig_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HomePageConfig)

        #region General Initializer : Class (HomePageConfig) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyTabPosition)]
        [TestCase(PropertyTabRotation)]
        [Category("AUT Property")]
        public void AUT_HomePageConfig_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (HomePageConfig) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HomePageConfig_Is_Instance_Present_Test()
        {
            // Assert
            _homePageConfigInstanceType.ShouldNotBeNull();
            _homePageConfigInstance.ShouldNotBeNull();
            _homePageConfigInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HomePageConfig) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HomePageConfig" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HomePageConfig_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _homePageConfigInstance.ShouldBeAssignableTo<HomePageConfig>();
            _homePageConfigInstanceFixture.ShouldBeAssignableTo<HomePageConfig>();
            CurrentInstance.ShouldBeAssignableTo<HomePageConfig>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HomePageConfig) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HomePageConfig_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HomePageConfig instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HomePageConfig) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyTabPosition)]
        [TestCase(PropertyTabRotation)]
        public void AUT_HomePageConfig_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HomePageConfig) => Property (TabPosition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageConfig_Public_Class_TabPosition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTabPosition);
            var propertyInfo = this.GetPropertyInfo(PropertyTabPosition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HomePageConfig) => Property (TabRotation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageConfig_Public_Class_TabRotation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTabRotation);
            var propertyInfo = this.GetPropertyInfo(PropertyTabRotation);

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