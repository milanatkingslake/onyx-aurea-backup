using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptStepPromptMetadataCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptStepPromptMetadataCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />)
        /// </summary>
        public ScriptStepPromptMetadataCPTLBusinessModelTest() : base(typeof(ScriptStepPromptMetadataCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptStepPromptMetadataCPTLBusinessModelInstanceType;
        private ScriptStepPromptMetadataCPTLBusinessModel _scriptStepPromptMetadataCPTLBusinessModelInstance;
        private ScriptStepPromptMetadataCPTLBusinessModel _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptStepPromptMetadataCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptStepPromptMetadataCPTLBusinessModelInstanceType = typeof(ScriptStepPromptMetadataCPTLBusinessModel);
            _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture = this.Create<ScriptStepPromptMetadataCPTLBusinessModel>(false);
            _scriptStepPromptMetadataCPTLBusinessModelInstance = _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture ?? this.Create<ScriptStepPromptMetadataCPTLBusinessModel>(true);
            CurrentInstance = _scriptStepPromptMetadataCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyControlTypeCode = "ControlTypeCode";
        private const string PropertyMax = "Max";
        private const string PropertyMin = "Min";
        private const string PropertyText = "Text";
        
        private const string PropertyDataType = "DataType";
        private const string PropertyExtraData = "ExtraData";
        private const string PropertyDefault = "Default";
        private const string PropertySortResponseInUI = "SortResponseInUI";
        private const string PropertyRequired = "Required";
        private const string PropertyReadOnly = "ReadOnly";

        #endregion

        #region Methods

        private const string MethodLoadPromptResponseMetadata = "LoadPromptResponseMetadata";

        #endregion

        #region Fields

        private const string FieldPromptResponsesMetadata = "PromptResponsesMetadata";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptStepPromptMetadataCPTLBusinessModel)

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadPromptResponseMetadata, 0)]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyMax)]
        [TestCase(PropertyMin)]
        [TestCase(PropertyText)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertyDefault)]
        [TestCase(PropertySortResponseInUI)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyReadOnly)]
        [Category("AUT Property")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ScriptStepPromptMetadataCPTLBusinessModel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldPromptResponsesMetadata)]
        [Category("AUT Fields")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptStepPromptMetadataCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptStepPromptMetadataCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptStepPromptMetadataCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptStepPromptMetadataCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptStepPromptMetadataCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptStepPromptMetadataCPTLBusinessModel>();
            _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptStepPromptMetadataCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptStepPromptMetadataCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptStepPromptMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepPromptMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepPromptMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptStepPromptMetadataCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptStepPromptMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepPromptMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepPromptMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepPromptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyControlTypeCode)]
        [TestCase(PropertyMax)]
        [TestCase(PropertyMin)]
        [TestCase(PropertyText)]
        [TestCase(PropertyDataType)]
        [TestCase(PropertyExtraData)]
        [TestCase(PropertyDefault)]
        [TestCase(PropertySortResponseInUI)]
        [TestCase(PropertyRequired)]
        [TestCase(PropertyReadOnly)]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (ControlTypeCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_ControlTypeCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (DataType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_DataType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (Default) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_Default_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (ExtraData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_ExtraData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (Max) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_Max_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (Min) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_Min_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (ReadOnly) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_ReadOnly_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (Required) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_Required_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (SortResponseInUI) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_SortResponseInUI_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortResponseInUI);
            var propertyInfo = this.GetPropertyInfo(PropertySortResponseInUI);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptStepPromptMetadataCPTLBusinessModel) => Property (Text) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_Public_Class_Text_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Category : MethodCallTest

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) private call definition
        
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var data = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _scriptStepPromptMetadataCPTLBusinessModelInstance.LoadPromptResponseMetadata(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadPromptResponseMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadPromptResponseMetadata = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadPromptResponseMetadata, methodLoadPromptResponseMetadataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptStepPromptMetadataCPTLBusinessModelInstanceFixture, parametersOfLoadPromptResponseMetadata);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadPromptResponseMetadata.ShouldNotBeNull();
            parametersOfLoadPromptResponseMetadata.Length.ShouldBe(1);
            methodLoadPromptResponseMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadPromptResponseMetadataParametersTypes.Length.ShouldBe(parametersOfLoadPromptResponseMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadPromptResponseMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadPromptResponseMetadata = { data };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadPromptResponseMetadata, parametersOfLoadPromptResponseMetadata, methodLoadPromptResponseMetadataParametersTypes);

            // Assert
            parametersOfLoadPromptResponseMetadata.ShouldNotBeNull();
            parametersOfLoadPromptResponseMetadata.Length.ShouldBe(1);
            methodLoadPromptResponseMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadPromptResponseMetadataParametersTypes.Length.ShouldBe(parametersOfLoadPromptResponseMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadPromptResponseMetadata, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var methodLoadPromptResponseMetadataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadPromptResponseMetadata, methodLoadPromptResponseMetadataParametersTypes);

            // Assert
            methodLoadPromptResponseMetadataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadPromptResponseMetadata) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepPromptMetadataCPTLBusinessModel_LoadPromptResponseMetadata_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadPromptResponseMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadPromptResponseMetadata, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}