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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.UserEntityConfiguration" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserEntityConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserEntityConfiguration" />)
        /// </summary>
        public UserEntityConfigurationTest() : base(typeof(UserEntityConfiguration))
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

        #region General Initializer : Class (UserEntityConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userEntityConfigurationInstanceType;
        private UserEntityConfiguration _userEntityConfigurationInstance;
        private UserEntityConfiguration _userEntityConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserEntityConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userEntityConfigurationInstanceType = typeof(UserEntityConfiguration);
            _userEntityConfigurationInstanceFixture = this.Create<UserEntityConfiguration>(false);
            _userEntityConfigurationInstance = _userEntityConfigurationInstanceFixture ?? this.Create<UserEntityConfiguration>(true);
            CurrentInstance = _userEntityConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserEntityConfiguration) Initializer

        #region Properties

        private const string PropertyUserConfigId = "UserConfigId";
        private const string PropertyUserId = "UserId";
        private const string PropertyEntityId = "EntityId";
        private const string PropertyUseType = "UseType";
        private const string PropertySortOrder = "SortOrder";
        private const string PropertyMaxRows = "MaxRows";
        
        private const string PropertySiteId = "SiteId";

        #endregion

        #endregion

        #region General Initializer : Class (UserEntityConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserEntityConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserEntityConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserEntityConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserEntityConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserEntityConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserEntityConfiguration)

        #region General Initializer : Class (UserEntityConfiguration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserConfigId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyMaxRows)]
        [TestCase(PropertySiteId)]
        [Category("AUT Property")]
        public void AUT_UserEntityConfiguration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserEntityConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserEntityConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _userEntityConfigurationInstanceType.ShouldNotBeNull();
            _userEntityConfigurationInstance.ShouldNotBeNull();
            _userEntityConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserEntityConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserEntityConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserEntityConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userEntityConfigurationInstance.ShouldBeAssignableTo<UserEntityConfiguration>();
            _userEntityConfigurationInstanceFixture.ShouldBeAssignableTo<UserEntityConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<UserEntityConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserEntityConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserEntityConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserEntityConfiguration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserEntityConfiguration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserConfigId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertySortOrder)]
        [TestCase(PropertyMaxRows)]
        [TestCase(PropertySiteId)]
        public void AUT_UserEntityConfiguration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (MaxRows) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_MaxRows_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (SortOrder) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_SortOrder_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (UserConfigId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_UserConfigId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserConfigId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserConfigId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserEntityConfiguration) => Property (UseType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserEntityConfiguration_Public_Class_UseType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}