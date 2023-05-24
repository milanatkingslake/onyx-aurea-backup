using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.UserGroupModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UserGroupModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserGroupModel" />)
        /// </summary>
        public UserGroupModelTest() : base(typeof(UserGroupModel))
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

        #region General Initializer : Class (UserGroupModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userGroupModelInstanceType;
        private UserGroupModel _userGroupModelInstance;
        private UserGroupModel _userGroupModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserGroupModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userGroupModelInstanceType = typeof(UserGroupModel);
            _userGroupModelInstanceFixture = this.Create<UserGroupModel>(false);
            _userGroupModelInstance = _userGroupModelInstanceFixture ?? this.Create<UserGroupModel>(true);
            CurrentInstance = _userGroupModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserGroupModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyType = "Type";
        private const string PropertyName = "Name";
        private const string PropertyEmail = "Email";

        #endregion

        #endregion

        #region General Initializer : Class (UserGroupModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserGroupModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserGroupModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserGroupModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserGroupModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserGroupModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserGroupModel)

        #region General Initializer : Class (UserGroupModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyType)]
        [TestCase(PropertyName)]
        [TestCase(PropertyEmail)]
        [Category("AUT Property")]
        public void AUT_UserGroupModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserGroupModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserGroupModel_Is_Instance_Present_Test()
        {
            // Assert
            _userGroupModelInstanceType.ShouldNotBeNull();
            _userGroupModelInstance.ShouldNotBeNull();
            _userGroupModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserGroupModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserGroupModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserGroupModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userGroupModelInstance.ShouldBeAssignableTo<UserGroupModel>();
            _userGroupModelInstanceFixture.ShouldBeAssignableTo<UserGroupModel>();
            CurrentInstance.ShouldBeAssignableTo<UserGroupModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserGroupModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserGroupModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserGroupModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserGroupModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyType)]
        [TestCase(PropertyName)]
        [TestCase(PropertyEmail)]
        public void AUT_UserGroupModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserGroupModel) => Property (Email) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserGroupModel_Public_Class_Email_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEmail);
            var propertyInfo = this.GetPropertyInfo(PropertyEmail);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserGroupModel) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserGroupModel_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserGroupModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserGroupModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserGroupModel) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserGroupModel_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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