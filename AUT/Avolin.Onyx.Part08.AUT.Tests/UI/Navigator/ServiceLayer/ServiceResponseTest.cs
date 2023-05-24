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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.ServiceResponse" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceResponseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceResponse" />)
        /// </summary>
        public ServiceResponseTest() : base(typeof(ServiceResponse))
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

        #region General Initializer : Class (ServiceResponse) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceResponseInstanceType;
        private ServiceResponse _serviceResponseInstance;
        private ServiceResponse _serviceResponseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceResponse" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceResponseInstanceType = typeof(ServiceResponse);
            _serviceResponseInstanceFixture = this.Create<ServiceResponse>(false);
            _serviceResponseInstance = _serviceResponseInstanceFixture ?? this.Create<ServiceResponse>(true);
            CurrentInstance = _serviceResponseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Initializer

        #region Properties

        private const string PropertyIsSuccess = "IsSuccess";
        private const string PropertyExceptions = "Exceptions";
        private const string PropertyResult = "Result";

        #endregion

        #region Fields

        private const string FieldsuccessStatus = "successStatus";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceResponse) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceResponse_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceResponse)

        #region General Initializer : Class (ServiceResponse) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyIsSuccess)]
        [TestCase(PropertyExceptions)]
        [TestCase(PropertyResult)]
        [Category("AUT Property")]
        public void AUT_ServiceResponse_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ServiceResponse) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsuccessStatus)]
        [Category("AUT Fields")]
        public void AUT_ServiceResponse_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServiceResponse) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResponse_Is_Instance_Present_Test()
        {
            // Assert
            _serviceResponseInstanceType.ShouldNotBeNull();
            _serviceResponseInstance.ShouldNotBeNull();
            _serviceResponseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceResponse) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceResponse" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceResponse_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceResponseInstance.ShouldBeAssignableTo<ServiceResponse>();
            _serviceResponseInstanceFixture.ShouldBeAssignableTo<ServiceResponse>();
            CurrentInstance.ShouldBeAssignableTo<ServiceResponse>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ServiceResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceResponse_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var xmlData = this.CreateType<string>();
            ServiceResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ServiceResponse(xmlData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _serviceResponseInstance.ShouldNotBeNull();
            _serviceResponseInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ServiceResponse>();
        }

        #endregion

        #region General Constructor : Class (ServiceResponse) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceResponse_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var xmlData = this.CreateType<string>();
            ServiceResponse instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ServiceResponse(xmlData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _serviceResponseInstance.ShouldNotBeNull();
            _serviceResponseInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ServiceResponse) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyIsSuccess)]
        [TestCase(PropertyExceptions)]
        [TestCase(PropertyResult)]
        public void AUT_ServiceResponse_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ServiceResponse) => Property (Exceptions) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Exceptions_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptions);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyExceptions);
            Action currentAction = () => propertyInfo.SetValue(_serviceResponseInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (Exceptions) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Public_Class_Exceptions_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyExceptions);
            var propertyInfo = this.GetPropertyInfo(PropertyExceptions);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (IsSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Public_Class_IsSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIsSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyIsSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ServiceResponse) => Property (Result) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ServiceResponse_Public_Class_Result_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResult);
            var propertyInfo = this.GetPropertyInfo(PropertyResult);

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