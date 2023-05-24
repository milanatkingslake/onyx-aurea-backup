using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Authenticate" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AuthenticateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Authenticate" />)
        /// </summary>
        public AuthenticateTest() : base(typeof(Authenticate))
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

        #region General Initializer : Class (Authenticate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _authenticateInstanceType;
        private Authenticate _authenticateInstance;
        private Authenticate _authenticateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Authenticate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _authenticateInstanceType = typeof(Authenticate);
            _authenticateInstanceFixture = this.Create<Authenticate>(false);
            _authenticateInstance = _authenticateInstanceFixture ?? this.Create<Authenticate>(true);
            CurrentInstance = _authenticateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Authenticate) Initializer

        #region Methods

        private const string MethodAuthenticateUser = "AuthenticateUser";
        private const string MethodGetLoginUiResourceName = "GetLoginUiResourceName";
        private const string MethodGetOnyxAuthenticateSession = "GetOnyxAuthenticateSession";
        private const string MethodGetWindowsAuthenticateSession = "GetWindowsAuthenticateSession";
        private const string MethodGetSession = "GetSession";
        private const string MethodChangePassword = "ChangePassword";
        private const string MethodLogoutUser = "LogoutUser";
        private const string MethodGetUserProfile = "GetUserProfile";
        private const string MethodGetDefaultUserProfile = "GetDefaultUserProfile";
        private const string MethodRemoveDuplicate = "RemoveDuplicate";
        private const string MethodGetUserPreferenceByName = "GetUserPreferenceByName";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string FieldonyxMobileRequestTimeOut = "onyxMobileRequestTimeOut";
        private const string FieldandroidScanKey = "androidScanKey";
        private const string FieldiOSScanKey = "iOSScanKey";
        private const string FieldsessionLock = "sessionLock";

        #endregion

        #endregion

        #region General Initializer : Class (Authenticate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Authenticate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Authenticate) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Authenticate_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Authenticate)

        #region General Initializer : Class (Authenticate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAuthenticateUser, 0)]
        [TestCase(MethodGetLoginUiResourceName, 0)]
        [TestCase(MethodGetOnyxAuthenticateSession, 0)]
        [TestCase(MethodGetWindowsAuthenticateSession, 0)]
        [TestCase(MethodGetSession, 0)]
        [TestCase(MethodChangePassword, 0)]
        [TestCase(MethodLogoutUser, 0)]
        [TestCase(MethodGetUserProfile, 0)]
        [TestCase(MethodGetDefaultUserProfile, 0)]
        [TestCase(MethodRemoveDuplicate, 0)]
        [TestCase(MethodGetUserPreferenceByName, 0)]
        public void AUT_Authenticate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Authenticate) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Authenticate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(FieldonyxMobileRequestTimeOut)]
        [TestCase(FieldandroidScanKey)]
        [TestCase(FieldiOSScanKey)]
        [TestCase(FieldsessionLock)]
        [Category("AUT Fields")]
        public void AUT_Authenticate_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Authenticate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Authenticate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Authenticate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _authenticateInstance.ShouldBeAssignableTo<Authenticate>();
            _authenticateInstanceFixture.ShouldBeAssignableTo<Authenticate>();
            CurrentInstance.ShouldBeAssignableTo<Authenticate>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AuthenticateUser) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);

            // Act
            Action executeAction = () => _authenticateInstance.AuthenticateUser();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.AuthenticateUser();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            Type [] methodAuthenticateUserParametersTypes = null;
            object[] parametersOfAuthenticateUser = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAuthenticateUser, methodAuthenticateUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfAuthenticateUser);
            var result2 = this.GetResultOfMethod<string>(MethodAuthenticateUser, parametersOfAuthenticateUser, methodAuthenticateUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAuthenticateUser.ShouldBeNull();
            methodAuthenticateUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            Type [] methodAuthenticateUserParametersTypes = null;
            object[] parametersOfAuthenticateUser = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodAuthenticateUser, parametersOfAuthenticateUser, methodAuthenticateUserParametersTypes);

            // Assert
            parametersOfAuthenticateUser.ShouldBeNull();
            methodAuthenticateUserParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            Type [] methodAuthenticateUserParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAuthenticateUser, methodAuthenticateUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAuthenticateUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            Type [] methodAuthenticateUserParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAuthenticateUser, methodAuthenticateUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAuthenticateUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateUser) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_AuthenticateUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateUser);
            var currentMethodInfo = this.GetMethodInfo(MethodAuthenticateUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetLoginUiResourceNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var appType = this.CreateType<string>();
            var methodGetLoginUiResourceNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLoginUiResourceName = { appType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetLoginUiResourceName, parametersOfGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_authenticateInstanceFixture, parametersOfGetLoginUiResourceName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLoginUiResourceName.ShouldNotBeNull();
            parametersOfGetLoginUiResourceName.Length.ShouldBe(1);
            methodGetLoginUiResourceNameParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var appType = this.CreateType<string>();
            var methodGetLoginUiResourceNameParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetLoginUiResourceName = { appType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLoginUiResourceName, parametersOfGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);

            // Assert
            parametersOfGetLoginUiResourceName.ShouldNotBeNull();
            parametersOfGetLoginUiResourceName.Length.ShouldBe(1);
            methodGetLoginUiResourceNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var methodGetLoginUiResourceNameParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLoginUiResourceNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var methodGetLoginUiResourceNameParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLoginUiResourceName, methodGetLoginUiResourceNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLoginUiResourceNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoginUiResourceName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLoginUiResourceName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetLoginUiResourceName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLoginUiResourceName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLoginUiResourceName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_Internally(Type[] types)
        {
            var methodGetOnyxAuthenticateSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var userName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodGetOnyxAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetOnyxAuthenticateSession = { userName, appName, password, siteId, source };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetOnyxAuthenticateSession);
            var result2 = this.GetResultOfMethod<string>(MethodGetOnyxAuthenticateSession, parametersOfGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOnyxAuthenticateSession.ShouldNotBeNull();
            parametersOfGetOnyxAuthenticateSession.Length.ShouldBe(5);
            methodGetOnyxAuthenticateSessionParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var userName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodGetOnyxAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetOnyxAuthenticateSession = { userName, appName, password, siteId, source };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetOnyxAuthenticateSession, parametersOfGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes);

            // Assert
            parametersOfGetOnyxAuthenticateSession.ShouldNotBeNull();
            parametersOfGetOnyxAuthenticateSession.Length.ShouldBe(5);
            methodGetOnyxAuthenticateSessionParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var methodGetOnyxAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOnyxAuthenticateSessionParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var methodGetOnyxAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOnyxAuthenticateSession, methodGetOnyxAuthenticateSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOnyxAuthenticateSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAuthenticateSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOnyxAuthenticateSession) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetOnyxAuthenticateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOnyxAuthenticateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOnyxAuthenticateSession, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_Internally(Type[] types)
        {
            var methodGetWindowsAuthenticateSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var userName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodGetWindowsAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetWindowsAuthenticateSession = { userName, appName, password, siteId, source };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetWindowsAuthenticateSession);
            var result2 = this.GetResultOfMethod<string>(MethodGetWindowsAuthenticateSession, parametersOfGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWindowsAuthenticateSession.ShouldNotBeNull();
            parametersOfGetWindowsAuthenticateSession.Length.ShouldBe(5);
            methodGetWindowsAuthenticateSessionParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var userName = this.CreateType<string>();
            var appName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodGetWindowsAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetWindowsAuthenticateSession = { userName, appName, password, siteId, source };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWindowsAuthenticateSession, parametersOfGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes);

            // Assert
            parametersOfGetWindowsAuthenticateSession.ShouldNotBeNull();
            parametersOfGetWindowsAuthenticateSession.Length.ShouldBe(5);
            methodGetWindowsAuthenticateSessionParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var methodGetWindowsAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWindowsAuthenticateSessionParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var methodGetWindowsAuthenticateSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWindowsAuthenticateSession, methodGetWindowsAuthenticateSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWindowsAuthenticateSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWindowsAuthenticateSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWindowsAuthenticateSession) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetWindowsAuthenticateSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWindowsAuthenticateSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWindowsAuthenticateSession, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetSession_Method_Call_Internally(Type[] types)
        {
            var methodGetSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSession, methodGetSessionParametersTypes);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);

            // Act
            Action executeAction = () => _authenticateInstance.GetSession();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.GetSession();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            Type [] methodGetSessionParametersTypes = null;
            object[] parametersOfGetSession = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSession, methodGetSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetSession);
            var result2 = this.GetResultOfMethod<string>(MethodGetSession, parametersOfGetSession, methodGetSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSession.ShouldBeNull();
            methodGetSessionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            Type [] methodGetSessionParametersTypes = null;
            object[] parametersOfGetSession = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSession, parametersOfGetSession, methodGetSessionParametersTypes);

            // Assert
            parametersOfGetSession.ShouldBeNull();
            methodGetSessionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            Type [] methodGetSessionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSession, methodGetSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            Type [] methodGetSessionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSession, methodGetSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_ChangePassword_Method_Call_Internally(Type[] types)
        {
            var methodChangePasswordParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodChangePassword, methodChangePasswordParametersTypes);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);

            // Act
            Action executeAction = () => _authenticateInstance.ChangePassword();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.ChangePassword();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            Type [] methodChangePasswordParametersTypes = null;
            object[] parametersOfChangePassword = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodChangePassword, methodChangePasswordParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfChangePassword);
            var result2 = this.GetResultOfMethod<string>(MethodChangePassword, parametersOfChangePassword, methodChangePasswordParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfChangePassword.ShouldBeNull();
            methodChangePasswordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            Type [] methodChangePasswordParametersTypes = null;
            object[] parametersOfChangePassword = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodChangePassword, parametersOfChangePassword, methodChangePasswordParametersTypes);

            // Assert
            parametersOfChangePassword.ShouldBeNull();
            methodChangePasswordParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            Type [] methodChangePasswordParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodChangePassword, methodChangePasswordParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodChangePasswordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            Type [] methodChangePasswordParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodChangePassword, methodChangePasswordParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodChangePasswordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_ChangePassword_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var currentMethodInfo = this.GetMethodInfo(MethodChangePassword, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_LogoutUser_Method_Call_Internally(Type[] types)
        {
            var methodLogoutUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodLogoutUser, methodLogoutUserParametersTypes);
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);

            // Act
            Action executeAction = () => _authenticateInstance.LogoutUser();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.LogoutUser();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            Type [] methodLogoutUserParametersTypes = null;
            object[] parametersOfLogoutUser = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodLogoutUser, methodLogoutUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfLogoutUser);
            var result2 = this.GetResultOfMethod<string>(MethodLogoutUser, parametersOfLogoutUser, methodLogoutUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfLogoutUser.ShouldBeNull();
            methodLogoutUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            Type [] methodLogoutUserParametersTypes = null;
            object[] parametersOfLogoutUser = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodLogoutUser, parametersOfLogoutUser, methodLogoutUserParametersTypes);

            // Assert
            parametersOfLogoutUser.ShouldBeNull();
            methodLogoutUserParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            Type [] methodLogoutUserParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodLogoutUser, methodLogoutUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodLogoutUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            Type [] methodLogoutUserParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodLogoutUser, methodLogoutUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodLogoutUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (LogoutUser) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_LogoutUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodLogoutUser);
            var currentMethodInfo = this.GetMethodInfo(MethodLogoutUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetUserProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetUserProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);

            // Act
            Action executeAction = () => _authenticateInstance.GetUserProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.GetUserProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;
            object[] parametersOfGetUserProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, methodGetUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetUserProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserProfile.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;
            object[] parametersOfGetUserProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            parametersOfGetUserProfile.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetDefaultUserProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultUserProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);

            // Act
            Action executeAction = () => _authenticateInstance.GetDefaultUserProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.GetDefaultUserProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;
            object[] parametersOfGetDefaultUserProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetDefaultUserProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultUserProfile.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;
            object[] parametersOfGetDefaultUserProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            parametersOfGetDefaultUserProfile.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_RemoveDuplicate_Method_Call_Internally(Type[] types)
        {
            var methodRemoveDuplicateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveDuplicate, methodRemoveDuplicateParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var resultXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _authenticateInstance.RemoveDuplicate(resultXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var resultXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.RemoveDuplicate(resultXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var resultXml = this.CreateType<string>();
            var methodRemoveDuplicateParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveDuplicate = { resultXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveDuplicate, methodRemoveDuplicateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfRemoveDuplicate);
            var result2 = this.GetResultOfMethod<string>(MethodRemoveDuplicate, parametersOfRemoveDuplicate, methodRemoveDuplicateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRemoveDuplicate.ShouldNotBeNull();
            parametersOfRemoveDuplicate.Length.ShouldBe(1);
            methodRemoveDuplicateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var resultXml = this.CreateType<string>();
            var methodRemoveDuplicateParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfRemoveDuplicate = { resultXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRemoveDuplicate, parametersOfRemoveDuplicate, methodRemoveDuplicateParametersTypes);

            // Assert
            parametersOfRemoveDuplicate.ShouldNotBeNull();
            parametersOfRemoveDuplicate.Length.ShouldBe(1);
            methodRemoveDuplicateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var methodRemoveDuplicateParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoveDuplicate, methodRemoveDuplicateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRemoveDuplicateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var methodRemoveDuplicateParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveDuplicate, methodRemoveDuplicateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveDuplicateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveDuplicate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveDuplicate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_RemoveDuplicate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveDuplicate);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveDuplicate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Authenticate_GetUserPreferenceByName_Method_Call_Internally(Type[] types)
        {
            var methodGetUserPreferenceByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);

            // Act
            Action executeAction = () => _authenticateInstance.GetUserPreferenceByName();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _authenticateInstance.GetUserPreferenceByName();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;
            object[] parametersOfGetUserPreferenceByName = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_authenticateInstanceFixture, parametersOfGetUserPreferenceByName);
            var result2 = this.GetResultOfMethod<string>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserPreferenceByName.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;
            object[] parametersOfGetUserPreferenceByName = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            parametersOfGetUserPreferenceByName.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Authenticate_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}