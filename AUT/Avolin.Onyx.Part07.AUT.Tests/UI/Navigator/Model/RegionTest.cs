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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.Region" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RegionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Region" />)
        /// </summary>
        public RegionTest() : base(typeof(Region))
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

        #region General Initializer : Class (Region) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _regionInstanceType;
        private Region _regionInstance;
        private Region _regionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Region" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _regionInstanceType = typeof(Region);
            _regionInstanceFixture = this.Create<Region>(false);
            _regionInstance = _regionInstanceFixture ?? this.Create<Region>(true);
            CurrentInstance = _regionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Region) Initializer

        #region Properties

        private const string PropertyCountryCode = "CountryCode";

        #endregion

        #endregion

        #region General Initializer : Class (Region) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Region" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Region_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Region) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Region" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Region_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Region) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Region" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Region_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Region)

        #region General Initializer : Class (Region) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Region" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyCountryCode)]
        [Category("AUT Property")]
        public void AUT_Region_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Region) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Region" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Region_Is_Instance_Present_Test()
        {
            // Assert
            _regionInstanceType.ShouldNotBeNull();
            _regionInstance.ShouldNotBeNull();
            _regionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Region) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Region" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Region_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _regionInstance.ShouldBeAssignableTo<Region>();
            _regionInstanceFixture.ShouldBeAssignableTo<Region>();
            CurrentInstance.ShouldBeAssignableTo<Region>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Region) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Region instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (Region) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var displayName = this.CreateType<string>();
            var displayValue = this.CreateType<string>();
            var phoneMask = this.CreateType<string>();
            var postalMask = this.CreateType<string>();
            Region instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Region(displayName, displayValue, phoneMask, postalMask);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _regionInstance.ShouldNotBeNull();
            _regionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Region>();
        }

        #endregion

        #region General Constructor : Class (Region) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var displayName = this.CreateType<string>();
            var displayValue = this.CreateType<string>();
            var phoneMask = this.CreateType<string>();
            var postalMask = this.CreateType<string>();
            Region instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Region(displayName, displayValue, phoneMask, postalMask);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _regionInstance.ShouldNotBeNull();
            _regionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Region) instance created

        /// <summary>
        ///     Class (<see cref="Region" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Is_Created_Test()
        {
            // Assert
            _regionInstance.ShouldNotBeNull();
            _regionInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Region) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Region" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_Region_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (Region) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Region" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Region) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Region" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodRegionParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRegionParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Region) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Region" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Region_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodRegionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodRegionParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Region) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyCountryCode)]
        public void AUT_Region_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Region) => Property (CountryCode) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_Region_Public_Class_CountryCode_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCountryCode);
            var propertyInfo = this.GetPropertyInfo(PropertyCountryCode);

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