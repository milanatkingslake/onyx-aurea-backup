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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.EntityGroupMapper" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class EntityGroupMapperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EntityGroupMapper" />)
        /// </summary>
        public EntityGroupMapperTest() : base(typeof(EntityGroupMapper))
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

        #region General Initializer : Class (EntityGroupMapper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _entityGroupMapperInstanceType;
        private EntityGroupMapper _entityGroupMapperInstance;
        private EntityGroupMapper _entityGroupMapperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EntityGroupMapper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _entityGroupMapperInstanceType = typeof(EntityGroupMapper);
            _entityGroupMapperInstanceFixture = this.Create<EntityGroupMapper>(false);
            _entityGroupMapperInstance = _entityGroupMapperInstanceFixture ?? this.Create<EntityGroupMapper>(true);
            CurrentInstance = _entityGroupMapperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EntityGroupMapper) Initializer

        #region Properties

        private const string PropertyEntityGroupMapperId = "EntityGroupMapperId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyGroupId = "GroupId";
        private const string PropertyEntityId = "EntityId";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyRowNumber = "RowNumber";
        private const string PropertyUpdateBy = "UpdateBy";
        private const string PropertyUpdateDate = "UpdateDate";
        private const string PropertyInsertBy = "InsertBy";
        private const string PropertyInsertDate = "InsertDate";
        private const string PropertyRecordStatus = "RecordStatus";
        private const string Propertynavigator_entity_master = "navigator_entity_master";

        #endregion

        #endregion

        #region General Initializer : Class (EntityGroupMapper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EntityGroupMapper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EntityGroupMapper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EntityGroupMapper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EntityGroupMapper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EntityGroupMapper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EntityGroupMapper)

        #region General Initializer : Class (EntityGroupMapper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEntityGroupMapperId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyRowNumber)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(Propertynavigator_entity_master)]
        [Category("AUT Property")]
        public void AUT_EntityGroupMapper_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EntityGroupMapper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EntityGroupMapper_Is_Instance_Present_Test()
        {
            // Assert
            _entityGroupMapperInstanceType.ShouldNotBeNull();
            _entityGroupMapperInstance.ShouldNotBeNull();
            _entityGroupMapperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EntityGroupMapper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EntityGroupMapper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EntityGroupMapper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _entityGroupMapperInstance.ShouldBeAssignableTo<EntityGroupMapper>();
            _entityGroupMapperInstanceFixture.ShouldBeAssignableTo<EntityGroupMapper>();
            CurrentInstance.ShouldBeAssignableTo<EntityGroupMapper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EntityGroupMapper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EntityGroupMapper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            EntityGroupMapper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (EntityGroupMapper) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEntityGroupMapperId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyGroupId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyRowNumber)]
        [TestCase(PropertyUpdateBy)]
        [TestCase(PropertyUpdateDate)]
        [TestCase(PropertyInsertBy)]
        [TestCase(PropertyInsertDate)]
        [TestCase(PropertyRecordStatus)]
        [TestCase(Propertynavigator_entity_master)]
        public void AUT_EntityGroupMapper_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (EntityGroupMapperId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_EntityGroupMapperId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityGroupMapperId);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityGroupMapperId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityId);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (GroupId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_GroupId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGroupId);
            var propertyInfo = this.GetPropertyInfo(PropertyGroupId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (InsertBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_InsertBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (InsertDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_InsertDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInsertDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInsertDate);
            Action currentAction = () => propertyInfo.SetValue(_entityGroupMapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (InsertDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_InsertDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (navigator_entity_master) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_navigator_entity_master_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master);
            Action currentAction = () => propertyInfo.SetValue(_entityGroupMapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (navigator_entity_master) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_navigator_entity_master_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (RecordStatus) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_RecordStatus_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (RowNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_RowNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyRowNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyRowNumber);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySequenceIndex);
            var propertyInfo = this.GetPropertyInfo(PropertySequenceIndex);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (UpdateBy) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_UpdateBy_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (UpdateDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_UpdateDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUpdateDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyUpdateDate);
            Action currentAction = () => propertyInfo.SetValue(_entityGroupMapperInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (EntityGroupMapper) => Property (UpdateDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EntityGroupMapper_Public_Class_UpdateDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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