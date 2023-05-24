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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.UserConfigurationView" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserConfigurationViewTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserConfigurationView" />)
        /// </summary>
        public UserConfigurationViewTest() : base(typeof(UserConfigurationView))
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

        #region General Initializer : Class (UserConfigurationView) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userConfigurationViewInstanceType;
        private UserConfigurationView _userConfigurationViewInstance;
        private UserConfigurationView _userConfigurationViewInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserConfigurationView" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userConfigurationViewInstanceType = typeof(UserConfigurationView);
            _userConfigurationViewInstanceFixture = this.Create<UserConfigurationView>(false);
            _userConfigurationViewInstance = _userConfigurationViewInstanceFixture ?? this.Create<UserConfigurationView>(true);
            CurrentInstance = _userConfigurationViewInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserConfigurationView) Initializer

        #region Properties

        private const string PropertyEntityId = "EntityId";
        private const string PropertyFieldId = "FieldId";
        private const string PropertyFieldName = "FieldName";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyType = "Type";
        private const string PropertyParent = "Parent";
        private const string PropertyControlType = "ControlType";
        private const string PropertyMaskFormat = "MaskFormat";
        private const string PropertyIsTransaction = "IsTransaction";
        private const string PropertyLinkedProperty = "LinkedProperty";
        private const string PropertyFieldSortOrder = "FieldSortOrder";
        private const string PropertyUseType = "UseType";
        private const string PropertyIsBatchUpdate = "IsBatchUpdate";
        private const string PropertyResourceName = "ResourceName";
        private const string PropertyCacheName = "CacheName";
        private const string PropertyCacheParentId = "CacheParentId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyWidth = "Width";
        private const string PropertyFieldState = "FieldState";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyUserId = "UserId";
        private const string PropertySortOrder = "SortOrder";
        private const string PropertyMaxRows = "MaxRows";

        #endregion

        #endregion

        #region General Initializer : Class (UserConfigurationView) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserConfigurationView_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserConfigurationView) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserConfigurationView_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserConfigurationView) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserConfigurationView_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserConfigurationView)

        #region General Initializer : Class (UserConfigurationView) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertyFieldName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyMaskFormat)]
        [TestCase(PropertyIsTransaction)]
        [TestCase(PropertyLinkedProperty)]
        [TestCase(PropertyFieldSortOrder)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertyIsBatchUpdate)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyMaxRows)]
        [Category("AUT Property")]
        public void AUT_UserConfigurationView_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserConfigurationView) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserConfigurationView_Is_Instance_Present_Test()
        {
            // Assert
            _userConfigurationViewInstanceType.ShouldNotBeNull();
            _userConfigurationViewInstance.ShouldNotBeNull();
            _userConfigurationViewInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserConfigurationView) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserConfigurationView" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserConfigurationView_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userConfigurationViewInstance.ShouldBeAssignableTo<UserConfigurationView>();
            _userConfigurationViewInstanceFixture.ShouldBeAssignableTo<UserConfigurationView>();
            CurrentInstance.ShouldBeAssignableTo<UserConfigurationView>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserConfigurationView) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserConfigurationView_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserConfigurationView instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserConfigurationView) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertyFieldName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyMaskFormat)]
        [TestCase(PropertyIsTransaction)]
        [TestCase(PropertyLinkedProperty)]
        [TestCase(PropertyFieldSortOrder)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertyIsBatchUpdate)]
        [TestCase(PropertyResourceName)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyMaxRows)]
        public void AUT_UserConfigurationView_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (CacheName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_CacheName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (CacheParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_CacheParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (ControlType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_ControlType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyControlType);
            var propertyInfo = this.GetPropertyInfo(PropertyControlType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDisplayName);
            var propertyInfo = this.GetPropertyInfo(PropertyDisplayName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (FieldId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_FieldId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldId);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (FieldName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_FieldName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldName);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (FieldSortOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_FieldSortOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldSortOrder);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldSortOrder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (FieldState) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_FieldState_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFieldState);
            var propertyInfo = this.GetPropertyInfo(PropertyFieldState);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (IsBatchUpdate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_IsBatchUpdate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsBatchUpdate);
            var propertyInfo = this.GetPropertyInfo(PropertyIsBatchUpdate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (IsTransaction) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_IsTransaction_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsTransaction);
            var propertyInfo = this.GetPropertyInfo(PropertyIsTransaction);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (LinkedProperty) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_LinkedProperty_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLinkedProperty);
            var propertyInfo = this.GetPropertyInfo(PropertyLinkedProperty);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (MaskFormat) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_MaskFormat_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaskFormat);
            var propertyInfo = this.GetPropertyInfo(PropertyMaskFormat);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (MaxRows) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_MaxRows_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMaxRows);
            var propertyInfo = this.GetPropertyInfo(PropertyMaxRows);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (Parent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_Parent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParent);
            var propertyInfo = this.GetPropertyInfo(PropertyParent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (ResourceName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_ResourceName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (SortOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_SortOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserConfigurationView) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (UseType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_UseType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUseType);
            var propertyInfo = this.GetPropertyInfo(PropertyUseType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserConfigurationView) => Property (Width) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserConfigurationView_Public_Class_Width_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWidth);
            var propertyInfo = this.GetPropertyInfo(PropertyWidth);

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