using System;
using System.Collections;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Session" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SessionTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Session" />)
        /// </summary>
        public SessionTest() : base(typeof(Session))
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

        #region General Initializer : Class (Session) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _sessionInstanceType;
        private Session _sessionInstance;
        private Session _sessionInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Session" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _sessionInstanceType = typeof(Session);
            _sessionInstanceFixture = this.Create<Session>(false);
            _sessionInstance = _sessionInstanceFixture ?? this.Create<Session>(true);
            CurrentInstance = _sessionInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Session) Initializer

        #region Methods

        private const string MethodHasPermission = "HasPermission";

        #endregion

        #endregion

        #region General Initializer : Class (Session) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Session" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Session_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Session)

        #region General Initializer : Class (Session) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Session" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodHasPermission, 0)]
        public void AUT_Session_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (Session) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Session" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Session_Is_Instance_Present_Test()
        {
            // Assert
            _sessionInstanceType.ShouldNotBeNull();
            _sessionInstance.ShouldNotBeNull();
            _sessionInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Session) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Session" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Session_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _sessionInstance.ShouldBeAssignableTo<Session>();
            _sessionInstanceFixture.ShouldBeAssignableTo<Session>();
            CurrentInstance.ShouldBeAssignableTo<Session>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Session) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Session_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Session instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Session(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _sessionInstance.ShouldNotBeNull();
            _sessionInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Session>();
        }

        #endregion

        #region General Constructor : Class (Session) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Session_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Session instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Session(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _sessionInstance.ShouldNotBeNull();
            _sessionInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (HasPermission) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<Guid>();
            var resourceName = this.CreateType<string>();

            // Act
            Action executeAction = () => _sessionInstance.HasPermission(sessionId, resourceName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<Guid>();
            var resourceName = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, resourceName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_sessionInstanceFixture, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(2);
            methodHasPermissionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<Guid>();
            var resourceName = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, resourceName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, methodHasPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_sessionInstanceFixture, out exception1, parametersOfHasPermission);
            var result2 = this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(2);
            methodHasPermissionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var sessionId = this.CreateType<Guid>();
            var resourceName = this.CreateType<string>();
            var methodHasPermissionParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfHasPermission = { sessionId, resourceName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodHasPermission, parametersOfHasPermission, methodHasPermissionParametersTypes);

            // Assert
            parametersOfHasPermission.ShouldNotBeNull();
            parametersOfHasPermission.Length.ShouldBe(2);
            methodHasPermissionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var methodHasPermissionParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodHasPermission, methodHasPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodHasPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (HasPermission) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Session_HasPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodHasPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodHasPermission, 0);
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