using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Common" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Common.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxISAPI.Common" />)
        /// </summary>
        public CommonTest() : base(typeof(Common))
        { }

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

        private const string MethodGenerateResponse = "GenerateResponse";
        private const string MethodGetRequestParameters = "GetRequestParameters";
        private const string MethodGetRequestParametersPlain = "GetRequestParametersPlain";
        private const string MethodGetRequestParametersStream = "GetRequestParametersStream";
        private const string MethodGetRequestParametersStreamForSearch = "GetRequestParametersStreamForSearch";
        private const string MethodGetParametersFromQueryString = "GetParametersFromQueryString";
        private const string MethodGetUtf16String = "GetUtf16String";
        private const string MethodProcessError = "ProcessError";
        private const string MethodGetRootInnerException = "GetRootInnerException";
        private const string MethodGetExceptionMessage = "GetExceptionMessage";

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

        #region Explore Class for Coverage Gain : Class (Common)

        #region General Initializer : Class (Common) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Common" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGenerateResponse, 0)]
        [TestCase(MethodGetRequestParameters, 0)]
        [TestCase(MethodGetRequestParametersPlain, 0)]
        [TestCase(MethodGetRequestParametersStream, 0)]
        [TestCase(MethodGetRequestParametersStreamForSearch, 0)]
        [TestCase(MethodGetParametersFromQueryString, 0)]
        [TestCase(MethodGetUtf16String, 0)]
        [TestCase(MethodProcessError, 0)]
        [TestCase(MethodProcessError, 1)]
        [TestCase(MethodGetRootInnerException, 0)]
        [TestCase(MethodGetExceptionMessage, 0)]
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

        #endregion

        #region Method Call : (GenerateResponse) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GenerateResponse_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResponse);
            Type [] methodGenerateResponseParametersTypes = null;
            object[] parametersOfGenerateResponse = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateResponse, methodGenerateResponseParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGenerateResponse);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGenerateResponse.ShouldBeNull();
            methodGenerateResponseParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResponse) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GenerateResponse_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResponse);
            Type [] methodGenerateResponseParametersTypes = null;
            object[] parametersOfGenerateResponse = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGenerateResponse, parametersOfGenerateResponse, methodGenerateResponseParametersTypes);

            // Assert
            parametersOfGenerateResponse.ShouldBeNull();
            methodGenerateResponseParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResponse) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GenerateResponse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResponse);
            Type [] methodGenerateResponseParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenerateResponse, methodGenerateResponseParametersTypes);

            // Assert
            methodGenerateResponseParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenerateResponse) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GenerateResponse_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenerateResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodGenerateResponse, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.GetRequestParameters(op, message, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetRequestParameters(op, message, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParameters = { op, message, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParameters, methodGetRequestParametersParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequestParameters, methodGetRequestParametersParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetRequestParameters, parametersOfGetRequestParameters, methodGetRequestParametersParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequestParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequestParameters.ShouldNotBeNull();
            parametersOfGetRequestParameters.Length.ShouldBe(3);
            methodGetRequestParametersParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParameters = { op, message, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetRequestParameters, parametersOfGetRequestParameters, methodGetRequestParametersParametersTypes);

            // Assert
            parametersOfGetRequestParameters.ShouldNotBeNull();
            parametersOfGetRequestParameters.Length.ShouldBe(3);
            methodGetRequestParametersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var methodGetRequestParametersParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequestParameters, methodGetRequestParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequestParametersParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var methodGetRequestParametersParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestParameters, methodGetRequestParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequestParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParameters) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParameters, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.GetRequestParametersPlain(op, message, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetRequestParametersPlain(op, message, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersPlainParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersPlain = { op, message, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersPlain, parametersOfGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequestParametersPlain);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequestParametersPlain.ShouldNotBeNull();
            parametersOfGetRequestParametersPlain.Length.ShouldBe(3);
            methodGetRequestParametersPlainParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersPlainParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersPlain = { op, message, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersPlain, parametersOfGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes);

            // Assert
            parametersOfGetRequestParametersPlain.ShouldNotBeNull();
            parametersOfGetRequestParametersPlain.Length.ShouldBe(3);
            methodGetRequestParametersPlainParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var methodGetRequestParametersPlainParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequestParametersPlainParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var methodGetRequestParametersPlainParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersPlain, methodGetRequestParametersPlainParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequestParametersPlainParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersPlain, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersPlain) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersPlain_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersPlain);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersPlain, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.GetRequestParametersStream(op, message, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetRequestParametersStream(op, message, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersStreamParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersStream = { op, message, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersStream, parametersOfGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequestParametersStream);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequestParametersStream.ShouldNotBeNull();
            parametersOfGetRequestParametersStream.Length.ShouldBe(3);
            methodGetRequestParametersStreamParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersStreamParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersStream = { op, message, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersStream, parametersOfGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes);

            // Assert
            parametersOfGetRequestParametersStream.ShouldNotBeNull();
            parametersOfGetRequestParametersStream.Length.ShouldBe(3);
            methodGetRequestParametersStreamParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var methodGetRequestParametersStreamParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequestParametersStreamParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var methodGetRequestParametersStreamParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStream, methodGetRequestParametersStreamParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequestParametersStreamParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStream, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersStream) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStream_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStream);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStream, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => Common.GetRequestParametersStreamForSearch(op, message, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetRequestParametersStreamForSearch(op, message, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersStreamForSearchParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersStreamForSearch = { op, message, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersStreamForSearch, parametersOfGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRequestParametersStreamForSearch);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRequestParametersStreamForSearch.ShouldNotBeNull();
            parametersOfGetRequestParametersStreamForSearch.Length.ShouldBe(3);
            methodGetRequestParametersStreamForSearchParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var op = this.CreateType<OperationProperties>();
            var message = this.CreateType<Stream>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetRequestParametersStreamForSearchParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            object[] parametersOfGetRequestParametersStreamForSearch = { op, message, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetRequestParametersStreamForSearch, parametersOfGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes);

            // Assert
            parametersOfGetRequestParametersStreamForSearch.ShouldNotBeNull();
            parametersOfGetRequestParametersStreamForSearch.Length.ShouldBe(3);
            methodGetRequestParametersStreamForSearchParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var methodGetRequestParametersStreamForSearchParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRequestParametersStreamForSearchParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var methodGetRequestParametersStreamForSearchParametersTypes = new Type[] { typeof(OperationProperties), typeof(Stream), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRequestParametersStreamForSearch, methodGetRequestParametersStreamForSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRequestParametersStreamForSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStreamForSearch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRequestParametersStreamForSearch) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRequestParametersStreamForSearch_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRequestParametersStreamForSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRequestParametersStreamForSearch, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
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
            var encodedParameter = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.GetParametersFromQueryString(isFromLogin, encodedParameter);

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
            var encodedParameter = this.CreateType<string>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = Common.GetParametersFromQueryString(isFromLogin, encodedParameter);
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
            var encodedParameter = this.CreateType<string>();
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool), typeof(string) };
            object[] parametersOfGetParametersFromQueryString = { isFromLogin, encodedParameter };
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
            parametersOfGetParametersFromQueryString.Length.ShouldBe(2);
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(2);
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
            var encodedParameter = this.CreateType<string>();
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool), typeof(string) };
            object[] parametersOfGetParametersFromQueryString = { isFromLogin, encodedParameter };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetParametersFromQueryString, parametersOfGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);

            // Assert
            parametersOfGetParametersFromQueryString.ShouldNotBeNull();
            parametersOfGetParametersFromQueryString.Length.ShouldBe(2);
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(2);
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
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParametersFromQueryString, methodGetParametersFromQueryStringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersFromQueryStringParametersTypes.Length.ShouldBe(2);
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
            var methodGetParametersFromQueryStringParametersTypes = new Type[] { typeof(bool), typeof(string) };
            const int parametersCount = 2;

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
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var stream = this.CreateType<Stream>();

            // Act
            Action executeAction = () => Common.GetUtf16String(stream);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var stream = this.CreateType<Stream>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetUtf16String(stream);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var stream = this.CreateType<Stream>();
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfGetUtf16String = { stream };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, methodGetUtf16StringParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetUtf16String, parametersOfGetUtf16String, methodGetUtf16StringParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetUtf16String);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUtf16String.ShouldNotBeNull();
            parametersOfGetUtf16String.Length.ShouldBe(1);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var stream = this.CreateType<Stream>();
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfGetUtf16String = { stream };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUtf16String, parametersOfGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            parametersOfGetUtf16String.ShouldNotBeNull();
            parametersOfGetUtf16String.Length.ShouldBe(1);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUtf16StringParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var methodGetUtf16StringParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUtf16String, methodGetUtf16StringParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUtf16StringParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUtf16String) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetUtf16String_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUtf16String);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUtf16String, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var op = this.CreateType<OperationProperties>();

            // Act
            Action executeAction = () => Common.ProcessError(e, op);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var op = this.CreateType<OperationProperties>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.ProcessError(e, op);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var op = this.CreateType<OperationProperties>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(OperationProperties) };
            object[] parametersOfProcessError = { e, op };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, methodProcessErrorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(2);
            methodProcessErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes));
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var op = this.CreateType<OperationProperties>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(OperationProperties) };
            object[] parametersOfProcessError = { e, op };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, methodProcessErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfProcessError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(2);
            methodProcessErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var op = this.CreateType<OperationProperties>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(OperationProperties) };
            object[] parametersOfProcessError = { e, op };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes);

            // Assert
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(2);
            methodProcessErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(OperationProperties) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodProcessErrorParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(OperationProperties) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodProcessErrorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var parameterCollection = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();

            // Act
            Action executeAction = () => Common.ProcessError(e, parameterCollection, key);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_DirectCall_Overloading_Of_1_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var parameterCollection = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.ProcessError(e, parameterCollection, key);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var parameterCollection = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(Hashtable), typeof(string) };
            object[] parametersOfProcessError = { e, parameterCollection, key };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, methodProcessErrorParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(3);
            methodProcessErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes));
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var parameterCollection = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(Hashtable), typeof(string) };
            object[] parametersOfProcessError = { e, parameterCollection, key };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, methodProcessErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfProcessError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(3);
            methodProcessErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var e = this.CreateType<Exception>();
            var parameterCollection = this.CreateType<Hashtable>();
            var key = this.CreateType<string>();
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(Hashtable), typeof(string) };
            object[] parametersOfProcessError = { e, parameterCollection, key };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodProcessError, parametersOfProcessError, methodProcessErrorParametersTypes);

            // Assert
            parametersOfProcessError.ShouldNotBeNull();
            parametersOfProcessError.Length.ShouldBe(3);
            methodProcessErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(Hashtable), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodProcessErrorParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var methodProcessErrorParametersTypes = new Type[] { typeof(Exception), typeof(Hashtable), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcessError, methodProcessErrorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodProcessErrorParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ProcessError) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_ProcessError_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcessError);
            var currentMethodInfo = this.GetMethodInfo(MethodProcessError, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var ex = this.CreateType<Exception>();

            // Act
            Action executeAction = () => Common.GetRootInnerException(ex);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var ex = this.CreateType<Exception>();
            var returnedValue = default(Exception);

            // Act
            Action executeAction = () => returnedValue = Common.GetRootInnerException(ex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var ex = this.CreateType<Exception>();
            var methodGetRootInnerExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfGetRootInnerException = { ex };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootInnerException, methodGetRootInnerExceptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetRootInnerException, methodGetRootInnerExceptionParametersTypes);
            var result2 = this.GetResultOfMethod<Exception>(MethodGetRootInnerException, parametersOfGetRootInnerException, methodGetRootInnerExceptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetRootInnerException.ShouldNotBeNull();
            parametersOfGetRootInnerException.Length.ShouldBe(1);
            methodGetRootInnerExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<Exception>(MethodGetRootInnerException, parametersOfGetRootInnerException, methodGetRootInnerExceptionParametersTypes));
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var ex = this.CreateType<Exception>();
            var methodGetRootInnerExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfGetRootInnerException = { ex };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootInnerException, methodGetRootInnerExceptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetRootInnerException);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetRootInnerException.ShouldNotBeNull();
            parametersOfGetRootInnerException.Length.ShouldBe(1);
            methodGetRootInnerExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var ex = this.CreateType<Exception>();
            var methodGetRootInnerExceptionParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfGetRootInnerException = { ex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Exception>(MethodGetRootInnerException, parametersOfGetRootInnerException, methodGetRootInnerExceptionParametersTypes);

            // Assert
            parametersOfGetRootInnerException.ShouldNotBeNull();
            parametersOfGetRootInnerException.Length.ShouldBe(1);
            methodGetRootInnerExceptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var methodGetRootInnerExceptionParametersTypes = new Type[] { typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRootInnerException, methodGetRootInnerExceptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetRootInnerExceptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var methodGetRootInnerExceptionParametersTypes = new Type[] { typeof(Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRootInnerException, methodGetRootInnerExceptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRootInnerExceptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootInnerException, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetRootInnerException) (Return Type : Exception) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetRootInnerException_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootInnerException);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootInnerException, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var handle = this.CreateType<string>();
            var caption = this.CreateType<string>();
            var exception = this.CreateType<Exception>();

            // Act
            Action executeAction = () => Common.GetExceptionMessage(handle, caption, exception);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var handle = this.CreateType<string>();
            var caption = this.CreateType<string>();
            var exception = this.CreateType<Exception>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = Common.GetExceptionMessage(handle, caption, exception);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
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
            var handle = this.CreateType<string>();
            var caption = this.CreateType<string>();
            var exception = this.CreateType<Exception>();
            var methodGetExceptionMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Exception) };
            object[] parametersOfGetExceptionMessage = { handle, caption, exception };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetExceptionMessage, parametersOfGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            parametersOfGetExceptionMessage.ShouldNotBeNull();
            parametersOfGetExceptionMessage.Length.ShouldBe(3);
            methodGetExceptionMessageParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var methodGetExceptionMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetExceptionMessageParametersTypes.Length.ShouldBe(3);
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
            var methodGetExceptionMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Exception) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExceptionMessage, methodGetExceptionMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExceptionMessageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetExceptionMessage) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Common_GetExceptionMessage_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExceptionMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExceptionMessage, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}