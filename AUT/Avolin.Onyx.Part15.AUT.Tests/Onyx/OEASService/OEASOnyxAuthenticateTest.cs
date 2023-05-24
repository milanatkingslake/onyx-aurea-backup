using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OEASService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OEASService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OEASService.OEASOnyxAuthenticate" />)
    ///     and namespace <see cref="Onyx.OEASService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OEASOnyxAuthenticateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASOnyxAuthenticate" />)
        /// </summary>
        public OEASOnyxAuthenticateTest() : base(typeof(OEASOnyxAuthenticate))
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

        #region General Initializer : Class (OEASOnyxAuthenticate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASOnyxAuthenticateInstanceType;
        private OEASOnyxAuthenticate _oEASOnyxAuthenticateInstance;
        private OEASOnyxAuthenticate _oEASOnyxAuthenticateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEASOnyxAuthenticate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASOnyxAuthenticateInstanceType = typeof(OEASOnyxAuthenticate);
            _oEASOnyxAuthenticateInstanceFixture = this.Create<OEASOnyxAuthenticate>(false);
            _oEASOnyxAuthenticateInstance = _oEASOnyxAuthenticateInstanceFixture ?? this.Create<OEASOnyxAuthenticate>(true);
            CurrentInstance = _oEASOnyxAuthenticateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASOnyxAuthenticate) Initializer

        #region Methods

        private const string MethodChangePassword = "ChangePassword";
        private const string MethodEstablishSession = "EstablishSession";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";
        private const string FieldonyxOEASService = "onyxOEASService";
        private const string FieldonyxContextData = "onyxContextData";

        #endregion

        #endregion

        #region General Initializer : Class (OEASOnyxAuthenticate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASOnyxAuthenticate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASOnyxAuthenticate) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASOnyxAuthenticate_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASOnyxAuthenticate)

        #region General Initializer : Class (OEASOnyxAuthenticate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodChangePassword, 0)]
        [TestCase(MethodEstablishSession, 0)]
        public void AUT_OEASOnyxAuthenticate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASOnyxAuthenticate) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [TestCase(FieldonyxOEASService)]
        [TestCase(FieldonyxContextData)]
        [Category("AUT Fields")]
        public void AUT_OEASOnyxAuthenticate_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OEASOnyxAuthenticate) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASOnyxAuthenticate_Is_Instance_Present_Test()
        {
            // Assert
            _oEASOnyxAuthenticateInstanceType.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstance.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OEASOnyxAuthenticate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEASOnyxAuthenticate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASOnyxAuthenticate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEASOnyxAuthenticateInstance.ShouldBeAssignableTo<OEASOnyxAuthenticate>();
            _oEASOnyxAuthenticateInstanceFixture.ShouldBeAssignableTo<OEASOnyxAuthenticate>();
            CurrentInstance.ShouldBeAssignableTo<OEASOnyxAuthenticate>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OEASOnyxAuthenticate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEASOnyxAuthenticate_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pOnyxContextData = this.CreateType<OnyxContextData>();
            OEASOnyxAuthenticate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEASOnyxAuthenticate(pOnyxContextData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstance.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OEASOnyxAuthenticate>();
        }

        #endregion

        #region General Constructor : Class (OEASOnyxAuthenticate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEASOnyxAuthenticate_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pOnyxContextData = this.CreateType<OnyxContextData>();
            OEASOnyxAuthenticate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEASOnyxAuthenticate(pOnyxContextData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstance.ShouldNotBeNull();
            _oEASOnyxAuthenticateInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ChangePassword) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var userId = this.CreateType<string>();
            var oldPassword = this.CreateType<string>();
            var newPassword = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASOnyxAuthenticateInstance.ChangePassword(userId, oldPassword, newPassword, applicationName, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var userId = this.CreateType<string>();
            var oldPassword = this.CreateType<string>();
            var newPassword = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var methodChangePasswordParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfChangePassword = { userId, oldPassword, newPassword, applicationName, siteId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodChangePassword, methodChangePasswordParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASOnyxAuthenticateInstanceFixture, parametersOfChangePassword);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfChangePassword.ShouldNotBeNull();
            parametersOfChangePassword.Length.ShouldBe(5);
            methodChangePasswordParametersTypes.Length.ShouldBe(5);
            methodChangePasswordParametersTypes.Length.ShouldBe(parametersOfChangePassword.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var userId = this.CreateType<string>();
            var oldPassword = this.CreateType<string>();
            var newPassword = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var methodChangePasswordParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfChangePassword = { userId, oldPassword, newPassword, applicationName, siteId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodChangePassword, parametersOfChangePassword, methodChangePasswordParametersTypes);

            // Assert
            parametersOfChangePassword.ShouldNotBeNull();
            parametersOfChangePassword.Length.ShouldBe(5);
            methodChangePasswordParametersTypes.Length.ShouldBe(5);
            methodChangePasswordParametersTypes.Length.ShouldBe(parametersOfChangePassword.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var currentMethodInfo = this.GetMethodInfo(MethodChangePassword, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var methodChangePasswordParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodChangePassword, methodChangePasswordParametersTypes);

            // Assert
            methodChangePasswordParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ChangePassword) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_ChangePassword_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodChangePassword);
            var currentMethodInfo = this.GetMethodInfo(MethodChangePassword, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_Internally(Type[] types)
        {
            var methodEstablishSessionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodEstablishSession, methodEstablishSessionParametersTypes);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASOnyxAuthenticateInstance.EstablishSession(userId, password, applicationName, siteId, source);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSession = { userId, password, applicationName, siteId, source };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, methodEstablishSessionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASOnyxAuthenticateInstanceFixture, parametersOfEstablishSession);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEstablishSession.ShouldNotBeNull();
            parametersOfEstablishSession.Length.ShouldBe(5);
            methodEstablishSessionParametersTypes.Length.ShouldBe(5);
            methodEstablishSessionParametersTypes.Length.ShouldBe(parametersOfEstablishSession.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var userId = this.CreateType<string>();
            var password = this.CreateType<string>();
            var applicationName = this.CreateType<string>();
            var siteId = this.CreateType<string>();
            var source = this.CreateType<string>();
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfEstablishSession = { userId, password, applicationName, siteId, source };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEstablishSession, parametersOfEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            parametersOfEstablishSession.ShouldNotBeNull();
            parametersOfEstablishSession.Length.ShouldBe(5);
            methodEstablishSessionParametersTypes.Length.ShouldBe(5);
            methodEstablishSessionParametersTypes.Length.ShouldBe(parametersOfEstablishSession.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var methodEstablishSessionParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEstablishSession, methodEstablishSessionParametersTypes);

            // Assert
            methodEstablishSessionParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EstablishSession) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxAuthenticate_EstablishSession_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEstablishSession);
            var currentMethodInfo = this.GetMethodInfo(MethodEstablishSession, 0);

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