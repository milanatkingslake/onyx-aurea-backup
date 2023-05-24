using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ONS.AdapterExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part09.AUT.Tests.ONS.AdapterExtension.Base
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ONS.AdapterExtension.Base.TaskFilter" />)
    ///     and namespace <see cref="Onyx.ONS.AdapterExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TaskFilterTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TaskFilter" />)
        /// </summary>
        public TaskFilterTest() : base(typeof(TaskFilter))
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

        #region General Initializer : Class (TaskFilter) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _taskFilterInstanceType;
        private TaskFilter _taskFilterInstance;
        private TaskFilter _taskFilterInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TaskFilter" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _taskFilterInstanceType = typeof(TaskFilter);
            _taskFilterInstanceFixture = this.Create<TaskFilter>(false);
            _taskFilterInstance = _taskFilterInstanceFixture ?? this.Create<TaskFilter>(true);
            CurrentInstance = _taskFilterInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TaskFilter) Initializer

        #region Properties

        private const string PropertyConfig = "Config";

        #endregion

        #region Methods

        private const string MethodValidateEventData = "ValidateEventData";
        private const string MethodDiscardInvalidEvent = "DiscardInvalidEvent";

        #endregion

        #endregion

        #region General Initializer : Class (TaskFilter) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskFilter_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TaskFilter) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskFilter_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TaskFilter) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TaskFilter_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TaskFilter)

        #region General Initializer : Class (TaskFilter) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodValidateEventData, 0)]
        [TestCase(MethodDiscardInvalidEvent, 0)]
        public void AUT_TaskFilter_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var currentMethodInfo = this.GetMethodInfo(name, overloadingIndex);

            // Act
            currentMethodInfo = currentMethodInfo.GetPreparedGenericMethodUsing();
            this.ExploreMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (TaskFilter) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfig)]
        [Category("AUT Property")]
        public void AUT_TaskFilter_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (TaskFilter) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskFilter_Is_Instance_Present_Test()
        {
            // Assert
            _taskFilterInstanceType.ShouldNotBeNull();
            _taskFilterInstance.ShouldNotBeNull();
            _taskFilterInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TaskFilter) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TaskFilter_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _taskFilterInstance.ShouldBeAssignableTo<TaskFilter>();
            _taskFilterInstanceFixture.ShouldBeAssignableTo<TaskFilter>();
            CurrentInstance.ShouldBeAssignableTo<TaskFilter>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TaskFilter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskFilter_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            TaskFilter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TaskFilter(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _taskFilterInstance.ShouldNotBeNull();
            _taskFilterInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<TaskFilter>();
        }

        #endregion

        #region General Constructor : Class (TaskFilter) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskFilter_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            TaskFilter instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new TaskFilter(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _taskFilterInstance.ShouldNotBeNull();
            _taskFilterInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (TaskFilter) instance created

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskFilter_Is_Created_Test()
        {
            // Assert
            _taskFilterInstance.ShouldNotBeNull();
            _taskFilterInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TaskFilter) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="TaskFilter" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_TaskFilter_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (TaskFilter) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="TaskFilter" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskFilter_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (TaskFilter) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="TaskFilter" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TaskFilter_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodTaskFilterParametersTypes = new Type[] { typeof(XElement) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodTaskFilterParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (TaskFilter) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfig)]
        public void AUT_TaskFilter_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (TaskFilter) => Property (Config) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TaskFilter_Config_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);
            Action currentAction = () => propertyInfo.SetValue(_taskFilterInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (TaskFilter) => Property (Config) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_TaskFilter_Public_Class_Config_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ValidateEventData) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _taskFilterInstance.ValidateEventData(eventData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, methodValidateEventDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_taskFilterInstanceFixture, parametersOfValidateEventData);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, methodValidateEventDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_taskFilterInstanceFixture, out exception1, parametersOfValidateEventData);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateEventDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_ValidateEventData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_Internally(Type[] types)
        {
            var methodDiscardInvalidEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _taskFilterInstance.DiscardInvalidEvent(eventData, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_taskFilterInstanceFixture, parametersOfDiscardInvalidEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_taskFilterInstanceFixture, out exception1, parametersOfDiscardInvalidEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TaskFilter_DiscardInvalidEvent_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}