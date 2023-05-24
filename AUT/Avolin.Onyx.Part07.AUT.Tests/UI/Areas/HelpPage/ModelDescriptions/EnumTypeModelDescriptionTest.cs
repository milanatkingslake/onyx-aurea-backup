using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.ModelDescriptions;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.ModelDescriptions
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.EnumTypeModelDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EnumTypeModelDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EnumTypeModelDescription" />)
        /// </summary>
        public EnumTypeModelDescriptionTest() : base(typeof(EnumTypeModelDescription))
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

        #region General Initializer : Class (EnumTypeModelDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _enumTypeModelDescriptionInstanceType;
        private EnumTypeModelDescription _enumTypeModelDescriptionInstance;
        private EnumTypeModelDescription _enumTypeModelDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EnumTypeModelDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _enumTypeModelDescriptionInstanceType = typeof(EnumTypeModelDescription);
            _enumTypeModelDescriptionInstanceFixture = this.Create<EnumTypeModelDescription>(false);
            _enumTypeModelDescriptionInstance = _enumTypeModelDescriptionInstanceFixture ?? this.Create<EnumTypeModelDescription>(true);
            CurrentInstance = _enumTypeModelDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EnumTypeModelDescription) Initializer

        #region Properties

        private const string PropertyValues = "Values";

        #endregion

        #endregion

        #region General Initializer : Class (EnumTypeModelDescription) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumTypeModelDescription_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EnumTypeModelDescription) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumTypeModelDescription_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EnumTypeModelDescription) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumTypeModelDescription_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EnumTypeModelDescription)

        #region General Initializer : Class (EnumTypeModelDescription) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyValues)]
        [Category("AUT Property")]
        public void AUT_EnumTypeModelDescription_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EnumTypeModelDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EnumTypeModelDescription_Is_Instance_Present_Test()
        {
            // Assert
            _enumTypeModelDescriptionInstanceType.ShouldNotBeNull();
            _enumTypeModelDescriptionInstance.ShouldNotBeNull();
            _enumTypeModelDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EnumTypeModelDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EnumTypeModelDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EnumTypeModelDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _enumTypeModelDescriptionInstance.ShouldBeAssignableTo<EnumTypeModelDescription>();
            _enumTypeModelDescriptionInstanceFixture.ShouldBeAssignableTo<EnumTypeModelDescription>();
            CurrentInstance.ShouldBeAssignableTo<EnumTypeModelDescription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EnumTypeModelDescription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EnumTypeModelDescription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            EnumTypeModelDescription instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (EnumTypeModelDescription) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EnumTypeModelDescription_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var enumTypeModelDescriptionInstance  = new EnumTypeModelDescription();

            // Asserts
            enumTypeModelDescriptionInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (EnumTypeModelDescription) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyValues)]
        public void AUT_EnumTypeModelDescription_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (EnumTypeModelDescription) => Property (Values) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EnumTypeModelDescription_Public_Class_Values_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValues);
            var propertyInfo = this.GetPropertyInfo(PropertyValues);

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