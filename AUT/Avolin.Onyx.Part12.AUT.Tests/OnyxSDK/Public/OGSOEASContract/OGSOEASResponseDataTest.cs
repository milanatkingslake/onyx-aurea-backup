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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASContract.OGSOEASResponseData" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OGSOEASResponseDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OGSOEASResponseData" />)
        /// </summary>
        public OGSOEASResponseDataTest() : base(typeof(OGSOEASResponseData))
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

        #region General Initializer : Class (OGSOEASResponseData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oGSOEASResponseDataInstanceType;
        private OGSOEASResponseData _oGSOEASResponseDataInstance;
        private OGSOEASResponseData _oGSOEASResponseDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OGSOEASResponseData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oGSOEASResponseDataInstanceType = typeof(OGSOEASResponseData);
            _oGSOEASResponseDataInstanceFixture = this.Create<OGSOEASResponseData>(false);
            _oGSOEASResponseDataInstance = _oGSOEASResponseDataInstanceFixture ?? this.Create<OGSOEASResponseData>(true);
            CurrentInstance = _oGSOEASResponseDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OGSOEASResponseData) Initializer

        #region Properties

        private const string PropertyData = "Data";
        private const string PropertyStatus = "Status";
        private const string PropertyExceptionMessage = "ExceptionMessage";

        #endregion

        #endregion

        #region General Initializer : Class (OGSOEASResponseData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASResponseData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASResponseData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASResponseData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OGSOEASResponseData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OGSOEASResponseData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OGSOEASResponseData)

        #region General Initializer : Class (OGSOEASResponseData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyData)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyExceptionMessage)]
        [Category("AUT Property")]
        public void AUT_OGSOEASResponseData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OGSOEASResponseData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASResponseData_Is_Instance_Present_Test()
        {
            // Assert
            _oGSOEASResponseDataInstanceType.ShouldNotBeNull();
            _oGSOEASResponseDataInstance.ShouldNotBeNull();
            _oGSOEASResponseDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OGSOEASResponseData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OGSOEASResponseData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OGSOEASResponseData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oGSOEASResponseDataInstance.ShouldBeAssignableTo<OGSOEASResponseData>();
            _oGSOEASResponseDataInstanceFixture.ShouldBeAssignableTo<OGSOEASResponseData>();
            CurrentInstance.ShouldBeAssignableTo<OGSOEASResponseData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OGSOEASResponseData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OGSOEASResponseData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OGSOEASResponseData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (OGSOEASResponseData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyData)]
        [TestCase(PropertyStatus)]
        [TestCase(PropertyExceptionMessage)]
        public void AUT_OGSOEASResponseData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (OGSOEASResponseData) => Property (Data) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASResponseData_Public_Class_Data_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyData);
            var propertyInfo = this.GetPropertyInfo(PropertyData);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASResponseData) => Property (ExceptionMessage) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASResponseData_Public_Class_ExceptionMessage_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptionMessage);
            var propertyInfo = this.GetPropertyInfo(PropertyExceptionMessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (OGSOEASResponseData) => Property (Status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_OGSOEASResponseData_Public_Class_Status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStatus);
            var propertyInfo = this.GetPropertyInfo(PropertyStatus);

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