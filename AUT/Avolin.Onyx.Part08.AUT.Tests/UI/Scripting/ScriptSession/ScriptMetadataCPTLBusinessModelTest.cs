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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptMetadataCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptMetadataCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptMetadataCPTLBusinessModel" />)
        /// </summary>
        public ScriptMetadataCPTLBusinessModelTest() : base(typeof(ScriptMetadataCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptMetadataCPTLBusinessModelInstanceType;
        private ScriptMetadataCPTLBusinessModel _scriptMetadataCPTLBusinessModelInstance;
        private ScriptMetadataCPTLBusinessModel _scriptMetadataCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptMetadataCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptMetadataCPTLBusinessModelInstanceType = typeof(ScriptMetadataCPTLBusinessModel);
            _scriptMetadataCPTLBusinessModelInstanceFixture = this.Create<ScriptMetadataCPTLBusinessModel>(false);
            _scriptMetadataCPTLBusinessModelInstance = _scriptMetadataCPTLBusinessModelInstanceFixture ?? this.Create<ScriptMetadataCPTLBusinessModel>(true);
            CurrentInstance = _scriptMetadataCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyInitialStepId = "InitialStepId";
        private const string PropertyLoadedScriptStepId = "LoadedScriptStepId";
        private const string PropertyStepsMetadata = "StepsMetadata";

        #endregion

        #region Methods

        private const string MethodLoadStepsMetadata = "LoadStepsMetadata";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptMetadataCPTLBusinessModel)

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadStepsMetadata, 0)]
        public void AUT_ScriptMetadataCPTLBusinessModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ScriptMetadataCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyInitialStepId)]
        [TestCase(PropertyLoadedScriptStepId)]
        [TestCase(PropertyStepsMetadata)]
        [Category("AUT Property")]
        public void AUT_ScriptMetadataCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptMetadataCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptMetadataCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptMetadataCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptMetadataCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptMetadataCPTLBusinessModel>();
            _scriptMetadataCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptMetadataCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptMetadataCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptMetadataCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptMetadataCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptMetadataCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptMetadataCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptMetadataCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptMetadataCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptMetadataCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptMetadataCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptMetadataCPTLBusinessModelParametersTypes = new Type[] { typeof(JObject) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptMetadataCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptMetadataCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptMetadataCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptMetadataCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptMetadataCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptMetadataCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyInitialStepId)]
        [TestCase(PropertyLoadedScriptStepId)]
        [TestCase(PropertyStepsMetadata)]
        public void AUT_ScriptMetadataCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptMetadataCPTLBusinessModel) => Property (InitialStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Public_Class_InitialStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInitialStepId);
            var propertyInfo = this.GetPropertyInfo(PropertyInitialStepId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMetadataCPTLBusinessModel) => Property (LoadedScriptStepId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Public_Class_LoadedScriptStepId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLoadedScriptStepId);
            var propertyInfo = this.GetPropertyInfo(PropertyLoadedScriptStepId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptMetadataCPTLBusinessModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptMetadataCPTLBusinessModel) => Property (StepsMetadata) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptMetadataCPTLBusinessModel_Public_Class_StepsMetadata_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStepsMetadata);
            var propertyInfo = this.GetPropertyInfo(PropertyStepsMetadata);

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

        #region Method Call : (LoadStepsMetadata) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var data = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _scriptMetadataCPTLBusinessModelInstance.LoadStepsMetadata(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadStepsMetadata) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadStepsMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepsMetadata = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepsMetadata, methodLoadStepsMetadataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptMetadataCPTLBusinessModelInstanceFixture, parametersOfLoadStepsMetadata);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadStepsMetadata.ShouldNotBeNull();
            parametersOfLoadStepsMetadata.Length.ShouldBe(1);
            methodLoadStepsMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadStepsMetadataParametersTypes.Length.ShouldBe(parametersOfLoadStepsMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepsMetadata) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var data = this.CreateType<JToken>();
            var methodLoadStepsMetadataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepsMetadata = { data };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadStepsMetadata, parametersOfLoadStepsMetadata, methodLoadStepsMetadataParametersTypes);

            // Assert
            parametersOfLoadStepsMetadata.ShouldNotBeNull();
            parametersOfLoadStepsMetadata.Length.ShouldBe(1);
            methodLoadStepsMetadataParametersTypes.Length.ShouldBe(1);
            methodLoadStepsMetadataParametersTypes.Length.ShouldBe(parametersOfLoadStepsMetadata.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepsMetadata) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepsMetadata, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadStepsMetadata) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var methodLoadStepsMetadataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadStepsMetadata, methodLoadStepsMetadataParametersTypes);

            // Assert
            methodLoadStepsMetadataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepsMetadata) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptMetadataCPTLBusinessModel_LoadStepsMetadata_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepsMetadata);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepsMetadata, 0);

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