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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ExtensionParameter" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ExtensionParameterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExtensionParameter" />)
        /// </summary>
        public ExtensionParameterTest() : base(typeof(ExtensionParameter))
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

        #region General Initializer : Class (ExtensionParameter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extensionParameterInstanceType;
        private ExtensionParameter _extensionParameterInstance;
        private ExtensionParameter _extensionParameterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ExtensionParameter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extensionParameterInstanceType = typeof(ExtensionParameter);
            _extensionParameterInstanceFixture = this.Create<ExtensionParameter>(false);
            _extensionParameterInstance = _extensionParameterInstanceFixture ?? this.Create<ExtensionParameter>(true);
            CurrentInstance = _extensionParameterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExtensionParameter) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyRequired = "Required";
        private const string PropertyRequiredSpecified = "RequiredSpecified";
        private const string PropertyReadOnly = "ReadOnly";
        private const string PropertyValue = "Value";
        private const string PropertyError = "Error";
        private const string PropertyEncrypted = "Encrypted";
        private const string PropertyIsPassword = "IsPassword";
        private const string PropertyValidValues = "ValidValues";

        #endregion

        #region Fields

        private const string FieldnameField = "nameField";
        private const string FielddisplayNameField = "displayNameField";
        private const string FieldrequiredField = "requiredField";
        private const string FieldrequiredFieldSpecified = "requiredFieldSpecified";
        private const string FieldreadOnlyField = "readOnlyField";
        private const string FieldvalueField = "valueField";
        private const string FielderrorField = "errorField";
        private const string FieldencryptedField = "encryptedField";
        private const string FieldisPasswordField = "isPasswordField";
        private const string FieldvalidValuesField = "validValuesField";

        #endregion

        #endregion

        #region General Initializer : Class (ExtensionParameter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionParameter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionParameter) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionParameter_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionParameter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionParameter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExtensionParameter)

        #region General Initializer : Class (ExtensionParameter) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyRequiredSpecified)]
        [TestCase(PropertyReadOnly)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyError)]
        [TestCase(PropertyEncrypted)]
        [TestCase(PropertyIsPassword)]
        [TestCase(PropertyValidValues)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ExtensionParameter_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ExtensionParameter) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldnameField)]
        [TestCase(FielddisplayNameField)]
        [TestCase(FieldrequiredField)]
        [TestCase(FieldrequiredFieldSpecified)]
        [TestCase(FieldreadOnlyField)]
        [TestCase(FieldvalueField)]
        [TestCase(FielderrorField)]
        [TestCase(FieldencryptedField)]
        [TestCase(FieldisPasswordField)]
        [TestCase(FieldvalidValuesField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ExtensionParameter_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ExtensionParameter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExtensionParameter_Is_Instance_Present_Test()
        {
            // Assert
            _extensionParameterInstanceType.ShouldNotBeNull();
            _extensionParameterInstance.ShouldNotBeNull();
            _extensionParameterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExtensionParameter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExtensionParameter" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExtensionParameter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _extensionParameterInstance.ShouldBeAssignableTo<ExtensionParameter>();
            _extensionParameterInstanceFixture.ShouldBeAssignableTo<ExtensionParameter>();
            CurrentInstance.ShouldBeAssignableTo<ExtensionParameter>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExtensionParameter) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ExtensionParameter_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ExtensionParameter instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ExtensionParameter) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyRequiredSpecified)]
        [TestCase(PropertyReadOnly)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyError)]
        [TestCase(PropertyEncrypted)]
        [TestCase(PropertyIsPassword)]
        [TestCase(PropertyValidValues)]
        public void AUT_ExtensionParameter_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ExtensionParameter) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ExtensionParameter) => Property (Encrypted) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_Encrypted_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEncrypted);
            var propertyInfo = this.GetPropertyInfo(PropertyEncrypted);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (Error) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_Error_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyError);
            var propertyInfo = this.GetPropertyInfo(PropertyError);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (IsPassword) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_IsPassword_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyIsPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ExtensionParameter) => Property (ReadOnly) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_ReadOnly_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReadOnly);
            var propertyInfo = this.GetPropertyInfo(PropertyReadOnly);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (Required) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_Required_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequired);
            var propertyInfo = this.GetPropertyInfo(PropertyRequired);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (RequiredSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_RequiredSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequiredSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyRequiredSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (ValidValues) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_ValidValues_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidValues);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyValidValues);
            Action currentAction = () => propertyInfo.SetValue(_extensionParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (ValidValues) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_ValidValues_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidValues);
            var propertyInfo = this.GetPropertyInfo(PropertyValidValues);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionParameter) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionParameter_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValue);
            var propertyInfo = this.GetPropertyInfo(PropertyValue);

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