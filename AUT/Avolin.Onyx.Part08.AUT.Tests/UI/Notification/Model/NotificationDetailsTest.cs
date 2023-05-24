using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Model.NotificationDetails" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NotificationDetailsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationDetails" />)
        /// </summary>
        public NotificationDetailsTest() : base(typeof(NotificationDetails))
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

        #region General Initializer : Class (NotificationDetails) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationDetailsInstanceType;
        private NotificationDetails _notificationDetailsInstance;
        private NotificationDetails _notificationDetailsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationDetails" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationDetailsInstanceType = typeof(NotificationDetails);
            _notificationDetailsInstanceFixture = this.Create<NotificationDetails>(false);
            _notificationDetailsInstance = _notificationDetailsInstanceFixture ?? this.Create<NotificationDetails>(true);
            CurrentInstance = _notificationDetailsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationDetails) Initializer

        #region Properties

        private const string PropertyNotificationTypeSelectedItem = "NotificationTypeSelectedItem";
        private const string PropertyUsersbySemicolon = "UsersbySemicolon";
        private const string PropertyNotificationDeliveryTypeSelectedItem = "NotificationDeliveryTypeSelectedItem";
        private const string PropertynotificationTypes = "notificationTypes";
        private const string PropertynotificationDeliveryTypes = "notificationDeliveryTypes";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationDetails) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationDetails_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationDetails) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationDetails_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationDetails) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationDetails_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationDetails)

        #region General Initializer : Class (NotificationDetails) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationTypeSelectedItem)]
        [TestCase(PropertyUsersbySemicolon)]
        [TestCase(PropertyNotificationDeliveryTypeSelectedItem)]
        [TestCase(PropertynotificationTypes)]
        [TestCase(PropertynotificationDeliveryTypes)]
        [Category("AUT Property")]
        public void AUT_NotificationDetails_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NotificationDetails) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationDetails_Is_Instance_Present_Test()
        {
            // Assert
            _notificationDetailsInstanceType.ShouldNotBeNull();
            _notificationDetailsInstance.ShouldNotBeNull();
            _notificationDetailsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationDetails) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationDetails" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationDetails_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationDetailsInstance.ShouldBeAssignableTo<NotificationDetails>();
            _notificationDetailsInstanceFixture.ShouldBeAssignableTo<NotificationDetails>();
            CurrentInstance.ShouldBeAssignableTo<NotificationDetails>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationDetails) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationDetails_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationDetails instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NotificationDetails) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationTypeSelectedItem)]
        [TestCase(PropertyUsersbySemicolon)]
        [TestCase(PropertyNotificationDeliveryTypeSelectedItem)]
        [TestCase(PropertynotificationTypes)]
        [TestCase(PropertynotificationDeliveryTypes)]
        public void AUT_NotificationDetails_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NotificationDetails) => Property (notificationDeliveryTypes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_Public_Class_notificationDeliveryTypes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynotificationDeliveryTypes);
            var propertyInfo = this.GetPropertyInfo(PropertynotificationDeliveryTypes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (NotificationDeliveryTypeSelectedItem) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_NotificationDeliveryTypeSelectedItem_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeSelectedItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeSelectedItem);
            Action currentAction = () => propertyInfo.SetValue(_notificationDetailsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (NotificationDeliveryTypeSelectedItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_Public_Class_NotificationDeliveryTypeSelectedItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeSelectedItem);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeSelectedItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (notificationTypes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_Public_Class_notificationTypes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertynotificationTypes);
            var propertyInfo = this.GetPropertyInfo(PropertynotificationTypes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (NotificationTypeSelectedItem) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_NotificationTypeSelectedItem_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeSelectedItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeSelectedItem);
            Action currentAction = () => propertyInfo.SetValue(_notificationDetailsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (NotificationTypeSelectedItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_Public_Class_NotificationTypeSelectedItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeSelectedItem);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeSelectedItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationDetails) => Property (UsersbySemicolon) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationDetails_Public_Class_UsersbySemicolon_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUsersbySemicolon);
            var propertyInfo = this.GetPropertyInfo(PropertyUsersbySemicolon);

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