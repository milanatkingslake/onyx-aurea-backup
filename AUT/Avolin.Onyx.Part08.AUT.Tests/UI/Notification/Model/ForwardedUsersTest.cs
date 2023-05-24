using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Notification.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Notification.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Notification.Model.ForwardedUsers" />)
    ///     and namespace <see cref="Onyx.UI.Notification.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ForwardedUsersTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ForwardedUsers" />)
        /// </summary>
        public ForwardedUsersTest() : base(typeof(ForwardedUsers))
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

        #region General Initializer : Class (ForwardedUsers) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _forwardedUsersInstanceType;
        private ForwardedUsers _forwardedUsersInstance;
        private ForwardedUsers _forwardedUsersInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ForwardedUsers" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _forwardedUsersInstanceType = typeof(ForwardedUsers);
            _forwardedUsersInstanceFixture = this.Create<ForwardedUsers>(false);
            _forwardedUsersInstance = _forwardedUsersInstanceFixture ?? this.Create<ForwardedUsers>(true);
            CurrentInstance = _forwardedUsersInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ForwardedUsers) Initializer

        #region Properties

        private const string PropertyUser = "User";

        #endregion

        #endregion

        #region General Initializer : Class (ForwardedUsers) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ForwardedUsers_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ForwardedUsers) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ForwardedUsers_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ForwardedUsers) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ForwardedUsers_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ForwardedUsers)

        #region General Initializer : Class (ForwardedUsers) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUser)]
        [Category("AUT Property")]
        public void AUT_ForwardedUsers_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ForwardedUsers) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ForwardedUsers_Is_Instance_Present_Test()
        {
            // Assert
            _forwardedUsersInstanceType.ShouldNotBeNull();
            _forwardedUsersInstance.ShouldNotBeNull();
            _forwardedUsersInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ForwardedUsers) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ForwardedUsers" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ForwardedUsers_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _forwardedUsersInstance.ShouldBeAssignableTo<ForwardedUsers>();
            _forwardedUsersInstanceFixture.ShouldBeAssignableTo<ForwardedUsers>();
            CurrentInstance.ShouldBeAssignableTo<ForwardedUsers>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ForwardedUsers) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ForwardedUsers_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ForwardedUsers instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ForwardedUsers) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUser)]
        public void AUT_ForwardedUsers_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ForwardedUsers) => Property (User) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ForwardedUsers_Public_Class_User_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUser);
            var propertyInfo = this.GetPropertyInfo(PropertyUser);

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