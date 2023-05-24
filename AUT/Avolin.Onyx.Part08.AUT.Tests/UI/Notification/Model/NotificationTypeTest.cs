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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Model.NotificationType" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NotificationTypeTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationType" />)
        /// </summary>
        public NotificationTypeTest() : base(typeof(NotificationType))
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

        #region General Initializer : Class (NotificationType) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationTypeInstanceType;
        private NotificationType _notificationTypeInstance;
        private NotificationType _notificationTypeInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationType" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationTypeInstanceType = typeof(NotificationType);
            _notificationTypeInstanceFixture = this.Create<NotificationType>(false);
            _notificationTypeInstance = _notificationTypeInstanceFixture ?? this.Create<NotificationType>(true);
            CurrentInstance = _notificationTypeInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationType) Initializer

        #region Properties

        private const string PropertyNotificationTypeId = "NotificationTypeId";
        private const string PropertyNotificationTypeName = "NotificationTypeName";
        private const string PropertyNotificationDescription = "NotificationDescription";
        private const string PropertyFromEmail = "FromEmail";
        private const string PropertyDefaultDeliveryType = "DefaultDeliveryType";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationType) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationType" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationType_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationType) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NotificationType" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationType_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationType) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationType" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationType_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationType)

        #region General Initializer : Class (NotificationType) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationType" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDescription)]
        [TestCase(PropertyFromEmail)]
        [TestCase(PropertyDefaultDeliveryType)]
        [Category("AUT Property")]
        public void AUT_NotificationType_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NotificationType) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationType" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationType_Is_Instance_Present_Test()
        {
            // Assert
            _notificationTypeInstanceType.ShouldNotBeNull();
            _notificationTypeInstance.ShouldNotBeNull();
            _notificationTypeInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationType) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationType" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationType_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationTypeInstance.ShouldBeAssignableTo<NotificationType>();
            _notificationTypeInstanceFixture.ShouldBeAssignableTo<NotificationType>();
            CurrentInstance.ShouldBeAssignableTo<NotificationType>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationType) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationType_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationType instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NotificationType) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDescription)]
        [TestCase(PropertyFromEmail)]
        [TestCase(PropertyDefaultDeliveryType)]
        public void AUT_NotificationType_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NotificationType) => Property (DefaultDeliveryType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationType_Public_Class_DefaultDeliveryType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultDeliveryType);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultDeliveryType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationType) => Property (FromEmail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationType_Public_Class_FromEmail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFromEmail);
            var propertyInfo = this.GetPropertyInfo(PropertyFromEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationType) => Property (NotificationDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationType_Public_Class_NotificationDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationType) => Property (NotificationTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationType_Public_Class_NotificationTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationType) => Property (NotificationTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationType_Public_Class_NotificationTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeName);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeName);

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