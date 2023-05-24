using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.Subscription" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SubscriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Subscription" />)
        /// </summary>
        public SubscriptionTest() : base(typeof(Subscription))
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

        #region General Initializer : Class (Subscription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _subscriptionInstanceType;
        private Subscription _subscriptionInstance;
        private Subscription _subscriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Subscription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _subscriptionInstanceType = typeof(Subscription);
            _subscriptionInstanceFixture = this.Create<Subscription>(false);
            _subscriptionInstance = _subscriptionInstanceFixture ?? this.Create<Subscription>(true);
            CurrentInstance = _subscriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Subscription) Initializer

        #region Properties

        private const string PropertySubscriptionID = "SubscriptionID";
        private const string PropertyOwner = "Owner";
        private const string PropertyPath = "Path";
        private const string PropertyVirtualPath = "VirtualPath";
        private const string PropertyReport = "Report";
        private const string PropertyDeliverySettings = "DeliverySettings";
        private const string PropertyDescription = "Description";
        private const string PropertyStatus = "Status";
        private const string PropertyActive = "Active";
        private const string PropertyLastExecuted = "LastExecuted";
        private const string PropertyLastExecutedSpecified = "LastExecutedSpecified";
        private const string PropertyModifiedBy = "ModifiedBy";
        private const string PropertyModifiedDate = "ModifiedDate";
        private const string PropertyEventType = "EventType";
        private const string PropertyIsDataDriven = "IsDataDriven";

        #endregion

        #region Fields

        private const string FieldsubscriptionIDField = "subscriptionIDField";
        private const string FieldownerField = "ownerField";
        private const string FieldpathField = "pathField";
        private const string FieldvirtualPathField = "virtualPathField";
        private const string FieldreportField = "reportField";
        private const string FielddeliverySettingsField = "deliverySettingsField";
        private const string FielddescriptionField = "descriptionField";
        private const string FieldstatusField = "statusField";
        private const string FieldactiveField = "activeField";
        private const string FieldlastExecutedField = "lastExecutedField";
        private const string FieldlastExecutedFieldSpecified = "lastExecutedFieldSpecified";
        private const string FieldmodifiedByField = "modifiedByField";
        private const string FieldmodifiedDateField = "modifiedDateField";
        private const string FieldeventTypeField = "eventTypeField";
        private const string FieldisDataDrivenField = "isDataDrivenField";

        #endregion

        #endregion

        #region General Initializer : Class (Subscription) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Subscription" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Subscription_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Subscription) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Subscription" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Subscription_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Subscription) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Subscription" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Subscription_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Subscription)

        #region General Initializer : Class (Subscription) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Subscription" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertySubscriptionID)]
        [TestCase(PropertyOwner)]
        [TestCase(PropertyPath)]
        [TestCase(PropertyVirtualPath)]
        [TestCase(PropertyReport)]
        [TestCase(PropertyDeliverySettings)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyLastExecuted)]
        [TestCase(PropertyLastExecutedSpecified)]
        [TestCase(PropertyModifiedBy)]
        [TestCase(PropertyModifiedDate)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyIsDataDriven)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_Subscription_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Subscription) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Subscription" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldsubscriptionIDField)]
        [TestCase(FieldownerField)]
        [TestCase(FieldpathField)]
        [TestCase(FieldvirtualPathField)]
        [TestCase(FieldreportField)]
        [TestCase(FielddeliverySettingsField)]
        [TestCase(FielddescriptionField)]
        [TestCase(FieldstatusField)]
        [TestCase(FieldactiveField)]
        [TestCase(FieldlastExecutedField)]
        [TestCase(FieldlastExecutedFieldSpecified)]
        [TestCase(FieldmodifiedByField)]
        [TestCase(FieldmodifiedDateField)]
        [TestCase(FieldeventTypeField)]
        [TestCase(FieldisDataDrivenField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_Subscription_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Subscription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Subscription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_Subscription_Is_Instance_Present_Test()
        {
            // Assert
            _subscriptionInstanceType.ShouldNotBeNull();
            _subscriptionInstance.ShouldNotBeNull();
            _subscriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Subscription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Subscription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_Subscription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _subscriptionInstance.ShouldBeAssignableTo<Subscription>();
            _subscriptionInstanceFixture.ShouldBeAssignableTo<Subscription>();
            CurrentInstance.ShouldBeAssignableTo<Subscription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Subscription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_Subscription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Subscription instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Subscription) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertySubscriptionID)]
        [TestCase(PropertyOwner)]
        [TestCase(PropertyPath)]
        [TestCase(PropertyVirtualPath)]
        [TestCase(PropertyReport)]
        [TestCase(PropertyDeliverySettings)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyActive)]
        [TestCase(PropertyLastExecuted)]
        [TestCase(PropertyLastExecutedSpecified)]
        [TestCase(PropertyModifiedBy)]
        [TestCase(PropertyModifiedDate)]
        [TestCase(PropertyEventType)]
        [TestCase(PropertyIsDataDriven)]
        public void AUT_Subscription_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Subscription) => Property (Active) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Active_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyActive);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActive);
            var propertyInfo = this.GetPropertyInfo(PropertyActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (DeliverySettings) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_DeliverySettings_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeliverySettings);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDeliverySettings);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (DeliverySettings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_DeliverySettings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDeliverySettings);
            var propertyInfo = this.GetPropertyInfo(PropertyDeliverySettings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (EventType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_EventType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (Subscription) => Property (IsDataDriven) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_IsDataDriven_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsDataDriven);
            var propertyInfo = this.GetPropertyInfo(PropertyIsDataDriven);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (LastExecuted) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_LastExecuted_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastExecuted);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyLastExecuted);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (LastExecuted) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_LastExecuted_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastExecuted);
            var propertyInfo = this.GetPropertyInfo(PropertyLastExecuted);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (LastExecutedSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_LastExecutedSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastExecutedSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyLastExecutedSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (ModifiedBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_ModifiedBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedBy);
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedBy);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (ModifiedDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_ModifiedDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedDate);
            Action currentAction = () => propertyInfo.SetValue(_subscriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (ModifiedDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_ModifiedDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyModifiedDate);
            var propertyInfo = this.GetPropertyInfo(PropertyModifiedDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Owner) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Owner_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOwner);
            var propertyInfo = this.GetPropertyInfo(PropertyOwner);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Path) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Path_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPath);
            var propertyInfo = this.GetPropertyInfo(PropertyPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Report) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Report_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReport);
            var propertyInfo = this.GetPropertyInfo(PropertyReport);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (Subscription) => Property (SubscriptionID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_SubscriptionID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySubscriptionID);
            var propertyInfo = this.GetPropertyInfo(PropertySubscriptionID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Subscription) => Property (VirtualPath) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Subscription_Public_Class_VirtualPath_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyVirtualPath);
            var propertyInfo = this.GetPropertyInfo(PropertyVirtualPath);

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