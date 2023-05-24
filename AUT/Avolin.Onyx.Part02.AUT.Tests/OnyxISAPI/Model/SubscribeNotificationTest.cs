using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.SubscribeNotification" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SubscribeNotificationTest : AbstractBaseSetupV3Test
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

        private const string MethodGetAvailableNotification = "GetAvailableNotification";
        private const string MethodHasPermission = "HasPermission";
        private const string MethodGetSubscribedNotification = "GetSubscribedNotification";
        private const string MethodGetUsers = "GetUsers";
        private const string MethodGetNotification = "GetNotification";
        private const string MethodSaveSubscription = "SaveSubscription";
        private const string MethodUpdateSubscription = "UpdateSubscription";
        private const string MethodDeleteSubscription = "DeleteSubscription";
        private const string MethodPublishEvent = "PublishEvent";
        private const string MethodLBOPublisher = "LBOPublisher";
        private const string MethodPublishGenericEvent = "PublishGenericEvent";
        private const string MethodCheckONSService = "CheckONSService";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

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
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

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
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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
        [TestCase(MethodGetAvailableNotification, 0)]
        [TestCase(MethodHasPermission, 0)]
        [TestCase(MethodGetSubscribedNotification, 0)]
        [TestCase(MethodGetUsers, 0)]
        [TestCase(MethodGetNotification, 0)]
        [TestCase(MethodSaveSubscription, 0)]
        [TestCase(MethodUpdateSubscription, 0)]
        [TestCase(MethodDeleteSubscription, 0)]
        [TestCase(MethodPublishEvent, 0)]
        [TestCase(MethodLBOPublisher, 0)]
        [TestCase(MethodPublishGenericEvent, 0)]
        [TestCase(MethodCheckONSService, 0)]
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
        [TestCase(FieldservicePersistence)]
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

        #region Method Call : (GetAvailableNotification) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.GetAvailableNotification();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetAvailableNotification();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            Type [] methodGetAvailableNotificationParametersTypes = null;
            object[] parametersOfGetAvailableNotification = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAvailableNotification, methodGetAvailableNotificationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfGetAvailableNotification);
            var result2 = this.GetResultOfMethod<string>(MethodGetAvailableNotification, parametersOfGetAvailableNotification, methodGetAvailableNotificationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAvailableNotification.ShouldBeNull();
            methodGetAvailableNotificationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            Type [] methodGetAvailableNotificationParametersTypes = null;
            object[] parametersOfGetAvailableNotification = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAvailableNotification, parametersOfGetAvailableNotification, methodGetAvailableNotificationParametersTypes);

            // Assert
            parametersOfGetAvailableNotification.ShouldBeNull();
            methodGetAvailableNotificationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            Type [] methodGetAvailableNotificationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAvailableNotification, methodGetAvailableNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAvailableNotificationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            Type [] methodGetAvailableNotificationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAvailableNotification, methodGetAvailableNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAvailableNotificationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAvailableNotification) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_GetAvailableNotification_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAvailableNotification);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAvailableNotification, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_HasPermission_Method_Call_Internally(Type[] types)
        {
            var methodHasPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var uiResource = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { uiResource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var uiResource = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { uiResource };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_subscribeNotificationInstanceFixture, out exception1, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var uiResource = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfHasPermission = { uiResource };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(1);
            methodHasPermissionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var methodHasPermissionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_HasPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);
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

            // Act
            Action executeAction = () => _subscribeNotificationInstance.GetSubscribedNotification();

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
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetSubscribedNotification();
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
            Type [] methodGetSubscribedNotificationParametersTypes = null;
            object[] parametersOfGetSubscribedNotification = null; // no parameter present
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
            parametersOfGetSubscribedNotification.ShouldBeNull();
            methodGetSubscribedNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetSubscribedNotificationParametersTypes = null;
            object[] parametersOfGetSubscribedNotification = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSubscribedNotification, parametersOfGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            parametersOfGetSubscribedNotification.ShouldBeNull();
            methodGetSubscribedNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetSubscribedNotificationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSubscribedNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetSubscribedNotificationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSubscribedNotification, methodGetSubscribedNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSubscribedNotificationParametersTypes.ShouldBeNull();
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

            // Act
            Action executeAction = () => _subscribeNotificationInstance.GetUsers();

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
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetUsers();
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
            Type [] methodGetUsersParametersTypes = null;
            object[] parametersOfGetUsers = null; // no parameter present
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
            parametersOfGetUsers.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
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
            Type [] methodGetUsersParametersTypes = null;
            object[] parametersOfGetUsers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUsers, parametersOfGetUsers, methodGetUsersParametersTypes);

            // Assert
            parametersOfGetUsers.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
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
            Type [] methodGetUsersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersParametersTypes.ShouldBeNull();
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
            Type [] methodGetUsersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsers, methodGetUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersParametersTypes.ShouldBeNull();
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

            // Act
            Action executeAction = () => _subscribeNotificationInstance.GetNotification();

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
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.GetNotification();
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
            Type [] methodGetNotificationParametersTypes = null;
            object[] parametersOfGetNotification = null; // no parameter present
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
            parametersOfGetNotification.ShouldBeNull();
            methodGetNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetNotificationParametersTypes = null;
            object[] parametersOfGetNotification = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetNotification, parametersOfGetNotification, methodGetNotificationParametersTypes);

            // Assert
            parametersOfGetNotification.ShouldBeNull();
            methodGetNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetNotificationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNotificationParametersTypes.ShouldBeNull();
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
            Type [] methodGetNotificationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNotification, methodGetNotificationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNotificationParametersTypes.ShouldBeNull();
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

        #region Method Call : (SaveSubscription) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_SaveSubscription_Method_Call_Internally(Type[] types)
        {
            var methodSaveSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.SaveSubscription();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.SaveSubscription();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            Type [] methodSaveSubscriptionParametersTypes = null;
            object[] parametersOfSaveSubscription = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveSubscription, methodSaveSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfSaveSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveSubscription.ShouldBeNull();
            methodSaveSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            Type [] methodSaveSubscriptionParametersTypes = null;
            object[] parametersOfSaveSubscription = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveSubscription, parametersOfSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            parametersOfSaveSubscription.ShouldBeNull();
            methodSaveSubscriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            Type [] methodSaveSubscriptionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_SaveSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveSubscription);
            Type [] methodSaveSubscriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveSubscription, methodSaveSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveSubscription) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (UpdateSubscription) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.UpdateSubscription();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.UpdateSubscription();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            Type [] methodUpdateSubscriptionParametersTypes = null;
            object[] parametersOfUpdateSubscription = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfUpdateSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSubscription.ShouldBeNull();
            methodUpdateSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            Type [] methodUpdateSubscriptionParametersTypes = null;
            object[] parametersOfUpdateSubscription = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateSubscription, parametersOfUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            parametersOfUpdateSubscription.ShouldBeNull();
            methodUpdateSubscriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            Type [] methodUpdateSubscriptionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_UpdateSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSubscription);
            Type [] methodUpdateSubscriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSubscription, methodUpdateSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSubscription) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (DeleteSubscription) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSubscriptionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.DeleteSubscription();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.DeleteSubscription();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            Type [] methodDeleteSubscriptionParametersTypes = null;
            object[] parametersOfDeleteSubscription = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfDeleteSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteSubscription.ShouldBeNull();
            methodDeleteSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            Type [] methodDeleteSubscriptionParametersTypes = null;
            object[] parametersOfDeleteSubscription = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDeleteSubscription, parametersOfDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            parametersOfDeleteSubscription.ShouldBeNull();
            methodDeleteSubscriptionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            Type [] methodDeleteSubscriptionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_DeleteSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSubscription);
            Type [] methodDeleteSubscriptionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSubscription, methodDeleteSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSubscriptionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteSubscription) (Return Type : string) without parameters value verify result should be null.

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

        #region Method Call : (PublishEvent) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_PublishEvent_Method_Call_Internally(Type[] types)
        {
            var methodPublishEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPublishEvent, methodPublishEventParametersTypes);
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.PublishEvent();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.PublishEvent();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            Type [] methodPublishEventParametersTypes = null;
            object[] parametersOfPublishEvent = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPublishEvent, methodPublishEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfPublishEvent);
            var result2 = this.GetResultOfMethod<string>(MethodPublishEvent, parametersOfPublishEvent, methodPublishEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPublishEvent.ShouldBeNull();
            methodPublishEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            Type [] methodPublishEventParametersTypes = null;
            object[] parametersOfPublishEvent = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPublishEvent, parametersOfPublishEvent, methodPublishEventParametersTypes);

            // Assert
            parametersOfPublishEvent.ShouldBeNull();
            methodPublishEventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            Type [] methodPublishEventParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPublishEvent, methodPublishEventParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPublishEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            Type [] methodPublishEventParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPublishEvent, methodPublishEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPublishEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishEvent) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishEvent_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodPublishEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_LBOPublisher_Method_Call_Internally(Type[] types)
        {
            var methodLBOPublisherParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLBOPublisher, methodLBOPublisherParametersTypes);
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.LBOPublisher();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.LBOPublisher();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            Type [] methodLBOPublisherParametersTypes = null;
            object[] parametersOfLBOPublisher = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLBOPublisher, methodLBOPublisherParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfLBOPublisher);
            var result2 = this.GetResultOfMethod<string>(MethodLBOPublisher, parametersOfLBOPublisher, methodLBOPublisherParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfLBOPublisher.ShouldBeNull();
            methodLBOPublisherParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            Type [] methodLBOPublisherParametersTypes = null;
            object[] parametersOfLBOPublisher = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodLBOPublisher, parametersOfLBOPublisher, methodLBOPublisherParametersTypes);

            // Assert
            parametersOfLBOPublisher.ShouldBeNull();
            methodLBOPublisherParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            Type [] methodLBOPublisherParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLBOPublisher, methodLBOPublisherParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodLBOPublisherParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            Type [] methodLBOPublisherParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLBOPublisher, methodLBOPublisherParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLBOPublisherParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LBOPublisher) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_LBOPublisher_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLBOPublisher);
            var currentMethodInfo = this.GetMethodInfo(MethodLBOPublisher, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_Internally(Type[] types)
        {
            var methodPublishGenericEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPublishGenericEvent, methodPublishGenericEventParametersTypes);
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.PublishGenericEvent();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.PublishGenericEvent();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            Type [] methodPublishGenericEventParametersTypes = null;
            object[] parametersOfPublishGenericEvent = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPublishGenericEvent, methodPublishGenericEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfPublishGenericEvent);
            var result2 = this.GetResultOfMethod<string>(MethodPublishGenericEvent, parametersOfPublishGenericEvent, methodPublishGenericEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPublishGenericEvent.ShouldBeNull();
            methodPublishGenericEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            Type [] methodPublishGenericEventParametersTypes = null;
            object[] parametersOfPublishGenericEvent = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPublishGenericEvent, parametersOfPublishGenericEvent, methodPublishGenericEventParametersTypes);

            // Assert
            parametersOfPublishGenericEvent.ShouldBeNull();
            methodPublishGenericEventParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            Type [] methodPublishGenericEventParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPublishGenericEvent, methodPublishGenericEventParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPublishGenericEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            Type [] methodPublishGenericEventParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPublishGenericEvent, methodPublishGenericEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPublishGenericEventParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishGenericEvent) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_PublishGenericEvent_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishGenericEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodPublishGenericEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SubscribeNotification_CheckONSService_Method_Call_Internally(Type[] types)
        {
            var methodCheckONSServiceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCheckONSService, methodCheckONSServiceParametersTypes);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);

            // Act
            Action executeAction = () => _subscribeNotificationInstance.CheckONSService();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _subscribeNotificationInstance.CheckONSService();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;
            object[] parametersOfCheckONSService = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckONSService, methodCheckONSServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_subscribeNotificationInstanceFixture, parametersOfCheckONSService);
            var result2 = this.GetResultOfMethod<string>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckONSService.ShouldBeNull();
            methodCheckONSServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckONSService);
            Type [] methodCheckONSServiceParametersTypes = null;
            object[] parametersOfCheckONSService = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCheckONSService, parametersOfCheckONSService, methodCheckONSServiceParametersTypes);

            // Assert
            parametersOfCheckONSService.ShouldBeNull();
            methodCheckONSServiceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckONSService) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (CheckONSService) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscribeNotification_CheckONSService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (CheckONSService) (Return Type : string) without parameters value verify result should be null.

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

        #endregion

        #endregion
    }
}