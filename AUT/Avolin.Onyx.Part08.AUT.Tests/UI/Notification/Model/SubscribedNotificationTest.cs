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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Model.SubscribedNotification" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SubscribedNotificationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscribedNotification" />)
        /// </summary>
        public SubscribedNotificationTest() : base(typeof(SubscribedNotification))
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

        #region General Initializer : Class (SubscribedNotification) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscribedNotificationInstanceType;
        private SubscribedNotification _subscribedNotificationInstance;
        private SubscribedNotification _subscribedNotificationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscribedNotification" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscribedNotificationInstanceType = typeof(SubscribedNotification);
            _subscribedNotificationInstanceFixture = this.Create<SubscribedNotification>(false);
            _subscribedNotificationInstance = _subscribedNotificationInstanceFixture ?? this.Create<SubscribedNotification>(true);
            CurrentInstance = _subscribedNotificationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscribedNotification) Initializer

        #region Properties

        private const string PropertyNotificationSubscriptionId = "NotificationSubscriptionId";
        private const string PropertyNotificationTypeName = "NotificationTypeName";
        private const string PropertyNotificationDeliveryTypeName = "NotificationDeliveryTypeName";

        #endregion

        #endregion

        #region General Initializer : Class (SubscribedNotification) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribedNotification_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscribedNotification) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribedNotification_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscribedNotification) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscribedNotification_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscribedNotification)

        #region General Initializer : Class (SubscribedNotification) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDeliveryTypeName)]
        [Category("AUT Property")]
        public void AUT_SubscribedNotification_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SubscribedNotification) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscribedNotification_Is_Instance_Present_Test()
        {
            // Assert
            _subscribedNotificationInstanceType.ShouldNotBeNull();
            _subscribedNotificationInstance.ShouldNotBeNull();
            _subscribedNotificationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SubscribedNotification) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscribedNotification" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscribedNotification_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscribedNotificationInstance.ShouldBeAssignableTo<SubscribedNotification>();
            _subscribedNotificationInstanceFixture.ShouldBeAssignableTo<SubscribedNotification>();
            CurrentInstance.ShouldBeAssignableTo<SubscribedNotification>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubscribedNotification) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscribedNotification_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SubscribedNotification instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SubscribedNotification) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDeliveryTypeName)]
        public void AUT_SubscribedNotification_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SubscribedNotification) => Property (NotificationDeliveryTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscribedNotification_Public_Class_NotificationDeliveryTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeName);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscribedNotification) => Property (NotificationSubscriptionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscribedNotification_Public_Class_NotificationSubscriptionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscribedNotification) => Property (NotificationTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscribedNotification_Public_Class_NotificationTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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