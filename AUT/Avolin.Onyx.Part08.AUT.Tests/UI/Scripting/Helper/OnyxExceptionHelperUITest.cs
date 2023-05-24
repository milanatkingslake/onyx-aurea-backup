using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.LoggerService;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.Helper;
using Onyx.UI.Scripting.ViewModel;
using OnyxSDK.Public.OnyxException;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Helper.OnyxExceptionHelperUI" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxExceptionHelperUITest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxExceptionHelperUI" />)
        /// </summary>
        public OnyxExceptionHelperUITest() : base(typeof(OnyxExceptionHelperUI))
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

        #region General Initializer : Class (OnyxExceptionHelperUI) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxExceptionHelperUIInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxExceptionHelperUI" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxExceptionHelperUIInstanceType = typeof(OnyxExceptionHelperUI);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxExceptionHelperUI) Initializer

        #region Methods

        private const string MethodGetMessageModelsFromOnyxException = "GetMessageModelsFromOnyxException";
        private const string MethodMessageModelsContainsException = "MessageModelsContainsException";
        private const string MethodControllerResponseHandler = "ControllerResponseHandler";
        private const string MethodControllerExceptionHandler = "ControllerExceptionHandler";
        private const string MethodBusinessLayerExceptionHandler = "BusinessLayerExceptionHandler";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxExceptionHelperUI) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelperUI" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExceptionHelperUI_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxExceptionHelperUI)

        #region General Initializer : Class (OnyxExceptionHelperUI) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelperUI" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetMessageModelsFromOnyxException, 0)]
        [TestCase(MethodMessageModelsContainsException, 0)]
        [TestCase(MethodControllerResponseHandler, 0)]
        [TestCase(MethodControllerExceptionHandler, 0)]
        [TestCase(MethodBusinessLayerExceptionHandler, 0)]
        public void AUT_OnyxExceptionHelperUI_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxExceptionHelperUI) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelperUI" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExceptionHelperUI_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxExceptionHelperUIInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var onyxExecuteException = this.CreateType<OnyxExecuteException>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var language = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxExceptionHelperUI.GetMessageModelsFromOnyxException(onyxExecuteException, messageModels, language);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var onyxExecuteException = this.CreateType<OnyxExecuteException>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var language = this.CreateType<string>();
            var methodGetMessageModelsFromOnyxExceptionParametersTypes = new Type[] { typeof(OnyxExecuteException), typeof(List<MessageModel>), typeof(string) };
            object[] parametersOfGetMessageModelsFromOnyxException = { onyxExecuteException, messageModels, language };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageModelsFromOnyxException, methodGetMessageModelsFromOnyxExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetMessageModelsFromOnyxException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMessageModelsFromOnyxException.ShouldNotBeNull();
            parametersOfGetMessageModelsFromOnyxException.Length.ShouldBe(3);
            methodGetMessageModelsFromOnyxExceptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var onyxExecuteException = this.CreateType<OnyxExecuteException>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var language = this.CreateType<string>();
            var methodGetMessageModelsFromOnyxExceptionParametersTypes = new Type[] { typeof(OnyxExecuteException), typeof(List<MessageModel>), typeof(string) };
            object[] parametersOfGetMessageModelsFromOnyxException = { onyxExecuteException, messageModels, language };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetMessageModelsFromOnyxException, parametersOfGetMessageModelsFromOnyxException, methodGetMessageModelsFromOnyxExceptionParametersTypes);

            // Assert
            parametersOfGetMessageModelsFromOnyxException.ShouldNotBeNull();
            parametersOfGetMessageModelsFromOnyxException.Length.ShouldBe(3);
            methodGetMessageModelsFromOnyxExceptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageModelsFromOnyxException, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var methodGetMessageModelsFromOnyxExceptionParametersTypes = new Type[] { typeof(OnyxExecuteException), typeof(List<MessageModel>), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessageModelsFromOnyxException, methodGetMessageModelsFromOnyxExceptionParametersTypes);

            // Assert
            methodGetMessageModelsFromOnyxExceptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessageModelsFromOnyxException) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_GetMessageModelsFromOnyxException_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessageModelsFromOnyxException);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessageModelsFromOnyxException, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Internally(Type[] types)
        {
            var methodMessageModelsContainsExceptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => OnyxExceptionHelperUI.MessageModelsContainsException(messageModels);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfMessageModelsContainsException = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);
            var result2 = this.GetResultOfMethod<bool>(MethodMessageModelsContainsException, parametersOfMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfMessageModelsContainsException.ShouldNotBeNull();
            parametersOfMessageModelsContainsException.Length.ShouldBe(1);
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<bool>(MethodMessageModelsContainsException, parametersOfMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes));
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfMessageModelsContainsException = { messageModels };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfMessageModelsContainsException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMessageModelsContainsException.ShouldNotBeNull();
            parametersOfMessageModelsContainsException.Length.ShouldBe(1);
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfMessageModelsContainsException = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodMessageModelsContainsException, parametersOfMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);

            // Assert
            parametersOfMessageModelsContainsException.ShouldNotBeNull();
            parametersOfMessageModelsContainsException.Length.ShouldBe(1);
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var methodMessageModelsContainsExceptionParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMessageModelsContainsException, methodMessageModelsContainsExceptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMessageModelsContainsExceptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var currentMethodInfo = this.GetMethodInfo(MethodMessageModelsContainsException, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (MessageModelsContainsException) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_MessageModelsContainsException_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMessageModelsContainsException);
            var currentMethodInfo = this.GetMethodInfo(MethodMessageModelsContainsException, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodControllerResponseHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var messageModels = this.CreateType<List<MessageModel>>();
            var responseViewModel = this.CreateType<ResponseViewModel>();

            // Act
            Action executeAction = () => OnyxExceptionHelperUI.ControllerResponseHandler(messageModels, responseViewModel);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var messageModels = this.CreateType<List<MessageModel>>();
            var responseViewModel = this.CreateType<ResponseViewModel>();
            var returnedValue = default(ResponseViewModel);

            // Act
            Action executeAction = () => returnedValue = OnyxExceptionHelperUI.ControllerResponseHandler(messageModels, responseViewModel);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var messageModels = this.CreateType<List<MessageModel>>();
            var responseViewModel = this.CreateType<ResponseViewModel>();
            var methodControllerResponseHandlerParametersTypes = new Type[] { typeof(List<MessageModel>), typeof(ResponseViewModel) };
            object[] parametersOfControllerResponseHandler = { messageModels, responseViewModel };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes);
            var result2 = this.GetResultOfMethod<ResponseViewModel>(MethodControllerResponseHandler, parametersOfControllerResponseHandler, methodControllerResponseHandlerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfControllerResponseHandler.ShouldNotBeNull();
            parametersOfControllerResponseHandler.Length.ShouldBe(2);
            methodControllerResponseHandlerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<ResponseViewModel>(MethodControllerResponseHandler, parametersOfControllerResponseHandler, methodControllerResponseHandlerParametersTypes));
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var messageModels = this.CreateType<List<MessageModel>>();
            var responseViewModel = this.CreateType<ResponseViewModel>();
            var methodControllerResponseHandlerParametersTypes = new Type[] { typeof(List<MessageModel>), typeof(ResponseViewModel) };
            object[] parametersOfControllerResponseHandler = { messageModels, responseViewModel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfControllerResponseHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfControllerResponseHandler.ShouldNotBeNull();
            parametersOfControllerResponseHandler.Length.ShouldBe(2);
            methodControllerResponseHandlerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var messageModels = this.CreateType<List<MessageModel>>();
            var responseViewModel = this.CreateType<ResponseViewModel>();
            var methodControllerResponseHandlerParametersTypes = new Type[] { typeof(List<MessageModel>), typeof(ResponseViewModel) };
            object[] parametersOfControllerResponseHandler = { messageModels, responseViewModel };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResponseViewModel>(MethodControllerResponseHandler, parametersOfControllerResponseHandler, methodControllerResponseHandlerParametersTypes);

            // Assert
            parametersOfControllerResponseHandler.ShouldNotBeNull();
            parametersOfControllerResponseHandler.Length.ShouldBe(2);
            methodControllerResponseHandlerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var methodControllerResponseHandlerParametersTypes = new Type[] { typeof(List<MessageModel>), typeof(ResponseViewModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodControllerResponseHandlerParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var methodControllerResponseHandlerParametersTypes = new Type[] { typeof(List<MessageModel>), typeof(ResponseViewModel) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodControllerResponseHandler, methodControllerResponseHandlerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodControllerResponseHandlerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodControllerResponseHandler, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ControllerResponseHandler) (Return Type : ResponseViewModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerResponseHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerResponseHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodControllerResponseHandler, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodControllerExceptionHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();

            // Act
            Action executeAction = () => OnyxExceptionHelperUI.ControllerExceptionHandler(ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var returnedValue = default(ResponseViewModel);

            // Act
            Action executeAction = () => returnedValue = OnyxExceptionHelperUI.ControllerExceptionHandler(ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var methodControllerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            object[] parametersOfControllerExceptionHandler = { ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);
            var result2 = this.GetResultOfMethod<ResponseViewModel>(MethodControllerExceptionHandler, parametersOfControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfControllerExceptionHandler.ShouldNotBeNull();
            parametersOfControllerExceptionHandler.Length.ShouldBe(7);
            methodControllerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(() => this.GetResultOfMethod<ResponseViewModel>(MethodControllerExceptionHandler, parametersOfControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes));
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var methodControllerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            object[] parametersOfControllerExceptionHandler = { ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfControllerExceptionHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfControllerExceptionHandler.ShouldNotBeNull();
            parametersOfControllerExceptionHandler.Length.ShouldBe(7);
            methodControllerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var methodControllerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            object[] parametersOfControllerExceptionHandler = { ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResponseViewModel>(MethodControllerExceptionHandler, parametersOfControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);

            // Assert
            parametersOfControllerExceptionHandler.ShouldNotBeNull();
            parametersOfControllerExceptionHandler.Length.ShouldBe(7);
            methodControllerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var methodControllerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodControllerExceptionHandlerParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var methodControllerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            const int parametersCount = 7;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodControllerExceptionHandler, methodControllerExceptionHandlerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodControllerExceptionHandlerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodControllerExceptionHandler, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ControllerExceptionHandler) (Return Type : ResponseViewModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_ControllerExceptionHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodControllerExceptionHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodControllerExceptionHandler, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_Internally(Type[] types)
        {
            var methodBusinessLayerExceptionHandlerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBusinessLayerExceptionHandler, methodBusinessLayerExceptionHandlerParametersTypes);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();

            // Act
            Action executeAction = () => OnyxExceptionHelperUI.BusinessLayerExceptionHandler(ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var methodBusinessLayerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            object[] parametersOfBusinessLayerExceptionHandler = { ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBusinessLayerExceptionHandler, methodBusinessLayerExceptionHandlerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfBusinessLayerExceptionHandler);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBusinessLayerExceptionHandler.ShouldNotBeNull();
            parametersOfBusinessLayerExceptionHandler.Length.ShouldBe(7);
            methodBusinessLayerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var ex = this.CreateType<Exception>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var iLog = this.CreateType<ILogger>();
            var exceptionMessageToLog = this.CreateType<string>();
            var exceptionMessageCulture = this.CreateType<string>();
            var newMessageNatLangId = this.CreateType<string>();
            var newMessageModel = this.CreateType<MessageModel>();
            var methodBusinessLayerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };
            object[] parametersOfBusinessLayerExceptionHandler = { ex, messageModels, iLog, exceptionMessageToLog, exceptionMessageCulture, newMessageNatLangId, newMessageModel };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBusinessLayerExceptionHandler, parametersOfBusinessLayerExceptionHandler, methodBusinessLayerExceptionHandlerParametersTypes);

            // Assert
            parametersOfBusinessLayerExceptionHandler.ShouldNotBeNull();
            parametersOfBusinessLayerExceptionHandler.Length.ShouldBe(7);
            methodBusinessLayerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodBusinessLayerExceptionHandler, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var methodBusinessLayerExceptionHandlerParametersTypes = new Type[] { typeof(Exception), typeof(List<MessageModel>), typeof(ILogger), typeof(string), typeof(string), typeof(string), typeof(MessageModel) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBusinessLayerExceptionHandler, methodBusinessLayerExceptionHandlerParametersTypes);

            // Assert
            methodBusinessLayerExceptionHandlerParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BusinessLayerExceptionHandler) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelperUI_BusinessLayerExceptionHandler_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBusinessLayerExceptionHandler);
            var currentMethodInfo = this.GetMethodInfo(MethodBusinessLayerExceptionHandler, 0);

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