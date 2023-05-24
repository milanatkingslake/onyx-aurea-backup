using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ExtensionSettings" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ExtensionSettingsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExtensionSettings" />)
        /// </summary>
        public ExtensionSettingsTest() : base(typeof(ExtensionSettings))
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

        #region General Initializer : Class (ExtensionSettings) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _extensionSettingsInstanceType;
        private ExtensionSettings _extensionSettingsInstance;
        private ExtensionSettings _extensionSettingsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ExtensionSettings" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _extensionSettingsInstanceType = typeof(ExtensionSettings);
            _extensionSettingsInstanceFixture = this.Create<ExtensionSettings>(false);
            _extensionSettingsInstance = _extensionSettingsInstanceFixture ?? this.Create<ExtensionSettings>(true);
            CurrentInstance = _extensionSettingsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExtensionSettings) Initializer

        #region Properties

        private const string PropertyParameterValues = "ParameterValues";

        #endregion

        #region Fields

        private const string FieldextensionField = "extensionField";
        private const string FieldparameterValuesField = "parameterValuesField";

        #endregion

        #endregion

        #region General Initializer : Class (ExtensionSettings) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionSettings_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionSettings) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionSettings_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ExtensionSettings) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ExtensionSettings_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExtensionSettings)

        #region General Initializer : Class (ExtensionSettings) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyParameterValues)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ExtensionSettings_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ExtensionSettings) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldextensionField)]
        [TestCase(FieldparameterValuesField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ExtensionSettings_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (ExtensionSettings) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExtensionSettings_Is_Instance_Present_Test()
        {
            // Assert
            _extensionSettingsInstanceType.ShouldNotBeNull();
            _extensionSettingsInstance.ShouldNotBeNull();
            _extensionSettingsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ExtensionSettings) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ExtensionSettings" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ExtensionSettings_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _extensionSettingsInstance.ShouldBeAssignableTo<ExtensionSettings>();
            _extensionSettingsInstanceFixture.ShouldBeAssignableTo<ExtensionSettings>();
            CurrentInstance.ShouldBeAssignableTo<ExtensionSettings>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ExtensionSettings) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ExtensionSettings_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ExtensionSettings instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ExtensionSettings) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyParameterValues)]
        public void AUT_ExtensionSettings_Property_Exist_By_Name_Verify_Test(string name)
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
        
        #region General Getters/Setters : Class (ExtensionSettings) => Property (ParameterValues) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionSettings_ParameterValues_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterValues);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyParameterValues);
            Action currentAction = () => propertyInfo.SetValue(_extensionSettingsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ExtensionSettings) => Property (ParameterValues) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ExtensionSettings_Public_Class_ParameterValues_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParameterValues);
            var propertyInfo = this.GetPropertyInfo(PropertyParameterValues);

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