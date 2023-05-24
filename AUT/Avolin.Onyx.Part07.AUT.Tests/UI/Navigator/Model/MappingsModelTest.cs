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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.MappingsModel" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class MappingsModelTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MappingsModel" />)
        /// </summary>
        public MappingsModelTest() : base(typeof(MappingsModel))
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

        #region General Initializer : Class (MappingsModel) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _mappingsModelInstanceType;
        private MappingsModel _mappingsModelInstance;
        private MappingsModel _mappingsModelInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MappingsModel" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _mappingsModelInstanceType = typeof(MappingsModel);
            _mappingsModelInstanceFixture = this.Create<MappingsModel>(false);
            _mappingsModelInstance = _mappingsModelInstanceFixture ?? this.Create<MappingsModel>(true);
            CurrentInstance = _mappingsModelInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MappingsModel) Initializer

        #region Properties

        private const string PropertyMappingEntity = "MappingEntity";
        private const string PropertyObjectNodeName = "ObjectNodeName";
        private const string PropertyMethod = "Method";
        private const string PropertyMappingList = "MappingList";

        #endregion

        #endregion

        #region General Initializer : Class (MappingsModel) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MappingsModel_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MappingsModel) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MappingsModel_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MappingsModel) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_MappingsModel_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MappingsModel)

        #region General Initializer : Class (MappingsModel) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyMappingEntity)]
        [TestCase(PropertyObjectNodeName)]
        [TestCase(PropertyMethod)]
        [TestCase(PropertyMappingList)]
        [Category("AUT Property")]
        public void AUT_MappingsModel_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MappingsModel) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MappingsModel_Is_Instance_Present_Test()
        {
            // Assert
            _mappingsModelInstanceType.ShouldNotBeNull();
            _mappingsModelInstance.ShouldNotBeNull();
            _mappingsModelInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MappingsModel) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MappingsModel" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_MappingsModel_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _mappingsModelInstance.ShouldBeAssignableTo<MappingsModel>();
            _mappingsModelInstanceFixture.ShouldBeAssignableTo<MappingsModel>();
            CurrentInstance.ShouldBeAssignableTo<MappingsModel>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MappingsModel) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_MappingsModel_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MappingsModel instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MappingsModel) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyMappingEntity)]
        [TestCase(PropertyObjectNodeName)]
        [TestCase(PropertyMethod)]
        [TestCase(PropertyMappingList)]
        public void AUT_MappingsModel_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MappingsModel) => Property (MappingEntity) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MappingsModel_Public_Class_MappingEntity_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMappingEntity);
            var propertyInfo = this.GetPropertyInfo(PropertyMappingEntity);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MappingsModel) => Property (MappingList) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MappingsModel_Public_Class_MappingList_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMappingList);
            var propertyInfo = this.GetPropertyInfo(PropertyMappingList);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MappingsModel) => Property (Method) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MappingsModel_Public_Class_Method_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMethod);
            var propertyInfo = this.GetPropertyInfo(PropertyMethod);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MappingsModel) => Property (ObjectNodeName) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_MappingsModel_Public_Class_ObjectNodeName_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyObjectNodeName);
            var propertyInfo = this.GetPropertyInfo(PropertyObjectNodeName);

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