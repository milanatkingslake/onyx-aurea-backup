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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.SubscriptionDataMembers" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SubscriptionDataMembersTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SubscriptionDataMembers" />)
        /// </summary>
        public SubscriptionDataMembersTest() : base(typeof(SubscriptionDataMembers))
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

        #region General Initializer : Class (SubscriptionDataMembers) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscriptionDataMembersInstanceType;
        private SubscriptionDataMembers _subscriptionDataMembersInstance;
        private SubscriptionDataMembers _subscriptionDataMembersInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SubscriptionDataMembers" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscriptionDataMembersInstanceType = typeof(SubscriptionDataMembers);
            _subscriptionDataMembersInstanceFixture = this.Create<SubscriptionDataMembers>(false);
            _subscriptionDataMembersInstance = _subscriptionDataMembersInstanceFixture ?? this.Create<SubscriptionDataMembers>(true);
            CurrentInstance = _subscriptionDataMembersInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SubscriptionDataMembers) Initializer

        #region Properties

        private const string PropertyNotificationSubscriptionId = "NotificationSubscriptionId";
        private const string PropertyNotificationTypeId = "NotificationTypeId";
        private const string PropertyNotificationDeliveryTypeId = "NotificationDeliveryTypeId";
        private const string PropertyNotificationTypeName = "NotificationTypeName";
        private const string PropertyNotificationDescription = "NotificationDescription";
        private const string PropertyNotificationDeliveryTypeName = "NotificationDeliveryTypeName";
        private const string PropertyOwnerId = "OwnerId";
        private const string PropertyOwnerName = "OwnerName";
        private const string PropertyFromEmail = "FromEmail";
        private const string PropertySubscriptionType = "SubscriptionType";

        #endregion

        #endregion

        #region General Initializer : Class (SubscriptionDataMembers) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionDataMembers_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscriptionDataMembers) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionDataMembers_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SubscriptionDataMembers) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SubscriptionDataMembers_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SubscriptionDataMembers)

        #region General Initializer : Class (SubscriptionDataMembers) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertyNotificationDeliveryTypeId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDescription)]
        [TestCase(PropertyNotificationDeliveryTypeName)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerName)]
        [TestCase(PropertyFromEmail)]
        [TestCase(PropertySubscriptionType)]
        [Category("AUT Property")]
        public void AUT_SubscriptionDataMembers_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SubscriptionDataMembers) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionDataMembers_Is_Instance_Present_Test()
        {
            // Assert
            _subscriptionDataMembersInstanceType.ShouldNotBeNull();
            _subscriptionDataMembersInstance.ShouldNotBeNull();
            _subscriptionDataMembersInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SubscriptionDataMembers) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SubscriptionDataMembers" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SubscriptionDataMembers_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscriptionDataMembersInstance.ShouldBeAssignableTo<SubscriptionDataMembers>();
            _subscriptionDataMembersInstanceFixture.ShouldBeAssignableTo<SubscriptionDataMembers>();
            CurrentInstance.ShouldBeAssignableTo<SubscriptionDataMembers>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SubscriptionDataMembers) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SubscriptionDataMembers_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SubscriptionDataMembers instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SubscriptionDataMembers) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationSubscriptionId)]
        [TestCase(PropertyNotificationTypeId)]
        [TestCase(PropertyNotificationDeliveryTypeId)]
        [TestCase(PropertyNotificationTypeName)]
        [TestCase(PropertyNotificationDescription)]
        [TestCase(PropertyNotificationDeliveryTypeName)]
        [TestCase(PropertyOwnerId)]
        [TestCase(PropertyOwnerName)]
        [TestCase(PropertyFromEmail)]
        [TestCase(PropertySubscriptionType)]
        public void AUT_SubscriptionDataMembers_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (FromEmail) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_FromEmail_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationDeliveryTypeId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_NotificationDeliveryTypeId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationDeliveryTypeId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationDeliveryTypeId);
            System.Action currentAction = () => propertyInfo.SetValue(_subscriptionDataMembersInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationDeliveryTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationDeliveryTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationDeliveryTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationDeliveryTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationSubscriptionId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_NotificationSubscriptionId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationSubscriptionId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationSubscriptionId);
            System.Action currentAction = () => propertyInfo.SetValue(_subscriptionDataMembersInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationSubscriptionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationSubscriptionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationTypeId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_NotificationTypeId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationTypeId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationTypeId);
            System.Action currentAction = () => propertyInfo.SetValue(_subscriptionDataMembersInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationTypeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationTypeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (NotificationTypeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_NotificationTypeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (OwnerId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_OwnerId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerId);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (OwnerName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_OwnerName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwnerName);
            var propertyInfo = this.GetPropertyInfo(PropertyOwnerName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SubscriptionDataMembers) => Property (SubscriptionType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SubscriptionDataMembers_Public_Class_SubscriptionType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubscriptionType);
            var propertyInfo = this.GetPropertyInfo(PropertySubscriptionType);

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