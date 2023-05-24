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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.Schedule" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ScheduleTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Schedule" />)
        /// </summary>
        public ScheduleTest() : base(typeof(Schedule))
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

        #region General Initializer : Class (Schedule) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _scheduleInstanceType;
        private Schedule _scheduleInstance;
        private Schedule _scheduleInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Schedule" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _scheduleInstanceType = typeof(Schedule);
            _scheduleInstanceFixture = this.Create<Schedule>(false);
            _scheduleInstance = _scheduleInstanceFixture ?? this.Create<Schedule>(true);
            CurrentInstance = _scheduleInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Schedule) Initializer

        #region Properties

        private const string PropertyScheduleID = "ScheduleID";
        private const string PropertyName = "Name";
        private const string PropertyDefinition = "Definition";
        private const string PropertyDescription = "Description";
        private const string PropertyCreator = "Creator";
        private const string PropertyNextRunTime = "NextRunTime";
        private const string PropertyNextRunTimeSpecified = "NextRunTimeSpecified";
        private const string PropertyLastRunTime = "LastRunTime";
        private const string PropertyLastRunTimeSpecified = "LastRunTimeSpecified";
        private const string PropertyReferencesPresent = "ReferencesPresent";
        private const string PropertyState = "State";

        #endregion

        #region Fields

        private const string FieldscheduleIDField = "scheduleIDField";
        private const string FieldnameField = "nameField";
        private const string FielddefinitionField = "definitionField";
        private const string FielddescriptionField = "descriptionField";
        private const string FieldcreatorField = "creatorField";
        private const string FieldnextRunTimeField = "nextRunTimeField";
        private const string FieldnextRunTimeFieldSpecified = "nextRunTimeFieldSpecified";
        private const string FieldlastRunTimeField = "lastRunTimeField";
        private const string FieldlastRunTimeFieldSpecified = "lastRunTimeFieldSpecified";
        private const string FieldreferencesPresentField = "referencesPresentField";
        private const string FieldstateField = "stateField";

        #endregion

        #endregion

        #region General Initializer : Class (Schedule) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Schedule" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Schedule_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Schedule) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="Schedule" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Schedule_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Schedule) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Schedule" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [NUnit.Framework.Category("AUT Reflection NonListed")]
        [NUnit.Framework.Category("AUT Slow Tests")]
        [NUnit.Framework.Category("AUT Explore")]
        public void AUT_Schedule_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Schedule)

        #region General Initializer : Class (Schedule) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="Schedule" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(PropertyScheduleID)]
        [TestCase(PropertyName)]
        [TestCase(PropertyDefinition)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyCreator)]
        [TestCase(PropertyNextRunTime)]
        [TestCase(PropertyNextRunTimeSpecified)]
        [TestCase(PropertyLastRunTime)]
        [TestCase(PropertyLastRunTimeSpecified)]
        [TestCase(PropertyReferencesPresent)]
        [TestCase(PropertyState)]
        [NUnit.Framework.Category("AUT Property")]
        public void AUT_Schedule_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (Schedule) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Schedule" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Initializer")]
        [TestCase(FieldscheduleIDField)]
        [TestCase(FieldnameField)]
        [TestCase(FielddefinitionField)]
        [TestCase(FielddescriptionField)]
        [TestCase(FieldcreatorField)]
        [TestCase(FieldnextRunTimeField)]
        [TestCase(FieldnextRunTimeFieldSpecified)]
        [TestCase(FieldlastRunTimeField)]
        [TestCase(FieldlastRunTimeFieldSpecified)]
        [TestCase(FieldreferencesPresentField)]
        [TestCase(FieldstateField)]
        [NUnit.Framework.Category("AUT Fields")]
        public void AUT_Schedule_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Schedule) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Schedule" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_Schedule_Is_Instance_Present_Test()
        {
            // Assert
            _scheduleInstanceType.ShouldNotBeNull();
            _scheduleInstance.ShouldNotBeNull();
            _scheduleInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Schedule) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Schedule" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Instance")]
        public void AUT_Schedule_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _scheduleInstance.ShouldBeAssignableTo<Schedule>();
            _scheduleInstanceFixture.ShouldBeAssignableTo<Schedule>();
            CurrentInstance.ShouldBeAssignableTo<Schedule>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Schedule) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT Constructor")]
        public void AUT_Schedule_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Schedule instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (Schedule) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        [TestCase(PropertyScheduleID)]
        [TestCase(PropertyName)]
        [TestCase(PropertyDefinition)]
        [TestCase(PropertyDescription)]
        [TestCase(PropertyCreator)]
        [TestCase(PropertyNextRunTime)]
        [TestCase(PropertyNextRunTimeSpecified)]
        [TestCase(PropertyLastRunTime)]
        [TestCase(PropertyLastRunTimeSpecified)]
        [TestCase(PropertyReferencesPresent)]
        [TestCase(PropertyState)]
        public void AUT_Schedule_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (Schedule) => Property (Creator) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_Creator_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyCreator);
            var propertyInfo = this.GetPropertyInfo(PropertyCreator);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (Definition) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Definition_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefinition);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyDefinition);
            Action currentAction = () => propertyInfo.SetValue(_scheduleInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (Definition) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_Definition_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDefinition);
            var propertyInfo = this.GetPropertyInfo(PropertyDefinition);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (Description) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_Description_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyDescription);
            var propertyInfo = this.GetPropertyInfo(PropertyDescription);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (LastRunTime) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_LastRunTime_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastRunTime);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyLastRunTime);
            Action currentAction = () => propertyInfo.SetValue(_scheduleInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (LastRunTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_LastRunTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastRunTime);
            var propertyInfo = this.GetPropertyInfo(PropertyLastRunTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (LastRunTimeSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_LastRunTimeSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyLastRunTimeSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyLastRunTimeSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (Name) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_Name_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyName);
            var propertyInfo = this.GetPropertyInfo(PropertyName);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (NextRunTime) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_NextRunTime_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNextRunTime);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNextRunTime);
            Action currentAction = () => propertyInfo.SetValue(_scheduleInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (NextRunTime) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_NextRunTime_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNextRunTime);
            var propertyInfo = this.GetPropertyInfo(PropertyNextRunTime);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (NextRunTimeSpecified) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_NextRunTimeSpecified_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNextRunTimeSpecified);
            var propertyInfo = this.GetPropertyInfo(PropertyNextRunTimeSpecified);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (ReferencesPresent) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_ReferencesPresent_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyReferencesPresent);
            var propertyInfo = this.GetPropertyInfo(PropertyReferencesPresent);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (ScheduleID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_ScheduleID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyScheduleID);
            var propertyInfo = this.GetPropertyInfo(PropertyScheduleID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (State) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_State_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyState);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyState);
            Action currentAction = () => propertyInfo.SetValue(_scheduleInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (Schedule) => Property (State) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT GetterSetter")]
        public void AUT_Schedule_Public_Class_State_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyState);
            var propertyInfo = this.GetPropertyInfo(PropertyState);

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