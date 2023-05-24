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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.DAL.OutlookAppointment" />)
    ///     and namespace <see cref="NotificationService.DAL"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OutlookAppointmentTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OutlookAppointment" />)
        /// </summary>
        public OutlookAppointmentTest() : base(typeof(OutlookAppointment))
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

        #region General Initializer : Class (OutlookAppointment) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _outlookAppointmentInstanceType;
        private OutlookAppointment _outlookAppointmentInstance;
        private OutlookAppointment _outlookAppointmentInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OutlookAppointment" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _outlookAppointmentInstanceType = typeof(OutlookAppointment);
            _outlookAppointmentInstanceFixture = this.Create<OutlookAppointment>(false);
            _outlookAppointmentInstance = _outlookAppointmentInstanceFixture ?? this.Create<OutlookAppointment>(true);
            CurrentInstance = _outlookAppointmentInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OutlookAppointment) Initializer

        #region Properties

        private const string PropertyOutlookAppointmentId = "OutlookAppointmentId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyDesc1 = "Desc1";
        private const string PropertySecondaryId = "SecondaryId";
        private const string PropertyProfileFileName = "ProfileFileName";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyRecordStatus = "RecordStatus";
        private const string PropertyOutlookPublishEvent = "OutlookPublishEvent";

        #endregion

        #endregion

        #region General Initializer : Class (OutlookAppointment) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookAppointment_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookAppointment) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookAppointment_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OutlookAppointment) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OutlookAppointment_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OutlookAppointment)

        #region General Initializer : Class (OutlookAppointment) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOutlookAppointmentId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyDesc1)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyProfileFileName)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(PropertyOutlookPublishEvent)]
        [Category("AUT Property")]
        public void AUT_OutlookAppointment_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OutlookAppointment) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookAppointment_Is_Instance_Present_Test()
        {
            // Assert
            _outlookAppointmentInstanceType.ShouldNotBeNull();
            _outlookAppointmentInstance.ShouldNotBeNull();
            _outlookAppointmentInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OutlookAppointment) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OutlookAppointment" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OutlookAppointment_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _outlookAppointmentInstance.ShouldBeAssignableTo<OutlookAppointment>();
            _outlookAppointmentInstanceFixture.ShouldBeAssignableTo<OutlookAppointment>();
            CurrentInstance.ShouldBeAssignableTo<OutlookAppointment>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OutlookAppointment) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OutlookAppointment_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OutlookAppointment instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OutlookAppointment) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOutlookAppointmentId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyDesc1)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyProfileFileName)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(PropertyOutlookPublishEvent)]
        public void AUT_OutlookAppointment_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (Desc1) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_Desc1_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDesc1);
            var propertyInfo = this.GetPropertyInfo(PropertyDesc1);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_outlookAppointmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (OutlookAppointmentId) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_OutlookAppointmentId_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookAppointmentId);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookAppointmentId);
            Action currentAction = () => propertyInfo.SetValue(_outlookAppointmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (OutlookAppointmentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_OutlookAppointmentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (OutlookPublishEvent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_OutlookPublishEvent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOutlookPublishEvent);
            var propertyInfo = this.GetPropertyInfo(PropertyOutlookPublishEvent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (ProfileFileName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_ProfileFileName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProfileFileName);
            var propertyInfo = this.GetPropertyInfo(PropertyProfileFileName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (RecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_RecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (SecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_SecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OutlookAppointment) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_outlookAppointmentInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (OutlookAppointment) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OutlookAppointment_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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