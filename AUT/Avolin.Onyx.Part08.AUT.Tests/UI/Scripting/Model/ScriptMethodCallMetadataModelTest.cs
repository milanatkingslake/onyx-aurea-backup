using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ScriptMethodCallMetadataModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptMethodCallMetadataModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptMethodCallMetadataModel" />)
        /// </summary>
        public ScriptMethodCallMetadataModelTest() : base(typeof(ScriptMethodCallMetadataModel))
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

        #region General Initializer : Class (ScriptMethodCallMetadataModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptMethodCallMetadataModelInstanceType;
        private ScriptMethodCallMetadataModel _scriptMethodCallMetadataModelInstance;
        private ScriptMethodCallMetadataModel _scriptMethodCallMetadataModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptMethodCallMetadataModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptMethodCallMetadataModelInstanceType = typeof(ScriptMethodCallMetadataModel);
            _scriptMethodCallMetadataModelInstanceFixture = this.Create<ScriptMethodCallMetadataModel>(false);
            _scriptMethodCallMetadataModelInstance = _scriptMethodCallMetadataModelInstanceFixture ?? this.Create<ScriptMethodCallMetadataModel>(true);
            CurrentInstance = _scriptMethodCallMetadataModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptMethodCallMetadataModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyName = "Name";
        private const string PropertyControlTypeCode = "ControlTypeCode";
        private const string PropertyDescription = "Description";
        private const string PropertyAllowUserInput = "AllowUserInput";
        private const string PropertyRequiresResponseList = "RequiresResponseList";
        private const string PropertyAllowSort = "AllowSort";
        private const string PropertyMultiSelect = "MultiSelect";
        private const string PropertyAllowEditableResponses = "AllowEditableResponses";
        private const string PropertyRequiresDataType = "RequiresDataType";
        private const string PropertyAllowText = "AllowText";
        private const string PropertyAllowInitialValue = "AllowInitialValue";
        private const string PropertyAllowMinMax = "AllowMinMax";
        
        private const string PropertyAllowExtraData = "AllowExtraData";
        private const string PropertyDefaultExtraData = "DefaultExtraData";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptMethodCallMetadataModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMethodCallMetadataModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptMethodCallMetadataModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMethodCallMetadataModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptMethodCallMetadataModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMethodCallMetadataModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptMethodCallMetadataModel)

        #region General Initializer : Class (ScriptMethodCallMetadataModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyAllowUserInput)]
        [TestCase(PropertyRequiresResponseList)]
        [TestCase(PropertyAllowSort)]
        [TestCase(PropertyMultiSelect)]
        [TestCase(PropertyAllowEditableResponses)]
        [TestCase(PropertyRequiresDataType)]
        [TestCase(PropertyAllowText)]
        [TestCase(PropertyAllowInitialValue)]
        [TestCase(PropertyAllowMinMax)]
        [TestCase(PropertyAllowExtraData)]
        [TestCase(PropertyDefaultExtraData)]
        [Category("AUT Property")]
        public void AUT_ScriptMethodCallMetadataModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptMethodCallMetadataModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptMethodCallMetadataModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptMethodCallMetadataModelInstanceType.ShouldNotBeNull();
            _scriptMethodCallMetadataModelInstance.ShouldNotBeNull();
            _scriptMethodCallMetadataModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptMethodCallMetadataModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptMethodCallMetadataModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptMethodCallMetadataModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptMethodCallMetadataModelInstance.ShouldBeAssignableTo<ScriptMethodCallMetadataModel>();
            _scriptMethodCallMetadataModelInstanceFixture.ShouldBeAssignableTo<ScriptMethodCallMetadataModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptMethodCallMetadataModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptMethodCallMetadataModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMethodCallMetadataModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptMethodCallMetadataModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyAllowUserInput)]
        [TestCase(PropertyRequiresResponseList)]
        [TestCase(PropertyAllowSort)]
        [TestCase(PropertyMultiSelect)]
        [TestCase(PropertyAllowEditableResponses)]
        [TestCase(PropertyRequiresDataType)]
        [TestCase(PropertyAllowText)]
        [TestCase(PropertyAllowInitialValue)]
        [TestCase(PropertyAllowMinMax)]
        [TestCase(PropertyAllowExtraData)]
        [TestCase(PropertyDefaultExtraData)]
        public void AUT_ScriptMethodCallMetadataModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowEditableResponses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowEditableResponses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowEditableResponses);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowEditableResponses);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowExtraData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowExtraData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowExtraData);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowExtraData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowInitialValue) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowInitialValue_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowInitialValue);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowInitialValue);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowMinMax) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowMinMax_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowMinMax);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowMinMax);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowSort) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowSort_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowSort);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowSort);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowText);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (AllowUserInput) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_AllowUserInput_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAllowUserInput);
            var propertyInfo = this.GetPropertyInfo(PropertyAllowUserInput);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (ControlTypeCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_ControlTypeCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyControlTypeCode);
            var propertyInfo = this.GetPropertyInfo(PropertyControlTypeCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (DefaultExtraData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_DefaultExtraData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultExtraData);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultExtraData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (MultiSelect) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_MultiSelect_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMultiSelect);
            var propertyInfo = this.GetPropertyInfo(PropertyMultiSelect);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (RequiresDataType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_RequiresDataType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequiresDataType);
            var propertyInfo = this.GetPropertyInfo(PropertyRequiresDataType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMethodCallMetadataModel) => Property (RequiresResponseList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMethodCallMetadataModel_Public_Class_RequiresResponseList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRequiresResponseList);
            var propertyInfo = this.GetPropertyInfo(PropertyRequiresResponseList);

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