using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ServiceResult" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceResult" />)
        /// </summary>
        public ServiceResultTest() : base(typeof(ServiceResult))
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

        #region General Initializer : Class (ServiceResult) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceResultInstanceType;
        private ServiceResult _serviceResultInstance;
        private ServiceResult _serviceResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceResult" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceResultInstanceType = typeof(ServiceResult);
            _serviceResultInstanceFixture = this.Create<ServiceResult>(false);
            _serviceResultInstance = _serviceResultInstanceFixture ?? this.Create<ServiceResult>(true);
            CurrentInstance = _serviceResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceResult) Initializer

        #region Properties

        private const string Propertystatus = "status";
        private const string Propertymessage = "message";
        private const string PropertyprimaryId = "primaryId";
        private const string PropertyonyxTimestamp = "onyxTimestamp";
        private const string PropertyonyxTimestampAddress = "onyxTimestampAddress";
        private const string PropertyonyxTimestampPhone = "onyxTimestampPhone";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceResult) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResult) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResult) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceResult)

        #region General Initializer : Class (ServiceResult) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertystatus)]
        [TestCase(Propertymessage)]
        [TestCase(PropertyprimaryId)]
        [TestCase(PropertyonyxTimestamp)]
        [TestCase(PropertyonyxTimestampAddress)]
        [TestCase(PropertyonyxTimestampPhone)]
        [Category("AUT Property")]
        public void AUT_ServiceResult_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServiceResult) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResult_Is_Instance_Present_Test()
        {
            // Assert
            _serviceResultInstanceType.ShouldNotBeNull();
            _serviceResultInstance.ShouldNotBeNull();
            _serviceResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceResult) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceResult" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceResultInstance.ShouldBeAssignableTo<ServiceResult>();
            _serviceResultInstanceFixture.ShouldBeAssignableTo<ServiceResult>();
            CurrentInstance.ShouldBeAssignableTo<ServiceResult>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ServiceResult) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ServiceResult instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ServiceResult) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertystatus)]
        [TestCase(Propertymessage)]
        [TestCase(PropertyprimaryId)]
        [TestCase(PropertyonyxTimestamp)]
        [TestCase(PropertyonyxTimestampAddress)]
        [TestCase(PropertyonyxTimestampPhone)]
        public void AUT_ServiceResult_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ServiceResult) => Property (message) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_message_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertymessage);
            var propertyInfo = this.GetPropertyInfo(Propertymessage);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResult) => Property (onyxTimestamp) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_onyxTimestamp_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyonyxTimestamp);
            var propertyInfo = this.GetPropertyInfo(PropertyonyxTimestamp);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResult) => Property (onyxTimestampAddress) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_onyxTimestampAddress_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyonyxTimestampAddress);
            var propertyInfo = this.GetPropertyInfo(PropertyonyxTimestampAddress);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResult) => Property (onyxTimestampPhone) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_onyxTimestampPhone_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyonyxTimestampPhone);
            var propertyInfo = this.GetPropertyInfo(PropertyonyxTimestampPhone);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResult) => Property (primaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_primaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyprimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyprimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResult) => Property (status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResult_Public_Class_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertystatus);
            var propertyInfo = this.GetPropertyInfo(Propertystatus);

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