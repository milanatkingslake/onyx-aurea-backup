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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.ScriptSession.ScriptSessionStepPromptResponsesCPTLBusinessModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.ScriptSession"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ScriptSessionStepPromptResponsesCPTLBusinessModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />)
        /// </summary>
        public ScriptSessionStepPromptResponsesCPTLBusinessModelTest() : base(typeof(ScriptSessionStepPromptResponsesCPTLBusinessModel))
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

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceType;
        private ScriptSessionStepPromptResponsesCPTLBusinessModel _scriptSessionStepPromptResponsesCPTLBusinessModelInstance;
        private ScriptSessionStepPromptResponsesCPTLBusinessModel _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceType = typeof(ScriptSessionStepPromptResponsesCPTLBusinessModel);
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture = this.Create<ScriptSessionStepPromptResponsesCPTLBusinessModel>(false);
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance = _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture ?? this.Create<ScriptSessionStepPromptResponsesCPTLBusinessModel>(true);
            CurrentInstance = _scriptSessionStepPromptResponsesCPTLBusinessModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Initializer

        #region Properties

        private const string PropertyObjectType = "ObjectType";
        private const string PropertyCollection = "Collection";
        private const string PropertyStepPromptResponses = "StepPromptResponses";

        #endregion

        #region Methods

        private const string MethodLoadStepPromptResponses = "LoadStepPromptResponses";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel)

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLoadStepPromptResponses, 0)]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyCollection)]
        [TestCase(PropertyStepPromptResponses)]
        [Category("AUT Property")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceType.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.ShouldBeAssignableTo<ScriptSessionStepPromptResponsesCPTLBusinessModel>();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture.ShouldBeAssignableTo<ScriptSessionStepPromptResponsesCPTLBusinessModel>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionStepPromptResponsesCPTLBusinessModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionStepPromptResponsesCPTLBusinessModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionStepPromptResponsesCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionStepPromptResponsesCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ScriptSessionStepPromptResponsesCPTLBusinessModel>();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var data = this.CreateType<JObject>();
            ScriptSessionStepPromptResponsesCPTLBusinessModel instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ScriptSessionStepPromptResponsesCPTLBusinessModel(data);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) instance created

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Is_Created_Test()
        {
            // Assert
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.ShouldNotBeNull();
            _scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodScriptSessionStepPromptResponsesCPTLBusinessModelParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionStepPromptResponsesCPTLBusinessModelParametersTypes);
        }

        #endregion

        #region General Constructor : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="ScriptSessionStepPromptResponsesCPTLBusinessModel" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodScriptSessionStepPromptResponsesCPTLBusinessModelParametersTypes = new Type[] { typeof(JObject) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodScriptSessionStepPromptResponsesCPTLBusinessModelParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyObjectType)]
        [TestCase(PropertyCollection)]
        [TestCase(PropertyStepPromptResponses)]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) => Property (Collection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Public_Class_Collection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCollection);
            var propertyInfo = this.GetPropertyInfo(PropertyCollection);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) => Property (ObjectType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Public_Class_ObjectType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ScriptSessionStepPromptResponsesCPTLBusinessModel) => Property (StepPromptResponses) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_Public_Class_StepPromptResponses_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region Category : MethodCallTest

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var data = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _scriptSessionStepPromptResponsesCPTLBusinessModelInstance.LoadStepPromptResponses(data);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var data = this.CreateType<JToken>();
            var methodLoadStepPromptResponsesParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepPromptResponses = { data };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptResponses, methodLoadStepPromptResponsesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptSessionStepPromptResponsesCPTLBusinessModelInstanceFixture, parametersOfLoadStepPromptResponses);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLoadStepPromptResponses.ShouldNotBeNull();
            parametersOfLoadStepPromptResponses.Length.ShouldBe(1);
            methodLoadStepPromptResponsesParametersTypes.Length.ShouldBe(1);
            methodLoadStepPromptResponsesParametersTypes.Length.ShouldBe(parametersOfLoadStepPromptResponses.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var data = this.CreateType<JToken>();
            var methodLoadStepPromptResponsesParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfLoadStepPromptResponses = { data };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLoadStepPromptResponses, parametersOfLoadStepPromptResponses, methodLoadStepPromptResponsesParametersTypes);

            // Assert
            parametersOfLoadStepPromptResponses.ShouldNotBeNull();
            parametersOfLoadStepPromptResponses.Length.ShouldBe(1);
            methodLoadStepPromptResponsesParametersTypes.Length.ShouldBe(1);
            methodLoadStepPromptResponsesParametersTypes.Length.ShouldBe(parametersOfLoadStepPromptResponses.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptResponses, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var methodLoadStepPromptResponsesParametersTypes = new Type[] { typeof(JToken) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLoadStepPromptResponses, methodLoadStepPromptResponsesParametersTypes);

            // Assert
            methodLoadStepPromptResponsesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LoadStepPromptResponses) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionStepPromptResponsesCPTLBusinessModel_LoadStepPromptResponses_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLoadStepPromptResponses);
            var currentMethodInfo = this.GetMethodInfo(MethodLoadStepPromptResponses, 0);

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