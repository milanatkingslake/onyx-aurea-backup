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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Persistence.ActionButtonMl" />)
    ///     and namespace <see cref="OnyxISAPI.Persistence"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ActionButtonMlTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ActionButtonMl" />)
        /// </summary>
        public ActionButtonMlTest() : base(typeof(ActionButtonMl))
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

        #region General Initializer : Class (ActionButtonMl) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _actionButtonMlInstanceType;
        private ActionButtonMl _actionButtonMlInstance;
        private ActionButtonMl _actionButtonMlInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ActionButtonMl" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _actionButtonMlInstanceType = typeof(ActionButtonMl);
            _actionButtonMlInstanceFixture = this.Create<ActionButtonMl>(false);
            _actionButtonMlInstance = _actionButtonMlInstanceFixture ?? this.Create<ActionButtonMl>(true);
            CurrentInstance = _actionButtonMlInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ActionButtonMl) Initializer

        #region Properties

        private const string PropertyActionButtonId = "ActionButtonId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyCaption = "Caption";
        private const string PropertyActionButton = "ActionButton";

        #endregion

        #endregion

        #region General Initializer : Class (ActionButtonMl) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMl_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionButtonMl) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMl_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ActionButtonMl) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ActionButtonMl_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ActionButtonMl)

        #region General Initializer : Class (ActionButtonMl) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyActionButtonId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCaption)]
        [TestCase(PropertyActionButton)]
        [Category("AUT Property")]
        public void AUT_ActionButtonMl_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ActionButtonMl) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionButtonMl_Is_Instance_Present_Test()
        {
            // Assert
            _actionButtonMlInstanceType.ShouldNotBeNull();
            _actionButtonMlInstance.ShouldNotBeNull();
            _actionButtonMlInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ActionButtonMl) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ActionButtonMl" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ActionButtonMl_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _actionButtonMlInstance.ShouldBeAssignableTo<ActionButtonMl>();
            _actionButtonMlInstanceFixture.ShouldBeAssignableTo<ActionButtonMl>();
            CurrentInstance.ShouldBeAssignableTo<ActionButtonMl>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ActionButtonMl) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ActionButtonMl_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ActionButtonMl instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ActionButtonMl) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyActionButtonId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyCaption)]
        [TestCase(PropertyActionButton)]
        public void AUT_ActionButtonMl_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ActionButtonMl) => Property (ActionButton) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_ActionButton_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButton);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyActionButton);
            Action currentAction = () => propertyInfo.SetValue(_actionButtonMlInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMl) => Property (ActionButton) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_Public_Class_ActionButton_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ActionButtonMl) => Property (ActionButtonId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_Public_Class_ActionButtonId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyActionButtonId);
            var propertyInfo = this.GetPropertyInfo(PropertyActionButtonId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMl) => Property (Caption) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_Public_Class_Caption_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCaption);
            var propertyInfo = this.GetPropertyInfo(PropertyCaption);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ActionButtonMl) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ActionButtonMl) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ActionButtonMl_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}