using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.Onyx.StepComponentLog" />)
    ///     and namespace <see cref="ConsonaCRM.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class StepComponentLogTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="StepComponentLog" />)
        /// </summary>
        public StepComponentLogTest() : base(typeof(StepComponentLog))
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

        #region General Initializer : Class (StepComponentLog) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _stepComponentLogInstanceType;
        private StepComponentLog _stepComponentLogInstance;
        private StepComponentLog _stepComponentLogInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="StepComponentLog" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _stepComponentLogInstanceType = typeof(StepComponentLog);
            _stepComponentLogInstanceFixture = this.Create<StepComponentLog>(false);
            _stepComponentLogInstance = _stepComponentLogInstanceFixture ?? this.Create<StepComponentLog>(true);
            CurrentInstance = _stepComponentLogInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (StepComponentLog) Initializer

        #region Properties

        private const string PropertylogSettings = "logSettings";
        private const string PropertylogErrors = "logErrors";
        private const string PropertylogWarnings = "logWarnings";
        private const string PropertylogMessages = "logMessages";
        private const string PropertyuserID = "userID";
        private const string PropertyotmID = "otmID";
        private const string PropertyeventLog = "eventLog";

        #endregion

        #region Methods

        private const string MethodLogMessage = "LogMessage";
        private const string MethodLogWarning = "LogWarning";
        private const string MethodLogError = "LogError";
        private const string MethodWriteEventLogEntry = "WriteEventLogEntry";

        #endregion

        #region Fields

        private const string FieldONYX_EVENT_INSTANCE_ID_BASE = "ONYX_EVENT_INSTANCE_ID_BASE";
        private const string FieldONYX_EVENT_CATEGORY_ID = "ONYX_EVENT_CATEGORY_ID";
        private const string Fieldm_eventLog = "m_eventLog";
        private const string Fieldm_logErrors = "m_logErrors";
        private const string Fieldm_logWarnings = "m_logWarnings";
        private const string Fieldm_logMessages = "m_logMessages";
        private const string Fieldm_userID = "m_userID";
        private const string Fieldm_otmID = "m_otmID";
        private const string Fieldm_logSettings = "m_logSettings";

        #endregion

        #endregion

        #region General Initializer : Class (StepComponentLog) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentLog_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentLog) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentLog_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (StepComponentLog) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_StepComponentLog_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (StepComponentLog)

        #region General Initializer : Class (StepComponentLog) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogMessage, 0)]
        [TestCase(MethodLogWarning, 0)]
        [TestCase(MethodLogError, 0)]
        [TestCase(MethodWriteEventLogEntry, 0)]
        public void AUT_StepComponentLog_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (StepComponentLog) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertylogSettings)]
        [TestCase(PropertylogErrors)]
        [TestCase(PropertylogWarnings)]
        [TestCase(PropertylogMessages)]
        [TestCase(PropertyuserID)]
        [TestCase(PropertyotmID)]
        [TestCase(PropertyeventLog)]
        [Category("AUT Property")]
        public void AUT_StepComponentLog_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (StepComponentLog) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldONYX_EVENT_INSTANCE_ID_BASE)]
        [TestCase(FieldONYX_EVENT_CATEGORY_ID)]
        [TestCase(Fieldm_eventLog)]
        [TestCase(Fieldm_logErrors)]
        [TestCase(Fieldm_logWarnings)]
        [TestCase(Fieldm_logMessages)]
        [TestCase(Fieldm_userID)]
        [TestCase(Fieldm_otmID)]
        [TestCase(Fieldm_logSettings)]
        [Category("AUT Fields")]
        public void AUT_StepComponentLog_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (StepComponentLog) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentLog_Is_Instance_Present_Test()
        {
            // Assert
            _stepComponentLogInstanceType.ShouldNotBeNull();
            _stepComponentLogInstance.ShouldNotBeNull();
            _stepComponentLogInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (StepComponentLog) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="StepComponentLog" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_StepComponentLog_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _stepComponentLogInstance.ShouldBeAssignableTo<StepComponentLog>();
            _stepComponentLogInstanceFixture.ShouldBeAssignableTo<StepComponentLog>();
            CurrentInstance.ShouldBeAssignableTo<StepComponentLog>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (StepComponentLog) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentLog_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var psEventLogSource = this.CreateType<string>();
            StepComponentLog instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentLog(psEventLogSource);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentLogInstance.ShouldNotBeNull();
            _stepComponentLogInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<StepComponentLog>();
        }

        #endregion

        #region General Constructor : Class (StepComponentLog) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_StepComponentLog_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var psEventLogSource = this.CreateType<string>();
            StepComponentLog instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new StepComponentLog(psEventLogSource);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _stepComponentLogInstance.ShouldNotBeNull();
            _stepComponentLogInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (StepComponentLog) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertylogSettings)]
        [TestCase(PropertylogErrors)]
        [TestCase(PropertylogWarnings)]
        [TestCase(PropertylogMessages)]
        [TestCase(PropertyuserID)]
        [TestCase(PropertyotmID)]
        [TestCase(PropertyeventLog)]
        public void AUT_StepComponentLog_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (StepComponentLog) => Property (eventLog) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_eventLog_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyeventLog);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyeventLog);
            Action currentAction = () => propertyInfo.SetValue(_stepComponentLogInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (eventLog) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_eventLog_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyeventLog);
            var propertyInfo = this.GetPropertyInfo(PropertyeventLog);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (logErrors) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_logErrors_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogErrors);
            var propertyInfo = this.GetPropertyInfo(PropertylogErrors);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (logMessages) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_logMessages_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogMessages);
            var propertyInfo = this.GetPropertyInfo(PropertylogMessages);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (logSettings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_logSettings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogSettings);
            var propertyInfo = this.GetPropertyInfo(PropertylogSettings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (logWarnings) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_logWarnings_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertylogWarnings);
            var propertyInfo = this.GetPropertyInfo(PropertylogWarnings);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (otmID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_otmID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyotmID);
            var propertyInfo = this.GetPropertyInfo(PropertyotmID);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (StepComponentLog) => Property (userID) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_StepComponentLog_Public_Class_userID_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyuserID);
            var propertyInfo = this.GetPropertyInfo(PropertyuserID);

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

        #region Method Call : (LogMessage) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var psSource = this.CreateType<string>();
            var psDebugType = this.CreateType<string>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentLogInstance.LogMessage(psSource, psDebugType, psMessage, psAdditionalInfo);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogMessage) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var psSource = this.CreateType<string>();
            var psDebugType = this.CreateType<string>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfLogMessage = { psSource, psDebugType, psMessage, psAdditionalInfo };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogMessage, methodLogMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentLogInstanceFixture, parametersOfLogMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogMessage.ShouldNotBeNull();
            parametersOfLogMessage.Length.ShouldBe(4);
            methodLogMessageParametersTypes.Length.ShouldBe(4);
            methodLogMessageParametersTypes.Length.ShouldBe(parametersOfLogMessage.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogMessage) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var psSource = this.CreateType<string>();
            var psDebugType = this.CreateType<string>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfLogMessage = { psSource, psDebugType, psMessage, psAdditionalInfo };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogMessage, parametersOfLogMessage, methodLogMessageParametersTypes);

            // Assert
            parametersOfLogMessage.ShouldNotBeNull();
            parametersOfLogMessage.Length.ShouldBe(4);
            methodLogMessageParametersTypes.Length.ShouldBe(4);
            methodLogMessageParametersTypes.Length.ShouldBe(parametersOfLogMessage.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogMessage) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodLogMessage, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogMessage) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var methodLogMessageParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogMessage, methodLogMessageParametersTypes);

            // Assert
            methodLogMessageParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogMessage) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogMessage_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodLogMessage, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentLog_LogWarning_Method_Call_Internally(Type[] types)
        {
            var methodLogWarningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentLogInstance.LogWarning(psSource, piMessageID, psMessage, psAdditionalInfo);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfLogWarning = { psSource, piMessageID, psMessage, psAdditionalInfo };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, methodLogWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentLogInstanceFixture, parametersOfLogWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(4);
            methodLogWarningParametersTypes.Length.ShouldBe(4);
            methodLogWarningParametersTypes.Length.ShouldBe(parametersOfLogWarning.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfLogWarning = { psSource, piMessageID, psMessage, psAdditionalInfo };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogWarning, parametersOfLogWarning, methodLogWarningParametersTypes);

            // Assert
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(4);
            methodLogWarningParametersTypes.Length.ShouldBe(4);
            methodLogWarningParametersTypes.Length.ShouldBe(parametersOfLogWarning.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);

            // Assert
            methodLogWarningParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogWarning_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentLog_LogError_Method_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();

            // Act
            Action executeAction = () => _stepComponentLogInstance.LogError(psSource, piMessageID, psMessage, psAdditionalInfo);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfLogError = { psSource, piMessageID, psMessage, psAdditionalInfo };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentLogInstanceFixture, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(parametersOfLogError.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var psSource = this.CreateType<string>();
            var piMessageID = this.CreateType<long>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };
            object[] parametersOfLogError = { psSource, piMessageID, psMessage, psAdditionalInfo };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(parametersOfLogError.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(long), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_LogError_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_Internally(Type[] types)
        {
            var methodWriteEventLogEntryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteEventLogEntry, methodWriteEventLogEntryParametersTypes);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEventLogEntry);
            var pEventLogEntryType = this.CreateType<EventLogEntryType>();
            var psSource = this.CreateType<string>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodWriteEventLogEntryParametersTypes = new Type[] { typeof(EventLogEntryType), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfWriteEventLogEntry = { pEventLogEntryType, psSource, psMessage, psAdditionalInfo };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEventLogEntry, methodWriteEventLogEntryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_stepComponentLogInstanceFixture, parametersOfWriteEventLogEntry);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWriteEventLogEntry.ShouldNotBeNull();
            parametersOfWriteEventLogEntry.Length.ShouldBe(4);
            methodWriteEventLogEntryParametersTypes.Length.ShouldBe(4);
            methodWriteEventLogEntryParametersTypes.Length.ShouldBe(parametersOfWriteEventLogEntry.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEventLogEntry);
            var pEventLogEntryType = this.CreateType<EventLogEntryType>();
            var psSource = this.CreateType<string>();
            var psMessage = this.CreateType<string>();
            var psAdditionalInfo = this.CreateType<string>();
            var methodWriteEventLogEntryParametersTypes = new Type[] { typeof(EventLogEntryType), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfWriteEventLogEntry = { pEventLogEntryType, psSource, psMessage, psAdditionalInfo };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWriteEventLogEntry, parametersOfWriteEventLogEntry, methodWriteEventLogEntryParametersTypes);

            // Assert
            parametersOfWriteEventLogEntry.ShouldNotBeNull();
            parametersOfWriteEventLogEntry.Length.ShouldBe(4);
            methodWriteEventLogEntryParametersTypes.Length.ShouldBe(4);
            methodWriteEventLogEntryParametersTypes.Length.ShouldBe(parametersOfWriteEventLogEntry.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEventLogEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEventLogEntry, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEventLogEntry);
            var methodWriteEventLogEntryParametersTypes = new Type[] { typeof(EventLogEntryType), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteEventLogEntry, methodWriteEventLogEntryParametersTypes);

            // Assert
            methodWriteEventLogEntryParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteEventLogEntry) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_StepComponentLog_WriteEventLogEntry_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteEventLogEntry);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteEventLogEntry, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}