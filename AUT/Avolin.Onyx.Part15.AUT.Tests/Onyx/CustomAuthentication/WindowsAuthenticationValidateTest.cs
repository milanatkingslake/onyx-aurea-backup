using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CustomAuthentication;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.CustomAuthentication
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CustomAuthentication.WindowsAuthenticationValidate" />)
    ///     and namespace <see cref="Onyx.CustomAuthentication"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class WindowsAuthenticationValidateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="WindowsAuthenticationValidate" />)
        /// </summary>
        public WindowsAuthenticationValidateTest() : base(typeof(WindowsAuthenticationValidate))
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

        #region General Initializer : Class (WindowsAuthenticationValidate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _windowsAuthenticationValidateInstanceType;
        private WindowsAuthenticationValidate _windowsAuthenticationValidateInstance;
        private WindowsAuthenticationValidate _windowsAuthenticationValidateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="WindowsAuthenticationValidate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _windowsAuthenticationValidateInstanceType = typeof(WindowsAuthenticationValidate);
            _windowsAuthenticationValidateInstanceFixture = this.Create<WindowsAuthenticationValidate>(false);
            _windowsAuthenticationValidateInstance = _windowsAuthenticationValidateInstanceFixture ?? this.Create<WindowsAuthenticationValidate>(true);
            CurrentInstance = _windowsAuthenticationValidateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (WindowsAuthenticationValidate) Initializer

        #region Methods

        private const string MethodLogonUser = "LogonUser";
        private const string MethodCloseHandle = "CloseHandle";
        private const string MethodValidate = "Validate";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        private const string Field_domain = "_domain";
        private const string Field_username = "_username";
        private const string Field_password = "_password";
        private const string FieldtokenHandle = "tokenHandle";
        private const string FieldWA_Logon_Type = "WA_Logon_Type";
        private const string FieldWA_Logon_Provider = "WA_Logon_Provider";

        #endregion

        #endregion

        #region General Initializer : Class (WindowsAuthenticationValidate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WindowsAuthenticationValidate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (WindowsAuthenticationValidate) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_WindowsAuthenticationValidate_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (WindowsAuthenticationValidate)

        #region General Initializer : Class (WindowsAuthenticationValidate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogonUser, 0)]
        [TestCase(MethodValidate, 0)]
        public void AUT_WindowsAuthenticationValidate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (WindowsAuthenticationValidate) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_domain)]
        [TestCase(Field_username)]
        [TestCase(Field_password)]
        [TestCase(FieldtokenHandle)]
        [TestCase(FieldWA_Logon_Type)]
        [TestCase(FieldWA_Logon_Provider)]
        [Category("AUT Fields")]
        public void AUT_WindowsAuthenticationValidate_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (WindowsAuthenticationValidate) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WindowsAuthenticationValidate_Is_Instance_Present_Test()
        {
            // Assert
            _windowsAuthenticationValidateInstanceType.ShouldNotBeNull();
            _windowsAuthenticationValidateInstance.ShouldNotBeNull();
            _windowsAuthenticationValidateInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (WindowsAuthenticationValidate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="WindowsAuthenticationValidate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_WindowsAuthenticationValidate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _windowsAuthenticationValidateInstance.ShouldBeAssignableTo<WindowsAuthenticationValidate>();
            _windowsAuthenticationValidateInstanceFixture.ShouldBeAssignableTo<WindowsAuthenticationValidate>();
            CurrentInstance.ShouldBeAssignableTo<WindowsAuthenticationValidate>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (WindowsAuthenticationValidate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_WindowsAuthenticationValidate_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var Domain = this.CreateType<string>();
            var Username = this.CreateType<string>();
            var Password = this.CreateType<string>();
            WindowsAuthenticationValidate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new WindowsAuthenticationValidate(Domain, Username, Password);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _windowsAuthenticationValidateInstance.ShouldNotBeNull();
            _windowsAuthenticationValidateInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<WindowsAuthenticationValidate>();
        }

        #endregion

        #region General Constructor : Class (WindowsAuthenticationValidate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_WindowsAuthenticationValidate_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var Domain = this.CreateType<string>();
            var Username = this.CreateType<string>();
            var Password = this.CreateType<string>();
            WindowsAuthenticationValidate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new WindowsAuthenticationValidate(Domain, Username, Password);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _windowsAuthenticationValidateInstance.ShouldNotBeNull();
            _windowsAuthenticationValidateInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (LogonUser) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var User = this.CreateType<string>();
            var Domain = this.CreateType<string>();
            var Password = this.CreateType<string>();
            var LogonType = this.CreateType<int>();
            var LogonProvider = this.CreateType<int>();
            var Token = this.CreateType<IntPtr>();

            // Act
            Action executeAction = () => WindowsAuthenticationValidate.LogonUser(User, Domain, Password, LogonType, LogonProvider, ref Token);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var User = this.CreateType<string>();
            var Domain = this.CreateType<string>();
            var Password = this.CreateType<string>();
            var LogonType = this.CreateType<int>();
            var LogonProvider = this.CreateType<int>();
            var Token = this.CreateType<IntPtr>();
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(IntPtr) };
            object[] parametersOfLogonUser = { User, Domain, Password, LogonType, LogonProvider, Token };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, methodLogonUserParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_windowsAuthenticationValidateInstanceFixture, parametersOfLogonUser);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfLogonUser.ShouldNotBeNull();
            parametersOfLogonUser.Length.ShouldBe(6);
            methodLogonUserParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var User = this.CreateType<string>();
            var Domain = this.CreateType<string>();
            var Password = this.CreateType<string>();
            var LogonType = this.CreateType<int>();
            var LogonProvider = this.CreateType<int>();
            var Token = this.CreateType<IntPtr>();
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(IntPtr) };
            object[] parametersOfLogonUser = { User, Domain, Password, LogonType, LogonProvider, Token };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodLogonUser, parametersOfLogonUser, methodLogonUserParametersTypes);

            // Assert
            parametersOfLogonUser.ShouldNotBeNull();
            parametersOfLogonUser.Length.ShouldBe(6);
            methodLogonUserParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var methodLogonUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(int), typeof(int), typeof(IntPtr) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogonUser, methodLogonUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLogonUserParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogonUser) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_LogonUser_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogonUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLogonUser, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CloseHandle) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WindowsAuthenticationValidate_CloseHandle_Static_Method_Call_Internally(Type[] types)
        {
            var methodCloseHandleParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCloseHandle, methodCloseHandleParametersTypes);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WindowsAuthenticationValidate_Validate_Method_Call_Internally(Type[] types)
        {
            var methodValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);

            // Act
            Action executeAction = () => _windowsAuthenticationValidateInstance.Validate();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;
            object[] parametersOfValidate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Boolean>(_windowsAuthenticationValidateInstanceFixture, parametersOfValidate);
            var result2 = this.GetResultOfMethod<Boolean>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidate.ShouldBeNull();
            methodValidateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;
            object[] parametersOfValidate = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Boolean>(_windowsAuthenticationValidateInstanceFixture, out exception1, parametersOfValidate);
            var result2 = this.GetResultOfMethod<Boolean>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidate.ShouldBeNull();
            methodValidateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;
            object[] parametersOfValidate = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_windowsAuthenticationValidateInstanceFixture, parametersOfValidate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidate.ShouldBeNull();
            methodValidateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;
            object[] parametersOfValidate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Boolean>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            parametersOfValidate.ShouldBeNull();
            methodValidateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            Type [] methodValidateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Boolean) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_WindowsAuthenticationValidate_Validate_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WindowsAuthenticationValidate_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_WindowsAuthenticationValidate_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}