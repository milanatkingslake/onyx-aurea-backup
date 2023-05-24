using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Onyx.UI.Scripting.ScriptSession;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.ScriptSession
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptStepPromptResponseMetadataCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptStepPromptResponseMetadataCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />)
        /// </summary>
        public ScriptStepPromptResponseMetadataCPTLBusinessModelTest() : base(typeof(ScriptStepPromptResponseMetadataCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceType;
        private ScriptStepPromptResponseMetadataCPTLBusinessModel _scriptStepPromptResponseMetadataCPTLBusinessModelInstance;
        private ScriptStepPromptResponseMetadataCPTLBusinessModel _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceType = typeof(ScriptStepPromptResponseMetadataCPTLBusinessModel);
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture = this.Create<ScriptStepPromptResponseMetadataCPTLBusinessModel>(false);
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstance = _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture ?? this.Create<ScriptStepPromptResponseMetadataCPTLBusinessModel>(true);
            CurrentInstance = _scriptStepPromptResponseMetadataCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyEditable = "Editable";
        private const string PropertyResponseCode = "ResponseCode";
        private const string PropertyText = "Text";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel)

        #region General Initializer : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEditable)]
        [TestCase(PropertyResponseCode)]
        [TestCase(PropertyText)]
        [Category("AUT Property")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptResponseMetadataCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptStepPromptResponseMetadataCPTLBusinessModel>();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptStepPromptResponseMetadataCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptStepPromptResponseMetadataCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepPromptResponseMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepPromptResponseMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptStepPromptResponseMetadataCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepPromptResponseMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepPromptResponseMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptResponseMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEditable)]
        [TestCase(PropertyResponseCode)]
        [TestCase(PropertyText)]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) => Property (Editable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Public_Class_Editable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEditable);
            var propertyInfo = this.GetPropertyInfo(PropertyEditable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) => Property (ResponseCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Public_Class_ResponseCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptResponseMetadataCPTLBusinessModel) => Property (Text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptResponseMetadataCPTLBusinessModel_Public_Class_Text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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