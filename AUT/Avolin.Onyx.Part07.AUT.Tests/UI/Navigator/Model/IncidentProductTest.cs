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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.IncidentProduct" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IncidentProductTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentProduct" />)
        /// </summary>
        public IncidentProductTest() : base(typeof(IncidentProduct))
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

        #region General Initializer : Class (IncidentProduct) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentProductInstanceType;
        private IncidentProduct _incidentProductInstance;
        private IncidentProduct _incidentProductInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentProduct" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentProductInstanceType = typeof(IncidentProduct);
            _incidentProductInstanceFixture = this.Create<IncidentProduct>(false);
            _incidentProductInstance = _incidentProductInstanceFixture ?? this.Create<IncidentProduct>(true);
            CurrentInstance = _incidentProductInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentProduct) Initializer

        #region Properties

        private const string PropertyPrimaryId = "PrimaryId";
        private const string PropertyIncidentCategory = "IncidentCategory";
        private const string PropertyDescription = "Description";
        private const string PropertyResolutionGroup = "ResolutionGroup";

        #endregion

        #endregion

        #region General Initializer : Class (IncidentProduct) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProduct_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProduct) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProduct_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProduct) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProduct_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentProduct)

        #region General Initializer : Class (IncidentProduct) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyIncidentCategory)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyResolutionGroup)]
        [Category("AUT Property")]
        public void AUT_IncidentProduct_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (IncidentProduct) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProduct_Is_Instance_Present_Test()
        {
            // Assert
            _incidentProductInstanceType.ShouldNotBeNull();
            _incidentProductInstance.ShouldNotBeNull();
            _incidentProductInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentProduct) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProduct_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentProductInstance.ShouldBeAssignableTo<IncidentProduct>();
            _incidentProductInstanceFixture.ShouldBeAssignableTo<IncidentProduct>();
            CurrentInstance.ShouldBeAssignableTo<IncidentProduct>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentProduct) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentProduct instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var id = this.CreateType<string>();
            var category = this.CreateType<string>();
            var desc = this.CreateType<string>();
            var group = this.CreateType<string>();
            IncidentProduct instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new IncidentProduct(id, category, desc, group);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _incidentProductInstance.ShouldNotBeNull();
            _incidentProductInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<IncidentProduct>();
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var id = this.CreateType<string>();
            var category = this.CreateType<string>();
            var desc = this.CreateType<string>();
            var group = this.CreateType<string>();
            IncidentProduct instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new IncidentProduct(id, category, desc, group);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _incidentProductInstance.ShouldNotBeNull();
            _incidentProductInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) instance created

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Is_Created_Test()
        {
            // Assert
            _incidentProductInstance.ShouldNotBeNull();
            _incidentProductInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="IncidentProduct" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_IncidentProduct_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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

        #region General Constructor : Class (IncidentProduct) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="IncidentProduct" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IncidentProduct" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodIncidentProductParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIncidentProductParametersTypes);
        }

        #endregion

        #region General Constructor : Class (IncidentProduct) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="IncidentProduct" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProduct_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodIncidentProductParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodIncidentProductParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (IncidentProduct) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyPrimaryId)]
        [TestCase(PropertyIncidentCategory)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyResolutionGroup)]
        public void AUT_IncidentProduct_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (IncidentProduct) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProduct_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (IncidentProduct) => Property (IncidentCategory) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProduct_Public_Class_IncidentCategory_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyIncidentCategory);
            var propertyInfo = this.GetPropertyInfo(PropertyIncidentCategory);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (IncidentProduct) => Property (PrimaryId) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProduct_Public_Class_PrimaryId_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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

        #region General Getters/Setters : Class (IncidentProduct) => Property (ResolutionGroup) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProduct_Public_Class_ResolutionGroup_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResolutionGroup);
            var propertyInfo = this.GetPropertyInfo(PropertyResolutionGroup);

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