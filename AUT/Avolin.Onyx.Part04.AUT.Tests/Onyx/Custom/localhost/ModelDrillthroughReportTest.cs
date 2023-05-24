using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ModelDrillthroughReport" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ModelDrillthroughReportTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ModelDrillthroughReport" />)
        /// </summary>
        public ModelDrillthroughReportTest() : base(typeof(ModelDrillthroughReport))
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

        #region General Initializer : Class (ModelDrillthroughReport) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _modelDrillthroughReportInstanceType;
        private ModelDrillthroughReport _modelDrillthroughReportInstance;
        private ModelDrillthroughReport _modelDrillthroughReportInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ModelDrillthroughReport" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _modelDrillthroughReportInstanceType = typeof(ModelDrillthroughReport);
            _modelDrillthroughReportInstanceFixture = this.Create<ModelDrillthroughReport>(false);
            _modelDrillthroughReportInstance = _modelDrillthroughReportInstanceFixture ?? this.Create<ModelDrillthroughReport>(true);
            CurrentInstance = _modelDrillthroughReportInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ModelDrillthroughReport) Initializer

        #region Properties

        private const string PropertyPath = "Path";
        private const string PropertyType = "Type";

        #endregion

        #region Fields

        private const string FieldpathField = "pathField";
        private const string FieldtypeField = "typeField";

        #endregion

        #endregion

        #region General Initializer : Class (ModelDrillthroughReport) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelDrillthroughReport_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDrillthroughReport) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelDrillthroughReport_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ModelDrillthroughReport) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ModelDrillthroughReport_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ModelDrillthroughReport)

        #region General Initializer : Class (ModelDrillthroughReport) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyPath)]
        [TestCase(PropertyType)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ModelDrillthroughReport_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ModelDrillthroughReport) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldpathField)]
        [TestCase(FieldtypeField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ModelDrillthroughReport_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ModelDrillthroughReport) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ModelDrillthroughReport_Is_Instance_Present_Test()
        {
            // Assert
            _modelDrillthroughReportInstanceType.ShouldNotBeNull();
            _modelDrillthroughReportInstance.ShouldNotBeNull();
            _modelDrillthroughReportInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ModelDrillthroughReport) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ModelDrillthroughReport" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ModelDrillthroughReport_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _modelDrillthroughReportInstance.ShouldBeAssignableTo<ModelDrillthroughReport>();
            _modelDrillthroughReportInstanceFixture.ShouldBeAssignableTo<ModelDrillthroughReport>();
            CurrentInstance.ShouldBeAssignableTo<ModelDrillthroughReport>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ModelDrillthroughReport) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ModelDrillthroughReport_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ModelDrillthroughReport instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ModelDrillthroughReport) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyPath)]
        [TestCase(PropertyType)]
        public void AUT_ModelDrillthroughReport_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ModelDrillthroughReport) => Property (Path) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelDrillthroughReport_Public_Class_Path_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyPath);
            var propertyInfo = this.GetPropertyInfo(PropertyPath);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ModelDrillthroughReport) => Property (Type) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelDrillthroughReport_Type_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyType);
            Action currentAction = () => propertyInfo.SetValue(_modelDrillthroughReportInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ModelDrillthroughReport) => Property (Type) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ModelDrillthroughReport_Public_Class_Type_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyType);
            var propertyInfo = this.GetPropertyInfo(PropertyType);

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