using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.CustomerModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CustomerModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerModel" />)
        /// </summary>
        public CustomerModelTest() : base(typeof(CustomerModel))
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

        #region General Initializer : Class (CustomerModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerModelInstanceType;
        private CustomerModel _customerModelInstance;
        private CustomerModel _customerModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerModelInstanceType = typeof(CustomerModel);
            _customerModelInstanceFixture = this.Create<CustomerModel>(false);
            _customerModelInstance = _customerModelInstanceFixture ?? this.Create<CustomerModel>(true);
            CurrentInstance = _customerModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomerModel) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertySecondaryId = "SecondaryId";
        private const string PropertyCustomerType = "CustomerType";
        private const string PropertyCompanyName = "CompanyName";
        private const string PropertySalutation = "Salutation";
        private const string PropertyFirstName = "FirstName";
        private const string PropertyLastName = "LastName";
        private const string PropertySuffix = "Suffix";
        private const string PropertyPrimaryContactPrimaryId = "PrimaryContactPrimaryId";
        private const string PropertyPrimaryContactSecondaryId = "PrimaryContactSecondaryId";

        #endregion

        #endregion

        #region General Initializer : Class (CustomerModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomerModel)

        #region General Initializer : Class (CustomerModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyCustomerType)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertySalutation)]
        [TestCase(PropertyFirstName)]
        [TestCase(PropertyLastName)]
        [TestCase(PropertySuffix)]
        [TestCase(PropertyPrimaryContactPrimaryId)]
        [TestCase(PropertyPrimaryContactSecondaryId)]
        [Category("AUT Property")]
        public void AUT_CustomerModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CustomerModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerModel_Is_Instance_Present_Test()
        {
            // Assert
            _customerModelInstanceType.ShouldNotBeNull();
            _customerModelInstance.ShouldNotBeNull();
            _customerModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomerModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomerModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customerModelInstance.ShouldBeAssignableTo<CustomerModel>();
            _customerModelInstanceFixture.ShouldBeAssignableTo<CustomerModel>();
            CurrentInstance.ShouldBeAssignableTo<CustomerModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CustomerModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CustomerModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CustomerModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (CustomerModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertySecondaryId)]
        [TestCase(PropertyCustomerType)]
        [TestCase(PropertyCompanyName)]
        [TestCase(PropertySalutation)]
        [TestCase(PropertyFirstName)]
        [TestCase(PropertyLastName)]
        [TestCase(PropertySuffix)]
        [TestCase(PropertyPrimaryContactPrimaryId)]
        [TestCase(PropertyPrimaryContactSecondaryId)]
        public void AUT_CustomerModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (CustomerModel) => Property (CompanyName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_CompanyName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCompanyName);
            var propertyInfo = this.GetPropertyInfo(PropertyCompanyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (CustomerType) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_CustomerType_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCustomerType);
            var propertyInfo = this.GetPropertyInfo(PropertyCustomerType);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (FirstName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_FirstName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFirstName);
            var propertyInfo = this.GetPropertyInfo(PropertyFirstName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (LastName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_LastName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastName);
            var propertyInfo = this.GetPropertyInfo(PropertyLastName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (PrimaryContactPrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_PrimaryContactPrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (PrimaryContactSecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_PrimaryContactSecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryContactSecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryContactSecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPrimaryId);
            var propertyInfo = this.GetPropertyInfo(PropertyPrimaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (Salutation) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_Salutation_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySalutation);
            var propertyInfo = this.GetPropertyInfo(PropertySalutation);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (SecondaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_SecondaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySecondaryId);
            var propertyInfo = this.GetPropertyInfo(PropertySecondaryId);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (CustomerModel) => Property (Suffix) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_CustomerModel_Public_Class_Suffix_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySuffix);
            var propertyInfo = this.GetPropertyInfo(PropertySuffix);

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