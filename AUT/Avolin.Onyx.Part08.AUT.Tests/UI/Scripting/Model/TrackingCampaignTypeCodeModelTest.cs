using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.TrackingCampaignTypeCodeModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TrackingCampaignTypeCodeModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TrackingCampaignTypeCodeModel" />)
        /// </summary>
        public TrackingCampaignTypeCodeModelTest() : base(typeof(TrackingCampaignTypeCodeModel))
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

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _trackingCampaignTypeCodeModelInstanceType;
        private TrackingCampaignTypeCodeModel _trackingCampaignTypeCodeModelInstance;
        private TrackingCampaignTypeCodeModel _trackingCampaignTypeCodeModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TrackingCampaignTypeCodeModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _trackingCampaignTypeCodeModelInstanceType = typeof(TrackingCampaignTypeCodeModel);
            _trackingCampaignTypeCodeModelInstanceFixture = this.Create<TrackingCampaignTypeCodeModel>(false);
            _trackingCampaignTypeCodeModelInstance = _trackingCampaignTypeCodeModelInstanceFixture ?? this.Create<TrackingCampaignTypeCodeModel>(true);
            CurrentInstance = _trackingCampaignTypeCodeModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) Initializer

        #region Properties

        private const string PropertyCampaignCode = "CampaignCode";
        private const string PropertyTrackingTypeCode = "TrackingTypeCode";
        private const string PropertyCode = "Code";
        private const string PropertyCodeId = "CodeId";
        private const string PropertyDescription = "Description";
        private const string PropertyName = "Name";

        #endregion

        #endregion

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCampaignTypeCodeModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCampaignTypeCodeModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCampaignTypeCodeModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TrackingCampaignTypeCodeModel)

        #region General Initializer : Class (TrackingCampaignTypeCodeModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCampaignCode)]
        [TestCase(PropertyTrackingTypeCode)]
        [TestCase(PropertyCode)]
        [TestCase(PropertyCodeId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyName)]
        [Category("AUT Property")]
        public void AUT_TrackingCampaignTypeCodeModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TrackingCampaignTypeCodeModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCampaignTypeCodeModel_Is_Instance_Present_Test()
        {
            // Assert
            _trackingCampaignTypeCodeModelInstanceType.ShouldNotBeNull();
            _trackingCampaignTypeCodeModelInstance.ShouldNotBeNull();
            _trackingCampaignTypeCodeModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TrackingCampaignTypeCodeModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TrackingCampaignTypeCodeModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCampaignTypeCodeModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _trackingCampaignTypeCodeModelInstance.ShouldBeAssignableTo<TrackingCampaignTypeCodeModel>();
            _trackingCampaignTypeCodeModelInstanceFixture.ShouldBeAssignableTo<TrackingCampaignTypeCodeModel>();
            CurrentInstance.ShouldBeAssignableTo<TrackingCampaignTypeCodeModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TrackingCampaignTypeCodeModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TrackingCampaignTypeCodeModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TrackingCampaignTypeCodeModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCampaignCode)]
        [TestCase(PropertyTrackingTypeCode)]
        [TestCase(PropertyCode)]
        [TestCase(PropertyCodeId)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyName)]
        public void AUT_TrackingCampaignTypeCodeModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (CampaignCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_CampaignCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCampaignCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCampaignCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (Code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_Code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (CodeId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_CodeId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCodeId);
            var propertyInfo = this.GetPropertyInfo(PropertyCodeId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (TrackingCampaignTypeCodeModel) => Property (TrackingTypeCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TrackingCampaignTypeCodeModel_Public_Class_TrackingTypeCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTrackingTypeCode);
            var propertyInfo = this.GetPropertyInfo(PropertyTrackingTypeCode);

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