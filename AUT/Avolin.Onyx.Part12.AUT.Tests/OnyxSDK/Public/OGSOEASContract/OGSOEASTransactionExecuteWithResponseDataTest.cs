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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASContract.OGSOEASTransactionExecuteWithResponseData" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSOEASTransactionExecuteWithResponseDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSOEASTransactionExecuteWithResponseData" />)
        /// </summary>
        public OGSOEASTransactionExecuteWithResponseDataTest() : base(typeof(OGSOEASTransactionExecuteWithResponseData))
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

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSOEASTransactionExecuteWithResponseDataInstanceType;
        private OGSOEASTransactionExecuteWithResponseData _oGSOEASTransactionExecuteWithResponseDataInstance;
        private OGSOEASTransactionExecuteWithResponseData _oGSOEASTransactionExecuteWithResponseDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OGSOEASTransactionExecuteWithResponseData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSOEASTransactionExecuteWithResponseDataInstanceType = typeof(OGSOEASTransactionExecuteWithResponseData);
            _oGSOEASTransactionExecuteWithResponseDataInstanceFixture = this.Create<OGSOEASTransactionExecuteWithResponseData>(false);
            _oGSOEASTransactionExecuteWithResponseDataInstance = _oGSOEASTransactionExecuteWithResponseDataInstanceFixture ?? this.Create<OGSOEASTransactionExecuteWithResponseData>(true);
            CurrentInstance = _oGSOEASTransactionExecuteWithResponseDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) Initializer

        #region Properties

        private const string PropertyApplicationName = "ApplicationName";
        private const string PropertyLogicalObjectName = "LogicalObjectName";
        private const string PropertyLogicalMethodName = "LogicalMethodName";
        private const string PropertySessionId = "SessionId";
        private const string PropertyParamXml = "ParamXml";
        private const string PropertyCustomDataXml = "CustomDataXml";

        #endregion

        #endregion

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSOEASTransactionExecuteWithResponseData)

        #region General Initializer : Class (OGSOEASTransactionExecuteWithResponseData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyParamXml)]
        [TestCase(PropertyCustomDataXml)]
        [Category("AUT Property")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OGSOEASTransactionExecuteWithResponseData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Is_Instance_Present_Test()
        {
            // Assert
            _oGSOEASTransactionExecuteWithResponseDataInstanceType.ShouldNotBeNull();
            _oGSOEASTransactionExecuteWithResponseDataInstance.ShouldNotBeNull();
            _oGSOEASTransactionExecuteWithResponseDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OGSOEASTransactionExecuteWithResponseData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OGSOEASTransactionExecuteWithResponseData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oGSOEASTransactionExecuteWithResponseDataInstance.ShouldBeAssignableTo<OGSOEASTransactionExecuteWithResponseData>();
            _oGSOEASTransactionExecuteWithResponseDataInstanceFixture.ShouldBeAssignableTo<OGSOEASTransactionExecuteWithResponseData>();
            CurrentInstance.ShouldBeAssignableTo<OGSOEASTransactionExecuteWithResponseData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OGSOEASTransactionExecuteWithResponseData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OGSOEASTransactionExecuteWithResponseData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyApplicationName)]
        [TestCase(PropertyLogicalObjectName)]
        [TestCase(PropertyLogicalMethodName)]
        [TestCase(PropertySessionId)]
        [TestCase(PropertyParamXml)]
        [TestCase(PropertyCustomDataXml)]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (ApplicationName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_ApplicationName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (CustomDataXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_CustomDataXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomDataXml);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomDataXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (LogicalMethodName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_LogicalMethodName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (LogicalObjectName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_LogicalObjectName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (ParamXml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_ParamXml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyParamXml);
            var propertyInfo = this.GetPropertyInfo(PropertyParamXml);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASTransactionExecuteWithResponseData) => Property (SessionId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASTransactionExecuteWithResponseData_Public_Class_SessionId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #endregion

        #endregion
    }
}