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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_entity_custom_cache" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatorentitycustomcacheTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_entity_custom_cache" />)
        /// </summary>
        public NavigatorentitycustomcacheTest() : base(typeof(navigator_entity_custom_cache))
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

        #region General Initializer : Class (navigator_entity_custom_cache) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorentitycustomcacheInstanceType;
        private navigator_entity_custom_cache _navigatorentitycustomcacheInstance;
        private navigator_entity_custom_cache _navigatorentitycustomcacheInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_entity_custom_cache" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorentitycustomcacheInstanceType = typeof(navigator_entity_custom_cache);
            _navigatorentitycustomcacheInstanceFixture = this.Create<navigator_entity_custom_cache>(false);
            _navigatorentitycustomcacheInstance = _navigatorentitycustomcacheInstanceFixture ?? this.Create<navigator_entity_custom_cache>(true);
            CurrentInstance = _navigatorentitycustomcacheInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_entity_custom_cache) Initializer

        #region Properties

        private const string PropertySiteId = "SiteId";
        private const string PropertyReferenceId = "ReferenceId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyCacheName = "CacheName";
        private const string PropertyValue = "Value";
        private const string PropertyDescription = "Description";
        private const string PropertyParentId = "ParentId";
        private const string PropertyObjectName = "ObjectName";
        private const string PropertyMethodName = "MethodName";
        private const string PropertyParameter = "Parameter";
        private const string Propertyinsert_by = "insert_by";
        private const string Propertyinsert_date = "insert_date";
        private const string Propertyupdate_by = "update_by";
        private const string Propertyupdate_date = "update_date";
        private const string Propertydelete_status = "delete_status";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_entity_custom_cache) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitycustomcache_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_custom_cache) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitycustomcache_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_entity_custom_cache) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatorentitycustomcache_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_entity_custom_cache)

        #region General Initializer : Class (navigator_entity_custom_cache) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyParameter)]
        [TestCase(Propertyinsert_by)]
        [TestCase(Propertyinsert_date)]
        [TestCase(Propertyupdate_by)]
        [TestCase(Propertyupdate_date)]
        [TestCase(Propertydelete_status)]
        [Category("AUT Property")]
        public void AUT_Navigatorentitycustomcache_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_entity_custom_cache) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitycustomcache_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorentitycustomcacheInstanceType.ShouldNotBeNull();
            _navigatorentitycustomcacheInstance.ShouldNotBeNull();
            _navigatorentitycustomcacheInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_entity_custom_cache) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_entity_custom_cache" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatorentitycustomcache_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorentitycustomcacheInstance.ShouldBeAssignableTo<navigator_entity_custom_cache>();
            _navigatorentitycustomcacheInstanceFixture.ShouldBeAssignableTo<navigator_entity_custom_cache>();
            CurrentInstance.ShouldBeAssignableTo<navigator_entity_custom_cache>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_entity_custom_cache) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatorentitycustomcache_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_entity_custom_cache instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyReferenceId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyValue)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyParentId)]
        [TestCase(PropertyObjectName)]
        [TestCase(PropertyMethodName)]
        [TestCase(PropertyParameter)]
        [TestCase(Propertyinsert_by)]
        [TestCase(Propertyinsert_date)]
        [TestCase(Propertyupdate_by)]
        [TestCase(Propertyupdate_date)]
        [TestCase(Propertydelete_status)]
        public void AUT_Navigatorentitycustomcache_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (CacheName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_CacheName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (delete_status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_delete_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (insert_by) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_insert_by_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_by);
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_by);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (insert_date) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_insert_date_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_date);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_date);
            Action currentAction = () => propertyInfo.SetValue(_navigatorentitycustomcacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (insert_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_insert_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyinsert_date);
            var propertyInfo = this.GetPropertyInfo(Propertyinsert_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (MethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_MethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (ObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_ObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (Parameter) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_Parameter_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameter);
            var propertyInfo = this.GetPropertyInfo(PropertyParameter);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (ParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_ParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParentId);
            var propertyInfo = this.GetPropertyInfo(PropertyParentId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (ReferenceId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_ReferenceId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferenceId);
            var propertyInfo = this.GetPropertyInfo(PropertyReferenceId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (update_by) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_update_by_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_by);
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_by);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (update_date) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_update_date_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_date);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_date);
            Action currentAction = () => propertyInfo.SetValue(_navigatorentitycustomcacheInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (update_date) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_update_date_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyupdate_date);
            var propertyInfo = this.GetPropertyInfo(Propertyupdate_date);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_entity_custom_cache) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatorentitycustomcache_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValue);
            var propertyInfo = this.GetPropertyInfo(PropertyValue);

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