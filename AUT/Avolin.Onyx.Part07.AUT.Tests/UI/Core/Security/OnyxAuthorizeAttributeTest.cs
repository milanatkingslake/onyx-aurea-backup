using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http.Controllers;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Security;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Core.Security
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.Security.OnyxAuthorizeAttribute" />)
    ///     and namespace <see cref="Onyx.UI.Core.Security"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxAuthorizeAttributeTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxAuthorizeAttribute" />)
        /// </summary>
        public OnyxAuthorizeAttributeTest() : base(typeof(OnyxAuthorizeAttribute))
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

        #region General Initializer : Class (OnyxAuthorizeAttribute) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxAuthorizeAttributeInstanceType;
        private OnyxAuthorizeAttribute _onyxAuthorizeAttributeInstance;
        private OnyxAuthorizeAttribute _onyxAuthorizeAttributeInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxAuthorizeAttribute" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxAuthorizeAttributeInstanceType = typeof(OnyxAuthorizeAttribute);
            _onyxAuthorizeAttributeInstanceFixture = this.Create<OnyxAuthorizeAttribute>(false);
            _onyxAuthorizeAttributeInstance = _onyxAuthorizeAttributeInstanceFixture ?? this.Create<OnyxAuthorizeAttribute>(true);
            CurrentInstance = _onyxAuthorizeAttributeInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxAuthorizeAttribute) Initializer

        #region Methods

        private const string MethodHandleUnauthorizedRequest = "HandleUnauthorizedRequest";
        private const string MethodIsAuthorized = "IsAuthorized";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxAuthorizeAttribute) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxAuthorizeAttribute" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxAuthorizeAttribute_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxAuthorizeAttribute)

        #region General Initializer : Class (OnyxAuthorizeAttribute) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxAuthorizeAttribute" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodHandleUnauthorizedRequest, 0)]
        [TestCase(MethodIsAuthorized, 0)]
        public void AUT_OnyxAuthorizeAttribute_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxAuthorizeAttribute) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxAuthorizeAttribute" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAuthorizeAttribute_Is_Instance_Present_Test()
        {
            // Assert
            _onyxAuthorizeAttributeInstanceType.ShouldNotBeNull();
            _onyxAuthorizeAttributeInstance.ShouldNotBeNull();
            _onyxAuthorizeAttributeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxAuthorizeAttribute) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxAuthorizeAttribute" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxAuthorizeAttribute_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxAuthorizeAttributeInstance.ShouldBeAssignableTo<OnyxAuthorizeAttribute>();
            _onyxAuthorizeAttributeInstanceFixture.ShouldBeAssignableTo<OnyxAuthorizeAttribute>();
            CurrentInstance.ShouldBeAssignableTo<OnyxAuthorizeAttribute>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxAuthorizeAttribute) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxAuthorizeAttribute_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxAuthorizeAttribute instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (HandleUnauthorizedRequest) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_HandleUnauthorizedRequest_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleUnauthorizedRequest);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodHandleUnauthorizedRequestParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfHandleUnauthorizedRequest = { actionContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodHandleUnauthorizedRequest, methodHandleUnauthorizedRequestParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxAuthorizeAttributeInstanceFixture, parametersOfHandleUnauthorizedRequest);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfHandleUnauthorizedRequest.ShouldNotBeNull();
            parametersOfHandleUnauthorizedRequest.Length.ShouldBe(1);
            methodHandleUnauthorizedRequestParametersTypes.Length.ShouldBe(1);
            methodHandleUnauthorizedRequestParametersTypes.Length.ShouldBe(parametersOfHandleUnauthorizedRequest.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (HandleUnauthorizedRequest) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_HandleUnauthorizedRequest_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleUnauthorizedRequest);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodHandleUnauthorizedRequestParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfHandleUnauthorizedRequest = { actionContext };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodHandleUnauthorizedRequest, parametersOfHandleUnauthorizedRequest, methodHandleUnauthorizedRequestParametersTypes);

            // Assert
            parametersOfHandleUnauthorizedRequest.ShouldNotBeNull();
            parametersOfHandleUnauthorizedRequest.Length.ShouldBe(1);
            methodHandleUnauthorizedRequestParametersTypes.Length.ShouldBe(1);
            methodHandleUnauthorizedRequestParametersTypes.Length.ShouldBe(parametersOfHandleUnauthorizedRequest.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleUnauthorizedRequest) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_HandleUnauthorizedRequest_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleUnauthorizedRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleUnauthorizedRequest, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HandleUnauthorizedRequest) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_HandleUnauthorizedRequest_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleUnauthorizedRequest);
            var methodHandleUnauthorizedRequestParametersTypes = new Type[] { typeof(HttpActionContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHandleUnauthorizedRequest, methodHandleUnauthorizedRequestParametersTypes);

            // Assert
            methodHandleUnauthorizedRequestParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HandleUnauthorizedRequest) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_HandleUnauthorizedRequest_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHandleUnauthorizedRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodHandleUnauthorizedRequest, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Internally(Type[] types)
        {
            var methodIsAuthorizedParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsAuthorized, methodIsAuthorizedParametersTypes);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfIsAuthorized = { actionContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsAuthorized, methodIsAuthorizedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxAuthorizeAttributeInstanceFixture, parametersOfIsAuthorized);
            var result2 = this.GetResultOfMethod<bool>(MethodIsAuthorized, parametersOfIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsAuthorized.ShouldNotBeNull();
            parametersOfIsAuthorized.Length.ShouldBe(1);
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfIsAuthorized = { actionContext };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsAuthorized, methodIsAuthorizedParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_onyxAuthorizeAttributeInstanceFixture, out exception1, parametersOfIsAuthorized);
            var result2 = this.GetResultOfMethod<bool>(MethodIsAuthorized, parametersOfIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsAuthorized.ShouldNotBeNull();
            parametersOfIsAuthorized.Length.ShouldBe(1);
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfIsAuthorized = { actionContext };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodIsAuthorized, methodIsAuthorizedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxAuthorizeAttributeInstanceFixture, parametersOfIsAuthorized);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfIsAuthorized.ShouldNotBeNull();
            parametersOfIsAuthorized.Length.ShouldBe(1);
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var actionContext = this.CreateType<HttpActionContext>();
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };
            object[] parametersOfIsAuthorized = { actionContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsAuthorized, parametersOfIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            parametersOfIsAuthorized.ShouldNotBeNull();
            parametersOfIsAuthorized.Length.ShouldBe(1);
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodIsAuthorizedParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var methodIsAuthorizedParametersTypes = new Type[] { typeof(HttpActionContext) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsAuthorized, methodIsAuthorizedParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsAuthorizedParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var currentMethodInfo = this.GetMethodInfo(MethodIsAuthorized, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (IsAuthorized) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxAuthorizeAttribute_IsAuthorized_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsAuthorized);
            var currentMethodInfo = this.GetMethodInfo(MethodIsAuthorized, 0);
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