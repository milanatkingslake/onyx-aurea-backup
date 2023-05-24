using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSocial;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxSocial
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSocial.TwitterApi" />)
    ///     and namespace <see cref="OnyxSocial"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TwitterApiTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TwitterApi" />)
        /// </summary>
        public TwitterApiTest() : base(typeof(TwitterApi))
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

        #region General Initializer : Class (TwitterApi) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _twitterApiInstanceType;
        private TwitterApi _twitterApiInstance;
        private TwitterApi _twitterApiInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TwitterApi" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _twitterApiInstanceType = typeof(TwitterApi);
            _twitterApiInstanceFixture = this.Create<TwitterApi>(false);
            _twitterApiInstance = _twitterApiInstanceFixture ?? this.Create<TwitterApi>(true);
            CurrentInstance = _twitterApiInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TwitterApi) Initializer

        #region Methods

        private const string MethodGetBearerToken = "GetBearerToken";
        private const string MethodGetBearerTokenJson = "GetBearerTokenJson";
        private const string MethodGetUserTimelineJson = "GetUserTimelineJson";
        private const string MethodGetSearchJson = "GetSearchJson";
        private const string MethodCreateRequest = "CreateRequest";
        private const string MethodGetBasicAuthToken = "GetBasicAuthToken";
        private const string MethodWriteRequest = "WriteRequest";
        private const string MethodReadResponse = "ReadResponse";
        private const string MethodBase64Encode = "Base64Encode";
        private const string MethodBase64Decode = "Base64Decode";

        #endregion

        #region Fields

        private const string FieldApiBaseUrl = "ApiBaseUrl";

        #endregion

        #endregion

        #region General Initializer : Class (TwitterApi) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TwitterApi_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TwitterApi) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TwitterApi_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TwitterApi)

        #region General Initializer : Class (TwitterApi) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetBearerToken, 0)]
        [TestCase(MethodGetBearerToken, 1)]
        [TestCase(MethodGetBearerTokenJson, 0)]
        [TestCase(MethodGetUserTimelineJson, 0)]
        [TestCase(MethodGetSearchJson, 0)]
        [TestCase(MethodCreateRequest, 0)]
        [TestCase(MethodGetBasicAuthToken, 0)]
        [TestCase(MethodWriteRequest, 0)]
        [TestCase(MethodReadResponse, 0)]
        [TestCase(MethodBase64Encode, 0)]
        [TestCase(MethodBase64Decode, 0)]
        public void AUT_TwitterApi_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TwitterApi) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldApiBaseUrl)]
        [Category("AUT Fields")]
        public void AUT_TwitterApi_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TwitterApi) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TwitterApi_Is_Instance_Present_Test()
        {
            // Assert
            _twitterApiInstanceType.ShouldNotBeNull();
            _twitterApiInstance.ShouldNotBeNull();
            _twitterApiInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TwitterApi) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TwitterApi" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TwitterApi_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _twitterApiInstance.ShouldBeAssignableTo<TwitterApi>();
            _twitterApiInstanceFixture.ShouldBeAssignableTo<TwitterApi>();
            CurrentInstance.ShouldBeAssignableTo<TwitterApi>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TwitterApi) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TwitterApi_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TwitterApi instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetBearerToken) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);

            // Act
            Action executeAction = () => _twitterApiInstance.GetBearerToken();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _twitterApiInstance.GetBearerToken();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            Type [] methodGetBearerTokenParametersTypes = null;
            object[] parametersOfGetBearerToken = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerToken, methodGetBearerTokenParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_twitterApiInstanceFixture, parametersOfGetBearerToken);
            var result2 = this.GetResultOfMethod<string>(MethodGetBearerToken, parametersOfGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBearerToken.ShouldBeNull();
            methodGetBearerTokenParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            Type [] methodGetBearerTokenParametersTypes = null;
            object[] parametersOfGetBearerToken = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBearerToken, parametersOfGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            parametersOfGetBearerToken.ShouldBeNull();
            methodGetBearerTokenParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            Type [] methodGetBearerTokenParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBearerTokenParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            Type [] methodGetBearerTokenParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBearerTokenParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerToken, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_GetBearerToken_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetBearerTokenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBearerToken, methodGetBearerTokenParametersTypes);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();

            // Act
            Action executeAction = () => _twitterApiInstance.GetBearerToken(consumerKey, consumerSecret);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _twitterApiInstance.GetBearerToken(consumerKey, consumerSecret);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBearerTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBearerToken = { consumerKey, consumerSecret };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerToken, methodGetBearerTokenParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_twitterApiInstanceFixture, parametersOfGetBearerToken);
            var result2 = this.GetResultOfMethod<string>(MethodGetBearerToken, parametersOfGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBearerToken.ShouldNotBeNull();
            parametersOfGetBearerToken.Length.ShouldBe(2);
            methodGetBearerTokenParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBearerTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBearerToken = { consumerKey, consumerSecret };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBearerToken, parametersOfGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            parametersOfGetBearerToken.ShouldNotBeNull();
            parametersOfGetBearerToken.Length.ShouldBe(2);
            methodGetBearerTokenParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var methodGetBearerTokenParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBearerTokenParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var methodGetBearerTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBearerToken, methodGetBearerTokenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBearerTokenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerToken, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerToken) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerToken_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerToken);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerToken, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetBearerTokenJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBearerTokenJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBearerTokenJson = { consumerKey, consumerSecret };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetBearerTokenJson, parametersOfGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfGetBearerTokenJson);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBearerTokenJson.ShouldNotBeNull();
            parametersOfGetBearerTokenJson.Length.ShouldBe(2);
            methodGetBearerTokenJsonParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBearerTokenJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBearerTokenJson = { consumerKey, consumerSecret };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBearerTokenJson, parametersOfGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);

            // Assert
            parametersOfGetBearerTokenJson.ShouldNotBeNull();
            parametersOfGetBearerTokenJson.Length.ShouldBe(2);
            methodGetBearerTokenJsonParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var methodGetBearerTokenJsonParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBearerTokenJsonParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var methodGetBearerTokenJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBearerTokenJson, methodGetBearerTokenJsonParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBearerTokenJsonParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerTokenJson, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBearerTokenJson) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBearerTokenJson_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBearerTokenJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBearerTokenJson, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_GetUserTimelineJson_Method_Call_Internally(Type[] types)
        {
            var methodGetUserTimelineJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var bearerToken = this.CreateType<string>();
            var screenName = this.CreateType<string>();
            var count = this.CreateType<int>();
            var excludeReplies = this.CreateType<bool>();
            var includeRTs = this.CreateType<bool>();

            // Act
            Action executeAction = () => _twitterApiInstance.GetUserTimelineJson(bearerToken, screenName, count, excludeReplies, includeRTs);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var bearerToken = this.CreateType<string>();
            var screenName = this.CreateType<string>();
            var count = this.CreateType<int>();
            var excludeReplies = this.CreateType<bool>();
            var includeRTs = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _twitterApiInstance.GetUserTimelineJson(bearerToken, screenName, count, excludeReplies, includeRTs);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var bearerToken = this.CreateType<string>();
            var screenName = this.CreateType<string>();
            var count = this.CreateType<int>();
            var excludeReplies = this.CreateType<bool>();
            var includeRTs = this.CreateType<bool>();
            var methodGetUserTimelineJsonParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(bool), typeof(bool) };
            object[] parametersOfGetUserTimelineJson = { bearerToken, screenName, count, excludeReplies, includeRTs };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_twitterApiInstanceFixture, parametersOfGetUserTimelineJson);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserTimelineJson, parametersOfGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserTimelineJson.ShouldNotBeNull();
            parametersOfGetUserTimelineJson.Length.ShouldBe(5);
            methodGetUserTimelineJsonParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var bearerToken = this.CreateType<string>();
            var screenName = this.CreateType<string>();
            var count = this.CreateType<int>();
            var excludeReplies = this.CreateType<bool>();
            var includeRTs = this.CreateType<bool>();
            var methodGetUserTimelineJsonParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(bool), typeof(bool) };
            object[] parametersOfGetUserTimelineJson = { bearerToken, screenName, count, excludeReplies, includeRTs };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserTimelineJson, parametersOfGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes);

            // Assert
            parametersOfGetUserTimelineJson.ShouldNotBeNull();
            parametersOfGetUserTimelineJson.Length.ShouldBe(5);
            methodGetUserTimelineJsonParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var methodGetUserTimelineJsonParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserTimelineJsonParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var methodGetUserTimelineJsonParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(bool), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserTimelineJson, methodGetUserTimelineJsonParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserTimelineJsonParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTimelineJson, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTimelineJson) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetUserTimelineJson_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTimelineJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTimelineJson, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_GetSearchJson_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchJsonParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchJson, methodGetSearchJsonParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var bearerToken = this.CreateType<string>();
            var parameters = this.CreateType<string>();

            // Act
            Action executeAction = () => _twitterApiInstance.GetSearchJson(bearerToken, parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var bearerToken = this.CreateType<string>();
            var parameters = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _twitterApiInstance.GetSearchJson(bearerToken, parameters);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var bearerToken = this.CreateType<string>();
            var parameters = this.CreateType<string>();
            var methodGetSearchJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSearchJson = { bearerToken, parameters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchJson, methodGetSearchJsonParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_twitterApiInstanceFixture, parametersOfGetSearchJson);
            var result2 = this.GetResultOfMethod<string>(MethodGetSearchJson, parametersOfGetSearchJson, methodGetSearchJsonParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchJson.ShouldNotBeNull();
            parametersOfGetSearchJson.Length.ShouldBe(2);
            methodGetSearchJsonParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var bearerToken = this.CreateType<string>();
            var parameters = this.CreateType<string>();
            var methodGetSearchJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetSearchJson = { bearerToken, parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSearchJson, parametersOfGetSearchJson, methodGetSearchJsonParametersTypes);

            // Assert
            parametersOfGetSearchJson.ShouldNotBeNull();
            parametersOfGetSearchJson.Length.ShouldBe(2);
            methodGetSearchJsonParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var methodGetSearchJsonParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchJson, methodGetSearchJsonParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchJsonParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var methodGetSearchJsonParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchJson, methodGetSearchJsonParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchJsonParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchJson, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchJson) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetSearchJson_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchJson);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchJson, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_CreateRequest_Static_Method_Call_Internally(Type[] types)
        {
            var methodCreateRequestParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateRequest, methodCreateRequestParametersTypes);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var url = this.CreateType<string>();
            var methodCreateRequestParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateRequest = { url };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequest, methodCreateRequestParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateRequest, methodCreateRequestParametersTypes);
            var result2 = this.GetResultOfMethod<WebRequest>(MethodCreateRequest, parametersOfCreateRequest, methodCreateRequestParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCreateRequest.ShouldNotBeNull();
            parametersOfCreateRequest.Length.ShouldBe(1);
            methodCreateRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<WebRequest>(MethodCreateRequest, parametersOfCreateRequest, methodCreateRequestParametersTypes));
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var url = this.CreateType<string>();
            var methodCreateRequestParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateRequest = { url };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequest, methodCreateRequestParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfCreateRequest);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateRequest.ShouldNotBeNull();
            parametersOfCreateRequest.Length.ShouldBe(1);
            methodCreateRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var url = this.CreateType<string>();
            var methodCreateRequestParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCreateRequest = { url };

            // Act
            Action currentAction = () => this.GetResultOfMethod<WebRequest>(MethodCreateRequest, parametersOfCreateRequest, methodCreateRequestParametersTypes);

            // Assert
            parametersOfCreateRequest.ShouldNotBeNull();
            parametersOfCreateRequest.Length.ShouldBe(1);
            methodCreateRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var methodCreateRequestParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateRequest, methodCreateRequestParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodCreateRequestParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var methodCreateRequestParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateRequest, methodCreateRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateRequestParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CreateRequest) (Return Type : WebRequest) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_CreateRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateRequest, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetBasicAuthTokenParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBasicAuthTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBasicAuthToken = { consumerKey, consumerSecret };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetBasicAuthToken, parametersOfGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetBasicAuthToken.ShouldNotBeNull();
            parametersOfGetBasicAuthToken.Length.ShouldBe(2);
            methodGetBasicAuthTokenParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetBasicAuthToken, parametersOfGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes));
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBasicAuthTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBasicAuthToken = { consumerKey, consumerSecret };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfGetBasicAuthToken);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetBasicAuthToken.ShouldNotBeNull();
            parametersOfGetBasicAuthToken.Length.ShouldBe(2);
            methodGetBasicAuthTokenParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var consumerKey = this.CreateType<string>();
            var consumerSecret = this.CreateType<string>();
            var methodGetBasicAuthTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetBasicAuthToken = { consumerKey, consumerSecret };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBasicAuthToken, parametersOfGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);

            // Assert
            parametersOfGetBasicAuthToken.ShouldNotBeNull();
            parametersOfGetBasicAuthToken.Length.ShouldBe(2);
            methodGetBasicAuthTokenParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var methodGetBasicAuthTokenParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetBasicAuthTokenParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var methodGetBasicAuthTokenParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBasicAuthToken, methodGetBasicAuthTokenParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBasicAuthTokenParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBasicAuthToken, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetBasicAuthToken) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_GetBasicAuthToken_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBasicAuthToken);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBasicAuthToken, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_WriteRequest_Static_Method_Call_Internally(Type[] types)
        {
            var methodWriteRequestParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteRequest, methodWriteRequestParametersTypes);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_WriteRequest_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteRequest);
            var webrequest = this.CreateType<WebRequest>();
            var postData = this.CreateType<string>();
            var methodWriteRequestParametersTypes = new Type[] { typeof(WebRequest), typeof(string) };
            object[] parametersOfWriteRequest = { webrequest, postData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteRequest, methodWriteRequestParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfWriteRequest);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWriteRequest.ShouldNotBeNull();
            parametersOfWriteRequest.Length.ShouldBe(2);
            methodWriteRequestParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_WriteRequest_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteRequest);
            var webrequest = this.CreateType<WebRequest>();
            var postData = this.CreateType<string>();
            var methodWriteRequestParametersTypes = new Type[] { typeof(WebRequest), typeof(string) };
            object[] parametersOfWriteRequest = { webrequest, postData };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWriteRequest, parametersOfWriteRequest, methodWriteRequestParametersTypes);

            // Assert
            parametersOfWriteRequest.ShouldNotBeNull();
            parametersOfWriteRequest.Length.ShouldBe(2);
            methodWriteRequestParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_WriteRequest_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteRequest, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_WriteRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteRequest);
            var methodWriteRequestParametersTypes = new Type[] { typeof(WebRequest), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteRequest, methodWriteRequestParametersTypes);

            // Assert
            methodWriteRequestParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteRequest) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_WriteRequest_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteRequest, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_ReadResponse_Static_Method_Call_Internally(Type[] types)
        {
            var methodReadResponseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReadResponse, methodReadResponseParametersTypes);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var webrequest = this.CreateType<WebRequest>();
            var methodReadResponseParametersTypes = new Type[] { typeof(WebRequest) };
            object[] parametersOfReadResponse = { webrequest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodReadResponse, methodReadResponseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodReadResponse, methodReadResponseParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodReadResponse, parametersOfReadResponse, methodReadResponseParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfReadResponse);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfReadResponse.ShouldNotBeNull();
            parametersOfReadResponse.Length.ShouldBe(1);
            methodReadResponseParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var webrequest = this.CreateType<WebRequest>();
            var methodReadResponseParametersTypes = new Type[] { typeof(WebRequest) };
            object[] parametersOfReadResponse = { webrequest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodReadResponse, parametersOfReadResponse, methodReadResponseParametersTypes);

            // Assert
            parametersOfReadResponse.ShouldNotBeNull();
            parametersOfReadResponse.Length.ShouldBe(1);
            methodReadResponseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var methodReadResponseParametersTypes = new Type[] { typeof(WebRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodReadResponse, methodReadResponseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodReadResponseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var methodReadResponseParametersTypes = new Type[] { typeof(WebRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReadResponse, methodReadResponseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodReadResponseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodReadResponse, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ReadResponse) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_ReadResponse_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReadResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodReadResponse, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_Base64Encode_Static_Method_Call_Internally(Type[] types)
        {
            var methodBase64EncodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBase64Encode, methodBase64EncodeParametersTypes);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var s = this.CreateType<string>();
            var methodBase64EncodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64Encode = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Encode, methodBase64EncodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodBase64Encode, methodBase64EncodeParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodBase64Encode, parametersOfBase64Encode, methodBase64EncodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfBase64Encode.ShouldNotBeNull();
            parametersOfBase64Encode.Length.ShouldBe(1);
            methodBase64EncodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodBase64Encode, parametersOfBase64Encode, methodBase64EncodeParametersTypes));
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var s = this.CreateType<string>();
            var methodBase64EncodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64Encode = { s };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Encode, methodBase64EncodeParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfBase64Encode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBase64Encode.ShouldNotBeNull();
            parametersOfBase64Encode.Length.ShouldBe(1);
            methodBase64EncodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var s = this.CreateType<string>();
            var methodBase64EncodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64Encode = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBase64Encode, parametersOfBase64Encode, methodBase64EncodeParametersTypes);

            // Assert
            parametersOfBase64Encode.ShouldNotBeNull();
            parametersOfBase64Encode.Length.ShouldBe(1);
            methodBase64EncodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var methodBase64EncodeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBase64Encode, methodBase64EncodeParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodBase64EncodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var methodBase64EncodeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBase64Encode, methodBase64EncodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBase64EncodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Encode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Base64Encode) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Encode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Encode);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Encode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TwitterApi_Base64Decode_Static_Method_Call_Internally(Type[] types)
        {
            var methodBase64DecodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBase64Decode, methodBase64DecodeParametersTypes);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var s = this.CreateType<string>();
            var methodBase64DecodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64Decode = { s };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Decode, methodBase64DecodeParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodBase64Decode, methodBase64DecodeParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodBase64Decode, parametersOfBase64Decode, methodBase64DecodeParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_twitterApiInstanceFixture, parametersOfBase64Decode);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBase64Decode.ShouldNotBeNull();
            parametersOfBase64Decode.Length.ShouldBe(1);
            methodBase64DecodeParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var s = this.CreateType<string>();
            var methodBase64DecodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfBase64Decode = { s };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBase64Decode, parametersOfBase64Decode, methodBase64DecodeParametersTypes);

            // Assert
            parametersOfBase64Decode.ShouldNotBeNull();
            parametersOfBase64Decode.Length.ShouldBe(1);
            methodBase64DecodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var methodBase64DecodeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBase64Decode, methodBase64DecodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBase64DecodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var methodBase64DecodeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBase64Decode, methodBase64DecodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBase64DecodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Decode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Base64Decode) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TwitterApi_Base64Decode_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBase64Decode);
            var currentMethodInfo = this.GetMethodInfo(MethodBase64Decode, 0);
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