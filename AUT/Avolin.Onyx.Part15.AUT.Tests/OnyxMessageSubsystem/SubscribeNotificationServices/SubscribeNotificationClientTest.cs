using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem.SubscribeNotificationServices;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem.SubscribeNotificationServices
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.SubscribeNotificationServices.SubscribeNotificationClient" />)
    ///     and namespace <see cref="OnyxMessageSubsystem.SubscribeNotificationServices"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SubscribeNotificationClientTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscribeNotificationClient" />)
        /// </summary>
        public SubscribeNotificationClientTest() : base(typeof(SubscribeNotificationClient))
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

        #region General Initializer : Class (SubscribeNotificationClient) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscribeNotificationClientInstanceType;
        private SubscribeNotificationClient _subscribeNotificationClientInstance;
        private SubscribeNotificationClient _subscribeNotificationClientInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscribeNotificationClient" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscribeNotificationClientInstanceType = typeof(SubscribeNotificationClient);
            _subscribeNotificationClientInstanceFixture = this.Create<SubscribeNotificationClient>(false);
            _subscribeNotificationClientInstance = _subscribeNotificationClientInstanceFixture ?? this.Create<SubscribeNotificationClient>(true);
            CurrentInstance = _subscribeNotificationClientInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscribeNotificationClient) Initializer

        #region Methods

        private const string MethodRetrieveAvailableNotification = "RetrieveAvailableNotification";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetNotification = "GetNotification";
        private const string MethodUpdateSubscription = "UpdateSubscription";
        private const string MethodSaveSubscription = "SaveSubscription";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #endregion

        #region General Initializer : Class (SubscribeNotificationClient) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscribeNotificationClient" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribeNotificationClient_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscribeNotificationClient)

        #region General Initializer : Class (SubscribeNotificationClient) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SubscribeNotificationClient" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetrieveAvailableNotification, 0)]
        [TestCase(MethodGetSubscribedNotification, 0)]
        [TestCase(MethodGetUsers, 0)]
        [TestCase(MethodGetNotification, 0)]
        [TestCase(MethodUpdateSubscription, 0)]
        [TestCase(MethodSaveSubscription, 0)]
        [TestCase(MethodDeleteSubscription, 0)]
        [TestCase(MethodCheckONSService, 0)]
        public void AUT_SubscribeNotificationClient_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SubscribeNotificationClient) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscribeNotificationClient" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscribeNotificationClient_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscribeNotificationClientInstance.ShouldBeAssignableTo<SubscribeNotificationClient>();
            _subscribeNotificationClientInstanceFixture.ShouldBeAssignableTo<SubscribeNotificationClient>();
            CurrentInstance.ShouldBeAssignableTo<SubscribeNotificationClient>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubscribeNotificationClient) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (SubscribeNotificationClient) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodSubscribeNotificationClientParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSubscribeNotificationClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SubscribeNotificationClient) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSubscribeNotificationClientParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSubscribeNotificationClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SubscribeNotificationClient) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSubscribeNotificationClientParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSubscribeNotificationClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SubscribeNotificationClient) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSubscribeNotificationClientParametersTypes = new Type[] { typeof(string), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSubscribeNotificationClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SubscribeNotificationClient) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SubscribeNotificationClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribeNotificationClient_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSubscribeNotificationClientParametersTypes = new Type[] { typeof(System.ServiceModel.Channels.Binding), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSubscribeNotificationClientParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.RetrieveAvailableNotification(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationClientInstance.RetrieveAvailableNotification(contextData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfRetrieveAvailableNotification = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationClientInstanceFixture, parametersOfRetrieveAvailableNotification);
            var result2 = this.GetResultOfMethod<string>(MethodRetrieveAvailableNotification, parametersOfRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRetrieveAvailableNotification.ShouldNotBeNull();
            parametersOfRetrieveAvailableNotification.Length.ShouldBe(1);
            methodRetrieveAvailableNotificationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfRetrieveAvailableNotification = { contextData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveAvailableNotification, parametersOfRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

            // Assert
            parametersOfRetrieveAvailableNotification.ShouldNotBeNull();
            parametersOfRetrieveAvailableNotification.Length.ShouldBe(1);
            methodRetrieveAvailableNotificationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRetrieveAvailableNotificationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveAvailableNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAvailableNotification, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_RetrieveAvailableNotification_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAvailableNotification, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.GetSubscribedNotification(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationClientInstance.GetSubscribedNotification(contextData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfGetSubscribedNotification = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationClientInstanceFixture, parametersOfGetSubscribedNotification);
            var result2 = this.GetResultOfMethod<string>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotification.ShouldNotBeNull();
            parametersOfGetSubscribedNotification.Length.ShouldBe(1);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfGetSubscribedNotification = { contextData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            parametersOfGetSubscribedNotification.ShouldNotBeNull();
            parametersOfGetSubscribedNotification.Length.ShouldBe(1);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetSubscribedNotification_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_GetUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.GetUsers(contextData, notificationSubscriptionId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationClientInstance.GetUsers(contextData, notificationSubscriptionId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGetUsers = { contextData, notificationSubscriptionId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, methodGetUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationClientInstanceFixture, parametersOfGetUsers);
            var result2 = this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsers.ShouldNotBeNull();
            parametersOfGetUsers.Length.ShouldBe(2);
            methodGetUsersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGetUsers = { contextData, notificationSubscriptionId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            parametersOfGetUsers.ShouldNotBeNull();
            parametersOfGetUsers.Length.ShouldBe(2);
            methodGetUsersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_GetNotification_Method_Call_Internally(Type[] types)
        {
            var methodGetNotificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.GetNotification(contextData, notificationSubscriptionId, subscriptionType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationClientInstance.GetNotification(contextData, notificationSubscriptionId, subscriptionType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodGetNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            object[] parametersOfGetNotification = { contextData, notificationSubscriptionId, subscriptionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotification, methodGetNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationClientInstanceFixture, parametersOfGetNotification);
            var result2 = this.GetResultOfMethod<string>(MethodGetNotification, parametersOfGetNotification, methodGetNotificationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNotification.ShouldNotBeNull();
            parametersOfGetNotification.Length.ShouldBe(3);
            methodGetNotificationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodGetNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            object[] parametersOfGetNotification = { contextData, notificationSubscriptionId, subscriptionType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNotification, parametersOfGetNotification, methodGetNotificationParametersTypes);

            // Assert
            parametersOfGetNotification.ShouldNotBeNull();
            parametersOfGetNotification.Length.ShouldBe(3);
            methodGetNotificationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var methodGetNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNotificationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var methodGetNotificationParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotification, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_GetNotification_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotification, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.UpdateSubscription(contextData, subscriptionData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, parametersOfUpdateSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateSubscription.ShouldNotBeNull();
            parametersOfUpdateSubscription.Length.ShouldBe(2);
            methodUpdateSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, out exception1, parametersOfUpdateSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateSubscription.ShouldNotBeNull();
            parametersOfUpdateSubscription.Length.ShouldBe(2);
            methodUpdateSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            parametersOfUpdateSubscription.ShouldNotBeNull();
            parametersOfUpdateSubscription.Length.ShouldBe(2);
            methodUpdateSubscriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_UpdateSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_Internally(Type[] types)
        {
            var methodSaveSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.SaveSubscription(contextData, subscriptionData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, methodSaveSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_subscribeNotificationClientInstanceFixture, parametersOfSaveSubscription);
            var result2 = this.GetResultOfMethod<int>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveSubscription.ShouldNotBeNull();
            parametersOfSaveSubscription.Length.ShouldBe(2);
            methodSaveSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, methodSaveSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_subscribeNotificationClientInstanceFixture, out exception1, parametersOfSaveSubscription);
            var result2 = this.GetResultOfMethod<int>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveSubscription.ShouldNotBeNull();
            parametersOfSaveSubscription.Length.ShouldBe(2);
            methodSaveSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            parametersOfSaveSubscription.ShouldNotBeNull();
            parametersOfSaveSubscription.Length.ShouldBe(2);
            methodSaveSubscriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_SaveSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.DeleteSubscription(contextData, subscriptionId, subscriptionType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, parametersOfDeleteSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteSubscription.ShouldNotBeNull();
            parametersOfDeleteSubscription.Length.ShouldBe(3);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, out exception1, parametersOfDeleteSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteSubscription.ShouldNotBeNull();
            parametersOfDeleteSubscription.Length.ShouldBe(3);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            parametersOfDeleteSubscription.ShouldNotBeNull();
            parametersOfDeleteSubscription.Length.ShouldBe(3);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_DeleteSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_Internally(Type[] types)
        {
            var methodCheckONSServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();

            // Act
            Action executeAction = () => _subscribeNotificationClientInstance.CheckONSService(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfCheckONSService = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, parametersOfCheckONSService);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckONSService.ShouldNotBeNull();
            parametersOfCheckONSService.Length.ShouldBe(1);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfCheckONSService = { contextData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationClientInstanceFixture, out exception1, parametersOfCheckONSService);
            var result2 = this.GetResultOfMethod<bool>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCheckONSService.ShouldNotBeNull();
            parametersOfCheckONSService.Length.ShouldBe(1);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            object[] parametersOfCheckONSService = { contextData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            parametersOfCheckONSService.ShouldNotBeNull();
            parametersOfCheckONSService.Length.ShouldBe(1);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotificationClient_CheckONSService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, 0);
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