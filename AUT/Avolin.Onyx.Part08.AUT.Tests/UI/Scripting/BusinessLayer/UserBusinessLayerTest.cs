using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.UserBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class UserBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="UserBusinessLayer" />)
        /// </summary>
        public UserBusinessLayerTest() : base(typeof(UserBusinessLayer))
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

        #region General Initializer : Class (UserBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _userBusinessLayerInstanceType;
        private UserBusinessLayer _userBusinessLayerInstance;
        private UserBusinessLayer _userBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="UserBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _userBusinessLayerInstanceType = typeof(UserBusinessLayer);
            _userBusinessLayerInstanceFixture = this.Create<UserBusinessLayer>(false);
            _userBusinessLayerInstance = _userBusinessLayerInstanceFixture ?? this.Create<UserBusinessLayer>(true);
            CurrentInstance = _userBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (UserBusinessLayer) Initializer

        #region Methods

        private const string MethodGetUserSearch = "GetUserSearch";
        private const string MethodGetUsersAndGroups = "GetUsersAndGroups";
        private const string MethodGetCurrentUser = "GetCurrentUser";
        private const string MethodGetActiveUsers = "GetActiveUsers";
        private const string MethodGetUserForUserId = "GetUserForUserId";
        private const string MethodGetCurrentUserPreference = "GetCurrentUserPreference";
        private const string MethodmergeUserPreference = "mergeUserPreference";

        #endregion

        #endregion

        #region General Initializer : Class (UserBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (UserBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_UserBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (UserBusinessLayer)

        #region General Initializer : Class (UserBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUserSearch, 0)]
        [TestCase(MethodGetUsersAndGroups, 0)]
        [TestCase(MethodGetCurrentUser, 0)]
        [TestCase(MethodGetActiveUsers, 0)]
        [TestCase(MethodGetUserForUserId, 0)]
        [TestCase(MethodGetCurrentUserPreference, 0)]
        [TestCase(MethodmergeUserPreference, 0)]
        [TestCase(MethodGetCurrentUserPreference, 1)]
        public void AUT_UserBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (UserBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _userBusinessLayerInstanceType.ShouldNotBeNull();
            _userBusinessLayerInstance.ShouldNotBeNull();
            _userBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (UserBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="UserBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_UserBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _userBusinessLayerInstance.ShouldBeAssignableTo<UserBusinessLayer>();
            _userBusinessLayerInstanceFixture.ShouldBeAssignableTo<UserBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<UserBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (UserBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_UserBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            UserBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetUserSearch(searchString, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<UserSearchModel>);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetUserSearch(searchString, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUserSearch = { searchString, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearch, methodGetUserSearchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserSearchModel>>(_userBusinessLayerInstanceFixture, parametersOfGetUserSearch);
            var result2 = this.GetResultOfMethod<IList<UserSearchModel>>(MethodGetUserSearch, parametersOfGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserSearch.ShouldNotBeNull();
            parametersOfGetUserSearch.Length.ShouldBe(2);
            methodGetUserSearchParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var searchString = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUserSearch = { searchString, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserSearchModel>>(MethodGetUserSearch, parametersOfGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            parametersOfGetUserSearch.ShouldNotBeNull();
            parametersOfGetUserSearch.Length.ShouldBe(2);
            methodGetUserSearchParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserSearchParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var methodGetUserSearchParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserSearch, methodGetUserSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetUserSearch) (Return Type : IList<UserSearchModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserSearch_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserSearch, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_Internally(Type[] types)
        {
            var methodGetUsersAndGroupsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetUsersAndGroups(groupId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<UserGroupModel>);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetUsersAndGroups(groupId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUsersAndGroups = { groupId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserGroupModel>>(_userBusinessLayerInstanceFixture, parametersOfGetUsersAndGroups);
            var result2 = this.GetResultOfMethod<IList<UserGroupModel>>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUsersAndGroups.ShouldNotBeNull();
            parametersOfGetUsersAndGroups.Length.ShouldBe(2);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var groupId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUsersAndGroups = { groupId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserGroupModel>>(MethodGetUsersAndGroups, parametersOfGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            parametersOfGetUsersAndGroups.ShouldNotBeNull();
            parametersOfGetUsersAndGroups.Length.ShouldBe(2);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var methodGetUsersAndGroupsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUsersAndGroups, methodGetUsersAndGroupsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUsersAndGroupsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetUsersAndGroups) (Return Type : IList<UserGroupModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUsersAndGroups_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUsersAndGroups);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUsersAndGroups, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetCurrentUser(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(UserModel);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetCurrentUser(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUser = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUser, methodGetCurrentUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<UserModel>(_userBusinessLayerInstanceFixture, parametersOfGetCurrentUser);
            var result2 = this.GetResultOfMethod<UserModel>(MethodGetCurrentUser, parametersOfGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentUser.ShouldNotBeNull();
            parametersOfGetCurrentUser.Length.ShouldBe(1);
            methodGetCurrentUserParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUser = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserModel>(MethodGetCurrentUser, parametersOfGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            parametersOfGetCurrentUser.ShouldNotBeNull();
            parametersOfGetCurrentUser.Length.ShouldBe(1);
            methodGetCurrentUserParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var methodGetCurrentUserParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentUserParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var methodGetCurrentUserParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentUser, methodGetCurrentUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentUserParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetCurrentUser) (Return Type : UserModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUser, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_Internally(Type[] types)
        {
            var methodGetActiveUsersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetActiveUsers(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<UserModel>);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetActiveUsers(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveUsersParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveUsers = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveUsers, methodGetActiveUsersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserModel>>(_userBusinessLayerInstanceFixture, parametersOfGetActiveUsers);
            var result2 = this.GetResultOfMethod<IList<UserModel>>(MethodGetActiveUsers, parametersOfGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveUsers.ShouldNotBeNull();
            parametersOfGetActiveUsers.Length.ShouldBe(1);
            methodGetActiveUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveUsersParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveUsers = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserModel>>(MethodGetActiveUsers, parametersOfGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            parametersOfGetActiveUsers.ShouldNotBeNull();
            parametersOfGetActiveUsers.Length.ShouldBe(1);
            methodGetActiveUsersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var methodGetActiveUsersParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveUsersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var methodGetActiveUsersParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveUsers, methodGetActiveUsersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveUsersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetActiveUsers) (Return Type : IList<UserModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetActiveUsers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveUsers);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveUsers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_Internally(Type[] types)
        {
            var methodGetUserForUserIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetUserForUserId(userId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(UserModel);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetUserForUserId(userId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUserForUserId = { userId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<UserModel>(_userBusinessLayerInstanceFixture, parametersOfGetUserForUserId);
            var result2 = this.GetResultOfMethod<UserModel>(MethodGetUserForUserId, parametersOfGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserForUserId.ShouldNotBeNull();
            parametersOfGetUserForUserId.Length.ShouldBe(2);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var userId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetUserForUserId = { userId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<UserModel>(MethodGetUserForUserId, parametersOfGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            parametersOfGetUserForUserId.ShouldNotBeNull();
            parametersOfGetUserForUserId.Length.ShouldBe(2);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var methodGetUserForUserIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserForUserId, methodGetUserForUserIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserForUserIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetUserForUserId) (Return Type : UserModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetUserForUserId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserForUserId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserForUserId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Internally(Type[] types)
        {
            var methodGetCurrentUserPreferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _userBusinessLayerInstance.GetCurrentUserPreference(profileId, preferenceName, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<UserPreferenceModel>);

            // Act
            Action executeAction = () => returnedValue = _userBusinessLayerInstance.GetCurrentUserPreference(profileId, preferenceName, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUserPreference = { profileId, preferenceName, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserPreferenceModel>>(_userBusinessLayerInstanceFixture, parametersOfGetCurrentUserPreference);
            var result2 = this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(3);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUserPreference = { profileId, preferenceName, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(3);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(int?), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_Internally(Type[] types)
        {
            var methodmergeUserPreferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodmergeUserPreference, methodmergeUserPreferenceParametersTypes);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var currentUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var defaultUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var methodmergeUserPreferenceParametersTypes = new Type[] { typeof(IList<UserPreferenceModel>), typeof(IList<UserPreferenceModel>) };
            object[] parametersOfmergeUserPreference = { currentUserPreference, defaultUserPreference };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodmergeUserPreference, methodmergeUserPreferenceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserPreferenceModel>>(_userBusinessLayerInstanceFixture, out exception1, parametersOfmergeUserPreference);
            var result2 = this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodmergeUserPreference, parametersOfmergeUserPreference, methodmergeUserPreferenceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfmergeUserPreference.ShouldNotBeNull();
            parametersOfmergeUserPreference.Length.ShouldBe(2);
            methodmergeUserPreferenceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var currentUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var defaultUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var methodmergeUserPreferenceParametersTypes = new Type[] { typeof(IList<UserPreferenceModel>), typeof(IList<UserPreferenceModel>) };
            object[] parametersOfmergeUserPreference = { currentUserPreference, defaultUserPreference };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodmergeUserPreference, methodmergeUserPreferenceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_userBusinessLayerInstanceFixture, parametersOfmergeUserPreference);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfmergeUserPreference.ShouldNotBeNull();
            parametersOfmergeUserPreference.Length.ShouldBe(2);
            methodmergeUserPreferenceParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var currentUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var defaultUserPreference = this.CreateType<IList<UserPreferenceModel>>();
            var methodmergeUserPreferenceParametersTypes = new Type[] { typeof(IList<UserPreferenceModel>), typeof(IList<UserPreferenceModel>) };
            object[] parametersOfmergeUserPreference = { currentUserPreference, defaultUserPreference };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodmergeUserPreference, parametersOfmergeUserPreference, methodmergeUserPreferenceParametersTypes);

            // Assert
            parametersOfmergeUserPreference.ShouldNotBeNull();
            parametersOfmergeUserPreference.Length.ShouldBe(2);
            methodmergeUserPreferenceParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var methodmergeUserPreferenceParametersTypes = new Type[] { typeof(IList<UserPreferenceModel>), typeof(IList<UserPreferenceModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodmergeUserPreference, methodmergeUserPreferenceParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodmergeUserPreferenceParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var methodmergeUserPreferenceParametersTypes = new Type[] { typeof(IList<UserPreferenceModel>), typeof(IList<UserPreferenceModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodmergeUserPreference, methodmergeUserPreferenceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodmergeUserPreferenceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodmergeUserPreference, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (mergeUserPreference) (Return Type : IList<UserPreferenceModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_mergeUserPreference_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodmergeUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodmergeUserPreference, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetCurrentUserPreferenceParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var userId = this.CreateType<string>();
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(string), typeof(int?), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUserPreference = { userId, profileId, preferenceName, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<UserPreferenceModel>>(_userBusinessLayerInstanceFixture, parametersOfGetCurrentUserPreference);
            var result2 = this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(4);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var userId = this.CreateType<string>();
            var profileId = this.CreateType<int?>();
            var preferenceName = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(string), typeof(int?), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetCurrentUserPreference = { userId, profileId, preferenceName, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<UserPreferenceModel>>(MethodGetCurrentUserPreference, parametersOfGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            parametersOfGetCurrentUserPreference.ShouldNotBeNull();
            parametersOfGetCurrentUserPreference.Length.ShouldBe(4);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(string), typeof(int?), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var methodGetCurrentUserPreferenceParametersTypes = new Type[] { typeof(string), typeof(int?), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCurrentUserPreference, methodGetCurrentUserPreferenceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCurrentUserPreferenceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCurrentUserPreference) (Return Type : IList<UserPreferenceModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_UserBusinessLayer_GetCurrentUserPreference_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCurrentUserPreference);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCurrentUserPreference, 1);
            const int parametersCount = 4;

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