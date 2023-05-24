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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.MonthlyRecurrence" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class MonthlyRecurrenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="MonthlyRecurrence" />)
        /// </summary>
        public MonthlyRecurrenceTest() : base(typeof(MonthlyRecurrence))
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

        #region General Initializer : Class (MonthlyRecurrence) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _monthlyRecurrenceInstanceType;
        private MonthlyRecurrence _monthlyRecurrenceInstance;
        private MonthlyRecurrence _monthlyRecurrenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="MonthlyRecurrence" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _monthlyRecurrenceInstanceType = typeof(MonthlyRecurrence);
            _monthlyRecurrenceInstanceFixture = this.Create<MonthlyRecurrence>(false);
            _monthlyRecurrenceInstance = _monthlyRecurrenceInstanceFixture ?? this.Create<MonthlyRecurrence>(true);
            CurrentInstance = _monthlyRecurrenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (MonthlyRecurrence) Initializer

        #region Properties

        private const string PropertyDays = "Days";
        private const string PropertyMonthsOfYear = "MonthsOfYear";

        #endregion

        #region Fields

        private const string FielddaysField = "daysField";
        private const string FieldmonthsOfYearField = "monthsOfYearField";

        #endregion

        #endregion

        #region General Initializer : Class (MonthlyRecurrence) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthlyRecurrence_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MonthlyRecurrence) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthlyRecurrence_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (MonthlyRecurrence) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_MonthlyRecurrence_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (MonthlyRecurrence)

        #region General Initializer : Class (MonthlyRecurrence) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyDays)]
        [TestCase(PropertyMonthsOfYear)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_MonthlyRecurrence_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (MonthlyRecurrence) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FielddaysField)]
        [TestCase(FieldmonthsOfYearField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_MonthlyRecurrence_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (MonthlyRecurrence) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_MonthlyRecurrence_Is_Instance_Present_Test()
        {
            // Assert
            _monthlyRecurrenceInstanceType.ShouldNotBeNull();
            _monthlyRecurrenceInstance.ShouldNotBeNull();
            _monthlyRecurrenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (MonthlyRecurrence) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="MonthlyRecurrence" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_MonthlyRecurrence_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _monthlyRecurrenceInstance.ShouldBeAssignableTo<MonthlyRecurrence>();
            _monthlyRecurrenceInstanceFixture.ShouldBeAssignableTo<MonthlyRecurrence>();
            CurrentInstance.ShouldBeAssignableTo<MonthlyRecurrence>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (MonthlyRecurrence) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_MonthlyRecurrence_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            MonthlyRecurrence instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (MonthlyRecurrence) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyDays)]
        [TestCase(PropertyMonthsOfYear)]
        public void AUT_MonthlyRecurrence_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (MonthlyRecurrence) => Property (Days) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthlyRecurrence_Public_Class_Days_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDays);
            var propertyInfo = this.GetPropertyInfo(PropertyDays);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (MonthlyRecurrence) => Property (MonthsOfYear) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthlyRecurrence_MonthsOfYear_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMonthsOfYear);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyMonthsOfYear);
            Action currentAction = () => propertyInfo.SetValue(_monthlyRecurrenceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (MonthlyRecurrence) => Property (MonthsOfYear) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_MonthlyRecurrence_Public_Class_MonthsOfYear_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyMonthsOfYear);
            var propertyInfo = this.GetPropertyInfo(PropertyMonthsOfYear);

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