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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.UserSearchModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UserSearchModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserSearchModel" />)
        /// </summary>
        public UserSearchModelTest() : base(typeof(UserSearchModel))
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

        #region General Initializer : Class (UserSearchModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userSearchModelInstanceType;
        private UserSearchModel _userSearchModelInstance;
        private UserSearchModel _userSearchModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserSearchModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userSearchModelInstanceType = typeof(UserSearchModel);
            _userSearchModelInstanceFixture = this.Create<UserSearchModel>(false);
            _userSearchModelInstance = _userSearchModelInstanceFixture ?? this.Create<UserSearchModel>(true);
            CurrentInstance = _userSearchModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserSearchModel) Initializer

        #region Properties

        private const string PropertyUserId = "UserId";
        private const string PropertyUserName = "UserName";
        private const string PropertyGroupName = "GroupName";

        #endregion

        #endregion

        #region General Initializer : Class (UserSearchModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserSearchModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserSearchModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserSearchModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserSearchModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserSearchModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserSearchModel)

        #region General Initializer : Class (UserSearchModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyGroupName)]
        [Category("AUT Property")]
        public void AUT_UserSearchModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (UserSearchModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserSearchModel_Is_Instance_Present_Test()
        {
            // Assert
            _userSearchModelInstanceType.ShouldNotBeNull();
            _userSearchModelInstance.ShouldNotBeNull();
            _userSearchModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserSearchModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserSearchModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserSearchModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userSearchModelInstance.ShouldBeAssignableTo<UserSearchModel>();
            _userSearchModelInstanceFixture.ShouldBeAssignableTo<UserSearchModel>();
            CurrentInstance.ShouldBeAssignableTo<UserSearchModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserSearchModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserSearchModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserSearchModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (UserSearchModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyGroupName)]
        public void AUT_UserSearchModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (UserSearchModel) => Property (GroupName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserSearchModel_Public_Class_GroupName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyGroupName);
            var propertyInfo = this.GetPropertyInfo(PropertyGroupName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (UserSearchModel) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserSearchModel_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (UserSearchModel) => Property (UserName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_UserSearchModel_Public_Class_UserName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserName);
            var propertyInfo = this.GetPropertyInfo(PropertyUserName);

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