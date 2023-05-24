using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.DAL;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.DAL
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DAL.OutlookPublishEvent" />)
    ///     and namespace <see cref="NotificationService.DAL"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OutlookPublishEventTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookPublishEvent" />)
        /// </summary>
        public OutlookPublishEventTest() : base(typeof(OutlookPublishEvent))
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

        #region General Initializer : Class (OutlookPublishEvent) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookPublishEventInstanceType;
        private OutlookPublishEvent _outlookPublishEventInstance;
        private OutlookPublishEvent _outlookPublishEventInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookPublishEvent" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookPublishEventInstanceType = typeof(OutlookPublishEvent);
            _outlookPublishEventInstanceFixture = this.Create<OutlookPublishEvent>(false);
            _outlookPublishEventInstance = _outlookPublishEventInstanceFixture ?? this.Create<OutlookPublishEvent>(true);
            CurrentInstance = _outlookPublishEventInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookPublishEvent) Initializer

        #region Properties

        private const string PropertyOutlookPublishEventId = "OutlookPublishEventId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyOutlookAppointmentId = "OutlookAppointmentId";
        private const string PropertyNewUserIds = "NewUserIds";
        private const string PropertyUpdateUserIds = "UpdateUserIds";
        private const string PropertyDeleteUserIds = "DeleteUserIds";
        private const string PropertyOutlookEventData = "OutlookEventData";
        private const string PropertyStatus = "Status";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyExceptionDetails = "ExceptionDetails";
        private const string PropertyOutlookAppointment = "OutlookAppointment";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookPublishEvent) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookPublishEvent_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookPublishEvent) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookPublishEvent_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookPublishEvent) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookPublishEvent_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookPublishEvent)

        #region General Initializer : Class (OutlookPublishEvent) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOutlookPublishEventId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyOutlookAppointmentId)]
        [TestCase(PropertyNewUserIds)]
        [TestCase(PropertyUpdateUserIds)]
        [TestCase(PropertyDeleteUserIds)]
        [TestCase(PropertyOutlookEventData)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyExceptionDetails)]
        [TestCase(PropertyOutlookAppointment)]
        [Category("AUT Property")]
        public void AUT_OutlookPublishEvent_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookPublishEvent) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookPublishEvent_Is_Instance_Present_Test()
        {
            // Assert
            _outlookPublishEventInstanceType.ShouldNotBeNull();
            _outlookPublishEventInstance.ShouldNotBeNull();
            _outlookPublishEventInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookPublishEvent) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookPublishEvent" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookPublishEvent_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookPublishEventInstance.ShouldBeAssignableTo<OutlookPublishEvent>();
            _outlookPublishEventInstanceFixture.ShouldBeAssignableTo<OutlookPublishEvent>();
            CurrentInstance.ShouldBeAssignableTo<OutlookPublishEvent>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookPublishEvent) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookPublishEvent_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OutlookPublishEvent instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OutlookPublishEvent) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOutlookPublishEventId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyOutlookAppointmentId)]
        [TestCase(PropertyNewUserIds)]
        [TestCase(PropertyUpdateUserIds)]
        [TestCase(PropertyDeleteUserIds)]
        [TestCase(PropertyOutlookEventData)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyExceptionDetails)]
        [TestCase(PropertyOutlookAppointment)]
        public void AUT_OutlookPublishEvent_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (DeleteUserIds) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_DeleteUserIds_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeleteUserIds);
            var propertyInfo = this.GetPropertyInfo(PropertyDeleteUserIds);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (ExceptionDetails) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_ExceptionDetails_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptionDetails);
            var propertyInfo = this.GetPropertyInfo(PropertyExceptionDetails);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_outlookPublishEventInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (NewUserIds) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_NewUserIds_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNewUserIds);
            var propertyInfo = this.GetPropertyInfo(PropertyNewUserIds);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (OutlookAppointment) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_OutlookAppointment_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookAppointment);
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookAppointment);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (OutlookAppointmentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_OutlookAppointmentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookAppointmentId);
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookAppointmentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (OutlookEventData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_OutlookEventData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookEventData);
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookEventData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (OutlookPublishEventId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_OutlookPublishEventId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookPublishEventId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookPublishEventId);
            Action currentAction = () => propertyInfo.SetValue(_outlookPublishEventInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (OutlookPublishEventId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_OutlookPublishEventId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookPublishEventId);
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookPublishEventId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (Status) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Status_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);
            Action currentAction = () => propertyInfo.SetValue(_outlookPublishEventInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_outlookPublishEventInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookPublishEvent) => Property (UpdateUserIds) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookPublishEvent_Public_Class_UpdateUserIds_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateUserIds);
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateUserIds);

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