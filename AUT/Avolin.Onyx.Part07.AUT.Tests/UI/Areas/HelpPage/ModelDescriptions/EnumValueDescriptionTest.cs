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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.EnumValueDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class EnumValueDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="EnumValueDescription" />)
        /// </summary>
        public EnumValueDescriptionTest() : base(typeof(EnumValueDescription))
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

        #region General Initializer : Class (EnumValueDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _enumValueDescriptionInstanceType;
        private EnumValueDescription _enumValueDescriptionInstance;
        private EnumValueDescription _enumValueDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="EnumValueDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _enumValueDescriptionInstanceType = typeof(EnumValueDescription);
            _enumValueDescriptionInstanceFixture = this.Create<EnumValueDescription>(false);
            _enumValueDescriptionInstance = _enumValueDescriptionInstanceFixture ?? this.Create<EnumValueDescription>(true);
            CurrentInstance = _enumValueDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (EnumValueDescription) Initializer

        #region Properties

        private const string PropertyDocumentation = "Documentation";
        private const string PropertyName = "Name";
        private const string PropertyValue = "Value";

        #endregion

        #endregion

        #region General Initializer : Class (EnumValueDescription) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumValueDescription_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EnumValueDescription) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumValueDescription_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (EnumValueDescription) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_EnumValueDescription_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (EnumValueDescription)

        #region General Initializer : Class (EnumValueDescription) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyDocumentation)]
        [TestCase(PropertyName)]
        [TestCase(PropertyValue)]
        [Category("AUT Property")]
        public void AUT_EnumValueDescription_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (EnumValueDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EnumValueDescription_Is_Instance_Present_Test()
        {
            // Assert
            _enumValueDescriptionInstanceType.ShouldNotBeNull();
            _enumValueDescriptionInstance.ShouldNotBeNull();
            _enumValueDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (EnumValueDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="EnumValueDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_EnumValueDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _enumValueDescriptionInstance.ShouldBeAssignableTo<EnumValueDescription>();
            _enumValueDescriptionInstanceFixture.ShouldBeAssignableTo<EnumValueDescription>();
            CurrentInstance.ShouldBeAssignableTo<EnumValueDescription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (EnumValueDescription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_EnumValueDescription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            EnumValueDescription instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (EnumValueDescription) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyDocumentation)]
        [TestCase(PropertyName)]
        [TestCase(PropertyValue)]
        public void AUT_EnumValueDescription_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (EnumValueDescription) => Property (Documentation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EnumValueDescription_Public_Class_Documentation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDocumentation);
            var propertyInfo = this.GetPropertyInfo(PropertyDocumentation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (EnumValueDescription) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EnumValueDescription_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (EnumValueDescription) => Property (Value) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_EnumValueDescription_Public_Class_Value_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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