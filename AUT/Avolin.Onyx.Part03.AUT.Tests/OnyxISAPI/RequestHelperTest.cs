using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.RequestHelper" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RequestHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RequestHelper" />)
        /// </summary>
        public RequestHelperTest() : base(typeof(RequestHelper))
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

        #region General Initializer : Class (RequestHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _requestHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="RequestHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _requestHelperInstanceType = typeof(RequestHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RequestHelper) Initializer

        #region Methods

        private const string MethodGetDecodedParameter = "GetDecodedParameter";
        private const string MethodGetParameters = "GetParameters";
        private const string MethodGetContextParameterFromHeader = "GetContextParameterFromHeader";
        private const string MethodGetSessionDetail = "GetSessionDetail";

        #endregion

        #endregion

        #region General Initializer : Class (RequestHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RequestHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RequestHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RequestHelper)

        #region General Initializer : Class (RequestHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RequestHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetDecodedParameter, 0)]
        [TestCase(MethodGetParameters, 0)]
        [TestCase(MethodGetContextParameterFromHeader, 0)]
        [TestCase(MethodGetSessionDetail, 0)]
        public void AUT_RequestHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (RequestHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RequestHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _requestHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetDecodedParameter) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var encodedString = this.CreateType<string>();

            // Act
            Action executeAction = () => RequestHelper.GetDecodedParameter(encodedString);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var encodedString = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = RequestHelper.GetDecodedParameter(encodedString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var encodedString = this.CreateType<string>();
            var methodGetDecodedParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDecodedParameter = { encodedString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDecodedParameter, methodGetDecodedParameterParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetDecodedParameter, methodGetDecodedParameterParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetDecodedParameter, parametersOfGetDecodedParameter, methodGetDecodedParameterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetDecodedParameter.ShouldNotBeNull();
            parametersOfGetDecodedParameter.Length.ShouldBe(1);
            methodGetDecodedParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetDecodedParameter, parametersOfGetDecodedParameter, methodGetDecodedParameterParametersTypes));
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var encodedString = this.CreateType<string>();
            var methodGetDecodedParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDecodedParameter = { encodedString };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDecodedParameter, methodGetDecodedParameterParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetDecodedParameter);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDecodedParameter.ShouldNotBeNull();
            parametersOfGetDecodedParameter.Length.ShouldBe(1);
            methodGetDecodedParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var encodedString = this.CreateType<string>();
            var methodGetDecodedParameterParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDecodedParameter = { encodedString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDecodedParameter, parametersOfGetDecodedParameter, methodGetDecodedParameterParametersTypes);

            // Assert
            parametersOfGetDecodedParameter.ShouldNotBeNull();
            parametersOfGetDecodedParameter.Length.ShouldBe(1);
            methodGetDecodedParameterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var methodGetDecodedParameterParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDecodedParameter, methodGetDecodedParameterParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetDecodedParameterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var methodGetDecodedParameterParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDecodedParameter, methodGetDecodedParameterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDecodedParameterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDecodedParameter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetDecodedParameter) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetDecodedParameter_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDecodedParameter);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDecodedParameter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RequestHelper_GetParameters_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var concatenatedParameter = this.CreateType<string>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => RequestHelper.GetParameters(concatenatedParameter, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var concatenatedParameter = this.CreateType<string>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = RequestHelper.GetParameters(concatenatedParameter, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var concatenatedParameter = this.CreateType<string>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetParametersParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetParameters = { concatenatedParameter, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, methodGetParametersParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetParameters, parametersOfGetParameters, methodGetParametersParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetParameters.ShouldNotBeNull();
            parametersOfGetParameters.Length.ShouldBe(2);
            methodGetParametersParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var concatenatedParameter = this.CreateType<string>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetParametersParametersTypes = new Type[] { typeof(string), typeof(bool) };
            object[] parametersOfGetParameters = { concatenatedParameter, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetParameters, parametersOfGetParameters, methodGetParametersParametersTypes);

            // Assert
            parametersOfGetParameters.ShouldNotBeNull();
            parametersOfGetParameters.Length.ShouldBe(2);
            methodGetParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var methodGetParametersParametersTypes = new Type[] { typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var methodGetParametersParametersTypes = new Type[] { typeof(string), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetParameters, methodGetParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetParameters) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetParameters_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetContextParameterFromHeaderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var parameterCollection = this.CreateType<Hashtable>();
            var isFromLogin = this.CreateType<bool>();

            // Act
            Action executeAction = () => RequestHelper.GetContextParameterFromHeader(parameterCollection, isFromLogin);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var parameterCollection = this.CreateType<Hashtable>();
            var isFromLogin = this.CreateType<bool>();
            var returnedValue = default(Hashtable);

            // Act
            Action executeAction = () => returnedValue = RequestHelper.GetContextParameterFromHeader(parameterCollection, isFromLogin);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var parameterCollection = this.CreateType<Hashtable>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetContextParameterFromHeaderParametersTypes = new Type[] { typeof(Hashtable), typeof(bool) };
            object[] parametersOfGetContextParameterFromHeader = { parameterCollection, isFromLogin };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);
            var result2 = this.GetResultOfMethod<Hashtable>(MethodGetContextParameterFromHeader, parametersOfGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetContextParameterFromHeader);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetContextParameterFromHeader.ShouldNotBeNull();
            parametersOfGetContextParameterFromHeader.Length.ShouldBe(2);
            methodGetContextParameterFromHeaderParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var parameterCollection = this.CreateType<Hashtable>();
            var isFromLogin = this.CreateType<bool>();
            var methodGetContextParameterFromHeaderParametersTypes = new Type[] { typeof(Hashtable), typeof(bool) };
            object[] parametersOfGetContextParameterFromHeader = { parameterCollection, isFromLogin };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Hashtable>(MethodGetContextParameterFromHeader, parametersOfGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);

            // Assert
            parametersOfGetContextParameterFromHeader.ShouldNotBeNull();
            parametersOfGetContextParameterFromHeader.Length.ShouldBe(2);
            methodGetContextParameterFromHeaderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var methodGetContextParameterFromHeaderParametersTypes = new Type[] { typeof(Hashtable), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetContextParameterFromHeaderParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var methodGetContextParameterFromHeaderParametersTypes = new Type[] { typeof(Hashtable), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetContextParameterFromHeader, methodGetContextParameterFromHeaderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetContextParameterFromHeaderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameterFromHeader, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetContextParameterFromHeader) (Return Type : Hashtable) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetContextParameterFromHeader_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetContextParameterFromHeader);
            var currentMethodInfo = this.GetMethodInfo(MethodGetContextParameterFromHeader, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionDetailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSessionDetail, methodGetSessionDetailParametersTypes);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();

            // Act
            Action executeAction = () => RequestHelper.GetSessionDetail(sessionId, appName, parameterCollection);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetSessionDetailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSessionDetail = { sessionId, appName, parameterCollection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionDetail, methodGetSessionDetailParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetSessionDetail);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSessionDetail.ShouldNotBeNull();
            parametersOfGetSessionDetail.Length.ShouldBe(3);
            methodGetSessionDetailParametersTypes.Length.ShouldBe(3);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var sessionId = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var parameterCollection = this.CreateType<Hashtable>();
            var methodGetSessionDetailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };
            object[] parametersOfGetSessionDetail = { sessionId, appName, parameterCollection };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodGetSessionDetail, parametersOfGetSessionDetail, methodGetSessionDetailParametersTypes);

            // Assert
            parametersOfGetSessionDetail.ShouldNotBeNull();
            parametersOfGetSessionDetail.Length.ShouldBe(3);
            methodGetSessionDetailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionDetail, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var methodGetSessionDetailParametersTypes = new Type[] { typeof(string), typeof(string), typeof(Hashtable) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSessionDetail, methodGetSessionDetailParametersTypes);

            // Assert
            methodGetSessionDetailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSessionDetail) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RequestHelper_GetSessionDetail_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSessionDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSessionDetail, 0);

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