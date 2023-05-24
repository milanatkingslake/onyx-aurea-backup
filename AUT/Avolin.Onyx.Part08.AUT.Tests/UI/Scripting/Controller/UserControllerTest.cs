using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Controller;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.UserController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserController" />)
        /// </summary>
        public UserControllerTest() : base(typeof(UserController))
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

        #region General Initializer : Class (UserController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userControllerInstanceType;
        private UserController _userControllerInstance;
        private UserController _userControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userControllerInstanceType = typeof(UserController);
            _userControllerInstanceFixture = this.Create<UserController>(false);
            _userControllerInstance = _userControllerInstanceFixture ?? this.Create<UserController>(true);
            CurrentInstance = _userControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserController) Initializer

        #region Methods

        private const string MethodGetUsersAndGroups = "GetUsersAndGroups";
        private const string MethodGetUserForUserId = "GetUserForUserId";
        private const string MethodGetUserSearch = "GetUserSearch";
        private const string MethodGetCurrentUser = "GetCurrentUser";
        private const string MethodGetActiveUsers = "GetActiveUsers";
        private const string MethodGetCurrentUserPreference = "GetCurrentUserPreference";

        #endregion

        #endregion

        #region General Initializer : Class (UserController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserController)

        #region General Initializer : Class (UserController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UserController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUsersAndGroups, 0)]
        [TestCase(MethodGetUserForUserId, 0)]
        [TestCase(MethodGetUserSearch, 0)]
        [TestCase(MethodGetCurrentUser, 0)]
        [TestCase(MethodGetActiveUsers, 0)]
        [TestCase(MethodGetCurrentUserPreference, 0)]
        public void AUT_UserController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (UserController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserController_Is_Instance_Present_Test()
        {
            // Assert
            _userControllerInstanceType.ShouldNotBeNull();
            _userControllerInstance.ShouldNotBeNull();
            _userControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userControllerInstance.ShouldBeAssignableTo<UserController>();
            _userControllerInstanceFixture.ShouldBeAssignableTo<UserController>();
            CurrentInstance.ShouldBeAssignableTo<UserController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();

            // Act
            Action executeAction = () => _userControllerInstance.GetUsersAndGroups(groupId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetUsersAndGroups(groupId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUsersAndGroups = { groupId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetUsersAndGroups);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsersAndGroups.ShouldNotBeNull();
            parametersOfGetUsersAndGroups.Length.ShouldBe(1);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUsersAndGroups = { groupId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            parametersOfGetUsersAndGroups.ShouldNotBeNull();
            parametersOfGetUsersAndGroups.Length.ShouldBe(1);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUsersAndGroups_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserController_GetUserForUserId_Method_Call_Internally(Type[] types)
        {
            var methodGetUserForUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();

            // Act
            Action executeAction = () => _userControllerInstance.GetUserForUserId(userId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetUserForUserId(userId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserForUserId = { userId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetUserForUserId);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserForUserId, parametersOfGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserForUserId.ShouldNotBeNull();
            parametersOfGetUserForUserId.Length.ShouldBe(1);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserForUserId = { userId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserForUserId, parametersOfGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            parametersOfGetUserForUserId.ShouldNotBeNull();
            parametersOfGetUserForUserId.Length.ShouldBe(1);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserForUserId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserForUserId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserForUserId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserController_GetUserSearch_Method_Call_Internally(Type[] types)
        {
            var methodGetUserSearchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserSearch, methodGetUserSearchParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();

            // Act
            Action executeAction = () => _userControllerInstance.GetUserSearch(searchString);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetUserSearch(searchString);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserSearch = { searchString };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearch, methodGetUserSearchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetUserSearch);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserSearch, parametersOfGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserSearch.ShouldNotBeNull();
            parametersOfGetUserSearch.Length.ShouldBe(1);
            methodGetUserSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetUserSearch = { searchString };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserSearch, parametersOfGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            parametersOfGetUserSearch.ShouldNotBeNull();
            parametersOfGetUserSearch.Length.ShouldBe(1);
            methodGetUserSearchParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetUserSearch_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearch, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserController_GetCurrentUser_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);

            // Act
            Action executeAction = () => _userControllerInstance.GetCurrentUser();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetCurrentUser();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            Type [] methodGetCurrentUserParametersTypes = null;
            object[] parametersOfGetCurrentUser = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUser, methodGetCurrentUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetCurrentUser);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCurrentUser, parametersOfGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentUser.ShouldBeNull();
            methodGetCurrentUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            Type [] methodGetCurrentUserParametersTypes = null;
            object[] parametersOfGetCurrentUser = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCurrentUser, parametersOfGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            parametersOfGetCurrentUser.ShouldBeNull();
            methodGetCurrentUserParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            Type [] methodGetCurrentUserParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            Type [] methodGetCurrentUserParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentUserParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserController_GetActiveUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetActiveUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);

            // Act
            Action executeAction = () => _userControllerInstance.GetActiveUsers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetActiveUsers();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            Type [] methodGetActiveUsersParametersTypes = null;
            object[] parametersOfGetActiveUsers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveUsers, methodGetActiveUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetActiveUsers);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveUsers, parametersOfGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveUsers.ShouldBeNull();
            methodGetActiveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            Type [] methodGetActiveUsersParametersTypes = null;
            object[] parametersOfGetActiveUsers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetActiveUsers, parametersOfGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            parametersOfGetActiveUsers.ShouldBeNull();
            methodGetActiveUsersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            Type [] methodGetActiveUsersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            Type [] methodGetActiveUsersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveUsersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetActiveUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveUsers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserController_GetCurrentUserPreference_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentUserPreferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();

            // Act
            Action executeAction = () => _userControllerInstance.GetCurrentUserPreference(profileId, preferenceName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _userControllerInstance.GetCurrentUserPreference(profileId, preferenceName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string) };
            object[] parametersOfGetCurrentUserPreference = { profileId, preferenceName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_userControllerInstanceFixture, parametersOfGetCurrentUserPreference);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(2);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string) };
            object[] parametersOfGetCurrentUserPreference = { profileId, preferenceName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(2);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserController_GetCurrentUserPreference_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, 0);
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