using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Ucf;
using Shouldly;

namespace Avolin.Onyx.Part06.AUT.Tests.Ucf
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Ucf.Logger" />)
    ///     and namespace <see cref="Onyx.Ucf"/> class using generator(v:0.2.5)'s
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

        /// <summary>
        ///    Setting up everything for <see cref="Logger" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _loggerInstanceType = typeof(Logger);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Logger) Initializer

        #region Methods

        private const string MethodPrefixMessage = "PrefixMessage";
        private const string MethodLogError = "LogError";
        private const string MethodLogWarning = "LogWarning";
        private const string MethodLogInformation = "LogInformation";
        private const string MethodLogDetail = "LogDetail";
        private const string MethodLogEvent = "LogEvent";

        #endregion

        #region Fields

        private const string FieldDebugMode = "DebugMode";
        private const string Field_fallBackEventSource = "_fallBackEventSource";

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
        [TestCase(MethodPrefixMessage, 0)]
        [TestCase(MethodLogError, 0)]
        [TestCase(MethodLogError, 1)]
        [TestCase(MethodLogError, 2)]
        [TestCase(MethodLogError, 3)]
        [TestCase(MethodLogWarning, 0)]
        [TestCase(MethodLogWarning, 1)]
        [TestCase(MethodLogInformation, 0)]
        [TestCase(MethodLogInformation, 1)]
        [TestCase(MethodLogDetail, 0)]
        [TestCase(MethodLogDetail, 1)]
        [TestCase(MethodLogEvent, 0)]
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
        [TestCase(FieldDebugMode)]
        [TestCase(Field_fallBackEventSource)]
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
        public void AUT_Logger_Is_Static_Type_Present_Test()
        {
            // Assert
            _loggerInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (PrefixMessage) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var message = this.CreateType<string>();
            var methodPrefixMessageParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPrefixMessage = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPrefixMessage, methodPrefixMessageParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodPrefixMessage, methodPrefixMessageParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodPrefixMessage, parametersOfPrefixMessage, methodPrefixMessageParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfPrefixMessage.ShouldNotBeNull();
            parametersOfPrefixMessage.Length.ShouldBe(1);
            methodPrefixMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodPrefixMessage, parametersOfPrefixMessage, methodPrefixMessageParametersTypes));
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var message = this.CreateType<string>();
            var methodPrefixMessageParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPrefixMessage = { message };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPrefixMessage, methodPrefixMessageParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfPrefixMessage);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPrefixMessage.ShouldNotBeNull();
            parametersOfPrefixMessage.Length.ShouldBe(1);
            methodPrefixMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var message = this.CreateType<string>();
            var methodPrefixMessageParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPrefixMessage = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPrefixMessage, parametersOfPrefixMessage, methodPrefixMessageParametersTypes);

            // Assert
            parametersOfPrefixMessage.ShouldNotBeNull();
            parametersOfPrefixMessage.Length.ShouldBe(1);
            methodPrefixMessageParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var methodPrefixMessageParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPrefixMessage, methodPrefixMessageParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodPrefixMessageParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var methodPrefixMessageParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrefixMessage, methodPrefixMessageParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPrefixMessageParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodPrefixMessage, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (PrefixMessage) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_PrefixMessage_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrefixMessage);
            var currentMethodInfo = this.GetMethodInfo(MethodPrefixMessage, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogError_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();

            // Act
            Action executeAction = () => Logger.LogError(message, source, args);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogError = { message, source, args };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(3);
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogError = { message, source, args };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(3);
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 0);
            const int parametersCount = 3;

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
        public void AUT_Logger_LogError_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (LogError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogError_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();

            // Act
            Action executeAction = () => Logger.LogError(message, source);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogError = { message, source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(2);
            methodLogErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogError = { message, source };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(2);
            methodLogErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 1);
            const int parametersCount = 2;

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
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogError_Static_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_DirectCall_Overloading_Of_2_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();
            var args = this.CreateType<object[]>();

            // Act
            Action executeAction = () => Logger.LogError(message, source, innerException, args);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_2_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();
            var args = this.CreateType<object[]>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception), typeof(object[]) };
            object[] parametersOfLogError = { message, source, innerException, args };
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
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_2_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();
            var args = this.CreateType<object[]>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception), typeof(object[]) };
            object[] parametersOfLogError = { message, source, innerException, args };

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
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 2);
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
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception), typeof(object[]) };

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
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_2_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 2);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogError_Static_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodLogErrorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_DirectCall_Overloading_Of_3_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();

            // Act
            Action executeAction = () => Logger.LogError(message, source, innerException);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_3_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception) };
            object[] parametersOfLogError = { message, source, innerException };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, methodLogErrorParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogError);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(3);
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Void_Overloading_Of_3_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var innerException = this.CreateType<Exception>();
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception) };
            object[] parametersOfLogError = { message, source, innerException };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogError, parametersOfLogError, methodLogErrorParametersTypes);

            // Assert
            parametersOfLogError.ShouldNotBeNull();
            parametersOfLogError.Length.ShouldBe(3);
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 3);
            const int parametersCount = 3;

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
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var methodLogErrorParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(Exception) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogError, methodLogErrorParametersTypes);

            // Assert
            methodLogErrorParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogError) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogError_Static_Method_Call_Overloading_Of_3_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogError);
            var currentMethodInfo = this.GetMethodInfo(MethodLogError, 3);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogWarning_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogWarningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();

            // Act
            Action executeAction = () => Logger.LogWarning(message, source, args);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogWarning = { message, source, args };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, methodLogWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(3);
            methodLogWarningParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogWarning = { message, source, args };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogWarning, parametersOfLogWarning, methodLogWarningParametersTypes);

            // Assert
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(3);
            methodLogWarningParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 0);
            const int parametersCount = 3;

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
        public void AUT_Logger_LogWarning_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);

            // Assert
            methodLogWarningParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (LogWarning) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogWarning_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodLogWarningParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();

            // Act
            Action executeAction = () => Logger.LogWarning(message, source);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogWarning = { message, source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, methodLogWarningParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogWarning);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(2);
            methodLogWarningParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogWarning = { message, source };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogWarning, parametersOfLogWarning, methodLogWarningParametersTypes);

            // Assert
            parametersOfLogWarning.ShouldNotBeNull();
            parametersOfLogWarning.Length.ShouldBe(2);
            methodLogWarningParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 1);
            const int parametersCount = 2;

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
        public void AUT_Logger_LogWarning_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var methodLogWarningParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogWarning, methodLogWarningParametersTypes);

            // Assert
            methodLogWarningParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogWarning) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogWarning_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogWarning);
            var currentMethodInfo = this.GetMethodInfo(MethodLogWarning, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogInformation_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogInformationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();

            // Act
            Action executeAction = () => Logger.LogInformation(message, source, args);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogInformation = { message, source, args };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, methodLogInformationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogInformation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(3);
            methodLogInformationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogInformation = { message, source, args };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogInformation, parametersOfLogInformation, methodLogInformationParametersTypes);

            // Assert
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(3);
            methodLogInformationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, 0);
            const int parametersCount = 3;

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
        public void AUT_Logger_LogInformation_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);

            // Assert
            methodLogInformationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
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

        #region Method Call : (LogInformation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogInformation_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodLogInformationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();

            // Act
            Action executeAction = () => Logger.LogInformation(message, source);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogInformation = { message, source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, methodLogInformationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogInformation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(2);
            methodLogInformationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogInformation = { message, source };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogInformation, parametersOfLogInformation, methodLogInformationParametersTypes);

            // Assert
            parametersOfLogInformation.ShouldNotBeNull();
            parametersOfLogInformation.Length.ShouldBe(2);
            methodLogInformationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, 1);
            const int parametersCount = 2;

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
        public void AUT_Logger_LogInformation_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var methodLogInformationParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogInformation, methodLogInformationParametersTypes);

            // Assert
            methodLogInformationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogInformation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogInformation_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogInformation);
            var currentMethodInfo = this.GetMethodInfo(MethodLogInformation, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogDetail_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogDetailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogDetail, methodLogDetailParametersTypes);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();

            // Act
            Action executeAction = () => Logger.LogDetail(message, source, args);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogDetail = { message, source, args };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, methodLogDetailParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogDetail);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogDetail.ShouldNotBeNull();
            parametersOfLogDetail.Length.ShouldBe(3);
            methodLogDetailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var args = this.CreateType<object[]>();
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };
            object[] parametersOfLogDetail = { message, source, args };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogDetail, parametersOfLogDetail, methodLogDetailParametersTypes);

            // Assert
            parametersOfLogDetail.ShouldNotBeNull();
            parametersOfLogDetail.Length.ShouldBe(3);
            methodLogDetailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(object[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogDetail, methodLogDetailParametersTypes);

            // Assert
            methodLogDetailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogDetail_Static_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodLogDetailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogDetail, methodLogDetailParametersTypes);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_DirectCall_Overloading_Of_1_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();

            // Act
            Action executeAction = () => Logger.LogDetail(message, source);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogDetail = { message, source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, methodLogDetailParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogDetail);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogDetail.ShouldNotBeNull();
            parametersOfLogDetail.Length.ShouldBe(2);
            methodLogDetailParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };
            object[] parametersOfLogDetail = { message, source };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogDetail, parametersOfLogDetail, methodLogDetailParametersTypes);

            // Assert
            parametersOfLogDetail.ShouldNotBeNull();
            parametersOfLogDetail.Length.ShouldBe(2);
            methodLogDetailParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var methodLogDetailParametersTypes = new Type[] { typeof(string), typeof(LoggerSource) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogDetail, methodLogDetailParametersTypes);

            // Assert
            methodLogDetailParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogDetail) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogDetail_Static_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodLogDetail, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Logger_LogEvent_Static_Method_Call_Internally(Type[] types)
        {
            var methodLogEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogEvent, methodLogEventParametersTypes);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogEvent_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEvent);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var category = this.CreateType<short>();
            var entryType = this.CreateType<EventLogEntryType>();
            var methodLogEventParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(short), typeof(EventLogEntryType) };
            object[] parametersOfLogEvent = { message, source, category, entryType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogEvent, methodLogEventParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfLogEvent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogEvent.ShouldNotBeNull();
            parametersOfLogEvent.Length.ShouldBe(4);
            methodLogEventParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogEvent_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEvent);
            var message = this.CreateType<string>();
            var source = this.CreateType<LoggerSource>();
            var category = this.CreateType<short>();
            var entryType = this.CreateType<EventLogEntryType>();
            var methodLogEventParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(short), typeof(EventLogEntryType) };
            object[] parametersOfLogEvent = { message, source, category, entryType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodLogEvent, parametersOfLogEvent, methodLogEventParametersTypes);

            // Assert
            parametersOfLogEvent.ShouldNotBeNull();
            parametersOfLogEvent.Length.ShouldBe(4);
            methodLogEventParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogEvent_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodLogEvent, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogEvent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEvent);
            var methodLogEventParametersTypes = new Type[] { typeof(string), typeof(LoggerSource), typeof(short), typeof(EventLogEntryType) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogEvent, methodLogEventParametersTypes);

            // Assert
            methodLogEventParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogEvent) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Logger_LogEvent_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodLogEvent, 0);

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