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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.FieldPanelItem" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FieldPanelItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FieldPanelItem" />)
        /// </summary>
        public FieldPanelItemTest() : base(typeof(FieldPanelItem))
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

        #region General Initializer : Class (FieldPanelItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _fieldPanelItemInstanceType;
        private FieldPanelItem _fieldPanelItemInstance;
        private FieldPanelItem _fieldPanelItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FieldPanelItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _fieldPanelItemInstanceType = typeof(FieldPanelItem);
            _fieldPanelItemInstanceFixture = this.Create<FieldPanelItem>(false);
            _fieldPanelItemInstance = _fieldPanelItemInstanceFixture ?? this.Create<FieldPanelItem>(true);
            CurrentInstance = _fieldPanelItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FieldPanelItem) Initializer

        #region Properties

        private const string PropertyDisplayValue = "DisplayValue";
        private const string PropertyDisplayName = "DisplayName";

        #endregion

        #endregion

        #region General Initializer : Class (FieldPanelItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FieldPanelItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FieldPanelItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FieldPanelItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (FieldPanelItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FieldPanelItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FieldPanelItem)

        #region General Initializer : Class (FieldPanelItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDisplayValue)]
        [TestCase(PropertyDisplayName)]
        [Category("AUT Property")]
        public void AUT_FieldPanelItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (FieldPanelItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FieldPanelItem_Is_Instance_Present_Test()
        {
            // Assert
            _fieldPanelItemInstanceType.ShouldNotBeNull();
            _fieldPanelItemInstance.ShouldNotBeNull();
            _fieldPanelItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FieldPanelItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FieldPanelItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FieldPanelItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _fieldPanelItemInstance.ShouldBeAssignableTo<FieldPanelItem>();
            _fieldPanelItemInstanceFixture.ShouldBeAssignableTo<FieldPanelItem>();
            CurrentInstance.ShouldBeAssignableTo<FieldPanelItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FieldPanelItem) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FieldPanelItem_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FieldPanelItem instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (FieldPanelItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDisplayValue)]
        [TestCase(PropertyDisplayName)]
        public void AUT_FieldPanelItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (FieldPanelItem) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FieldPanelItem_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (FieldPanelItem) => Property (DisplayValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_FieldPanelItem_Public_Class_DisplayValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayValue);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayValue);

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