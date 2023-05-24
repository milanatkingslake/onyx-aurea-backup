using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Controller;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.ScriptController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptController" />)
        /// </summary>
        public ScriptControllerTest() : base(typeof(ScriptController))
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

        #region General Initializer : Class (ScriptController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptControllerInstanceType;
        private ScriptController _scriptControllerInstance;
        private ScriptController _scriptControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptControllerInstanceType = typeof(ScriptController);
            _scriptControllerInstanceFixture = this.Create<ScriptController>(false);
            _scriptControllerInstance = _scriptControllerInstanceFixture ?? this.Create<ScriptController>(true);
            CurrentInstance = _scriptControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptController) Initializer

        #region Methods

        private const string MethodGetScriptList = "GetScriptList";
        private const string MethodGetScript = "GetScript";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptController)

        #region General Initializer : Class (ScriptController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetScriptList, 0)]
        [TestCase(MethodGetScript, 0)]
        public void AUT_ScriptController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ScriptController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptController_Is_Instance_Present_Test()
        {
            // Assert
            _scriptControllerInstanceType.ShouldNotBeNull();
            _scriptControllerInstance.ShouldNotBeNull();
            _scriptControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptControllerInstance.ShouldBeAssignableTo<ScriptController>();
            _scriptControllerInstanceFixture.ShouldBeAssignableTo<ScriptController>();
            CurrentInstance.ShouldBeAssignableTo<ScriptController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);

            // Act
            Action executeAction = () => _scriptControllerInstance.GetScriptList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptControllerInstance.GetScriptList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            Type [] methodGetScriptListParametersTypes = null;
            object[] parametersOfGetScriptList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptList, methodGetScriptListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptControllerInstanceFixture, parametersOfGetScriptList);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetScriptList, parametersOfGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptList.ShouldBeNull();
            methodGetScriptListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            Type [] methodGetScriptListParametersTypes = null;
            object[] parametersOfGetScriptList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetScriptList, parametersOfGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            parametersOfGetScriptList.ShouldBeNull();
            methodGetScriptListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            Type [] methodGetScriptListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            Type [] methodGetScriptListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptList, methodGetScriptListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptList) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScriptList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptController_GetScript_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();

            // Act
            Action executeAction = () => _scriptControllerInstance.GetScript(scriptId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptControllerInstance.GetScript(scriptId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var methodGetScriptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetScript = { scriptId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, methodGetScriptParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptControllerInstanceFixture, parametersOfGetScript);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetScript, parametersOfGetScript, methodGetScriptParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScript.ShouldNotBeNull();
            parametersOfGetScript.Length.ShouldBe(1);
            methodGetScriptParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var scriptId = this.CreateType<string>();
            var methodGetScriptParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetScript = { scriptId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetScript, parametersOfGetScript, methodGetScriptParametersTypes);

            // Assert
            parametersOfGetScript.ShouldNotBeNull();
            parametersOfGetScript.Length.ShouldBe(1);
            methodGetScriptParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var methodGetScriptParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var methodGetScriptParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScript, methodGetScriptParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScript) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptController_GetScript_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScript);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScript, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}