using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.SearchFilter" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SearchFilterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SearchFilter" />)
        /// </summary>
        public SearchFilterTest() : base(typeof(SearchFilter))
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

        #region General Initializer : Class (SearchFilter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _searchFilterInstanceType;
        private SearchFilter _searchFilterInstance;
        private SearchFilter _searchFilterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SearchFilter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _searchFilterInstanceType = typeof(SearchFilter);
            _searchFilterInstanceFixture = this.Create<SearchFilter>(false);
            _searchFilterInstance = _searchFilterInstanceFixture ?? this.Create<SearchFilter>(true);
            CurrentInstance = _searchFilterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SearchFilter) Initializer

        #region Properties

        private const string PropertyName = "Name";
        private const string PropertyDisplayName = "DisplayName";
        private const string PropertyType = "Type";
        private const string PropertyParent = "Parent";
        private const string PropertyFieldState = "FieldState";
        private const string PropertyPreferredOrder = "PreferredOrder";
        private const string PropertyControlType = "ControlType";
        private const string PropertyCacheName = "CacheName";
        private const string PropertyCacheParentId = "CacheParentId";
        private const string PropertyIsRequired = "IsRequired";

        #endregion

        #endregion

        #region General Initializer : Class (SearchFilter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchFilter) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilter_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SearchFilter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SearchFilter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SearchFilter)

        #region General Initializer : Class (SearchFilter) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertyPreferredOrder)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(PropertyIsRequired)]
        [Category("AUT Property")]
        public void AUT_SearchFilter_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SearchFilter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchFilter_Is_Instance_Present_Test()
        {
            // Assert
            _searchFilterInstanceType.ShouldNotBeNull();
            _searchFilterInstance.ShouldNotBeNull();
            _searchFilterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SearchFilter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SearchFilter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _searchFilterInstance.ShouldBeAssignableTo<SearchFilter>();
            _searchFilterInstanceFixture.ShouldBeAssignableTo<SearchFilter>();
            CurrentInstance.ShouldBeAssignableTo<SearchFilter>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SearchFilter) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SearchFilter instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (SearchFilter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var name = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            var type = this.CreateType<string>();
            var parentPanel = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var preferredOrder = this.CreateType<int>();
            var controlType = this.CreateType<string>();
            var cacheName = this.CreateType<string>();
            SearchFilter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SearchFilter(name, displayName, type, parentPanel, fieldState, preferredOrder, controlType, cacheName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _searchFilterInstance.ShouldNotBeNull();
            _searchFilterInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<SearchFilter>();
        }

        #endregion

        #region General Constructor : Class (SearchFilter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var name = this.CreateType<string>();
            var displayName = this.CreateType<string>();
            var type = this.CreateType<string>();
            var parentPanel = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var preferredOrder = this.CreateType<int>();
            var controlType = this.CreateType<string>();
            var cacheName = this.CreateType<string>();
            SearchFilter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new SearchFilter(name, displayName, type, parentPanel, fieldState, preferredOrder, controlType, cacheName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _searchFilterInstance.ShouldNotBeNull();
            _searchFilterInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (SearchFilter) instance created

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Is_Created_Test()
        {
            // Assert
            _searchFilterInstance.ShouldNotBeNull();
            _searchFilterInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (SearchFilter) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="SearchFilter" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_SearchFilter_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (SearchFilter) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="SearchFilter" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (SearchFilter) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SearchFilter" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodSearchFilterParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSearchFilterParametersTypes);
        }

        #endregion

        #region General Constructor : Class (SearchFilter) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="SearchFilter" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SearchFilter_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodSearchFilterParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodSearchFilterParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SearchFilter) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyName)]
        [TestCase(PropertyDisplayName)]
        [TestCase(PropertyType)]
        [TestCase(PropertyParent)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertyPreferredOrder)]
        [TestCase(PropertyControlType)]
        [TestCase(PropertyCacheName)]
        [TestCase(PropertyCacheParentId)]
        [TestCase(PropertyIsRequired)]
        public void AUT_SearchFilter_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SearchFilter) => Property (CacheName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_CacheName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (CacheParentId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_CacheParentId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (ControlType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_ControlType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (DisplayName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_DisplayName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (FieldState) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_FieldState_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (IsRequired) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_IsRequired_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (Parent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_Parent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (SearchFilter) => Property (PreferredOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_PreferredOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPreferredOrder);
            var propertyInfo = this.GetPropertyInfo(PropertyPreferredOrder);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (SearchFilter) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SearchFilter_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}