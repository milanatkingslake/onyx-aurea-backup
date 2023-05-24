using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using OnyxISAPI.Persistence;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.ProfileManager" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProfileManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProfileManager" />)
        /// </summary>
        public ProfileManagerTest() : base(typeof(ProfileManager))
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

        #region General Initializer : Class (ProfileManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _profileManagerInstanceType;
        private ProfileManager _profileManagerInstance;
        private ProfileManager _profileManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProfileManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _profileManagerInstanceType = typeof(ProfileManager);
            _profileManagerInstanceFixture = this.Create<ProfileManager>(false);
            _profileManagerInstance = _profileManagerInstanceFixture ?? this.Create<ProfileManager>(true);
            CurrentInstance = _profileManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProfileManager) Initializer

        #region Methods

        private const string MethodGetSearchFilterProfile = "GetSearchFilterProfile";
        private const string MethodGetUserConfigurationFields = "GetUserConfigurationFields";
        private const string MethodGetQueryConfigurationFields = "GetQueryConfigurationFields";
        private const string MethodUpdateSearchFilterProfile = "UpdateSearchFilterProfile";
        private const string MethodCreateFieldConfiguration = "CreateFieldConfiguration";
        private const string MethodIsUserConfigurationSame = "IsUserConfigurationSame";
        private const string MethodGetLastSavedConfiguration = "GetLastSavedConfiguration";
        private const string MethodCreateUserFieldConfigurationList = "CreateUserFieldConfigurationList";
        private const string MethodRestoreSearchFilterProfile = "RestoreSearchFilterProfile";
        private const string MethodGetDataGridProfile = "GetDataGridProfile";
        private const string MethodUpdateDataGridProfile = "UpdateDataGridProfile";
        private const string MethodUpdateFieldConfiguration = "UpdateFieldConfiguration";
        private const string MethodUpdateEntityConfiguration = "UpdateEntityConfiguration";
        private const string MethodRestoreDataGridProfile = "RestoreDataGridProfile";
        private const string MethodGetUserEntityConfiguration = "GetUserEntityConfiguration";
        private const string MethodGetUserFieldConfiguration = "GetUserFieldConfiguration";
        private const string MethodGetQueryEntityConfiguration = "GetQueryEntityConfiguration";
        private const string MethodGetQueryRGConfiguration = "GetQueryRGConfiguration";
        private const string MethodGetDefaultFieldConfiguration = "GetDefaultFieldConfiguration";
        private const string MethodGetDefaultEntityConfiguration = "GetDefaultEntityConfiguration";
        private const string MethodGetModulePrivilege = "GetModulePrivilege";
        private const string MethodGetAllUIResources = "GetAllUIResources";
        private const string MethodGetBatchUpdatableFields = "GetBatchUpdatableFields";
        private const string MethodGetDataGridFields = "GetDataGridFields";
        private const string MethodGetSystemDefaultDataGridProfile = "GetSystemDefaultDataGridProfile";
        private const string MethodGetDefaultUserAccess = "GetDefaultUserAccess";
        private const string MethodGetAllFields = "GetAllFields";
        private const string MethodGetViewName = "GetViewName";
        private const string MethodGetEntityConfigurationForUser = "GetEntityConfigurationForUser";
        private const string MethodGetSystemDefaultSearchFilterProfile = "GetSystemDefaultSearchFilterProfile";
        private const string MethodGetFieldProperties = "GetFieldProperties";
        private const string MethodGetFieldIds = "GetFieldIds";
        private const string MethodGetNavigatorEntityID = "GetNavigatorEntityID";
        private const string MethodGetEntityName = "GetEntityName";
        private const string MethodGetDataType = "GetDataType";
        private const string MethodGetPolicy = "GetPolicy";
        private const string MethodGetFieldPosition = "GetFieldPosition";
        private const string MethodGetPropertyName = "GetPropertyName";
        private const string MethodGetPropertyID = "GetPropertyID";
        private const string MethodGetOwnerTypeByEntityId = "GetOwnerTypeByEntityId";
        private const string MethodGetPageSize = "GetPageSize";
        private const string MethodGetXml = "GetXml";
        private const string MethodUpdateSortOrder = "UpdateSortOrder";
        private const string MethodApplyDisplayPermissionForSearchFilter = "ApplyDisplayPermissionForSearchFilter";
        private const string MethodApplyFieldPermissionForSearchFilter = "ApplyFieldPermissionForSearchFilter";
        private const string MethodApplyFieldPermission = "ApplyFieldPermission";
        private const string MethodApplyDisplayPermission = "ApplyDisplayPermission";
        private const string MethodApplyUserFieldsConfiguration = "ApplyUserFieldsConfiguration";
        private const string MethodApplyUserQueryConfiguration = "ApplyUserQueryConfiguration";
        private const string MethodApplyUserSelection = "ApplyUserSelection";
        private const string MethodApplyProperties = "ApplyProperties";
        private const string MethodUpdateFieldProperties = "UpdateFieldProperties";
        private const string MethodUpdateQueryConfiguration = "UpdateQueryConfiguration";
        private const string MethodUpdateQueryFieldConfiguration = "UpdateQueryFieldConfiguration";
        private const string MethodReplaceCharWithChar = "ReplaceCharWithChar";
        private const string MethodGetSearchEntities = "GetSearchEntities";
        private const string MethodValidateMaxRecordsProfile = "ValidateMaxRecordsProfile";
        private const string MethodValidateMaxPageSizeProfile = "ValidateMaxPageSizeProfile";
        private const string MethodGetSearchExecuteMode = "GetSearchExecuteMode";
        private const string MethodGetSelectColumnNames = "GetSelectColumnNames";
        private const string MethodGetNavigatorEntityRecordByName = "GetNavigatorEntityRecordByName";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string FieldoedbEntities = "oedbEntities";

        #endregion

        #endregion

        #region General Initializer : Class (ProfileManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProfileManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProfileManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProfileManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ProfileManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProfileManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ProfileManager)

        #region General Initializer : Class (ProfileManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ProfileManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSearchFilterProfile, 0)]
        [TestCase(MethodGetUserConfigurationFields, 0)]
        [TestCase(MethodGetQueryConfigurationFields, 0)]
        [TestCase(MethodUpdateSearchFilterProfile, 0)]
        [TestCase(MethodCreateFieldConfiguration, 0)]
        [TestCase(MethodIsUserConfigurationSame, 0)]
        [TestCase(MethodGetLastSavedConfiguration, 0)]
        [TestCase(MethodCreateUserFieldConfigurationList, 0)]
        [TestCase(MethodRestoreSearchFilterProfile, 0)]
        [TestCase(MethodGetDataGridProfile, 0)]
        [TestCase(MethodUpdateDataGridProfile, 0)]
        [TestCase(MethodUpdateFieldConfiguration, 0)]
        [TestCase(MethodUpdateEntityConfiguration, 0)]
        [TestCase(MethodRestoreDataGridProfile, 0)]
        [TestCase(MethodGetUserEntityConfiguration, 0)]
        [TestCase(MethodGetUserFieldConfiguration, 0)]
        [TestCase(MethodGetQueryEntityConfiguration, 0)]
        [TestCase(MethodGetQueryRGConfiguration, 0)]
        [TestCase(MethodGetDefaultFieldConfiguration, 0)]
        [TestCase(MethodGetDefaultEntityConfiguration, 0)]
        [TestCase(MethodGetModulePrivilege, 0)]
        [TestCase(MethodGetAllUIResources, 0)]
        [TestCase(MethodGetBatchUpdatableFields, 0)]
        [TestCase(MethodGetDataGridProfile, 1)]
        [TestCase(MethodGetDataGridFields, 0)]
        [TestCase(MethodGetSystemDefaultDataGridProfile, 0)]
        [TestCase(MethodGetDefaultUserAccess, 0)]
        [TestCase(MethodGetAllFields, 0)]
        [TestCase(MethodGetViewName, 0)]
        [TestCase(MethodGetEntityConfigurationForUser, 0)]
        [TestCase(MethodGetSystemDefaultSearchFilterProfile, 0)]
        [TestCase(MethodGetFieldProperties, 0)]
        [TestCase(MethodGetFieldIds, 0)]
        [TestCase(MethodGetNavigatorEntityID, 0)]
        [TestCase(MethodGetEntityName, 0)]
        [TestCase(MethodGetDataType, 0)]
        [TestCase(MethodGetPolicy, 0)]
        [TestCase(MethodGetFieldPosition, 0)]
        [TestCase(MethodGetPropertyName, 0)]
        [TestCase(MethodGetPropertyID, 0)]
        [TestCase(MethodGetOwnerTypeByEntityId, 0)]
        [TestCase(MethodGetXml, 0)]
        [TestCase(MethodGetXml, 1)]
        [TestCase(MethodGetXml, 2)]
        [TestCase(MethodGetXml, 3)]
        [TestCase(MethodUpdateSortOrder, 0)]
        [TestCase(MethodApplyDisplayPermissionForSearchFilter, 0)]
        [TestCase(MethodApplyFieldPermissionForSearchFilter, 0)]
        [TestCase(MethodApplyFieldPermission, 0)]
        [TestCase(MethodApplyDisplayPermission, 0)]
        [TestCase(MethodApplyUserFieldsConfiguration, 0)]
        [TestCase(MethodApplyUserQueryConfiguration, 0)]
        [TestCase(MethodApplyUserSelection, 0)]
        [TestCase(MethodApplyProperties, 0)]
        [TestCase(MethodUpdateFieldProperties, 0)]
        [TestCase(MethodUpdateQueryConfiguration, 0)]
        [TestCase(MethodUpdateQueryFieldConfiguration, 0)]
        [TestCase(MethodReplaceCharWithChar, 0)]
        [TestCase(MethodGetSearchEntities, 0)]
        [TestCase(MethodGetXml, 4)]
        [TestCase(MethodValidateMaxRecordsProfile, 0)]
        [TestCase(MethodGetSearchExecuteMode, 0)]
        [TestCase(MethodGetSelectColumnNames, 0)]
        [TestCase(MethodGetNavigatorEntityRecordByName, 0)]
        public void AUT_ProfileManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ProfileManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ProfileManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(FieldoedbEntities)]
        [Category("AUT Fields")]
        public void AUT_ProfileManager_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ProfileManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ProfileManager" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProfileManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _profileManagerInstance.ShouldBeAssignableTo<ProfileManager>();
            _profileManagerInstanceFixture.ShouldBeAssignableTo<ProfileManager>();
            CurrentInstance.ShouldBeAssignableTo<ProfileManager>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.GetSearchFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetSearchFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;
            object[] parametersOfGetSearchFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetSearchFilterProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilterProfile.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;
            object[] parametersOfGetSearchFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            parametersOfGetSearchFilterProfile.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_Internally(Type[] types)
        {
            var methodGetUserConfigurationFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var userId = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetUserConfigurationFieldsParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetUserConfigurationFields = { userId, navigatorEntityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserConfigurationView>>(_profileManagerInstanceFixture, parametersOfGetUserConfigurationFields);
            var result2 = this.GetResultOfMethod<List<UserConfigurationView>>(MethodGetUserConfigurationFields, parametersOfGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserConfigurationFields.ShouldNotBeNull();
            parametersOfGetUserConfigurationFields.Length.ShouldBe(3);
            methodGetUserConfigurationFieldsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var userId = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetUserConfigurationFieldsParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetUserConfigurationFields = { userId, navigatorEntityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserConfigurationView>>(MethodGetUserConfigurationFields, parametersOfGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes);

            // Assert
            parametersOfGetUserConfigurationFields.ShouldNotBeNull();
            parametersOfGetUserConfigurationFields.Length.ShouldBe(3);
            methodGetUserConfigurationFieldsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var methodGetUserConfigurationFieldsParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserConfigurationFieldsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var methodGetUserConfigurationFieldsParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserConfigurationFields, methodGetUserConfigurationFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserConfigurationFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserConfigurationFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserConfigurationFields) (Return Type : List<UserConfigurationView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserConfigurationFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserConfigurationFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserConfigurationFields, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryConfigurationFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var navigatorEntityId = this.CreateType<int>();
            var queryId = this.CreateType<Guid>();
            var methodGetQueryConfigurationFieldsParametersTypes = new Type[] { typeof(int), typeof(Guid) };
            object[] parametersOfGetQueryConfigurationFields = { navigatorEntityId, queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<QueryConfigurationView>>(_profileManagerInstanceFixture, parametersOfGetQueryConfigurationFields);
            var result2 = this.GetResultOfMethod<List<QueryConfigurationView>>(MethodGetQueryConfigurationFields, parametersOfGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryConfigurationFields.ShouldNotBeNull();
            parametersOfGetQueryConfigurationFields.Length.ShouldBe(2);
            methodGetQueryConfigurationFieldsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var navigatorEntityId = this.CreateType<int>();
            var queryId = this.CreateType<Guid>();
            var methodGetQueryConfigurationFieldsParametersTypes = new Type[] { typeof(int), typeof(Guid) };
            object[] parametersOfGetQueryConfigurationFields = { navigatorEntityId, queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<QueryConfigurationView>>(MethodGetQueryConfigurationFields, parametersOfGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes);

            // Assert
            parametersOfGetQueryConfigurationFields.ShouldNotBeNull();
            parametersOfGetQueryConfigurationFields.Length.ShouldBe(2);
            methodGetQueryConfigurationFieldsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var methodGetQueryConfigurationFieldsParametersTypes = new Type[] { typeof(int), typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryConfigurationFieldsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var methodGetQueryConfigurationFieldsParametersTypes = new Type[] { typeof(int), typeof(Guid) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryConfigurationFields, methodGetQueryConfigurationFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryConfigurationFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfigurationFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryConfigurationFields) (Return Type : List<QueryConfigurationView>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryConfigurationFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfigurationFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfigurationFields, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.UpdateSearchFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.UpdateSearchFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;
            object[] parametersOfUpdateSearchFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfUpdateSearchFilterProfile);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateSearchFilterProfile, parametersOfUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSearchFilterProfile.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;
            object[] parametersOfUpdateSearchFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateSearchFilterProfile, parametersOfUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            parametersOfUpdateSearchFilterProfile.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodCreateFieldConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var fieldList = this.CreateType<XmlNodeList>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodCreateFieldConfigurationParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfCreateFieldConfiguration = { fieldList, userId, entityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<FieldConfiguration>>(_profileManagerInstanceFixture, parametersOfCreateFieldConfiguration);
            var result2 = this.GetResultOfMethod<List<FieldConfiguration>>(MethodCreateFieldConfiguration, parametersOfCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateFieldConfiguration.ShouldNotBeNull();
            parametersOfCreateFieldConfiguration.Length.ShouldBe(4);
            methodCreateFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var fieldList = this.CreateType<XmlNodeList>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodCreateFieldConfigurationParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfCreateFieldConfiguration = { fieldList, userId, entityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<FieldConfiguration>>(MethodCreateFieldConfiguration, parametersOfCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes);

            // Assert
            parametersOfCreateFieldConfiguration.ShouldNotBeNull();
            parametersOfCreateFieldConfiguration.Length.ShouldBe(4);
            methodCreateFieldConfigurationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var methodCreateFieldConfigurationParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var methodCreateFieldConfigurationParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateFieldConfiguration, methodCreateFieldConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateFieldConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFieldConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateFieldConfiguration) (Return Type : List<FieldConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateFieldConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateFieldConfiguration, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_Internally(Type[] types)
        {
            var methodIsUserConfigurationSameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var SourceConfiguration = this.CreateType<UserFieldConfiguration>();
            var targetConfiguration = this.CreateType<UserFieldConfiguration>();
            var methodIsUserConfigurationSameParametersTypes = new Type[] { typeof(UserFieldConfiguration), typeof(UserFieldConfiguration) };
            object[] parametersOfIsUserConfigurationSame = { SourceConfiguration, targetConfiguration };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfIsUserConfigurationSame);
            var result2 = this.GetResultOfMethod<bool>(MethodIsUserConfigurationSame, parametersOfIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsUserConfigurationSame.ShouldNotBeNull();
            parametersOfIsUserConfigurationSame.Length.ShouldBe(2);
            methodIsUserConfigurationSameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var SourceConfiguration = this.CreateType<UserFieldConfiguration>();
            var targetConfiguration = this.CreateType<UserFieldConfiguration>();
            var methodIsUserConfigurationSameParametersTypes = new Type[] { typeof(UserFieldConfiguration), typeof(UserFieldConfiguration) };
            object[] parametersOfIsUserConfigurationSame = { SourceConfiguration, targetConfiguration };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfIsUserConfigurationSame);
            var result2 = this.GetResultOfMethod<bool>(MethodIsUserConfigurationSame, parametersOfIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsUserConfigurationSame.ShouldNotBeNull();
            parametersOfIsUserConfigurationSame.Length.ShouldBe(2);
            methodIsUserConfigurationSameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var SourceConfiguration = this.CreateType<UserFieldConfiguration>();
            var targetConfiguration = this.CreateType<UserFieldConfiguration>();
            var methodIsUserConfigurationSameParametersTypes = new Type[] { typeof(UserFieldConfiguration), typeof(UserFieldConfiguration) };
            object[] parametersOfIsUserConfigurationSame = { SourceConfiguration, targetConfiguration };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsUserConfigurationSame, parametersOfIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes);

            // Assert
            parametersOfIsUserConfigurationSame.ShouldNotBeNull();
            parametersOfIsUserConfigurationSame.Length.ShouldBe(2);
            methodIsUserConfigurationSameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var methodIsUserConfigurationSameParametersTypes = new Type[] { typeof(UserFieldConfiguration), typeof(UserFieldConfiguration) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsUserConfigurationSame, methodIsUserConfigurationSameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsUserConfigurationSameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var currentMethodInfo = this.GetMethodInfo(MethodIsUserConfigurationSame, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsUserConfigurationSame) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_IsUserConfigurationSame_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsUserConfigurationSame);
            var currentMethodInfo = this.GetMethodInfo(MethodIsUserConfigurationSame, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetLastSavedConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetLastSavedConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetLastSavedConfiguration = { userId, entityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserFieldConfiguration>>(_profileManagerInstanceFixture, parametersOfGetLastSavedConfiguration);
            var result2 = this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodGetLastSavedConfiguration, parametersOfGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLastSavedConfiguration.ShouldNotBeNull();
            parametersOfGetLastSavedConfiguration.Length.ShouldBe(3);
            methodGetLastSavedConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetLastSavedConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetLastSavedConfiguration = { userId, entityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodGetLastSavedConfiguration, parametersOfGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes);

            // Assert
            parametersOfGetLastSavedConfiguration.ShouldNotBeNull();
            parametersOfGetLastSavedConfiguration.Length.ShouldBe(3);
            methodGetLastSavedConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var methodGetLastSavedConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLastSavedConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var methodGetLastSavedConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLastSavedConfiguration, methodGetLastSavedConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLastSavedConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLastSavedConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLastSavedConfiguration) (Return Type : List<UserFieldConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetLastSavedConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLastSavedConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLastSavedConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_Internally(Type[] types)
        {
            var methodCreateUserFieldConfigurationListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var fieldList = this.CreateType<XmlNodeList>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodCreateUserFieldConfigurationListParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfCreateUserFieldConfigurationList = { fieldList, userId, entityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserFieldConfiguration>>(_profileManagerInstanceFixture, parametersOfCreateUserFieldConfigurationList);
            var result2 = this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodCreateUserFieldConfigurationList, parametersOfCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateUserFieldConfigurationList.ShouldNotBeNull();
            parametersOfCreateUserFieldConfigurationList.Length.ShouldBe(4);
            methodCreateUserFieldConfigurationListParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var fieldList = this.CreateType<XmlNodeList>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodCreateUserFieldConfigurationListParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfCreateUserFieldConfigurationList = { fieldList, userId, entityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodCreateUserFieldConfigurationList, parametersOfCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes);

            // Assert
            parametersOfCreateUserFieldConfigurationList.ShouldNotBeNull();
            parametersOfCreateUserFieldConfigurationList.Length.ShouldBe(4);
            methodCreateUserFieldConfigurationListParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var methodCreateUserFieldConfigurationListParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateUserFieldConfigurationListParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var methodCreateUserFieldConfigurationListParametersTypes = new Type[] { typeof(XmlNodeList), typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateUserFieldConfigurationList, methodCreateUserFieldConfigurationListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateUserFieldConfigurationListParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateUserFieldConfigurationList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateUserFieldConfigurationList) (Return Type : List<UserFieldConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_CreateUserFieldConfigurationList_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateUserFieldConfigurationList);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateUserFieldConfigurationList, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodRestoreSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.RestoreSearchFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.RestoreSearchFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            Type [] methodRestoreSearchFilterProfileParametersTypes = null;
            object[] parametersOfRestoreSearchFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfRestoreSearchFilterProfile);
            var result2 = this.GetResultOfMethod<string>(MethodRestoreSearchFilterProfile, parametersOfRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRestoreSearchFilterProfile.ShouldBeNull();
            methodRestoreSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            Type [] methodRestoreSearchFilterProfileParametersTypes = null;
            object[] parametersOfRestoreSearchFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRestoreSearchFilterProfile, parametersOfRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes);

            // Assert
            parametersOfRestoreSearchFilterProfile.ShouldBeNull();
            methodRestoreSearchFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            Type [] methodRestoreSearchFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRestoreSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            Type [] methodRestoreSearchFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRestoreSearchFilterProfile, methodRestoreSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRestoreSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreSearchFilterProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDataGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetDataGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.GetDataGridProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDataGridProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            Type [] methodGetDataGridProfileParametersTypes = null;
            object[] parametersOfGetDataGridProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetDataGridProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetDataGridProfile, parametersOfGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataGridProfile.ShouldBeNull();
            methodGetDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            Type [] methodGetDataGridProfileParametersTypes = null;
            object[] parametersOfGetDataGridProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDataGridProfile, parametersOfGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            parametersOfGetDataGridProfile.ShouldBeNull();
            methodGetDataGridProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            Type [] methodGetDataGridProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            Type [] methodGetDataGridProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodUpdateDataGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.UpdateDataGridProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.UpdateDataGridProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            Type [] methodUpdateDataGridProfileParametersTypes = null;
            object[] parametersOfUpdateDataGridProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfUpdateDataGridProfile);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateDataGridProfile, parametersOfUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateDataGridProfile.ShouldBeNull();
            methodUpdateDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            Type [] methodUpdateDataGridProfileParametersTypes = null;
            object[] parametersOfUpdateDataGridProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateDataGridProfile, parametersOfUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes);

            // Assert
            parametersOfUpdateDataGridProfile.ShouldBeNull();
            methodUpdateDataGridProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            Type [] methodUpdateDataGridProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            Type [] methodUpdateDataGridProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateDataGridProfile, methodUpdateDataGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateDataGridProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateDataGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateDataGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodUpdateFieldConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateFieldConfiguration = { userId, entityId, useType, xmlDoc, adminPermission };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfUpdateFieldConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateFieldConfiguration, parametersOfUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateFieldConfiguration.Length.ShouldBe(5);
            methodUpdateFieldConfigurationParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateFieldConfiguration = { userId, entityId, useType, xmlDoc, adminPermission };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfUpdateFieldConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateFieldConfiguration, parametersOfUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateFieldConfiguration.Length.ShouldBe(5);
            methodUpdateFieldConfigurationParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateFieldConfiguration = { userId, entityId, useType, xmlDoc, adminPermission };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateFieldConfiguration, parametersOfUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes);

            // Assert
            parametersOfUpdateFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateFieldConfiguration.Length.ShouldBe(5);
            methodUpdateFieldConfigurationParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var methodUpdateFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateFieldConfiguration, methodUpdateFieldConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateFieldConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateFieldConfiguration) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldConfiguration, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodUpdateEntityConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateEntityConfiguration = { userId, entityId, searchType, xmlDoc, adminPermission };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfUpdateEntityConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateEntityConfiguration, parametersOfUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateEntityConfiguration.ShouldNotBeNull();
            parametersOfUpdateEntityConfiguration.Length.ShouldBe(5);
            methodUpdateEntityConfigurationParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateEntityConfiguration = { userId, entityId, searchType, xmlDoc, adminPermission };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfUpdateEntityConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateEntityConfiguration, parametersOfUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateEntityConfiguration.ShouldNotBeNull();
            parametersOfUpdateEntityConfiguration.Length.ShouldBe(5);
            methodUpdateEntityConfigurationParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var adminPermission = this.CreateType<bool>();
            var methodUpdateEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            object[] parametersOfUpdateEntityConfiguration = { userId, entityId, searchType, xmlDoc, adminPermission };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateEntityConfiguration, parametersOfUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes);

            // Assert
            parametersOfUpdateEntityConfiguration.ShouldNotBeNull();
            parametersOfUpdateEntityConfiguration.Length.ShouldBe(5);
            methodUpdateEntityConfigurationParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var methodUpdateEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(XmlDocument), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateEntityConfiguration, methodUpdateEntityConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateEntityConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateEntityConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateEntityConfiguration) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateEntityConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateEntityConfiguration, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodRestoreDataGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.RestoreDataGridProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.RestoreDataGridProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            Type [] methodRestoreDataGridProfileParametersTypes = null;
            object[] parametersOfRestoreDataGridProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfRestoreDataGridProfile);
            var result2 = this.GetResultOfMethod<string>(MethodRestoreDataGridProfile, parametersOfRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRestoreDataGridProfile.ShouldBeNull();
            methodRestoreDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            Type [] methodRestoreDataGridProfileParametersTypes = null;
            object[] parametersOfRestoreDataGridProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRestoreDataGridProfile, parametersOfRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes);

            // Assert
            parametersOfRestoreDataGridProfile.ShouldBeNull();
            methodRestoreDataGridProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            Type [] methodRestoreDataGridProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRestoreDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            Type [] methodRestoreDataGridProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRestoreDataGridProfile, methodRestoreDataGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRestoreDataGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDataGridProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_RestoreDataGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDataGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetUserEntityConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchMode = this.CreateType<int>();
            var siteId = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetUserEntityConfiguration(userId, entityId, searchMode, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchMode = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var returnedValue = default(List<UserEntityConfiguration>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetUserEntityConfiguration(userId, entityId, searchMode, siteId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchMode = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var methodGetUserEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetUserEntityConfiguration = { userId, entityId, searchMode, siteId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserEntityConfiguration>>(_profileManagerInstanceFixture, parametersOfGetUserEntityConfiguration);
            var result2 = this.GetResultOfMethod<List<UserEntityConfiguration>>(MethodGetUserEntityConfiguration, parametersOfGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserEntityConfiguration.ShouldNotBeNull();
            parametersOfGetUserEntityConfiguration.Length.ShouldBe(4);
            methodGetUserEntityConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var searchMode = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var methodGetUserEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetUserEntityConfiguration = { userId, entityId, searchMode, siteId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserEntityConfiguration>>(MethodGetUserEntityConfiguration, parametersOfGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes);

            // Assert
            parametersOfGetUserEntityConfiguration.ShouldNotBeNull();
            parametersOfGetUserEntityConfiguration.Length.ShouldBe(4);
            methodGetUserEntityConfigurationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var methodGetUserEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserEntityConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var methodGetUserEntityConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserEntityConfiguration, methodGetUserEntityConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserEntityConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserEntityConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserEntityConfiguration) (Return Type : List<UserEntityConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserEntityConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserEntityConfiguration, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetUserFieldConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var siteId = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetUserFieldConfiguration(userId, entityId, useType, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var returnedValue = default(List<UserFieldConfiguration>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetUserFieldConfiguration(userId, entityId, useType, siteId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var methodGetUserFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetUserFieldConfiguration = { userId, entityId, useType, siteId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<UserFieldConfiguration>>(_profileManagerInstanceFixture, parametersOfGetUserFieldConfiguration);
            var result2 = this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodGetUserFieldConfiguration, parametersOfGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserFieldConfiguration.ShouldNotBeNull();
            parametersOfGetUserFieldConfiguration.Length.ShouldBe(4);
            methodGetUserFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var methodGetUserFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetUserFieldConfiguration = { userId, entityId, useType, siteId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<UserFieldConfiguration>>(MethodGetUserFieldConfiguration, parametersOfGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes);

            // Assert
            parametersOfGetUserFieldConfiguration.ShouldNotBeNull();
            parametersOfGetUserFieldConfiguration.Length.ShouldBe(4);
            methodGetUserFieldConfigurationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var methodGetUserFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var methodGetUserFieldConfigurationParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(int) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserFieldConfiguration, methodGetUserFieldConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserFieldConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserFieldConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserFieldConfiguration) (Return Type : List<UserFieldConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetUserFieldConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserFieldConfiguration, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryEntityConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var entityId = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetQueryEntityConfiguration(queryId, siteId, entityId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var entityId = this.CreateType<int>();
            var returnedValue = default(List<QueryEntityConfiguration>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetQueryEntityConfiguration(queryId, siteId, entityId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var entityId = this.CreateType<int>();
            var methodGetQueryEntityConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int) };
            object[] parametersOfGetQueryEntityConfiguration = { queryId, siteId, entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<QueryEntityConfiguration>>(_profileManagerInstanceFixture, parametersOfGetQueryEntityConfiguration);
            var result2 = this.GetResultOfMethod<List<QueryEntityConfiguration>>(MethodGetQueryEntityConfiguration, parametersOfGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryEntityConfiguration.ShouldNotBeNull();
            parametersOfGetQueryEntityConfiguration.Length.ShouldBe(3);
            methodGetQueryEntityConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var entityId = this.CreateType<int>();
            var methodGetQueryEntityConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int) };
            object[] parametersOfGetQueryEntityConfiguration = { queryId, siteId, entityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<QueryEntityConfiguration>>(MethodGetQueryEntityConfiguration, parametersOfGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes);

            // Assert
            parametersOfGetQueryEntityConfiguration.ShouldNotBeNull();
            parametersOfGetQueryEntityConfiguration.Length.ShouldBe(3);
            methodGetQueryEntityConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var methodGetQueryEntityConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryEntityConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var methodGetQueryEntityConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryEntityConfiguration, methodGetQueryEntityConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryEntityConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryEntityConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryEntityConfiguration) (Return Type : List<QueryEntityConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryEntityConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryEntityConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryRGConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetQueryRGConfiguration(queryId, siteId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var returnedValue = default(List<QueryRGConfiguration>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetQueryRGConfiguration(queryId, siteId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var methodGetQueryRGConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int) };
            object[] parametersOfGetQueryRGConfiguration = { queryId, siteId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<QueryRGConfiguration>>(_profileManagerInstanceFixture, parametersOfGetQueryRGConfiguration);
            var result2 = this.GetResultOfMethod<List<QueryRGConfiguration>>(MethodGetQueryRGConfiguration, parametersOfGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryRGConfiguration.ShouldNotBeNull();
            parametersOfGetQueryRGConfiguration.Length.ShouldBe(2);
            methodGetQueryRGConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var queryId = this.CreateType<Guid>();
            var siteId = this.CreateType<int>();
            var methodGetQueryRGConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int) };
            object[] parametersOfGetQueryRGConfiguration = { queryId, siteId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<QueryRGConfiguration>>(MethodGetQueryRGConfiguration, parametersOfGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes);

            // Assert
            parametersOfGetQueryRGConfiguration.ShouldNotBeNull();
            parametersOfGetQueryRGConfiguration.Length.ShouldBe(2);
            methodGetQueryRGConfigurationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var methodGetQueryRGConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryRGConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var methodGetQueryRGConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryRGConfiguration, methodGetQueryRGConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryRGConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryRGConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryRGConfiguration) (Return Type : List<QueryRGConfiguration>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetQueryRGConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryRGConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryRGConfiguration, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultFieldConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var useType = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetDefaultFieldConfiguration(entityId, siteId, useType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var returnedValue = default(List<navigator_entity_field_master>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDefaultFieldConfiguration(entityId, siteId, useType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetDefaultFieldConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetDefaultFieldConfiguration = { entityId, siteId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master>>(_profileManagerInstanceFixture, parametersOfGetDefaultFieldConfiguration);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master>>(MethodGetDefaultFieldConfiguration, parametersOfGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultFieldConfiguration.ShouldNotBeNull();
            parametersOfGetDefaultFieldConfiguration.Length.ShouldBe(3);
            methodGetDefaultFieldConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetDefaultFieldConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetDefaultFieldConfiguration = { entityId, siteId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master>>(MethodGetDefaultFieldConfiguration, parametersOfGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes);

            // Assert
            parametersOfGetDefaultFieldConfiguration.ShouldNotBeNull();
            parametersOfGetDefaultFieldConfiguration.Length.ShouldBe(3);
            methodGetDefaultFieldConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var methodGetDefaultFieldConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultFieldConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var methodGetDefaultFieldConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultFieldConfiguration, methodGetDefaultFieldConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultFieldConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultFieldConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultFieldConfiguration) (Return Type : List<navigator_entity_field_master>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultFieldConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultFieldConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultEntityConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var SearchType = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetDefaultEntityConfiguration(entityId, siteId, SearchType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var SearchType = this.CreateType<int>();
            var returnedValue = default(List<navigator_entity_master>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDefaultEntityConfiguration(entityId, siteId, SearchType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var SearchType = this.CreateType<int>();
            var methodGetDefaultEntityConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetDefaultEntityConfiguration = { entityId, siteId, SearchType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_master>>(_profileManagerInstanceFixture, parametersOfGetDefaultEntityConfiguration);
            var result2 = this.GetResultOfMethod<List<navigator_entity_master>>(MethodGetDefaultEntityConfiguration, parametersOfGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultEntityConfiguration.ShouldNotBeNull();
            parametersOfGetDefaultEntityConfiguration.Length.ShouldBe(3);
            methodGetDefaultEntityConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var entityId = this.CreateType<int>();
            var siteId = this.CreateType<int>();
            var SearchType = this.CreateType<int>();
            var methodGetDefaultEntityConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            object[] parametersOfGetDefaultEntityConfiguration = { entityId, siteId, SearchType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_master>>(MethodGetDefaultEntityConfiguration, parametersOfGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes);

            // Assert
            parametersOfGetDefaultEntityConfiguration.ShouldNotBeNull();
            parametersOfGetDefaultEntityConfiguration.Length.ShouldBe(3);
            methodGetDefaultEntityConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var methodGetDefaultEntityConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultEntityConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var methodGetDefaultEntityConfigurationParametersTypes = new Type[] { typeof(int), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultEntityConfiguration, methodGetDefaultEntityConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultEntityConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultEntityConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultEntityConfiguration) (Return Type : List<navigator_entity_master>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultEntityConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultEntityConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultEntityConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetModulePrivilege_Method_Call_Internally(Type[] types)
        {
            var methodGetModulePrivilegeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilege, methodGetModulePrivilegeParametersTypes);
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);

            // Act
            Action executeAction = () => _profileManagerInstance.GetModulePrivilege();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetModulePrivilege();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            Type [] methodGetModulePrivilegeParametersTypes = null;
            object[] parametersOfGetModulePrivilege = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilege, methodGetModulePrivilegeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetModulePrivilege);
            var result2 = this.GetResultOfMethod<string>(MethodGetModulePrivilege, parametersOfGetModulePrivilege, methodGetModulePrivilegeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModulePrivilege.ShouldBeNull();
            methodGetModulePrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            Type [] methodGetModulePrivilegeParametersTypes = null;
            object[] parametersOfGetModulePrivilege = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetModulePrivilege, parametersOfGetModulePrivilege, methodGetModulePrivilegeParametersTypes);

            // Assert
            parametersOfGetModulePrivilege.ShouldBeNull();
            methodGetModulePrivilegeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            Type [] methodGetModulePrivilegeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilege, methodGetModulePrivilegeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModulePrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            Type [] methodGetModulePrivilegeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilege, methodGetModulePrivilegeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModulePrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilege) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetModulePrivilege_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilege);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilege, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetAllUIResources_Method_Call_Internally(Type[] types)
        {
            var methodGetAllUIResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);

            // Act
            Action executeAction = () => _profileManagerInstance.GetAllUIResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetAllUIResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;
            object[] parametersOfGetAllUIResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetAllUIResources);
            var result2 = this.GetResultOfMethod<string>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAllUIResources.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;
            object[] parametersOfGetAllUIResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            parametersOfGetAllUIResources.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_Internally(Type[] types)
        {
            var methodGetBatchUpdatableFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var isBrowseMode = this.CreateType<bool>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetBatchUpdatableFields(navigatorEntity, userId, isBrowseMode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var isBrowseMode = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetBatchUpdatableFields(navigatorEntity, userId, isBrowseMode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var isBrowseMode = this.CreateType<bool>();
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetBatchUpdatableFields = { navigatorEntity, userId, isBrowseMode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetBatchUpdatableFields);
            var result2 = this.GetResultOfMethod<string>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBatchUpdatableFields.ShouldNotBeNull();
            parametersOfGetBatchUpdatableFields.Length.ShouldBe(3);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var isBrowseMode = this.CreateType<bool>();
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            object[] parametersOfGetBatchUpdatableFields = { navigatorEntity, userId, isBrowseMode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBatchUpdatableFields, parametersOfGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdatableFields.ShouldNotBeNull();
            parametersOfGetBatchUpdatableFields.Length.ShouldBe(3);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var methodGetBatchUpdatableFieldsParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdatableFields, methodGetBatchUpdatableFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdatableFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdatableFields) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetBatchUpdatableFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdatableFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdatableFields, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDataGridProfile_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetDataGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var searchMode = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var isIncludeTransactionFields = this.CreateType<bool>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetDataGridProfile(navigatorEntity, userId, searchMode, queryId, isIncludeTransactionFields);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var searchMode = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var isIncludeTransactionFields = this.CreateType<bool>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDataGridProfile(navigatorEntity, userId, searchMode, queryId, isIncludeTransactionFields);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var searchMode = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var isIncludeTransactionFields = this.CreateType<bool>();
            var methodGetDataGridProfileParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(bool) };
            object[] parametersOfGetDataGridProfile = { navigatorEntity, userId, searchMode, queryId, isIncludeTransactionFields };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetDataGridProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetDataGridProfile, parametersOfGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataGridProfile.ShouldNotBeNull();
            parametersOfGetDataGridProfile.Length.ShouldBe(5);
            methodGetDataGridProfileParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var navigatorEntity = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var searchMode = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var isIncludeTransactionFields = this.CreateType<bool>();
            var methodGetDataGridProfileParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(bool) };
            object[] parametersOfGetDataGridProfile = { navigatorEntity, userId, searchMode, queryId, isIncludeTransactionFields };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDataGridProfile, parametersOfGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            parametersOfGetDataGridProfile.ShouldNotBeNull();
            parametersOfGetDataGridProfile.Length.ShouldBe(5);
            methodGetDataGridProfileParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var methodGetDataGridProfileParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataGridProfileParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var methodGetDataGridProfileParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataGridProfile, methodGetDataGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataGridProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridProfile, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridProfile) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridProfile_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridProfile, 1);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDataGridFields_Method_Call_Internally(Type[] types)
        {
            var methodGetDataGridFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDataGridFields, methodGetDataGridFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var navigatorEntityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var includeTransactionFieilds = this.CreateType<bool>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetDataGridFields(navigatorEntityId, userId, queryId, useType, includeTransactionFieilds);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var navigatorEntityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var includeTransactionFieilds = this.CreateType<bool>();
            var returnedValue = default(List<navigator_entity_field_master_ml_view>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDataGridFields(navigatorEntityId, userId, queryId, useType, includeTransactionFieilds);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var navigatorEntityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var includeTransactionFieilds = this.CreateType<bool>();
            var methodGetDataGridFieldsParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfGetDataGridFields = { navigatorEntityId, userId, queryId, useType, includeTransactionFieilds };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridFields, methodGetDataGridFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfGetDataGridFields);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetDataGridFields, parametersOfGetDataGridFields, methodGetDataGridFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataGridFields.ShouldNotBeNull();
            parametersOfGetDataGridFields.Length.ShouldBe(5);
            methodGetDataGridFieldsParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var navigatorEntityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var includeTransactionFieilds = this.CreateType<bool>();
            var methodGetDataGridFieldsParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfGetDataGridFields = { navigatorEntityId, userId, queryId, useType, includeTransactionFieilds };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetDataGridFields, parametersOfGetDataGridFields, methodGetDataGridFieldsParametersTypes);

            // Assert
            parametersOfGetDataGridFields.ShouldNotBeNull();
            parametersOfGetDataGridFields.Length.ShouldBe(5);
            methodGetDataGridFieldsParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var methodGetDataGridFieldsParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(int), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataGridFields, methodGetDataGridFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataGridFieldsParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var methodGetDataGridFieldsParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string), typeof(int), typeof(bool) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataGridFields, methodGetDataGridFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataGridFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataGridFields) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataGridFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataGridFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataGridFields, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetSystemDefaultDataGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var navigatorEntityID = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var isIncludeHiddenFields = this.CreateType<bool>();
            var methodGetSystemDefaultDataGridProfileParametersTypes = new Type[] { typeof(int), typeof(int), typeof(bool) };
            object[] parametersOfGetSystemDefaultDataGridProfile = { navigatorEntityID, useType, isIncludeHiddenFields };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfGetSystemDefaultDataGridProfile);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetSystemDefaultDataGridProfile, parametersOfGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemDefaultDataGridProfile.ShouldNotBeNull();
            parametersOfGetSystemDefaultDataGridProfile.Length.ShouldBe(3);
            methodGetSystemDefaultDataGridProfileParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var navigatorEntityID = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var isIncludeHiddenFields = this.CreateType<bool>();
            var methodGetSystemDefaultDataGridProfileParametersTypes = new Type[] { typeof(int), typeof(int), typeof(bool) };
            object[] parametersOfGetSystemDefaultDataGridProfile = { navigatorEntityID, useType, isIncludeHiddenFields };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetSystemDefaultDataGridProfile, parametersOfGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes);

            // Assert
            parametersOfGetSystemDefaultDataGridProfile.ShouldNotBeNull();
            parametersOfGetSystemDefaultDataGridProfile.Length.ShouldBe(3);
            methodGetSystemDefaultDataGridProfileParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var methodGetSystemDefaultDataGridProfileParametersTypes = new Type[] { typeof(int), typeof(int), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemDefaultDataGridProfileParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var methodGetSystemDefaultDataGridProfileParametersTypes = new Type[] { typeof(int), typeof(int), typeof(bool) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultDataGridProfile, methodGetSystemDefaultDataGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemDefaultDataGridProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultDataGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemDefaultDataGridProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultDataGridProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultDataGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultDataGridProfile, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultUserAccessParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetDefaultUserAccessParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetDefaultUserAccess = { entityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetDefaultUserAccess);
            var result2 = this.GetResultOfMethod<string>(MethodGetDefaultUserAccess, parametersOfGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultUserAccess.ShouldNotBeNull();
            parametersOfGetDefaultUserAccess.Length.ShouldBe(2);
            methodGetDefaultUserAccessParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetDefaultUserAccessParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetDefaultUserAccess = { entityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDefaultUserAccess, parametersOfGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes);

            // Assert
            parametersOfGetDefaultUserAccess.ShouldNotBeNull();
            parametersOfGetDefaultUserAccess.Length.ShouldBe(2);
            methodGetDefaultUserAccessParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var methodGetDefaultUserAccessParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultUserAccessParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var methodGetDefaultUserAccessParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserAccess, methodGetDefaultUserAccessParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultUserAccessParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserAccess, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserAccess) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDefaultUserAccess_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserAccess);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserAccess, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetAllFields_Method_Call_Internally(Type[] types)
        {
            var methodGetAllFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllFields, methodGetAllFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var navigatorEntityID = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetAllFieldsParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetAllFields = { navigatorEntityID, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFields, methodGetAllFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master>>(_profileManagerInstanceFixture, parametersOfGetAllFields);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master>>(MethodGetAllFields, parametersOfGetAllFields, methodGetAllFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAllFields.ShouldNotBeNull();
            parametersOfGetAllFields.Length.ShouldBe(2);
            methodGetAllFieldsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var navigatorEntityID = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetAllFieldsParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetAllFields = { navigatorEntityID, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master>>(MethodGetAllFields, parametersOfGetAllFields, methodGetAllFieldsParametersTypes);

            // Assert
            parametersOfGetAllFields.ShouldNotBeNull();
            parametersOfGetAllFields.Length.ShouldBe(2);
            methodGetAllFieldsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var methodGetAllFieldsParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllFields, methodGetAllFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAllFieldsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var methodGetAllFieldsParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllFields, methodGetAllFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllFields) (Return Type : List<navigator_entity_field_master>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetAllFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllFields, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetViewName_Method_Call_Internally(Type[] types)
        {
            var methodGetViewNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetViewName, methodGetViewNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var entityId = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetViewName(entityId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var entityId = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetViewName(entityId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var entityId = this.CreateType<int>();
            var methodGetViewNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetViewName = { entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewName, methodGetViewNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetViewName);
            var result2 = this.GetResultOfMethod<string>(MethodGetViewName, parametersOfGetViewName, methodGetViewNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetViewName.ShouldNotBeNull();
            parametersOfGetViewName.Length.ShouldBe(1);
            methodGetViewNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var entityId = this.CreateType<int>();
            var methodGetViewNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetViewName = { entityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetViewName, parametersOfGetViewName, methodGetViewNameParametersTypes);

            // Assert
            parametersOfGetViewName.ShouldNotBeNull();
            parametersOfGetViewName.Length.ShouldBe(1);
            methodGetViewNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var methodGetViewNameParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetViewName, methodGetViewNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetViewNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var methodGetViewNameParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetViewName, methodGetViewNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetViewNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetViewName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetViewName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetViewName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetViewName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityConfigurationForUserParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var sessionId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var resource = this.CreateType<string>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetEntityConfigurationForUser(sessionId, userId, entityId, queryId, useType, resource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var sessionId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var resource = this.CreateType<string>();
            var returnedValue = default(EntityConfiguration);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetEntityConfigurationForUser(sessionId, userId, entityId, queryId, useType, resource);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var sessionId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var resource = this.CreateType<string>();
            var methodGetEntityConfigurationForUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };
            object[] parametersOfGetEntityConfigurationForUser = { sessionId, userId, entityId, queryId, useType, resource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<EntityConfiguration>(_profileManagerInstanceFixture, parametersOfGetEntityConfigurationForUser);
            var result2 = this.GetResultOfMethod<EntityConfiguration>(MethodGetEntityConfigurationForUser, parametersOfGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityConfigurationForUser.ShouldNotBeNull();
            parametersOfGetEntityConfigurationForUser.Length.ShouldBe(6);
            methodGetEntityConfigurationForUserParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var sessionId = this.CreateType<string>();
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var queryId = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var resource = this.CreateType<string>();
            var methodGetEntityConfigurationForUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };
            object[] parametersOfGetEntityConfigurationForUser = { sessionId, userId, entityId, queryId, useType, resource };

            // Act
            Action currentAction = () => this.GetResultOfMethod<EntityConfiguration>(MethodGetEntityConfigurationForUser, parametersOfGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes);

            // Assert
            parametersOfGetEntityConfigurationForUser.ShouldNotBeNull();
            parametersOfGetEntityConfigurationForUser.Length.ShouldBe(6);
            methodGetEntityConfigurationForUserParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var methodGetEntityConfigurationForUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityConfigurationForUserParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var methodGetEntityConfigurationForUserParametersTypes = new Type[] { typeof(string), typeof(string), typeof(int), typeof(string), typeof(int), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityConfigurationForUser, methodGetEntityConfigurationForUserParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityConfigurationForUserParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityConfigurationForUser, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityConfigurationForUser) (Return Type : EntityConfiguration) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityConfigurationForUser_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityConfigurationForUser);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityConfigurationForUser, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetSystemDefaultSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var navigatorEntityId = this.CreateType<int>();
            var methodGetSystemDefaultSearchFilterProfileParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetSystemDefaultSearchFilterProfile = { navigatorEntityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfGetSystemDefaultSearchFilterProfile);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetSystemDefaultSearchFilterProfile, parametersOfGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemDefaultSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSystemDefaultSearchFilterProfile.Length.ShouldBe(1);
            methodGetSystemDefaultSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var navigatorEntityId = this.CreateType<int>();
            var methodGetSystemDefaultSearchFilterProfileParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetSystemDefaultSearchFilterProfile = { navigatorEntityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodGetSystemDefaultSearchFilterProfile, parametersOfGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes);

            // Assert
            parametersOfGetSystemDefaultSearchFilterProfile.ShouldNotBeNull();
            parametersOfGetSystemDefaultSearchFilterProfile.Length.ShouldBe(1);
            methodGetSystemDefaultSearchFilterProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var methodGetSystemDefaultSearchFilterProfileParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemDefaultSearchFilterProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var methodGetSystemDefaultSearchFilterProfileParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemDefaultSearchFilterProfile, methodGetSystemDefaultSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemDefaultSearchFilterProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemDefaultSearchFilterProfile) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSystemDefaultSearchFilterProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemDefaultSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemDefaultSearchFilterProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetFieldProperties_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFieldProperties, methodGetFieldPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var userId = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetFieldProperties = { userId, navigatorEntityId, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldProperties, methodGetFieldPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_user_field_property>>(_profileManagerInstanceFixture, parametersOfGetFieldProperties);
            var result2 = this.GetResultOfMethod<List<navigator_user_field_property>>(MethodGetFieldProperties, parametersOfGetFieldProperties, methodGetFieldPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetFieldProperties.ShouldNotBeNull();
            parametersOfGetFieldProperties.Length.ShouldBe(3);
            methodGetFieldPropertiesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var userId = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            object[] parametersOfGetFieldProperties = { userId, navigatorEntityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_user_field_property>>(MethodGetFieldProperties, parametersOfGetFieldProperties, methodGetFieldPropertiesParametersTypes);

            // Assert
            parametersOfGetFieldProperties.ShouldNotBeNull();
            parametersOfGetFieldProperties.Length.ShouldBe(3);
            methodGetFieldPropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var methodGetFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFieldProperties, methodGetFieldPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetFieldPropertiesParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var methodGetFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFieldProperties, methodGetFieldPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldProperties) (Return Type : List<navigator_user_field_property>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldProperties, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldIds) (Return Type : List<int>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetFieldIds_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldIdsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFieldIds, methodGetFieldIdsParametersTypes);
        }

        #endregion

        #region Method Call : (GetFieldIds) (Return Type : List<int>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldIds_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldIds);
            var navigatorEntityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var methodGetFieldIdsParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetFieldIds = { navigatorEntityId, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<int>>(MethodGetFieldIds, parametersOfGetFieldIds, methodGetFieldIdsParametersTypes);

            // Assert
            parametersOfGetFieldIds.ShouldNotBeNull();
            parametersOfGetFieldIds.Length.ShouldBe(2);
            methodGetFieldIdsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldIds) (Return Type : List<int>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldIds_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldIds);
            var methodGetFieldIdsParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFieldIds, methodGetFieldIdsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldIdsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldIds) (Return Type : List<int>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldIds_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldIds);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldIds, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldIds) (Return Type : List<int>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldIds_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldIds);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldIds, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_Internally(Type[] types)
        {
            var methodGetNavigatorEntityIDParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var navigatorEntity = this.CreateType<string>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetNavigatorEntityID(navigatorEntity);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var navigatorEntity = this.CreateType<string>();
            var methodGetNavigatorEntityIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNavigatorEntityID = { navigatorEntity };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, parametersOfGetNavigatorEntityID);
            var result2 = this.GetResultOfMethod<int>(MethodGetNavigatorEntityID, parametersOfGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNavigatorEntityID.ShouldNotBeNull();
            parametersOfGetNavigatorEntityID.Length.ShouldBe(1);
            methodGetNavigatorEntityIDParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var navigatorEntity = this.CreateType<string>();
            var methodGetNavigatorEntityIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNavigatorEntityID = { navigatorEntity };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, out exception1, parametersOfGetNavigatorEntityID);
            var result2 = this.GetResultOfMethod<int>(MethodGetNavigatorEntityID, parametersOfGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetNavigatorEntityID.ShouldNotBeNull();
            parametersOfGetNavigatorEntityID.Length.ShouldBe(1);
            methodGetNavigatorEntityIDParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var navigatorEntity = this.CreateType<string>();
            var methodGetNavigatorEntityIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetNavigatorEntityID = { navigatorEntity };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetNavigatorEntityID, parametersOfGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes);

            // Assert
            parametersOfGetNavigatorEntityID.ShouldNotBeNull();
            parametersOfGetNavigatorEntityID.Length.ShouldBe(1);
            methodGetNavigatorEntityIDParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var methodGetNavigatorEntityIDParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntityID, methodGetNavigatorEntityIDParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNavigatorEntityIDParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityID, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityID) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityID_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityID, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetEntityName_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityID = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetEntityName(entityID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityID = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetEntityName(entityID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityID = this.CreateType<int>();
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetEntityName = { entityID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, methodGetEntityNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetEntityName);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntityName, parametersOfGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityName.ShouldNotBeNull();
            parametersOfGetEntityName.Length.ShouldBe(1);
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var entityID = this.CreateType<int>();
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetEntityName = { entityID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntityName, parametersOfGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            parametersOfGetEntityName.ShouldNotBeNull();
            parametersOfGetEntityName.Length.ShouldBe(1);
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var methodGetEntityNameParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityName, methodGetEntityNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetEntityName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetDataType_Method_Call_Internally(Type[] types)
        {
            var methodGetDataTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDataType, methodGetDataTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var entityId = this.CreateType<int>();
            var fieldName = this.CreateType<string>();
            var useType = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetDataType(entityId, fieldName, useType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var entityId = this.CreateType<int>();
            var fieldName = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetDataType(entityId, fieldName, useType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var entityId = this.CreateType<int>();
            var fieldName = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var methodGetDataTypeParametersTypes = new Type[] { typeof(int), typeof(string), typeof(int) };
            object[] parametersOfGetDataType = { entityId, fieldName, useType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataType, methodGetDataTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetDataType);
            var result2 = this.GetResultOfMethod<string>(MethodGetDataType, parametersOfGetDataType, methodGetDataTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataType.ShouldNotBeNull();
            parametersOfGetDataType.Length.ShouldBe(3);
            methodGetDataTypeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var entityId = this.CreateType<int>();
            var fieldName = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var methodGetDataTypeParametersTypes = new Type[] { typeof(int), typeof(string), typeof(int) };
            object[] parametersOfGetDataType = { entityId, fieldName, useType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDataType, parametersOfGetDataType, methodGetDataTypeParametersTypes);

            // Assert
            parametersOfGetDataType.ShouldNotBeNull();
            parametersOfGetDataType.Length.ShouldBe(3);
            methodGetDataTypeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var methodGetDataTypeParametersTypes = new Type[] { typeof(int), typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataType, methodGetDataTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataTypeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var methodGetDataTypeParametersTypes = new Type[] { typeof(int), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataType, methodGetDataTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataType) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetDataType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataType, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetPolicy_Method_Call_Internally(Type[] types)
        {
            var methodGetPolicyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPolicy, methodGetPolicyParametersTypes);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var policyName = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var methodGetPolicyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetPolicy = { policyName, navigatorEntity };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicy, methodGetPolicyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfGetPolicy);
            var result2 = this.GetResultOfMethod<bool>(MethodGetPolicy, parametersOfGetPolicy, methodGetPolicyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPolicy.ShouldNotBeNull();
            parametersOfGetPolicy.Length.ShouldBe(2);
            methodGetPolicyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var policyName = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var methodGetPolicyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetPolicy = { policyName, navigatorEntity };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicy, methodGetPolicyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfGetPolicy);
            var result2 = this.GetResultOfMethod<bool>(MethodGetPolicy, parametersOfGetPolicy, methodGetPolicyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPolicy.ShouldNotBeNull();
            parametersOfGetPolicy.Length.ShouldBe(2);
            methodGetPolicyParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var policyName = this.CreateType<string>();
            var navigatorEntity = this.CreateType<string>();
            var methodGetPolicyParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetPolicy = { policyName, navigatorEntity };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetPolicy, parametersOfGetPolicy, methodGetPolicyParametersTypes);

            // Assert
            parametersOfGetPolicy.ShouldNotBeNull();
            parametersOfGetPolicy.Length.ShouldBe(2);
            methodGetPolicyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var methodGetPolicyParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPolicy, methodGetPolicyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPolicyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicy, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPolicy) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPolicy_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPolicy);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPolicy, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetFieldPosition_Method_Call_Internally(Type[] types)
        {
            var methodGetFieldPositionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFieldPosition, methodGetFieldPositionParametersTypes);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var fieldId = this.CreateType<int>();
            var methodGetFieldPositionParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetFieldPosition = { fieldId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldPosition, methodGetFieldPositionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, parametersOfGetFieldPosition);
            var result2 = this.GetResultOfMethod<int>(MethodGetFieldPosition, parametersOfGetFieldPosition, methodGetFieldPositionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFieldPosition.ShouldNotBeNull();
            parametersOfGetFieldPosition.Length.ShouldBe(1);
            methodGetFieldPositionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var fieldId = this.CreateType<int>();
            var methodGetFieldPositionParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetFieldPosition = { fieldId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldPosition, methodGetFieldPositionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, out exception1, parametersOfGetFieldPosition);
            var result2 = this.GetResultOfMethod<int>(MethodGetFieldPosition, parametersOfGetFieldPosition, methodGetFieldPositionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFieldPosition.ShouldNotBeNull();
            parametersOfGetFieldPosition.Length.ShouldBe(1);
            methodGetFieldPositionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var fieldId = this.CreateType<int>();
            var methodGetFieldPositionParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetFieldPosition = { fieldId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetFieldPosition, parametersOfGetFieldPosition, methodGetFieldPositionParametersTypes);

            // Assert
            parametersOfGetFieldPosition.ShouldNotBeNull();
            parametersOfGetFieldPosition.Length.ShouldBe(1);
            methodGetFieldPositionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var methodGetFieldPositionParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFieldPosition, methodGetFieldPositionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFieldPositionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldPosition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFieldPosition) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetFieldPosition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFieldPosition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFieldPosition, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetPropertyName_Method_Call_Internally(Type[] types)
        {
            var methodGetPropertyNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPropertyName, methodGetPropertyNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var propertyID = this.CreateType<int>();
            var methodGetPropertyNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetPropertyName = { propertyID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyName, methodGetPropertyNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetPropertyName);
            var result2 = this.GetResultOfMethod<string>(MethodGetPropertyName, parametersOfGetPropertyName, methodGetPropertyNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetPropertyName.ShouldNotBeNull();
            parametersOfGetPropertyName.Length.ShouldBe(1);
            methodGetPropertyNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var propertyID = this.CreateType<int>();
            var methodGetPropertyNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetPropertyName = { propertyID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetPropertyName, parametersOfGetPropertyName, methodGetPropertyNameParametersTypes);

            // Assert
            parametersOfGetPropertyName.ShouldNotBeNull();
            parametersOfGetPropertyName.Length.ShouldBe(1);
            methodGetPropertyNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var methodGetPropertyNameParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetPropertyName, methodGetPropertyNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetPropertyNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var methodGetPropertyNameParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPropertyName, methodGetPropertyNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetPropertyID_Method_Call_Internally(Type[] types)
        {
            var methodGetPropertyIDParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPropertyID, methodGetPropertyIDParametersTypes);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var propertyName = this.CreateType<string>();
            var methodGetPropertyIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPropertyID = { propertyName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyID, methodGetPropertyIDParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, parametersOfGetPropertyID);
            var result2 = this.GetResultOfMethod<int>(MethodGetPropertyID, parametersOfGetPropertyID, methodGetPropertyIDParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPropertyID.ShouldNotBeNull();
            parametersOfGetPropertyID.Length.ShouldBe(1);
            methodGetPropertyIDParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var propertyName = this.CreateType<string>();
            var methodGetPropertyIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPropertyID = { propertyName };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyID, methodGetPropertyIDParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, out exception1, parametersOfGetPropertyID);
            var result2 = this.GetResultOfMethod<int>(MethodGetPropertyID, parametersOfGetPropertyID, methodGetPropertyIDParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetPropertyID.ShouldNotBeNull();
            parametersOfGetPropertyID.Length.ShouldBe(1);
            methodGetPropertyIDParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var propertyName = this.CreateType<string>();
            var methodGetPropertyIDParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetPropertyID = { propertyName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetPropertyID, parametersOfGetPropertyID, methodGetPropertyIDParametersTypes);

            // Assert
            parametersOfGetPropertyID.ShouldNotBeNull();
            parametersOfGetPropertyID.Length.ShouldBe(1);
            methodGetPropertyIDParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var methodGetPropertyIDParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetPropertyID, methodGetPropertyIDParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetPropertyIDParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyID, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetPropertyID) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetPropertyID_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetPropertyID);
            var currentMethodInfo = this.GetMethodInfo(MethodGetPropertyID, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_Internally(Type[] types)
        {
            var methodGetOwnerTypeByEntityIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var entityID = this.CreateType<int>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetOwnerTypeByEntityId(entityID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var entityID = this.CreateType<int>();
            var methodGetOwnerTypeByEntityIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetOwnerTypeByEntityId = { entityID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, parametersOfGetOwnerTypeByEntityId);
            var result2 = this.GetResultOfMethod<int>(MethodGetOwnerTypeByEntityId, parametersOfGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOwnerTypeByEntityId.ShouldNotBeNull();
            parametersOfGetOwnerTypeByEntityId.Length.ShouldBe(1);
            methodGetOwnerTypeByEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var entityID = this.CreateType<int>();
            var methodGetOwnerTypeByEntityIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetOwnerTypeByEntityId = { entityID };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_profileManagerInstanceFixture, out exception1, parametersOfGetOwnerTypeByEntityId);
            var result2 = this.GetResultOfMethod<int>(MethodGetOwnerTypeByEntityId, parametersOfGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetOwnerTypeByEntityId.ShouldNotBeNull();
            parametersOfGetOwnerTypeByEntityId.Length.ShouldBe(1);
            methodGetOwnerTypeByEntityIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var entityID = this.CreateType<int>();
            var methodGetOwnerTypeByEntityIdParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetOwnerTypeByEntityId = { entityID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetOwnerTypeByEntityId, parametersOfGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes);

            // Assert
            parametersOfGetOwnerTypeByEntityId.ShouldNotBeNull();
            parametersOfGetOwnerTypeByEntityId.Length.ShouldBe(1);
            methodGetOwnerTypeByEntityIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var methodGetOwnerTypeByEntityIdParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOwnerTypeByEntityId, methodGetOwnerTypeByEntityIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOwnerTypeByEntityIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeByEntityId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOwnerTypeByEntityId) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetOwnerTypeByEntityId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOwnerTypeByEntityId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOwnerTypeByEntityId, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetPageSize) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetPageSize_Method_Call_Internally(Type[] types)
        {
            var methodGetPageSizeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetPageSize, methodGetPageSizeParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetXml_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_property_master>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_property_master>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_property_master>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_property_master>) };
            object[] parametersOfGetXml = { list };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_property_master>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_property_master>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetXml_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var maxRecords = this.CreateType<int>();
            var pageSize = this.CreateType<int>();
            var sortOrder = this.CreateType<string>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetXml(list, maxRecords, pageSize, sortOrder);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var maxRecords = this.CreateType<int>();
            var pageSize = this.CreateType<int>();
            var sortOrder = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetXml(list, maxRecords, pageSize, sortOrder);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var maxRecords = this.CreateType<int>();
            var pageSize = this.CreateType<int>();
            var sortOrder = this.CreateType<string>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(int), typeof(int), typeof(string) };
            object[] parametersOfGetXml = { list, maxRecords, pageSize, sortOrder };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(4);
            methodGetXmlParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var maxRecords = this.CreateType<int>();
            var pageSize = this.CreateType<int>();
            var sortOrder = this.CreateType<string>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(int), typeof(int), typeof(string) };
            object[] parametersOfGetXml = { list, maxRecords, pageSize, sortOrder };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(4);
            methodGetXmlParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(int), typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(int), typeof(int), typeof(string) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 1);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetXml_Method_Overloading_Of_2_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_2_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetXml(list);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_2_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetXml(list);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            object[] parametersOfGetXml = { list };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 2);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_2_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 2);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetXml_Method_Overloading_Of_3_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_3_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryID = this.CreateType<string>();

            // Act
            Action executeAction = () => _profileManagerInstance.GetXml(list, queryID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_DirectCall_Overloading_Of_3_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryID = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetXml(list, queryID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryID = this.CreateType<string>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string) };
            object[] parametersOfGetXml = { list, queryID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(2);
            methodGetXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryID = this.CreateType<string>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string) };
            object[] parametersOfGetXml = { list, queryID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(2);
            methodGetXmlParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 3);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_3_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 3);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateSortOrder_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSortOrderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSortOrder, methodUpdateSortOrderParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSortOrder_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSortOrder);
            var document = this.CreateType<XmlDocument>();
            var sortOrder = this.CreateType<string>();
            var methodUpdateSortOrderParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfUpdateSortOrder = { document, sortOrder };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSortOrder, methodUpdateSortOrderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfUpdateSortOrder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateSortOrder.ShouldNotBeNull();
            parametersOfUpdateSortOrder.Length.ShouldBe(2);
            methodUpdateSortOrderParametersTypes.Length.ShouldBe(2);
            methodUpdateSortOrderParametersTypes.Length.ShouldBe(parametersOfUpdateSortOrder.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSortOrder_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSortOrder);
            var document = this.CreateType<XmlDocument>();
            var sortOrder = this.CreateType<string>();
            var methodUpdateSortOrderParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };
            object[] parametersOfUpdateSortOrder = { document, sortOrder };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateSortOrder, parametersOfUpdateSortOrder, methodUpdateSortOrderParametersTypes);

            // Assert
            parametersOfUpdateSortOrder.ShouldNotBeNull();
            parametersOfUpdateSortOrder.Length.ShouldBe(2);
            methodUpdateSortOrderParametersTypes.Length.ShouldBe(2);
            methodUpdateSortOrderParametersTypes.Length.ShouldBe(parametersOfUpdateSortOrder.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSortOrder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSortOrder);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSortOrder, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSortOrder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSortOrder);
            var methodUpdateSortOrderParametersTypes = new Type[] { typeof(XmlDocument), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSortOrder, methodUpdateSortOrderParametersTypes);

            // Assert
            methodUpdateSortOrderParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSortOrder) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateSortOrder_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSortOrder);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSortOrder, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_Internally(Type[] types)
        {
            var methodApplyDisplayPermissionForSearchFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var methodApplyDisplayPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };
            object[] parametersOfApplyDisplayPermissionForSearchFilter = { fieldList, resource, fieldState };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfApplyDisplayPermissionForSearchFilter);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyDisplayPermissionForSearchFilter, parametersOfApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyDisplayPermissionForSearchFilter.ShouldNotBeNull();
            parametersOfApplyDisplayPermissionForSearchFilter.Length.ShouldBe(3);
            methodApplyDisplayPermissionForSearchFilterParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var methodApplyDisplayPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };
            object[] parametersOfApplyDisplayPermissionForSearchFilter = { fieldList, resource, fieldState };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyDisplayPermissionForSearchFilter, parametersOfApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes);

            // Assert
            parametersOfApplyDisplayPermissionForSearchFilter.ShouldNotBeNull();
            parametersOfApplyDisplayPermissionForSearchFilter.Length.ShouldBe(3);
            methodApplyDisplayPermissionForSearchFilterParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var methodApplyDisplayPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyDisplayPermissionForSearchFilterParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var methodApplyDisplayPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermissionForSearchFilter, methodApplyDisplayPermissionForSearchFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyDisplayPermissionForSearchFilterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermissionForSearchFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyDisplayPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermissionForSearchFilter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermissionForSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermissionForSearchFilter, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_Internally(Type[] types)
        {
            var methodApplyFieldPermissionForSearchFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var methodApplyFieldPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            object[] parametersOfApplyFieldPermissionForSearchFilter = { fieldList };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfApplyFieldPermissionForSearchFilter);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyFieldPermissionForSearchFilter, parametersOfApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyFieldPermissionForSearchFilter.ShouldNotBeNull();
            parametersOfApplyFieldPermissionForSearchFilter.Length.ShouldBe(1);
            methodApplyFieldPermissionForSearchFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var methodApplyFieldPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            object[] parametersOfApplyFieldPermissionForSearchFilter = { fieldList };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyFieldPermissionForSearchFilter, parametersOfApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes);

            // Assert
            parametersOfApplyFieldPermissionForSearchFilter.ShouldNotBeNull();
            parametersOfApplyFieldPermissionForSearchFilter.Length.ShouldBe(1);
            methodApplyFieldPermissionForSearchFilterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var methodApplyFieldPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyFieldPermissionForSearchFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var methodApplyFieldPermissionForSearchFilterParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyFieldPermissionForSearchFilter, methodApplyFieldPermissionForSearchFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyFieldPermissionForSearchFilterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermissionForSearchFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyFieldPermissionForSearchFilter) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermissionForSearchFilter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermissionForSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermissionForSearchFilter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyFieldPermission_Method_Call_Internally(Type[] types)
        {
            var methodApplyFieldPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyFieldPermission, methodApplyFieldPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermission_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var includeTransactionField = this.CreateType<bool>();
            var methodApplyFieldPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(bool) };
            object[] parametersOfApplyFieldPermission = { fieldList, includeTransactionField };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermission, methodApplyFieldPermissionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfApplyFieldPermission);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyFieldPermission.ShouldNotBeNull();
            parametersOfApplyFieldPermission.Length.ShouldBe(2);
            methodApplyFieldPermissionParametersTypes.Length.ShouldBe(2);
            methodApplyFieldPermissionParametersTypes.Length.ShouldBe(parametersOfApplyFieldPermission.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermission_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var includeTransactionField = this.CreateType<bool>();
            var methodApplyFieldPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(bool) };
            object[] parametersOfApplyFieldPermission = { fieldList, includeTransactionField };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyFieldPermission, parametersOfApplyFieldPermission, methodApplyFieldPermissionParametersTypes);

            // Assert
            parametersOfApplyFieldPermission.ShouldNotBeNull();
            parametersOfApplyFieldPermission.Length.ShouldBe(2);
            methodApplyFieldPermissionParametersTypes.Length.ShouldBe(2);
            methodApplyFieldPermissionParametersTypes.Length.ShouldBe(parametersOfApplyFieldPermission.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermission, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermission);
            var methodApplyFieldPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyFieldPermission, methodApplyFieldPermissionParametersTypes);

            // Assert
            methodApplyFieldPermissionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyFieldPermission) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyFieldPermission_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyFieldPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyFieldPermission, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_Internally(Type[] types)
        {
            var methodApplyDisplayPermissionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var includeTransactionFields = this.CreateType<bool>();

            // Act
            Action executeAction = () => _profileManagerInstance.ApplyDisplayPermission(fieldList, resource, fieldState, includeTransactionFields);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var includeTransactionFields = this.CreateType<bool>();
            var returnedValue = default(List<navigator_entity_field_master_ml_view>);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.ApplyDisplayPermission(fieldList, resource, fieldState, includeTransactionFields);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var includeTransactionFields = this.CreateType<bool>();
            var methodApplyDisplayPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfApplyDisplayPermission = { fieldList, resource, fieldState, includeTransactionFields };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfApplyDisplayPermission);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyDisplayPermission, parametersOfApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyDisplayPermission.ShouldNotBeNull();
            parametersOfApplyDisplayPermission.Length.ShouldBe(4);
            methodApplyDisplayPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var resource = this.CreateType<string>();
            var fieldState = this.CreateType<int>();
            var includeTransactionFields = this.CreateType<bool>();
            var methodApplyDisplayPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfApplyDisplayPermission = { fieldList, resource, fieldState, includeTransactionFields };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyDisplayPermission, parametersOfApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes);

            // Assert
            parametersOfApplyDisplayPermission.ShouldNotBeNull();
            parametersOfApplyDisplayPermission.Length.ShouldBe(4);
            methodApplyDisplayPermissionParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var methodApplyDisplayPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyDisplayPermissionParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var methodApplyDisplayPermissionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int), typeof(bool) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyDisplayPermission, methodApplyDisplayPermissionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyDisplayPermissionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermission, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyDisplayPermission) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyDisplayPermission_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyDisplayPermission);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyDisplayPermission, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodApplyUserFieldsConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var baseFilterList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var userFilterList = this.CreateType<List<UserConfigurationView>>();
            var filterType = this.CreateType<int>();
            var methodApplyUserFieldsConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<UserConfigurationView>), typeof(int) };
            object[] parametersOfApplyUserFieldsConfiguration = { baseFilterList, userFilterList, filterType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfApplyUserFieldsConfiguration);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyUserFieldsConfiguration, parametersOfApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyUserFieldsConfiguration.ShouldNotBeNull();
            parametersOfApplyUserFieldsConfiguration.Length.ShouldBe(3);
            methodApplyUserFieldsConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var baseFilterList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var userFilterList = this.CreateType<List<UserConfigurationView>>();
            var filterType = this.CreateType<int>();
            var methodApplyUserFieldsConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<UserConfigurationView>), typeof(int) };
            object[] parametersOfApplyUserFieldsConfiguration = { baseFilterList, userFilterList, filterType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyUserFieldsConfiguration, parametersOfApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes);

            // Assert
            parametersOfApplyUserFieldsConfiguration.ShouldNotBeNull();
            parametersOfApplyUserFieldsConfiguration.Length.ShouldBe(3);
            methodApplyUserFieldsConfigurationParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var methodApplyUserFieldsConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<UserConfigurationView>), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyUserFieldsConfigurationParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var methodApplyUserFieldsConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<UserConfigurationView>), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyUserFieldsConfiguration, methodApplyUserFieldsConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyUserFieldsConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserFieldsConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyUserFieldsConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserFieldsConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserFieldsConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserFieldsConfiguration, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodApplyUserQueryConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var baseFilterList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryFilterList = this.CreateType<List<QueryConfigurationView>>();
            var methodApplyUserQueryConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<QueryConfigurationView>) };
            object[] parametersOfApplyUserQueryConfiguration = { baseFilterList, queryFilterList };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<navigator_entity_field_master_ml_view>>(_profileManagerInstanceFixture, parametersOfApplyUserQueryConfiguration);
            var result2 = this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyUserQueryConfiguration, parametersOfApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyUserQueryConfiguration.ShouldNotBeNull();
            parametersOfApplyUserQueryConfiguration.Length.ShouldBe(2);
            methodApplyUserQueryConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var baseFilterList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var queryFilterList = this.CreateType<List<QueryConfigurationView>>();
            var methodApplyUserQueryConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<QueryConfigurationView>) };
            object[] parametersOfApplyUserQueryConfiguration = { baseFilterList, queryFilterList };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<navigator_entity_field_master_ml_view>>(MethodApplyUserQueryConfiguration, parametersOfApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes);

            // Assert
            parametersOfApplyUserQueryConfiguration.ShouldNotBeNull();
            parametersOfApplyUserQueryConfiguration.Length.ShouldBe(2);
            methodApplyUserQueryConfigurationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var methodApplyUserQueryConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<QueryConfigurationView>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyUserQueryConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var methodApplyUserQueryConfigurationParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<QueryConfigurationView>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyUserQueryConfiguration, methodApplyUserQueryConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyUserQueryConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserQueryConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyUserQueryConfiguration) (Return Type : List<navigator_entity_field_master_ml_view>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserQueryConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserQueryConfiguration, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyUserSelection_Method_Call_Internally(Type[] types)
        {
            var methodApplyUserSelectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyUserSelection, methodApplyUserSelectionParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserSelection_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserSelection);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var filterFields = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var methodApplyUserSelectionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };
            object[] parametersOfApplyUserSelection = { fieldList, filterFields, useType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserSelection, methodApplyUserSelectionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfApplyUserSelection);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyUserSelection.ShouldNotBeNull();
            parametersOfApplyUserSelection.Length.ShouldBe(3);
            methodApplyUserSelectionParametersTypes.Length.ShouldBe(3);
            methodApplyUserSelectionParametersTypes.Length.ShouldBe(parametersOfApplyUserSelection.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserSelection_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserSelection);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var filterFields = this.CreateType<string>();
            var useType = this.CreateType<int>();
            var methodApplyUserSelectionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };
            object[] parametersOfApplyUserSelection = { fieldList, filterFields, useType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyUserSelection, parametersOfApplyUserSelection, methodApplyUserSelectionParametersTypes);

            // Assert
            parametersOfApplyUserSelection.ShouldNotBeNull();
            parametersOfApplyUserSelection.Length.ShouldBe(3);
            methodApplyUserSelectionParametersTypes.Length.ShouldBe(3);
            methodApplyUserSelectionParametersTypes.Length.ShouldBe(parametersOfApplyUserSelection.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserSelection_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserSelection);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserSelection, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserSelection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserSelection);
            var methodApplyUserSelectionParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(string), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyUserSelection, methodApplyUserSelectionParametersTypes);

            // Assert
            methodApplyUserSelectionParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyUserSelection) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyUserSelection_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyUserSelection);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyUserSelection, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ApplyProperties_Method_Call_Internally(Type[] types)
        {
            var methodApplyPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyProperties, methodApplyPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyProperties);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var propertyList = this.CreateType<List<navigator_user_field_property>>();
            var methodApplyPropertiesParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<navigator_user_field_property>) };
            object[] parametersOfApplyProperties = { fieldList, propertyList };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyProperties, methodApplyPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfApplyProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfApplyProperties.ShouldNotBeNull();
            parametersOfApplyProperties.Length.ShouldBe(2);
            methodApplyPropertiesParametersTypes.Length.ShouldBe(2);
            methodApplyPropertiesParametersTypes.Length.ShouldBe(parametersOfApplyProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyProperties);
            var fieldList = this.CreateType<List<navigator_entity_field_master_ml_view>>();
            var propertyList = this.CreateType<List<navigator_user_field_property>>();
            var methodApplyPropertiesParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<navigator_user_field_property>) };
            object[] parametersOfApplyProperties = { fieldList, propertyList };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodApplyProperties, parametersOfApplyProperties, methodApplyPropertiesParametersTypes);

            // Assert
            parametersOfApplyProperties.ShouldNotBeNull();
            parametersOfApplyProperties.Length.ShouldBe(2);
            methodApplyPropertiesParametersTypes.Length.ShouldBe(2);
            methodApplyPropertiesParametersTypes.Length.ShouldBe(parametersOfApplyProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyProperties, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyProperties);
            var methodApplyPropertiesParametersTypes = new Type[] { typeof(List<navigator_entity_field_master_ml_view>), typeof(List<navigator_user_field_property>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyProperties, methodApplyPropertiesParametersTypes);

            // Assert
            methodApplyPropertiesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ApplyProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateFieldProperties_Method_Call_Internally(Type[] types)
        {
            var methodUpdateFieldPropertiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateFieldProperties, methodUpdateFieldPropertiesParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldProperties);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var fieldId = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();
            var methodUpdateFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(Hashtable) };
            object[] parametersOfUpdateFieldProperties = { userId, entityId, fieldId, ParameterCollection };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldProperties, methodUpdateFieldPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfUpdateFieldProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateFieldProperties.ShouldNotBeNull();
            parametersOfUpdateFieldProperties.Length.ShouldBe(4);
            methodUpdateFieldPropertiesParametersTypes.Length.ShouldBe(4);
            methodUpdateFieldPropertiesParametersTypes.Length.ShouldBe(parametersOfUpdateFieldProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldProperties);
            var userId = this.CreateType<string>();
            var entityId = this.CreateType<int>();
            var fieldId = this.CreateType<int>();
            var ParameterCollection = this.CreateType<Hashtable>();
            var methodUpdateFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(Hashtable) };
            object[] parametersOfUpdateFieldProperties = { userId, entityId, fieldId, ParameterCollection };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateFieldProperties, parametersOfUpdateFieldProperties, methodUpdateFieldPropertiesParametersTypes);

            // Assert
            parametersOfUpdateFieldProperties.ShouldNotBeNull();
            parametersOfUpdateFieldProperties.Length.ShouldBe(4);
            methodUpdateFieldPropertiesParametersTypes.Length.ShouldBe(4);
            methodUpdateFieldPropertiesParametersTypes.Length.ShouldBe(parametersOfUpdateFieldProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldProperties, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldProperties);
            var methodUpdateFieldPropertiesParametersTypes = new Type[] { typeof(string), typeof(int), typeof(int), typeof(Hashtable) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateFieldProperties, methodUpdateFieldPropertiesParametersTypes);

            // Assert
            methodUpdateFieldPropertiesParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateFieldProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateFieldProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateFieldProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateFieldProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryConfiguration = { queryId, entityId, searchType, xmlDoc };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfUpdateQueryConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateQueryConfiguration, parametersOfUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateQueryConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryConfiguration.Length.ShouldBe(4);
            methodUpdateQueryConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryConfiguration = { queryId, entityId, searchType, xmlDoc };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfUpdateQueryConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateQueryConfiguration, parametersOfUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateQueryConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryConfiguration.Length.ShouldBe(4);
            methodUpdateQueryConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var searchType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryConfiguration = { queryId, entityId, searchType, xmlDoc };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateQueryConfiguration, parametersOfUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes);

            // Assert
            parametersOfUpdateQueryConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryConfiguration.Length.ShouldBe(4);
            methodUpdateQueryConfigurationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var methodUpdateQueryConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryConfiguration, methodUpdateQueryConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryConfiguration) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryConfiguration, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryFieldConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryFieldConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryFieldConfiguration = { queryId, entityId, useType, xmlDoc };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, parametersOfUpdateQueryFieldConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateQueryFieldConfiguration, parametersOfUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateQueryFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryFieldConfiguration.Length.ShouldBe(4);
            methodUpdateQueryFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryFieldConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryFieldConfiguration = { queryId, entityId, useType, xmlDoc };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_profileManagerInstanceFixture, out exception1, parametersOfUpdateQueryFieldConfiguration);
            var result2 = this.GetResultOfMethod<bool>(MethodUpdateQueryFieldConfiguration, parametersOfUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfUpdateQueryFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryFieldConfiguration.Length.ShouldBe(4);
            methodUpdateQueryFieldConfigurationParametersTypes.Length.ShouldBe(4);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var useType = this.CreateType<int>();
            var xmlDoc = this.CreateType<XmlDocument>();
            var methodUpdateQueryFieldConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            object[] parametersOfUpdateQueryFieldConfiguration = { queryId, entityId, useType, xmlDoc };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodUpdateQueryFieldConfiguration, parametersOfUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes);

            // Assert
            parametersOfUpdateQueryFieldConfiguration.ShouldNotBeNull();
            parametersOfUpdateQueryFieldConfiguration.Length.ShouldBe(4);
            methodUpdateQueryFieldConfigurationParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var methodUpdateQueryFieldConfigurationParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(int), typeof(XmlDocument) };
            const int parametersCount = 4;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryFieldConfiguration, methodUpdateQueryFieldConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryFieldConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryFieldConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQueryFieldConfiguration) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_UpdateQueryFieldConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryFieldConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryFieldConfiguration, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_Internally(Type[] types)
        {
            var methodReplaceCharWithCharParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodReplaceCharWithChar, methodReplaceCharWithCharParametersTypes);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceCharWithChar);
            var text = this.CreateType<string>();
            var index = this.CreateType<int>();
            var charToUse = this.CreateType<char>();
            var methodReplaceCharWithCharParametersTypes = new Type[] { typeof(string), typeof(int), typeof(char) };
            object[] parametersOfReplaceCharWithChar = { text, index, charToUse };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodReplaceCharWithChar, methodReplaceCharWithCharParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_profileManagerInstanceFixture, parametersOfReplaceCharWithChar);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfReplaceCharWithChar.ShouldNotBeNull();
            parametersOfReplaceCharWithChar.Length.ShouldBe(3);
            methodReplaceCharWithCharParametersTypes.Length.ShouldBe(3);
            methodReplaceCharWithCharParametersTypes.Length.ShouldBe(parametersOfReplaceCharWithChar.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceCharWithChar);
            var text = this.CreateType<string>();
            var index = this.CreateType<int>();
            var charToUse = this.CreateType<char>();
            var methodReplaceCharWithCharParametersTypes = new Type[] { typeof(string), typeof(int), typeof(char) };
            object[] parametersOfReplaceCharWithChar = { text, index, charToUse };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodReplaceCharWithChar, parametersOfReplaceCharWithChar, methodReplaceCharWithCharParametersTypes);

            // Assert
            parametersOfReplaceCharWithChar.ShouldNotBeNull();
            parametersOfReplaceCharWithChar.Length.ShouldBe(3);
            methodReplaceCharWithCharParametersTypes.Length.ShouldBe(3);
            methodReplaceCharWithCharParametersTypes.Length.ShouldBe(parametersOfReplaceCharWithChar.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceCharWithChar);
            var currentMethodInfo = this.GetMethodInfo(MethodReplaceCharWithChar, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceCharWithChar);
            var methodReplaceCharWithCharParametersTypes = new Type[] { typeof(string), typeof(int), typeof(char) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodReplaceCharWithChar, methodReplaceCharWithCharParametersTypes);

            // Assert
            methodReplaceCharWithCharParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ReplaceCharWithChar) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ReplaceCharWithChar_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodReplaceCharWithChar);
            var currentMethodInfo = this.GetMethodInfo(MethodReplaceCharWithChar, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetSearchEntities_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchEntitiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchEntities, methodGetSearchEntitiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);

            // Act
            Action executeAction = () => _profileManagerInstance.GetSearchEntities();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetSearchEntities();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            Type [] methodGetSearchEntitiesParametersTypes = null;
            object[] parametersOfGetSearchEntities = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchEntities, methodGetSearchEntitiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetSearchEntities);
            var result2 = this.GetResultOfMethod<string>(MethodGetSearchEntities, parametersOfGetSearchEntities, methodGetSearchEntitiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchEntities.ShouldBeNull();
            methodGetSearchEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            Type [] methodGetSearchEntitiesParametersTypes = null;
            object[] parametersOfGetSearchEntities = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSearchEntities, parametersOfGetSearchEntities, methodGetSearchEntitiesParametersTypes);

            // Assert
            parametersOfGetSearchEntities.ShouldBeNull();
            methodGetSearchEntitiesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            Type [] methodGetSearchEntitiesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchEntities, methodGetSearchEntitiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            Type [] methodGetSearchEntitiesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchEntities, methodGetSearchEntitiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchEntities) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchEntities_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchEntities);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchEntities, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetXml_Method_Overloading_Of_4_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var entites = this.CreateType<List<navigator_entity_master_ml_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_master_ml_view>) };
            object[] parametersOfGetXml = { entites };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfGetXml);
            var result2 = this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var entites = this.CreateType<List<navigator_entity_master_ml_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_master_ml_view>) };
            object[] parametersOfGetXml = { entites };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetXml, parametersOfGetXml, methodGetXmlParametersTypes);

            // Assert
            parametersOfGetXml.ShouldNotBeNull();
            parametersOfGetXml.Length.ShouldBe(1);
            methodGetXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_master_ml_view>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetXmlParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<navigator_entity_master_ml_view>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetXmlParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 4);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetXml_Method_Call_Overloading_Of_4_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, 4);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_Internally(Type[] types)
        {
            var methodValidateMaxRecordsProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);

            // Act
            Action executeAction = () => _profileManagerInstance.ValidateMaxRecordsProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.ValidateMaxRecordsProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            Type [] methodValidateMaxRecordsProfileParametersTypes = null;
            object[] parametersOfValidateMaxRecordsProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_profileManagerInstanceFixture, parametersOfValidateMaxRecordsProfile);
            var result2 = this.GetResultOfMethod<string>(MethodValidateMaxRecordsProfile, parametersOfValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidateMaxRecordsProfile.ShouldBeNull();
            methodValidateMaxRecordsProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            Type [] methodValidateMaxRecordsProfileParametersTypes = null;
            object[] parametersOfValidateMaxRecordsProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodValidateMaxRecordsProfile, parametersOfValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes);

            // Assert
            parametersOfValidateMaxRecordsProfile.ShouldBeNull();
            methodValidateMaxRecordsProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            Type [] methodValidateMaxRecordsProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateMaxRecordsProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            Type [] methodValidateMaxRecordsProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateMaxRecordsProfile, methodValidateMaxRecordsProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateMaxRecordsProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMaxRecordsProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_ValidateMaxRecordsProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMaxRecordsProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateMaxRecordsProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMaxPageSizeProfile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_ValidateMaxPageSizeProfile_Method_Call_Internally(Type[] types)
        {
            var methodValidateMaxPageSizeProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateMaxPageSizeProfile, methodValidateMaxPageSizeProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetSearchExecuteMode_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchExecuteModeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchExecuteMode, methodGetSearchExecuteModeParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchExecuteMode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchExecuteMode);

            // Act
            Action executeAction = () => _profileManagerInstance.GetSearchExecuteMode();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchExecuteMode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchExecuteMode);
            var returnedValue = default(bool?);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetSearchExecuteMode();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchExecuteMode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchExecuteMode);
            Type [] methodGetSearchExecuteModeParametersTypes = null;
            object[] parametersOfGetSearchExecuteMode = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool?>(MethodGetSearchExecuteMode, parametersOfGetSearchExecuteMode, methodGetSearchExecuteModeParametersTypes);

            // Assert
            parametersOfGetSearchExecuteMode.ShouldBeNull();
            methodGetSearchExecuteModeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchExecuteMode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchExecuteMode);
            Type [] methodGetSearchExecuteModeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchExecuteMode, methodGetSearchExecuteModeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchExecuteModeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchExecuteMode) (Return Type : bool?) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSearchExecuteMode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchExecuteMode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchExecuteMode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetSelectColumnNames_Method_Call_Internally(Type[] types)
        {
            var methodGetSelectColumnNamesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);

            // Act
            Action executeAction = () => _profileManagerInstance.GetSelectColumnNames();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetSelectColumnNames();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            Type [] methodGetSelectColumnNamesParametersTypes = null;
            object[] parametersOfGetSelectColumnNames = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_profileManagerInstanceFixture, parametersOfGetSelectColumnNames);
            var result2 = this.GetResultOfMethod<string[]>(MethodGetSelectColumnNames, parametersOfGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSelectColumnNames.ShouldBeNull();
            methodGetSelectColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            Type [] methodGetSelectColumnNamesParametersTypes = null;
            object[] parametersOfGetSelectColumnNames = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodGetSelectColumnNames, parametersOfGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes);

            // Assert
            parametersOfGetSelectColumnNames.ShouldBeNull();
            methodGetSelectColumnNamesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            Type [] methodGetSelectColumnNamesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSelectColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            Type [] methodGetSelectColumnNamesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSelectColumnNames, methodGetSelectColumnNamesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSelectColumnNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSelectColumnNames) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetSelectColumnNames_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSelectColumnNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSelectColumnNames, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_Internally(Type[] types)
        {
            var methodGetNavigatorEntityRecordByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);

            // Act
            Action executeAction = () => _profileManagerInstance.GetNavigatorEntityRecordByName();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            var returnedValue = default(navigator_entity_master_ml_view);

            // Act
            Action executeAction = () => returnedValue = _profileManagerInstance.GetNavigatorEntityRecordByName();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            Type [] methodGetNavigatorEntityRecordByNameParametersTypes = null;
            object[] parametersOfGetNavigatorEntityRecordByName = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<navigator_entity_master_ml_view>(_profileManagerInstanceFixture, parametersOfGetNavigatorEntityRecordByName);
            var result2 = this.GetResultOfMethod<navigator_entity_master_ml_view>(MethodGetNavigatorEntityRecordByName, parametersOfGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNavigatorEntityRecordByName.ShouldBeNull();
            methodGetNavigatorEntityRecordByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            Type [] methodGetNavigatorEntityRecordByNameParametersTypes = null;
            object[] parametersOfGetNavigatorEntityRecordByName = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<navigator_entity_master_ml_view>(MethodGetNavigatorEntityRecordByName, parametersOfGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes);

            // Assert
            parametersOfGetNavigatorEntityRecordByName.ShouldBeNull();
            methodGetNavigatorEntityRecordByNameParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            Type [] methodGetNavigatorEntityRecordByNameParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNavigatorEntityRecordByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            Type [] methodGetNavigatorEntityRecordByNameParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntityRecordByName, methodGetNavigatorEntityRecordByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNavigatorEntityRecordByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntityRecordByName) (Return Type : navigator_entity_master_ml_view) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProfileManager_GetNavigatorEntityRecordByName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntityRecordByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntityRecordByName, 0);

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