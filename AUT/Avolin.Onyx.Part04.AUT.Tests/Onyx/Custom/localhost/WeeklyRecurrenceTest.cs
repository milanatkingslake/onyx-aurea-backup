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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.WeeklyRecurrence" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class WeeklyRecurrenceTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WeeklyRecurrence" />)
        /// </summary>
        public WeeklyRecurrenceTest() : base(typeof(WeeklyRecurrence))
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

        #region General Initializer : Class (WeeklyRecurrence) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _weeklyRecurrenceInstanceType;
        private WeeklyRecurrence _weeklyRecurrenceInstance;
        private WeeklyRecurrence _weeklyRecurrenceInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="WeeklyRecurrence" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _weeklyRecurrenceInstanceType = typeof(WeeklyRecurrence);
            _weeklyRecurrenceInstanceFixture = this.Create<WeeklyRecurrence>(false);
            _weeklyRecurrenceInstance = _weeklyRecurrenceInstanceFixture ?? this.Create<WeeklyRecurrence>(true);
            CurrentInstance = _weeklyRecurrenceInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WeeklyRecurrence) Initializer

        #region Properties

        private const string PropertyWeeksInterval = "WeeksInterval";
        private const string PropertyWeeksIntervalSpecified = "WeeksIntervalSpecified";
        private const string PropertyDaysOfWeek = "DaysOfWeek";

        #endregion

        #region Fields

        private const string FieldweeksIntervalField = "weeksIntervalField";
        private const string FieldweeksIntervalFieldSpecified = "weeksIntervalFieldSpecified";
        private const string FielddaysOfWeekField = "daysOfWeekField";

        #endregion

        #endregion

        #region General Initializer : Class (WeeklyRecurrence) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_WeeklyRecurrence_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WeeklyRecurrence) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_WeeklyRecurrence_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WeeklyRecurrence) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_WeeklyRecurrence_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WeeklyRecurrence)

        #region General Initializer : Class (WeeklyRecurrence) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyWeeksInterval)]
        [TestCase(PropertyWeeksIntervalSpecified)]
        [TestCase(PropertyDaysOfWeek)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_WeeklyRecurrence_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (WeeklyRecurrence) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldweeksIntervalField)]
        [TestCase(FieldweeksIntervalFieldSpecified)]
        [TestCase(FielddaysOfWeekField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_WeeklyRecurrence_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (WeeklyRecurrence) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_WeeklyRecurrence_Is_Instance_Present_Test()
        {
            // Assert
            _weeklyRecurrenceInstanceType.ShouldNotBeNull();
            _weeklyRecurrenceInstance.ShouldNotBeNull();
            _weeklyRecurrenceInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (WeeklyRecurrence) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="WeeklyRecurrence" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_WeeklyRecurrence_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _weeklyRecurrenceInstance.ShouldBeAssignableTo<WeeklyRecurrence>();
            _weeklyRecurrenceInstanceFixture.ShouldBeAssignableTo<WeeklyRecurrence>();
            CurrentInstance.ShouldBeAssignableTo<WeeklyRecurrence>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (WeeklyRecurrence) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_WeeklyRecurrence_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            WeeklyRecurrence instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (WeeklyRecurrence) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyWeeksInterval)]
        [TestCase(PropertyWeeksIntervalSpecified)]
        [TestCase(PropertyDaysOfWeek)]
        public void AUT_WeeklyRecurrence_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (WeeklyRecurrence) => Property (DaysOfWeek) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_WeeklyRecurrence_DaysOfWeek_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDaysOfWeek);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDaysOfWeek);
            Action currentAction = () => propertyInfo.SetValue(_weeklyRecurrenceInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (WeeklyRecurrence) => Property (DaysOfWeek) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_WeeklyRecurrence_Public_Class_DaysOfWeek_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDaysOfWeek);
            var propertyInfo = this.GetPropertyInfo(PropertyDaysOfWeek);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WeeklyRecurrence) => Property (WeeksInterval) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_WeeklyRecurrence_Public_Class_WeeksInterval_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWeeksInterval);
            var propertyInfo = this.GetPropertyInfo(PropertyWeeksInterval);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (WeeklyRecurrence) => Property (WeeksIntervalSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_WeeklyRecurrence_Public_Class_WeeksIntervalSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyWeeksIntervalSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyWeeksIntervalSpecified);

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