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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions.KeyValuePairModelDescription" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.ModelDescriptions"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class KeyValuePairModelDescriptionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="KeyValuePairModelDescription" />)
        /// </summary>
        public KeyValuePairModelDescriptionTest() : base(typeof(KeyValuePairModelDescription))
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

        #region General Initializer : Class (KeyValuePairModelDescription) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _keyValuePairModelDescriptionInstanceType;
        private KeyValuePairModelDescription _keyValuePairModelDescriptionInstance;
        private KeyValuePairModelDescription _keyValuePairModelDescriptionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="KeyValuePairModelDescription" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _keyValuePairModelDescriptionInstanceType = typeof(KeyValuePairModelDescription);
            _keyValuePairModelDescriptionInstanceFixture = this.Create<KeyValuePairModelDescription>(false);
            _keyValuePairModelDescriptionInstance = _keyValuePairModelDescriptionInstanceFixture ?? this.Create<KeyValuePairModelDescription>(true);
            CurrentInstance = _keyValuePairModelDescriptionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (KeyValuePairModelDescription) Initializer

        #region Properties

        private const string PropertyKeyModelDescription = "KeyModelDescription";
        private const string PropertyValueModelDescription = "ValueModelDescription";

        #endregion

        #endregion

        #region General Initializer : Class (KeyValuePairModelDescription) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_KeyValuePairModelDescription_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (KeyValuePairModelDescription) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_KeyValuePairModelDescription_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (KeyValuePairModelDescription) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_KeyValuePairModelDescription_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (KeyValuePairModelDescription)

        #region General Initializer : Class (KeyValuePairModelDescription) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyKeyModelDescription)]
        [TestCase(PropertyValueModelDescription)]
        [Category("AUT Property")]
        public void AUT_KeyValuePairModelDescription_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (KeyValuePairModelDescription) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_KeyValuePairModelDescription_Is_Instance_Present_Test()
        {
            // Assert
            _keyValuePairModelDescriptionInstanceType.ShouldNotBeNull();
            _keyValuePairModelDescriptionInstance.ShouldNotBeNull();
            _keyValuePairModelDescriptionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (KeyValuePairModelDescription) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="KeyValuePairModelDescription" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_KeyValuePairModelDescription_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _keyValuePairModelDescriptionInstance.ShouldBeAssignableTo<KeyValuePairModelDescription>();
            _keyValuePairModelDescriptionInstanceFixture.ShouldBeAssignableTo<KeyValuePairModelDescription>();
            CurrentInstance.ShouldBeAssignableTo<KeyValuePairModelDescription>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (KeyValuePairModelDescription) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_KeyValuePairModelDescription_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            KeyValuePairModelDescription instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (KeyValuePairModelDescription) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyKeyModelDescription)]
        [TestCase(PropertyValueModelDescription)]
        public void AUT_KeyValuePairModelDescription_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (KeyValuePairModelDescription) => Property (KeyModelDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_KeyValuePairModelDescription_KeyModelDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKeyModelDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyKeyModelDescription);
            Action currentAction = () => propertyInfo.SetValue(_keyValuePairModelDescriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (KeyValuePairModelDescription) => Property (KeyModelDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_KeyValuePairModelDescription_Public_Class_KeyModelDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyKeyModelDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyKeyModelDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (KeyValuePairModelDescription) => Property (ValueModelDescription) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_KeyValuePairModelDescription_ValueModelDescription_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValueModelDescription);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyValueModelDescription);
            Action currentAction = () => propertyInfo.SetValue(_keyValuePairModelDescriptionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (KeyValuePairModelDescription) => Property (ValueModelDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_KeyValuePairModelDescription_Public_Class_ValueModelDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyValueModelDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyValueModelDescription);

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