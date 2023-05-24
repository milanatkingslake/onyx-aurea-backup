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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_user_field_property" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatoruserfieldpropertyTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_user_field_property" />)
        /// </summary>
        public NavigatoruserfieldpropertyTest() : base(typeof(navigator_user_field_property))
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

        #region General Initializer : Class (navigator_user_field_property) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatoruserfieldpropertyInstanceType;
        private navigator_user_field_property _navigatoruserfieldpropertyInstance;
        private navigator_user_field_property _navigatoruserfieldpropertyInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_user_field_property" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatoruserfieldpropertyInstanceType = typeof(navigator_user_field_property);
            _navigatoruserfieldpropertyInstanceFixture = this.Create<navigator_user_field_property>(false);
            _navigatoruserfieldpropertyInstance = _navigatoruserfieldpropertyInstanceFixture ?? this.Create<navigator_user_field_property>(true);
            CurrentInstance = _navigatoruserfieldpropertyInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_user_field_property) Initializer

        #region Properties

        private const string Propertyuser_id = "user_id";
        private const string Propertyproperty_id = "property_id";
        private const string Propertyproperty_value = "property_value";
        private const string Propertyfield_id = "field_id";
        private const string Propertyis_active = "is_active";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_user_field_property) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruserfieldproperty_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_user_field_property) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruserfieldproperty_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_user_field_property) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruserfieldproperty_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_user_field_property)

        #region General Initializer : Class (navigator_user_field_property) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertyproperty_id)]
        [TestCase(Propertyproperty_value)]
        [TestCase(Propertyfield_id)]
        [TestCase(Propertyis_active)]
        [Category("AUT Property")]
        public void AUT_Navigatoruserfieldproperty_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_user_field_property) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatoruserfieldproperty_Is_Instance_Present_Test()
        {
            // Assert
            _navigatoruserfieldpropertyInstanceType.ShouldNotBeNull();
            _navigatoruserfieldpropertyInstance.ShouldNotBeNull();
            _navigatoruserfieldpropertyInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_user_field_property) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_user_field_property" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatoruserfieldproperty_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatoruserfieldpropertyInstance.ShouldBeAssignableTo<navigator_user_field_property>();
            _navigatoruserfieldpropertyInstanceFixture.ShouldBeAssignableTo<navigator_user_field_property>();
            CurrentInstance.ShouldBeAssignableTo<navigator_user_field_property>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_user_field_property) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatoruserfieldproperty_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_user_field_property instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_user_field_property) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertyproperty_id)]
        [TestCase(Propertyproperty_value)]
        [TestCase(Propertyfield_id)]
        [TestCase(Propertyis_active)]
        public void AUT_Navigatoruserfieldproperty_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_user_field_property) => Property (field_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruserfieldproperty_Public_Class_field_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfield_id);
            var propertyInfo = this.GetPropertyInfo(Propertyfield_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_field_property) => Property (is_active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruserfieldproperty_Public_Class_is_active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyis_active);
            var propertyInfo = this.GetPropertyInfo(Propertyis_active);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_field_property) => Property (property_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruserfieldproperty_Public_Class_property_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyproperty_id);
            var propertyInfo = this.GetPropertyInfo(Propertyproperty_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_field_property) => Property (property_value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruserfieldproperty_Public_Class_property_value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyproperty_value);
            var propertyInfo = this.GetPropertyInfo(Propertyproperty_value);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_field_property) => Property (user_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruserfieldproperty_Public_Class_user_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuser_id);
            var propertyInfo = this.GetPropertyInfo(Propertyuser_id);

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