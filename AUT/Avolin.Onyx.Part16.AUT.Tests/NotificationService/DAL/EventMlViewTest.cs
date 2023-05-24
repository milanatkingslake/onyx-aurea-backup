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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DAL.EventMlView" />)
    ///     and namespace <see cref="NotificationService.DAL"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class EventMlViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EventMlView" />)
        /// </summary>
        public EventMlViewTest() : base(typeof(EventMlView))
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

        #region General Initializer : Class (EventMlView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _eventMlViewInstanceType;
        private EventMlView _eventMlViewInstance;
        private EventMlView _eventMlViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EventMlView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _eventMlViewInstanceType = typeof(EventMlView);
            _eventMlViewInstanceFixture = this.Create<EventMlView>(false);
            _eventMlViewInstance = _eventMlViewInstanceFixture ?? this.Create<EventMlView>(true);
            CurrentInstance = _eventMlViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EventMlView) Initializer

        #region Properties

        private const string PropertyEventId = "EventId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyEventName = "EventName";
        private const string PropertySecondaryId = "SecondaryId";
        private const string PropertyLboObjectId = "LboObjectId";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyRecordStatus = "RecordStatus";

        #endregion

        #endregion

        #region General Initializer : Class (EventMlView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EventMlView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventMlView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EventMlView) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="EventMlView" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventMlView_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EventMlView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EventMlView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EventMlView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EventMlView)

        #region General Initializer : Class (EventMlView) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EventMlView" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEventId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyEventName)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        [Category("AUT Property")]
        public void AUT_EventMlView_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EventMlView) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EventMlView" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EventMlView_Is_Instance_Present_Test()
        {
            // Assert
            _eventMlViewInstanceType.ShouldNotBeNull();
            _eventMlViewInstance.ShouldNotBeNull();
            _eventMlViewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EventMlView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EventMlView" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EventMlView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _eventMlViewInstance.ShouldBeAssignableTo<EventMlView>();
            _eventMlViewInstanceFixture.ShouldBeAssignableTo<EventMlView>();
            CurrentInstance.ShouldBeAssignableTo<EventMlView>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EventMlView) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EventMlView_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            EventMlView instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (EventMlView) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEventId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyEventName)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        public void AUT_EventMlView_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (EventMlView) => Property (EventId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_EventId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEventId);
            Action currentAction = () => propertyInfo.SetValue(_eventMlViewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (EventId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_EventId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventId);
            var propertyInfo = this.GetPropertyInfo(PropertyEventId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (EventName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_EventName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventName);
            var propertyInfo = this.GetPropertyInfo(PropertyEventName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EventMlView) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_eventMlViewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EventMlView) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (LboObjectId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_LboObjectId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboObjectId);
            var propertyInfo = this.GetPropertyInfo(PropertyLboObjectId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (RecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_RecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRecordStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyRecordStatus);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (SecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_SecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertySecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EventMlView) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EventMlView) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_eventMlViewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EventMlView) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EventMlView_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}