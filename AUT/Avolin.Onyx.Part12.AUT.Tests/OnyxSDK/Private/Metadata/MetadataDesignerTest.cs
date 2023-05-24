using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Private.Metadata;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Private.Metadata
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Private.Metadata.Metadata" />)
    ///     and namespace <see cref="OnyxSDK.Private.Metadata"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MetadataDesignerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="MetadataNonPublicTypeName" />) using
        ///     Using a public type <see cref="OnyxMetadata" /> to
        ///     create a non-public type.
        /// </summary>
        public MetadataDesignerTest() : base(publicType: typeof(OnyxMetadata), classNameWithNamespace: MetadataNonPublicTypeName)
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

        private Type _metadataInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string MetadataNonPublicTypeName = "OnyxSDK.Private.Metadata.Metadata";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _metadataInstance;
        private object _metadataInstanceFixture;

        #region General Initializer : Class (Metadata) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="Metadata" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _metadataInstanceFixture = this.CreateNonPublicType(MetadataNonPublicTypeName);
            _metadataInstance = _metadataInstanceFixture;
            CurrentInstance = _metadataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Metadata) Initializer

        #region Properties

        private const string PropertyResourceManager = "ResourceManager";
        private const string PropertyCulture = "Culture";
        private const string PropertyIDR_PARAMETERS_XSL = "IDR_PARAMETERS_XSL";

        #endregion

        #region Fields

        private const string FieldresourceMan = "resourceMan";
        private const string FieldresourceCulture = "resourceCulture";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (Metadata)

        #region General Initializer : Class (Metadata) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Metadata" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MetadataDesigner_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Metadata) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Metadata" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyIDR_PARAMETERS_XSL)]
        [Category("AUT Property")]
        public void AUT_MetadataDesigner_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Metadata) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Metadata" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MetadataDesigner_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (Metadata) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Metadata" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldresourceMan)]
        [TestCase(FieldresourceCulture)]
        [Category("AUT Fields")]
        public void AUT_MetadataDesigner_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Metadata) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Metadata" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MetadataDesigner_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Metadata) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResourceManager)]
        [TestCase(PropertyCulture)]
        [TestCase(PropertyIDR_PARAMETERS_XSL)]
        public void AUT_MetadataDesigner_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Metadata) => Property (Culture) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MetadataDesigner_Culture_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCulture);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyCulture);
            Action currentAction = () => propertyInfo.SetValue(_metadataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Metadata) => Property (Culture) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MetadataDesigner_Public_Class_Culture_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (Metadata) => Property (IDR_PARAMETERS_XSL) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MetadataDesigner_Public_Class_IDR_PARAMETERS_XSL_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIDR_PARAMETERS_XSL);
            var propertyInfo = this.GetPropertyInfo(PropertyIDR_PARAMETERS_XSL);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Metadata) => Property (ResourceManager) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MetadataDesigner_ResourceManager_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);
            Action currentAction = () => propertyInfo.SetValue(_metadataInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Metadata) => Property (ResourceManager) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MetadataDesigner_Public_Class_ResourceManager_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResourceManager);
            var propertyInfo = this.GetPropertyInfo(PropertyResourceManager);

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