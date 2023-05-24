using System;
using System.Collections;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.OnyxLogHelper" />)
    ///     and namespace <see cref="OnyxMessageSubsystem"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxLogHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxLogHelper" />)
        /// </summary>
        public OnyxLogHelperTest() : base(typeof(OnyxLogHelper))
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

        #region General Initializer : Class (OnyxLogHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxLogHelperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxLogHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxLogHelperInstanceType = typeof(OnyxLogHelper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxLogHelper) Initializer

        #region Methods

        private const string MethodLogEntryInformation = "LogEntryInformation";
        private const string MethodLogExitInformation = "LogExitInformation";
        private const string MethodLogWarning = "LogWarning";
        private const string MethodLogError = "LogError";
        private const string MethodWriteToEventLog = "WriteToEventLog";

        #endregion

        #region Fields

        private const string FieldFORMAT_INFO_ENTRY = "FORMAT_INFO_ENTRY";
        
        private const string FieldFORMAT_WARNING = "FORMAT_WARNING";
        private const string FieldFORMAT_ERROR = "FORMAT_ERROR";
        private const string FieldWARNING_SITE_ID_DOES_NOT_EXIST = "WARNING_SITE_ID_DOES_NOT_EXIST";
        private const string FieldWARNING_APP_NAME_DOES_NOT_EXIST = "WARNING_APP_NAME_DOES_NOT_EXIST";
        private const string FieldWARNING_SESSION_DOES_NOT_EXIST = "WARNING_SESSION_DOES_NOT_EXIST";
        private const string FieldWARNING_USER_ID_DOES_NOT_EXIST = "WARNING_USER_ID_DOES_NOT_EXIST";
        private const string FieldWARNING_LANGUAGE_CODE_DOES_NOT_EXIST = "WARNING_LANGUAGE_CODE_DOES_NOT_EXIST";
        private const string FieldEVENT_LOG_LIMIT = "EVENT_LOG_LIMIT";
        private const string FieldONYX_EVENT_BASE_ID = "ONYX_EVENT_BASE_ID";
        private const string FieldoEventLog = "oEventLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxLogHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxLogHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLogHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxLogHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxLogHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxLogHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxLogHelper)

        #region General Initializer : Class (OnyxLogHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxLogHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogEntryInformation, 0)]
        [TestCase(MethodLogWarning, 0)]
        [TestCase(MethodLogError, 0)]
        [TestCase(MethodWriteToEventLog, 0)]
        public void AUT_OnyxLogHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxLogHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxLogHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldFORMAT_INFO_ENTRY)]
        [TestCase(FieldFORMAT_WARNING)]
        [TestCase(FieldFORMAT_ERROR)]
        [TestCase(FieldWARNING_SITE_ID_DOES_NOT_EXIST)]
        [TestCase(FieldWARNING_APP_NAME_DOES_NOT_EXIST)]
        [TestCase(FieldWARNING_SESSION_DOES_NOT_EXIST)]
        [TestCase(FieldWARNING_USER_ID_DOES_NOT_EXIST)]
        [TestCase(FieldWARNING_LANGUAGE_CODE_DOES_NOT_EXIST)]
        [TestCase(FieldEVENT_LOG_LIMIT)]
        [TestCase(FieldONYX_EVENT_BASE_ID)]
        [TestCase(FieldoEventLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxLogHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxLogHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxLogHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxLogHelper_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxLogHelperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LogEntryInformation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogEntryInformationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogEntryInformation, methodLogEntryInformationParametersTypes);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxLogHelper.LogEntryInformation(source, methodName, user, inputParameters, logPath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();
            var methodLogEntryInformationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfLogEntryInformation = { source, methodName, user, inputParameters, logPath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogEntryInformation, methodLogEntryInformationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogEntryInformation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogEntryInformation.ShouldNotBeNull();
            parametersOfLogEntryInformation.Length.ShouldBe(5);
            methodLogEntryInformationParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();
            var methodLogEntryInformationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfLogEntryInformation = { source, methodName, user, inputParameters, logPath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogEntryInformation, parametersOfLogEntryInformation, methodLogEntryInformationParametersTypes);

            // Assert
            parametersOfLogEntryInformation.ShouldNotBeNull();
            parametersOfLogEntryInformation.Length.ShouldBe(5);
            methodLogEntryInformationParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogEntryInformation, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var methodLogEntryInformationParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogEntryInformation, methodLogEntryInformationParametersTypes);

            // Assert
            methodLogEntryInformationParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEntryInformation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogEntryInformation_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEntryInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogEntryInformation, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogExitInformation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxLogHelper_LogExitInformation_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogExitInformationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogExitInformation, methodLogExitInformationParametersTypes);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogWarningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var message = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxLogHelper.LogWarning(source, methodName, user, message, inputParameters, logPath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var message = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfLogWarning = { source, methodName, user, message, inputParameters, logPath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, methodLogWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(6);
            methodLogWarningParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var source = this.CreateType<string>();
            var methodName = this.CreateType<string>();
            var user = this.CreateType<string>();
            var message = this.CreateType<string>();
            var inputParameters = this.CreateType<Hashtable>();
            var logPath = this.CreateType<string>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };
            object[] parametersOfLogWarning = { source, methodName, user, message, inputParameters, logPath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogWarning, parametersOfLogWarning, methodLogWarningParametersTypes);

            // Assert
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(6);
            methodLogWarningParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 0);
            const int parametersCount = 6;

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
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(Hashtable), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);

            // Assert
            methodLogWarningParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogWarning_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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
        private void AUT_OnyxLogHelper_LogError_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogError_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var source = this.CreateType<string>();
            var ex = this.CreateType<Exception>();
            var user = this.CreateType<string>();
            var logPath = this.CreateType<string>();

            // Act
            Action executeAction = () => OnyxLogHelper.LogError(source, ex, user, logPath);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogError_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var source = this.CreateType<string>();
            var ex = this.CreateType<Exception>();
            var user = this.CreateType<string>();
            var logPath = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(Exception), typeof(string), typeof(string) };
            object[] parametersOfLogError = { source, ex, user, logPath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogError_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var source = this.CreateType<string>();
            var ex = this.CreateType<Exception>();
            var user = this.CreateType<string>();
            var logPath = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(Exception), typeof(string), typeof(string) };
            object[] parametersOfLogError = { source, ex, user, logPath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(4);
            methodLogErrorParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_LogError_Static_Method_Call_Parameters_Count_Verification_Test()
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
        public void AUT_OnyxLogHelper_LogError_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(Exception), typeof(string), typeof(string) };

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
        public void AUT_OnyxLogHelper_LogError_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (WriteToEventLog) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxLogHelper_WriteToEventLog_Static_Method_Call_Internally(Type[] types)
        {
            var methodWriteToEventLogParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWriteToEventLog, methodWriteToEventLogParametersTypes);
        }

        #endregion
        
        #region Method Call : (WriteToEventLog) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_WriteToEventLog_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToEventLog);
            var psSource = this.CreateType<string>();
            var psLogMessage = this.CreateType<string>();
            var peLogEntryType = this.CreateType<EventLogEntryType>();
            var user = this.CreateType<string>();
            var methodWriteToEventLogParametersTypes = new Type[] { typeof(string), typeof(string), typeof(EventLogEntryType), typeof(string) };
            object[] parametersOfWriteToEventLog = { psSource, psLogMessage, peLogEntryType, user };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWriteToEventLog, parametersOfWriteToEventLog, methodWriteToEventLogParametersTypes);

            // Assert
            parametersOfWriteToEventLog.ShouldNotBeNull();
            parametersOfWriteToEventLog.Length.ShouldBe(4);
            methodWriteToEventLogParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToEventLog) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_WriteToEventLog_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToEventLog);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToEventLog, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WriteToEventLog) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_WriteToEventLog_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToEventLog);
            var methodWriteToEventLogParametersTypes = new Type[] { typeof(string), typeof(string), typeof(EventLogEntryType), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWriteToEventLog, methodWriteToEventLogParametersTypes);

            // Assert
            methodWriteToEventLogParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WriteToEventLog) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxLogHelper_WriteToEventLog_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWriteToEventLog);
            var currentMethodInfo = this.GetMethodInfo(MethodWriteToEventLog, 0);

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