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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.ScriptSessionPromptResponseModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionPromptResponseModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionPromptResponseModel" />)
        /// </summary>
        public ScriptSessionPromptResponseModelTest() : base(typeof(ScriptSessionPromptResponseModel))
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

        #region General Initializer : Class (ScriptSessionPromptResponseModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionPromptResponseModelInstanceType;
        private ScriptSessionPromptResponseModel _scriptSessionPromptResponseModelInstance;
        private ScriptSessionPromptResponseModel _scriptSessionPromptResponseModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionPromptResponseModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionPromptResponseModelInstanceType = typeof(ScriptSessionPromptResponseModel);
            _scriptSessionPromptResponseModelInstanceFixture = this.Create<ScriptSessionPromptResponseModel>(false);
            _scriptSessionPromptResponseModelInstance = _scriptSessionPromptResponseModelInstanceFixture ?? this.Create<ScriptSessionPromptResponseModel>(true);
            CurrentInstance = _scriptSessionPromptResponseModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionPromptResponseModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySessionStepId = "SessionStepId";
        private const string PropertyStepPromptId = "StepPromptId";
        private const string PropertyScriptStepId = "ScriptStepId";
        private const string PropertyControlType = "ControlType";
        private const string PropertyResponseCode = "ResponseCode";
        private const string PropertyValue = "Value";
        private const string PropertyAdditionalText = "AdditionalText";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionPromptResponseModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionPromptResponseModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionPromptResponseModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionPromptResponseModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionPromptResponseModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionPromptResponseModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionPromptResponseModel)

        #region General Initializer : Class (ScriptSessionPromptResponseModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySessionStepId)]
        [TestCase(PropertyStepPromptId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyResponseCode)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyAdditionalText)]
        [Category("AUT Property")]
        public void AUT_ScriptSessionPromptResponseModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionPromptResponseModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionPromptResponseModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionPromptResponseModelInstanceType.ShouldNotBeNull();
            _scriptSessionPromptResponseModelInstance.ShouldNotBeNull();
            _scriptSessionPromptResponseModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionPromptResponseModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionPromptResponseModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionPromptResponseModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionPromptResponseModelInstance.ShouldBeAssignableTo<ScriptSessionPromptResponseModel>();
            _scriptSessionPromptResponseModelInstanceFixture.ShouldBeAssignableTo<ScriptSessionPromptResponseModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionPromptResponseModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionPromptResponseModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionPromptResponseModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionPromptResponseModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySessionStepId)]
        [TestCase(PropertyStepPromptId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyResponseCode)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyAdditionalText)]
        public void AUT_ScriptSessionPromptResponseModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (AdditionalText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_AdditionalText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAdditionalText);
            var propertyInfo = this.GetPropertyInfo(PropertyAdditionalText);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (ControlType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_ControlType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyControlType);
            var propertyInfo = this.GetPropertyInfo(PropertyControlType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (ResponseCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_ResponseCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResponseCode);
            var propertyInfo = this.GetPropertyInfo(PropertyResponseCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (ScriptStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_ScriptStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (SessionStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_SessionStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionStepId);
            var propertyInfo = this.GetPropertyInfo(PropertySessionStepId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (StepPromptId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_StepPromptId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepPromptId);
            var propertyInfo = this.GetPropertyInfo(PropertyStepPromptId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionPromptResponseModel) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionPromptResponseModel_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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