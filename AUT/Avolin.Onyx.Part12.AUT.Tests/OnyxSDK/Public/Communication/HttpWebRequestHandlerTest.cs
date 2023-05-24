using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Communication;
using OnyxSDK.Public.Configuration;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Communication
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Communication.HttpWebRequestHandler" />)
    ///     and namespace <see cref="OnyxSDK.Public.Communication"/> class using generator(v:0.2.5)'s
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
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var apiAddress = this.CreateType<string>();
            var requestMethod = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.CreateWebRequest(applicationName, siteId, languageCode, apiAddress, requestMethod);

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
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var apiAddress = this.CreateType<string>();
            var requestMethod = this.CreateType<string>();
            var returnedValue = default(HttpWebRequest);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.CreateWebRequest(applicationName, siteId, languageCode, apiAddress, requestMethod);
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
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var apiAddress = this.CreateType<string>();
            var requestMethod = this.CreateType<string>();
            var methodCreateWebRequestParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfCreateWebRequest = { applicationName, siteId, languageCode, apiAddress, requestMethod };
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
            parametersOfCreateWebRequest.ShouldNotBeNull();
            parametersOfCreateWebRequest.Length.ShouldBe(5);
            methodCreateWebRequestParametersTypes.Length.ShouldBe(5);
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
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var apiAddress = this.CreateType<string>();
            var requestMethod = this.CreateType<string>();
            var methodCreateWebRequestParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfCreateWebRequest = { applicationName, siteId, languageCode, apiAddress, requestMethod };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HttpWebRequest>(MethodCreateWebRequest, parametersOfCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            parametersOfCreateWebRequest.ShouldNotBeNull();
            parametersOfCreateWebRequest.Length.ShouldBe(5);
            methodCreateWebRequestParametersTypes.Length.ShouldBe(5);
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
            var methodCreateWebRequestParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateWebRequestParametersTypes.Length.ShouldBe(5);
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
            var methodCreateWebRequestParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateWebRequest, methodCreateWebRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateWebRequestParametersTypes.Length.ShouldBe(parametersCount);
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

        #region Method Call : (CreateWebRequest) (Return Type : HttpWebRequest) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_CreateWebRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateWebRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateWebRequest, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
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

        #region Method Call : (AppendAuthCredentials) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var webRequest = this.CreateType<HttpWebRequest>();
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxSDKGatewayServiceConfiguration>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.AppendAuthCredentials(webRequest, onyxGatewayServiceConfiguration);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AppendAuthCredentials) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_AppendAuthCredentials_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAppendAuthCredentials);
            var webRequest = this.CreateType<HttpWebRequest>();
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxSDKGatewayServiceConfiguration>();
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxSDKGatewayServiceConfiguration) };
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
            Should.NotThrow(currentAction);
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
            var onyxGatewayServiceConfiguration = this.CreateType<OnyxSDKGatewayServiceConfiguration>();
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxSDKGatewayServiceConfiguration) };
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
            var methodAppendAuthCredentialsParametersTypes = new Type[] { typeof(HttpWebRequest), typeof(OnyxSDKGatewayServiceConfiguration) };

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

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetOnyxGatewayServiceConfiguration(applicationName, siteId, languageCode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var returnedValue = default(OnyxSDKGatewayServiceConfiguration);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetOnyxGatewayServiceConfiguration(applicationName, siteId, languageCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetOnyxGatewayServiceConfiguration = { applicationName, siteId, languageCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxSDKGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldNotBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.Length.ShouldBe(3);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<OnyxSDKGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes));
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetOnyxGatewayServiceConfiguration = { applicationName, siteId, languageCode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOnyxGatewayServiceConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldNotBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.Length.ShouldBe(3);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var languageCode = this.CreateType<string>();
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetOnyxGatewayServiceConfiguration = { applicationName, siteId, languageCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxSDKGatewayServiceConfiguration>(MethodGetOnyxGatewayServiceConfiguration, parametersOfGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            parametersOfGetOnyxGatewayServiceConfiguration.ShouldNotBeNull();
            parametersOfGetOnyxGatewayServiceConfiguration.Length.ShouldBe(3);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxGatewayServiceConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var methodGetOnyxGatewayServiceConfigurationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxGatewayServiceConfiguration, methodGetOnyxGatewayServiceConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxGatewayServiceConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxGatewayServiceConfiguration) (Return Type : OnyxSDKGatewayServiceConfiguration) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetOnyxGatewayServiceConfiguration_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxGatewayServiceConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxGatewayServiceConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
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

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GenerateBasicAuthenticationHeader(userName, password);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
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
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
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

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenerateBasicAuthenticationHeader.ShouldNotBeNull();
            parametersOfGenerateBasicAuthenticationHeader.Length.ShouldBe(2);
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGenerateBasicAuthenticationHeader, parametersOfGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes));
        }

        #endregion

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGenerateBasicAuthenticationHeader = { userName, password };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateBasicAuthenticationHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateBasicAuthenticationHeader.ShouldNotBeNull();
            parametersOfGenerateBasicAuthenticationHeader.Length.ShouldBe(2);
            methodGenerateBasicAuthenticationHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
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

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var methodGenerateBasicAuthenticationHeaderParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGenerateBasicAuthenticationHeader, methodGenerateBasicAuthenticationHeaderParametersTypes);

            // Assert
            result.ShouldNotBeNull();
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

        #region Method Call : (GenerateBasicAuthenticationHeader) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GenerateBasicAuthenticationHeader_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateBasicAuthenticationHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateBasicAuthenticationHeader, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
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

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetNetworkCredential(userName, password);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
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
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
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

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNetworkCredential.ShouldNotBeNull();
            parametersOfGetNetworkCredential.Length.ShouldBe(2);
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<NetworkCredential>(MethodGetNetworkCredential, parametersOfGetNetworkCredential, methodGetNetworkCredentialParametersTypes));
        }

        #endregion

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetNetworkCredential = { userName, password };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetNetworkCredential);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetNetworkCredential.ShouldNotBeNull();
            parametersOfGetNetworkCredential.Length.ShouldBe(2);
            methodGetNetworkCredentialParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
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

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var methodGetNetworkCredentialParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNetworkCredential, methodGetNetworkCredentialParametersTypes);

            // Assert
            result.ShouldNotBeNull();
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

        #region Method Call : (GetNetworkCredential) (Return Type : NetworkCredential) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetNetworkCredential_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNetworkCredential);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNetworkCredential, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
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