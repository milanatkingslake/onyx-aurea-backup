using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GatewayProxy.Helper.Common" />)
    ///     and namespace <see cref="Onyx.GatewayProxy.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
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

        #region General Initializer : Class (Common) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Common" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonInstanceType = typeof(Common);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Common) Initializer

        #region Methods

        private const string MethodGetEndpointUrl = "GetEndpointUrl";
        private const string MethodStringToStream = "StringToStream";
        private const string MethodDecryptText = "DecryptText";
        private const string MethodGetParametersFromQueryString = "GetParametersFromQueryString";
        private const string MethodGetExceptionMessage = "GetExceptionMessage";
        private const string MethodGetFile = "GetFile";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Common) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Common_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetEndpointUrl, 0)]
        [TestCase(MethodStringToStream, 0)]
        [TestCase(MethodDecryptText, 0)]
        [TestCase(MethodGetParametersFromQueryString, 0)]
        [TestCase(MethodGetExceptionMessage, 0)]
        [TestCase(MethodGetFile, 0)]
        public void AUT_Common_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Common) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_Common_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Common) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Common" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Common_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetEndpointUrl) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetEndpointUrl(pathAndQuery);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetEndpointUrl(pathAndQuery);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpointUrl = { pathAndQuery };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetEndpointUrl, parametersOfGetEndpointUrl, methodGetEndpointUrlParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetEndpointUrl);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEndpointUrl.ShouldNotBeNull();
            parametersOfGetEndpointUrl.Length.ShouldBe(1);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var pathAndQuery = this.CreateType<string>();
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetEndpointUrl = { pathAndQuery };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEndpointUrl, parametersOfGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            parametersOfGetEndpointUrl.ShouldNotBeNull();
            parametersOfGetEndpointUrl.Length.ShouldBe(1);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var methodGetEndpointUrlParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEndpointUrl, methodGetEndpointUrlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEndpointUrlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEndpointUrl) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetEndpointUrl_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEndpointUrl);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEndpointUrl, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_StringToStream_Static_Method_Call_Internally(Type[] types)
        {
            var methodStringToStreamParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.StringToStream(result);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var returnedValue = default(Stream);

            // Act
            Action executeAction = () => returnedValue = Common.StringToStream(result);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStringToStream = { result };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, methodStringToStreamParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);
            var result2 = this.GetResultOfMethod<Stream>(MethodStringToStream, parametersOfStringToStream, methodStringToStreamParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfStringToStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfStringToStream.ShouldNotBeNull();
            parametersOfStringToStream.Length.ShouldBe(1);
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var result = this.CreateType<string>();
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfStringToStream = { result };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Stream>(MethodStringToStream, parametersOfStringToStream, methodStringToStreamParametersTypes);

            // Assert
            parametersOfStringToStream.ShouldNotBeNull();
            parametersOfStringToStream.Length.ShouldBe(1);
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodStringToStreamParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var methodStringToStreamParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodStringToStream, methodStringToStreamParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodStringToStreamParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (StringToStream) (Return Type : Stream) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_StringToStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodStringToStream);
            var currentMethodInfo = this.GetMethodInfo(MethodStringToStream, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_DecryptText_Static_Method_Call_Internally(Type[] types)
        {
            var methodDecryptTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.DecryptText(encryptedText);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.DecryptText(encryptedText);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, methodDecryptTextParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfDecryptText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var encryptedText = this.CreateType<string>();
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDecryptText = { encryptedText };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDecryptText, parametersOfDecryptText, methodDecryptTextParametersTypes);

            // Assert
            parametersOfDecryptText.ShouldNotBeNull();
            parametersOfDecryptText.Length.ShouldBe(1);
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDecryptTextParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var methodDecryptTextParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDecryptText, methodDecryptTextParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDecryptTextParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DecryptText) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_DecryptText_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDecryptText);
            var currentMethodInfo = this.GetMethodInfo(MethodDecryptText, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetParametersFromQueryString_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersFromQueryStringParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.GetParametersFromQueryString(isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetParametersFromQueryString(isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var isFromLogin = this.CreateType<bool>();
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfGetParametersFromQueryString = { isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetParametersFromQueryString, parametersOfGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetParametersFromQueryString);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParametersFromQueryString.ShouldNotBeNull();
            parametersOfGetParametersFromQueryString.Length.ShouldBe(1);
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var isFromLogin = this.CreateType<bool>();
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool) };
            object[] parametersOfGetParametersFromQueryString = { isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetParametersFromQueryString, parametersOfGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);

            // Assert
            parametersOfGetParametersFromQueryString.ShouldNotBeNull();
            parametersOfGetParametersFromQueryString.Length.ShouldBe(1);
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParametersFromQueryString, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParametersFromQueryString) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetParametersFromQueryString_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParametersFromQueryString);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParametersFromQueryString, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetExceptionMessage_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetExceptionMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);

            // Act
            Action executeAction = () => Common.GetExceptionMessage();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetExceptionMessage();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;
            object[] parametersOfGetExceptionMessage = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetExceptionMessage, parametersOfGetExceptionMessage, methodGetExceptionMessageParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetExceptionMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetExceptionMessage.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;
            object[] parametersOfGetExceptionMessage = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetExceptionMessage, parametersOfGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            parametersOfGetExceptionMessage.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            Type [] methodGetExceptionMessageParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExceptionMessageParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Common_GetFile_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetFileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetFile(fileName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var returnedValue = default(Stream);

            // Act
            Action executeAction = () => returnedValue = Common.GetFile(fileName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFile = { fileName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, methodGetFileParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);
            var result2 = this.GetResultOfMethod<Stream>(MethodGetFile, parametersOfGetFile, methodGetFileParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetFile.ShouldNotBeNull();
            parametersOfGetFile.Length.ShouldBe(1);
            methodGetFileParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var fileName = this.CreateType<string>();
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetFile = { fileName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Stream>(MethodGetFile, parametersOfGetFile, methodGetFileParametersTypes);

            // Assert
            parametersOfGetFile.ShouldNotBeNull();
            parametersOfGetFile.Length.ShouldBe(1);
            methodGetFileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var methodGetFileParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var methodGetFileParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFile, methodGetFileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFile) (Return Type : Stream) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetFile_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFile, 0);
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