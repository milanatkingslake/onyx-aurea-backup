using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.Helper.HttpHeaderHelper" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HttpHeaderHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HttpHeaderHelper" />)
        /// </summary>
        public HttpHeaderHelperTest() : base(typeof(HttpHeaderHelper))
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

        #region General Initializer : Class (HttpHeaderHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _httpHeaderHelperInstanceType;
        private HttpHeaderHelper _httpHeaderHelperInstance;
        private HttpHeaderHelper _httpHeaderHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HttpHeaderHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _httpHeaderHelperInstanceType = typeof(HttpHeaderHelper);
            _httpHeaderHelperInstanceFixture = this.Create<HttpHeaderHelper>(false);
            _httpHeaderHelperInstance = _httpHeaderHelperInstanceFixture ?? this.Create<HttpHeaderHelper>(true);
            CurrentInstance = _httpHeaderHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HttpHeaderHelper) Initializer

        #region Methods

        private const string MethodSetHeaders = "SetHeaders";
        private const string MethodAddDefaultHeaders = "AddDefaultHeaders";
        private const string MethodAddHeadersToCollection = "AddHeadersToCollection";
        private const string MethodAddOnyxHeadersToCollection = "AddOnyxHeadersToCollection";
        private const string MethodRemoveHeadersFromCollection = "RemoveHeadersFromCollection";
        private const string MethodSetAddHeaders = "SetAddHeaders";
        private const string MethodGetHeadersToBeSet = "GetHeadersToBeSet";
        private const string MethodGetHeadersToBeCopied = "GetHeadersToBeCopied";

        #endregion

        #region Fields

        private const string FieldHttpHeadersConfiguration = "HttpHeadersConfiguration";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (HttpHeaderHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HttpHeaderHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HttpHeaderHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HttpHeaderHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HttpHeaderHelper)

        #region General Initializer : Class (HttpHeaderHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetHeaders, 0)]
        [TestCase(MethodAddDefaultHeaders, 0)]
        [TestCase(MethodAddHeadersToCollection, 0)]
        [TestCase(MethodAddOnyxHeadersToCollection, 0)]
        [TestCase(MethodRemoveHeadersFromCollection, 0)]
        [TestCase(MethodSetAddHeaders, 0)]
        [TestCase(MethodGetHeadersToBeSet, 0)]
        [TestCase(MethodGetHeadersToBeCopied, 0)]
        public void AUT_HttpHeaderHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HttpHeaderHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldHttpHeadersConfiguration)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_HttpHeaderHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (HttpHeaderHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HttpHeaderHelper_Is_Instance_Present_Test()
        {
            // Assert
            _httpHeaderHelperInstanceType.ShouldNotBeNull();
            _httpHeaderHelperInstance.ShouldNotBeNull();
            _httpHeaderHelperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (HttpHeaderHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HttpHeaderHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HttpHeaderHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _httpHeaderHelperInstance.ShouldBeAssignableTo<HttpHeaderHelper>();
            _httpHeaderHelperInstanceFixture.ShouldBeAssignableTo<HttpHeaderHelper>();
            CurrentInstance.ShouldBeAssignableTo<HttpHeaderHelper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HttpHeaderHelper) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HttpHeaderHelper_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var httpHeadersConfiguration = this.CreateType<string>();
            HttpHeaderHelper instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new HttpHeaderHelper(httpHeadersConfiguration);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _httpHeaderHelperInstance.ShouldNotBeNull();
            _httpHeaderHelperInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<HttpHeaderHelper>();
        }

        #endregion

        #region General Constructor : Class (HttpHeaderHelper) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HttpHeaderHelper_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var httpHeadersConfiguration = this.CreateType<string>();
            HttpHeaderHelper instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new HttpHeaderHelper(httpHeadersConfiguration);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _httpHeaderHelperInstance.ShouldNotBeNull();
            _httpHeaderHelperInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SetHeaders) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetHeaders_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.SetHeaders(webHeaderCollectionDestination, webHeaderCollectionSource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetHeaders_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var methodSetHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(WebHeaderCollection) };
            object[] parametersOfSetHeaders = { webHeaderCollectionDestination, webHeaderCollectionSource };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetHeaders, methodSetHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfSetHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetHeaders.ShouldNotBeNull();
            parametersOfSetHeaders.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(parametersOfSetHeaders.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetHeaders_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var methodSetHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(WebHeaderCollection) };
            object[] parametersOfSetHeaders = { webHeaderCollectionDestination, webHeaderCollectionSource };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetHeaders, parametersOfSetHeaders, methodSetHeadersParametersTypes);

            // Assert
            parametersOfSetHeaders.ShouldNotBeNull();
            parametersOfSetHeaders.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(2);
            methodSetHeadersParametersTypes.Length.ShouldBe(parametersOfSetHeaders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetHeaders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetHeaders_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_HttpHeaderHelper_SetHeaders_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetHeaders);
            var methodSetHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(WebHeaderCollection) };

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
        public void AUT_HttpHeaderHelper_SetHeaders_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (AddDefaultHeaders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_Internally(Type[] types)
        {
            var methodAddDefaultHeadersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddDefaultHeaders, methodAddDefaultHeadersParametersTypes);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.AddDefaultHeaders(webHeaderCollectionDestination);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var methodAddDefaultHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection) };
            object[] parametersOfAddDefaultHeaders = { webHeaderCollectionDestination };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddDefaultHeaders, methodAddDefaultHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfAddDefaultHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddDefaultHeaders.ShouldNotBeNull();
            parametersOfAddDefaultHeaders.Length.ShouldBe(1);
            methodAddDefaultHeadersParametersTypes.Length.ShouldBe(1);
            methodAddDefaultHeadersParametersTypes.Length.ShouldBe(parametersOfAddDefaultHeaders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var methodAddDefaultHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection) };
            object[] parametersOfAddDefaultHeaders = { webHeaderCollectionDestination };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddDefaultHeaders, parametersOfAddDefaultHeaders, methodAddDefaultHeadersParametersTypes);

            // Assert
            parametersOfAddDefaultHeaders.ShouldNotBeNull();
            parametersOfAddDefaultHeaders.Length.ShouldBe(1);
            methodAddDefaultHeadersParametersTypes.Length.ShouldBe(1);
            methodAddDefaultHeadersParametersTypes.Length.ShouldBe(parametersOfAddDefaultHeaders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodAddDefaultHeaders, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var methodAddDefaultHeadersParametersTypes = new Type[] { typeof(WebHeaderCollection) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddDefaultHeaders, methodAddDefaultHeadersParametersTypes);

            // Assert
            methodAddDefaultHeadersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddDefaultHeaders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddDefaultHeaders_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddDefaultHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodAddDefaultHeaders, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_Internally(Type[] types)
        {
            var methodAddHeadersToCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddHeadersToCollection, methodAddHeadersToCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.AddHeadersToCollection(webHeaderCollectionDestination, httpHeadersToBeSet);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();
            var methodAddHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(Dictionary<string, string>) };
            object[] parametersOfAddHeadersToCollection = { webHeaderCollectionDestination, httpHeadersToBeSet };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddHeadersToCollection, methodAddHeadersToCollectionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfAddHeadersToCollection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddHeadersToCollection.ShouldNotBeNull();
            parametersOfAddHeadersToCollection.Length.ShouldBe(2);
            methodAddHeadersToCollectionParametersTypes.Length.ShouldBe(2);
            methodAddHeadersToCollectionParametersTypes.Length.ShouldBe(parametersOfAddHeadersToCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();
            var methodAddHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(Dictionary<string, string>) };
            object[] parametersOfAddHeadersToCollection = { webHeaderCollectionDestination, httpHeadersToBeSet };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddHeadersToCollection, parametersOfAddHeadersToCollection, methodAddHeadersToCollectionParametersTypes);

            // Assert
            parametersOfAddHeadersToCollection.ShouldNotBeNull();
            parametersOfAddHeadersToCollection.Length.ShouldBe(2);
            methodAddHeadersToCollectionParametersTypes.Length.ShouldBe(2);
            methodAddHeadersToCollectionParametersTypes.Length.ShouldBe(parametersOfAddHeadersToCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodAddHeadersToCollection, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var methodAddHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(Dictionary<string, string>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddHeadersToCollection, methodAddHeadersToCollectionParametersTypes);

            // Assert
            methodAddHeadersToCollectionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddHeadersToCollection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddHeadersToCollection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddHeadersToCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodAddHeadersToCollection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_Internally(Type[] types)
        {
            var methodAddOnyxHeadersToCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddOnyxHeadersToCollection, methodAddOnyxHeadersToCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.AddOnyxHeadersToCollection(webHeaderCollectionDestination);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var methodAddOnyxHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection) };
            object[] parametersOfAddOnyxHeadersToCollection = { webHeaderCollectionDestination };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAddOnyxHeadersToCollection, methodAddOnyxHeadersToCollectionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfAddOnyxHeadersToCollection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAddOnyxHeadersToCollection.ShouldNotBeNull();
            parametersOfAddOnyxHeadersToCollection.Length.ShouldBe(1);
            methodAddOnyxHeadersToCollectionParametersTypes.Length.ShouldBe(1);
            methodAddOnyxHeadersToCollectionParametersTypes.Length.ShouldBe(parametersOfAddOnyxHeadersToCollection.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var methodAddOnyxHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection) };
            object[] parametersOfAddOnyxHeadersToCollection = { webHeaderCollectionDestination };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodAddOnyxHeadersToCollection, parametersOfAddOnyxHeadersToCollection, methodAddOnyxHeadersToCollectionParametersTypes);

            // Assert
            parametersOfAddOnyxHeadersToCollection.ShouldNotBeNull();
            parametersOfAddOnyxHeadersToCollection.Length.ShouldBe(1);
            methodAddOnyxHeadersToCollectionParametersTypes.Length.ShouldBe(1);
            methodAddOnyxHeadersToCollectionParametersTypes.Length.ShouldBe(parametersOfAddOnyxHeadersToCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodAddOnyxHeadersToCollection, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var methodAddOnyxHeadersToCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddOnyxHeadersToCollection, methodAddOnyxHeadersToCollectionParametersTypes);

            // Assert
            methodAddOnyxHeadersToCollectionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddOnyxHeadersToCollection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_AddOnyxHeadersToCollection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddOnyxHeadersToCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodAddOnyxHeadersToCollection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_Internally(Type[] types)
        {
            var methodRemoveHeadersFromCollectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveHeadersFromCollection, methodRemoveHeadersFromCollectionParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.RemoveHeadersFromCollection(webHeaderCollectionDestination, httpHeaderConfiguration);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodRemoveHeadersFromCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfRemoveHeadersFromCollection = { webHeaderCollectionDestination, httpHeaderConfiguration };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHeadersFromCollection, methodRemoveHeadersFromCollectionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfRemoveHeadersFromCollection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveHeadersFromCollection.ShouldNotBeNull();
            parametersOfRemoveHeadersFromCollection.Length.ShouldBe(2);
            methodRemoveHeadersFromCollectionParametersTypes.Length.ShouldBe(2);
            methodRemoveHeadersFromCollectionParametersTypes.Length.ShouldBe(parametersOfRemoveHeadersFromCollection.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var webHeaderCollectionDestination = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodRemoveHeadersFromCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfRemoveHeadersFromCollection = { webHeaderCollectionDestination, httpHeaderConfiguration };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveHeadersFromCollection, parametersOfRemoveHeadersFromCollection, methodRemoveHeadersFromCollectionParametersTypes);

            // Assert
            parametersOfRemoveHeadersFromCollection.ShouldNotBeNull();
            parametersOfRemoveHeadersFromCollection.Length.ShouldBe(2);
            methodRemoveHeadersFromCollectionParametersTypes.Length.ShouldBe(2);
            methodRemoveHeadersFromCollectionParametersTypes.Length.ShouldBe(parametersOfRemoveHeadersFromCollection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHeadersFromCollection, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var methodRemoveHeadersFromCollectionParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveHeadersFromCollection, methodRemoveHeadersFromCollectionParametersTypes);

            // Assert
            methodRemoveHeadersFromCollectionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHeadersFromCollection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_RemoveHeadersFromCollection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHeadersFromCollection);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHeadersFromCollection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_Internally(Type[] types)
        {
            var methodSetAddHeadersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSetAddHeaders, methodSetAddHeadersParametersTypes);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.SetAddHeaders(httpHeadersToBeSet, httpHeaderConfiguration);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodSetAddHeadersParametersTypes = new Type[] { typeof(Dictionary<string, string>), typeof(List<string>) };
            object[] parametersOfSetAddHeaders = { httpHeadersToBeSet, httpHeaderConfiguration };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetAddHeaders, methodSetAddHeadersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_httpHeaderHelperInstanceFixture, parametersOfSetAddHeaders);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetAddHeaders.ShouldNotBeNull();
            parametersOfSetAddHeaders.Length.ShouldBe(2);
            methodSetAddHeadersParametersTypes.Length.ShouldBe(2);
            methodSetAddHeadersParametersTypes.Length.ShouldBe(parametersOfSetAddHeaders.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var httpHeadersToBeSet = this.CreateType<Dictionary<string, string>>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodSetAddHeadersParametersTypes = new Type[] { typeof(Dictionary<string, string>), typeof(List<string>) };
            object[] parametersOfSetAddHeaders = { httpHeadersToBeSet, httpHeaderConfiguration };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetAddHeaders, parametersOfSetAddHeaders, methodSetAddHeadersParametersTypes);

            // Assert
            parametersOfSetAddHeaders.ShouldNotBeNull();
            parametersOfSetAddHeaders.Length.ShouldBe(2);
            methodSetAddHeadersParametersTypes.Length.ShouldBe(2);
            methodSetAddHeadersParametersTypes.Length.ShouldBe(parametersOfSetAddHeaders.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetAddHeaders, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var methodSetAddHeadersParametersTypes = new Type[] { typeof(Dictionary<string, string>), typeof(List<string>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetAddHeaders, methodSetAddHeadersParametersTypes);

            // Assert
            methodSetAddHeadersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetAddHeaders) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_SetAddHeaders_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetAddHeaders);
            var currentMethodInfo = this.GetMethodInfo(MethodSetAddHeaders, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_Internally(Type[] types)
        {
            var methodGetHeadersToBeSetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeCopied = this.CreateType<List<string>>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.GetHeadersToBeSet(webHeaderCollectionSource, httpHeadersToBeCopied);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeCopied = this.CreateType<List<string>>();
            var returnedValue = default(Dictionary<string, string>);

            // Act
            Action executeAction = () => returnedValue = _httpHeaderHelperInstance.GetHeadersToBeSet(webHeaderCollectionSource, httpHeadersToBeCopied);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeCopied = this.CreateType<List<string>>();
            var methodGetHeadersToBeSetParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfGetHeadersToBeSet = { webHeaderCollectionSource, httpHeadersToBeCopied };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Dictionary<string, string>>(_httpHeaderHelperInstanceFixture, parametersOfGetHeadersToBeSet);
            var result2 = this.GetResultOfMethod<Dictionary<string, string>>(MethodGetHeadersToBeSet, parametersOfGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHeadersToBeSet.ShouldNotBeNull();
            parametersOfGetHeadersToBeSet.Length.ShouldBe(2);
            methodGetHeadersToBeSetParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeadersToBeCopied = this.CreateType<List<string>>();
            var methodGetHeadersToBeSetParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfGetHeadersToBeSet = { webHeaderCollectionSource, httpHeadersToBeCopied };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Dictionary<string, string>>(MethodGetHeadersToBeSet, parametersOfGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes);

            // Assert
            parametersOfGetHeadersToBeSet.ShouldNotBeNull();
            parametersOfGetHeadersToBeSet.Length.ShouldBe(2);
            methodGetHeadersToBeSetParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var methodGetHeadersToBeSetParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHeadersToBeSetParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var methodGetHeadersToBeSetParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeSet, methodGetHeadersToBeSetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHeadersToBeSetParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeSet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHeadersToBeSet) (Return Type : Dictionary<string, string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeSet_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeSet);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeSet, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_Internally(Type[] types)
        {
            var methodGetHeadersToBeCopiedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();

            // Act
            Action executeAction = () => _httpHeaderHelperInstance.GetHeadersToBeCopied(webHeaderCollectionSource, httpHeaderConfiguration);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var returnedValue = default(List<string>);

            // Act
            Action executeAction = () => returnedValue = _httpHeaderHelperInstance.GetHeadersToBeCopied(webHeaderCollectionSource, httpHeaderConfiguration);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodGetHeadersToBeCopiedParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfGetHeadersToBeCopied = { webHeaderCollectionSource, httpHeaderConfiguration };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<string>>(_httpHeaderHelperInstanceFixture, parametersOfGetHeadersToBeCopied);
            var result2 = this.GetResultOfMethod<List<string>>(MethodGetHeadersToBeCopied, parametersOfGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHeadersToBeCopied.ShouldNotBeNull();
            parametersOfGetHeadersToBeCopied.Length.ShouldBe(2);
            methodGetHeadersToBeCopiedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var webHeaderCollectionSource = this.CreateType<WebHeaderCollection>();
            var httpHeaderConfiguration = this.CreateType<List<string>>();
            var methodGetHeadersToBeCopiedParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            object[] parametersOfGetHeadersToBeCopied = { webHeaderCollectionSource, httpHeaderConfiguration };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<string>>(MethodGetHeadersToBeCopied, parametersOfGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes);

            // Assert
            parametersOfGetHeadersToBeCopied.ShouldNotBeNull();
            parametersOfGetHeadersToBeCopied.Length.ShouldBe(2);
            methodGetHeadersToBeCopiedParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var methodGetHeadersToBeCopiedParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHeadersToBeCopiedParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var methodGetHeadersToBeCopiedParametersTypes = new Type[] { typeof(WebHeaderCollection), typeof(List<string>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHeadersToBeCopied, methodGetHeadersToBeCopiedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHeadersToBeCopiedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeCopied, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHeadersToBeCopied) (Return Type : List<string>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HttpHeaderHelper_GetHeadersToBeCopied_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHeadersToBeCopied);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHeadersToBeCopied, 0);
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