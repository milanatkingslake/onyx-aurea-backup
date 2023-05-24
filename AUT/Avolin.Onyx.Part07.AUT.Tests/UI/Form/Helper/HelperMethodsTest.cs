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
using Onyx.UI.Form.Helper;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Form.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Form.Helper.HelperMethods" />)
    ///     and namespace <see cref="Onyx.UI.Form.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelperMethodsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelperMethods" />)
        /// </summary>
        public HelperMethodsTest() : base(typeof(HelperMethods))
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

        #region General Initializer : Class (HelperMethods) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helperMethodsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="HelperMethods" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helperMethodsInstanceType = typeof(HelperMethods);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelperMethods) Initializer

        #region Properties

        private const string PropertyOGSBaseUrl = "OGSBaseUrl";

        #endregion

        #region Methods

        private const string MethodGetQueryString = "GetQueryString";
        private const string MethodDoRequest = "DoRequest";
        private const string MethodSetOnyxHeaders = "SetOnyxHeaders";
        private const string MethodGetOnyxHeaders = "GetOnyxHeaders";

        #endregion

        #endregion

        #region General Initializer : Class (HelperMethods) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelperMethods" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelperMethods_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelperMethods) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelperMethods" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelperMethods_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelperMethods)

        #region General Initializer : Class (HelperMethods) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelperMethods" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetQueryString, 0)]
        [TestCase(MethodDoRequest, 0)]
        [TestCase(MethodSetOnyxHeaders, 0)]
        [TestCase(MethodGetOnyxHeaders, 0)]
        public void AUT_HelperMethods_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelperMethods) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelperMethods" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOGSBaseUrl)]
        [Category("AUT Property")]
        public void AUT_HelperMethods_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HelperMethods) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HelperMethods" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelperMethods_Is_Static_Type_Present_Test()
        {
            // Assert
            _helperMethodsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetQueryString) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var request = this.CreateType<HttpRequestMessage>();

            // Act
            Action executeAction = () => HelperMethods.GetQueryString(request);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var request = this.CreateType<HttpRequestMessage>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = HelperMethods.GetQueryString(request);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var request = this.CreateType<HttpRequestMessage>();
            var methodGetQueryStringParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetQueryString = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryString, methodGetQueryStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetQueryString, methodGetQueryStringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryString, parametersOfGetQueryString, methodGetQueryStringParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetQueryString.ShouldNotBeNull();
            parametersOfGetQueryString.Length.ShouldBe(1);
            methodGetQueryStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetQueryString, parametersOfGetQueryString, methodGetQueryStringParametersTypes));
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var request = this.CreateType<HttpRequestMessage>();
            var methodGetQueryStringParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetQueryString = { request };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryString, methodGetQueryStringParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetQueryString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetQueryString.ShouldNotBeNull();
            parametersOfGetQueryString.Length.ShouldBe(1);
            methodGetQueryStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var request = this.CreateType<HttpRequestMessage>();
            var methodGetQueryStringParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetQueryString = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryString, parametersOfGetQueryString, methodGetQueryStringParametersTypes);

            // Assert
            parametersOfGetQueryString.ShouldNotBeNull();
            parametersOfGetQueryString.Length.ShouldBe(1);
            methodGetQueryStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var methodGetQueryStringParametersTypes = new Type[] { typeof(HttpRequestMessage) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryString, methodGetQueryStringParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetQueryStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var methodGetQueryStringParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryString, methodGetQueryStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetQueryString) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetQueryString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethods_DoRequest_Static_Method_Call_Internally(Type[] types)
        {
            var methodDoRequestParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRequest, methodDoRequestParametersTypes);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var uri = this.CreateType<string>();
            var queryString = this.CreateType<string>();
            var httpVerb = this.CreateType<string>();
            var contentType = this.CreateType<string>();
            var postData = this.CreateType<string>();

            // Act
            Action executeAction = () => HelperMethods.DoRequest(onyxHeaderDetail, uri, queryString, httpVerb, contentType, postData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var uri = this.CreateType<string>();
            var queryString = this.CreateType<string>();
            var httpVerb = this.CreateType<string>();
            var contentType = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = HelperMethods.DoRequest(onyxHeaderDetail, uri, queryString, httpVerb, contentType, postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var uri = this.CreateType<string>();
            var queryString = this.CreateType<string>();
            var httpVerb = this.CreateType<string>();
            var contentType = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodDoRequestParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfDoRequest = { onyxHeaderDetail, uri, queryString, httpVerb, contentType, postData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRequest, methodDoRequestParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDoRequest, methodDoRequestParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDoRequest, parametersOfDoRequest, methodDoRequestParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDoRequest);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoRequest.ShouldNotBeNull();
            parametersOfDoRequest.Length.ShouldBe(6);
            methodDoRequestParametersTypes.Length.ShouldBe(6);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var onyxHeaderDetail = this.CreateType<OnyxHeaderDetail>();
            var uri = this.CreateType<string>();
            var queryString = this.CreateType<string>();
            var httpVerb = this.CreateType<string>();
            var contentType = this.CreateType<string>();
            var postData = this.CreateType<string>();
            var methodDoRequestParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfDoRequest = { onyxHeaderDetail, uri, queryString, httpVerb, contentType, postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDoRequest, parametersOfDoRequest, methodDoRequestParametersTypes);

            // Assert
            parametersOfDoRequest.ShouldNotBeNull();
            parametersOfDoRequest.Length.ShouldBe(6);
            methodDoRequestParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var methodDoRequestParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoRequest, methodDoRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoRequestParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var methodDoRequestParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRequest, methodDoRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRequestParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRequest) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_DoRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRequest, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_Internally(Type[] types)
        {
            var methodSetOnyxHeadersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetOnyxHeaders, methodSetOnyxHeadersParametersTypes);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var source = this.CreateType<OnyxHeaderDetail>();
            var destination = this.CreateType<HttpWebRequest>();

            // Act
            Action executeAction = () => HelperMethods.SetOnyxHeaders(source, destination);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var source = this.CreateType<OnyxHeaderDetail>();
            var destination = this.CreateType<HttpWebRequest>();
            var methodSetOnyxHeadersParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(HttpWebRequest) };
            object[] parametersOfSetOnyxHeaders = { source, destination };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetOnyxHeaders, methodSetOnyxHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetOnyxHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetOnyxHeaders.ShouldNotBeNull();
            parametersOfSetOnyxHeaders.Length.ShouldBe(2);
            methodSetOnyxHeadersParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var source = this.CreateType<OnyxHeaderDetail>();
            var destination = this.CreateType<HttpWebRequest>();
            var methodSetOnyxHeadersParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(HttpWebRequest) };
            object[] parametersOfSetOnyxHeaders = { source, destination };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetOnyxHeaders, parametersOfSetOnyxHeaders, methodSetOnyxHeadersParametersTypes);

            // Assert
            parametersOfSetOnyxHeaders.ShouldNotBeNull();
            parametersOfSetOnyxHeaders.Length.ShouldBe(2);
            methodSetOnyxHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetOnyxHeaders, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var methodSetOnyxHeadersParametersTypes = new Type[] { typeof(OnyxHeaderDetail), typeof(HttpWebRequest) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetOnyxHeaders, methodSetOnyxHeadersParametersTypes);

            // Assert
            methodSetOnyxHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetOnyxHeaders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_SetOnyxHeaders_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetOnyxHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetOnyxHeaders, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxHeadersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var source = this.CreateType<HttpRequestMessage>();

            // Act
            Action executeAction = () => HelperMethods.GetOnyxHeaders(source);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var returnedValue = default(OnyxHeaderDetail);

            // Act
            Action executeAction = () => returnedValue = HelperMethods.GetOnyxHeaders(source);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var methodGetOnyxHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetOnyxHeaders = { source };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);
            var result2 = this.GetResultOfMethod<OnyxHeaderDetail>(MethodGetOnyxHeaders, parametersOfGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOnyxHeaders.ShouldNotBeNull();
            parametersOfGetOnyxHeaders.Length.ShouldBe(1);
            methodGetOnyxHeadersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<OnyxHeaderDetail>(MethodGetOnyxHeaders, parametersOfGetOnyxHeaders, methodGetOnyxHeadersParametersTypes));
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var methodGetOnyxHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetOnyxHeaders = { source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetOnyxHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetOnyxHeaders.ShouldNotBeNull();
            parametersOfGetOnyxHeaders.Length.ShouldBe(1);
            methodGetOnyxHeadersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var source = this.CreateType<HttpRequestMessage>();
            var methodGetOnyxHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            object[] parametersOfGetOnyxHeaders = { source };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxHeaderDetail>(MethodGetOnyxHeaders, parametersOfGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);

            // Assert
            parametersOfGetOnyxHeaders.ShouldNotBeNull();
            parametersOfGetOnyxHeaders.Length.ShouldBe(1);
            methodGetOnyxHeadersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var methodGetOnyxHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetOnyxHeadersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var methodGetOnyxHeadersParametersTypes = new Type[] { typeof(HttpRequestMessage) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxHeaders, methodGetOnyxHeadersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxHeadersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxHeaders, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxHeaders) (Return Type : OnyxHeaderDetail) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelperMethods_GetOnyxHeaders_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxHeaders, 0);
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