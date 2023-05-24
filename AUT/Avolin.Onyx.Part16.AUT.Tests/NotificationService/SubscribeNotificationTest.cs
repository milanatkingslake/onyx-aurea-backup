using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NotificationService.DAL;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.SubscribeNotification" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    [Ignore("Candidate for hanging of Jenkins builds")]
    public class SubscribeNotificationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscribeNotification" />)
        /// </summary>
        public SubscribeNotificationTest() : base(typeof(SubscribeNotification))
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

        #region General Initializer : Class (SubscribeNotification) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscribeNotificationInstanceType;
        private SubscribeNotification _subscribeNotificationInstance;
        private SubscribeNotification _subscribeNotificationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscribeNotification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscribeNotificationInstanceType = typeof(SubscribeNotification);
            _subscribeNotificationInstanceFixture = this.Create<SubscribeNotification>(false);
            _subscribeNotificationInstance = _subscribeNotificationInstanceFixture ?? this.Create<SubscribeNotification>(true);
            CurrentInstance = _subscribeNotificationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscribeNotification) Initializer

        #region Methods

        private const string MethodRetrieveAvailableNotification = "RetrieveAvailableNotification";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetNotification = "GetNotification";
        private const string MethodSaveSubscription = "SaveSubscription";
        private const string MethodUpdateSubscription = "UpdateSubscription";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodCheckONSService = "CheckONSService";
        private const string MethodSaveForwardedUsers = "SaveForwardedUsers";
        private const string MethodRemoveForwardedUsers = "RemoveForwardedUsers";
        private const string MethodUpdateForwardedUsers = "UpdateForwardedUsers";
        private const string MethodIsSubscriptionExists = "IsSubscriptionExists";
        private const string MethodValidateForwardedSubscription = "ValidateForwardedSubscription";

        #endregion

        #region Fields

        private const string FieldpersistenceDB = "persistenceDB";
        private const string FieldconnectionString = "connectionString";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (SubscribeNotification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribeNotification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscribeNotification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribeNotification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscribeNotification)

        #region General Initializer : Class (SubscribeNotification) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRetrieveAvailableNotification, 0)]
        [TestCase(MethodGetSubscribedNotification, 0)]
        [TestCase(MethodGetUsers, 0)]
        [TestCase(MethodGetNotification, 0)]
        [TestCase(MethodSaveSubscription, 0)]
        [TestCase(MethodUpdateSubscription, 0)]
        [TestCase(MethodDeleteSubscription, 0)]
        [TestCase(MethodCheckONSService, 0)]
        [TestCase(MethodSaveForwardedUsers, 0)]
        [TestCase(MethodRemoveForwardedUsers, 0)]
        [TestCase(MethodUpdateForwardedUsers, 0)]
        [TestCase(MethodIsSubscriptionExists, 0)]
        [TestCase(MethodValidateForwardedSubscription, 0)]
        public void AUT_SubscribeNotification_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SubscribeNotification) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldpersistenceDB)]
        [TestCase(FieldconnectionString)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_SubscribeNotification_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SubscribeNotification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscribeNotification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscribeNotification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscribeNotificationInstance.ShouldBeAssignableTo<SubscribeNotification>();
            _subscribeNotificationInstanceFixture.ShouldBeAssignableTo<SubscribeNotification>();
            CurrentInstance.ShouldBeAssignableTo<SubscribeNotification>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<ContextData>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.RetrieveAvailableNotification(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<ContextData>();
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _subscribeNotificationInstance.RetrieveAvailableNotification(contextData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<ContextData>();
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfRetrieveAvailableNotification = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfRetrieveAvailableNotification);
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
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var contextData = this.CreateType<ContextData>();
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfRetrieveAvailableNotification = { contextData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodRetrieveAvailableNotification, parametersOfRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

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
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(ContextData) };

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
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRetrieveAvailableNotification);
            var methodRetrieveAvailableNotificationParametersTypes = new Type[] { typeof(ContextData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRetrieveAvailableNotification, methodRetrieveAvailableNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRetrieveAvailableNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RetrieveAvailableNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_RetrieveAvailableNotification_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<ContextData>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.GetSubscribedNotification(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<ContextData>();
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetSubscribedNotification(contextData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<ContextData>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfGetSubscribedNotification = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfGetSubscribedNotification);
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
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var contextData = this.CreateType<ContextData>();
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfGetSubscribedNotification = { contextData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

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
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(ContextData) };

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
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotification);
            var methodGetSubscribedNotificationParametersTypes = new Type[] { typeof(ContextData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_GetSubscribedNotification_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_SubscribeNotification_GetUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.GetUsers(contextData, notificationSubscriptionId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetUsers(contextData, notificationSubscriptionId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetUsers = { contextData, notificationSubscriptionId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsers, methodGetUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfGetUsers);
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
        public void AUT_SubscribeNotification_GetUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var methodGetUsersParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetUsers = { contextData, notificationSubscriptionId };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

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
        public void AUT_SubscribeNotification_GetUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(ContextData), typeof(string) };

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
        public void AUT_SubscribeNotification_GetUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsers);
            var methodGetUsersParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_GetUsers_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_SubscribeNotification_GetNotification_Method_Call_Internally(Type[] types)
        {
            var methodGetNotificationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.GetNotification(contextData, notificationSubscriptionId, subscriptionType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetNotification(contextData, notificationSubscriptionId, subscriptionType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodGetNotificationParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            object[] parametersOfGetNotification = { contextData, notificationSubscriptionId, subscriptionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotification, methodGetNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfGetNotification);
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
        public void AUT_SubscribeNotification_GetNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var contextData = this.CreateType<ContextData>();
            var notificationSubscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodGetNotificationParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            object[] parametersOfGetNotification = { contextData, notificationSubscriptionId, subscriptionType };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNotification, parametersOfGetNotification, methodGetNotificationParametersTypes);

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
        public void AUT_SubscribeNotification_GetNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var methodGetNotificationParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };

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
        public void AUT_SubscribeNotification_GetNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotification);
            var methodGetNotificationParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_GetNotification_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (SaveSubscription) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_SaveSubscription_Method_Call_Internally(Type[] types)
        {
            var methodSaveSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.SaveSubscription(contextData, subscriptionData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, methodSaveSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_subscribeNotificationInstanceFixture, parametersOfSaveSubscription);
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
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, methodSaveSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_subscribeNotificationInstanceFixture, out exception1, parametersOfSaveSubscription);
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
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfSaveSubscription = { contextData, subscriptionData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<int>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

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
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var methodSaveSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (UpdateSubscription) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.UpdateSubscription(contextData, subscriptionData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfUpdateSubscription);
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
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfUpdateSubscription);
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
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            object[] parametersOfUpdateSubscription = { contextData, subscriptionData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

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
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var methodUpdateSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(SubscriptionData) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (DeleteSubscription) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.DeleteSubscription(contextData, subscriptionId, subscriptionType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfDeleteSubscription);
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
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfDeleteSubscription);
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
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var contextData = this.CreateType<ContextData>();
            var subscriptionId = this.CreateType<string>();
            var subscriptionType = this.CreateType<int>();
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            object[] parametersOfDeleteSubscription = { contextData, subscriptionId, subscriptionType };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

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
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var methodDeleteSubscriptionParametersTypes = new Type[] { typeof(ContextData), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_SubscribeNotification_CheckONSService_Method_Call_Internally(Type[] types)
        {
            var methodCheckONSServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<ContextData>();

            // Act
            System.Action executeAction = () => _subscribeNotificationInstance.CheckONSService(contextData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfCheckONSService = { contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfCheckONSService);
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
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfCheckONSService = { contextData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfCheckONSService);
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
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var contextData = this.CreateType<ContextData>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(ContextData) };
            object[] parametersOfCheckONSService = { contextData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

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
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(ContextData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_Internally(Type[] types)
        {
            var methodSaveForwardedUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveForwardedUsers, methodSaveForwardedUsersParametersTypes);
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfSaveForwardedUsers = { subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveForwardedUsers, methodSaveForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfSaveForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodSaveForwardedUsers, parametersOfSaveForwardedUsers, methodSaveForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveForwardedUsers.ShouldNotBeNull();
            parametersOfSaveForwardedUsers.Length.ShouldBe(1);
            methodSaveForwardedUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfSaveForwardedUsers = { subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveForwardedUsers, methodSaveForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfSaveForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodSaveForwardedUsers, parametersOfSaveForwardedUsers, methodSaveForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveForwardedUsers.ShouldNotBeNull();
            parametersOfSaveForwardedUsers.Length.ShouldBe(1);
            methodSaveForwardedUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodSaveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfSaveForwardedUsers = { subscriptionData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodSaveForwardedUsers, parametersOfSaveForwardedUsers, methodSaveForwardedUsersParametersTypes);

            // Assert
            parametersOfSaveForwardedUsers.ShouldNotBeNull();
            parametersOfSaveForwardedUsers.Length.ShouldBe(1);
            methodSaveForwardedUsersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var methodSaveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveForwardedUsers, methodSaveForwardedUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveForwardedUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveForwardedUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveForwardedUsers) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveForwardedUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveForwardedUsers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_Internally(Type[] types)
        {
            var methodRemoveForwardedUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodRemoveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfRemoveForwardedUsers = { subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfRemoveForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodRemoveForwardedUsers, parametersOfRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemoveForwardedUsers.ShouldNotBeNull();
            parametersOfRemoveForwardedUsers.Length.ShouldBe(1);
            methodRemoveForwardedUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodRemoveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfRemoveForwardedUsers = { subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfRemoveForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodRemoveForwardedUsers, parametersOfRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfRemoveForwardedUsers.ShouldNotBeNull();
            parametersOfRemoveForwardedUsers.Length.ShouldBe(1);
            methodRemoveForwardedUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodRemoveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfRemoveForwardedUsers = { subscriptionData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodRemoveForwardedUsers, parametersOfRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes);

            // Assert
            parametersOfRemoveForwardedUsers.ShouldNotBeNull();
            parametersOfRemoveForwardedUsers.Length.ShouldBe(1);
            methodRemoveForwardedUsersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var methodRemoveForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveForwardedUsers, methodRemoveForwardedUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveForwardedUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveForwardedUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveForwardedUsers) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_RemoveForwardedUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveForwardedUsers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_Internally(Type[] types)
        {
            var methodUpdateForwardedUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var notificationSubscriptionForwarded = this.CreateType<List<NotificationSubscriptionForwarded>>();
            var usersList = this.CreateType<List<string>>();
            var methodUpdateForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData), typeof(List<NotificationSubscriptionForwarded>), typeof(List<string>) };
            object[] parametersOfUpdateForwardedUsers = { subscriptionData, notificationSubscriptionForwarded, usersList };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfUpdateForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateForwardedUsers, parametersOfUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateForwardedUsers.ShouldNotBeNull();
            parametersOfUpdateForwardedUsers.Length.ShouldBe(3);
            methodUpdateForwardedUsersParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var notificationSubscriptionForwarded = this.CreateType<List<NotificationSubscriptionForwarded>>();
            var usersList = this.CreateType<List<string>>();
            var methodUpdateForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData), typeof(List<NotificationSubscriptionForwarded>), typeof(List<string>) };
            object[] parametersOfUpdateForwardedUsers = { subscriptionData, notificationSubscriptionForwarded, usersList };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfUpdateForwardedUsers);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateForwardedUsers, parametersOfUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateForwardedUsers.ShouldNotBeNull();
            parametersOfUpdateForwardedUsers.Length.ShouldBe(3);
            methodUpdateForwardedUsersParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var notificationSubscriptionForwarded = this.CreateType<List<NotificationSubscriptionForwarded>>();
            var usersList = this.CreateType<List<string>>();
            var methodUpdateForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData), typeof(List<NotificationSubscriptionForwarded>), typeof(List<string>) };
            object[] parametersOfUpdateForwardedUsers = { subscriptionData, notificationSubscriptionForwarded, usersList };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateForwardedUsers, parametersOfUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes);

            // Assert
            parametersOfUpdateForwardedUsers.ShouldNotBeNull();
            parametersOfUpdateForwardedUsers.Length.ShouldBe(3);
            methodUpdateForwardedUsersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var methodUpdateForwardedUsersParametersTypes = new Type[] { typeof(SubscriptionData), typeof(List<NotificationSubscriptionForwarded>), typeof(List<string>) };
            const int parametersCount = 3;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateForwardedUsers, methodUpdateForwardedUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateForwardedUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateForwardedUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateForwardedUsers) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateForwardedUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateForwardedUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateForwardedUsers, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_Internally(Type[] types)
        {
            var methodIsSubscriptionExistsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodIsSubscriptionExistsParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfIsSubscriptionExists = { subscriptionData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfIsSubscriptionExists);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSubscriptionExists, parametersOfIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSubscriptionExists.ShouldNotBeNull();
            parametersOfIsSubscriptionExists.Length.ShouldBe(1);
            methodIsSubscriptionExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodIsSubscriptionExistsParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfIsSubscriptionExists = { subscriptionData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfIsSubscriptionExists);
            var result2 = this.GetResultOfMethod<bool>(MethodIsSubscriptionExists, parametersOfIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsSubscriptionExists.ShouldNotBeNull();
            parametersOfIsSubscriptionExists.Length.ShouldBe(1);
            methodIsSubscriptionExistsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var subscriptionData = this.CreateType<SubscriptionData>();
            var methodIsSubscriptionExistsParametersTypes = new Type[] { typeof(SubscriptionData) };
            object[] parametersOfIsSubscriptionExists = { subscriptionData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsSubscriptionExists, parametersOfIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes);

            // Assert
            parametersOfIsSubscriptionExists.ShouldNotBeNull();
            parametersOfIsSubscriptionExists.Length.ShouldBe(1);
            methodIsSubscriptionExistsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var methodIsSubscriptionExistsParametersTypes = new Type[] { typeof(SubscriptionData) };
            const int parametersCount = 1;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsSubscriptionExists, methodIsSubscriptionExistsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsSubscriptionExistsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsSubscriptionExists, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsSubscriptionExists) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_IsSubscriptionExists_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsSubscriptionExists);
            var currentMethodInfo = this.GetMethodInfo(MethodIsSubscriptionExists, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_Internally(Type[] types)
        {
            var methodValidateForwardedSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var objSubscriptionDataMembers = this.CreateType<SubscriptionDataMembers>();
            var contextData = this.CreateType<ContextData>();
            var methodValidateForwardedSubscriptionParametersTypes = new Type[] { typeof(SubscriptionDataMembers), typeof(ContextData) };
            object[] parametersOfValidateForwardedSubscription = { objSubscriptionDataMembers, contextData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfValidateForwardedSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateForwardedSubscription, parametersOfValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateForwardedSubscription.ShouldNotBeNull();
            parametersOfValidateForwardedSubscription.Length.ShouldBe(2);
            methodValidateForwardedSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var objSubscriptionDataMembers = this.CreateType<SubscriptionDataMembers>();
            var contextData = this.CreateType<ContextData>();
            var methodValidateForwardedSubscriptionParametersTypes = new Type[] { typeof(SubscriptionDataMembers), typeof(ContextData) };
            object[] parametersOfValidateForwardedSubscription = { objSubscriptionDataMembers, contextData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfValidateForwardedSubscription);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateForwardedSubscription, parametersOfValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateForwardedSubscription.ShouldNotBeNull();
            parametersOfValidateForwardedSubscription.Length.ShouldBe(2);
            methodValidateForwardedSubscriptionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var objSubscriptionDataMembers = this.CreateType<SubscriptionDataMembers>();
            var contextData = this.CreateType<ContextData>();
            var methodValidateForwardedSubscriptionParametersTypes = new Type[] { typeof(SubscriptionDataMembers), typeof(ContextData) };
            object[] parametersOfValidateForwardedSubscription = { objSubscriptionDataMembers, contextData };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateForwardedSubscription, parametersOfValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes);

            // Assert
            parametersOfValidateForwardedSubscription.ShouldNotBeNull();
            parametersOfValidateForwardedSubscription.Length.ShouldBe(2);
            methodValidateForwardedSubscriptionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var methodValidateForwardedSubscriptionParametersTypes = new Type[] { typeof(SubscriptionDataMembers), typeof(ContextData) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateForwardedSubscription, methodValidateForwardedSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateForwardedSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForwardedSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateForwardedSubscription) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_ValidateForwardedSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateForwardedSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateForwardedSubscription, 0);
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