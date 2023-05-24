using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptStepMetadataCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptStepMetadataCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptStepMetadataCPTLBusinessModel" />)
        /// </summary>
        public ScriptStepMetadataCPTLBusinessModelTest() : base(typeof(ScriptStepMetadataCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptStepMetadataCPTLBusinessModelInstanceType;
        private ScriptStepMetadataCPTLBusinessModel _scriptStepMetadataCPTLBusinessModelInstance;
        private ScriptStepMetadataCPTLBusinessModel _scriptStepMetadataCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptStepMetadataCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptStepMetadataCPTLBusinessModelInstanceType = typeof(ScriptStepMetadataCPTLBusinessModel);
            _scriptStepMetadataCPTLBusinessModelInstanceFixture = this.Create<ScriptStepMetadataCPTLBusinessModel>(false);
            _scriptStepMetadataCPTLBusinessModelInstance = _scriptStepMetadataCPTLBusinessModelInstanceFixture ?? this.Create<ScriptStepMetadataCPTLBusinessModel>(true);
            CurrentInstance = _scriptStepMetadataCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyName = "Name";
        private const string PropertyFinalStep = "FinalStep";
        private const string PropertyHeaderText = "HeaderText";
        private const string PropertyFooterText = "FooterText";

        #endregion

        #region Methods

        private const string MethodLoadStepPromptsMetadata = "LoadStepPromptsMetadata";

        #endregion

        #region Fields

        private const string FieldStepPromptsMetadata = "StepPromptsMetadata";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptStepMetadataCPTLBusinessModel)

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadStepPromptsMetadata, 0)]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyFinalStep)]
        [TestCase(PropertyHeaderText)]
        [TestCase(PropertyFooterText)]
        [Category("AUT Property")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ScriptStepMetadataCPTLBusinessModel) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldStepPromptsMetadata)]
        [Category("AUT Fields")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptStepMetadataCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptStepMetadataCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptStepMetadataCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptStepMetadataCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptStepMetadataCPTLBusinessModel>();
            _scriptStepMetadataCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptStepMetadataCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptStepMetadataCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptStepMetadataCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptStepMetadataCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptStepMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptStepMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptStepMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptStepMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptStepMetadataCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptStepMetadataCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptStepMetadataCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptStepMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptStepMetadataCPTLBusinessModelParametersTypes = new Type[] { typeof(JObject) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptStepMetadataCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyName)]
        [TestCase(PropertyFinalStep)]
        [TestCase(PropertyHeaderText)]
        [TestCase(PropertyFooterText)]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => Property (FinalStep) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Public_Class_FinalStep_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => Property (FooterText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Public_Class_FooterText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => Property (HeaderText) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Public_Class_HeaderText_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptStepMetadataCPTLBusinessModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var data = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _scriptStepMetadataCPTLBusinessModelInstance.LoadStepPromptsMetadata(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadStepPromptsMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepPromptsMetadata = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptsMetadata, methodLoadStepPromptsMetadataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptStepMetadataCPTLBusinessModelInstanceFixture, parametersOfLoadStepPromptsMetadata);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadStepPromptsMetadata.ShouldNotBeNull();
            parametersOfLoadStepPromptsMetadata.Length.ShouldBe(1);
            methodLoadStepPromptsMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadStepPromptsMetadataParametersTypes.Length.ShouldBe(parametersOfLoadStepPromptsMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadStepPromptsMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepPromptsMetadata = { data };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadStepPromptsMetadata, parametersOfLoadStepPromptsMetadata, methodLoadStepPromptsMetadataParametersTypes);

            // Assert
            parametersOfLoadStepPromptsMetadata.ShouldNotBeNull();
            parametersOfLoadStepPromptsMetadata.Length.ShouldBe(1);
            methodLoadStepPromptsMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadStepPromptsMetadataParametersTypes.Length.ShouldBe(parametersOfLoadStepPromptsMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptsMetadata, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var methodLoadStepPromptsMetadataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadStepPromptsMetadata, methodLoadStepPromptsMetadataParametersTypes);

            // Assert
            methodLoadStepPromptsMetadataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptsMetadata) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptStepMetadataCPTLBusinessModel_LoadStepPromptsMetadata_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptsMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptsMetadata, 0);

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