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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.MonthsOfYearSelector" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class MonthsOfYearSelectorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MonthsOfYearSelector" />)
        /// </summary>
        public MonthsOfYearSelectorTest() : base(typeof(MonthsOfYearSelector))
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

        #region General Initializer : Class (MonthsOfYearSelector) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _monthsOfYearSelectorInstanceType;
        private MonthsOfYearSelector _monthsOfYearSelectorInstance;
        private MonthsOfYearSelector _monthsOfYearSelectorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MonthsOfYearSelector" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _monthsOfYearSelectorInstanceType = typeof(MonthsOfYearSelector);
            _monthsOfYearSelectorInstanceFixture = this.Create<MonthsOfYearSelector>(false);
            _monthsOfYearSelectorInstance = _monthsOfYearSelectorInstanceFixture ?? this.Create<MonthsOfYearSelector>(true);
            CurrentInstance = _monthsOfYearSelectorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MonthsOfYearSelector) Initializer

        #region Properties

        private const string PropertyJanuary = "January";
        private const string PropertyFebruary = "February";
        private const string PropertyMarch = "March";
        private const string PropertyApril = "April";
        private const string PropertyMay = "May";
        private const string PropertyJune = "June";
        private const string PropertyJuly = "July";
        private const string PropertyAugust = "August";
        private const string PropertySeptember = "September";
        private const string PropertyOctober = "October";
        private const string PropertyNovember = "November";
        private const string PropertyDecember = "December";

        #endregion

        #region Fields

        private const string FieldjanuaryField = "januaryField";
        private const string FieldfebruaryField = "februaryField";
        private const string FieldmarchField = "marchField";
        private const string FieldaprilField = "aprilField";
        private const string FieldmayField = "mayField";
        private const string FieldjuneField = "juneField";
        private const string FieldjulyField = "julyField";
        private const string FieldaugustField = "augustField";
        private const string FieldseptemberField = "septemberField";
        private const string FieldoctoberField = "octoberField";
        private const string FieldnovemberField = "novemberField";
        private const string FielddecemberField = "decemberField";

        #endregion

        #endregion

        #region General Initializer : Class (MonthsOfYearSelector) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthsOfYearSelector_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MonthsOfYearSelector) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthsOfYearSelector_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MonthsOfYearSelector) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthsOfYearSelector_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MonthsOfYearSelector)

        #region General Initializer : Class (MonthsOfYearSelector) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyJanuary)]
        [TestCase(PropertyFebruary)]
        [TestCase(PropertyMarch)]
        [TestCase(PropertyApril)]
        [TestCase(PropertyMay)]
        [TestCase(PropertyJune)]
        [TestCase(PropertyJuly)]
        [TestCase(PropertyAugust)]
        [TestCase(PropertySeptember)]
        [TestCase(PropertyOctober)]
        [TestCase(PropertyNovember)]
        [TestCase(PropertyDecember)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_MonthsOfYearSelector_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (MonthsOfYearSelector) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldjanuaryField)]
        [TestCase(FieldfebruaryField)]
        [TestCase(FieldmarchField)]
        [TestCase(FieldaprilField)]
        [TestCase(FieldmayField)]
        [TestCase(FieldjuneField)]
        [TestCase(FieldjulyField)]
        [TestCase(FieldaugustField)]
        [TestCase(FieldseptemberField)]
        [TestCase(FieldoctoberField)]
        [TestCase(FieldnovemberField)]
        [TestCase(FielddecemberField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_MonthsOfYearSelector_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MonthsOfYearSelector) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_MonthsOfYearSelector_Is_Instance_Present_Test()
        {
            // Assert
            _monthsOfYearSelectorInstanceType.ShouldNotBeNull();
            _monthsOfYearSelectorInstance.ShouldNotBeNull();
            _monthsOfYearSelectorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MonthsOfYearSelector) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MonthsOfYearSelector" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_MonthsOfYearSelector_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _monthsOfYearSelectorInstance.ShouldBeAssignableTo<MonthsOfYearSelector>();
            _monthsOfYearSelectorInstanceFixture.ShouldBeAssignableTo<MonthsOfYearSelector>();
            CurrentInstance.ShouldBeAssignableTo<MonthsOfYearSelector>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MonthsOfYearSelector) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_MonthsOfYearSelector_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MonthsOfYearSelector instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MonthsOfYearSelector) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyJanuary)]
        [TestCase(PropertyFebruary)]
        [TestCase(PropertyMarch)]
        [TestCase(PropertyApril)]
        [TestCase(PropertyMay)]
        [TestCase(PropertyJune)]
        [TestCase(PropertyJuly)]
        [TestCase(PropertyAugust)]
        [TestCase(PropertySeptember)]
        [TestCase(PropertyOctober)]
        [TestCase(PropertyNovember)]
        [TestCase(PropertyDecember)]
        public void AUT_MonthsOfYearSelector_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (April) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_April_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyApril);
            var propertyInfo = this.GetPropertyInfo(PropertyApril);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (August) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_August_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyAugust);
            var propertyInfo = this.GetPropertyInfo(PropertyAugust);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (December) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_December_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDecember);
            var propertyInfo = this.GetPropertyInfo(PropertyDecember);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (February) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_February_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyFebruary);
            var propertyInfo = this.GetPropertyInfo(PropertyFebruary);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (January) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_January_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyJanuary);
            var propertyInfo = this.GetPropertyInfo(PropertyJanuary);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (July) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_July_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyJuly);
            var propertyInfo = this.GetPropertyInfo(PropertyJuly);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (June) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_June_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyJune);
            var propertyInfo = this.GetPropertyInfo(PropertyJune);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (March) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_March_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMarch);
            var propertyInfo = this.GetPropertyInfo(PropertyMarch);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (May) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_May_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMay);
            var propertyInfo = this.GetPropertyInfo(PropertyMay);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (November) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_November_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNovember);
            var propertyInfo = this.GetPropertyInfo(PropertyNovember);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (October) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_October_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOctober);
            var propertyInfo = this.GetPropertyInfo(PropertyOctober);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthsOfYearSelector) => Property (September) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthsOfYearSelector_Public_Class_September_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertySeptember);
            var propertyInfo = this.GetPropertyInfo(PropertySeptember);

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