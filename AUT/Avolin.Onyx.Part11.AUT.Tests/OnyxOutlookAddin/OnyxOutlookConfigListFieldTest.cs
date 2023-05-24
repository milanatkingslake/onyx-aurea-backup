using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.OnyxOutlookConfigListField" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxOutlookConfigListFieldTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOutlookConfigListField" />)
        /// </summary>
        public OnyxOutlookConfigListFieldTest() : base(typeof(OnyxOutlookConfigListField))
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

        #region General Initializer : Class (OnyxOutlookConfigListField) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOutlookConfigListFieldInstanceType;
        private OnyxOutlookConfigListField _onyxOutlookConfigListFieldInstance;
        private OnyxOutlookConfigListField _onyxOutlookConfigListFieldInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOutlookConfigListField" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOutlookConfigListFieldInstanceType = typeof(OnyxOutlookConfigListField);
            _onyxOutlookConfigListFieldInstanceFixture = this.Create<OnyxOutlookConfigListField>(false);
            _onyxOutlookConfigListFieldInstance = _onyxOutlookConfigListFieldInstanceFixture ?? this.Create<OnyxOutlookConfigListField>(true);
            CurrentInstance = _onyxOutlookConfigListFieldInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookConfigListField) Initializer

        #region Properties

        private const string PropertyRowIx = "RowIx";
        private const string PropertyPropertyPath = "PropertyPath";
        private const string PropertyFieldName = "FieldName";
        private const string PropertyLabel = "Label";
        private const string PropertyDefaultValue = "DefaultValue";
        private const string PropertyVisible = "Visible";
        private const string PropertyHyperLink = "HyperLink";
        private const string PropertyMaskFormat = "MaskFormat";
        private const string PropertyDataType = "DataType";
        private const string PropertyReferenceField = "ReferenceField";
        private const string PropertyType = "Type";

        #endregion

        #region Methods

        private const string MethodTransformValue = "TransformValue";

        #endregion

        #region Fields

        private const string FieldfieldName = "fieldName";
        private const string FieldpropertyPath = "propertyPath";
        private const string FielddefVal = "defVal";
        private const string Fieldlabel = "label";
        private const string Fieldvisible = "visible";
        private const string Fieldhyperlink = "hyperlink";
        private const string FieldmaskFormat = "maskFormat";
        private const string FielddataType = "dataType";
        private const string FieldrefFieldName = "refFieldName";
        private const string Fieldtype = "type";
        private const string FieldrowIx = "rowIx";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOutlookConfigListField) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookConfigListField_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookConfigListField) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookConfigListField_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookConfigListField) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOutlookConfigListField_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOutlookConfigListField)

        #region General Initializer : Class (OnyxOutlookConfigListField) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTransformValue, 0)]
        public void AUT_OnyxOutlookConfigListField_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (OnyxOutlookConfigListField) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyRowIx)]
        [TestCase(PropertyPropertyPath)]
        [TestCase(PropertyFieldName)]
        [TestCase(PropertyLabel)]
        [TestCase(PropertyDefaultValue)]
        [TestCase(PropertyVisible)]
        [TestCase(PropertyHyperLink)]
        [TestCase(PropertyMaskFormat)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyReferenceField)]
        [TestCase(PropertyType)]
        [Category("AUT Property")]
        public void AUT_OnyxOutlookConfigListField_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (OnyxOutlookConfigListField) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldfieldName)]
        [TestCase(FieldpropertyPath)]
        [TestCase(FielddefVal)]
        [TestCase(Fieldlabel)]
        [TestCase(Fieldvisible)]
        [TestCase(Fieldhyperlink)]
        [TestCase(FieldmaskFormat)]
        [TestCase(FielddataType)]
        [TestCase(FieldrefFieldName)]
        [TestCase(Fieldtype)]
        [TestCase(FieldrowIx)]
        [Category("AUT Fields")]
        public void AUT_OnyxOutlookConfigListField_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxOutlookConfigListField) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookConfigListField_Is_Instance_Present_Test()
        {
            // Assert
            _onyxOutlookConfigListFieldInstanceType.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstance.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxOutlookConfigListField) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOutlookConfigListField" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOutlookConfigListField_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOutlookConfigListFieldInstance.ShouldBeAssignableTo<OnyxOutlookConfigListField>();
            _onyxOutlookConfigListFieldInstanceFixture.ShouldBeAssignableTo<OnyxOutlookConfigListField>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOutlookConfigListField>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxOutlookConfigListField) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOutlookConfigListField_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var fieldXEl = this.CreateType<XElement>();
            OnyxOutlookConfigListField instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOutlookConfigListField(fieldXEl);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstance.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OnyxOutlookConfigListField>();
        }

        #endregion

        #region General Constructor : Class (OnyxOutlookConfigListField) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOutlookConfigListField_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var fieldXEl = this.CreateType<XElement>();
            OnyxOutlookConfigListField instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OnyxOutlookConfigListField(fieldXEl);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstance.ShouldNotBeNull();
            _onyxOutlookConfigListFieldInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyRowIx)]
        [TestCase(PropertyPropertyPath)]
        [TestCase(PropertyFieldName)]
        [TestCase(PropertyLabel)]
        [TestCase(PropertyDefaultValue)]
        [TestCase(PropertyVisible)]
        [TestCase(PropertyHyperLink)]
        [TestCase(PropertyMaskFormat)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyReferenceField)]
        [TestCase(PropertyType)]
        public void AUT_OnyxOutlookConfigListField_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (DataType) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_DataType_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDataType);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (DataType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_DataType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDataType);
            var propertyInfo = this.GetPropertyInfo(PropertyDataType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (DefaultValue) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_DefaultValue_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValue);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValue);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (DefaultValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_DefaultValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValue);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (FieldName) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_FieldName_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldName);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFieldName);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (FieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_FieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldName);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (HyperLink) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_HyperLink_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHyperLink);
            var propertyInfo = this.GetPropertyInfo(PropertyHyperLink);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (Label) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Label_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyLabel);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (Label) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_Label_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLabel);
            var propertyInfo = this.GetPropertyInfo(PropertyLabel);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (MaskFormat) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_MaskFormat_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaskFormat);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMaskFormat);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (MaskFormat) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_MaskFormat_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaskFormat);
            var propertyInfo = this.GetPropertyInfo(PropertyMaskFormat);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (PropertyPath) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_PropertyPath_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyPath);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyPath);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (PropertyPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_PropertyPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPropertyPath);
            var propertyInfo = this.GetPropertyInfo(PropertyPropertyPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (ReferenceField) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_ReferenceField_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceField);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceField);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (ReferenceField) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_ReferenceField_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceField);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceField);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (RowIx) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_RowIx_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRowIx);
            var propertyInfo = this.GetPropertyInfo(PropertyRowIx);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (Type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyType);
            Action currentAction = () => propertyInfo.SetValue(_onyxOutlookConfigListFieldInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxOutlookConfigListField) => Property (Visible) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxOutlookConfigListField_Public_Class_Visible_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyVisible);
            var propertyInfo = this.GetPropertyInfo(PropertyVisible);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (TransformValue) (Return Type : String) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var inVal = this.CreateType<string>();
            var inMask = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxOutlookConfigListFieldInstance.TransformValue(inVal, inMask);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var inVal = this.CreateType<string>();
            var inMask = this.CreateType<string>();
            var returnedValue = default(String);

            // Act
            Action executeAction = () => returnedValue = _onyxOutlookConfigListFieldInstance.TransformValue(inVal, inMask);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var inVal = this.CreateType<string>();
            var inMask = this.CreateType<string>();
            var methodTransformValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfTransformValue = { inVal, inMask };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodTransformValue, methodTransformValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<String>(_onyxOutlookConfigListFieldInstanceFixture, parametersOfTransformValue);
            var result2 = this.GetResultOfMethod<String>(MethodTransformValue, parametersOfTransformValue, methodTransformValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfTransformValue.ShouldNotBeNull();
            parametersOfTransformValue.Length.ShouldBe(2);
            methodTransformValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var inVal = this.CreateType<string>();
            var inMask = this.CreateType<string>();
            var methodTransformValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            object[] parametersOfTransformValue = { inVal, inMask };

            // Act
            Action currentAction = () => this.GetResultOfMethod<String>(MethodTransformValue, parametersOfTransformValue, methodTransformValueParametersTypes);

            // Assert
            parametersOfTransformValue.ShouldNotBeNull();
            parametersOfTransformValue.Length.ShouldBe(2);
            methodTransformValueParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var methodTransformValueParametersTypes = new Type[] { typeof(String), typeof(String) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodTransformValue, methodTransformValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodTransformValueParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var methodTransformValueParametersTypes = new Type[] { typeof(String), typeof(String) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodTransformValue, methodTransformValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodTransformValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var currentMethodInfo = this.GetMethodInfo(MethodTransformValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (TransformValue) (Return Type : String) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOutlookConfigListField_TransformValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodTransformValue);
            var currentMethodInfo = this.GetMethodInfo(MethodTransformValue, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}