using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Form.Helper;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Form.Helper
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Form.Helper.OnyxHeaderDetail" />)
    ///     and namespace <see cref="Onyx.UI.Form.Helper"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxHeaderDetailTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxHeaderDetail" />)
        /// </summary>
        public OnyxHeaderDetailTest() : base(typeof(OnyxHeaderDetail))
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

        #region General Initializer : Class (OnyxHeaderDetail) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxHeaderDetailInstanceType;
        private OnyxHeaderDetail _onyxHeaderDetailInstance;
        private OnyxHeaderDetail _onyxHeaderDetailInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxHeaderDetail" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxHeaderDetailInstanceType = typeof(OnyxHeaderDetail);
            _onyxHeaderDetailInstanceFixture = this.Create<OnyxHeaderDetail>(false);
            _onyxHeaderDetailInstance = _onyxHeaderDetailInstanceFixture ?? this.Create<OnyxHeaderDetail>(true);
            CurrentInstance = _onyxHeaderDetailInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxHeaderDetail) Initializer

        #region Properties

        private const string PropertyUserId = "UserId";
        private const string PropertySessionId = "SessionId";
        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguage = "Language";
        private const string PropertyPassword = "Password";
        private const string PropertyNewPassword = "NewPassword";
        private const string PropertyAuthMode = "AuthMode";
        private const string PropertyAppType = "AppType";
        private const string PropertyClientTimeZoneOffset = "ClientTimeZoneOffset";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxHeaderDetail) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxHeaderDetail_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxHeaderDetail) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxHeaderDetail_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxHeaderDetail) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxHeaderDetail_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxHeaderDetail)

        #region General Initializer : Class (OnyxHeaderDetail) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyNewPassword)]
        [TestCase(PropertyAuthMode)]
        [TestCase(PropertyAppType)]
        [TestCase(PropertyClientTimeZoneOffset)]
        [Category("AUT Property")]
        public void AUT_OnyxHeaderDetail_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxHeaderDetail) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxHeaderDetail_Is_Instance_Present_Test()
        {
            // Assert
            _onyxHeaderDetailInstanceType.ShouldNotBeNull();
            _onyxHeaderDetailInstance.ShouldNotBeNull();
            _onyxHeaderDetailInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxHeaderDetail) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxHeaderDetail" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxHeaderDetail_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxHeaderDetailInstance.ShouldBeAssignableTo<OnyxHeaderDetail>();
            _onyxHeaderDetailInstanceFixture.ShouldBeAssignableTo<OnyxHeaderDetail>();
            CurrentInstance.ShouldBeAssignableTo<OnyxHeaderDetail>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxHeaderDetail) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxHeaderDetail_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxHeaderDetail instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OnyxHeaderDetail) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguage)]
        [TestCase(PropertyPassword)]
        [TestCase(PropertyNewPassword)]
        [TestCase(PropertyAuthMode)]
        [TestCase(PropertyAppType)]
        [TestCase(PropertyClientTimeZoneOffset)]
        public void AUT_OnyxHeaderDetail_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApplicationName);
            var propertyInfo = this.GetPropertyInfo(PropertyApplicationName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (AppType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_AppType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppType);
            var propertyInfo = this.GetPropertyInfo(PropertyAppType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (AuthMode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_AuthMode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAuthMode);
            var propertyInfo = this.GetPropertyInfo(PropertyAuthMode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (ClientTimeZoneOffset) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_ClientTimeZoneOffset_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyClientTimeZoneOffset);
            var propertyInfo = this.GetPropertyInfo(PropertyClientTimeZoneOffset);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (NewPassword) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_NewPassword_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNewPassword);
            var propertyInfo = this.GetPropertyInfo(PropertyNewPassword);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (Password) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_Password_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySessionId);
            var propertyInfo = this.GetPropertyInfo(PropertySessionId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OnyxHeaderDetail) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OnyxHeaderDetail_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyUserId);
            var propertyInfo = this.GetPropertyInfo(PropertyUserId);

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