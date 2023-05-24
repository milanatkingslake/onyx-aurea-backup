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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.DaysOfWeekSelector" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class DaysOfWeekSelectorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="DaysOfWeekSelector" />)
        /// </summary>
        public DaysOfWeekSelectorTest() : base(typeof(DaysOfWeekSelector))
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

        #region General Initializer : Class (DaysOfWeekSelector) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _daysOfWeekSelectorInstanceType;
        private DaysOfWeekSelector _daysOfWeekSelectorInstance;
        private DaysOfWeekSelector _daysOfWeekSelectorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="DaysOfWeekSelector" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _daysOfWeekSelectorInstanceType = typeof(DaysOfWeekSelector);
            _daysOfWeekSelectorInstanceFixture = this.Create<DaysOfWeekSelector>(false);
            _daysOfWeekSelectorInstance = _daysOfWeekSelectorInstanceFixture ?? this.Create<DaysOfWeekSelector>(true);
            CurrentInstance = _daysOfWeekSelectorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (DaysOfWeekSelector) Initializer

        #region Properties

        private const string PropertySunday = "Sunday";
        private const string PropertyMonday = "Monday";
        private const string PropertyTuesday = "Tuesday";
        private const string PropertyWednesday = "Wednesday";
        private const string PropertyThursday = "Thursday";
        private const string PropertyFriday = "Friday";
        private const string PropertySaturday = "Saturday";

        #endregion

        #region Fields

        private const string FieldsundayField = "sundayField";
        private const string FieldmondayField = "mondayField";
        private const string FieldtuesdayField = "tuesdayField";
        private const string FieldwednesdayField = "wednesdayField";
        private const string FieldthursdayField = "thursdayField";
        private const string FieldfridayField = "fridayField";
        private const string FieldsaturdayField = "saturdayField";

        #endregion

        #endregion

        #region General Initializer : Class (DaysOfWeekSelector) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DaysOfWeekSelector_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DaysOfWeekSelector) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DaysOfWeekSelector_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (DaysOfWeekSelector) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_DaysOfWeekSelector_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (DaysOfWeekSelector)

        #region General Initializer : Class (DaysOfWeekSelector) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertySunday)]
        [TestCase(PropertyMonday)]
        [TestCase(PropertyTuesday)]
        [TestCase(PropertyWednesday)]
        [TestCase(PropertyThursday)]
        [TestCase(PropertyFriday)]
        [TestCase(PropertySaturday)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_DaysOfWeekSelector_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (DaysOfWeekSelector) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldsundayField)]
        [TestCase(FieldmondayField)]
        [TestCase(FieldtuesdayField)]
        [TestCase(FieldwednesdayField)]
        [TestCase(FieldthursdayField)]
        [TestCase(FieldfridayField)]
        [TestCase(FieldsaturdayField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_DaysOfWeekSelector_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (DaysOfWeekSelector) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DaysOfWeekSelector_Is_Instance_Present_Test()
        {
            // Assert
            _daysOfWeekSelectorInstanceType.ShouldNotBeNull();
            _daysOfWeekSelectorInstance.ShouldNotBeNull();
            _daysOfWeekSelectorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (DaysOfWeekSelector) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="DaysOfWeekSelector" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_DaysOfWeekSelector_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _daysOfWeekSelectorInstance.ShouldBeAssignableTo<DaysOfWeekSelector>();
            _daysOfWeekSelectorInstanceFixture.ShouldBeAssignableTo<DaysOfWeekSelector>();
            CurrentInstance.ShouldBeAssignableTo<DaysOfWeekSelector>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (DaysOfWeekSelector) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_DaysOfWeekSelector_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            DaysOfWeekSelector instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (DaysOfWeekSelector) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertySunday)]
        [TestCase(PropertyMonday)]
        [TestCase(PropertyTuesday)]
        [TestCase(PropertyWednesday)]
        [TestCase(PropertyThursday)]
        [TestCase(PropertyFriday)]
        [TestCase(PropertySaturday)]
        public void AUT_DaysOfWeekSelector_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Friday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Friday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFriday);
            var propertyInfo = this.GetPropertyInfo(PropertyFriday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Monday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Monday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMonday);
            var propertyInfo = this.GetPropertyInfo(PropertyMonday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Saturday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Saturday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySaturday);
            var propertyInfo = this.GetPropertyInfo(PropertySaturday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Sunday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Sunday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySunday);
            var propertyInfo = this.GetPropertyInfo(PropertySunday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Thursday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Thursday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyThursday);
            var propertyInfo = this.GetPropertyInfo(PropertyThursday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Tuesday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Tuesday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyTuesday);
            var propertyInfo = this.GetPropertyInfo(PropertyTuesday);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (DaysOfWeekSelector) => Property (Wednesday) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_DaysOfWeekSelector_Public_Class_Wednesday_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWednesday);
            var propertyInfo = this.GetPropertyInfo(PropertyWednesday);

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