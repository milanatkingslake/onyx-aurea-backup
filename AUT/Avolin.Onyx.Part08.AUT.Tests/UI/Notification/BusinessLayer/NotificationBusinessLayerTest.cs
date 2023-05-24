using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Onyx.UI.Notification.BusinessLayer;
using Onyx.UI.Notification.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.BusinessLayer.NotificationBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Notification.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NotificationBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationBusinessLayer" />)
        /// </summary>
        public NotificationBusinessLayerTest() : base(typeof(NotificationBusinessLayer))
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

        #region General Initializer : Class (NotificationBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationBusinessLayerInstanceType;
        private NotificationBusinessLayer _notificationBusinessLayerInstance;
        private NotificationBusinessLayer _notificationBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationBusinessLayerInstanceType = typeof(NotificationBusinessLayer);
            _notificationBusinessLayerInstanceFixture = this.Create<NotificationBusinessLayer>(false);
            _notificationBusinessLayerInstance = _notificationBusinessLayerInstanceFixture ?? this.Create<NotificationBusinessLayer>(true);
            CurrentInstance = _notificationBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationBusinessLayer) Initializer

        #region Methods

        private const string MethodGetNotificationTypeByUserId = "GetNotificationTypeByUserId";
        private const string MethodAddtNotificationSubscription = "AddtNotificationSubscription";
        private const string MethodGetSubscribedNotificationByUserId = "GetSubscribedNotificationByUserId";
        private const string MethodGetSubscribedNotificationById = "GetSubscribedNotificationById";
        private const string MethodUpdateNotificationSubscription = "UpdateNotificationSubscription";
        private const string MethodUnSubscribe = "UnSubscribe";
        private const string MethodGetForwardedUsersBySubcriptionId = "GetForwardedUsersBySubcriptionId";
        private const string MethodGetUserGroup = "GetUserGroup";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationBusinessLayer)

        #region General Initializer : Class (NotificationBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NotificationBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetNotificationTypeByUserId, 0)]
        [TestCase(MethodAddtNotificationSubscription, 0)]
        [TestCase(MethodGetSubscribedNotificationByUserId, 0)]
        [TestCase(MethodGetSubscribedNotificationById, 0)]
        [TestCase(MethodUpdateNotificationSubscription, 0)]
        [TestCase(MethodUnSubscribe, 0)]
        [TestCase(MethodGetForwardedUsersBySubcriptionId, 0)]
        [TestCase(MethodGetUserGroup, 0)]
        [TestCase(MethodCheckONSService, 0)]
        public void AUT_NotificationBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NotificationBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _notificationBusinessLayerInstanceType.ShouldNotBeNull();
            _notificationBusinessLayerInstance.ShouldNotBeNull();
            _notificationBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationBusinessLayerInstance.ShouldBeAssignableTo<NotificationBusinessLayer>();
            _notificationBusinessLayerInstanceFixture.ShouldBeAssignableTo<NotificationBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NotificationBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.GetNotificationTypeByUserId(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(NotificationDetails);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.GetNotificationTypeByUserId(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetNotificationTypeByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetNotificationTypeByUserId = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<NotificationDetails>(_notificationBusinessLayerInstanceFixture, parametersOfGetNotificationTypeByUserId);
            var result2 = this.GetResultOfMethod<NotificationDetails>(MethodGetNotificationTypeByUserId, parametersOfGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNotificationTypeByUserId.ShouldNotBeNull();
            parametersOfGetNotificationTypeByUserId.Length.ShouldBe(1);
            methodGetNotificationTypeByUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetNotificationTypeByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetNotificationTypeByUserId = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<NotificationDetails>(MethodGetNotificationTypeByUserId, parametersOfGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            parametersOfGetNotificationTypeByUserId.ShouldNotBeNull();
            parametersOfGetNotificationTypeByUserId.Length.ShouldBe(1);
            methodGetNotificationTypeByUserIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var methodGetNotificationTypeByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNotificationTypeByUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var methodGetNotificationTypeByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationTypeByUserIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationTypeByUserId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : NotificationDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetNotificationTypeByUserId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationTypeByUserId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_Internally(Type[] types)
        {
            var methodAddtNotificationSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.AddtNotificationSubscription(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.AddtNotificationSubscription(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodAddtNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfAddtNotificationSubscription = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_notificationBusinessLayerInstanceFixture, parametersOfAddtNotificationSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodAddtNotificationSubscription, parametersOfAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddtNotificationSubscription.ShouldNotBeNull();
            parametersOfAddtNotificationSubscription.Length.ShouldBe(1);
            methodAddtNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodAddtNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfAddtNotificationSubscription = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAddtNotificationSubscription, parametersOfAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            parametersOfAddtNotificationSubscription.ShouldNotBeNull();
            parametersOfAddtNotificationSubscription.Length.ShouldBe(1);
            methodAddtNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var methodAddtNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddtNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var methodAddtNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddtNotificationSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodAddtNotificationSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_AddtNotificationSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodAddtNotificationSubscription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationByUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.GetSubscribedNotificationByUserId(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(SubscribedDetails);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.GetSubscribedNotificationByUserId(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSubscribedNotificationByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSubscribedNotificationByUserId = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<SubscribedDetails>(_notificationBusinessLayerInstanceFixture, parametersOfGetSubscribedNotificationByUserId);
            var result2 = this.GetResultOfMethod<SubscribedDetails>(MethodGetSubscribedNotificationByUserId, parametersOfGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotificationByUserId.ShouldNotBeNull();
            parametersOfGetSubscribedNotificationByUserId.Length.ShouldBe(1);
            methodGetSubscribedNotificationByUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSubscribedNotificationByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSubscribedNotificationByUserId = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<SubscribedDetails>(MethodGetSubscribedNotificationByUserId, parametersOfGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            parametersOfGetSubscribedNotificationByUserId.ShouldNotBeNull();
            parametersOfGetSubscribedNotificationByUserId.Length.ShouldBe(1);
            methodGetSubscribedNotificationByUserIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var methodGetSubscribedNotificationByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationByUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var methodGetSubscribedNotificationByUserIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationByUserIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationByUserId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : SubscribedDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationByUserId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationByUserId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.GetSubscribedNotificationById(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(NotificationDetails);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.GetSubscribedNotificationById(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSubscribedNotificationByIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSubscribedNotificationById = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<NotificationDetails>(_notificationBusinessLayerInstanceFixture, parametersOfGetSubscribedNotificationById);
            var result2 = this.GetResultOfMethod<NotificationDetails>(MethodGetSubscribedNotificationById, parametersOfGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotificationById.ShouldNotBeNull();
            parametersOfGetSubscribedNotificationById.Length.ShouldBe(1);
            methodGetSubscribedNotificationByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetSubscribedNotificationByIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetSubscribedNotificationById = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<NotificationDetails>(MethodGetSubscribedNotificationById, parametersOfGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            parametersOfGetSubscribedNotificationById.ShouldNotBeNull();
            parametersOfGetSubscribedNotificationById.Length.ShouldBe(1);
            methodGetSubscribedNotificationByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var methodGetSubscribedNotificationByIdParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var methodGetSubscribedNotificationByIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : NotificationDetails) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetSubscribedNotificationById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationById, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_Internally(Type[] types)
        {
            var methodUpdateNotificationSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.UpdateNotificationSubscription(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.UpdateNotificationSubscription(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUpdateNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUpdateNotificationSubscription = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_notificationBusinessLayerInstanceFixture, parametersOfUpdateNotificationSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateNotificationSubscription, parametersOfUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateNotificationSubscription.ShouldNotBeNull();
            parametersOfUpdateNotificationSubscription.Length.ShouldBe(1);
            methodUpdateNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUpdateNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUpdateNotificationSubscription = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateNotificationSubscription, parametersOfUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            parametersOfUpdateNotificationSubscription.ShouldNotBeNull();
            parametersOfUpdateNotificationSubscription.Length.ShouldBe(1);
            methodUpdateNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var methodUpdateNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateNotificationSubscriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var methodUpdateNotificationSubscriptionParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateNotificationSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateNotificationSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UpdateNotificationSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateNotificationSubscription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_Internally(Type[] types)
        {
            var methodUnSubscribeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.UnSubscribe(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.UnSubscribe(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUnSubscribeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUnSubscribe = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUnSubscribe, methodUnSubscribeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_notificationBusinessLayerInstanceFixture, parametersOfUnSubscribe);
            var result2 = this.GetResultOfMethod<string>(MethodUnSubscribe, parametersOfUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUnSubscribe.ShouldNotBeNull();
            parametersOfUnSubscribe.Length.ShouldBe(1);
            methodUnSubscribeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUnSubscribeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUnSubscribe = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUnSubscribe, parametersOfUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            parametersOfUnSubscribe.ShouldNotBeNull();
            parametersOfUnSubscribe.Length.ShouldBe(1);
            methodUnSubscribeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var methodUnSubscribeParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUnSubscribeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var methodUnSubscribeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUnSubscribeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var currentMethodInfo = this.GetMethodInfo(MethodUnSubscribe, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_UnSubscribe_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var currentMethodInfo = this.GetMethodInfo(MethodUnSubscribe, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_Internally(Type[] types)
        {
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.GetForwardedUsersBySubcriptionId(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ForwardedUsers>);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.GetForwardedUsersBySubcriptionId(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetForwardedUsersBySubcriptionId = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ForwardedUsers>>(_notificationBusinessLayerInstanceFixture, parametersOfGetForwardedUsersBySubcriptionId);
            var result2 = this.GetResultOfMethod<List<ForwardedUsers>>(MethodGetForwardedUsersBySubcriptionId, parametersOfGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetForwardedUsersBySubcriptionId.ShouldNotBeNull();
            parametersOfGetForwardedUsersBySubcriptionId.Length.ShouldBe(1);
            methodGetForwardedUsersBySubcriptionIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetForwardedUsersBySubcriptionId = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ForwardedUsers>>(MethodGetForwardedUsersBySubcriptionId, parametersOfGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            parametersOfGetForwardedUsersBySubcriptionId.ShouldNotBeNull();
            parametersOfGetForwardedUsersBySubcriptionId.Length.ShouldBe(1);
            methodGetForwardedUsersBySubcriptionIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetForwardedUsersBySubcriptionIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetForwardedUsersBySubcriptionIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUsersBySubcriptionId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : List<ForwardedUsers>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetForwardedUsersBySubcriptionId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUsersBySubcriptionId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_Internally(Type[] types)
        {
            var methodGetUserGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.GetUserGroup(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(HierarchicalDataSource);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.GetUserGroup(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetUserGroupParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetUserGroup = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroup, methodGetUserGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<HierarchicalDataSource>(_notificationBusinessLayerInstanceFixture, parametersOfGetUserGroup);
            var result2 = this.GetResultOfMethod<HierarchicalDataSource>(MethodGetUserGroup, parametersOfGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserGroup.ShouldNotBeNull();
            parametersOfGetUserGroup.Length.ShouldBe(1);
            methodGetUserGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetUserGroupParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetUserGroup = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HierarchicalDataSource>(MethodGetUserGroup, parametersOfGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            parametersOfGetUserGroup.ShouldNotBeNull();
            parametersOfGetUserGroup.Length.ShouldBe(1);
            methodGetUserGroupParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var methodGetUserGroupParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserGroupParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var methodGetUserGroupParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserGroupParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroup, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : HierarchicalDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_GetUserGroup_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroup, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_Internally(Type[] types)
        {
            var methodCheckONSServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _notificationBusinessLayerInstance.CheckONSService(mainfest);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _notificationBusinessLayerInstance.CheckONSService(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfCheckONSService = { mainfest };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_notificationBusinessLayerInstanceFixture, out exception1, parametersOfCheckONSService);
            var result2 = this.GetResultOfMethod<string>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

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

        #region Method Call : (CheckONSService) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfCheckONSService = { mainfest };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_notificationBusinessLayerInstanceFixture, parametersOfCheckONSService);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCheckONSService.ShouldNotBeNull();
            parametersOfCheckONSService.Length.ShouldBe(1);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfCheckONSService = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            parametersOfCheckONSService.ShouldNotBeNull();
            parametersOfCheckONSService.Length.ShouldBe(1);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckONSServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var methodCheckONSServiceParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckONSServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (CheckONSService) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationBusinessLayer_CheckONSService_Method_Call_Parameters_Count_Verification_Test()
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