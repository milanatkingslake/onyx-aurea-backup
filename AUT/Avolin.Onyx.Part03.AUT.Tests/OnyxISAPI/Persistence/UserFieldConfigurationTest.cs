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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.UserFieldConfiguration" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserFieldConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserFieldConfiguration" />)
        /// </summary>
        public UserFieldConfigurationTest() : base(typeof(UserFieldConfiguration))
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

        #region General Initializer : Class (UserFieldConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userFieldConfigurationInstanceType;
        private UserFieldConfiguration _userFieldConfigurationInstance;
        private UserFieldConfiguration _userFieldConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserFieldConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userFieldConfigurationInstanceType = typeof(UserFieldConfiguration);
            _userFieldConfigurationInstanceFixture = this.Create<UserFieldConfiguration>(false);
            _userFieldConfigurationInstance = _userFieldConfigurationInstanceFixture ?? this.Create<UserFieldConfiguration>(true);
            CurrentInstance = _userFieldConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserFieldConfiguration) Initializer

        #region Properties

        private const string PropertyConfigId = "ConfigId";
        private const string PropertyUserId = "UserId";
        private const string PropertyFieldId = "FieldId";
        private const string PropertyEntityId = "EntityId";
        private const string PropertySequenceIndex = "SequenceIndex";
        private const string PropertyFieldState = "FieldState";
        private const string PropertyWidth = "Width";
        private const string PropertyUseType = "UseType";
        private const string PropertySiteId = "SiteId";
        private const string PropertyIsRequired = "IsRequired";

        #endregion

        #endregion

        #region General Initializer : Class (UserFieldConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserFieldConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserFieldConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserFieldConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserFieldConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserFieldConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserFieldConfiguration)

        #region General Initializer : Class (UserFieldConfiguration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfigId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyIsRequired)]
        [Category("AUT Property")]
        public void AUT_UserFieldConfiguration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserFieldConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserFieldConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _userFieldConfigurationInstanceType.ShouldNotBeNull();
            _userFieldConfigurationInstance.ShouldNotBeNull();
            _userFieldConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserFieldConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserFieldConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserFieldConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userFieldConfigurationInstance.ShouldBeAssignableTo<UserFieldConfiguration>();
            _userFieldConfigurationInstanceFixture.ShouldBeAssignableTo<UserFieldConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<UserFieldConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserFieldConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserFieldConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserFieldConfiguration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserFieldConfiguration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfigId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyFieldId)]
        [TestCase(PropertyEntityId)]
        [TestCase(PropertySequenceIndex)]
        [TestCase(PropertyFieldState)]
        [TestCase(PropertyWidth)]
        [TestCase(PropertyUseType)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyIsRequired)]
        public void AUT_UserFieldConfiguration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (ConfigId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_ConfigId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfigId);
            var propertyInfo = this.GetPropertyInfo(PropertyConfigId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (EntityId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_EntityId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (FieldId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_FieldId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (FieldState) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_FieldState_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (IsRequired) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_IsRequired_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (SequenceIndex) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_SequenceIndex_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (UseType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_UseType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserFieldConfiguration) => Property (Width) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserFieldConfiguration_Public_Class_Width_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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