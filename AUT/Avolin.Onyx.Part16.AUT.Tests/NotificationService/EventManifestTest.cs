using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.EventManifest" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EventManifestTest : AbstractBaseSetupV3Test
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

        private const string PropertyNeedAck = "NeedAck";
        private const string PropertyIsSubscriptionRequired = "IsSubscriptionRequired";
        private const string PropertyEventType = "EventType";
        private const string PropertySysData = "SysData";
        private const string PropertyAppData = "AppData";
        private const string PropertyUser_id = "User_id";
        private const string PropertyNotification_id = "Notification_id";

        #endregion

        #region Fields

        private const string FieldneedAck = "needAck";
        private const string FieldeventType = "eventType";
        private const string FieldsysData = "sysData";
        private const string FieldappData = "appData";
        private const string Fieldnotification_id = "notification_id";
        private const string Fielduser_id = "user_id";
        private const string FieldisSubscriptionRequired = "isSubscriptionRequired";

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
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

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
            System.Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

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
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EventManifest)

        #region General Initializer : Class (EventManifest) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EventManifest" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNeedAck)]
        [TestCase(PropertyIsSubscriptionRequired)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertySysData)]
        [TestCase(PropertyAppData)]
        [TestCase(PropertyUser_id)]
        [TestCase(PropertyNotification_id)]
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
        [TestCase(FieldneedAck)]
        [TestCase(FieldeventType)]
        [TestCase(FieldsysData)]
        [TestCase(FieldappData)]
        [TestCase(Fieldnotification_id)]
        [TestCase(Fielduser_id)]
        [TestCase(FieldisSubscriptionRequired)]
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
        [TestCase(PropertyNeedAck)]
        [TestCase(PropertyIsSubscriptionRequired)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertySysData)]
        [TestCase(PropertyAppData)]
        [TestCase(PropertyUser_id)]
        [TestCase(PropertyNotification_id)]
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
            System.Action currentAction = () => propertyInfo.SetValue(_eventManifestInstance, randomString, null);

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

        #endregion
    }
}