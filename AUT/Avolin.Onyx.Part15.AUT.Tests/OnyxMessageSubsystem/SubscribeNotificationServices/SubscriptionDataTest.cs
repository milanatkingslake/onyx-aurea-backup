using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem.SubscribeNotificationServices;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem.SubscribeNotificationServices
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.SubscribeNotificationServices.SubscriptionData" />)
    ///     and namespace <see cref="OnyxMessageSubsystem.SubscribeNotificationServices"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SubscriptionDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscriptionData" />)
        /// </summary>
        public SubscriptionDataTest() : base(typeof(SubscriptionData))
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

        #region General Initializer : Class (SubscriptionData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscriptionDataInstanceType;
        private SubscriptionData _subscriptionDataInstance;
        private SubscriptionData _subscriptionDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscriptionData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscriptionDataInstanceType = typeof(SubscriptionData);
            _subscriptionDataInstanceFixture = this.Create<SubscriptionData>(false);
            _subscriptionDataInstance = _subscriptionDataInstanceFixture ?? this.Create<SubscriptionData>(true);
            CurrentInstance = _subscriptionDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscriptionData) Initializer

        #region Properties

        private const string PropertyExtensionData = "ExtensionData";
        private const string PropertyForwardedUsers = "ForwardedUsers";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyNotificationDeliveryTypeId = "NotificationDeliveryTypeId";
        private const string PropertyNotificationSubscriptionId = "NotificationSubscriptionId";
        private const string PropertyNotificationTypeId = "NotificationTypeId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyUserId = "UserId";

        #endregion

        #region Methods

        private const string MethodRaisePropertyChanged = "RaisePropertyChanged";

        #endregion

        #region Fields

        private const string FieldextensionDataField = "extensionDataField";
        private const string FieldForwardedUsersField = "ForwardedUsersField";
        private const string FieldInsertByField = "InsertByField";
        private const string FieldInsertDateField = "InsertDateField";
        private const string FieldNotificationDeliveryTypeIdField = "NotificationDeliveryTypeIdField";
        private const string FieldNotificationSubscriptionIdField = "NotificationSubscriptionIdField";
        private const string FieldNotificationTypeIdField = "NotificationTypeIdField";
        private const string FieldSiteIdField = "SiteIdField";
        private const string FieldUpdateByField = "UpdateByField";
        private const string FieldUpdateDateField = "UpdateDateField";
        private const string FieldUserIdField = "UserIdField";

        #endregion

        #endregion

        #region General Initializer : Class (SubscriptionData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscriptionData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscriptionData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscriptionData)

        #region General Initializer : Class (SubscriptionData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRaisePropertyChanged, 0)]
        public void AUT_SubscriptionData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SubscriptionData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyForwardedUsers)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyNotificationDeliveryTypeId)]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyUserId)]
        [Category("AUT Property")]
        public void AUT_SubscriptionData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SubscriptionData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldextensionDataField)]
        [TestCase(FieldForwardedUsersField)]
        [TestCase(FieldInsertByField)]
        [TestCase(FieldInsertDateField)]
        [TestCase(FieldNotificationDeliveryTypeIdField)]
        [TestCase(FieldNotificationSubscriptionIdField)]
        [TestCase(FieldNotificationTypeIdField)]
        [TestCase(FieldSiteIdField)]
        [TestCase(FieldUpdateByField)]
        [TestCase(FieldUpdateDateField)]
        [TestCase(FieldUserIdField)]
        [Category("AUT Fields")]
        public void AUT_SubscriptionData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SubscriptionData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionData_Is_Instance_Present_Test()
        {
            // Assert
            _subscriptionDataInstanceType.ShouldNotBeNull();
            _subscriptionDataInstance.ShouldNotBeNull();
            _subscriptionDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SubscriptionData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscriptionData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscriptionDataInstance.ShouldBeAssignableTo<SubscriptionData>();
            _subscriptionDataInstanceFixture.ShouldBeAssignableTo<SubscriptionData>();
            CurrentInstance.ShouldBeAssignableTo<SubscriptionData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubscriptionData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscriptionData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SubscriptionData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SubscriptionData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyForwardedUsers)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyNotificationDeliveryTypeId)]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyUserId)]
        public void AUT_SubscriptionData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SubscriptionData) => Property (ExtensionData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_ExtensionData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionData);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (ExtensionData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_ExtensionData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionData);
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (ForwardedUsers) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_ForwardedUsers_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyForwardedUsers);
            var propertyInfo = this.GetPropertyInfo(PropertyForwardedUsers);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertBy);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationDeliveryTypeId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_NotificationDeliveryTypeId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeId);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationDeliveryTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_NotificationDeliveryTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationSubscriptionId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_NotificationSubscriptionId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscriptionId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscriptionId);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationSubscriptionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_NotificationSubscriptionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscriptionId);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscriptionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationTypeId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_NotificationTypeId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeId);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (NotificationTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_NotificationTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeId);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteId);
            var propertyInfo = this.GetPropertyInfo(PropertySiteId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateBy);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionDataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionData) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionData_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserId);

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

        #region Method Call : (RaisePropertyChanged) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscriptionData_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var propertyName = this.CreateType<string>();
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRaisePropertyChanged = { propertyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, methodRaisePropertyChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_subscriptionDataInstanceFixture, parametersOfRaisePropertyChanged);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRaisePropertyChanged.ShouldNotBeNull();
            parametersOfRaisePropertyChanged.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(parametersOfRaisePropertyChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscriptionData_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var propertyName = this.CreateType<string>();
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRaisePropertyChanged = { propertyName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRaisePropertyChanged, parametersOfRaisePropertyChanged, methodRaisePropertyChangedParametersTypes);

            // Assert
            parametersOfRaisePropertyChanged.ShouldNotBeNull();
            parametersOfRaisePropertyChanged.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(parametersOfRaisePropertyChanged.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscriptionData_RaisePropertyChanged_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscriptionData_RaisePropertyChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRaisePropertyChanged, methodRaisePropertyChangedParametersTypes);

            // Assert
            methodRaisePropertyChangedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RaisePropertyChanged) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SubscriptionData_RaisePropertyChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, 0);

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