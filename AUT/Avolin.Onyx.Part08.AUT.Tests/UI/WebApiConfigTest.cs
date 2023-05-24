using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.WebApiConfig" />)
    ///     and namespace <see cref="Onyx.UI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WebApiConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WebApiConfig" />)
        /// </summary>
        public WebApiConfigTest() : base(typeof(WebApiConfig))
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

        #region General Initializer : Class (WebApiConfig) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _webApiConfigInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="WebApiConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _webApiConfigInstanceType = typeof(WebApiConfig);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WebApiConfig) Initializer

        #region Methods

        private const string MethodEnableCORS = "EnableCORS";
        private const string MethodRegisterSecurityAPI = "RegisterSecurityAPI";
        private const string MethodRegisterScriptingAPI = "RegisterScriptingAPI";
        private const string MethodRegisterSurveyAPI = "RegisterSurveyAPI";
        private const string MethodRegisterNaivigatorAPI = "RegisterNaivigatorAPI";
        private const string MethodRegisterNotificationAPI = "RegisterNotificationAPI";
        private const string MethodRegisterFormAPI = "RegisterFormAPI";
        private const string MethodRegister = "Register";

        #endregion

        #endregion

        #region General Initializer : Class (WebApiConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WebApiConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WebApiConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WebApiConfig)

        #region General Initializer : Class (WebApiConfig) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="WebApiConfig" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodEnableCORS, 0)]
        [TestCase(MethodRegisterSecurityAPI, 0)]
        [TestCase(MethodRegisterScriptingAPI, 0)]
        [TestCase(MethodRegisterSurveyAPI, 0)]
        [TestCase(MethodRegisterNaivigatorAPI, 0)]
        [TestCase(MethodRegisterNotificationAPI, 0)]
        [TestCase(MethodRegisterFormAPI, 0)]
        [TestCase(MethodRegister, 0)]
        public void AUT_WebApiConfig_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (WebApiConfig) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WebApiConfig" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WebApiConfig_Is_Static_Type_Present_Test()
        {
            // Assert
            _webApiConfigInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (EnableCORS) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.EnableCORS(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EnableCORS) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var config = this.CreateType<HttpConfiguration>();
            var methodEnableCORSParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfEnableCORS = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEnableCORS, methodEnableCORSParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfEnableCORS);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEnableCORS.ShouldNotBeNull();
            parametersOfEnableCORS.Length.ShouldBe(1);
            methodEnableCORSParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EnableCORS) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var config = this.CreateType<HttpConfiguration>();
            var methodEnableCORSParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfEnableCORS = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEnableCORS, parametersOfEnableCORS, methodEnableCORSParametersTypes);

            // Assert
            parametersOfEnableCORS.ShouldNotBeNull();
            parametersOfEnableCORS.Length.ShouldBe(1);
            methodEnableCORSParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnableCORS) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var currentMethodInfo = this.GetMethodInfo(MethodEnableCORS, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EnableCORS) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var methodEnableCORSParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEnableCORS, methodEnableCORSParametersTypes);

            // Assert
            methodEnableCORSParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnableCORS) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_EnableCORS_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableCORS);
            var currentMethodInfo = this.GetMethodInfo(MethodEnableCORS, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterSecurityAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterSecurityAPI, methodRegisterSecurityAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterSecurityAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterSecurityAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterSecurityAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSecurityAPI, methodRegisterSecurityAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterSecurityAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterSecurityAPI.ShouldNotBeNull();
            parametersOfRegisterSecurityAPI.Length.ShouldBe(1);
            methodRegisterSecurityAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterSecurityAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterSecurityAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterSecurityAPI, parametersOfRegisterSecurityAPI, methodRegisterSecurityAPIParametersTypes);

            // Assert
            parametersOfRegisterSecurityAPI.ShouldNotBeNull();
            parametersOfRegisterSecurityAPI.Length.ShouldBe(1);
            methodRegisterSecurityAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSecurityAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var methodRegisterSecurityAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterSecurityAPI, methodRegisterSecurityAPIParametersTypes);

            // Assert
            methodRegisterSecurityAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSecurityAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSecurityAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSecurityAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSecurityAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterScriptingAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterScriptingAPI, methodRegisterScriptingAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterScriptingAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterScriptingAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterScriptingAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterScriptingAPI, methodRegisterScriptingAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterScriptingAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterScriptingAPI.ShouldNotBeNull();
            parametersOfRegisterScriptingAPI.Length.ShouldBe(1);
            methodRegisterScriptingAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterScriptingAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterScriptingAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterScriptingAPI, parametersOfRegisterScriptingAPI, methodRegisterScriptingAPIParametersTypes);

            // Assert
            parametersOfRegisterScriptingAPI.ShouldNotBeNull();
            parametersOfRegisterScriptingAPI.Length.ShouldBe(1);
            methodRegisterScriptingAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterScriptingAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var methodRegisterScriptingAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterScriptingAPI, methodRegisterScriptingAPIParametersTypes);

            // Assert
            methodRegisterScriptingAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterScriptingAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterScriptingAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterScriptingAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterScriptingAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterSurveyAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterSurveyAPI, methodRegisterSurveyAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterSurveyAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterSurveyAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterSurveyAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSurveyAPI, methodRegisterSurveyAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterSurveyAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterSurveyAPI.ShouldNotBeNull();
            parametersOfRegisterSurveyAPI.Length.ShouldBe(1);
            methodRegisterSurveyAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterSurveyAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterSurveyAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterSurveyAPI, parametersOfRegisterSurveyAPI, methodRegisterSurveyAPIParametersTypes);

            // Assert
            parametersOfRegisterSurveyAPI.ShouldNotBeNull();
            parametersOfRegisterSurveyAPI.Length.ShouldBe(1);
            methodRegisterSurveyAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSurveyAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var methodRegisterSurveyAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterSurveyAPI, methodRegisterSurveyAPIParametersTypes);

            // Assert
            methodRegisterSurveyAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterSurveyAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterSurveyAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterSurveyAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterSurveyAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterNaivigatorAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterNaivigatorAPI, methodRegisterNaivigatorAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterNaivigatorAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterNaivigatorAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterNaivigatorAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNaivigatorAPI, methodRegisterNaivigatorAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterNaivigatorAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterNaivigatorAPI.ShouldNotBeNull();
            parametersOfRegisterNaivigatorAPI.Length.ShouldBe(1);
            methodRegisterNaivigatorAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterNaivigatorAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterNaivigatorAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterNaivigatorAPI, parametersOfRegisterNaivigatorAPI, methodRegisterNaivigatorAPIParametersTypes);

            // Assert
            parametersOfRegisterNaivigatorAPI.ShouldNotBeNull();
            parametersOfRegisterNaivigatorAPI.Length.ShouldBe(1);
            methodRegisterNaivigatorAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNaivigatorAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var methodRegisterNaivigatorAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterNaivigatorAPI, methodRegisterNaivigatorAPIParametersTypes);

            // Assert
            methodRegisterNaivigatorAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNaivigatorAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNaivigatorAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNaivigatorAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNaivigatorAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterNotificationAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterNotificationAPI, methodRegisterNotificationAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterNotificationAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterNotificationAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterNotificationAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNotificationAPI, methodRegisterNotificationAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterNotificationAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterNotificationAPI.ShouldNotBeNull();
            parametersOfRegisterNotificationAPI.Length.ShouldBe(1);
            methodRegisterNotificationAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterNotificationAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterNotificationAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterNotificationAPI, parametersOfRegisterNotificationAPI, methodRegisterNotificationAPIParametersTypes);

            // Assert
            parametersOfRegisterNotificationAPI.ShouldNotBeNull();
            parametersOfRegisterNotificationAPI.Length.ShouldBe(1);
            methodRegisterNotificationAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNotificationAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var methodRegisterNotificationAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterNotificationAPI, methodRegisterNotificationAPIParametersTypes);

            // Assert
            methodRegisterNotificationAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterNotificationAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterNotificationAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterNotificationAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterNotificationAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterFormAPIParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegisterFormAPI, methodRegisterFormAPIParametersTypes);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.RegisterFormAPI(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterFormAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterFormAPI = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterFormAPI, methodRegisterFormAPIParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegisterFormAPI);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegisterFormAPI.ShouldNotBeNull();
            parametersOfRegisterFormAPI.Length.ShouldBe(1);
            methodRegisterFormAPIParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterFormAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegisterFormAPI = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegisterFormAPI, parametersOfRegisterFormAPI, methodRegisterFormAPIParametersTypes);

            // Assert
            parametersOfRegisterFormAPI.ShouldNotBeNull();
            parametersOfRegisterFormAPI.Length.ShouldBe(1);
            methodRegisterFormAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterFormAPI, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var methodRegisterFormAPIParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegisterFormAPI, methodRegisterFormAPIParametersTypes);

            // Assert
            methodRegisterFormAPIParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RegisterFormAPI) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_RegisterFormAPI_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegisterFormAPI);
            var currentMethodInfo = this.GetMethodInfo(MethodRegisterFormAPI, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WebApiConfig_Register_Static_Method_Call_Internally(Type[] types)
        {
            var methodRegisterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRegister, methodRegisterParametersTypes);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var config = this.CreateType<HttpConfiguration>();

            // Act
            Action executeAction = () => WebApiConfig.Register(config);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegister = { config };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRegister, methodRegisterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfRegister);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRegister.ShouldNotBeNull();
            parametersOfRegister.Length.ShouldBe(1);
            methodRegisterParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var config = this.CreateType<HttpConfiguration>();
            var methodRegisterParametersTypes = new Type[] { typeof(HttpConfiguration) };
            object[] parametersOfRegister = { config };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRegister, parametersOfRegister, methodRegisterParametersTypes);

            // Assert
            parametersOfRegister.ShouldNotBeNull();
            parametersOfRegister.Length.ShouldBe(1);
            methodRegisterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var currentMethodInfo = this.GetMethodInfo(MethodRegister, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var methodRegisterParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRegister, methodRegisterParametersTypes);

            // Assert
            methodRegisterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Register) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WebApiConfig_Register_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRegister);
            var currentMethodInfo = this.GetMethodInfo(MethodRegister, 0);

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