using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ModelCatalogItem" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ModelCatalogItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModelCatalogItem" />)
        /// </summary>
        public ModelCatalogItemTest() : base(typeof(ModelCatalogItem))
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

        #region General Initializer : Class (ModelCatalogItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modelCatalogItemInstanceType;
        private ModelCatalogItem _modelCatalogItemInstance;
        private ModelCatalogItem _modelCatalogItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ModelCatalogItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modelCatalogItemInstanceType = typeof(ModelCatalogItem);
            _modelCatalogItemInstanceFixture = this.Create<ModelCatalogItem>(false);
            _modelCatalogItemInstance = _modelCatalogItemInstanceFixture ?? this.Create<ModelCatalogItem>(true);
            CurrentInstance = _modelCatalogItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ModelCatalogItem) Initializer

        #region Properties

        private const string PropertyModel = "Model";
        private const string PropertyDescription = "Description";
        private const string PropertyPerspectives = "Perspectives";

        #endregion

        #region Fields

        private const string FieldmodelField = "modelField";
        private const string FielddescriptionField = "descriptionField";
        private const string FieldperspectivesField = "perspectivesField";

        #endregion

        #endregion

        #region General Initializer : Class (ModelCatalogItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelCatalogItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelCatalogItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelCatalogItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelCatalogItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelCatalogItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModelCatalogItem)

        #region General Initializer : Class (ModelCatalogItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyModel)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyPerspectives)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ModelCatalogItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ModelCatalogItem) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldmodelField)]
        [TestCase(FielddescriptionField)]
        [TestCase(FieldperspectivesField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ModelCatalogItem_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ModelCatalogItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ModelCatalogItem_Is_Instance_Present_Test()
        {
            // Assert
            _modelCatalogItemInstanceType.ShouldNotBeNull();
            _modelCatalogItemInstance.ShouldNotBeNull();
            _modelCatalogItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ModelCatalogItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ModelCatalogItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ModelCatalogItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modelCatalogItemInstance.ShouldBeAssignableTo<ModelCatalogItem>();
            _modelCatalogItemInstanceFixture.ShouldBeAssignableTo<ModelCatalogItem>();
            CurrentInstance.ShouldBeAssignableTo<ModelCatalogItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ModelCatalogItem) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ModelCatalogItem_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ModelCatalogItem instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ModelCatalogItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyModel)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyPerspectives)]
        public void AUT_ModelCatalogItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ModelCatalogItem) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelCatalogItem_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelCatalogItem) => Property (Model) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelCatalogItem_Public_Class_Model_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModel);
            var propertyInfo = this.GetPropertyInfo(PropertyModel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelCatalogItem) => Property (Perspectives) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelCatalogItem_Perspectives_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPerspectives);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPerspectives);
            Action currentAction = () => propertyInfo.SetValue(_modelCatalogItemInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ModelCatalogItem) => Property (Perspectives) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelCatalogItem_Public_Class_Perspectives_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPerspectives);
            var propertyInfo = this.GetPropertyInfo(PropertyPerspectives);

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