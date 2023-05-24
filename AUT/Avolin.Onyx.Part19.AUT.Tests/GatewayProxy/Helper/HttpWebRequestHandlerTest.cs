using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Net;
using System.ServiceModel.Channels;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GatewayProxy.Helper;
using Shouldly;

namespace Avolin.Onyx.Part19.AUT.Tests.GatewayProxy.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.Helper.HttpWebRequestHandler" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HttpWebRequestHandlerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HttpWebRequestHandler" />)
        /// </summary>
        public HttpWebRequestHandlerTest() : base(typeof(HttpWebRequestHandler))
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

        #region General Initializer : Class (HttpWebRequestHandler) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _httpWebRequestHandlerInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="HttpWebRequestHandler" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _httpWebRequestHandlerInstanceType = typeof(HttpWebRequestHandler);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HttpWebRequestHandler) Initializer

        #region Methods

        private const string MethodCreateWebRequest = "CreateWebRequest";
        private const string MethodGetResponseFromServerUsingMessage = "GetResponseFromServerUsingMessage";
        private const string MethodGetResponseFromServerUsingXElement = "GetResponseFromServerUsingXElement";
        private const string MethodGetResponseFromServer = "GetResponseFromServer";
        private const string MethodGetResponseFromServerAsStream = "GetResponseFromServerAsStream";
        private const string MethodBuildRequestStream = "BuildRequestStream";
        private const string MethodBuildRequestMemoryStream = "BuildRequestMemoryStream";
        private const string MethodAppendAuthCredentials = "AppendAuthCredentials";
        private const string MethodGetOnyxGatewayServiceConfiguration = "GetOnyxGatewayServiceConfiguration";
        private const string MethodGenerateBasicAuthenticationHeader = "GenerateBasicAuthenticationHeader";
        private const string MethodGetNetworkCredential = "GetNetworkCredential";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (HttpWebRequestHandler) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HttpWebRequestHandler" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HttpWebRequestHandler_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HttpWebRequestHandler) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HttpWebRequestHandler" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HttpWebRequestHandler_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HttpWebRequestHandler)

        #region General Initializer : Class (HttpWebRequestHandler) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HttpWebRequestHandler" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateWebRequest, 0)]
        [TestCase(MethodGetResponseFromServerUsingMessage, 0)]
        [TestCase(MethodGetResponseFromServerUsingXElement, 0)]
        [TestCase(MethodGetResponseFromServer, 0)]
        [TestCase(MethodGetResponseFromServerAsStream, 0)]
        [TestCase(MethodBuildRequestStream, 0)]
        [TestCase(MethodBuildRequestMemoryStream, 0)]
        [TestCase(MethodAppendAuthCredentials, 0)]
        [TestCase(MethodGetOnyxGatewayServiceConfiguration, 0)]
        [TestCase(MethodGenerateBasicAuthenticationHeader, 0)]
        [TestCase(MethodGetNetworkCredential, 0)]
        public void AUT_HttpWebRequestHandler_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HttpWebRequestHandler) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HttpWebRequestHandler" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_HttpWebRequestHandler_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HttpWebRequestHandler) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HttpWebRequestHandler" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HttpWebRequestHandler_Is_Static_Type_Present_Test()
        {
            // Assert
            _httpWebRequestHandlerInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);

            // Act
            Action executeAction = () => HttpWebRequestHandler.CreateWebRequest();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            var returnedValue = default(HttpWebRequest);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.CreateWebRequest();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            Type [] methodCreateWebRequestParametersTypes = null;
            object[] parametersOfCreateWebRequest = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateWebRequest, methodCreateWebRequestParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateWebRequest, methodCreateWebRequestParametersTypes);
            var result2 = this.GetResultOfMethod<HttpWebRequest>(MethodCreateWebRequest, parametersOfCreateWebRequest, methodCreateWebRequestParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateWebRequest);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateWebRequest.ShouldBeNull();
            methodCreateWebRequestParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            Type [] methodCreateWebRequestParametersTypes = null;
            object[] parametersOfCreateWebRequest = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<HttpWebRequest>(MethodCreateWebRequest, parametersOfCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            parametersOfCreateWebRequest.ShouldBeNull();
            methodCreateWebRequestParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            Type [] methodCreateWebRequestParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateWebRequestParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            Type [] methodCreateWebRequestParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateWebRequestParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateWebRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseFromServerUsingMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetResponseFromServerUsingMessage(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetResponseFromServerUsingMessage(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var message = this.CreateType<Message>();
            var methodGetResponseFromServerUsingMessageParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetResponseFromServerUsingMessage = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);
            var result2 = this.GetResultOfMethod<Message>(MethodGetResponseFromServerUsingMessage, parametersOfGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResponseFromServerUsingMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseFromServerUsingMessage.ShouldNotBeNull();
            parametersOfGetResponseFromServerUsingMessage.Length.ShouldBe(1);
            methodGetResponseFromServerUsingMessageParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var message = this.CreateType<Message>();
            var methodGetResponseFromServerUsingMessageParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetResponseFromServerUsingMessage = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetResponseFromServerUsingMessage, parametersOfGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);

            // Assert
            parametersOfGetResponseFromServerUsingMessage.ShouldNotBeNull();
            parametersOfGetResponseFromServerUsingMessage.Length.ShouldBe(1);
            methodGetResponseFromServerUsingMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var methodGetResponseFromServerUsingMessageParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseFromServerUsingMessageParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var methodGetResponseFromServerUsingMessageParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingMessage, methodGetResponseFromServerUsingMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseFromServerUsingMessageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingMessage) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingMessage_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingMessage, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseFromServerUsingXElementParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var xElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetResponseFromServerUsingXElement(xElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var xElement = this.CreateType<XElement>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetResponseFromServerUsingXElement(xElement);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var xElement = this.CreateType<XElement>();
            var methodGetResponseFromServerUsingXElementParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetResponseFromServerUsingXElement = { xElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);
            var result2 = this.GetResultOfMethod<Message>(MethodGetResponseFromServerUsingXElement, parametersOfGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResponseFromServerUsingXElement);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseFromServerUsingXElement.ShouldNotBeNull();
            parametersOfGetResponseFromServerUsingXElement.Length.ShouldBe(1);
            methodGetResponseFromServerUsingXElementParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var xElement = this.CreateType<XElement>();
            var methodGetResponseFromServerUsingXElementParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetResponseFromServerUsingXElement = { xElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetResponseFromServerUsingXElement, parametersOfGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);

            // Assert
            parametersOfGetResponseFromServerUsingXElement.ShouldNotBeNull();
            parametersOfGetResponseFromServerUsingXElement.Length.ShouldBe(1);
            methodGetResponseFromServerUsingXElementParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var methodGetResponseFromServerUsingXElementParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseFromServerUsingXElementParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var methodGetResponseFromServerUsingXElementParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerUsingXElement, methodGetResponseFromServerUsingXElementParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseFromServerUsingXElementParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingXElement, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerUsingXElement) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerUsingXElement_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerUsingXElement);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerUsingXElement, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseFromServerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var messageStream = this.CreateType<Stream>();
            var encoding = this.CreateType<bool>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetResponseFromServer(messageStream, encoding);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var messageStream = this.CreateType<Stream>();
            var encoding = this.CreateType<bool>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetResponseFromServer(messageStream, encoding);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var messageStream = this.CreateType<Stream>();
            var encoding = this.CreateType<bool>();
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(Stream), typeof(bool) };
            object[] parametersOfGetResponseFromServer = { messageStream, encoding };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);
            var result2 = this.GetResultOfMethod<Message>(MethodGetResponseFromServer, parametersOfGetResponseFromServer, methodGetResponseFromServerParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResponseFromServer);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseFromServer.ShouldNotBeNull();
            parametersOfGetResponseFromServer.Length.ShouldBe(2);
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var messageStream = this.CreateType<Stream>();
            var encoding = this.CreateType<bool>();
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(Stream), typeof(bool) };
            object[] parametersOfGetResponseFromServer = { messageStream, encoding };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetResponseFromServer, parametersOfGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            parametersOfGetResponseFromServer.ShouldNotBeNull();
            parametersOfGetResponseFromServer.Length.ShouldBe(2);
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(Stream), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(Stream), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServer, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServer, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetResponseFromServerAsStreamParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var messageStream = this.CreateType<Stream>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetResponseFromServerAsStream(messageStream);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var messageStream = this.CreateType<Stream>();
            var returnedValue = default(Stream);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetResponseFromServerAsStream(messageStream);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var messageStream = this.CreateType<Stream>();
            var methodGetResponseFromServerAsStreamParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfGetResponseFromServerAsStream = { messageStream };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);
            var result2 = this.GetResultOfMethod<Stream>(MethodGetResponseFromServerAsStream, parametersOfGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetResponseFromServerAsStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResponseFromServerAsStream.ShouldNotBeNull();
            parametersOfGetResponseFromServerAsStream.Length.ShouldBe(1);
            methodGetResponseFromServerAsStreamParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var messageStream = this.CreateType<Stream>();
            var methodGetResponseFromServerAsStreamParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfGetResponseFromServerAsStream = { messageStream };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Stream>(MethodGetResponseFromServerAsStream, parametersOfGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);

            // Assert
            parametersOfGetResponseFromServerAsStream.ShouldNotBeNull();
            parametersOfGetResponseFromServerAsStream.Length.ShouldBe(1);
            methodGetResponseFromServerAsStreamParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var methodGetResponseFromServerAsStreamParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseFromServerAsStreamParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var methodGetResponseFromServerAsStreamParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServerAsStream, methodGetResponseFromServerAsStreamParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseFromServerAsStreamParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerAsStream, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServerAsStream) (Return Type : Stream) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServerAsStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServerAsStream);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServerAsStream, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_Internally(Type[] types)
        {
            var methodBuildRequestStreamParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildRequestStream, methodBuildRequestStreamParametersTypes);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.BuildRequestStream(ref webRequest, messageStream);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();
            var methodBuildRequestStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };
            object[] parametersOfBuildRequestStream = { webRequest, messageStream };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestStream, methodBuildRequestStreamParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfBuildRequestStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildRequestStream.ShouldNotBeNull();
            parametersOfBuildRequestStream.Length.ShouldBe(2);
            methodBuildRequestStreamParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();
            var methodBuildRequestStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };
            object[] parametersOfBuildRequestStream = { webRequest, messageStream };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBuildRequestStream, parametersOfBuildRequestStream, methodBuildRequestStreamParametersTypes);

            // Assert
            parametersOfBuildRequestStream.ShouldNotBeNull();
            parametersOfBuildRequestStream.Length.ShouldBe(2);
            methodBuildRequestStreamParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestStream, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var methodBuildRequestStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildRequestStream, methodBuildRequestStreamParametersTypes);

            // Assert
            methodBuildRequestStreamParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestStream) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestStream_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestStream);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestStream, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_Internally(Type[] types)
        {
            var methodBuildRequestMemoryStreamParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBuildRequestMemoryStream, methodBuildRequestMemoryStreamParametersTypes);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.BuildRequestMemoryStream(ref webRequest, messageStream);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();
            var methodBuildRequestMemoryStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };
            object[] parametersOfBuildRequestMemoryStream = { webRequest, messageStream };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestMemoryStream, methodBuildRequestMemoryStreamParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfBuildRequestMemoryStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBuildRequestMemoryStream.ShouldNotBeNull();
            parametersOfBuildRequestMemoryStream.Length.ShouldBe(2);
            methodBuildRequestMemoryStreamParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var webRequest = this.CreateType<HttpWebRequest>();
            var messageStream = this.CreateType<Stream>();
            var methodBuildRequestMemoryStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };
            object[] parametersOfBuildRequestMemoryStream = { webRequest, messageStream };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBuildRequestMemoryStream, parametersOfBuildRequestMemoryStream, methodBuildRequestMemoryStreamParametersTypes);

            // Assert
            parametersOfBuildRequestMemoryStream.ShouldNotBeNull();
            parametersOfBuildRequestMemoryStream.Length.ShouldBe(2);
            methodBuildRequestMemoryStreamParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestMemoryStream, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var methodBuildRequestMemoryStreamParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(Stream) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBuildRequestMemoryStream, methodBuildRequestMemoryStreamParametersTypes);

            // Assert
            methodBuildRequestMemoryStreamParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BuildRequestMemoryStream) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_BuildRequestMemoryStream_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBuildRequestMemoryStream);
            var currentMethodInfo = this.GetMethodInfo(MethodBuildRequestMemoryStream, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Internally(Type[] types)
        {
            var methodAppendAuthCredentialsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAppendAuthCredentials, methodAppendAuthCredentialsParametersTypes);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var webRequest = this.CreateType<HttpWebRequest>();
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxGatewayServiceConfiguration>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.AppendAuthCredentials(webRequest, onyxGatewayServiceConfiguration);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var webRequest = this.CreateType<HttpWebRequest>();
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxGatewayServiceConfiguration>();
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxGatewayServiceConfiguration) };
            object[] parametersOfAppendAuthCredentials = { webRequest, onyxGatewayServiceConfiguration };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAppendAuthCredentials, methodAppendAuthCredentialsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfAppendAuthCredentials);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAppendAuthCredentials.ShouldNotBeNull();
            parametersOfAppendAuthCredentials.Length.ShouldBe(2);
            methodAppendAuthCredentialsParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var webRequest = this.CreateType<HttpWebRequest>();
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxGatewayServiceConfiguration>();
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxGatewayServiceConfiguration) };
            object[] parametersOfAppendAuthCredentials = { webRequest, onyxGatewayServiceConfiguration };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAppendAuthCredentials, parametersOfAppendAuthCredentials, methodAppendAuthCredentialsParametersTypes);

            // Assert
            parametersOfAppendAuthCredentials.ShouldNotBeNull();
            parametersOfAppendAuthCredentials.Length.ShouldBe(2);
            methodAppendAuthCredentialsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendAuthCredentials, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxGatewayServiceConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAppendAuthCredentials, methodAppendAuthCredentialsParametersTypes);

            // Assert
            methodAppendAuthCredentialsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var currentMethodInfo = this.GetMethodInfo(MethodAppendAuthCredentials, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetOnyxGatewayServiceConfiguration();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var returnedValue = default(OnyxGatewayServiceConfiguration);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetOnyxGatewayServiceConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfiguration = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOnyxGatewayServiceConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;
            object[] parametersOfGetOnyxGatewayServiceConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            Type [] methodGetOnyxGatewayServiceConfigurationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxGatewayServiceConfiguration) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Internally(Type[] types)
        {
            var methodGenerateBasicAuthenticationHeaderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GenerateBasicAuthenticationHeader(userName, password);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GenerateBasicAuthenticationHeader(userName, password);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateBasicAuthenticationHeader = { userName, password };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGenerateBasicAuthenticationHeader, parametersOfGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateBasicAuthenticationHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGenerateBasicAuthenticationHeader.ShouldNotBeNull();
            parametersOfGenerateBasicAuthenticationHeader.Length.ShouldBe(2);
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateBasicAuthenticationHeader = { userName, password };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGenerateBasicAuthenticationHeader, parametersOfGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);

            // Assert
            parametersOfGenerateBasicAuthenticationHeader.ShouldNotBeNull();
            parametersOfGenerateBasicAuthenticationHeader.Length.ShouldBe(2);
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateBasicAuthenticationHeader, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateBasicAuthenticationHeader, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetNetworkCredentialParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetNetworkCredential(userName, password);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var returnedValue = default(NetworkCredential);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetNetworkCredential(userName, password);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetNetworkCredential = { userName, password };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes);
            var result2 = this.GetResultOfMethod<NetworkCredential>(MethodGetNetworkCredential, parametersOfGetNetworkCredential, methodGetNetworkCredentialParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNetworkCredential);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNetworkCredential.ShouldNotBeNull();
            parametersOfGetNetworkCredential.Length.ShouldBe(2);
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetNetworkCredential = { userName, password };

            // Act
            Action currentAction = () => this.GetResultOfMethod<NetworkCredential>(MethodGetNetworkCredential, parametersOfGetNetworkCredential, methodGetNetworkCredentialParametersTypes);

            // Assert
            parametersOfGetNetworkCredential.ShouldNotBeNull();
            parametersOfGetNetworkCredential.Length.ShouldBe(2);
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNetworkCredential, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNetworkCredential, 0);
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