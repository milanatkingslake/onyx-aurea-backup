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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest" />)
    ///     and namespace <see cref="OnyxMessageSubsystem.SubscribeNotificationServices"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class EventManifestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EventManifest" />)
        /// </summary>
        public EventManifestTest() : base(typeof(EventManifest))
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

        #region General Initializer : Class (EventManifest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _eventManifestInstanceType;
        private EventManifest _eventManifestInstance;
        private EventManifest _eventManifestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EventManifest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _eventManifestInstanceType = typeof(EventManifest);
            _eventManifestInstanceFixture = this.Create<EventManifest>(false);
            _eventManifestInstance = _eventManifestInstanceFixture ?? this.Create<EventManifest>(true);
            CurrentInstance = _eventManifestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EventManifest) Initializer

        #region Properties

        private const string PropertyExtensionData = "ExtensionData";
        private const string PropertyAppData = "AppData";
        private const string PropertyEventType = "EventType";
        private const string PropertyIsSubscriptionRequired = "IsSubscriptionRequired";
        private const string PropertyNeedAck = "NeedAck";
        private const string PropertyNotification_id = "Notification_id";
        private const string PropertySysData = "SysData";
        private const string PropertyUser_id = "User_id";

        #endregion

        #region Methods

        private const string MethodRaisePropertyChanged = "RaisePropertyChanged";

        #endregion

        #region Fields

        private const string FieldextensionDataField = "extensionDataField";
        private const string FieldAppDataField = "AppDataField";
        private const string FieldEventTypeField = "EventTypeField";
        private const string FieldIsSubscriptionRequiredField = "IsSubscriptionRequiredField";
        private const string FieldNeedAckField = "NeedAckField";
        private const string FieldNotification_idField = "Notification_idField";
        private const string FieldSysDataField = "SysDataField";
        private const string FieldUser_idField = "User_idField";

        #endregion

        #endregion

        #region General Initializer : Class (EventManifest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventManifest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EventManifest) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventManifest_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EventManifest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventManifest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EventManifest)

        #region General Initializer : Class (EventManifest) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodRaisePropertyChanged, 0)]
        public void AUT_EventManifest_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (EventManifest) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyAppData)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyIsSubscriptionRequired)]
        [TestCase(PropertyNeedAck)]
        [TestCase(PropertyNotification_id)]
        [TestCase(PropertySysData)]
        [TestCase(PropertyUser_id)]
        [Category("AUT Property")]
        public void AUT_EventManifest_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (EventManifest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldextensionDataField)]
        [TestCase(FieldAppDataField)]
        [TestCase(FieldEventTypeField)]
        [TestCase(FieldIsSubscriptionRequiredField)]
        [TestCase(FieldNeedAckField)]
        [TestCase(FieldNotification_idField)]
        [TestCase(FieldSysDataField)]
        [TestCase(FieldUser_idField)]
        [Category("AUT Fields")]
        public void AUT_EventManifest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EventManifest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EventManifest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EventManifest_Is_Instance_Present_Test()
        {
            // Assert
            _eventManifestInstanceType.ShouldNotBeNull();
            _eventManifestInstance.ShouldNotBeNull();
            _eventManifestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EventManifest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EventManifest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EventManifest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _eventManifestInstance.ShouldBeAssignableTo<EventManifest>();
            _eventManifestInstanceFixture.ShouldBeAssignableTo<EventManifest>();
            CurrentInstance.ShouldBeAssignableTo<EventManifest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EventManifest) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EventManifest_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            EventManifest instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (EventManifest) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyExtensionData)]
        [TestCase(PropertyAppData)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyIsSubscriptionRequired)]
        [TestCase(PropertyNeedAck)]
        [TestCase(PropertyNotification_id)]
        [TestCase(PropertySysData)]
        [TestCase(PropertyUser_id)]
        public void AUT_EventManifest_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (EventManifest) => Property (AppData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_AppData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppData);
            var propertyInfo = this.GetPropertyInfo(PropertyAppData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (EventType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_EventType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventType);
            var propertyInfo = this.GetPropertyInfo(PropertyEventType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (ExtensionData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_ExtensionData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExtensionData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExtensionData);
            Action currentAction = () => propertyInfo.SetValue(_eventManifestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (ExtensionData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_ExtensionData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EventManifest) => Property (IsSubscriptionRequired) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_IsSubscriptionRequired_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSubscriptionRequired);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSubscriptionRequired);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (NeedAck) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_NeedAck_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNeedAck);
            var propertyInfo = this.GetPropertyInfo(PropertyNeedAck);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (Notification_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_Notification_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotification_id);
            var propertyInfo = this.GetPropertyInfo(PropertyNotification_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (SysData) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_SysData_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySysData);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertySysData);
            Action currentAction = () => propertyInfo.SetValue(_eventManifestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (SysData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_SysData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySysData);
            var propertyInfo = this.GetPropertyInfo(PropertySysData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (User_id) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_User_id_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser_id);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUser_id);
            Action currentAction = () => propertyInfo.SetValue(_eventManifestInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventManifest) => Property (User_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventManifest_Public_Class_User_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser_id);
            var propertyInfo = this.GetPropertyInfo(PropertyUser_id);

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
        public void AUT_EventManifest_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRaisePropertyChanged);
            var propertyName = this.CreateType<string>();
            var methodRaisePropertyChangedParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRaisePropertyChanged = { propertyName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRaisePropertyChanged, methodRaisePropertyChangedParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_eventManifestInstanceFixture, parametersOfRaisePropertyChanged);

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
        public void AUT_EventManifest_RaisePropertyChanged_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
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
        public void AUT_EventManifest_RaisePropertyChanged_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_EventManifest_RaisePropertyChanged_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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
        public void AUT_EventManifest_RaisePropertyChanged_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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