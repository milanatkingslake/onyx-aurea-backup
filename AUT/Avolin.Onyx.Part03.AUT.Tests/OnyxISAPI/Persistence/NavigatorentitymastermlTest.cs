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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_entity_master_ml" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatorentitymastermlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_entity_master_ml" />)
        /// </summary>
        public NavigatorentitymastermlTest() : base(typeof(navigator_entity_master_ml))
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

        #region General Initializer : Class (navigator_entity_master_ml) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorentitymastermlInstanceType;
        private navigator_entity_master_ml _navigatorentitymastermlInstance;
        private navigator_entity_master_ml _navigatorentitymastermlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_entity_master_ml" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorentitymastermlInstanceType = typeof(navigator_entity_master_ml);
            _navigatorentitymastermlInstanceFixture = this.Create<navigator_entity_master_ml>(false);
            _navigatorentitymastermlInstance = _navigatorentitymastermlInstanceFixture ?? this.Create<navigator_entity_master_ml>(true);
            CurrentInstance = _navigatorentitymastermlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml) Initializer

        #region Properties

        private const string Propertyentity_id = "entity_id";
        private const string Propertysite_id = "site_id";
        private const string Propertylanguage_code = "language_code";
        private const string Propertyentity_display_name = "entity_display_name";
        private const string Propertynavigator_entity_master = "navigator_entity_master";
        private const string Propertylanguage = "language";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymasterml_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymasterml_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymasterml_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_entity_master_ml)

        #region General Initializer : Class (navigator_entity_master_ml) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyentity_display_name)]
        [TestCase(Propertynavigator_entity_master)]
        [TestCase(Propertylanguage)]
        [Category("AUT Property")]
        public void AUT_Navigatorentitymasterml_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_entity_master_ml) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitymasterml_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorentitymastermlInstanceType.ShouldNotBeNull();
            _navigatorentitymastermlInstance.ShouldNotBeNull();
            _navigatorentitymastermlInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_entity_master_ml) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitymasterml_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorentitymastermlInstance.ShouldBeAssignableTo<navigator_entity_master_ml>();
            _navigatorentitymastermlInstanceFixture.ShouldBeAssignableTo<navigator_entity_master_ml>();
            CurrentInstance.ShouldBeAssignableTo<navigator_entity_master_ml>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_entity_master_ml) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatorentitymasterml_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_entity_master_ml instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_entity_master_ml) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyentity_display_name)]
        [TestCase(Propertynavigator_entity_master)]
        [TestCase(Propertylanguage)]
        public void AUT_Navigatorentitymasterml_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (entity_display_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_entity_display_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_display_name);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_display_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (entity_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_entity_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_id);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (language) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_language_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertylanguage);
            Action currentAction = () => propertyInfo.SetValue(_navigatorentitymastermlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (language_code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_language_code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage_code);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage_code);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (navigator_entity_master) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_navigator_entity_master_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master);
            Action currentAction = () => propertyInfo.SetValue(_navigatorentitymastermlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (navigator_entity_master) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_navigator_entity_master_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymasterml_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysite_id);
            var propertyInfo = this.GetPropertyInfo(Propertysite_id);

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