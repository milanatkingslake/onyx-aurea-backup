using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.ModelDescriptions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.ModelDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ModelDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModelDescription" />)
        /// </summary>
        public ModelDescriptionTest() : base(typeof(ModelDescription))
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

        #region General Initializer : Class (ModelDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modelDescriptionInstanceType;
        private ModelDescription _modelDescriptionInstance;
        private ModelDescription _modelDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ModelDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modelDescriptionInstanceType = typeof(ModelDescription);
            _modelDescriptionInstanceFixture = this.Create<ModelDescription>(false);
            _modelDescriptionInstance = _modelDescriptionInstanceFixture ?? this.Create<ModelDescription>(true);
            CurrentInstance = _modelDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ModelDescription) Initializer

        #region Properties

        private const string PropertyDocumentation = "Documentation";
        private const string PropertyModelType = "ModelType";
        private const string PropertyName = "Name";

        #endregion

        #endregion

        #region General Initializer : Class (ModelDescription) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescription_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDescription) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescription_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDescription) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ModelDescription_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModelDescription)

        #region General Initializer : Class (ModelDescription) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDocumentation)]
        [TestCase(PropertyModelType)]
        [TestCase(PropertyName)]
        [Category("AUT Property")]
        public void AUT_ModelDescription_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ModelDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModelDescription_Is_Instance_Present_Test()
        {
            // Assert
            _modelDescriptionInstanceType.ShouldNotBeNull();
            _modelDescriptionInstance.ShouldNotBeNull();
            _modelDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ModelDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ModelDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ModelDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modelDescriptionInstance.ShouldBeAssignableTo<ModelDescription>();
            _modelDescriptionInstanceFixture.ShouldBeAssignableTo<ModelDescription>();
            CurrentInstance.ShouldBeAssignableTo<ModelDescription>();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ModelDescription) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDocumentation)]
        [TestCase(PropertyModelType)]
        [TestCase(PropertyName)]
        public void AUT_ModelDescription_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ModelDescription) => Property (Documentation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescription_Public_Class_Documentation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocumentation);
            var propertyInfo = this.GetPropertyInfo(PropertyDocumentation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelDescription) => Property (ModelType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescription_ModelType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModelType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyModelType);
            Action currentAction = () => propertyInfo.SetValue(_modelDescriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ModelDescription) => Property (ModelType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescription_Public_Class_ModelType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModelType);
            var propertyInfo = this.GetPropertyInfo(PropertyModelType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelDescription) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ModelDescription_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}