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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.ResultGrid" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ResultGridTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ResultGrid" />)
        /// </summary>
        public ResultGridTest() : base(typeof(ResultGrid))
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

        #region General Initializer : Class (ResultGrid) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _resultGridInstanceType;
        private ResultGrid _resultGridInstance;
        private ResultGrid _resultGridInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ResultGrid" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _resultGridInstanceType = typeof(ResultGrid);
            _resultGridInstanceFixture = this.Create<ResultGrid>(false);
            _resultGridInstance = _resultGridInstanceFixture ?? this.Create<ResultGrid>(true);
            CurrentInstance = _resultGridInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ResultGrid) Initializer

        #region Properties

        private const string PropertyResultGridConfiguration = "ResultGridConfiguration";
        private const string PropertyResultGridObjectCollection = "ResultGridObjectCollection";

        #endregion

        #endregion

        #region General Initializer : Class (ResultGrid) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGrid_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGrid) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGrid_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ResultGrid) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ResultGrid_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ResultGrid)

        #region General Initializer : Class (ResultGrid) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyResultGridConfiguration)]
        [TestCase(PropertyResultGridObjectCollection)]
        [Category("AUT Property")]
        public void AUT_ResultGrid_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ResultGrid) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGrid_Is_Instance_Present_Test()
        {
            // Assert
            _resultGridInstanceType.ShouldNotBeNull();
            _resultGridInstance.ShouldNotBeNull();
            _resultGridInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ResultGrid) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ResultGrid" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ResultGrid_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _resultGridInstance.ShouldBeAssignableTo<ResultGrid>();
            _resultGridInstanceFixture.ShouldBeAssignableTo<ResultGrid>();
            CurrentInstance.ShouldBeAssignableTo<ResultGrid>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ResultGrid) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ResultGrid_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ResultGrid instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ResultGrid) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyResultGridConfiguration)]
        [TestCase(PropertyResultGridObjectCollection)]
        public void AUT_ResultGrid_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ResultGrid) => Property (ResultGridConfiguration) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGrid_ResultGridConfiguration_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResultGridConfiguration);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyResultGridConfiguration);
            Action currentAction = () => propertyInfo.SetValue(_resultGridInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ResultGrid) => Property (ResultGridConfiguration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGrid_Public_Class_ResultGridConfiguration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResultGridConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyResultGridConfiguration);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ResultGrid) => Property (ResultGridObjectCollection) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_ResultGrid_Public_Class_ResultGridObjectCollection_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyResultGridObjectCollection);
            var propertyInfo = this.GetPropertyInfo(PropertyResultGridObjectCollection);

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