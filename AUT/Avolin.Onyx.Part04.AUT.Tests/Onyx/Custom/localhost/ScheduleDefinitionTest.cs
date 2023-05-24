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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ScheduleDefinition" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScheduleDefinitionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ScheduleDefinition" />)
        /// </summary>
        public ScheduleDefinitionTest() : base(typeof(ScheduleDefinition))
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

        #region General Initializer : Class (ScheduleDefinition) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scheduleDefinitionInstanceType;
        private ScheduleDefinition _scheduleDefinitionInstance;
        private ScheduleDefinition _scheduleDefinitionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ScheduleDefinition" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scheduleDefinitionInstanceType = typeof(ScheduleDefinition);
            _scheduleDefinitionInstanceFixture = this.Create<ScheduleDefinition>(false);
            _scheduleDefinitionInstance = _scheduleDefinitionInstanceFixture ?? this.Create<ScheduleDefinition>(true);
            CurrentInstance = _scheduleDefinitionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ScheduleDefinition) Initializer

        #region Properties

        private const string PropertyStartDateTime = "StartDateTime";
        private const string PropertyEndDate = "EndDate";
        private const string PropertyEndDateSpecified = "EndDateSpecified";
        private const string PropertyItem = "Item";

        #endregion

        #region Fields

        private const string FieldstartDateTimeField = "startDateTimeField";
        private const string FieldendDateField = "endDateField";
        private const string FieldendDateFieldSpecified = "endDateFieldSpecified";
        private const string FielditemField = "itemField";

        #endregion

        #endregion

        #region General Initializer : Class (ScheduleDefinition) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleDefinition_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScheduleDefinition) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleDefinition_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ScheduleDefinition) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_ScheduleDefinition_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ScheduleDefinition)

        #region General Initializer : Class (ScheduleDefinition) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyStartDateTime)]
        [TestCase(PropertyEndDate)]
        [TestCase(PropertyEndDateSpecified)]
        [TestCase(PropertyItem)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_ScheduleDefinition_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (ScheduleDefinition) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldstartDateTimeField)]
        [TestCase(FieldendDateField)]
        [TestCase(FieldendDateFieldSpecified)]
        [TestCase(FielditemField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_ScheduleDefinition_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ScheduleDefinition) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleDefinition_Is_Instance_Present_Test()
        {
            // Assert
            _scheduleDefinitionInstanceType.ShouldNotBeNull();
            _scheduleDefinitionInstance.ShouldNotBeNull();
            _scheduleDefinitionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ScheduleDefinition) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ScheduleDefinition" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_ScheduleDefinition_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scheduleDefinitionInstance.ShouldBeAssignableTo<ScheduleDefinition>();
            _scheduleDefinitionInstanceFixture.ShouldBeAssignableTo<ScheduleDefinition>();
            CurrentInstance.ShouldBeAssignableTo<ScheduleDefinition>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ScheduleDefinition) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_ScheduleDefinition_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ScheduleDefinition instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (ScheduleDefinition) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyStartDateTime)]
        [TestCase(PropertyEndDate)]
        [TestCase(PropertyEndDateSpecified)]
        [TestCase(PropertyItem)]
        public void AUT_ScheduleDefinition_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (EndDate) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_EndDate_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndDate);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyEndDate);
            Action currentAction = () => propertyInfo.SetValue(_scheduleDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (EndDate) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_Public_Class_EndDate_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndDate);
            var propertyInfo = this.GetPropertyInfo(PropertyEndDate);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (EndDateSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_Public_Class_EndDateSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyEndDateSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyEndDateSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (Item) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_Item_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyItem);
            Action currentAction = () => propertyInfo.SetValue(_scheduleDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (Item) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_Public_Class_Item_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyItem);
            var propertyInfo = this.GetPropertyInfo(PropertyItem);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (StartDateTime) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_StartDateTime_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartDateTime);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyStartDateTime);
            Action currentAction = () => propertyInfo.SetValue(_scheduleDefinitionInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (ScheduleDefinition) => Property (StartDateTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_ScheduleDefinition_Public_Class_StartDateTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyStartDateTime);
            var propertyInfo = this.GetPropertyInfo(PropertyStartDateTime);

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