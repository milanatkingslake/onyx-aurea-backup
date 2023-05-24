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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.ScriptingController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptingControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptingController" />)
        /// </summary>
        public ScriptingControllerTest() : base(typeof(ScriptingController))
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

        #region General Initializer : Class (ScriptingController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptingControllerInstanceType;
        private ScriptingController _scriptingControllerInstance;
        private ScriptingController _scriptingControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptingController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptingControllerInstanceType = typeof(ScriptingController);
            _scriptingControllerInstanceFixture = this.Create<ScriptingController>(false);
            _scriptingControllerInstance = _scriptingControllerInstanceFixture ?? this.Create<ScriptingController>(true);
            CurrentInstance = _scriptingControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptingController) Initializer

        #region Methods

        private const string MethodGetApplicationResources = "GetApplicationResources";
        private const string MethodGetMessageLocalizationResources = "GetMessageLocalizationResources";
        private const string MethodGetSystemLocalizationResources = "GetSystemLocalizationResources";
        private const string MethodGetSecurityResources = "GetSecurityResources";
        private const string MethodGetLanguageResources = "GetLanguageResources";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptingController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptingController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptingController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptingController)

        #region General Initializer : Class (ScriptingController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetApplicationResources, 0)]
        [TestCase(MethodGetMessageLocalizationResources, 0)]
        [TestCase(MethodGetSystemLocalizationResources, 0)]
        [TestCase(MethodGetSecurityResources, 0)]
        [TestCase(MethodGetLanguageResources, 0)]
        public void AUT_ScriptingController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptingController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingController_Is_Instance_Present_Test()
        {
            // Assert
            _scriptingControllerInstanceType.ShouldNotBeNull();
            _scriptingControllerInstance.ShouldNotBeNull();
            _scriptingControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptingController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptingController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptingController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptingControllerInstance.ShouldBeAssignableTo<ScriptingController>();
            _scriptingControllerInstanceFixture.ShouldBeAssignableTo<ScriptingController>();
            CurrentInstance.ShouldBeAssignableTo<ScriptingController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptingController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptingController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptingController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);

            // Act
            Action executeAction = () => _scriptingControllerInstance.GetApplicationResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptingControllerInstance.GetApplicationResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            Type [] methodGetApplicationResourcesParametersTypes = null;
            object[] parametersOfGetApplicationResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptingControllerInstanceFixture, parametersOfGetApplicationResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetApplicationResources, parametersOfGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetApplicationResources.ShouldBeNull();
            methodGetApplicationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            Type [] methodGetApplicationResourcesParametersTypes = null;
            object[] parametersOfGetApplicationResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetApplicationResources, parametersOfGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            parametersOfGetApplicationResources.ShouldBeNull();
            methodGetApplicationResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            Type [] methodGetApplicationResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetApplicationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            Type [] methodGetApplicationResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetApplicationResources, methodGetApplicationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetApplicationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetApplicationResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageLocalizationResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);

            // Act
            Action executeAction = () => _scriptingControllerInstance.GetMessageLocalizationResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptingControllerInstance.GetMessageLocalizationResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            Type [] methodGetMessageLocalizationResourcesParametersTypes = null;
            object[] parametersOfGetMessageLocalizationResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptingControllerInstanceFixture, parametersOfGetMessageLocalizationResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetMessageLocalizationResources, parametersOfGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetMessageLocalizationResources.ShouldBeNull();
            methodGetMessageLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            Type [] methodGetMessageLocalizationResourcesParametersTypes = null;
            object[] parametersOfGetMessageLocalizationResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetMessageLocalizationResources, parametersOfGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            parametersOfGetMessageLocalizationResources.ShouldBeNull();
            methodGetMessageLocalizationResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            Type [] methodGetMessageLocalizationResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetMessageLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            Type [] methodGetMessageLocalizationResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessageLocalizationResources, methodGetMessageLocalizationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMessageLocalizationResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetMessageLocalizationResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageLocalizationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_Internally(Type[] types)
        {
            var methodGetSystemLocalizationResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);

            // Act
            Action executeAction = () => _scriptingControllerInstance.GetSystemLocalizationResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptingControllerInstance.GetSystemLocalizationResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            Type [] methodGetSystemLocalizationResourcesParametersTypes = null;
            object[] parametersOfGetSystemLocalizationResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptingControllerInstanceFixture, parametersOfGetSystemLocalizationResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSystemLocalizationResources, parametersOfGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemLocalizationResources.ShouldBeNull();
            methodGetSystemLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            Type [] methodGetSystemLocalizationResourcesParametersTypes = null;
            object[] parametersOfGetSystemLocalizationResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSystemLocalizationResources, parametersOfGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            parametersOfGetSystemLocalizationResources.ShouldBeNull();
            methodGetSystemLocalizationResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            Type [] methodGetSystemLocalizationResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            Type [] methodGetSystemLocalizationResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemLocalizationResources, methodGetSystemLocalizationResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemLocalizationResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemLocalizationResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSystemLocalizationResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemLocalizationResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemLocalizationResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingController_GetSecurityResources_Method_Call_Internally(Type[] types)
        {
            var methodGetSecurityResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);

            // Act
            Action executeAction = () => _scriptingControllerInstance.GetSecurityResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptingControllerInstance.GetSecurityResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;
            object[] parametersOfGetSecurityResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptingControllerInstanceFixture, parametersOfGetSecurityResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSecurityResources.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;
            object[] parametersOfGetSecurityResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            parametersOfGetSecurityResources.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptingController_GetLanguageResources_Method_Call_Internally(Type[] types)
        {
            var methodGetLanguageResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLanguageResources, methodGetLanguageResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var appName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var culture = this.CreateType<string>();

            // Act
            Action executeAction = () => _scriptingControllerInstance.GetLanguageResources(appName, siteId, culture);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var appName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var culture = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptingControllerInstance.GetLanguageResources(appName, siteId, culture);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var appName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var culture = this.CreateType<string>();
            var methodGetLanguageResourcesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetLanguageResources = { appName, siteId, culture };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLanguageResources, methodGetLanguageResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptingControllerInstanceFixture, parametersOfGetLanguageResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetLanguageResources, parametersOfGetLanguageResources, methodGetLanguageResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLanguageResources.ShouldNotBeNull();
            parametersOfGetLanguageResources.Length.ShouldBe(3);
            methodGetLanguageResourcesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var appName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var culture = this.CreateType<string>();
            var methodGetLanguageResourcesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetLanguageResources = { appName, siteId, culture };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetLanguageResources, parametersOfGetLanguageResources, methodGetLanguageResourcesParametersTypes);

            // Assert
            parametersOfGetLanguageResources.ShouldNotBeNull();
            parametersOfGetLanguageResources.Length.ShouldBe(3);
            methodGetLanguageResourcesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var methodGetLanguageResourcesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLanguageResources, methodGetLanguageResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLanguageResourcesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var methodGetLanguageResourcesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLanguageResources, methodGetLanguageResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLanguageResourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLanguageResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLanguageResources) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptingController_GetLanguageResources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLanguageResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLanguageResources, 0);
            const int parametersCount = 3;

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