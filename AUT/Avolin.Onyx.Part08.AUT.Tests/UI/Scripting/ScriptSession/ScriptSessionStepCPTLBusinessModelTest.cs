using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptSessionStepCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionStepCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionStepCPTLBusinessModel" />)
        /// </summary>
        public ScriptSessionStepCPTLBusinessModelTest() : base(typeof(ScriptSessionStepCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionStepCPTLBusinessModelInstanceType;
        private ScriptSessionStepCPTLBusinessModel _scriptSessionStepCPTLBusinessModelInstance;
        private ScriptSessionStepCPTLBusinessModel _scriptSessionStepCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionStepCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionStepCPTLBusinessModelInstanceType = typeof(ScriptSessionStepCPTLBusinessModel);
            _scriptSessionStepCPTLBusinessModelInstanceFixture = this.Create<ScriptSessionStepCPTLBusinessModel>(false);
            _scriptSessionStepCPTLBusinessModelInstance = _scriptSessionStepCPTLBusinessModelInstanceFixture ?? this.Create<ScriptSessionStepCPTLBusinessModel>(true);
            CurrentInstance = _scriptSessionStepCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyContent = "Content";
        private const string PropertyAction = "Action";
        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyScriptSessionId = "ScriptSessionId";
        private const string PropertyScriptStepId = "ScriptStepId";
        private const string PropertySequenceNumber = "SequenceNumber";
        private const string PropertyCompleted = "Completed";
        private const string PropertyStepPromptResponses = "StepPromptResponses";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionStepCPTLBusinessModel)

        #region General Initializer : Class (ScriptSessionStepCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyContent)]
        [TestCase(PropertyAction)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyScriptSessionId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyCompleted)]
        [TestCase(PropertyStepPromptResponses)]
        [Category("AUT Property")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionStepCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionStepCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionStepCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionStepCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptSessionStepCPTLBusinessModel>();
            _scriptSessionStepCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptSessionStepCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionStepCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionStepCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionStepCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionStepCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptSessionStepCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionStepCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionStepCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptSessionStepCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptSessionStepCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionStepCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptSessionStepCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionStepCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionStepCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptSessionStepCPTLBusinessModelParametersTypes = new Type[] { typeof(JObject) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionStepCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyContent)]
        [TestCase(PropertyAction)]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyScriptSessionId)]
        [TestCase(PropertyScriptStepId)]
        [TestCase(PropertySequenceNumber)]
        [TestCase(PropertyCompleted)]
        [TestCase(PropertyStepPromptResponses)]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (Action) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_Action_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAction);
            var propertyInfo = this.GetPropertyInfo(PropertyAction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (Completed) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_Completed_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCompleted);
            var propertyInfo = this.GetPropertyInfo(PropertyCompleted);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (Content) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_Content_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyContent);
            var propertyInfo = this.GetPropertyInfo(PropertyContent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectType);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (ScriptSessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_ScriptSessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScriptSessionId);
            var propertyInfo = this.GetPropertyInfo(PropertyScriptSessionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (ScriptStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_ScriptStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (SequenceNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_SequenceNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (StepPromptResponses) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_StepPromptResponses_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepPromptResponses);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStepPromptResponses);
            Action currentAction = () => propertyInfo.SetValue(_scriptSessionStepCPTLBusinessModelInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepCPTLBusinessModel) => Property (StepPromptResponses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepCPTLBusinessModel_Public_Class_StepPromptResponses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepPromptResponses);
            var propertyInfo = this.GetPropertyInfo(PropertyStepPromptResponses);

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