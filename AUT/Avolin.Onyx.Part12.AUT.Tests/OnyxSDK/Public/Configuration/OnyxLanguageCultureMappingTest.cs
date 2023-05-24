using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Configuration;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Configuration
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Configuration.OnyxLanguageCultureMapping" />)
    ///     and namespace <see cref="OnyxSDK.Public.Configuration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxLanguageCultureMappingTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxLanguageCultureMapping" />)
        /// </summary>
        public OnyxLanguageCultureMappingTest() : base(typeof(OnyxLanguageCultureMapping))
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

        #region General Initializer : Class (OnyxLanguageCultureMapping) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxLanguageCultureMappingInstanceType;
        private OnyxLanguageCultureMapping _onyxLanguageCultureMappingInstance;
        private OnyxLanguageCultureMapping _onyxLanguageCultureMappingInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxLanguageCultureMapping" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxLanguageCultureMappingInstanceType = typeof(OnyxLanguageCultureMapping);
            _onyxLanguageCultureMappingInstanceFixture = this.Create<OnyxLanguageCultureMapping>(false);
            _onyxLanguageCultureMappingInstance = _onyxLanguageCultureMappingInstanceFixture ?? this.Create<OnyxLanguageCultureMapping>(true);
            CurrentInstance = _onyxLanguageCultureMappingInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMapping) Initializer

        #region Properties

        private const string PropertyLanguage = "Language";
        private const string PropertyUniqueId = "UniqueId";
        private const string PropertyCulture = "Culture";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMapping) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMapping" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLanguageCultureMapping_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxLanguageCultureMapping) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMapping" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLanguageCultureMapping_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxLanguageCultureMapping)

        #region General Initializer : Class (OnyxLanguageCultureMapping) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMapping" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyUniqueId)]
        [TestCase(PropertyCulture)]
        [Category("AUT Property")]
        public void AUT_OnyxLanguageCultureMapping_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxLanguageCultureMapping) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMapping" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxLanguageCultureMapping_Is_Instance_Present_Test()
        {
            // Assert
            _onyxLanguageCultureMappingInstanceType.ShouldNotBeNull();
            _onyxLanguageCultureMappingInstance.ShouldNotBeNull();
            _onyxLanguageCultureMappingInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxLanguageCultureMapping) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxLanguageCultureMapping" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxLanguageCultureMapping_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxLanguageCultureMappingInstance.ShouldBeAssignableTo<OnyxLanguageCultureMapping>();
            _onyxLanguageCultureMappingInstanceFixture.ShouldBeAssignableTo<OnyxLanguageCultureMapping>();
            CurrentInstance.ShouldBeAssignableTo<OnyxLanguageCultureMapping>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxLanguageCultureMapping) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxLanguageCultureMapping_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxLanguageCultureMapping instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxLanguageCultureMapping) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyUniqueId)]
        [TestCase(PropertyCulture)]
        public void AUT_OnyxLanguageCultureMapping_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxLanguageCultureMapping) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMapping_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxLanguageCultureMapping) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMapping_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguage);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxLanguageCultureMapping) => Property (UniqueId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxLanguageCultureMapping_Public_Class_UniqueId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUniqueId);
            var propertyInfo = this.GetPropertyInfo(PropertyUniqueId);

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