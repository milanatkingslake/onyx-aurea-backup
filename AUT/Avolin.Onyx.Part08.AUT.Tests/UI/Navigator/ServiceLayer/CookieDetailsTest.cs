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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.CookieDetails" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CookieDetailsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CookieDetails" />)
        /// </summary>
        public CookieDetailsTest() : base(typeof(CookieDetails))
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

        #region General Initializer : Class (CookieDetails) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _cookieDetailsInstanceType;
        private CookieDetails _cookieDetailsInstance;
        private CookieDetails _cookieDetailsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CookieDetails" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _cookieDetailsInstanceType = typeof(CookieDetails);
            _cookieDetailsInstanceFixture = this.Create<CookieDetails>(false);
            _cookieDetailsInstance = _cookieDetailsInstanceFixture ?? this.Create<CookieDetails>(true);
            CurrentInstance = _cookieDetailsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CookieDetails) Initializer

        #region Properties

        private const string PropertyInstance = "Instance";
        private const string PropertySessionId = "SessionId";
        private const string PropertyUserId = "UserId";
        private const string PropertySiteId = "SiteId";
        private const string PropertyAppName = "AppName";
        private const string PropertyProfileId = "ProfileId";
        private const string PropertyLanguage = "Language";

        #endregion

        #region Fields

        private const string Fieldinstance = "instance";
        private const string FieldsessionId = "sessionId";
        private const string FielduserId = "userId";
        private const string FieldsiteId = "siteId";
        private const string FieldappName = "appName";
        private const string FieldprofileId = "profileId";
        private const string Fieldlanguage = "language";

        #endregion

        #endregion

        #region General Initializer : Class (CookieDetails) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CookieDetails_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CookieDetails) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CookieDetails_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CookieDetails) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CookieDetails_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CookieDetails)

        #region General Initializer : Class (CookieDetails) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyInstance)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertyLanguage)]
        [Category("AUT Property")]
        public void AUT_CookieDetails_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (CookieDetails) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldinstance)]
        [TestCase(FieldsessionId)]
        [TestCase(FielduserId)]
        [TestCase(FieldsiteId)]
        [TestCase(FieldappName)]
        [TestCase(FieldprofileId)]
        [TestCase(Fieldlanguage)]
        [Category("AUT Fields")]
        public void AUT_CookieDetails_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CookieDetails) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CookieDetails_Is_Instance_Present_Test()
        {
            // Assert
            _cookieDetailsInstanceType.ShouldNotBeNull();
            _cookieDetailsInstance.ShouldNotBeNull();
            _cookieDetailsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CookieDetails) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CookieDetails" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CookieDetails_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _cookieDetailsInstance.ShouldBeAssignableTo<CookieDetails>();
            _cookieDetailsInstanceFixture.ShouldBeAssignableTo<CookieDetails>();
            CurrentInstance.ShouldBeAssignableTo<CookieDetails>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CookieDetails) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CookieDetails_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CookieDetails instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (CookieDetails) Default Assignment Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CookieDetails_Constructor_Instantiated_With_Default_Assignments_Test()
        {
            // Act
            var cookieDetailsInstance  = new CookieDetails();

            // Asserts
            cookieDetailsInstance.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CookieDetails) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyInstance)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyAppName)]
        [TestCase(PropertyProfileId)]
        [TestCase(PropertyLanguage)]
        public void AUT_CookieDetails_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CookieDetails) => Property (AppName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_AppName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAppName);
            var propertyInfo = this.GetPropertyInfo(PropertyAppName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CookieDetails) => Property (Instance) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Instance_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInstance);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyInstance);
            Action currentAction = () => propertyInfo.SetValue(_cookieDetailsInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (CookieDetails) => Property (Instance) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_Instance_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyInstance);
            var propertyInfo = this.GetPropertyInfo(PropertyInstance);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CookieDetails) => Property (Language) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_Language_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CookieDetails) => Property (ProfileId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_ProfileId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProfileId);
            var propertyInfo = this.GetPropertyInfo(PropertyProfileId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CookieDetails) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CookieDetails) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (CookieDetails) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CookieDetails_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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