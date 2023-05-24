using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.SystemData" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SystemDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SystemData" />)
        /// </summary>
        public SystemDataTest() : base(typeof(SystemData))
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

        #region General Initializer : Class (SystemData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _systemDataInstanceType;
        private SystemData _systemDataInstance;
        private SystemData _systemDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SystemData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _systemDataInstanceType = typeof(SystemData);
            _systemDataInstanceFixture = this.Create<SystemData>(false);
            _systemDataInstance = _systemDataInstanceFixture ?? this.Create<SystemData>(true);
            CurrentInstance = _systemDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SystemData) Initializer

        #region Properties

        private const string PropertySiteid = "Siteid";

        #endregion

        #region Fields

        private const string Fieldsiteid = "siteid";

        #endregion

        #endregion

        #region General Initializer : Class (SystemData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SystemData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SystemData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SystemData) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SystemData" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SystemData_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SystemData) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SystemData" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SystemData_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SystemData)

        #region General Initializer : Class (SystemData) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SystemData" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertySiteid)]
        [Category("AUT Property")]
        public void AUT_SystemData_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (SystemData) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="SystemData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldsiteid)]
        [Category("AUT Fields")]
        public void AUT_SystemData_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (SystemData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SystemData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SystemData_Is_Instance_Present_Test()
        {
            // Assert
            _systemDataInstanceType.ShouldNotBeNull();
            _systemDataInstance.ShouldNotBeNull();
            _systemDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SystemData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SystemData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SystemData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _systemDataInstance.ShouldBeAssignableTo<SystemData>();
            _systemDataInstanceFixture.ShouldBeAssignableTo<SystemData>();
            CurrentInstance.ShouldBeAssignableTo<SystemData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SystemData) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SystemData_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SystemData instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SystemData) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertySiteid)]
        public void AUT_SystemData_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (SystemData) => Property (Siteid) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SystemData_Public_Class_Siteid_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySiteid);
            var propertyInfo = this.GetPropertyInfo(PropertySiteid);

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