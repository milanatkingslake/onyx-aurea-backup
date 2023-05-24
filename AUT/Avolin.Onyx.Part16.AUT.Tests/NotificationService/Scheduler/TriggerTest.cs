using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Scheduler;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Scheduler
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Scheduler.Trigger" />)
    ///     and namespace <see cref="NotificationService.Scheduler"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TriggerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TriggerNonPublicTypeName" />) using
        ///     Using a public type <see cref="Administration" /> to
        ///     create a non-public type.
        /// </summary>
        public TriggerTest() : base(publicType: typeof(global::NotificationService.Scheduler.Administration), classNameWithNamespace: TriggerNonPublicTypeName)
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

        private Type _triggerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TriggerNonPublicTypeName = "NotificationService.Scheduler.Trigger";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _triggerInstance;
        private object _triggerInstanceFixture;

        #region General Initializer : Class (Trigger) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Trigger" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _triggerInstanceFixture = this.CreateNonPublicType(TriggerNonPublicTypeName);
            _triggerInstance = _triggerInstanceFixture;
            CurrentInstance = _triggerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Trigger) Initializer

        #region Properties

        private const string PropertyID = "ID";
        private const string PropertyStartTime = "StartTime";
        private const string PropertyStartTimeInMinutes = "StartTimeInMinutes";
        private const string PropertyEndTimeInMinutes = "EndTimeInMinutes";
        private const string PropertyDuration = "Duration";
        private const string PropertyCurrentTimeInMinutes = "CurrentTimeInMinutes";
        private const string PropertyEndTime = "EndTime";
        private const string PropertyEnabled = "Enabled";
        private const string PropertyIs24x7Trigger = "Is24x7Trigger";

        #endregion

        #region Methods

        private const string MethodMinutesFromMidNight = "MinutesFromMidNight";
        private const string MethodEquals = "Equals";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Trigger)

        #region General Initializer : Class (Trigger) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Trigger" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodMinutesFromMidNight, 0)]
        [TestCase(MethodEquals, 0)]
        [TestCase(MethodEquals, 1)]
        [Category("AUT Explore")]
        public void AUT_Trigger_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Trigger) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Trigger" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Trigger_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Trigger) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Trigger" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyID)]
        [TestCase(PropertyStartTime)]
        [TestCase(PropertyStartTimeInMinutes)]
        [TestCase(PropertyEndTimeInMinutes)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyCurrentTimeInMinutes)]
        [TestCase(PropertyEndTime)]
        [TestCase(PropertyEnabled)]
        [TestCase(PropertyIs24x7Trigger)]
        [Category("AUT Property")]
        public void AUT_Trigger_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Trigger) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Trigger" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Trigger_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Trigger) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Trigger" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Trigger_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Trigger) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyID)]
        [TestCase(PropertyStartTime)]
        [TestCase(PropertyStartTimeInMinutes)]
        [TestCase(PropertyEndTimeInMinutes)]
        [TestCase(PropertyDuration)]
        [TestCase(PropertyCurrentTimeInMinutes)]
        [TestCase(PropertyEndTime)]
        [TestCase(PropertyEnabled)]
        [TestCase(PropertyIs24x7Trigger)]
        public void AUT_Trigger_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Trigger) => Property (CurrentTimeInMinutes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_CurrentTimeInMinutes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCurrentTimeInMinutes);
            var propertyInfo = this.GetPropertyInfo(PropertyCurrentTimeInMinutes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (Duration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_Duration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDuration);
            var propertyInfo = this.GetPropertyInfo(PropertyDuration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (Enabled) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_Enabled_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnabled);
            var propertyInfo = this.GetPropertyInfo(PropertyEnabled);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (EndTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_EndTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndTime);
            var propertyInfo = this.GetPropertyInfo(PropertyEndTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (EndTimeInMinutes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_EndTimeInMinutes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndTimeInMinutes);
            var propertyInfo = this.GetPropertyInfo(PropertyEndTimeInMinutes);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (ID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_ID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyID);
            var propertyInfo = this.GetPropertyInfo(PropertyID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (Is24x7Trigger) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_Is24x7Trigger_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIs24x7Trigger);
            var propertyInfo = this.GetPropertyInfo(PropertyIs24x7Trigger);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (StartTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_StartTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartTime);
            var propertyInfo = this.GetPropertyInfo(PropertyStartTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Trigger) => Property (StartTimeInMinutes) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Trigger_Public_Class_StartTimeInMinutes_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartTimeInMinutes);
            var propertyInfo = this.GetPropertyInfo(PropertyStartTimeInMinutes);

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