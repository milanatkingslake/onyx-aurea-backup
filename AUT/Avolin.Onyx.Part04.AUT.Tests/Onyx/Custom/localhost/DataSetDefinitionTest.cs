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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.DataSetDefinition" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DataSetDefinitionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DataSetDefinition" />)
        /// </summary>
        public DataSetDefinitionTest() : base(typeof(DataSetDefinition))
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

        #region General Initializer : Class (DataSetDefinition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _dataSetDefinitionInstanceType;
        private DataSetDefinition _dataSetDefinitionInstance;
        private DataSetDefinition _dataSetDefinitionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DataSetDefinition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _dataSetDefinitionInstanceType = typeof(DataSetDefinition);
            _dataSetDefinitionInstanceFixture = this.Create<DataSetDefinition>(false);
            _dataSetDefinitionInstance = _dataSetDefinitionInstanceFixture ?? this.Create<DataSetDefinition>(true);
            CurrentInstance = _dataSetDefinitionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DataSetDefinition) Initializer

        #region Properties

        private const string PropertyFields = "Fields";
        private const string PropertyQuery = "Query";
        private const string PropertyCaseSensitivity = "CaseSensitivity";
        private const string PropertyCaseSensitivitySpecified = "CaseSensitivitySpecified";
        private const string PropertyCollation = "Collation";
        private const string PropertyAccentSensitivity = "AccentSensitivity";
        private const string PropertyAccentSensitivitySpecified = "AccentSensitivitySpecified";
        private const string PropertyKanatypeSensitivity = "KanatypeSensitivity";
        private const string PropertyKanatypeSensitivitySpecified = "KanatypeSensitivitySpecified";
        private const string PropertyWidthSensitivity = "WidthSensitivity";
        private const string PropertyWidthSensitivitySpecified = "WidthSensitivitySpecified";
        private const string PropertyName = "Name";

        #endregion

        #region Fields

        private const string FieldfieldsField = "fieldsField";
        private const string FieldqueryField = "queryField";
        private const string FieldcaseSensitivityField = "caseSensitivityField";
        private const string FieldcaseSensitivityFieldSpecified = "caseSensitivityFieldSpecified";
        private const string FieldcollationField = "collationField";
        private const string FieldaccentSensitivityField = "accentSensitivityField";
        private const string FieldaccentSensitivityFieldSpecified = "accentSensitivityFieldSpecified";
        private const string FieldkanatypeSensitivityField = "kanatypeSensitivityField";
        private const string FieldkanatypeSensitivityFieldSpecified = "kanatypeSensitivityFieldSpecified";
        private const string FieldwidthSensitivityField = "widthSensitivityField";
        private const string FieldwidthSensitivityFieldSpecified = "widthSensitivityFieldSpecified";
        private const string FieldnameField = "nameField";

        #endregion

        #endregion

        #region General Initializer : Class (DataSetDefinition) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSetDefinition_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataSetDefinition) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSetDefinition_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DataSetDefinition) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DataSetDefinition_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DataSetDefinition)

        #region General Initializer : Class (DataSetDefinition) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyFields)]
        [TestCase(PropertyQuery)]
        [TestCase(PropertyCaseSensitivity)]
        [TestCase(PropertyCaseSensitivitySpecified)]
        [TestCase(PropertyCollation)]
        [TestCase(PropertyAccentSensitivity)]
        [TestCase(PropertyAccentSensitivitySpecified)]
        [TestCase(PropertyKanatypeSensitivity)]
        [TestCase(PropertyKanatypeSensitivitySpecified)]
        [TestCase(PropertyWidthSensitivity)]
        [TestCase(PropertyWidthSensitivitySpecified)]
        [TestCase(PropertyName)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_DataSetDefinition_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DataSetDefinition) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldfieldsField)]
        [TestCase(FieldqueryField)]
        [TestCase(FieldcaseSensitivityField)]
        [TestCase(FieldcaseSensitivityFieldSpecified)]
        [TestCase(FieldcollationField)]
        [TestCase(FieldaccentSensitivityField)]
        [TestCase(FieldaccentSensitivityFieldSpecified)]
        [TestCase(FieldkanatypeSensitivityField)]
        [TestCase(FieldkanatypeSensitivityFieldSpecified)]
        [TestCase(FieldwidthSensitivityField)]
        [TestCase(FieldwidthSensitivityFieldSpecified)]
        [TestCase(FieldnameField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_DataSetDefinition_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DataSetDefinition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSetDefinition_Is_Instance_Present_Test()
        {
            // Assert
            _dataSetDefinitionInstanceType.ShouldNotBeNull();
            _dataSetDefinitionInstance.ShouldNotBeNull();
            _dataSetDefinitionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DataSetDefinition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DataSetDefinition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DataSetDefinition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _dataSetDefinitionInstance.ShouldBeAssignableTo<DataSetDefinition>();
            _dataSetDefinitionInstanceFixture.ShouldBeAssignableTo<DataSetDefinition>();
            CurrentInstance.ShouldBeAssignableTo<DataSetDefinition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DataSetDefinition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_DataSetDefinition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DataSetDefinition instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DataSetDefinition) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyFields)]
        [TestCase(PropertyQuery)]
        [TestCase(PropertyCaseSensitivity)]
        [TestCase(PropertyCaseSensitivitySpecified)]
        [TestCase(PropertyCollation)]
        [TestCase(PropertyAccentSensitivity)]
        [TestCase(PropertyAccentSensitivitySpecified)]
        [TestCase(PropertyKanatypeSensitivity)]
        [TestCase(PropertyKanatypeSensitivitySpecified)]
        [TestCase(PropertyWidthSensitivity)]
        [TestCase(PropertyWidthSensitivitySpecified)]
        [TestCase(PropertyName)]
        public void AUT_DataSetDefinition_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DataSetDefinition) => Property (AccentSensitivity) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_AccentSensitivity_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccentSensitivity);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAccentSensitivity);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (AccentSensitivity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_AccentSensitivity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccentSensitivity);
            var propertyInfo = this.GetPropertyInfo(PropertyAccentSensitivity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (AccentSensitivitySpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_AccentSensitivitySpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAccentSensitivitySpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyAccentSensitivitySpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (CaseSensitivity) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_CaseSensitivity_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaseSensitivity);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCaseSensitivity);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (CaseSensitivity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_CaseSensitivity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaseSensitivity);
            var propertyInfo = this.GetPropertyInfo(PropertyCaseSensitivity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (CaseSensitivitySpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_CaseSensitivitySpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaseSensitivitySpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyCaseSensitivitySpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Collation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_Collation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCollation);
            var propertyInfo = this.GetPropertyInfo(PropertyCollation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Fields) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Fields_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFields);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyFields);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Fields) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_Fields_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFields);
            var propertyInfo = this.GetPropertyInfo(PropertyFields);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (KanatypeSensitivity) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_KanatypeSensitivity_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKanatypeSensitivity);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyKanatypeSensitivity);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (KanatypeSensitivity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_KanatypeSensitivity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKanatypeSensitivity);
            var propertyInfo = this.GetPropertyInfo(PropertyKanatypeSensitivity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (KanatypeSensitivitySpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_KanatypeSensitivitySpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKanatypeSensitivitySpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyKanatypeSensitivitySpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Query) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Query_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuery);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyQuery);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (Query) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_Query_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (WidthSensitivity) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_WidthSensitivity_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWidthSensitivity);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyWidthSensitivity);
            Action currentAction = () => propertyInfo.SetValue(_dataSetDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (WidthSensitivity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_WidthSensitivity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWidthSensitivity);
            var propertyInfo = this.GetPropertyInfo(PropertyWidthSensitivity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DataSetDefinition) => Property (WidthSensitivitySpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DataSetDefinition_Public_Class_WidthSensitivitySpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWidthSensitivitySpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyWidthSensitivitySpecified);

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