using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.TemplateData" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TemplateDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TemplateDataNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public TemplateDataTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: TemplateDataNonPublicTypeName)
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

        private Type _templateDataInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TemplateDataNonPublicTypeName = "NotificationService.Administration.TemplateData";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _templateDataInstance;
        private object _templateDataInstanceFixture;

        #region General Initializer : Class (TemplateData) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="TemplateData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _templateDataInstanceFixture = this.CreateNonPublicType(TemplateDataNonPublicTypeName);
            _templateDataInstance = _templateDataInstanceFixture;
            CurrentInstance = _templateDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TemplateData) Initializer

        #region Properties

        private const string PropertyNotificationID = "NotificationID";
        private const string PropertyTitle = "Title";
        private const string PropertyEventData = "EventData";
        private const string PropertyOutlookEventData = "OutlookEventData";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (TemplateData)

        #region General Initializer : Class (TemplateData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TemplateData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TemplateData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TemplateData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TemplateData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNotificationID)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyEventData)]
        [TestCase(PropertyOutlookEventData)]
        [Category("AUT Property")]
        public void AUT_TemplateData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TemplateData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TemplateData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TemplateData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TemplateData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TemplateData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TemplateData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TemplateData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNotificationID)]
        [TestCase(PropertyTitle)]
        [TestCase(PropertyEventData)]
        [TestCase(PropertyOutlookEventData)]
        public void AUT_TemplateData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TemplateData) => Property (EventData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateData_Public_Class_EventData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEventData);
            var propertyInfo = this.GetPropertyInfo(PropertyEventData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TemplateData) => Property (NotificationID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateData_Public_Class_NotificationID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNotificationID);
            var propertyInfo = this.GetPropertyInfo(PropertyNotificationID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TemplateData) => Property (OutlookEventData) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateData_Public_Class_OutlookEventData_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TemplateData) => Property (Title) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TemplateData_Public_Class_Title_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTitle);
            var propertyInfo = this.GetPropertyInfo(PropertyTitle);

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