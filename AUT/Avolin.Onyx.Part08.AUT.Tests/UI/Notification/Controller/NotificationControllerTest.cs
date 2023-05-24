using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.Controller;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Controller.NotificationController" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NotificationControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationController" />)
        /// </summary>
        public NotificationControllerTest() : base(typeof(NotificationController))
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

        #region General Initializer : Class (NotificationController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationControllerInstanceType;
        private NotificationController _notificationControllerInstance;
        private NotificationController _notificationControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationControllerInstanceType = typeof(NotificationController);
            _notificationControllerInstanceFixture = this.Create<NotificationController>(false);
            _notificationControllerInstance = _notificationControllerInstanceFixture ?? this.Create<NotificationController>(true);
            CurrentInstance = _notificationControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationController) Initializer

        #region Properties

        private const string PropertyNotificationBusinessLayer = "NotificationBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetSubscribedNotificationByUserId = "GetSubscribedNotificationByUserId";
        private const string MethodGetNotificationTypeByUserId = "GetNotificationTypeByUserId";
        private const string MethodGetSubscribedNotificationById = "GetSubscribedNotificationById";
        private const string MethodGetForwardedUsersBySubcriptionId = "GetForwardedUsersBySubcriptionId";
        private const string MethodGetUserGroup = "GetUserGroup";
        private const string MethodUnSubscribe = "UnSubscribe";
        private const string MethodAddtNotificationSubscription = "AddtNotificationSubscription";
        private const string MethodUpdateNotificationSubscription = "UpdateNotificationSubscription";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NotificationController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationController)

        #region General Initializer : Class (NotificationController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NotificationController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSubscribedNotificationByUserId, 0)]
        [TestCase(MethodGetNotificationTypeByUserId, 0)]
        [TestCase(MethodGetSubscribedNotificationById, 0)]
        [TestCase(MethodGetForwardedUsersBySubcriptionId, 0)]
        [TestCase(MethodGetUserGroup, 0)]
        [TestCase(MethodUnSubscribe, 0)]
        [TestCase(MethodAddtNotificationSubscription, 0)]
        [TestCase(MethodUpdateNotificationSubscription, 0)]
        [TestCase(MethodCheckONSService, 0)]
        public void AUT_NotificationController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NotificationController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NotificationController_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (NotificationController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationController_Is_Instance_Present_Test()
        {
            // Assert
            _notificationControllerInstanceType.ShouldNotBeNull();
            _notificationControllerInstance.ShouldNotBeNull();
            _notificationControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationControllerInstance.ShouldBeAssignableTo<NotificationController>();
            _notificationControllerInstanceFixture.ShouldBeAssignableTo<NotificationController>();
            CurrentInstance.ShouldBeAssignableTo<NotificationController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NotificationController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationBusinessLayer)]
        public void AUT_NotificationController_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationController) => Property (NotificationBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationController_NotificationBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_notificationControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationController) => Property (NotificationBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationController_Public_Class_NotificationBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationBusinessLayer);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);

            // Act
            Action executeAction = () => _notificationControllerInstance.GetSubscribedNotificationByUserId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.GetSubscribedNotificationByUserId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            Type [] methodGetSubscribedNotificationByUserIdParametersTypes = null;
            object[] parametersOfGetSubscribedNotificationByUserId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfGetSubscribedNotificationByUserId);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSubscribedNotificationByUserId, parametersOfGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotificationByUserId.ShouldBeNull();
            methodGetSubscribedNotificationByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            Type [] methodGetSubscribedNotificationByUserIdParametersTypes = null;
            object[] parametersOfGetSubscribedNotificationByUserId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSubscribedNotificationByUserId, parametersOfGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            parametersOfGetSubscribedNotificationByUserId.ShouldBeNull();
            methodGetSubscribedNotificationByUserIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            Type [] methodGetSubscribedNotificationByUserIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationByUserId);
            Type [] methodGetSubscribedNotificationByUserIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationByUserId, methodGetSubscribedNotificationByUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationByUserId) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationByUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_Internally(Type[] types)
        {
            var methodGetNotificationTypeByUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);

            // Act
            Action executeAction = () => _notificationControllerInstance.GetNotificationTypeByUserId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.GetNotificationTypeByUserId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            Type [] methodGetNotificationTypeByUserIdParametersTypes = null;
            object[] parametersOfGetNotificationTypeByUserId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfGetNotificationTypeByUserId);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetNotificationTypeByUserId, parametersOfGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNotificationTypeByUserId.ShouldBeNull();
            methodGetNotificationTypeByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            Type [] methodGetNotificationTypeByUserIdParametersTypes = null;
            object[] parametersOfGetNotificationTypeByUserId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetNotificationTypeByUserId, parametersOfGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            parametersOfGetNotificationTypeByUserId.ShouldBeNull();
            methodGetNotificationTypeByUserIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            Type [] methodGetNotificationTypeByUserIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNotificationTypeByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNotificationTypeByUserId);
            Type [] methodGetNotificationTypeByUserIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotificationTypeByUserId, methodGetNotificationTypeByUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationTypeByUserIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNotificationTypeByUserId) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetNotificationTypeByUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_Internally(Type[] types)
        {
            var methodGetSubscribedNotificationByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);

            // Act
            Action executeAction = () => _notificationControllerInstance.GetSubscribedNotificationById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.GetSubscribedNotificationById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            Type [] methodGetSubscribedNotificationByIdParametersTypes = null;
            object[] parametersOfGetSubscribedNotificationById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfGetSubscribedNotificationById);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSubscribedNotificationById, parametersOfGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSubscribedNotificationById.ShouldBeNull();
            methodGetSubscribedNotificationByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            Type [] methodGetSubscribedNotificationByIdParametersTypes = null;
            object[] parametersOfGetSubscribedNotificationById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSubscribedNotificationById, parametersOfGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            parametersOfGetSubscribedNotificationById.ShouldBeNull();
            methodGetSubscribedNotificationByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            Type [] methodGetSubscribedNotificationByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSubscribedNotificationById);
            Type [] methodGetSubscribedNotificationByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotificationById, methodGetSubscribedNotificationByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSubscribedNotificationById) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetSubscribedNotificationById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_Internally(Type[] types)
        {
            var methodGetForwardedUsersBySubcriptionIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);

            // Act
            Action executeAction = () => _notificationControllerInstance.GetForwardedUsersBySubcriptionId();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.GetForwardedUsersBySubcriptionId();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            Type [] methodGetForwardedUsersBySubcriptionIdParametersTypes = null;
            object[] parametersOfGetForwardedUsersBySubcriptionId = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfGetForwardedUsersBySubcriptionId);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetForwardedUsersBySubcriptionId, parametersOfGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetForwardedUsersBySubcriptionId.ShouldBeNull();
            methodGetForwardedUsersBySubcriptionIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            Type [] methodGetForwardedUsersBySubcriptionIdParametersTypes = null;
            object[] parametersOfGetForwardedUsersBySubcriptionId = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetForwardedUsersBySubcriptionId, parametersOfGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            parametersOfGetForwardedUsersBySubcriptionId.ShouldBeNull();
            methodGetForwardedUsersBySubcriptionIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            Type [] methodGetForwardedUsersBySubcriptionIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetForwardedUsersBySubcriptionIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetForwardedUsersBySubcriptionId);
            Type [] methodGetForwardedUsersBySubcriptionIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetForwardedUsersBySubcriptionId, methodGetForwardedUsersBySubcriptionIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetForwardedUsersBySubcriptionIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetForwardedUsersBySubcriptionId) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetForwardedUsersBySubcriptionId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_GetUserGroup_Method_Call_Internally(Type[] types)
        {
            var methodGetUserGroupParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);

            // Act
            Action executeAction = () => _notificationControllerInstance.GetUserGroup();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.GetUserGroup();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            Type [] methodGetUserGroupParametersTypes = null;
            object[] parametersOfGetUserGroup = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserGroup, methodGetUserGroupParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfGetUserGroup);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserGroup, parametersOfGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserGroup.ShouldBeNull();
            methodGetUserGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            Type [] methodGetUserGroupParametersTypes = null;
            object[] parametersOfGetUserGroup = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserGroup, parametersOfGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            parametersOfGetUserGroup.ShouldBeNull();
            methodGetUserGroupParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            Type [] methodGetUserGroupParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserGroup);
            Type [] methodGetUserGroupParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserGroup, methodGetUserGroupParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserGroupParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserGroup) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_GetUserGroup_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_UnSubscribe_Method_Call_Internally(Type[] types)
        {
            var methodUnSubscribeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);

            // Act
            Action executeAction = () => _notificationControllerInstance.UnSubscribe();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.UnSubscribe();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            Type [] methodUnSubscribeParametersTypes = null;
            object[] parametersOfUnSubscribe = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUnSubscribe, methodUnSubscribeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfUnSubscribe);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUnSubscribe, parametersOfUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUnSubscribe.ShouldBeNull();
            methodUnSubscribeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            Type [] methodUnSubscribeParametersTypes = null;
            object[] parametersOfUnSubscribe = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUnSubscribe, parametersOfUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            parametersOfUnSubscribe.ShouldBeNull();
            methodUnSubscribeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            Type [] methodUnSubscribeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUnSubscribeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUnSubscribe);
            Type [] methodUnSubscribeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUnSubscribe, methodUnSubscribeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUnSubscribeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UnSubscribe) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UnSubscribe_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_AddtNotificationSubscription_Method_Call_Internally(Type[] types)
        {
            var methodAddtNotificationSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);

            // Act
            Action executeAction = () => _notificationControllerInstance.AddtNotificationSubscription();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.AddtNotificationSubscription();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            Type [] methodAddtNotificationSubscriptionParametersTypes = null;
            object[] parametersOfAddtNotificationSubscription = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfAddtNotificationSubscription);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodAddtNotificationSubscription, parametersOfAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAddtNotificationSubscription.ShouldBeNull();
            methodAddtNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            Type [] methodAddtNotificationSubscriptionParametersTypes = null;
            object[] parametersOfAddtNotificationSubscription = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodAddtNotificationSubscription, parametersOfAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            parametersOfAddtNotificationSubscription.ShouldBeNull();
            methodAddtNotificationSubscriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            Type [] methodAddtNotificationSubscriptionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAddtNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAddtNotificationSubscription);
            Type [] methodAddtNotificationSubscriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAddtNotificationSubscription, methodAddtNotificationSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAddtNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AddtNotificationSubscription) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_AddtNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_Internally(Type[] types)
        {
            var methodUpdateNotificationSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);

            // Act
            Action executeAction = () => _notificationControllerInstance.UpdateNotificationSubscription();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.UpdateNotificationSubscription();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            Type [] methodUpdateNotificationSubscriptionParametersTypes = null;
            object[] parametersOfUpdateNotificationSubscription = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfUpdateNotificationSubscription);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateNotificationSubscription, parametersOfUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateNotificationSubscription.ShouldBeNull();
            methodUpdateNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            Type [] methodUpdateNotificationSubscriptionParametersTypes = null;
            object[] parametersOfUpdateNotificationSubscription = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateNotificationSubscription, parametersOfUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            parametersOfUpdateNotificationSubscription.ShouldBeNull();
            methodUpdateNotificationSubscriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            Type [] methodUpdateNotificationSubscriptionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateNotificationSubscription);
            Type [] methodUpdateNotificationSubscriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateNotificationSubscription, methodUpdateNotificationSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateNotificationSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateNotificationSubscription) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_UpdateNotificationSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NotificationController_CheckONSService_Method_Call_Internally(Type[] types)
        {
            var methodCheckONSServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);

            // Act
            Action executeAction = () => _notificationControllerInstance.CheckONSService();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _notificationControllerInstance.CheckONSService();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;
            object[] parametersOfCheckONSService = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_notificationControllerInstanceFixture, parametersOfCheckONSService);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckONSService.ShouldBeNull();
            methodCheckONSServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;
            object[] parametersOfCheckONSService = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            parametersOfCheckONSService.ShouldBeNull();
            methodCheckONSServiceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckONSServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckONSServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationController_CheckONSService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #endregion

        #endregion
    }
}