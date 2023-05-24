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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportParameter" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportParameterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportParameter" />)
        /// </summary>
        public ReportParameterTest() : base(typeof(ReportParameter))
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

        #region General Initializer : Class (ReportParameter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _reportParameterInstanceType;
        private ReportParameter _reportParameterInstance;
        private ReportParameter _reportParameterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportParameter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportParameterInstanceType = typeof(ReportParameter);
            _reportParameterInstanceFixture = this.Create<ReportParameter>(false);
            _reportParameterInstance = _reportParameterInstanceFixture ?? this.Create<ReportParameter>(true);
            CurrentInstance = _reportParameterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportParameter) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyType = "Type";
        private const string PropertyTypeSpecified = "TypeSpecified";
        private const string PropertyNullable = "Nullable";
        private const string PropertyNullableSpecified = "NullableSpecified";
        private const string PropertyAllowBlank = "AllowBlank";
        private const string PropertyAllowBlankSpecified = "AllowBlankSpecified";
        private const string PropertyMultiValue = "MultiValue";
        private const string PropertyMultiValueSpecified = "MultiValueSpecified";
        private const string PropertyQueryParameter = "QueryParameter";
        private const string PropertyQueryParameterSpecified = "QueryParameterSpecified";
        private const string PropertyPrompt = "Prompt";
        private const string PropertyPromptUser = "PromptUser";
        private const string PropertyPromptUserSpecified = "PromptUserSpecified";
        private const string PropertyDependencies = "Dependencies";
        private const string PropertyValidValuesQueryBased = "ValidValuesQueryBased";
        private const string PropertyValidValuesQueryBasedSpecified = "ValidValuesQueryBasedSpecified";
        private const string PropertyValidValues = "ValidValues";
        private const string PropertyDefaultValuesQueryBased = "DefaultValuesQueryBased";
        private const string PropertyDefaultValuesQueryBasedSpecified = "DefaultValuesQueryBasedSpecified";
        private const string PropertyDefaultValues = "DefaultValues";
        private const string PropertyState = "State";
        private const string PropertyStateSpecified = "StateSpecified";
        private const string PropertyErrorMessage = "ErrorMessage";

        #endregion

        #region Fields

        private const string FieldnameField = "nameField";
        private const string FieldtypeField = "typeField";
        private const string FieldtypeFieldSpecified = "typeFieldSpecified";
        private const string FieldnullableField = "nullableField";
        private const string FieldnullableFieldSpecified = "nullableFieldSpecified";
        private const string FieldallowBlankField = "allowBlankField";
        private const string FieldallowBlankFieldSpecified = "allowBlankFieldSpecified";
        private const string FieldmultiValueField = "multiValueField";
        private const string FieldmultiValueFieldSpecified = "multiValueFieldSpecified";
        private const string FieldqueryParameterField = "queryParameterField";
        private const string FieldqueryParameterFieldSpecified = "queryParameterFieldSpecified";
        private const string FieldpromptField = "promptField";
        private const string FieldpromptUserField = "promptUserField";
        private const string FieldpromptUserFieldSpecified = "promptUserFieldSpecified";
        private const string FielddependenciesField = "dependenciesField";
        private const string FieldvalidValuesQueryBasedField = "validValuesQueryBasedField";
        private const string FieldvalidValuesQueryBasedFieldSpecified = "validValuesQueryBasedFieldSpecified";
        private const string FieldvalidValuesField = "validValuesField";
        private const string FielddefaultValuesQueryBasedField = "defaultValuesQueryBasedField";
        private const string FielddefaultValuesQueryBasedFieldSpecified = "defaultValuesQueryBasedFieldSpecified";
        private const string FielddefaultValuesField = "defaultValuesField";
        private const string FieldstateField = "stateField";
        private const string FieldstateFieldSpecified = "stateFieldSpecified";
        private const string FielderrorMessageField = "errorMessageField";

        #endregion

        #endregion

        #region General Initializer : Class (ReportParameter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportParameter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportParameter) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportParameter_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ReportParameter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ReportParameter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ReportParameter)

        #region General Initializer : Class (ReportParameter) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyTypeSpecified)]
        [TestCase(PropertyNullable)]
        [TestCase(PropertyNullableSpecified)]
        [TestCase(PropertyAllowBlank)]
        [TestCase(PropertyAllowBlankSpecified)]
        [TestCase(PropertyMultiValue)]
        [TestCase(PropertyMultiValueSpecified)]
        [TestCase(PropertyQueryParameter)]
        [TestCase(PropertyQueryParameterSpecified)]
        [TestCase(PropertyPrompt)]
        [TestCase(PropertyPromptUser)]
        [TestCase(PropertyPromptUserSpecified)]
        [TestCase(PropertyDependencies)]
        [TestCase(PropertyValidValuesQueryBased)]
        [TestCase(PropertyValidValuesQueryBasedSpecified)]
        [TestCase(PropertyValidValues)]
        [TestCase(PropertyDefaultValuesQueryBased)]
        [TestCase(PropertyDefaultValuesQueryBasedSpecified)]
        [TestCase(PropertyDefaultValues)]
        [TestCase(PropertyState)]
        [TestCase(PropertyStateSpecified)]
        [TestCase(PropertyErrorMessage)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ReportParameter_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ReportParameter) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldnameField)]
        [TestCase(FieldtypeField)]
        [TestCase(FieldtypeFieldSpecified)]
        [TestCase(FieldnullableField)]
        [TestCase(FieldnullableFieldSpecified)]
        [TestCase(FieldallowBlankField)]
        [TestCase(FieldallowBlankFieldSpecified)]
        [TestCase(FieldmultiValueField)]
        [TestCase(FieldmultiValueFieldSpecified)]
        [TestCase(FieldqueryParameterField)]
        [TestCase(FieldqueryParameterFieldSpecified)]
        [TestCase(FieldpromptField)]
        [TestCase(FieldpromptUserField)]
        [TestCase(FieldpromptUserFieldSpecified)]
        [TestCase(FielddependenciesField)]
        [TestCase(FieldvalidValuesQueryBasedField)]
        [TestCase(FieldvalidValuesQueryBasedFieldSpecified)]
        [TestCase(FieldvalidValuesField)]
        [TestCase(FielddefaultValuesQueryBasedField)]
        [TestCase(FielddefaultValuesQueryBasedFieldSpecified)]
        [TestCase(FielddefaultValuesField)]
        [TestCase(FieldstateField)]
        [TestCase(FieldstateFieldSpecified)]
        [TestCase(FielderrorMessageField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ReportParameter_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ReportParameter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportParameter_Is_Instance_Present_Test()
        {
            // Assert
            _reportParameterInstanceType.ShouldNotBeNull();
            _reportParameterInstance.ShouldNotBeNull();
            _reportParameterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ReportParameter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ReportParameter" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ReportParameter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _reportParameterInstance.ShouldBeAssignableTo<ReportParameter>();
            _reportParameterInstanceFixture.ShouldBeAssignableTo<ReportParameter>();
            CurrentInstance.ShouldBeAssignableTo<ReportParameter>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ReportParameter) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ReportParameter_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ReportParameter instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ReportParameter) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyTypeSpecified)]
        [TestCase(PropertyNullable)]
        [TestCase(PropertyNullableSpecified)]
        [TestCase(PropertyAllowBlank)]
        [TestCase(PropertyAllowBlankSpecified)]
        [TestCase(PropertyMultiValue)]
        [TestCase(PropertyMultiValueSpecified)]
        [TestCase(PropertyQueryParameter)]
        [TestCase(PropertyQueryParameterSpecified)]
        [TestCase(PropertyPrompt)]
        [TestCase(PropertyPromptUser)]
        [TestCase(PropertyPromptUserSpecified)]
        [TestCase(PropertyDependencies)]
        [TestCase(PropertyValidValuesQueryBased)]
        [TestCase(PropertyValidValuesQueryBasedSpecified)]
        [TestCase(PropertyValidValues)]
        [TestCase(PropertyDefaultValuesQueryBased)]
        [TestCase(PropertyDefaultValuesQueryBasedSpecified)]
        [TestCase(PropertyDefaultValues)]
        [TestCase(PropertyState)]
        [TestCase(PropertyStateSpecified)]
        [TestCase(PropertyErrorMessage)]
        public void AUT_ReportParameter_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ReportParameter) => Property (AllowBlank) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_AllowBlank_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowBlank);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowBlank);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (AllowBlankSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_AllowBlankSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowBlankSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowBlankSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (DefaultValues) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_DefaultValues_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValues);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValues);
            Action currentAction = () => propertyInfo.SetValue(_reportParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (DefaultValues) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_DefaultValues_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValues);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValues);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (DefaultValuesQueryBased) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_DefaultValuesQueryBased_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValuesQueryBased);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValuesQueryBased);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (DefaultValuesQueryBasedSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_DefaultValuesQueryBasedSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultValuesQueryBasedSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultValuesQueryBasedSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Dependencies) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Dependencies_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDependencies);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDependencies);
            Action currentAction = () => propertyInfo.SetValue(_reportParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Dependencies) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_Dependencies_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDependencies);
            var propertyInfo = this.GetPropertyInfo(PropertyDependencies);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (ErrorMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_ErrorMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyErrorMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyErrorMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (MultiValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_MultiValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMultiValue);
            var propertyInfo = this.GetPropertyInfo(PropertyMultiValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (MultiValueSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_MultiValueSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMultiValueSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyMultiValueSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ReportParameter) => Property (Nullable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_Nullable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNullable);
            var propertyInfo = this.GetPropertyInfo(PropertyNullable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (NullableSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_NullableSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNullableSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyNullableSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Prompt) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_Prompt_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrompt);
            var propertyInfo = this.GetPropertyInfo(PropertyPrompt);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (PromptUser) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_PromptUser_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPromptUser);
            var propertyInfo = this.GetPropertyInfo(PropertyPromptUser);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (PromptUserSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_PromptUserSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPromptUserSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyPromptUserSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (QueryParameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_QueryParameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryParameter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (QueryParameterSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_QueryParameterSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryParameterSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryParameterSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (State) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_State_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyState);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyState);
            Action currentAction = () => propertyInfo.SetValue(_reportParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (State) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_State_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyState);
            var propertyInfo = this.GetPropertyInfo(PropertyState);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (StateSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_StateSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStateSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyStateSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyType);
            Action currentAction = () => propertyInfo.SetValue(_reportParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ReportParameter) => Property (TypeSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_TypeSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTypeSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyTypeSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (ValidValues) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_ValidValues_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidValues);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyValidValues);
            Action currentAction = () => propertyInfo.SetValue(_reportParameterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (ValidValues) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_ValidValues_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ReportParameter) => Property (ValidValuesQueryBased) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_ValidValuesQueryBased_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidValuesQueryBased);
            var propertyInfo = this.GetPropertyInfo(PropertyValidValuesQueryBased);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ReportParameter) => Property (ValidValuesQueryBasedSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ReportParameter_Public_Class_ValidValuesQueryBasedSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValidValuesQueryBasedSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyValidValuesQueryBasedSpecified);

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