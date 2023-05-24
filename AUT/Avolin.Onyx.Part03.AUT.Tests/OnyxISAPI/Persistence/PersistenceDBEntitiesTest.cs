using System;
using System.Data.Entity;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.PersistenceDBEntities" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class PersistenceDBEntitiesTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PersistenceDBEntities" />)
        /// </summary>
        public PersistenceDBEntitiesTest() : base(typeof(PersistenceDBEntities))
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

        #region General Initializer : Class (PersistenceDBEntities) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _persistenceDBEntitiesInstanceType;
        private PersistenceDBEntities _persistenceDBEntitiesInstance;
        private PersistenceDBEntities _persistenceDBEntitiesInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PersistenceDBEntities" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _persistenceDBEntitiesInstanceType = typeof(PersistenceDBEntities);
            _persistenceDBEntitiesInstanceFixture = this.Create<PersistenceDBEntities>(false);
            _persistenceDBEntitiesInstance = _persistenceDBEntitiesInstanceFixture ?? this.Create<PersistenceDBEntities>(true);
            CurrentInstance = _persistenceDBEntitiesInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PersistenceDBEntities) Initializer

        #region Properties

        private const string PropertyActionButton = "ActionButton";
        private const string PropertyActionButtonMl = "ActionButtonMl";
        private const string PropertyActionGroup = "ActionGroup";
        private const string PropertyActionGroupMl = "ActionGroupMl";
        private const string PropertyActionListProfile = "ActionListProfile";
        private const string PropertyActionListProfileMl = "ActionListProfileMl";
        private const string Propertybookmark = "bookmark";
        private const string PropertyBroker = "Broker";
        private const string PropertyEndPoint = "EndPoint";
        private const string PropertyEndPointProperty = "EndPointProperty";
        private const string PropertyEndPointPropertyName = "EndPointPropertyName";
        private const string PropertyEndPointType = "EndPointType";
        private const string PropertyEndPointTypeMl = "EndPointTypeMl";
        private const string PropertyEntityGroupMapper = "EntityGroupMapper";
        private const string Propertyfolder = "folder";
        private const string PropertyHomePageQuery = "HomePageQuery";
        private const string PropertyHomePageUserConfig = "HomePageUserConfig";
        private const string PropertyLboObject = "LboObject";
        private const string PropertyLboPropertyMapper = "LboPropertyMapper";
        private const string PropertyMobileBookmark = "MobileBookmark";
        private const string Propertynavigator_entity_field_master = "navigator_entity_field_master";
        private const string Propertynavigator_entity_field_master_ml = "navigator_entity_field_master_ml";
        private const string Propertynavigator_entity_master = "navigator_entity_master";
        private const string Propertynavigator_entity_master_ml = "navigator_entity_master_ml";
        private const string Propertynavigator_operator = "navigator_operator";
        private const string Propertynavigator_operator_ml = "navigator_operator_ml";
        private const string Propertynavigator_property_master = "navigator_property_master";
        private const string Propertynavigator_user_access = "navigator_user_access";
        private const string Propertynavigator_user_field_property = "navigator_user_field_property";
        private const string Propertyquery = "query";
        private const string PropertyQueryEntityConfiguration = "QueryEntityConfiguration";
        private const string PropertyQueryProfile = "QueryProfile";
        private const string PropertyQueryResult = "QueryResult";
        private const string PropertyQueryRGConfiguration = "QueryRGConfiguration";
        private const string PropertyUserEntityConfiguration = "UserEntityConfiguration";
        private const string PropertyUserFieldConfiguration = "UserFieldConfiguration";
        private const string Propertynavigator_entity_custom_cache = "navigator_entity_custom_cache";
        private const string PropertyActionButtonMlView = "ActionButtonMlView";
        private const string PropertyActionGroupMlView = "ActionGroupMlView";
        private const string PropertyActionListProfileMlView = "ActionListProfileMlView";
        private const string PropertyDetailListViewColumnMlView = "DetailListViewColumnMlView";
        private const string PropertyDetailListViewFormView = "DetailListViewFormView";
        private const string PropertyDetailListViewGroupMlView = "DetailListViewGroupMlView";
        private const string PropertyDetailListViewMlView = "DetailListViewMlView";
        private const string PropertyDetailViewGroupMlView = "DetailViewGroupMlView";
        private const string PropertyEndPointTypeMlView = "EndPointTypeMlView";
        private const string PropertyGamNonUiView = "GamNonUiView";
        private const string PropertyGamUiView = "GamUiView";
        private const string PropertyLboPropertyFieldMapperView = "LboPropertyFieldMapperView";
        private const string Propertynavigator_entity_field_master_ml_view = "navigator_entity_field_master_ml_view";
        private const string Propertynavigator_entity_master_ml_view = "navigator_entity_master_ml_view";
        private const string Propertynavigator_operator_ml_view = "navigator_operator_ml_view";
        private const string Propertyquery_view = "query_view";
        private const string PropertyQueryConfigurationView = "QueryConfigurationView";
        private const string PropertyUserConfigurationView = "UserConfigurationView";
        private const string PropertyDetailViewMlView = "DetailViewMlView";
        private const string PropertyDetailViewFieldMlView = "DetailViewFieldMlView";
        private const string Propertylanguage = "language";
        private const string PropertyResultGridToolActionGroup = "ResultGridToolActionGroup";
        private const string PropertyResultGridToolActionItem = "ResultGridToolActionItem";

        #endregion

        #region Methods

        private const string MethodOnModelCreating = "OnModelCreating";

        #endregion

        #endregion

        #region General Initializer : Class (PersistenceDBEntities) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PersistenceDBEntities) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PersistenceDBEntities) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PersistenceDBEntities_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PersistenceDBEntities)

        #region General Initializer : Class (PersistenceDBEntities) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodOnModelCreating, 0)]
        public void AUT_PersistenceDBEntities_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PersistenceDBEntities) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyActionButton)]
        [TestCase(PropertyActionButtonMl)]
        [TestCase(PropertyActionGroup)]
        [TestCase(PropertyActionGroupMl)]
        [TestCase(PropertyActionListProfile)]
        [TestCase(PropertyActionListProfileMl)]
        [TestCase(Propertybookmark)]
        [TestCase(PropertyBroker)]
        [TestCase(PropertyEndPoint)]
        [TestCase(PropertyEndPointProperty)]
        [TestCase(PropertyEndPointPropertyName)]
        [TestCase(PropertyEndPointType)]
        [TestCase(PropertyEndPointTypeMl)]
        [TestCase(PropertyEntityGroupMapper)]
        [TestCase(Propertyfolder)]
        [TestCase(PropertyHomePageQuery)]
        [TestCase(PropertyHomePageUserConfig)]
        [TestCase(PropertyLboObject)]
        [TestCase(PropertyLboPropertyMapper)]
        [TestCase(PropertyMobileBookmark)]
        [TestCase(Propertynavigator_entity_field_master)]
        [TestCase(Propertynavigator_entity_field_master_ml)]
        [TestCase(Propertynavigator_entity_master)]
        [TestCase(Propertynavigator_entity_master_ml)]
        [TestCase(Propertynavigator_operator)]
        [TestCase(Propertynavigator_operator_ml)]
        [TestCase(Propertynavigator_property_master)]
        [TestCase(Propertynavigator_user_access)]
        [TestCase(Propertynavigator_user_field_property)]
        [TestCase(Propertyquery)]
        [TestCase(PropertyQueryEntityConfiguration)]
        [TestCase(PropertyQueryProfile)]
        [TestCase(PropertyQueryResult)]
        [TestCase(PropertyQueryRGConfiguration)]
        [TestCase(PropertyUserEntityConfiguration)]
        [TestCase(PropertyUserFieldConfiguration)]
        [TestCase(Propertynavigator_entity_custom_cache)]
        [TestCase(PropertyActionButtonMlView)]
        [TestCase(PropertyActionGroupMlView)]
        [TestCase(PropertyActionListProfileMlView)]
        [TestCase(PropertyDetailListViewColumnMlView)]
        [TestCase(PropertyDetailListViewFormView)]
        [TestCase(PropertyDetailListViewGroupMlView)]
        [TestCase(PropertyDetailListViewMlView)]
        [TestCase(PropertyDetailViewGroupMlView)]
        [TestCase(PropertyEndPointTypeMlView)]
        [TestCase(PropertyGamNonUiView)]
        [TestCase(PropertyGamUiView)]
        [TestCase(PropertyLboPropertyFieldMapperView)]
        [TestCase(Propertynavigator_entity_field_master_ml_view)]
        [TestCase(Propertynavigator_entity_master_ml_view)]
        [TestCase(Propertynavigator_operator_ml_view)]
        [TestCase(Propertyquery_view)]
        [TestCase(PropertyQueryConfigurationView)]
        [TestCase(PropertyUserConfigurationView)]
        [TestCase(PropertyDetailViewMlView)]
        [TestCase(PropertyDetailViewFieldMlView)]
        [TestCase(Propertylanguage)]
        [TestCase(PropertyResultGridToolActionGroup)]
        [TestCase(PropertyResultGridToolActionItem)]
        [Category("AUT Property")]
        public void AUT_PersistenceDBEntities_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PersistenceDBEntities) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PersistenceDBEntities_Is_Instance_Present_Test()
        {
            // Assert
            _persistenceDBEntitiesInstanceType.ShouldNotBeNull();
            _persistenceDBEntitiesInstance.ShouldNotBeNull();
            _persistenceDBEntitiesInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PersistenceDBEntities) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PersistenceDBEntities" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PersistenceDBEntities_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _persistenceDBEntitiesInstance.ShouldBeAssignableTo<PersistenceDBEntities>();
            _persistenceDBEntitiesInstanceFixture.ShouldBeAssignableTo<PersistenceDBEntities>();
            CurrentInstance.ShouldBeAssignableTo<PersistenceDBEntities>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PersistenceDBEntities) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PersistenceDBEntities_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            PersistenceDBEntities instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PersistenceDBEntities) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyActionButton)]
        [TestCase(PropertyActionButtonMl)]
        [TestCase(PropertyActionGroup)]
        [TestCase(PropertyActionGroupMl)]
        [TestCase(PropertyActionListProfile)]
        [TestCase(PropertyActionListProfileMl)]
        [TestCase(Propertybookmark)]
        [TestCase(PropertyBroker)]
        [TestCase(PropertyEndPoint)]
        [TestCase(PropertyEndPointProperty)]
        [TestCase(PropertyEndPointPropertyName)]
        [TestCase(PropertyEndPointType)]
        [TestCase(PropertyEndPointTypeMl)]
        [TestCase(PropertyEntityGroupMapper)]
        [TestCase(Propertyfolder)]
        [TestCase(PropertyHomePageQuery)]
        [TestCase(PropertyHomePageUserConfig)]
        [TestCase(PropertyLboObject)]
        [TestCase(PropertyLboPropertyMapper)]
        [TestCase(PropertyMobileBookmark)]
        [TestCase(Propertynavigator_entity_field_master)]
        [TestCase(Propertynavigator_entity_field_master_ml)]
        [TestCase(Propertynavigator_entity_master)]
        [TestCase(Propertynavigator_entity_master_ml)]
        [TestCase(Propertynavigator_operator)]
        [TestCase(Propertynavigator_operator_ml)]
        [TestCase(Propertynavigator_property_master)]
        [TestCase(Propertynavigator_user_access)]
        [TestCase(Propertynavigator_user_field_property)]
        [TestCase(Propertyquery)]
        [TestCase(PropertyQueryEntityConfiguration)]
        [TestCase(PropertyQueryProfile)]
        [TestCase(PropertyQueryResult)]
        [TestCase(PropertyQueryRGConfiguration)]
        [TestCase(PropertyUserEntityConfiguration)]
        [TestCase(PropertyUserFieldConfiguration)]
        [TestCase(Propertynavigator_entity_custom_cache)]
        [TestCase(PropertyActionButtonMlView)]
        [TestCase(PropertyActionGroupMlView)]
        [TestCase(PropertyActionListProfileMlView)]
        [TestCase(PropertyDetailListViewColumnMlView)]
        [TestCase(PropertyDetailListViewFormView)]
        [TestCase(PropertyDetailListViewGroupMlView)]
        [TestCase(PropertyDetailListViewMlView)]
        [TestCase(PropertyDetailViewGroupMlView)]
        [TestCase(PropertyEndPointTypeMlView)]
        [TestCase(PropertyGamNonUiView)]
        [TestCase(PropertyGamUiView)]
        [TestCase(PropertyLboPropertyFieldMapperView)]
        [TestCase(Propertynavigator_entity_field_master_ml_view)]
        [TestCase(Propertynavigator_entity_master_ml_view)]
        [TestCase(Propertynavigator_operator_ml_view)]
        [TestCase(Propertyquery_view)]
        [TestCase(PropertyQueryConfigurationView)]
        [TestCase(PropertyUserConfigurationView)]
        [TestCase(PropertyDetailViewMlView)]
        [TestCase(PropertyDetailViewFieldMlView)]
        [TestCase(Propertylanguage)]
        [TestCase(PropertyResultGridToolActionGroup)]
        [TestCase(PropertyResultGridToolActionItem)]
        public void AUT_PersistenceDBEntities_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionButton) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionButton_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButton);
            var propertyInfo = this.GetPropertyInfo(PropertyActionButton);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionButtonMl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionButtonMl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButtonMl);
            var propertyInfo = this.GetPropertyInfo(PropertyActionButtonMl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionButtonMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionButtonMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButtonMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyActionButtonMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionGroup) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionGroup_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionGroup);
            var propertyInfo = this.GetPropertyInfo(PropertyActionGroup);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionGroupMl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionGroupMl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionGroupMl);
            var propertyInfo = this.GetPropertyInfo(PropertyActionGroupMl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionGroupMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionGroupMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionGroupMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyActionGroupMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionListProfile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionListProfile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionListProfile);
            var propertyInfo = this.GetPropertyInfo(PropertyActionListProfile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionListProfileMl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionListProfileMl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionListProfileMl);
            var propertyInfo = this.GetPropertyInfo(PropertyActionListProfileMl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ActionListProfileMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ActionListProfileMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionListProfileMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyActionListProfileMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (bookmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_bookmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertybookmark);
            var propertyInfo = this.GetPropertyInfo(Propertybookmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (Broker) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_Broker_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBroker);
            var propertyInfo = this.GetPropertyInfo(PropertyBroker);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailListViewColumnMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailListViewColumnMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailListViewColumnMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailListViewColumnMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailListViewFormView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailListViewFormView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailListViewFormView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailListViewFormView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailListViewGroupMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailListViewGroupMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailListViewGroupMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailListViewGroupMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailListViewMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailListViewMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailListViewMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailListViewMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailViewFieldMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailViewFieldMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailViewFieldMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailViewFieldMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailViewGroupMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailViewGroupMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailViewGroupMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailViewGroupMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (DetailViewMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_DetailViewMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDetailViewMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyDetailViewMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPoint) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPoint_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPoint);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPoint);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPointProperty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPointProperty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointProperty);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointProperty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPointPropertyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPointPropertyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointPropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointPropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPointType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPointType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointType);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPointTypeMl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPointTypeMl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointTypeMl);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointTypeMl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EndPointTypeMlView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EndPointTypeMlView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndPointTypeMlView);
            var propertyInfo = this.GetPropertyInfo(PropertyEndPointTypeMlView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (EntityGroupMapper) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_EntityGroupMapper_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEntityGroupMapper);
            var propertyInfo = this.GetPropertyInfo(PropertyEntityGroupMapper);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (folder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_folder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfolder);
            var propertyInfo = this.GetPropertyInfo(Propertyfolder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (GamNonUiView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_GamNonUiView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGamNonUiView);
            var propertyInfo = this.GetPropertyInfo(PropertyGamNonUiView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (GamUiView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_GamUiView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGamUiView);
            var propertyInfo = this.GetPropertyInfo(PropertyGamUiView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (HomePageQuery) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_HomePageQuery_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHomePageQuery);
            var propertyInfo = this.GetPropertyInfo(PropertyHomePageQuery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (HomePageUserConfig) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_HomePageUserConfig_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHomePageUserConfig);
            var propertyInfo = this.GetPropertyInfo(PropertyHomePageUserConfig);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertylanguage);
            var propertyInfo = this.GetPropertyInfo(Propertylanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (LboObject) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_LboObject_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboObject);
            var propertyInfo = this.GetPropertyInfo(PropertyLboObject);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (LboPropertyFieldMapperView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_LboPropertyFieldMapperView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboPropertyFieldMapperView);
            var propertyInfo = this.GetPropertyInfo(PropertyLboPropertyFieldMapperView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (LboPropertyMapper) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_LboPropertyMapper_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLboPropertyMapper);
            var propertyInfo = this.GetPropertyInfo(PropertyLboPropertyMapper);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (MobileBookmark) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_MobileBookmark_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMobileBookmark);
            var propertyInfo = this.GetPropertyInfo(PropertyMobileBookmark);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_custom_cache) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_custom_cache_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_custom_cache);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_custom_cache);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_field_master) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_field_master_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_field_master);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_field_master);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_field_master_ml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_field_master_ml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_field_master_ml_view) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_field_master_ml_view_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_field_master_ml_view);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_field_master_ml_view);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_master) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_master_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_master_ml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_master_ml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master_ml);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master_ml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_entity_master_ml_view) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_entity_master_ml_view_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_entity_master_ml_view);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_entity_master_ml_view);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_operator) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_operator_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_operator);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_operator);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_operator_ml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_operator_ml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_operator_ml);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_operator_ml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_operator_ml_view) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_operator_ml_view_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_operator_ml_view);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_operator_ml_view);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_property_master) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_property_master_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_property_master);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_property_master);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_user_access) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_user_access_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_user_access);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_user_access);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (navigator_user_field_property) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_navigator_user_field_property_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynavigator_user_field_property);
            var propertyInfo = this.GetPropertyInfo(Propertynavigator_user_field_property);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (query) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_query_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyquery);
            var propertyInfo = this.GetPropertyInfo(Propertyquery);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (query_view) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_query_view_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyquery_view);
            var propertyInfo = this.GetPropertyInfo(Propertyquery_view);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (QueryConfigurationView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_QueryConfigurationView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryConfigurationView);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryConfigurationView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (QueryEntityConfiguration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_QueryEntityConfiguration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryEntityConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryEntityConfiguration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (QueryProfile) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_QueryProfile_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryProfile);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryProfile);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (QueryResult) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_QueryResult_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryResult);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryResult);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (QueryRGConfiguration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_QueryRGConfiguration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyQueryRGConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyQueryRGConfiguration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ResultGridToolActionGroup) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ResultGridToolActionGroup_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResultGridToolActionGroup);
            var propertyInfo = this.GetPropertyInfo(PropertyResultGridToolActionGroup);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (ResultGridToolActionItem) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_ResultGridToolActionItem_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResultGridToolActionItem);
            var propertyInfo = this.GetPropertyInfo(PropertyResultGridToolActionItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (UserConfigurationView) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_UserConfigurationView_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserConfigurationView);
            var propertyInfo = this.GetPropertyInfo(PropertyUserConfigurationView);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (UserEntityConfiguration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_UserEntityConfiguration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserEntityConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyUserEntityConfiguration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PersistenceDBEntities) => Property (UserFieldConfiguration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PersistenceDBEntities_Public_Class_UserFieldConfiguration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserFieldConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyUserFieldConfiguration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (OnModelCreating) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PersistenceDBEntities_OnModelCreating_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var modelBuilder = this.CreateType<DbModelBuilder>();
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };
            object[] parametersOfOnModelCreating = { modelBuilder };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, methodOnModelCreatingParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_persistenceDBEntitiesInstanceFixture, parametersOfOnModelCreating);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfOnModelCreating.ShouldNotBeNull();
            parametersOfOnModelCreating.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(parametersOfOnModelCreating.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PersistenceDBEntities_OnModelCreating_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var modelBuilder = this.CreateType<DbModelBuilder>();
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };
            object[] parametersOfOnModelCreating = { modelBuilder };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnModelCreating, parametersOfOnModelCreating, methodOnModelCreatingParametersTypes);

            // Assert
            parametersOfOnModelCreating.ShouldNotBeNull();
            parametersOfOnModelCreating.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            methodOnModelCreatingParametersTypes.Length.ShouldBe(parametersOfOnModelCreating.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PersistenceDBEntities_OnModelCreating_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PersistenceDBEntities_OnModelCreating_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var methodOnModelCreatingParametersTypes = new Type[] { typeof(DbModelBuilder) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnModelCreating, methodOnModelCreatingParametersTypes);

            // Assert
            methodOnModelCreatingParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnModelCreating) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PersistenceDBEntities_OnModelCreating_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnModelCreating);
            var currentMethodInfo = this.GetMethodInfo(MethodOnModelCreating, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}