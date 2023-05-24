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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DAL.NotificationSubscriptionForwarded" />)
    ///     and namespace <see cref="NotificationService.DAL"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NotificationSubscriptionForwardedTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationSubscriptionForwarded" />)
        /// </summary>
        public NotificationSubscriptionForwardedTest() : base(typeof(NotificationSubscriptionForwarded))
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

        #region General Initializer : Class (NotificationSubscriptionForwarded) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationSubscriptionForwardedInstanceType;
        private NotificationSubscriptionForwarded _notificationSubscriptionForwardedInstance;
        private NotificationSubscriptionForwarded _notificationSubscriptionForwardedInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationSubscriptionForwarded" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationSubscriptionForwardedInstanceType = typeof(NotificationSubscriptionForwarded);
            _notificationSubscriptionForwardedInstanceFixture = this.Create<NotificationSubscriptionForwarded>(false);
            _notificationSubscriptionForwardedInstance = _notificationSubscriptionForwardedInstanceFixture ?? this.Create<NotificationSubscriptionForwarded>(true);
            CurrentInstance = _notificationSubscriptionForwardedInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationSubscriptionForwarded) Initializer

        #region Properties

        private const string PropertyNotificationSubscriptionId = "NotificationSubscriptionId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyUserId = "UserId";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyDeleteStatus = "DeleteStatus";
        private const string PropertyNotificationSubscription = "NotificationSubscription";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationSubscriptionForwarded) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationSubscriptionForwarded_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationSubscriptionForwarded) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationSubscriptionForwarded_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NotificationSubscriptionForwarded) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationSubscriptionForwarded_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationSubscriptionForwarded)

        #region General Initializer : Class (NotificationSubscriptionForwarded) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyDeleteStatus)]
        [TestCase(PropertyNotificationSubscription)]
        [Category("AUT Property")]
        public void AUT_NotificationSubscriptionForwarded_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NotificationSubscriptionForwarded) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationSubscriptionForwarded_Is_Instance_Present_Test()
        {
            // Assert
            _notificationSubscriptionForwardedInstanceType.ShouldNotBeNull();
            _notificationSubscriptionForwardedInstance.ShouldNotBeNull();
            _notificationSubscriptionForwardedInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationSubscriptionForwarded) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationSubscriptionForwarded" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationSubscriptionForwarded_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationSubscriptionForwardedInstance.ShouldBeAssignableTo<NotificationSubscriptionForwarded>();
            _notificationSubscriptionForwardedInstanceFixture.ShouldBeAssignableTo<NotificationSubscriptionForwarded>();
            CurrentInstance.ShouldBeAssignableTo<NotificationSubscriptionForwarded>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationSubscriptionForwarded) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationSubscriptionForwarded_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationSubscriptionForwarded instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyDeleteStatus)]
        [TestCase(PropertyNotificationSubscription)]
        public void AUT_NotificationSubscriptionForwarded_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (DeleteStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_DeleteStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeleteStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyDeleteStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_notificationSubscriptionForwardedInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (NotificationSubscription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_NotificationSubscription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscription);
            Action currentAction = () => propertyInfo.SetValue(_notificationSubscriptionForwardedInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (NotificationSubscription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_NotificationSubscription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscription);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (NotificationSubscriptionId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_NotificationSubscriptionId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscriptionId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscriptionId);
            Action currentAction = () => propertyInfo.SetValue(_notificationSubscriptionForwardedInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (NotificationSubscriptionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_NotificationSubscriptionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_notificationSubscriptionForwardedInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (NotificationSubscriptionForwarded) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NotificationSubscriptionForwarded_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion
    }
}