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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ScriptStepPromptMetadataModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptStepPromptMetadataModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptStepPromptMetadataModel" />)
        /// </summary>
        public ScriptStepPromptMetadataModelTest() : base(typeof(ScriptStepPromptMetadataModel))
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

        #region General Initializer : Class (ScriptStepPromptMetadataModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptStepPromptMetadataModelInstanceType;
        private ScriptStepPromptMetadataModel _scriptStepPromptMetadataModelInstance;
        private ScriptStepPromptMetadataModel _scriptStepPromptMetadataModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptStepPromptMetadataModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptStepPromptMetadataModelInstanceType = typeof(ScriptStepPromptMetadataModel);
            _scriptStepPromptMetadataModelInstanceFixture = this.Create<ScriptStepPromptMetadataModel>(false);
            _scriptStepPromptMetadataModelInstance = _scriptStepPromptMetadataModelInstanceFixture ?? this.Create<ScriptStepPromptMetadataModel>(true);
            CurrentInstance = _scriptStepPromptMetadataModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyName = "Name";
        private const string PropertyScriptId = "ScriptId";
        private const string PropertyScriptStepId = "ScriptStepId";
        private const string PropertySequenceNumber = "SequenceNumber";
        private const string PropertyText = "Text";
        private const string PropertyDataType = "DataType";
        private const string PropertyControlTypeCode = "ControlTypeCode";
        private const string PropertyReadOnly = "ReadOnly";
        
        private const string PropertySortResponsesInUi = "SortResponsesInUi";
        private const string PropertyMin = "Min";
        private const string PropertyMax = "Max";
        private const string PropertyRequired = "Required";
        private const string PropertyDefault = "Default";
        private const string PropertyInValueVariableName = "InValueVariableName";
        private const string PropertyOutValueVariableName = "OutValueVariableName";
        private const string PropertyDisplayListVariableName = "DisplayListVariableName";
        private const string PropertyExtraData = "ExtraData";
        private const string PropertyActive = "Active";
        private const string PropertyPromptResponses = "PromptResponses";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptStepPromptMetadataModel)

        #region General Initializer : Class (ScriptStepPromptMetadataModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyScriptId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyText)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyReadOnly)]
        [TestCase(PropertySortResponsesInUi)]
        [TestCase(PropertyMin)]
        [TestCase(PropertyMax)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyDefault)]
        [TestCase(PropertyInValueVariableName)]
        [TestCase(PropertyOutValueVariableName)]
        [TestCase(PropertyDisplayListVariableName)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyPromptResponses)]
        [Category("AUT Property")]
        public void AUT_ScriptStepPromptMetadataModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptStepPromptMetadataModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptMetadataModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptStepPromptMetadataModelInstanceType.ShouldNotBeNull();
            _scriptStepPromptMetadataModelInstance.ShouldNotBeNull();
            _scriptStepPromptMetadataModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptStepPromptMetadataModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptMetadataModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptStepPromptMetadataModelInstance.ShouldBeAssignableTo<ScriptStepPromptMetadataModel>();
            _scriptStepPromptMetadataModelInstanceFixture.ShouldBeAssignableTo<ScriptStepPromptMetadataModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptStepPromptMetadataModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptStepPromptMetadataModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepPromptMetadataModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptStepPromptMetadataModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyScriptId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyText)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyReadOnly)]
        [TestCase(PropertySortResponsesInUi)]
        [TestCase(PropertyMin)]
        [TestCase(PropertyMax)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyDefault)]
        [TestCase(PropertyInValueVariableName)]
        [TestCase(PropertyOutValueVariableName)]
        [TestCase(PropertyDisplayListVariableName)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyPromptResponses)]
        public void AUT_ScriptStepPromptMetadataModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var propertyInfo = this.GetPropertyInfo(PropertyActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (ControlTypeCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_ControlTypeCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (DataType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_DataType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Default) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Default_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefault);
            var propertyInfo = this.GetPropertyInfo(PropertyDefault);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (DisplayListVariableName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_DisplayListVariableName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayListVariableName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayListVariableName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (ExtraData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_ExtraData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtraData);
            var propertyInfo = this.GetPropertyInfo(PropertyExtraData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (InValueVariableName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_InValueVariableName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInValueVariableName);
            var propertyInfo = this.GetPropertyInfo(PropertyInValueVariableName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Max) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Max_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMax);
            var propertyInfo = this.GetPropertyInfo(PropertyMax);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Min) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Min_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMin);
            var propertyInfo = this.GetPropertyInfo(PropertyMin);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (OutValueVariableName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_OutValueVariableName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutValueVariableName);
            var propertyInfo = this.GetPropertyInfo(PropertyOutValueVariableName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (PromptResponses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_PromptResponses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPromptResponses);
            var propertyInfo = this.GetPropertyInfo(PropertyPromptResponses);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (ReadOnly) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_ReadOnly_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Required) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Required_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (ScriptId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_ScriptId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptId);
            var propertyInfo = this.GetPropertyInfo(PropertyScriptId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (ScriptStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_ScriptStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptStepId);
            var propertyInfo = this.GetPropertyInfo(PropertyScriptStepId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (SequenceNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_SequenceNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequenceNumber);
            var propertyInfo = this.GetPropertyInfo(PropertySequenceNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (SortResponsesInUi) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_SortResponsesInUi_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortResponsesInUi);
            var propertyInfo = this.GetPropertyInfo(PropertySortResponsesInUi);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataModel) => Property (Text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataModel_Public_Class_Text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyText);
            var propertyInfo = this.GetPropertyInfo(PropertyText);

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