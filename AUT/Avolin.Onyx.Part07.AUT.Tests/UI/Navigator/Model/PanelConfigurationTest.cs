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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.PanelConfiguration" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PanelConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PanelConfiguration" />)
        /// </summary>
        public PanelConfigurationTest() : base(typeof(PanelConfiguration))
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

        #region General Initializer : Class (PanelConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _panelConfigurationInstanceType;
        private PanelConfiguration _panelConfigurationInstance;
        private PanelConfiguration _panelConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PanelConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _panelConfigurationInstanceType = typeof(PanelConfiguration);
            _panelConfigurationInstanceFixture = this.Create<PanelConfiguration>(false);
            _panelConfigurationInstance = _panelConfigurationInstanceFixture ?? this.Create<PanelConfiguration>(true);
            CurrentInstance = _panelConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PanelConfiguration) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyClass = "Class";
        private const string PropertyType = "Type";
        private const string PropertyIsDefault = "IsDefault";
        private const string PropertySequanceIndexFilter = "SequanceIndexFilter";
        private const string PropertyIsDefaultDetail = "IsDefaultDetail";
        private const string PropertyVisibility = "Visibility";
        private const string PropertyEnabled = "Enabled";

        #endregion

        #endregion

        #region General Initializer : Class (PanelConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PanelConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PanelConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PanelConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PanelConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PanelConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PanelConfiguration)

        #region General Initializer : Class (PanelConfiguration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyClass)]
        [TestCase(PropertyType)]
        [TestCase(PropertyIsDefault)]
        [TestCase(PropertySequanceIndexFilter)]
        [TestCase(PropertyIsDefaultDetail)]
        [TestCase(PropertyVisibility)]
        [TestCase(PropertyEnabled)]
        [Category("AUT Property")]
        public void AUT_PanelConfiguration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PanelConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PanelConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _panelConfigurationInstanceType.ShouldNotBeNull();
            _panelConfigurationInstance.ShouldNotBeNull();
            _panelConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PanelConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PanelConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PanelConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _panelConfigurationInstance.ShouldBeAssignableTo<PanelConfiguration>();
            _panelConfigurationInstanceFixture.ShouldBeAssignableTo<PanelConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<PanelConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PanelConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PanelConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            PanelConfiguration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PanelConfiguration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyClass)]
        [TestCase(PropertyType)]
        [TestCase(PropertyIsDefault)]
        [TestCase(PropertySequanceIndexFilter)]
        [TestCase(PropertyIsDefaultDetail)]
        [TestCase(PropertyVisibility)]
        [TestCase(PropertyEnabled)]
        public void AUT_PanelConfiguration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (PanelConfiguration) => Property (Class) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_Class_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyClass);
            var propertyInfo = this.GetPropertyInfo(PropertyClass);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (Enabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_Enabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnabled);
            var propertyInfo = this.GetPropertyInfo(PropertyEnabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (IsDefault) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_IsDefault_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsDefault);
            var propertyInfo = this.GetPropertyInfo(PropertyIsDefault);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (IsDefaultDetail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_IsDefaultDetail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsDefaultDetail);
            var propertyInfo = this.GetPropertyInfo(PropertyIsDefaultDetail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (SequanceIndexFilter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_SequanceIndexFilter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequanceIndexFilter);
            var propertyInfo = this.GetPropertyInfo(PropertySequanceIndexFilter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PanelConfiguration) => Property (Visibility) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PanelConfiguration_Public_Class_Visibility_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyVisibility);
            var propertyInfo = this.GetPropertyInfo(PropertyVisibility);

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