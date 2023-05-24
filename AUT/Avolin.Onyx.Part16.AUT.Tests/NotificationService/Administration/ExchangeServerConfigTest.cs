using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.ExchangeServerConfig" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExchangeServerConfigTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="ExchangeServerConfigNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public ExchangeServerConfigTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: ExchangeServerConfigNonPublicTypeName)
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

        private Type _exchangeServerConfigInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string ExchangeServerConfigNonPublicTypeName = "NotificationService.Administration.ExchangeServerConfig";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _exchangeServerConfigInstance;
        private object _exchangeServerConfigInstanceFixture;

        #region General Initializer : Class (ExchangeServerConfig) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="ExchangeServerConfig" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _exchangeServerConfigInstanceFixture = this.CreateNonPublicType(ExchangeServerConfigNonPublicTypeName);
            _exchangeServerConfigInstance = _exchangeServerConfigInstanceFixture;
            CurrentInstance = _exchangeServerConfigInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExchangeServerConfig) Initializer

        #region Properties

        private const string PropertyHost = "Host";
        private const string PropertyUserName = "UserName";
        private const string PropertyPassword = "Password";
        private const string PropertyEnableSsl = "EnableSsl";
        private const string PropertyDefaultCredentials = "DefaultCredentials";
        private const string PropertyDomain = "Domain";
        private const string PropertyEnableEwsTraceLog = "EnableEwsTraceLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (ExchangeServerConfig)

        #region General Initializer : Class (ExchangeServerConfig) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExchangeServerConfig" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExchangeServerConfig_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ExchangeServerConfig) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ExchangeServerConfig" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyHost)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyEnableSsl)]
        [TestCase(PropertyDefaultCredentials)]
        [TestCase(PropertyDomain)]
        [TestCase(PropertyEnableEwsTraceLog)]
        [Category("AUT Property")]
        public void AUT_ExchangeServerConfig_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ExchangeServerConfig) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ExchangeServerConfig" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExchangeServerConfig_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (ExchangeServerConfig) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ExchangeServerConfig" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExchangeServerConfig_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ExchangeServerConfig) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyHost)]
        [TestCase(PropertyUserName)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyEnableSsl)]
        [TestCase(PropertyDefaultCredentials)]
        [TestCase(PropertyDomain)]
        [TestCase(PropertyEnableEwsTraceLog)]
        public void AUT_ExchangeServerConfig_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (DefaultCredentials) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_DefaultCredentials_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefaultCredentials);
            var propertyInfo = this.GetPropertyInfo(PropertyDefaultCredentials);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (Domain) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_Domain_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDomain);
            var propertyInfo = this.GetPropertyInfo(PropertyDomain);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (EnableEwsTraceLog) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_EnableEwsTraceLog_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnableEwsTraceLog);
            var propertyInfo = this.GetPropertyInfo(PropertyEnableEwsTraceLog);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (EnableSsl) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_EnableSsl_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnableSsl);
            var propertyInfo = this.GetPropertyInfo(PropertyEnableSsl);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (Host) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_Host_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyHost);
            var propertyInfo = this.GetPropertyInfo(PropertyHost);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (Password) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_Password_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (ExchangeServerConfig) => Property (UserName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ExchangeServerConfig_Public_Class_UserName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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