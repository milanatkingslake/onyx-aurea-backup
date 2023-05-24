using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.CalendarProperties" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CalendarPropertiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="CalendarPropertiesNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public CalendarPropertiesTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: CalendarPropertiesNonPublicTypeName)
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

        private Type _calendarPropertiesInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string CalendarPropertiesNonPublicTypeName = "NotificationService.Administration.CalendarProperties";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _calendarPropertiesInstance;
        private object _calendarPropertiesInstanceFixture;

        #region General Initializer : Class (CalendarProperties) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="CalendarProperties" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _calendarPropertiesInstanceFixture = this.CreateNonPublicType(CalendarPropertiesNonPublicTypeName);
            _calendarPropertiesInstance = _calendarPropertiesInstanceFixture;
            CurrentInstance = _calendarPropertiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CalendarProperties) Initializer

        #region Properties

        private const string PropertySubject = "Subject";
        private const string PropertyBody = "Body";
        private const string PropertyAppointmentStartTime = "AppointmentStartTime";
        private const string PropertyAppointmentEndTime = "AppointmentEndTime";
        private const string PropertyStartTimeZone = "StartTimeZone";
        private const string PropertyIsHtmlBody = "IsHtmlBody";
        private const string PropertyAppointmentId = "AppointmentId";
        private const string PropertyNewUserList = "NewUserList";
        private const string PropertyUpdateUserList = "UpdateUserList";
        private const string PropertyDeleteUserList = "DeleteUserList";
        private const string PropertyEventData = "EventData";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (CalendarProperties)

        #region General Initializer : Class (CalendarProperties) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CalendarProperties" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CalendarProperties_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CalendarProperties) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CalendarProperties" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySubject)]
        [TestCase(PropertyBody)]
        [TestCase(PropertyAppointmentStartTime)]
        [TestCase(PropertyAppointmentEndTime)]
        [TestCase(PropertyStartTimeZone)]
        [TestCase(PropertyIsHtmlBody)]
        [TestCase(PropertyAppointmentId)]
        [TestCase(PropertyNewUserList)]
        [TestCase(PropertyUpdateUserList)]
        [TestCase(PropertyDeleteUserList)]
        [TestCase(PropertyEventData)]
        [Category("AUT Property")]
        public void AUT_CalendarProperties_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CalendarProperties) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CalendarProperties" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CalendarProperties_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (CalendarProperties) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CalendarProperties" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CalendarProperties_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CalendarProperties) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySubject)]
        [TestCase(PropertyBody)]
        [TestCase(PropertyAppointmentStartTime)]
        [TestCase(PropertyAppointmentEndTime)]
        [TestCase(PropertyStartTimeZone)]
        [TestCase(PropertyIsHtmlBody)]
        [TestCase(PropertyAppointmentId)]
        [TestCase(PropertyNewUserList)]
        [TestCase(PropertyUpdateUserList)]
        [TestCase(PropertyDeleteUserList)]
        [TestCase(PropertyEventData)]
        public void AUT_CalendarProperties_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CalendarProperties) => Property (AppointmentEndTime) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_AppointmentEndTime_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppointmentEndTime);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAppointmentEndTime);
            Action currentAction = () => propertyInfo.SetValue(_calendarPropertiesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (AppointmentEndTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_AppointmentEndTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppointmentEndTime);
            var propertyInfo = this.GetPropertyInfo(PropertyAppointmentEndTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (AppointmentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_AppointmentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppointmentId);
            var propertyInfo = this.GetPropertyInfo(PropertyAppointmentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (AppointmentStartTime) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_AppointmentStartTime_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppointmentStartTime);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyAppointmentStartTime);
            Action currentAction = () => propertyInfo.SetValue(_calendarPropertiesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (AppointmentStartTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_AppointmentStartTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppointmentStartTime);
            var propertyInfo = this.GetPropertyInfo(PropertyAppointmentStartTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (Body) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_Body_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBody);
            var propertyInfo = this.GetPropertyInfo(PropertyBody);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (DeleteUserList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_DeleteUserList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeleteUserList);
            var propertyInfo = this.GetPropertyInfo(PropertyDeleteUserList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (EventData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_EventData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventData);
            var propertyInfo = this.GetPropertyInfo(PropertyEventData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (IsHtmlBody) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_IsHtmlBody_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsHtmlBody);
            var propertyInfo = this.GetPropertyInfo(PropertyIsHtmlBody);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (NewUserList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_NewUserList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNewUserList);
            var propertyInfo = this.GetPropertyInfo(PropertyNewUserList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (StartTimeZone) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_StartTimeZone_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartTimeZone);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStartTimeZone);
            Action currentAction = () => propertyInfo.SetValue(_calendarPropertiesInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (StartTimeZone) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_StartTimeZone_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartTimeZone);
            var propertyInfo = this.GetPropertyInfo(PropertyStartTimeZone);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (Subject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_Subject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubject);
            var propertyInfo = this.GetPropertyInfo(PropertySubject);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CalendarProperties) => Property (UpdateUserList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CalendarProperties_Public_Class_UpdateUserList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateUserList);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateUserList);

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