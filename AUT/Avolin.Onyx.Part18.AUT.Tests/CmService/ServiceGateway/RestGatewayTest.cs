using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using CmService.ServiceGateway;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.CmService.ServiceGateway
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.ServiceGateway.RestGateway" />)
    ///     and namespace <see cref="CmService.ServiceGateway"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RestGatewayTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RestGateway" />)
        /// </summary>
        public RestGatewayTest() : base(typeof(RestGateway))
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

        #region General Initializer : Class (RestGateway) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _restGatewayInstanceType;
        private RestGateway _restGatewayInstance;
        private RestGateway _restGatewayInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RestGateway" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _restGatewayInstanceType = typeof(RestGateway);
            _restGatewayInstanceFixture = this.Create<RestGateway>(false);
            _restGatewayInstance = _restGatewayInstanceFixture ?? this.Create<RestGateway>(true);
            CurrentInstance = _restGatewayInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RestGateway) Initializer

        #region Methods

        private const string MethodCoInitializeSecurity = "CoInitializeSecurity";

        #endregion

        #endregion

        #region General Initializer : Class (RestGateway) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RestGateway" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RestGateway_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RestGateway)

        #region General Initializer : Class (RestGateway) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RestGateway" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCoInitializeSecurity, 0)]
        public void AUT_RestGateway_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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
        
        #region General Instance : Class (RestGateway) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RestGateway" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RestGateway_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _restGatewayInstance.ShouldBeAssignableTo<RestGateway>();
            _restGatewayInstanceFixture.ShouldBeAssignableTo<RestGateway>();
            CurrentInstance.ShouldBeAssignableTo<RestGateway>();
        }

        #endregion

        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (CoInitializeSecurity) (Return Type : int) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var pVoid = this.CreateType<IntPtr>();
            var cAuthSvc = this.CreateType<int>();
            var asAuthSvc = this.CreateType<IntPtr>();
            var pReserved1 = this.CreateType<IntPtr>();
            var level = this.CreateType<RestGateway.RpcAuthnLevel>();
            var impers = this.CreateType<RestGateway.RpcImpLevel>();
            var pAuthList = this.CreateType<IntPtr>();
            var dwCapabilities = this.CreateType<int>();
            var pReserved3 = this.CreateType<IntPtr>();

            // Act
            Action executeAction = () => RestGateway.CoInitializeSecurity(pVoid, cAuthSvc, asAuthSvc, pReserved1, level, impers, pAuthList, dwCapabilities, pReserved3);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CoInitializeSecurity) (Return Type : int) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var pVoid = this.CreateType<IntPtr>();
            var cAuthSvc = this.CreateType<int>();
            var asAuthSvc = this.CreateType<IntPtr>();
            var pReserved1 = this.CreateType<IntPtr>();
            var level = this.CreateType<RestGateway.RpcAuthnLevel>();
            var impers = this.CreateType<RestGateway.RpcImpLevel>();
            var pAuthList = this.CreateType<IntPtr>();
            var dwCapabilities = this.CreateType<int>();
            var pReserved3 = this.CreateType<IntPtr>();
            var methodCoInitializeSecurityParametersTypes = new Type[] { typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr), typeof(RestGateway.RpcAuthnLevel), typeof(RestGateway.RpcImpLevel), typeof(IntPtr), typeof(int), typeof(IntPtr) };
            object[] parametersOfCoInitializeSecurity = { pVoid, cAuthSvc, asAuthSvc, pReserved1, level, impers, pAuthList, dwCapabilities, pReserved3 };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCoInitializeSecurity, methodCoInitializeSecurityParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_restGatewayInstanceFixture, parametersOfCoInitializeSecurity);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCoInitializeSecurity.ShouldNotBeNull();
            parametersOfCoInitializeSecurity.Length.ShouldBe(9);
            methodCoInitializeSecurityParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CoInitializeSecurity) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var pVoid = this.CreateType<IntPtr>();
            var cAuthSvc = this.CreateType<int>();
            var asAuthSvc = this.CreateType<IntPtr>();
            var pReserved1 = this.CreateType<IntPtr>();
            var level = this.CreateType<RestGateway.RpcAuthnLevel>();
            var impers = this.CreateType<RestGateway.RpcImpLevel>();
            var pAuthList = this.CreateType<IntPtr>();
            var dwCapabilities = this.CreateType<int>();
            var pReserved3 = this.CreateType<IntPtr>();
            var methodCoInitializeSecurityParametersTypes = new Type[] { typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr), typeof(RestGateway.RpcAuthnLevel), typeof(RestGateway.RpcImpLevel), typeof(IntPtr), typeof(int), typeof(IntPtr) };
            object[] parametersOfCoInitializeSecurity = { pVoid, cAuthSvc, asAuthSvc, pReserved1, level, impers, pAuthList, dwCapabilities, pReserved3 };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodCoInitializeSecurity, parametersOfCoInitializeSecurity, methodCoInitializeSecurityParametersTypes);

            // Assert
            parametersOfCoInitializeSecurity.ShouldNotBeNull();
            parametersOfCoInitializeSecurity.Length.ShouldBe(9);
            methodCoInitializeSecurityParametersTypes.Length.ShouldBe(9);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CoInitializeSecurity) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var methodCoInitializeSecurityParametersTypes = new Type[] { typeof(IntPtr), typeof(int), typeof(IntPtr), typeof(IntPtr), typeof(RestGateway.RpcAuthnLevel), typeof(RestGateway.RpcImpLevel), typeof(IntPtr), typeof(int), typeof(IntPtr) };
            const int parametersCount = 9;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCoInitializeSecurity, methodCoInitializeSecurityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCoInitializeSecurityParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CoInitializeSecurity) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodCoInitializeSecurity, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CoInitializeSecurity) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RestGateway_CoInitializeSecurity_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCoInitializeSecurity);
            var currentMethodInfo = this.GetMethodInfo(MethodCoInitializeSecurity, 0);
            const int parametersCount = 9;

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