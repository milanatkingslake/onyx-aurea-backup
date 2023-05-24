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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Model.IncidentProductModel" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class IncidentProductModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentProductModel" />)
        /// </summary>
        public IncidentProductModelTest() : base(typeof(IncidentProductModel))
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

        #region General Initializer : Class (IncidentProductModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentProductModelInstanceType;
        private IncidentProductModel _incidentProductModelInstance;
        private IncidentProductModel _incidentProductModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentProductModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentProductModelInstanceType = typeof(IncidentProductModel);
            _incidentProductModelInstanceFixture = this.Create<IncidentProductModel>(false);
            _incidentProductModelInstance = _incidentProductModelInstanceFixture ?? this.Create<IncidentProductModel>(true);
            CurrentInstance = _incidentProductModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentProductModel) Initializer

        #region Properties

        private const string PropertyProductNumber = "ProductNumber";
        private const string PropertyProductDescription = "ProductDescription";

        #endregion

        #endregion

        #region General Initializer : Class (IncidentProductModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProductModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProductModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentProductModel)

        #region General Initializer : Class (IncidentProductModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyProductNumber)]
        [TestCase(PropertyProductDescription)]
        [Category("AUT Property")]
        public void AUT_IncidentProductModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (IncidentProductModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProductModel_Is_Instance_Present_Test()
        {
            // Assert
            _incidentProductModelInstanceType.ShouldNotBeNull();
            _incidentProductModelInstance.ShouldNotBeNull();
            _incidentProductModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentProductModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentProductModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProductModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentProductModelInstance.ShouldBeAssignableTo<IncidentProductModel>();
            _incidentProductModelInstanceFixture.ShouldBeAssignableTo<IncidentProductModel>();
            CurrentInstance.ShouldBeAssignableTo<IncidentProductModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentProductModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProductModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentProductModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (IncidentProductModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyProductNumber)]
        [TestCase(PropertyProductDescription)]
        public void AUT_IncidentProductModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (IncidentProductModel) => Property (ProductDescription) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProductModel_Public_Class_ProductDescription_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProductDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyProductDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (IncidentProductModel) => Property (ProductNumber) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_IncidentProductModel_Public_Class_ProductNumber_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyProductNumber);
            var propertyInfo = this.GetPropertyInfo(PropertyProductNumber);

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