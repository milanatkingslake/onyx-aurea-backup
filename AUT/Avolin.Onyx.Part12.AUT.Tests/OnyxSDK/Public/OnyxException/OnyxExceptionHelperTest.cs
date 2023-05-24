using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OnyxSDK.Public.OnyxException;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OnyxException
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OnyxException.OnyxExceptionHelper" />)
    ///     and namespace <see cref="OnyxSDK.Public.OnyxException"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxExceptionHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxExceptionHelper" />)
        /// </summary>
        public OnyxExceptionHelperTest() : base(typeof(OnyxExceptionHelper))
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

        #region General Initializer : Class (OnyxExceptionHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxExceptionHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxExceptionHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxExceptionHelperInstanceType = typeof(OnyxExceptionHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxExceptionHelper) Initializer

        #region Methods

        private const string MethodExceptionCheckForMethodCall = "ExceptionCheckForMethodCall";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxExceptionHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxExceptionHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxExceptionHelper)

        #region General Initializer : Class (OnyxExceptionHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExceptionCheckForMethodCall, 0)]
        public void AUT_OnyxExceptionHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxExceptionHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxExceptionHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxExceptionHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxExceptionHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var returnParameters = this.CreateType<JObject>();
            var methodCallName = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxExceptionHelper.ExceptionCheckForMethodCall(returnParameters, methodCallName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var returnParameters = this.CreateType<JObject>();
            var methodCallName = this.CreateType<string>();
            var returnedValue = default(OnyxExecuteException);

            // Act
            Action executeAction = () => returnedValue = OnyxExceptionHelper.ExceptionCheckForMethodCall(returnParameters, methodCallName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var returnParameters = this.CreateType<JObject>();
            var methodCallName = this.CreateType<string>();
            var methodExceptionCheckForMethodCallParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfExceptionCheckForMethodCall = { returnParameters, methodCallName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionCheckForMethodCall, methodExceptionCheckForMethodCallParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfExceptionCheckForMethodCall);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExceptionCheckForMethodCall.ShouldNotBeNull();
            parametersOfExceptionCheckForMethodCall.Length.ShouldBe(2);
            methodExceptionCheckForMethodCallParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var returnParameters = this.CreateType<JObject>();
            var methodCallName = this.CreateType<string>();
            var methodExceptionCheckForMethodCallParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            object[] parametersOfExceptionCheckForMethodCall = { returnParameters, methodCallName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OnyxExecuteException>(MethodExceptionCheckForMethodCall, parametersOfExceptionCheckForMethodCall, methodExceptionCheckForMethodCallParametersTypes);

            // Assert
            parametersOfExceptionCheckForMethodCall.ShouldNotBeNull();
            parametersOfExceptionCheckForMethodCall.Length.ShouldBe(2);
            methodExceptionCheckForMethodCallParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var methodExceptionCheckForMethodCallParametersTypes = new Type[] { typeof(JObject), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExceptionCheckForMethodCall, methodExceptionCheckForMethodCallParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExceptionCheckForMethodCallParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var methodExceptionCheckForMethodCallParametersTypes = new Type[] { typeof(JObject), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExceptionCheckForMethodCall, methodExceptionCheckForMethodCallParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExceptionCheckForMethodCallParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionCheckForMethodCall, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExceptionCheckForMethodCall) (Return Type : OnyxExecuteException) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxExceptionHelper_ExceptionCheckForMethodCall_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionCheckForMethodCall);
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionCheckForMethodCall, 0);
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