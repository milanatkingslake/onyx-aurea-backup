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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASContract.OGSOEASEASServicesExecuteData" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSOEASEASServicesExecuteDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSOEASEASServicesExecuteData" />)
        /// </summary>
        public OGSOEASEASServicesExecuteDataTest() : base(typeof(OGSOEASEASServicesExecuteData))
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

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSOEASEASServicesExecuteDataInstanceType;
        private OGSOEASEASServicesExecuteData _oGSOEASEASServicesExecuteDataInstance;
        private OGSOEASEASServicesExecuteData _oGSOEASEASServicesExecuteDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OGSOEASEASServicesExecuteData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSOEASEASServicesExecuteDataInstanceType = typeof(OGSOEASEASServicesExecuteData);
            _oGSOEASEASServicesExecuteDataInstanceFixture = this.Create<OGSOEASEASServicesExecuteData>(false);
            _oGSOEASEASServicesExecuteDataInstance = _oGSOEASEASServicesExecuteDataInstanceFixture ?? this.Create<OGSOEASEASServicesExecuteData>(true);
            CurrentInstance = _oGSOEASEASServicesExecuteDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) Initializer

        #region Properties

        private const string PropertyLogicalObjectName = "LogicalObjectName";
        private const string PropertyLogicalMethodName = "LogicalMethodName";
        private const string PropertyParametersXml = "ParametersXml";
        private const string PropertySessionId = "SessionId";
        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertySiteId = "SiteId";
        private const string PropertyUserId = "UserId";
        private const string PropertyEnforcePermissions = "EnforcePermissions";
        private const string PropertyStandardMethod = "StandardMethod";

        #endregion

        #endregion

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASEASServicesExecuteData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASEASServicesExecuteData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASEASServicesExecuteData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSOEASEASServicesExecuteData)

        #region General Initializer : Class (OGSOEASEASServicesExecuteData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertyParametersXml)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyEnforcePermissions)]
        [TestCase(PropertyStandardMethod)]
        [Category("AUT Property")]
        public void AUT_OGSOEASEASServicesExecuteData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OGSOEASEASServicesExecuteData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASEASServicesExecuteData_Is_Instance_Present_Test()
        {
            // Assert
            _oGSOEASEASServicesExecuteDataInstanceType.ShouldNotBeNull();
            _oGSOEASEASServicesExecuteDataInstance.ShouldNotBeNull();
            _oGSOEASEASServicesExecuteDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OGSOEASEASServicesExecuteData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OGSOEASEASServicesExecuteData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASEASServicesExecuteData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oGSOEASEASServicesExecuteDataInstance.ShouldBeAssignableTo<OGSOEASEASServicesExecuteData>();
            _oGSOEASEASServicesExecuteDataInstanceFixture.ShouldBeAssignableTo<OGSOEASEASServicesExecuteData>();
            CurrentInstance.ShouldBeAssignableTo<OGSOEASEASServicesExecuteData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OGSOEASEASServicesExecuteData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OGSOEASEASServicesExecuteData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OGSOEASEASServicesExecuteData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertyParametersXml)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertySiteId)]
        [TestCase(PropertyUserId)]
        [TestCase(PropertyEnforcePermissions)]
        [TestCase(PropertyStandardMethod)]
        public void AUT_OGSOEASEASServicesExecuteData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (EnforcePermissions) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_EnforcePermissions_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEnforcePermissions);
            var propertyInfo = this.GetPropertyInfo(PropertyEnforcePermissions);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (LogicalMethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_LogicalMethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogicalMethodName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogicalMethodName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (LogicalObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_LogicalObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLogicalObjectName);
            var propertyInfo = this.GetPropertyInfo(PropertyLogicalObjectName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (ParametersXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_ParametersXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParametersXml);
            var propertyInfo = this.GetPropertyInfo(PropertyParametersXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (SiteId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_SiteId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (StandardMethod) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_StandardMethod_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStandardMethod);
            var propertyInfo = this.GetPropertyInfo(PropertyStandardMethod);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASEASServicesExecuteData) => Property (UserId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASEASServicesExecuteData_Public_Class_UserId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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