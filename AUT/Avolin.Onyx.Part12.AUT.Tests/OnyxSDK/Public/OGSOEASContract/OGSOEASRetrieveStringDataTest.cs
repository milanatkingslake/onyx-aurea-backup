using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OGSOEASContract;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OGSOEASContract
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASContract.OGSOEASRetrieveStringData" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSOEASRetrieveStringDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSOEASRetrieveStringData" />)
        /// </summary>
        public OGSOEASRetrieveStringDataTest() : base(typeof(OGSOEASRetrieveStringData))
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

        #region General Initializer : Class (OGSOEASRetrieveStringData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSOEASRetrieveStringDataInstanceType;
        private OGSOEASRetrieveStringData _oGSOEASRetrieveStringDataInstance;
        private OGSOEASRetrieveStringData _oGSOEASRetrieveStringDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OGSOEASRetrieveStringData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSOEASRetrieveStringDataInstanceType = typeof(OGSOEASRetrieveStringData);
            _oGSOEASRetrieveStringDataInstanceFixture = this.Create<OGSOEASRetrieveStringData>(false);
            _oGSOEASRetrieveStringDataInstance = _oGSOEASRetrieveStringDataInstanceFixture ?? this.Create<OGSOEASRetrieveStringData>(true);
            CurrentInstance = _oGSOEASRetrieveStringDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSOEASRetrieveStringData) Initializer

        #region Properties

        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertySiteId = "SiteId";
        private const string PropertyLanguageCode = "LanguageCode";
        private const string PropertyNatLangId = "NatLangId";
        private const string PropertyArguments = "Arguments";

        #endregion

        #endregion

        #region General Initializer : Class (OGSOEASRetrieveStringData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASRetrieveStringData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASRetrieveStringData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASRetrieveStringData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASRetrieveStringData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASRetrieveStringData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSOEASRetrieveStringData)

        #region General Initializer : Class (OGSOEASRetrieveStringData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyArguments)]
        [Category("AUT Property")]
        public void AUT_OGSOEASRetrieveStringData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OGSOEASRetrieveStringData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASRetrieveStringData_Is_Instance_Present_Test()
        {
            // Assert
            _oGSOEASRetrieveStringDataInstanceType.ShouldNotBeNull();
            _oGSOEASRetrieveStringDataInstance.ShouldNotBeNull();
            _oGSOEASRetrieveStringDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OGSOEASRetrieveStringData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OGSOEASRetrieveStringData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASRetrieveStringData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oGSOEASRetrieveStringDataInstance.ShouldBeAssignableTo<OGSOEASRetrieveStringData>();
            _oGSOEASRetrieveStringDataInstanceFixture.ShouldBeAssignableTo<OGSOEASRetrieveStringData>();
            CurrentInstance.ShouldBeAssignableTo<OGSOEASRetrieveStringData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OGSOEASRetrieveStringData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OGSOEASRetrieveStringData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OGSOEASRetrieveStringData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyLanguageCode)]
        [TestCase(PropertyNatLangId)]
        [TestCase(PropertyArguments)]
        public void AUT_OGSOEASRetrieveStringData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASRetrieveStringData_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => Property (Arguments) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASRetrieveStringData_Public_Class_Arguments_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyArguments);
            var propertyInfo = this.GetPropertyInfo(PropertyArguments);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => Property (LanguageCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASRetrieveStringData_Public_Class_LanguageCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLanguageCode);
            var propertyInfo = this.GetPropertyInfo(PropertyLanguageCode);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => Property (NatLangId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASRetrieveStringData_Public_Class_NatLangId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNatLangId);
            var propertyInfo = this.GetPropertyInfo(PropertyNatLangId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASRetrieveStringData) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASRetrieveStringData_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}