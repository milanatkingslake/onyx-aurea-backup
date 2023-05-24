using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.LoggerService;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.LoggerService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.LoggerService.Logger" />)
    ///     and namespace <see cref="Onyx.LoggerService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LoggerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Logger" />)
        /// </summary>
        public LoggerTest() : base(typeof(Logger))
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

        #region General Initializer : Class (Logger) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _loggerInstanceType;
        private Logger _loggerInstance;
        private Logger _loggerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Logger" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _loggerInstanceType = typeof(Logger);
            _loggerInstanceFixture = this.Create<Logger>(false);
            _loggerInstance = _loggerInstanceFixture ?? this.Create<Logger>(true);
            CurrentInstance = _loggerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Logger) Initializer

        #region Methods

        private const string MethodloadConfiguration = "loadConfiguration";
        private const string MethodFatal = "Fatal";
        private const string MethodError = "Error";
        private const string MethodWarn = "Warn";
        private const string MethodInfo = "Info";
        private const string MethodDebug = "Debug";

        #endregion

        #region Fields

        private const string Field_logger = "_logger";
        private const string FieldisLoggerInitialized = "isLoggerInitialized";

        #endregion

        #endregion

        #region General Initializer : Class (Logger) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Logger" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Logger_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region General Initializer : Class (Logger) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Logger" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Logger_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Logger)

        #region General Initializer : Class (Logger) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Logger" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodloadConfiguration, 0)]
        [TestCase(MethodFatal, 0)]
        [TestCase(MethodError, 0)]
        [TestCase(MethodWarn, 0)]
        [TestCase(MethodInfo, 0)]
        [TestCase(MethodDebug, 0)]
        public void AUT_Logger_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Logger) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Logger" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_logger)]
        [TestCase(FieldisLoggerInitialized)]
        [Category("AUT Fields")]
        public void AUT_Logger_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Logger) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Logger" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Logger_Is_Instance_Present_Test()
        {
            // Assert
            _loggerInstanceType.ShouldNotBeNull();
            _loggerInstance.ShouldNotBeNull();
            _loggerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Logger) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Logger" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Logger_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _loggerInstance.ShouldBeAssignableTo<Logger>();
            _loggerInstanceFixture.ShouldBeAssignableTo<Logger>();
            CurrentInstance.ShouldBeAssignableTo<Logger>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Logger) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var logClass = this.CreateType<Type>();
            Logger instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Logger(logClass);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _loggerInstance.ShouldNotBeNull();
            _loggerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Logger>();
        }

        #endregion

        #region General Constructor : Class (Logger) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var logClass = this.CreateType<Type>();
            Logger instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Logger(logClass);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _loggerInstance.ShouldNotBeNull();
            _loggerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (Logger) instance created

        /// <summary>
        ///     Class (<see cref="Logger" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_Is_Created_Test()
        {
            // Assert
            _loggerInstance.ShouldNotBeNull();
            _loggerInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (Logger) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="Logger" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_Logger_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
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
        
        #region General Constructor : Class (Logger) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="Logger" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (Logger) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Logger" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodLoggerParametersTypes = new Type[] { typeof(Type) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodLoggerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (Logger) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="Logger" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Logger_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodLoggerParametersTypes = new Type[] { typeof(Type), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodLoggerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (loadConfiguration) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_loadConfiguration_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadConfiguration);
            var configFilePath = this.CreateType<string>();
            var methodloadConfigurationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfloadConfiguration = { configFilePath };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodloadConfiguration, methodloadConfigurationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfloadConfiguration);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfloadConfiguration.ShouldNotBeNull();
            parametersOfloadConfiguration.Length.ShouldBe(1);
            methodloadConfigurationParametersTypes.Length.ShouldBe(1);
            methodloadConfigurationParametersTypes.Length.ShouldBe(parametersOfloadConfiguration.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadConfiguration) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_loadConfiguration_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadConfiguration);
            var configFilePath = this.CreateType<string>();
            var methodloadConfigurationParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfloadConfiguration = { configFilePath };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodloadConfiguration, parametersOfloadConfiguration, methodloadConfigurationParametersTypes);

            // Assert
            parametersOfloadConfiguration.ShouldNotBeNull();
            parametersOfloadConfiguration.Length.ShouldBe(1);
            methodloadConfigurationParametersTypes.Length.ShouldBe(1);
            methodloadConfigurationParametersTypes.Length.ShouldBe(parametersOfloadConfiguration.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadConfiguration) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_loadConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodloadConfiguration, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (loadConfiguration) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_loadConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadConfiguration);
            var methodloadConfigurationParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodloadConfiguration, methodloadConfigurationParametersTypes);

            // Assert
            methodloadConfigurationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (loadConfiguration) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_loadConfiguration_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodloadConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodloadConfiguration, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Fatal) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_Fatal_Method_Call_Internally(Type[] types)
        {
            var methodFatalParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFatal, methodFatalParametersTypes);
        }

        #endregion
        
        #region Method Call : (Fatal) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var errorMessage = this.CreateType<string>();

            // Act
            Action executeAction = () => _loggerInstance.Fatal(errorMessage);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (Fatal) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var errorMessage = this.CreateType<string>();
            var methodFatalParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFatal = { errorMessage };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFatal, methodFatalParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfFatal);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFatal.ShouldNotBeNull();
            parametersOfFatal.Length.ShouldBe(1);
            methodFatalParametersTypes.Length.ShouldBe(1);
            methodFatalParametersTypes.Length.ShouldBe(parametersOfFatal.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Fatal) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var errorMessage = this.CreateType<string>();
            var methodFatalParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFatal = { errorMessage };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFatal, parametersOfFatal, methodFatalParametersTypes);

            // Assert
            parametersOfFatal.ShouldNotBeNull();
            parametersOfFatal.Length.ShouldBe(1);
            methodFatalParametersTypes.Length.ShouldBe(1);
            methodFatalParametersTypes.Length.ShouldBe(parametersOfFatal.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Fatal) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var currentMethodInfo = this.GetMethodInfo(MethodFatal, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Fatal) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var methodFatalParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFatal, methodFatalParametersTypes);

            // Assert
            methodFatalParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Fatal) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Fatal_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFatal);
            var currentMethodInfo = this.GetMethodInfo(MethodFatal, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_Error_Method_Call_Internally(Type[] types)
        {
            var methodErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodError, methodErrorParametersTypes);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var errorMessage = this.CreateType<string>();
            var ex = this.CreateType<Exception>();

            // Act
            Action executeAction = () => _loggerInstance.Error(errorMessage, ex);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (Error) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var errorMessage = this.CreateType<string>();
            var ex = this.CreateType<Exception>();
            var methodErrorParametersTypes = new Type[] { typeof(string), typeof(Exception) };
            object[] parametersOfError = { errorMessage, ex };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodError, methodErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfError.ShouldNotBeNull();
            parametersOfError.Length.ShouldBe(2);
            methodErrorParametersTypes.Length.ShouldBe(2);
            methodErrorParametersTypes.Length.ShouldBe(parametersOfError.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var errorMessage = this.CreateType<string>();
            var ex = this.CreateType<Exception>();
            var methodErrorParametersTypes = new Type[] { typeof(string), typeof(Exception) };
            object[] parametersOfError = { errorMessage, ex };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodError, parametersOfError, methodErrorParametersTypes);

            // Assert
            parametersOfError.ShouldNotBeNull();
            parametersOfError.Length.ShouldBe(2);
            methodErrorParametersTypes.Length.ShouldBe(2);
            methodErrorParametersTypes.Length.ShouldBe(parametersOfError.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var currentMethodInfo = this.GetMethodInfo(MethodError, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var methodErrorParametersTypes = new Type[] { typeof(string), typeof(Exception) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodError, methodErrorParametersTypes);

            // Assert
            methodErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Error) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Error_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodError);
            var currentMethodInfo = this.GetMethodInfo(MethodError, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_Warn_Method_Call_Internally(Type[] types)
        {
            var methodWarnParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWarn, methodWarnParametersTypes);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => _loggerInstance.Warn(message);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var message = this.CreateType<string>();
            var methodWarnParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfWarn = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodWarn, methodWarnParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfWarn);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfWarn.ShouldNotBeNull();
            parametersOfWarn.Length.ShouldBe(1);
            methodWarnParametersTypes.Length.ShouldBe(1);
            methodWarnParametersTypes.Length.ShouldBe(parametersOfWarn.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var message = this.CreateType<string>();
            var methodWarnParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfWarn = { message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodWarn, parametersOfWarn, methodWarnParametersTypes);

            // Assert
            parametersOfWarn.ShouldNotBeNull();
            parametersOfWarn.Length.ShouldBe(1);
            methodWarnParametersTypes.Length.ShouldBe(1);
            methodWarnParametersTypes.Length.ShouldBe(parametersOfWarn.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var currentMethodInfo = this.GetMethodInfo(MethodWarn, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var methodWarnParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWarn, methodWarnParametersTypes);

            // Assert
            methodWarnParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Warn) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Warn_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWarn);
            var currentMethodInfo = this.GetMethodInfo(MethodWarn, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_Info_Method_Call_Internally(Type[] types)
        {
            var methodInfoParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInfo, methodInfoParametersTypes);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => _loggerInstance.Info(message);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (Info) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var message = this.CreateType<string>();
            var methodInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfInfo = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInfo, methodInfoParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInfo.ShouldNotBeNull();
            parametersOfInfo.Length.ShouldBe(1);
            methodInfoParametersTypes.Length.ShouldBe(1);
            methodInfoParametersTypes.Length.ShouldBe(parametersOfInfo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var message = this.CreateType<string>();
            var methodInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfInfo = { message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInfo, parametersOfInfo, methodInfoParametersTypes);

            // Assert
            parametersOfInfo.ShouldNotBeNull();
            parametersOfInfo.Length.ShouldBe(1);
            methodInfoParametersTypes.Length.ShouldBe(1);
            methodInfoParametersTypes.Length.ShouldBe(parametersOfInfo.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodInfo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var methodInfoParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInfo, methodInfoParametersTypes);

            // Assert
            methodInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Info) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Info_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodInfo, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_Debug_Method_Call_Internally(Type[] types)
        {
            var methodDebugParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDebug, methodDebugParametersTypes);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var message = this.CreateType<string>();

            // Act
            Action executeAction = () => _loggerInstance.Debug(message);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var message = this.CreateType<string>();
            var methodDebugParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDebug = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDebug, methodDebugParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_loggerInstanceFixture, parametersOfDebug);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDebug.ShouldNotBeNull();
            parametersOfDebug.Length.ShouldBe(1);
            methodDebugParametersTypes.Length.ShouldBe(1);
            methodDebugParametersTypes.Length.ShouldBe(parametersOfDebug.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var message = this.CreateType<string>();
            var methodDebugParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDebug = { message };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDebug, parametersOfDebug, methodDebugParametersTypes);

            // Assert
            parametersOfDebug.ShouldNotBeNull();
            parametersOfDebug.Length.ShouldBe(1);
            methodDebugParametersTypes.Length.ShouldBe(1);
            methodDebugParametersTypes.Length.ShouldBe(parametersOfDebug.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var currentMethodInfo = this.GetMethodInfo(MethodDebug, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var methodDebugParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDebug, methodDebugParametersTypes);

            // Assert
            methodDebugParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Debug) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_Debug_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDebug);
            var currentMethodInfo = this.GetMethodInfo(MethodDebug, 0);

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