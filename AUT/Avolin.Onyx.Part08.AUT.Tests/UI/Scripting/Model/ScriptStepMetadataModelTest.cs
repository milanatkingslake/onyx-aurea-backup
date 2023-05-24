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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ScriptStepMetadataModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptStepMetadataModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptStepMetadataModel" />)
        /// </summary>
        public ScriptStepMetadataModelTest() : base(typeof(ScriptStepMetadataModel))
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

        #region General Initializer : Class (ScriptStepMetadataModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptStepMetadataModelInstanceType;
        private ScriptStepMetadataModel _scriptStepMetadataModelInstance;
        private ScriptStepMetadataModel _scriptStepMetadataModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptStepMetadataModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptStepMetadataModelInstanceType = typeof(ScriptStepMetadataModel);
            _scriptStepMetadataModelInstanceFixture = this.Create<ScriptStepMetadataModel>(false);
            _scriptStepMetadataModelInstance = _scriptStepMetadataModelInstanceFixture ?? this.Create<ScriptStepMetadataModel>(true);
            CurrentInstance = _scriptStepMetadataModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataModel) Initializer

        #region Properties

        private const string PropertyFinalStep = "FinalStep";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyName = "Name";
        private const string PropertyDescription = "Description";
        private const string PropertyHeaderText = "HeaderText";
        private const string PropertyFooterText = "FooterText";
        private const string PropertyTop = "Top";
        private const string PropertyLeft = "Left";
        private const string PropertyHeight = "Height";
        private const string PropertyWidth = "Width";
        private const string PropertyActive = "Active";
        private const string PropertyStepPrompts = "StepPrompts";
        private const string PropertyStepRules = "StepRules";
        private const string PropertyStepMethodCalls = "StepMethodCalls";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptStepMetadataModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptStepMetadataModel)

        #region General Initializer : Class (ScriptStepMetadataModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyFinalStep)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyHeaderText)]
        [TestCase(PropertyFooterText)]
        [TestCase(PropertyTop)]
        [TestCase(PropertyLeft)]
        [TestCase(PropertyHeight)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyStepPrompts)]
        [TestCase(PropertyStepRules)]
        [TestCase(PropertyStepMethodCalls)]
        [Category("AUT Property")]
        public void AUT_ScriptStepMetadataModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptStepMetadataModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepMetadataModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptStepMetadataModelInstanceType.ShouldNotBeNull();
            _scriptStepMetadataModelInstance.ShouldNotBeNull();
            _scriptStepMetadataModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptStepMetadataModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepMetadataModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptStepMetadataModelInstance.ShouldBeAssignableTo<ScriptStepMetadataModel>();
            _scriptStepMetadataModelInstanceFixture.ShouldBeAssignableTo<ScriptStepMetadataModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptStepMetadataModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptStepMetadataModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptStepMetadataModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyFinalStep)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyHeaderText)]
        [TestCase(PropertyFooterText)]
        [TestCase(PropertyTop)]
        [TestCase(PropertyLeft)]
        [TestCase(PropertyHeight)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyStepPrompts)]
        [TestCase(PropertyStepRules)]
        [TestCase(PropertyStepMethodCalls)]
        public void AUT_ScriptStepMetadataModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (FinalStep) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_FinalStep_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFinalStep);
            var propertyInfo = this.GetPropertyInfo(PropertyFinalStep);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (FooterText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_FooterText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFooterText);
            var propertyInfo = this.GetPropertyInfo(PropertyFooterText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (HeaderText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_HeaderText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeaderText);
            var propertyInfo = this.GetPropertyInfo(PropertyHeaderText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Height) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Height_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHeight);
            var propertyInfo = this.GetPropertyInfo(PropertyHeight);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Left) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Left_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLeft);
            var propertyInfo = this.GetPropertyInfo(PropertyLeft);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (StepMethodCalls) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_StepMethodCalls_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepMethodCalls);
            var propertyInfo = this.GetPropertyInfo(PropertyStepMethodCalls);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (StepPrompts) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_StepPrompts_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepPrompts);
            var propertyInfo = this.GetPropertyInfo(PropertyStepPrompts);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (StepRules) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_StepRules_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepRules);
            var propertyInfo = this.GetPropertyInfo(PropertyStepRules);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Top) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Top_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTop);
            var propertyInfo = this.GetPropertyInfo(PropertyTop);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepMetadataModel) => Property (Width) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataModel_Public_Class_Width_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWidth);
            var propertyInfo = this.GetPropertyInfo(PropertyWidth);

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