using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using KBengine;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.KBengine
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="KBengine.AppLogEvent" />)
    ///     and namespace <see cref="KBengine"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AppLogEventTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AppLogEvent" />)
        /// </summary>
        public AppLogEventTest() : base(typeof(AppLogEvent))
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

        #region General Initializer : Class (AppLogEvent) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _appLogEventInstanceType;
        private AppLogEvent _appLogEventInstance;
        private AppLogEvent _appLogEventInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AppLogEvent" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _appLogEventInstanceType = typeof(AppLogEvent);
            _appLogEventInstanceFixture = this.Create<AppLogEvent>(false);
            _appLogEventInstance = _appLogEventInstanceFixture ?? this.Create<AppLogEvent>(true);
            CurrentInstance = _appLogEventInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AppLogEvent) Initializer

        #region Methods

        private const string MethodLogError = "LogError";
        private const string MethodLogInformation = "LogInformation";

        #endregion

        #region Fields

        private const string Field_appLog = "_appLog";

        #endregion

        #endregion

        #region General Initializer : Class (AppLogEvent) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AppLogEvent_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AppLogEvent) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AppLogEvent_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AppLogEvent)

        #region General Initializer : Class (AppLogEvent) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogError, 0)]
        [TestCase(MethodLogInformation, 0)]
        public void AUT_AppLogEvent_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AppLogEvent) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_appLog)]
        [Category("AUT Fields")]
        public void AUT_AppLogEvent_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AppLogEvent) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AppLogEvent_Is_Instance_Present_Test()
        {
            // Assert
            _appLogEventInstanceType.ShouldNotBeNull();
            _appLogEventInstance.ShouldNotBeNull();
            _appLogEventInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (AppLogEvent) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AppLogEvent" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AppLogEvent_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _appLogEventInstance.ShouldBeAssignableTo<AppLogEvent>();
            _appLogEventInstanceFixture.ShouldBeAssignableTo<AppLogEvent>();
            CurrentInstance.ShouldBeAssignableTo<AppLogEvent>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (AppLogEvent) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AppLogEvent_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var eventLogname = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            AppLogEvent instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new AppLogEvent(eventLogname, applicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _appLogEventInstance.ShouldNotBeNull();
            _appLogEventInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<AppLogEvent>();
        }

        #endregion

        #region General Constructor : Class (AppLogEvent) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_AppLogEvent_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var eventLogname = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            AppLogEvent instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new AppLogEvent(eventLogname, applicationName);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _appLogEventInstance.ShouldNotBeNull();
            _appLogEventInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LogError) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogError_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => _appLogEventInstance.LogError(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogError_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLogError = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appLogEventInstanceFixture, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(1);
            methodLogErrorParametersTypes.Length.ShouldBe(1);
            methodLogErrorParametersTypes.Length.ShouldBe(parametersOfLogError.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogError_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLogError = { message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(1);
            methodLogErrorParametersTypes.Length.ShouldBe(1);
            methodLogErrorParametersTypes.Length.ShouldBe(parametersOfLogError.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogError_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 0);
            const int parametersCount = 1;

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
        public void AUT_AppLogEvent_LogError_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogError_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (LogInformation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AppLogEvent_LogInformation_Method_Call_Internally(Type[] types)
        {
            var methodLogInformationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => _appLogEventInstance.LogInformation(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLogInformation = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, methodLogInformationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_appLogEventInstanceFixture, parametersOfLogInformation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(1);
            methodLogInformationParametersTypes.Length.ShouldBe(1);
            methodLogInformationParametersTypes.Length.ShouldBe(parametersOfLogInformation.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfLogInformation = { message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogInformation, parametersOfLogInformation, methodLogInformationParametersTypes);

            // Assert
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(1);
            methodLogInformationParametersTypes.Length.ShouldBe(1);
            methodLogInformationParametersTypes.Length.ShouldBe(parametersOfLogInformation.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var methodLogInformationParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);

            // Assert
            methodLogInformationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AppLogEvent_LogInformation_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, 0);

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