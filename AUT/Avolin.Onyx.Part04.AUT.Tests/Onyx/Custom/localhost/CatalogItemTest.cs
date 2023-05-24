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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.CatalogItem" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CatalogItemTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CatalogItem" />)
        /// </summary>
        public CatalogItemTest() : base(typeof(CatalogItem))
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

        #region General Initializer : Class (CatalogItem) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _catalogItemInstanceType;
        private CatalogItem _catalogItemInstance;
        private CatalogItem _catalogItemInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CatalogItem" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _catalogItemInstanceType = typeof(CatalogItem);
            _catalogItemInstanceFixture = this.Create<CatalogItem>(false);
            _catalogItemInstance = _catalogItemInstanceFixture ?? this.Create<CatalogItem>(true);
            CurrentInstance = _catalogItemInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CatalogItem) Initializer

        #region Properties

        private const string PropertyID = "ID";
        private const string PropertyName = "Name";
        private const string PropertyPath = "Path";
        private const string PropertyVirtualPath = "VirtualPath";
        private const string PropertyType = "Type";
        private const string PropertySize = "Size";
        
        private const string PropertyDescription = "Description";
        private const string PropertyHidden = "Hidden";
        private const string PropertyHiddenSpecified = "HiddenSpecified";
        private const string PropertyCreationDate = "CreationDate";
        private const string PropertyCreationDateSpecified = "CreationDateSpecified";
        private const string PropertyModifiedDate = "ModifiedDate";
        private const string PropertyModifiedDateSpecified = "ModifiedDateSpecified";
        private const string PropertyCreatedBy = "CreatedBy";
        private const string PropertyModifiedBy = "ModifiedBy";
        private const string PropertyMimeType = "MimeType";
        private const string PropertyExecutionDate = "ExecutionDate";
        private const string PropertyExecutionDateSpecified = "ExecutionDateSpecified";

        #endregion

        #region Fields

        private const string FieldidField = "idField";
        private const string FieldnameField = "nameField";
        private const string FieldpathField = "pathField";
        private const string FieldvirtualPathField = "virtualPathField";
        private const string FieldtypeField = "typeField";
        private const string FieldsizeField = "sizeField";
        private const string FieldsizeFieldSpecified = "sizeFieldSpecified";
        private const string FielddescriptionField = "descriptionField";
        private const string FieldhiddenField = "hiddenField";
        private const string FieldhiddenFieldSpecified = "hiddenFieldSpecified";
        private const string FieldcreationDateField = "creationDateField";
        private const string FieldcreationDateFieldSpecified = "creationDateFieldSpecified";
        private const string FieldmodifiedDateField = "modifiedDateField";
        private const string FieldmodifiedDateFieldSpecified = "modifiedDateFieldSpecified";
        private const string FieldcreatedByField = "createdByField";
        private const string FieldmodifiedByField = "modifiedByField";
        private const string FieldmimeTypeField = "mimeTypeField";
        private const string FieldexecutionDateField = "executionDateField";
        private const string FieldexecutionDateFieldSpecified = "executionDateFieldSpecified";

        #endregion

        #endregion

        #region General Initializer : Class (CatalogItem) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CatalogItem_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CatalogItem) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CatalogItem_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CatalogItem) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_CatalogItem_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CatalogItem)

        #region General Initializer : Class (CatalogItem) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyID)]
        [TestCase(PropertyName)]
        [TestCase(PropertyPath)]
        [TestCase(PropertyVirtualPath)]
        [TestCase(PropertyType)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyHidden)]
        [TestCase(PropertyHiddenSpecified)]
        [TestCase(PropertyCreationDate)]
        [TestCase(PropertyCreationDateSpecified)]
        [TestCase(PropertyModifiedDate)]
        [TestCase(PropertyModifiedDateSpecified)]
        [TestCase(PropertyCreatedBy)]
        [TestCase(PropertyModifiedBy)]
        [TestCase(PropertyMimeType)]
        [TestCase(PropertyExecutionDate)]
        [TestCase(PropertyExecutionDateSpecified)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_CatalogItem_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CatalogItem) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldidField)]
        [TestCase(FieldnameField)]
        [TestCase(FieldpathField)]
        [TestCase(FieldvirtualPathField)]
        [TestCase(FieldtypeField)]
        [TestCase(FielddescriptionField)]
        [TestCase(FieldhiddenField)]
        [TestCase(FieldhiddenFieldSpecified)]
        [TestCase(FieldcreationDateField)]
        [TestCase(FieldcreationDateFieldSpecified)]
        [TestCase(FieldmodifiedDateField)]
        [TestCase(FieldmodifiedDateFieldSpecified)]
        [TestCase(FieldcreatedByField)]
        [TestCase(FieldmodifiedByField)]
        [TestCase(FieldmimeTypeField)]
        [TestCase(FieldexecutionDateField)]
        [TestCase(FieldexecutionDateFieldSpecified)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_CatalogItem_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CatalogItem) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_CatalogItem_Is_Instance_Present_Test()
        {
            // Assert
            _catalogItemInstanceType.ShouldNotBeNull();
            _catalogItemInstance.ShouldNotBeNull();
            _catalogItemInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CatalogItem) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CatalogItem" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_CatalogItem_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _catalogItemInstance.ShouldBeAssignableTo<CatalogItem>();
            _catalogItemInstanceFixture.ShouldBeAssignableTo<CatalogItem>();
            CurrentInstance.ShouldBeAssignableTo<CatalogItem>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CatalogItem) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_CatalogItem_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CatalogItem instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CatalogItem) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyID)]
        [TestCase(PropertyName)]
        [TestCase(PropertyPath)]
        [TestCase(PropertyVirtualPath)]
        [TestCase(PropertyType)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyHidden)]
        [TestCase(PropertyHiddenSpecified)]
        [TestCase(PropertyCreationDate)]
        [TestCase(PropertyCreationDateSpecified)]
        [TestCase(PropertyModifiedDate)]
        [TestCase(PropertyModifiedDateSpecified)]
        [TestCase(PropertyCreatedBy)]
        [TestCase(PropertyModifiedBy)]
        [TestCase(PropertyMimeType)]
        [TestCase(PropertyExecutionDate)]
        [TestCase(PropertyExecutionDateSpecified)]
        public void AUT_CatalogItem_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CatalogItem) => Property (CreatedBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_CreatedBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreatedBy);
            var propertyInfo = this.GetPropertyInfo(PropertyCreatedBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (CreationDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_CreationDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreationDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCreationDate);
            Action currentAction = () => propertyInfo.SetValue(_catalogItemInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (CreationDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_CreationDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreationDate);
            var propertyInfo = this.GetPropertyInfo(PropertyCreationDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (CreationDateSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_CreationDateSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreationDateSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyCreationDateSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CatalogItem) => Property (ExecutionDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_ExecutionDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExecutionDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExecutionDate);
            Action currentAction = () => propertyInfo.SetValue(_catalogItemInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ExecutionDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ExecutionDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExecutionDate);
            var propertyInfo = this.GetPropertyInfo(PropertyExecutionDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ExecutionDateSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ExecutionDateSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExecutionDateSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyExecutionDateSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (Hidden) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_Hidden_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHidden);
            var propertyInfo = this.GetPropertyInfo(PropertyHidden);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (HiddenSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_HiddenSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHiddenSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyHiddenSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyID);
            var propertyInfo = this.GetPropertyInfo(PropertyID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (MimeType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_MimeType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMimeType);
            var propertyInfo = this.GetPropertyInfo(PropertyMimeType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ModifiedBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ModifiedBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedBy);
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ModifiedDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_ModifiedDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedDate);
            Action currentAction = () => propertyInfo.SetValue(_catalogItemInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ModifiedDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ModifiedDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedDate);
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (ModifiedDateSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_ModifiedDateSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedDateSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedDateSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CatalogItem) => Property (Path) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_Path_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPath);
            var propertyInfo = this.GetPropertyInfo(PropertyPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (Type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyType);
            Action currentAction = () => propertyInfo.SetValue(_catalogItemInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CatalogItem) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CatalogItem) => Property (VirtualPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_CatalogItem_Public_Class_VirtualPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyVirtualPath);
            var propertyInfo = this.GetPropertyInfo(PropertyVirtualPath);

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