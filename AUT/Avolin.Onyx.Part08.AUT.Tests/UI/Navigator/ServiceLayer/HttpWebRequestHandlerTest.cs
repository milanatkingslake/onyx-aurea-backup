using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Net.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.HttpWebRequestHandler" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
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

        private const string MethodGetResponseFromServer = "GetResponseFromServer";
        private const string MethodSetHeaders = "SetHeaders";

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
        [TestCase(MethodGetResponseFromServer, 0)]
        [TestCase(MethodSetHeaders, 0)]
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

        #region Method Call : (GetResponseFromServer) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var manifest = this.CreateType<NavigatorManifest>();
            var xml = this.CreateType<string>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.GetResponseFromServer(manifest, xml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var manifest = this.CreateType<NavigatorManifest>();
            var xml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = HttpWebRequestHandler.GetResponseFromServer(manifest, xml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var manifest = this.CreateType<NavigatorManifest>();
            var xml = this.CreateType<string>();
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(NavigatorManifest), typeof(string) };
            object[] parametersOfGetResponseFromServer = { manifest, xml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetResponseFromServer, parametersOfGetResponseFromServer, methodGetResponseFromServerParametersTypes);
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

        #region Method Call : (GetResponseFromServer) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var manifest = this.CreateType<NavigatorManifest>();
            var xml = this.CreateType<string>();
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(NavigatorManifest), typeof(string) };
            object[] parametersOfGetResponseFromServer = { manifest, xml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetResponseFromServer, parametersOfGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            parametersOfGetResponseFromServer.ShouldNotBeNull();
            parametersOfGetResponseFromServer.Length.ShouldBe(2);
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(NavigatorManifest), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_GetResponseFromServer_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResponseFromServer);
            var methodGetResponseFromServerParametersTypes = new Type[] { typeof(NavigatorManifest), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResponseFromServer, methodGetResponseFromServerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResponseFromServerParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResponseFromServer) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (GetResponseFromServer) (Return Type : string) Parameters Count verify

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

        #region Method Call : (SetHeaders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetHeadersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetHeaders, methodSetHeadersParametersTypes);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var destination = this.CreateType<HttpWebRequest>();

            // Act
            Action executeAction = () => HttpWebRequestHandler.SetHeaders(source, destination);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var destination = this.CreateType<HttpWebRequest>();
            var methodSetHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage), typeof(HttpWebRequest) };
            object[] parametersOfSetHeaders = { source, destination };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetHeaders, methodSetHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetHeaders.ShouldNotBeNull();
            parametersOfSetHeaders.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var destination = this.CreateType<HttpWebRequest>();
            var methodSetHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage), typeof(HttpWebRequest) };
            object[] parametersOfSetHeaders = { source, destination };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetHeaders, parametersOfSetHeaders, methodSetHeadersParametersTypes);

            // Assert
            parametersOfSetHeaders.ShouldNotBeNull();
            parametersOfSetHeaders.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetHeaders, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var methodSetHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage), typeof(HttpWebRequest) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetHeaders, methodSetHeadersParametersTypes);

            // Assert
            methodSetHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpWebRequestHandler_SetHeaders_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetHeaders, 0);

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