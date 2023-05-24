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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.navigator_user_access" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class NavigatoruseraccessTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="navigator_user_access" />)
        /// </summary>
        public NavigatoruseraccessTest() : base(typeof(navigator_user_access))
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

        #region General Initializer : Class (navigator_user_access) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatoruseraccessInstanceType;
        private navigator_user_access _navigatoruseraccessInstance;
        private navigator_user_access _navigatoruseraccessInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="navigator_user_access" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatoruseraccessInstanceType = typeof(navigator_user_access);
            _navigatoruseraccessInstanceFixture = this.Create<navigator_user_access>(false);
            _navigatoruseraccessInstance = _navigatoruseraccessInstanceFixture ?? this.Create<navigator_user_access>(true);
            CurrentInstance = _navigatoruseraccessInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (navigator_user_access) Initializer

        #region Properties

        private const string Propertyuser_id = "user_id";
        private const string Propertyentity_id = "entity_id";
        private const string Propertysearch_RLC_fields = "search_RLC_fields";
        private const string Propertybrowse_RLC_fields = "browse_RLC_fields";
        private const string Propertyfilter_fields = "filter_fields";
        private const string Propertymax_records = "max_records";
        private const string Propertyis_active = "is_active";
        private const string Propertysort_order = "sort_order";

        #endregion

        #endregion

        #region General Initializer : Class (navigator_user_access) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruseraccess_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_user_access) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruseraccess_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (navigator_user_access) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Navigatoruseraccess_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (navigator_user_access)

        #region General Initializer : Class (navigator_user_access) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysearch_RLC_fields)]
        [TestCase(Propertybrowse_RLC_fields)]
        [TestCase(Propertyfilter_fields)]
        [TestCase(Propertymax_records)]
        [TestCase(Propertyis_active)]
        [TestCase(Propertysort_order)]
        [Category("AUT Property")]
        public void AUT_Navigatoruseraccess_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (navigator_user_access) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatoruseraccess_Is_Instance_Present_Test()
        {
            // Assert
            _navigatoruseraccessInstanceType.ShouldNotBeNull();
            _navigatoruseraccessInstance.ShouldNotBeNull();
            _navigatoruseraccessInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (navigator_user_access) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="navigator_user_access" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Navigatoruseraccess_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatoruseraccessInstance.ShouldBeAssignableTo<navigator_user_access>();
            _navigatoruseraccessInstanceFixture.ShouldBeAssignableTo<navigator_user_access>();
            CurrentInstance.ShouldBeAssignableTo<navigator_user_access>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (navigator_user_access) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Navigatoruseraccess_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            navigator_user_access instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (navigator_user_access) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertyuser_id)]
        [TestCase(Propertyentity_id)]
        [TestCase(Propertysearch_RLC_fields)]
        [TestCase(Propertybrowse_RLC_fields)]
        [TestCase(Propertyfilter_fields)]
        [TestCase(Propertymax_records)]
        [TestCase(Propertyis_active)]
        [TestCase(Propertysort_order)]
        public void AUT_Navigatoruseraccess_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (navigator_user_access) => Property (browse_RLC_fields) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_browse_RLC_fields_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertybrowse_RLC_fields);
            var propertyInfo = this.GetPropertyInfo(Propertybrowse_RLC_fields);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_access) => Property (entity_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_entity_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_user_access) => Property (filter_fields) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_filter_fields_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyfilter_fields);
            var propertyInfo = this.GetPropertyInfo(Propertyfilter_fields);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_access) => Property (is_active) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_is_active_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyis_active);
            var propertyInfo = this.GetPropertyInfo(Propertyis_active);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_access) => Property (max_records) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_max_records_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_user_access) => Property (search_RLC_fields) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_search_RLC_fields_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertysearch_RLC_fields);
            var propertyInfo = this.GetPropertyInfo(Propertysearch_RLC_fields);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (navigator_user_access) => Property (sort_order) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_sort_order_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (navigator_user_access) => Property (user_id) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Navigatoruseraccess_Public_Class_user_id_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertyuser_id);
            var propertyInfo = this.GetPropertyInfo(Propertyuser_id);

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