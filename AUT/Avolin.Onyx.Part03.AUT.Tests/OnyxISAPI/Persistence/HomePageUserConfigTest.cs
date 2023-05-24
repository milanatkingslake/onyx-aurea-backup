using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI.Persistence
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.HomePageUserConfig" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class HomePageUserConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HomePageUserConfig" />)
        /// </summary>
        public HomePageUserConfigTest() : base(typeof(HomePageUserConfig))
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

        #region General Initializer : Class (HomePageUserConfig) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _homePageUserConfigInstanceType;
        private HomePageUserConfig _homePageUserConfigInstance;
        private HomePageUserConfig _homePageUserConfigInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HomePageUserConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _homePageUserConfigInstanceType = typeof(HomePageUserConfig);
            _homePageUserConfigInstanceFixture = this.Create<HomePageUserConfig>(false);
            _homePageUserConfigInstance = _homePageUserConfigInstanceFixture ?? this.Create<HomePageUserConfig>(true);
            CurrentInstance = _homePageUserConfigInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HomePageUserConfig) Initializer

        #region Properties

        private const string PropertyConfigID = "ConfigID";
        private const string PropertyOwnerID = "OwnerID";
        private const string PropertyTabPosition = "TabPosition";
        private const string PropertyTabRotation = "TabRotation";
        private const string PropertySiteID = "SiteID";
        private const string PropertyRecordstatus = "Recordstatus";

        #endregion

        #endregion

        #region General Initializer : Class (HomePageUserConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageUserConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HomePageUserConfig) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageUserConfig_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HomePageUserConfig) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HomePageUserConfig_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HomePageUserConfig)

        #region General Initializer : Class (HomePageUserConfig) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfigID)]
        [TestCase(PropertyOwnerID)]
        [TestCase(PropertyTabPosition)]
        [TestCase(PropertyTabRotation)]
        [TestCase(PropertySiteID)]
        [TestCase(PropertyRecordstatus)]
        [Category("AUT Property")]
        public void AUT_HomePageUserConfig_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HomePageUserConfig) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HomePageUserConfig_Is_Instance_Present_Test()
        {
            // Assert
            _homePageUserConfigInstanceType.ShouldNotBeNull();
            _homePageUserConfigInstance.ShouldNotBeNull();
            _homePageUserConfigInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HomePageUserConfig) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HomePageUserConfig" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HomePageUserConfig_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _homePageUserConfigInstance.ShouldBeAssignableTo<HomePageUserConfig>();
            _homePageUserConfigInstanceFixture.ShouldBeAssignableTo<HomePageUserConfig>();
            CurrentInstance.ShouldBeAssignableTo<HomePageUserConfig>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HomePageUserConfig) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HomePageUserConfig_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            HomePageUserConfig instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HomePageUserConfig) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfigID)]
        [TestCase(PropertyOwnerID)]
        [TestCase(PropertyTabPosition)]
        [TestCase(PropertyTabRotation)]
        [TestCase(PropertySiteID)]
        [TestCase(PropertyRecordstatus)]
        public void AUT_HomePageUserConfig_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (ConfigID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_ConfigID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfigID);
            var propertyInfo = this.GetPropertyInfo(PropertyConfigID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (OwnerID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_OwnerID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerID);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (Recordstatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_Recordstatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordstatus);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordstatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (SiteID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_SiteID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteID);
            var propertyInfo = this.GetPropertyInfo(PropertySiteID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (TabPosition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_TabPosition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (HomePageUserConfig) => Property (TabRotation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HomePageUserConfig_Public_Class_TabRotation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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