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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.AdministrationServiceResult" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AdministrationServiceResultTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AdministrationServiceResult" />)
        /// </summary>
        public AdministrationServiceResultTest() : base(typeof(AdministrationServiceResult))
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

        #region General Initializer : Class (AdministrationServiceResult) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _administrationServiceResultInstanceType;
        private AdministrationServiceResult _administrationServiceResultInstance;
        private AdministrationServiceResult _administrationServiceResultInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AdministrationServiceResult" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _administrationServiceResultInstanceType = typeof(AdministrationServiceResult);
            _administrationServiceResultInstanceFixture = this.Create<AdministrationServiceResult>(false);
            _administrationServiceResultInstance = _administrationServiceResultInstanceFixture ?? this.Create<AdministrationServiceResult>(true);
            CurrentInstance = _administrationServiceResultInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AdministrationServiceResult) Initializer

        #region Properties

        private const string Propertystatus = "status";

        #endregion

        #endregion

        #region General Initializer : Class (AdministrationServiceResult) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AdministrationServiceResult_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AdministrationServiceResult) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AdministrationServiceResult_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AdministrationServiceResult) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AdministrationServiceResult_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AdministrationServiceResult)

        #region General Initializer : Class (AdministrationServiceResult) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertystatus)]
        [Category("AUT Property")]
        public void AUT_AdministrationServiceResult_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AdministrationServiceResult) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AdministrationServiceResult_Is_Instance_Present_Test()
        {
            // Assert
            _administrationServiceResultInstanceType.ShouldNotBeNull();
            _administrationServiceResultInstance.ShouldNotBeNull();
            _administrationServiceResultInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AdministrationServiceResult) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AdministrationServiceResult" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AdministrationServiceResult_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _administrationServiceResultInstance.ShouldBeAssignableTo<AdministrationServiceResult>();
            _administrationServiceResultInstanceFixture.ShouldBeAssignableTo<AdministrationServiceResult>();
            CurrentInstance.ShouldBeAssignableTo<AdministrationServiceResult>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AdministrationServiceResult) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AdministrationServiceResult_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            AdministrationServiceResult instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (AdministrationServiceResult) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertystatus)]
        public void AUT_AdministrationServiceResult_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (AdministrationServiceResult) => Property (status) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_AdministrationServiceResult_Public_Class_status_Coverage_For_Property_Is_Present_And_Can_Read_Test()
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