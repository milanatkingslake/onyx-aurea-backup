using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.OnyxGatewayServiceConfiguration" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxGatewayServiceConfigurationTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayServiceConfiguration" />)
        /// </summary>
        public OnyxGatewayServiceConfigurationTest() : base(typeof(OnyxGatewayServiceConfiguration))
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

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayServiceConfigurationInstanceType;
        private OnyxGatewayServiceConfiguration _onyxGatewayServiceConfigurationInstance;
        private OnyxGatewayServiceConfiguration _onyxGatewayServiceConfigurationInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayServiceConfiguration" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayServiceConfigurationInstanceType = typeof(OnyxGatewayServiceConfiguration);
            _onyxGatewayServiceConfigurationInstanceFixture = this.Create<OnyxGatewayServiceConfiguration>(false);
            _onyxGatewayServiceConfigurationInstance = _onyxGatewayServiceConfigurationInstanceFixture ?? this.Create<OnyxGatewayServiceConfiguration>(true);
            CurrentInstance = _onyxGatewayServiceConfigurationInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) Initializer

        #region Properties

        private const string PropertyUniqueId = "UniqueId";
        private const string PropertyBaseAddress = "BaseAddress";
        private const string PropertyUserName = "UserName";
        private const string PropertyPassword = "Password";
        private const string PropertyAuthenticationType = "AuthenticationType";
        private const string PropertyDomainName = "DomainName";
        private const string PropertyApplication = "Application";
        private const string PropertySite = "Site";
        private const string PropertyLanguage = "Language";
        private const string PropertyDecryptedPassword = "DecryptedPassword";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfiguration_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfiguration_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceConfiguration_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayServiceConfiguration)

        #region General Initializer : Class (OnyxGatewayServiceConfiguration) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUniqueId)]
        [TestCase(PropertyBaseAddress)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyAuthenticationType)]
        [TestCase(PropertyDomainName)]
        [TestCase(PropertyApplication)]
        [TestCase(PropertySite)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyDecryptedPassword)]
        [Category("AUT Property")]
        public void AUT_OnyxGatewayServiceConfiguration_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxGatewayServiceConfiguration) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfiguration_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationInstanceType.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationInstance.ShouldNotBeNull();
            _onyxGatewayServiceConfigurationInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayServiceConfiguration) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceConfiguration" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceConfiguration_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayServiceConfigurationInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfiguration>();
            _onyxGatewayServiceConfigurationInstanceFixture.ShouldBeAssignableTo<OnyxGatewayServiceConfiguration>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayServiceConfiguration>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxGatewayServiceConfiguration) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxGatewayServiceConfiguration_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxGatewayServiceConfiguration instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUniqueId)]
        [TestCase(PropertyBaseAddress)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyAuthenticationType)]
        [TestCase(PropertyDomainName)]
        [TestCase(PropertyApplication)]
        [TestCase(PropertySite)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyDecryptedPassword)]
        public void AUT_OnyxGatewayServiceConfiguration_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (Application) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_Application_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApplication);
            var propertyInfo = this.GetPropertyInfo(PropertyApplication);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (AuthenticationType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_AuthenticationType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAuthenticationType);
            var propertyInfo = this.GetPropertyInfo(PropertyAuthenticationType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (BaseAddress) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_BaseAddress_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyBaseAddress);
            var propertyInfo = this.GetPropertyInfo(PropertyBaseAddress);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (DecryptedPassword) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_DecryptedPassword_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDecryptedPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyDecryptedPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (DomainName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_DomainName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDomainName);
            var propertyInfo = this.GetPropertyInfo(PropertyDomainName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (Password) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_Password_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (Site) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_Site_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySite);
            var propertyInfo = this.GetPropertyInfo(PropertySite);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (UniqueId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_UniqueId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxGatewayServiceConfiguration) => Property (UserName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxGatewayServiceConfiguration_Public_Class_UserName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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