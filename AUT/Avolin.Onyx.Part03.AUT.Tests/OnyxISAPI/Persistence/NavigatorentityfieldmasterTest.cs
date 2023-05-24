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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_entity_field_master" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatorentityfieldmasterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_entity_field_master" />)
        /// </summary>
        public NavigatorentityfieldmasterTest() : base(typeof(navigator_entity_field_master))
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

        #region General Initializer : Class (navigator_entity_field_master) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorentityfieldmasterInstanceType;
        private navigator_entity_field_master _navigatorentityfieldmasterInstance;
        private navigator_entity_field_master _navigatorentityfieldmasterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_entity_field_master" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorentityfieldmasterInstanceType = typeof(navigator_entity_field_master);
            _navigatorentityfieldmasterInstanceFixture = this.Create<navigator_entity_field_master>(false);
            _navigatorentityfieldmasterInstance = _navigatorentityfieldmasterInstanceFixture ?? this.Create<navigator_entity_field_master>(true);
            CurrentInstance = _navigatorentityfieldmasterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_entity_field_master) Initializer

        #region Properties

        private const string Propertyfield_id = "field_id";
        private const string Propertysite_id = "site_id";
        private const string Propertyentity_id = "entity_id";
        private const string Propertyfield_name = "field_name";
        private const string Propertyposition = "position";
        private const string Propertytype = "type";
        private const string Propertyparent = "parent";
        private const string Propertysequence_index = "sequence_index";
        private const string Propertycontrol_type = "control_type";
        private const string Propertymask_format = "mask_format";
        private const string Propertysort_order = "sort_order";
        private const string Propertyis_transaction = "is_transaction";
        private const string Propertylinked_property = "linked_property";
        private const string Propertyuse_type = "use_type";
        private const string Propertyfield_state = "field_state";
        private const string Propertyis_batch_update = "is_batch_update";
        private const string PropertyResourceName = "ResourceName";
        private const string PropertyCacheName = "CacheName";
        private const string PropertyCacheParentId = "CacheParentId";
        private const string Propertydelete_status = "delete_status";
        private const string Propertyprimary_linked_field_name = "primary_linked_field_name";
        private const string Propertysecondary_linked_field_name = "secondary_linked_field_name";
        private const string Propertybatch_sequence_index = "batch_sequence_index";
        private const string Propertyis_exists_condition = "is_exists_condition";
        private const string PropertyIsRequired = "IsRequired";
        private const string Propertynavigator_entity_field_master_ml = "navigator_entity_field_master_ml";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_entity_field_master) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentityfieldmaster_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_field_master) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentityfieldmaster_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_field_master) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentityfieldmaster_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_entity_field_master)

        #region General Initializer : Class (navigator_entity_field_master) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyfield_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertyfield_name)]
        [TestCase(Propertyposition)]
        [TestCase(Propertytype)]
        [TestCase(Propertyparent)]
        [TestCase(Propertysequence_index)]
        [TestCase(Propertycontrol_type)]
        [TestCase(Propertymask_format)]
        [TestCase(Propertysort_order)]
        [TestCase(Propertyis_transaction)]
        [TestCase(Propertylinked_property)]
        [TestCase(Propertyuse_type)]
        [TestCase(Propertyfield_state)]
        [TestCase(Propertyis_batch_update)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(Propertydelete_status)]
        [TestCase(Propertyprimary_linked_field_name)]
        [TestCase(Propertysecondary_linked_field_name)]
        [TestCase(Propertybatch_sequence_index)]
        [TestCase(Propertyis_exists_condition)]
        [TestCase(PropertyIsRequired)]
        [TestCase(Propertynavigator_entity_field_master_ml)]
        [Category("AUT Property")]
        public void AUT_Navigatorentityfieldmaster_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_entity_field_master) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentityfieldmaster_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorentityfieldmasterInstanceType.ShouldNotBeNull();
            _navigatorentityfieldmasterInstance.ShouldNotBeNull();
            _navigatorentityfieldmasterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_entity_field_master) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_entity_field_master" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentityfieldmaster_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorentityfieldmasterInstance.ShouldBeAssignableTo<navigator_entity_field_master>();
            _navigatorentityfieldmasterInstanceFixture.ShouldBeAssignableTo<navigator_entity_field_master>();
            CurrentInstance.ShouldBeAssignableTo<navigator_entity_field_master>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_entity_field_master) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatorentityfieldmaster_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_entity_field_master instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_entity_field_master) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyfield_id)]
        [TestCase(Propertysite_id)]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertyfield_name)]
        [TestCase(Propertyposition)]
        [TestCase(Propertytype)]
        [TestCase(Propertyparent)]
        [TestCase(Propertysequence_index)]
        [TestCase(Propertycontrol_type)]
        [TestCase(Propertymask_format)]
        [TestCase(Propertysort_order)]
        [TestCase(Propertyis_transaction)]
        [TestCase(Propertylinked_property)]
        [TestCase(Propertyuse_type)]
        [TestCase(Propertyfield_state)]
        [TestCase(Propertyis_batch_update)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(Propertydelete_status)]
        [TestCase(Propertyprimary_linked_field_name)]
        [TestCase(Propertysecondary_linked_field_name)]
        [TestCase(Propertybatch_sequence_index)]
        [TestCase(Propertyis_exists_condition)]
        [TestCase(PropertyIsRequired)]
        [TestCase(Propertynavigator_entity_field_master_ml)]
        public void AUT_Navigatorentityfieldmaster_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (batch_sequence_index) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_batch_sequence_index_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertybatch_sequence_index);
            var propertyInfo = this.GetPropertyInfo(Propertybatch_sequence_index);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (CacheName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_CacheName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCacheName);
            var propertyInfo = this.GetPropertyInfo(PropertyCacheName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (CacheParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_CacheParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCacheParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyCacheParentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (control_type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_control_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertycontrol_type);
            var propertyInfo = this.GetPropertyInfo(Propertycontrol_type);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (delete_status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_delete_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertydelete_status);
            var propertyInfo = this.GetPropertyInfo(Propertydelete_status);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (entity_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_entity_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (field_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_field_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfield_id);
            var propertyInfo = this.GetPropertyInfo(Propertyfield_id);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (field_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_field_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfield_name);
            var propertyInfo = this.GetPropertyInfo(Propertyfield_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (field_state) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_field_state_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfield_state);
            var propertyInfo = this.GetPropertyInfo(Propertyfield_state);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (is_batch_update) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_is_batch_update_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyis_batch_update);
            var propertyInfo = this.GetPropertyInfo(Propertyis_batch_update);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (is_exists_condition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_is_exists_condition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyis_exists_condition);
            var propertyInfo = this.GetPropertyInfo(Propertyis_exists_condition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (is_transaction) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_is_transaction_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyis_transaction);
            var propertyInfo = this.GetPropertyInfo(Propertyis_transaction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (IsRequired) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_IsRequired_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsRequired);
            var propertyInfo = this.GetPropertyInfo(PropertyIsRequired);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (linked_property) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_linked_property_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylinked_property);
            var propertyInfo = this.GetPropertyInfo(Propertylinked_property);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (mask_format) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_mask_format_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertymask_format);
            var propertyInfo = this.GetPropertyInfo(Propertymask_format);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (navigator_entity_field_master_ml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_navigator_entity_field_master_ml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_field_master_ml);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_field_master_ml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (parent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_parent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyparent);
            var propertyInfo = this.GetPropertyInfo(Propertyparent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (position) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_position_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyposition);
            var propertyInfo = this.GetPropertyInfo(Propertyposition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (primary_linked_field_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_primary_linked_field_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyprimary_linked_field_name);
            var propertyInfo = this.GetPropertyInfo(Propertyprimary_linked_field_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceName);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (secondary_linked_field_name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_secondary_linked_field_name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysecondary_linked_field_name);
            var propertyInfo = this.GetPropertyInfo(Propertysecondary_linked_field_name);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (sequence_index) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_sequence_index_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (site_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_site_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (sort_order) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_sort_order_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysort_order);
            var propertyInfo = this.GetPropertyInfo(Propertysort_order);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertytype);
            var propertyInfo = this.GetPropertyInfo(Propertytype);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_field_master) => Property (use_type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentityfieldmaster_Public_Class_use_type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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