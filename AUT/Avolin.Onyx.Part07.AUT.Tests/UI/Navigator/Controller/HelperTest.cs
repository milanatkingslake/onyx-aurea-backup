using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Controller;
using Onyx.UI.Navigator.ViewModel;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.Helper" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Helper" />)
        /// </summary>
        public HelperTest() : base(typeof(Helper))
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

        #region General Initializer : Class (Helper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Helper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helperInstanceType = typeof(Helper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Helper) Initializer

        #region Methods

        private const string MethodCreateErrorResponse = "CreateErrorResponse";
        private const string MethodGetMessage = "GetMessage";

        #endregion

        #endregion

        #region General Initializer : Class (Helper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Helper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Helper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Helper)

        #region General Initializer : Class (Helper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Helper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateErrorResponse, 0)]
        [TestCase(MethodGetMessage, 0)]
        public void AUT_Helper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Helper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Helper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Helper_Is_Static_Type_Present_Test()
        {
            // Assert
            _helperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var ex = this.CreateType<System.Exception>();

            // Act
            Action executeAction = () => Helper.CreateErrorResponse(ex);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var ex = this.CreateType<System.Exception>();
            var returnedValue = default(ResponseViewModel);

            // Act
            Action executeAction = () => returnedValue = Helper.CreateErrorResponse(ex);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var ex = this.CreateType<System.Exception>();
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(System.Exception) };
            object[] parametersOfCreateErrorResponse = { ex };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateErrorResponse, methodCreateErrorResponseParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodCreateErrorResponse, methodCreateErrorResponseParametersTypes);
            var result2 = this.GetResultOfMethod<ResponseViewModel>(MethodCreateErrorResponse, parametersOfCreateErrorResponse, methodCreateErrorResponseParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfCreateErrorResponse);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateErrorResponse.ShouldNotBeNull();
            parametersOfCreateErrorResponse.Length.ShouldBe(1);
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var ex = this.CreateType<System.Exception>();
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(System.Exception) };
            object[] parametersOfCreateErrorResponse = { ex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResponseViewModel>(MethodCreateErrorResponse, parametersOfCreateErrorResponse, methodCreateErrorResponseParametersTypes);

            // Assert
            parametersOfCreateErrorResponse.ShouldNotBeNull();
            parametersOfCreateErrorResponse.Length.ShouldBe(1);
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(System.Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateErrorResponse, methodCreateErrorResponseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(System.Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateErrorResponse, methodCreateErrorResponseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateErrorResponse, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : ResponseViewModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateErrorResponse, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Helper_GetMessage_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetMessageParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var ex = this.CreateType<System.Exception>();
            var methodGetMessageParametersTypes = new Type[] { typeof(System.Exception) };
            object[] parametersOfGetMessage = { ex };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, methodGetMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMessage.ShouldNotBeNull();
            parametersOfGetMessage.Length.ShouldBe(1);
            methodGetMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes));
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var ex = this.CreateType<System.Exception>();
            var methodGetMessageParametersTypes = new Type[] { typeof(System.Exception) };
            object[] parametersOfGetMessage = { ex };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, methodGetMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetMessage.ShouldNotBeNull();
            parametersOfGetMessage.Length.ShouldBe(1);
            methodGetMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var ex = this.CreateType<System.Exception>();
            var methodGetMessageParametersTypes = new Type[] { typeof(System.Exception) };
            object[] parametersOfGetMessage = { ex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetMessage, parametersOfGetMessage, methodGetMessageParametersTypes);

            // Assert
            parametersOfGetMessage.ShouldNotBeNull();
            parametersOfGetMessage.Length.ShouldBe(1);
            methodGetMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var methodGetMessageParametersTypes = new Type[] { typeof(System.Exception) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetMessageParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var methodGetMessageParametersTypes = new Type[] { typeof(System.Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMessage, methodGetMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMessageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetMessage) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_GetMessage_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMessage, 0);
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