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
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.ScriptSessionController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScriptSessionControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScriptSessionController" />)
        /// </summary>
        public ScriptSessionControllerTest() : base(typeof(ScriptSessionController))
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

        #region General Initializer : Class (ScriptSessionController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scriptSessionControllerInstanceType;
        private ScriptSessionController _scriptSessionControllerInstance;
        private ScriptSessionController _scriptSessionControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScriptSessionController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scriptSessionControllerInstanceType = typeof(ScriptSessionController);
            _scriptSessionControllerInstanceFixture = this.Create<ScriptSessionController>(false);
            _scriptSessionControllerInstance = _scriptSessionControllerInstanceFixture ?? this.Create<ScriptSessionController>(true);
            CurrentInstance = _scriptSessionControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScriptSessionController) Initializer

        #region Methods

        private const string MethodResumeSession = "ResumeSession";
        private const string MethodCreateSession = "CreateSession";
        private const string MethodSaveSessionAndMove = "SaveSessionAndMove";
        private const string MethodSessionStepMove = "SessionStepMove";
        private const string MethodUpdateSession = "UpdateSession";
        private const string MethodUpdateSessionStep = "UpdateSessionStep";
        private const string MethodDeleteSession = "DeleteSession";
        private const string MethodPrintSession = "PrintSession";

        #endregion

        #endregion

        #region General Initializer : Class (ScriptSessionController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScriptSessionController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ScriptSessionController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScriptSessionController)

        #region General Initializer : Class (ScriptSessionController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodResumeSession, 0)]
        [TestCase(MethodCreateSession, 0)]
        [TestCase(MethodCreateSession, 1)]
        [TestCase(MethodSaveSessionAndMove, 0)]
        [TestCase(MethodSaveSessionAndMove, 1)]
        [TestCase(MethodSessionStepMove, 0)]
        [TestCase(MethodUpdateSession, 0)]
        [TestCase(MethodUpdateSessionStep, 0)]
        [TestCase(MethodDeleteSession, 0)]
        [TestCase(MethodPrintSession, 0)]
        public void AUT_ScriptSessionController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ScriptSessionController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionController_Is_Instance_Present_Test()
        {
            // Assert
            _scriptSessionControllerInstanceType.ShouldNotBeNull();
            _scriptSessionControllerInstance.ShouldNotBeNull();
            _scriptSessionControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScriptSessionController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScriptSessionController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ScriptSessionController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scriptSessionControllerInstance.ShouldBeAssignableTo<ScriptSessionController>();
            _scriptSessionControllerInstanceFixture.ShouldBeAssignableTo<ScriptSessionController>();
            CurrentInstance.ShouldBeAssignableTo<ScriptSessionController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScriptSessionController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ScriptSessionController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScriptSessionController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var scriptId = this.CreateType<int>();
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.ResumeSession(scriptId, scriptSessionId, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var scriptId = this.CreateType<int>();
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.ResumeSession(scriptId, scriptSessionId, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var scriptId = this.CreateType<int>();
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodResumeSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(bool) };
            object[] parametersOfResumeSession = { scriptId, scriptSessionId, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSession, methodResumeSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfResumeSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodResumeSession, parametersOfResumeSession, methodResumeSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResumeSession.ShouldNotBeNull();
            parametersOfResumeSession.Length.ShouldBe(3);
            methodResumeSessionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var scriptId = this.CreateType<int>();
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodResumeSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(bool) };
            object[] parametersOfResumeSession = { scriptId, scriptSessionId, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodResumeSession, parametersOfResumeSession, methodResumeSessionParametersTypes);

            // Assert
            parametersOfResumeSession.ShouldNotBeNull();
            parametersOfResumeSession.Length.ShouldBe(3);
            methodResumeSessionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var methodResumeSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResumeSession, methodResumeSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResumeSessionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var methodResumeSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResumeSession, methodResumeSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResumeSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResumeSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_ResumeSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSession);
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSession, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_CreateSession_Method_Call_Internally(Type[] types)
        {
            var methodCreateSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptOegRefModel = this.CreateType<ScriptOegRefModel>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.CreateSession(scriptOegRefModel, compatibility);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptOegRefModel = this.CreateType<ScriptOegRefModel>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.CreateSession(scriptOegRefModel, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptOegRefModel = this.CreateType<ScriptOegRefModel>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(ScriptOegRefModel), typeof(bool) };
            object[] parametersOfCreateSession = { scriptOegRefModel, compatibility };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, methodCreateSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, out exception1, parametersOfCreateSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodCreateSession, parametersOfCreateSession, methodCreateSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(2);
            methodCreateSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptOegRefModel = this.CreateType<ScriptOegRefModel>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(ScriptOegRefModel), typeof(bool) };
            object[] parametersOfCreateSession = { scriptOegRefModel, compatibility };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, methodCreateSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptSessionControllerInstanceFixture, parametersOfCreateSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(2);
            methodCreateSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptOegRefModel = this.CreateType<ScriptOegRefModel>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(ScriptOegRefModel), typeof(bool) };
            object[] parametersOfCreateSession = { scriptOegRefModel, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodCreateSession, parametersOfCreateSession, methodCreateSessionParametersTypes);

            // Assert
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(2);
            methodCreateSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var methodCreateSessionParametersTypes = new Type[] { typeof(ScriptOegRefModel), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var methodCreateSessionParametersTypes = new Type[] { typeof(ScriptOegRefModel), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_CreateSession_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.CreateSession(scriptId, ownerId, ownerType, compatibility);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.CreateSession(scriptId, ownerId, ownerType, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCreateSession = { scriptId, ownerId, ownerType, compatibility };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, methodCreateSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, out exception1, parametersOfCreateSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodCreateSession, parametersOfCreateSession, methodCreateSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(4);
            methodCreateSessionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCreateSession = { scriptId, ownerId, ownerType, compatibility };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, methodCreateSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptSessionControllerInstanceFixture, parametersOfCreateSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(4);
            methodCreateSessionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var scriptId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodCreateSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfCreateSession = { scriptId, ownerId, ownerType, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodCreateSession, parametersOfCreateSession, methodCreateSessionParametersTypes);

            // Assert
            parametersOfCreateSession.ShouldNotBeNull();
            parametersOfCreateSession.Length.ShouldBe(4);
            methodCreateSessionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var methodCreateSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateSessionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var methodCreateSessionParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSession, methodCreateSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_CreateSession_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSession, 1);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Internally(Type[] types)
        {
            var methodSaveSessionAndMoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var sessionStepId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.SaveSessionAndMove(scriptModel, sessionStepId, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var sessionStepId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.SaveSessionAndMove(scriptModel, sessionStepId, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var sessionStepId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(bool) };
            object[] parametersOfSaveSessionAndMove = { scriptModel, sessionStepId, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfSaveSessionAndMove);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSaveSessionAndMove, parametersOfSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveSessionAndMove.ShouldNotBeNull();
            parametersOfSaveSessionAndMove.Length.ShouldBe(3);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var sessionStepId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(bool) };
            object[] parametersOfSaveSessionAndMove = { scriptModel, sessionStepId, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSaveSessionAndMove, parametersOfSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            parametersOfSaveSessionAndMove.ShouldNotBeNull();
            parametersOfSaveSessionAndMove.Length.ShouldBe(3);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_SaveSessionAndMove_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodSaveSessionAndMoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.SaveSessionAndMove(scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.SaveSessionAndMove(scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            object[] parametersOfSaveSessionAndMove = { scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfSaveSessionAndMove);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSaveSessionAndMove, parametersOfSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveSessionAndMove.ShouldNotBeNull();
            parametersOfSaveSessionAndMove.Length.ShouldBe(4);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            object[] parametersOfSaveSessionAndMove = { scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSaveSessionAndMove, parametersOfSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            parametersOfSaveSessionAndMove.ShouldNotBeNull();
            parametersOfSaveSessionAndMove.Length.ShouldBe(4);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var methodSaveSessionAndMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveSessionAndMove, methodSaveSessionAndMoveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveSessionAndMoveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSessionAndMove) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SaveSessionAndMove_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSessionAndMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSessionAndMove, 1);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_SessionStepMove_Method_Call_Internally(Type[] types)
        {
            var methodSessionStepMoveParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSessionStepMove, methodSessionStepMoveParametersTypes);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.SessionStepMove(scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.SessionStepMove(scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var methodSessionStepMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            object[] parametersOfSessionStepMove = { scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSessionStepMove, methodSessionStepMoveParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfSessionStepMove);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSessionStepMove, parametersOfSessionStepMove, methodSessionStepMoveParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSessionStepMove.ShouldNotBeNull();
            parametersOfSessionStepMove.Length.ShouldBe(4);
            methodSessionStepMoveParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var scriptModel = this.CreateType<ScriptModel>();
            var moveToSessionStepId = this.CreateType<string>();
            var moveToScriptStepId = this.CreateType<int?>();
            var compatibility = this.CreateType<bool>();
            var methodSessionStepMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            object[] parametersOfSessionStepMove = { scriptModel, moveToSessionStepId, moveToScriptStepId, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSessionStepMove, parametersOfSessionStepMove, methodSessionStepMoveParametersTypes);

            // Assert
            parametersOfSessionStepMove.ShouldNotBeNull();
            parametersOfSessionStepMove.Length.ShouldBe(4);
            methodSessionStepMoveParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var methodSessionStepMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSessionStepMove, methodSessionStepMoveParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSessionStepMoveParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var methodSessionStepMoveParametersTypes = new Type[] { typeof(ScriptModel), typeof(string), typeof(int?), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSessionStepMove, methodSessionStepMoveParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSessionStepMoveParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSessionStepMove, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SessionStepMove) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_SessionStepMove_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSessionStepMove);
            var currentMethodInfo = this.GetMethodInfo(MethodSessionStepMove, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_UpdateSession_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSession, methodUpdateSessionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.UpdateSession(scriptModel, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.UpdateSession(scriptModel, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfUpdateSession = { scriptModel, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, methodUpdateSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfUpdateSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSession, parametersOfUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfUpdateSession = { scriptModel, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSession, parametersOfUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            parametersOfUpdateSession.ShouldNotBeNull();
            parametersOfUpdateSession.Length.ShouldBe(2);
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var methodUpdateSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSession, methodUpdateSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSessionStepParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSessionStep, methodUpdateSessionStepParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.UpdateSessionStep(scriptModel, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.UpdateSessionStep(scriptModel, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionStepParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfUpdateSessionStep = { scriptModel, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionStep, methodUpdateSessionStepParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfUpdateSessionStep);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSessionStep, parametersOfUpdateSessionStep, methodUpdateSessionStepParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSessionStep.ShouldNotBeNull();
            parametersOfUpdateSessionStep.Length.ShouldBe(2);
            methodUpdateSessionStepParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodUpdateSessionStepParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfUpdateSessionStep = { scriptModel, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSessionStep, parametersOfUpdateSessionStep, methodUpdateSessionStepParametersTypes);

            // Assert
            parametersOfUpdateSessionStep.ShouldNotBeNull();
            parametersOfUpdateSessionStep.Length.ShouldBe(2);
            methodUpdateSessionStepParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var methodUpdateSessionStepParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSessionStep, methodUpdateSessionStepParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSessionStepParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var methodUpdateSessionStepParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSessionStep, methodUpdateSessionStepParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSessionStepParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionStep, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSessionStep) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_UpdateSessionStep_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSessionStep);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSessionStep, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_DeleteSession_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSession, methodDeleteSessionParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.DeleteSession(scriptSessionId, compatibility);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.DeleteSession(scriptSessionId, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodDeleteSessionParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfDeleteSession = { scriptSessionId, compatibility };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSession, methodDeleteSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, out exception1, parametersOfDeleteSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodDeleteSession, parametersOfDeleteSession, methodDeleteSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteSession.ShouldNotBeNull();
            parametersOfDeleteSession.Length.ShouldBe(2);
            methodDeleteSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodDeleteSessionParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfDeleteSession = { scriptSessionId, compatibility };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSession, methodDeleteSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_scriptSessionControllerInstanceFixture, parametersOfDeleteSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteSession.ShouldNotBeNull();
            parametersOfDeleteSession.Length.ShouldBe(2);
            methodDeleteSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var scriptSessionId = this.CreateType<string>();
            var compatibility = this.CreateType<bool>();
            var methodDeleteSessionParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfDeleteSession = { scriptSessionId, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodDeleteSession, parametersOfDeleteSession, methodDeleteSessionParametersTypes);

            // Assert
            parametersOfDeleteSession.ShouldNotBeNull();
            parametersOfDeleteSession.Length.ShouldBe(2);
            methodDeleteSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var methodDeleteSessionParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteSession, methodDeleteSessionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var methodDeleteSessionParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSession, methodDeleteSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_DeleteSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSession);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSession, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ScriptSessionController_PrintSession_Method_Call_Internally(Type[] types)
        {
            var methodPrintSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPrintSession, methodPrintSessionParametersTypes);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();

            // Act
            Action executeAction = () => _scriptSessionControllerInstance.PrintSession(scriptModel, compatibility);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _scriptSessionControllerInstance.PrintSession(scriptModel, compatibility);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodPrintSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfPrintSession = { scriptModel, compatibility };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPrintSession, methodPrintSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_scriptSessionControllerInstanceFixture, parametersOfPrintSession);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodPrintSession, parametersOfPrintSession, methodPrintSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPrintSession.ShouldNotBeNull();
            parametersOfPrintSession.Length.ShouldBe(2);
            methodPrintSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var scriptModel = this.CreateType<ScriptModel>();
            var compatibility = this.CreateType<bool>();
            var methodPrintSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            object[] parametersOfPrintSession = { scriptModel, compatibility };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodPrintSession, parametersOfPrintSession, methodPrintSessionParametersTypes);

            // Assert
            parametersOfPrintSession.ShouldNotBeNull();
            parametersOfPrintSession.Length.ShouldBe(2);
            methodPrintSessionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var methodPrintSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPrintSession, methodPrintSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPrintSessionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var methodPrintSessionParametersTypes = new Type[] { typeof(ScriptModel), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrintSession, methodPrintSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPrintSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var currentMethodInfo = this.GetMethodInfo(MethodPrintSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PrintSession) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ScriptSessionController_PrintSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrintSession);
            var currentMethodInfo = this.GetMethodInfo(MethodPrintSession, 0);
            const int parametersCount = 2;

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