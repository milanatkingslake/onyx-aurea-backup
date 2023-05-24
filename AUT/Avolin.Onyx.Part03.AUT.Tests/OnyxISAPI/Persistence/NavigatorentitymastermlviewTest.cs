using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI.Persistence
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_entity_master_ml_view" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatorentitymastermlviewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_entity_master_ml_view" />)
        /// </summary>
        public NavigatorentitymastermlviewTest() : base(typeof(navigator_entity_master_ml_view))
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

        #region General Initializer : Class (navigator_entity_master_ml_view) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorentitymastermlviewInstanceType;
        private navigator_entity_master_ml_view _navigatorentitymastermlviewInstance;
        private navigator_entity_master_ml_view _navigatorentitymastermlviewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_entity_master_ml_view" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorentitymastermlviewInstanceType = typeof(navigator_entity_master_ml_view);
            _navigatorentitymastermlviewInstanceFixture = this.Create<navigator_entity_master_ml_view>(false);
            _navigatorentitymastermlviewInstance = _navigatorentitymastermlviewInstanceFixture ?? this.Create<navigator_entity_master_ml_view>(true);
            CurrentInstance = _navigatorentitymastermlviewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml_view) Initializer

        #region Properties

        private const string Propertyentity_id = "entity_id";
        private const string Propertysite_id = "site_id";
        private const string Propertylanguage_code = "language_code";
        private const string Propertyentity_name = "entity_name";
        private const string Propertyentity_view_name = "entity_view_name";
        private const string PropertyGamEntityResourceName = "GamEntityResourceName";
        private const string PropertyLboObjectId = "LboObjectId";
        private const string PropertyLboObjectName = "LboObjectName";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyRetrieveMethodName = "RetrieveMethodName";
        private const string Propertyentity_display_name = "entity_display_name";
        private const string Propertyuse_type = "use_type";
        
        private const string Propertymax_records = "max_records";
        private const string PropertyIsActive = "IsActive";
        private const string PropertyEntityResourceName = "EntityResourceName";
        private const string PropertyIsMobileBookmarkEnable = "IsMobileBookmarkEnable";
        private const string PropertySortOrder = "SortOrder";
        private const string PropertyIsClientSummaryEnable = "IsClientSummaryEnable";
        private const string PropertyIsBatchUpdateEnable = "IsBatchUpdateEnable";
        private const string PropertyBatchUpdateResourceName = "BatchUpdateResourceName";
        private const string PropertyDetailViewId = "DetailViewId";
        private const string PropertySearchExecuteMode = "SearchExecuteMode";
        private const string Propertysequence_index = "sequence_index";
        private const string PropertyIsBatchActionEnable = "IsBatchActionEnable";
        private const string PropertyBatchActionResourceName = "BatchActionResourceName";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml_view) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymastermlview_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml_view) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymastermlview_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_master_ml_view) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitymastermlview_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_entity_master_ml_view)

        #region General Initializer : Class (navigator_entity_master_ml_view) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyentity_name)]
        [TestCase(Propertyentity_view_name)]
        [TestCase(PropertyGamEntityResourceName)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyLboObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyRetrieveMethodName)]
        [TestCase(Propertyentity_display_name)]
        [TestCase(Propertyuse_type)]
        [TestCase(Propertymax_records)]
        [TestCase(PropertyIsActive)]
        [TestCase(PropertyEntityResourceName)]
        [TestCase(PropertyIsMobileBookmarkEnable)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyIsClientSummaryEnable)]
        [TestCase(PropertyIsBatchUpdateEnable)]
        [TestCase(PropertyBatchUpdateResourceName)]
        [TestCase(PropertyDetailViewId)]
        [TestCase(PropertySearchExecuteMode)]
        [TestCase(Propertysequence_index)]
        [TestCase(PropertyIsBatchActionEnable)]
        [TestCase(PropertyBatchActionResourceName)]
        [Category("AUT Property")]
        public void AUT_Navigatorentitymastermlview_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_entity_master_ml_view) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitymastermlview_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorentitymastermlviewInstanceType.ShouldNotBeNull();
            _navigatorentitymastermlviewInstance.ShouldNotBeNull();
            _navigatorentitymastermlviewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_entity_master_ml_view) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_entity_master_ml_view" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitymastermlview_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorentitymastermlviewInstance.ShouldBeAssignableTo<navigator_entity_master_ml_view>();
            _navigatorentitymastermlviewInstanceFixture.ShouldBeAssignableTo<navigator_entity_master_ml_view>();
            CurrentInstance.ShouldBeAssignableTo<navigator_entity_master_ml_view>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_entity_master_ml_view) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatorentitymastermlview_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_entity_master_ml_view instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertylanguage_code)]
        [TestCase(Propertyentity_name)]
        [TestCase(Propertyentity_view_name)]
        [TestCase(PropertyGamEntityResourceName)]
        [TestCase(PropertyLboObjectId)]
        [TestCase(PropertyLboObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyRetrieveMethodName)]
        [TestCase(Propertyentity_display_name)]
        [TestCase(Propertyuse_type)]
        [TestCase(Propertymax_records)]
        [TestCase(PropertyIsActive)]
        [TestCase(PropertyEntityResourceName)]
        [TestCase(PropertyIsMobileBookmarkEnable)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyIsClientSummaryEnable)]
        [TestCase(PropertyIsBatchUpdateEnable)]
        [TestCase(PropertyBatchUpdateResourceName)]
        [TestCase(PropertyDetailViewId)]
        [TestCase(PropertySearchExecuteMode)]
        [TestCase(Propertysequence_index)]
        [TestCase(PropertyIsBatchActionEnable)]
        [TestCase(PropertyBatchActionResourceName)]
        public void AUT_Navigatorentitymastermlview_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (BatchActionResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_BatchActionResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchActionResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchActionResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (BatchUpdateResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_BatchUpdateResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBatchUpdateResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyBatchUpdateResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (DetailViewId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_DetailViewId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailViewId);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailViewId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (entity_display_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_entity_display_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_display_name);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_display_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (entity_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_entity_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_id);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (entity_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_entity_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_name);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (entity_view_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_entity_view_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyentity_view_name);
            var propertyInfo = this.GetPropertyInfo(Propertyentity_view_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (EntityResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_EntityResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (GamEntityResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_GamEntityResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGamEntityResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyGamEntityResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (IsActive) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_IsActive_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsActive);
            var propertyInfo = this.GetPropertyInfo(PropertyIsActive);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (IsBatchActionEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_IsBatchActionEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBatchActionEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBatchActionEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (IsBatchUpdateEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_IsBatchUpdateEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBatchUpdateEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBatchUpdateEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (IsClientSummaryEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_IsClientSummaryEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsClientSummaryEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsClientSummaryEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (IsMobileBookmarkEnable) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_IsMobileBookmarkEnable_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsMobileBookmarkEnable);
            var propertyInfo = this.GetPropertyInfo(PropertyIsMobileBookmarkEnable);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (language_code) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_language_code_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage_code);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage_code);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (LboObjectId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_LboObjectId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (LboObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_LboObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyLboObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (max_records) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_max_records_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertymax_records);
            var propertyInfo = this.GetPropertyInfo(Propertymax_records);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (RetrieveMethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_RetrieveMethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRetrieveMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyRetrieveMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (SearchExecuteMode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_SearchExecuteMode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySearchExecuteMode);
            var propertyInfo = this.GetPropertyInfo(PropertySearchExecuteMode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (sequence_index) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_sequence_index_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysequence_index);
            var propertyInfo = this.GetPropertyInfo(Propertysequence_index);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysite_id);
            var propertyInfo = this.GetPropertyInfo(Propertysite_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (SortOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_SortOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySortOrder);
            var propertyInfo = this.GetPropertyInfo(PropertySortOrder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (use_type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_use_type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuse_type);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyuse_type);
            Action currentAction = () => propertyInfo.SetValue(_navigatorentitymastermlviewInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_master_ml_view) => Property (use_type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitymastermlview_Public_Class_use_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuse_type);
            var propertyInfo = this.GetPropertyInfo(Propertyuse_type);

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