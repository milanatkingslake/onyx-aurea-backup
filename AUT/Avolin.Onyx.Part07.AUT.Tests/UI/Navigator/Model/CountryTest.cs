using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Country" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CountryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Country" />)
        /// </summary>
        public CountryTest() : base(typeof(Country))
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

        #region General Initializer : Class (Country) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _countryInstanceType;
        private Country _countryInstance;
        private Country _countryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Country" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _countryInstanceType = typeof(Country);
            _countryInstanceFixture = this.Create<Country>(false);
            _countryInstance = _countryInstanceFixture ?? this.Create<Country>(true);
            CurrentInstance = _countryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Country) Initializer

        #region Properties

        private const string PropertyPhoneMask = "PhoneMask";
        private const string PropertyPostalMask = "PostalMask";

        #endregion

        #endregion

        #region General Initializer : Class (Country) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Country" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Country_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Country) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Country" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Country_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Country) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Country" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Country_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Country)

        #region General Initializer : Class (Country) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Country" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPhoneMask)]
        [TestCase(PropertyPostalMask)]
        [Category("AUT Property")]
        public void AUT_Country_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Country) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Country" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Country_Is_Instance_Present_Test()
        {
            // Assert
            _countryInstanceType.ShouldNotBeNull();
            _countryInstance.ShouldNotBeNull();
            _countryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Country) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Country" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Country_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _countryInstance.ShouldBeAssignableTo<Country>();
            _countryInstanceFixture.ShouldBeAssignableTo<Country>();
            CurrentInstance.ShouldBeAssignableTo<Country>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Country) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Country instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (Country) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var displayName = this.CreateType<string>();
            var displayValue = this.CreateType<string>();
            var phoneMask = this.CreateType<string>();
            var postalMask = this.CreateType<string>();
            Country instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Country(displayName, displayValue, phoneMask, postalMask);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _countryInstance.ShouldNotBeNull();
            _countryInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Country>();
        }

        #endregion

        #region General Constructor : Class (Country) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var displayName = this.CreateType<string>();
            var displayValue = this.CreateType<string>();
            var phoneMask = this.CreateType<string>();
            var postalMask = this.CreateType<string>();
            Country instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Country(displayName, displayValue, phoneMask, postalMask);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _countryInstance.ShouldNotBeNull();
            _countryInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Country) instance created

        /// <summary>
        ///     Class (<see cref="Country" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Is_Created_Test()
        {
            // Assert
            _countryInstance.ShouldNotBeNull();
            _countryInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Country) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Country" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_Country_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Country) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Country" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Country) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Country" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodCountryParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCountryParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Country) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Country" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Country_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodCountryParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodCountryParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Country) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPhoneMask)]
        [TestCase(PropertyPostalMask)]
        public void AUT_Country_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Country) => Property (PhoneMask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Country_Public_Class_PhoneMask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPhoneMask);
            var propertyInfo = this.GetPropertyInfo(PropertyPhoneMask);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Country) => Property (PostalMask) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Country_Public_Class_PostalMask_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPostalMask);
            var propertyInfo = this.GetPropertyInfo(PropertyPostalMask);

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