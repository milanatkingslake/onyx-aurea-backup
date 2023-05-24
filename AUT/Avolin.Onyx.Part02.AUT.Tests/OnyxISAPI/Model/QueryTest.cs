using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Query" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Query" />)
        /// </summary>
        public QueryTest() : base(typeof(Query))
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

        #region General Initializer : Class (Query) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryInstanceType;
        private Query _queryInstance;
        private Query _queryInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Query" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryInstanceType = typeof(Query);
            _queryInstanceFixture = this.Create<Query>(false);
            _queryInstance = _queryInstanceFixture ?? this.Create<Query>(true);
            CurrentInstance = _queryInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Query) Initializer

        #region Methods

        private const string MethodCreateQuery = "CreateQuery";
        private const string MethodUpdateQuery = "UpdateQuery";
        private const string MethodUpdatePostionForQuery = "UpdatePostionForQuery";
        private const string MethodRenameQuery = "RenameQuery";
        private const string MethodDeleteQuery = "DeleteQuery";
        private const string MethodMoveQuery = "MoveQuery";
        private const string MethodGetQueries = "GetQueries";
        private const string MethodGetQueryResults = "GetQueryResults";
        private const string MethodGetQueryTree = "GetQueryTree";
        private const string MethodGetQueryData = "GetQueryData";
        private const string MethodGetHomePageQueries = "GetHomePageQueries";
        private const string MethodGetHomePageQueriesById = "GetHomePageQueriesById";
        private const string MethodGetHomePageConfig = "GetHomePageConfig";
        private const string MethodSaveHomePageConfig = "SaveHomePageConfig";
        private const string MethodGetBookMarks = "GetBookMarks";
        private const string MethodCreateBookMark = "CreateBookMark";
        private const string MethodRemoveBookMark = "RemoveBookMark";
        private const string MethodCreateHomePageQuery = "CreateHomePageQuery";
        private const string MethodRemoveHomePageQuery = "RemoveHomePageQuery";
        private const string MethodSaveALLQuery = "SaveALLQuery";
        private const string MethodRemoveQuery = "RemoveQuery";
        private const string MethodCreateMobileBookMark = "CreateMobileBookMark";
        private const string MethodRemoveMobileBookMark = "RemoveMobileBookMark";
        private const string MethodIsDisabledField = "IsDisabledField";
        private const string MethodGetSearchFiltersOfSavedQuery = "GetSearchFiltersOfSavedQuery";
        private const string MethodGetXml = "GetXml";
        private const string MethodGetQueryConfiguration = "GetQueryConfiguration";
        private const string MethodIsHomePageQuery = "IsHomePageQuery";
        private const string MethodGetMaxSequenceIndex = "GetMaxSequenceIndex";
        private const string MethodIsMobileBookMarkQuery = "IsMobileBookMarkQuery";
        private const string MethodIsMobileBookMarkEntity = "IsMobileBookMarkEntity";
        private const string MethodIsBookMarkQuery = "IsBookMarkQuery";
        private const string MethodApplyPermissionForQueryParameters = "ApplyPermissionForQueryParameters";
        private const string MethodInsertQueryRGConfig = "InsertQueryRGConfig";
        private const string MethodUpdateQueryRGConfig = "UpdateQueryRGConfig";
        private const string MethodInsertQueryEntityConfig = "InsertQueryEntityConfig";
        private const string MethodUpdateQueryEntityConfig = "UpdateQueryEntityConfig";
        private const string MethodValidateMobileBookmark = "ValidateMobileBookmark";
        private const string MethodGetLboObjectName = "GetLboObjectName";
        private const string MethodIsQueryExist = "IsQueryExist";
        private const string MethodGetProtectionMode = "GetProtectionMode";
        private const string MethodGetRootFolder = "GetRootFolder";
        private const string MethodDeleteFolder = "DeleteFolder";
        private const string MethodGetRecordCount = "GetRecordCount";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";
        private const string FieldsessionObject = "sessionObject";
        private const string FieldprofileManager = "profileManager";

        #endregion

        #endregion

        #region General Initializer : Class (Query) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Query" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Query_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Query) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Query" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Query_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Query)

        #region General Initializer : Class (Query) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Query" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateQuery, 0)]
        [TestCase(MethodUpdateQuery, 0)]
        [TestCase(MethodUpdatePostionForQuery, 0)]
        [TestCase(MethodRenameQuery, 0)]
        [TestCase(MethodDeleteQuery, 0)]
        [TestCase(MethodMoveQuery, 0)]
        [TestCase(MethodGetQueries, 0)]
        [TestCase(MethodGetQueryResults, 0)]
        [TestCase(MethodGetQueryTree, 0)]
        [TestCase(MethodGetQueryData, 0)]
        [TestCase(MethodGetHomePageQueries, 0)]
        [TestCase(MethodGetHomePageQueriesById, 0)]
        [TestCase(MethodGetHomePageConfig, 0)]
        [TestCase(MethodSaveHomePageConfig, 0)]
        [TestCase(MethodGetBookMarks, 0)]
        [TestCase(MethodCreateBookMark, 0)]
        [TestCase(MethodRemoveBookMark, 0)]
        [TestCase(MethodCreateHomePageQuery, 0)]
        [TestCase(MethodRemoveHomePageQuery, 0)]
        [TestCase(MethodSaveALLQuery, 0)]
        [TestCase(MethodCreateBookMark, 1)]
        [TestCase(MethodRemoveBookMark, 1)]
        [TestCase(MethodRemoveQuery, 0)]
        [TestCase(MethodCreateHomePageQuery, 1)]
        [TestCase(MethodRemoveHomePageQuery, 1)]
        [TestCase(MethodCreateMobileBookMark, 0)]
        [TestCase(MethodRemoveMobileBookMark, 0)]
        [TestCase(MethodIsDisabledField, 0)]
        [TestCase(MethodGetSearchFiltersOfSavedQuery, 0)]
        [TestCase(MethodGetXml, 0)]
        [TestCase(MethodGetQueryConfiguration, 0)]
        [TestCase(MethodIsHomePageQuery, 0)]
        [TestCase(MethodGetMaxSequenceIndex, 0)]
        [TestCase(MethodIsMobileBookMarkQuery, 0)]
        [TestCase(MethodIsMobileBookMarkEntity, 0)]
        [TestCase(MethodIsBookMarkQuery, 0)]
        [TestCase(MethodApplyPermissionForQueryParameters, 0)]
        [TestCase(MethodInsertQueryRGConfig, 0)]
        [TestCase(MethodUpdateQueryRGConfig, 0)]
        [TestCase(MethodInsertQueryEntityConfig, 0)]
        [TestCase(MethodUpdateQueryEntityConfig, 0)]
        [TestCase(MethodValidateMobileBookmark, 0)]
        [TestCase(MethodGetLboObjectName, 0)]
        [TestCase(MethodIsQueryExist, 0)]
        [TestCase(MethodGetProtectionMode, 0)]
        [TestCase(MethodGetRootFolder, 0)]
        [TestCase(MethodDeleteFolder, 0)]
        [TestCase(MethodGetRecordCount, 0)]
        public void AUT_Query_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Query) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Query" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [TestCase(FieldsessionObject)]
        [TestCase(FieldprofileManager)]
        [Category("AUT Fields")]
        public void AUT_Query_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Query) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Query" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Query_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryInstance.ShouldBeAssignableTo<Query>();
            _queryInstanceFixture.ShouldBeAssignableTo<Query>();
            CurrentInstance.ShouldBeAssignableTo<Query>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);

            // Act
            Action executeAction = () => _queryInstance.CreateQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            Type [] methodCreateQueryParametersTypes = null;
            object[] parametersOfCreateQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQuery, methodCreateQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfCreateQuery);
            var result2 = this.GetResultOfMethod<string>(MethodCreateQuery, parametersOfCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateQuery.ShouldBeNull();
            methodCreateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            Type [] methodCreateQueryParametersTypes = null;
            object[] parametersOfCreateQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateQuery, parametersOfCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            parametersOfCreateQuery.ShouldBeNull();
            methodCreateQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            Type [] methodCreateQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            Type [] methodCreateQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_UpdateQuery_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQuery, methodUpdateQueryParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);

            // Act
            Action executeAction = () => _queryInstance.UpdateQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.UpdateQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            Type [] methodUpdateQueryParametersTypes = null;
            object[] parametersOfUpdateQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQuery, methodUpdateQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfUpdateQuery);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateQuery, parametersOfUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateQuery.ShouldBeNull();
            methodUpdateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            Type [] methodUpdateQueryParametersTypes = null;
            object[] parametersOfUpdateQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateQuery, parametersOfUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            parametersOfUpdateQuery.ShouldBeNull();
            methodUpdateQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            Type [] methodUpdateQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            Type [] methodUpdateQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_UpdatePostionForQuery_Method_Call_Internally(Type[] types)
        {
            var methodUpdatePostionForQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);

            // Act
            Action executeAction = () => _queryInstance.UpdatePostionForQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.UpdatePostionForQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;
            object[] parametersOfUpdatePostionForQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfUpdatePostionForQuery);
            var result2 = this.GetResultOfMethod<string>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdatePostionForQuery.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;
            object[] parametersOfUpdatePostionForQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            parametersOfUpdatePostionForQuery.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RenameQuery_Method_Call_Internally(Type[] types)
        {
            var methodRenameQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRenameQuery, methodRenameQueryParametersTypes);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);

            // Act
            Action executeAction = () => _queryInstance.RenameQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RenameQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            Type [] methodRenameQueryParametersTypes = null;
            object[] parametersOfRenameQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRenameQuery, methodRenameQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfRenameQuery);
            var result2 = this.GetResultOfMethod<string>(MethodRenameQuery, parametersOfRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRenameQuery.ShouldBeNull();
            methodRenameQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            Type [] methodRenameQueryParametersTypes = null;
            object[] parametersOfRenameQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRenameQuery, parametersOfRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            parametersOfRenameQuery.ShouldBeNull();
            methodRenameQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            Type [] methodRenameQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRenameQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            Type [] methodRenameQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRenameQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRenameQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_DeleteQuery_Method_Call_Internally(Type[] types)
        {
            var methodDeleteQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteQuery, methodDeleteQueryParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);

            // Act
            Action executeAction = () => _queryInstance.DeleteQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.DeleteQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            Type [] methodDeleteQueryParametersTypes = null;
            object[] parametersOfDeleteQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQuery, methodDeleteQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfDeleteQuery);
            var result2 = this.GetResultOfMethod<string>(MethodDeleteQuery, parametersOfDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteQuery.ShouldBeNull();
            methodDeleteQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            Type [] methodDeleteQueryParametersTypes = null;
            object[] parametersOfDeleteQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDeleteQuery, parametersOfDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            parametersOfDeleteQuery.ShouldBeNull();
            methodDeleteQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            Type [] methodDeleteQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            Type [] methodDeleteQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_MoveQuery_Method_Call_Internally(Type[] types)
        {
            var methodMoveQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMoveQuery, methodMoveQueryParametersTypes);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);

            // Act
            Action executeAction = () => _queryInstance.MoveQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.MoveQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            Type [] methodMoveQueryParametersTypes = null;
            object[] parametersOfMoveQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQuery, methodMoveQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfMoveQuery);
            var result2 = this.GetResultOfMethod<string>(MethodMoveQuery, parametersOfMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMoveQuery.ShouldBeNull();
            methodMoveQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            Type [] methodMoveQueryParametersTypes = null;
            object[] parametersOfMoveQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMoveQuery, parametersOfMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            parametersOfMoveQuery.ShouldBeNull();
            methodMoveQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            Type [] methodMoveQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMoveQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            Type [] methodMoveQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMoveQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetQueries_Method_Call_Internally(Type[] types)
        {
            var methodGetQueriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueries, methodGetQueriesParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);

            // Act
            Action executeAction = () => _queryInstance.GetQueries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetQueries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            Type [] methodGetQueriesParametersTypes = null;
            object[] parametersOfGetQueries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueries, methodGetQueriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetQueries);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueries, parametersOfGetQueries, methodGetQueriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueries.ShouldBeNull();
            methodGetQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            Type [] methodGetQueriesParametersTypes = null;
            object[] parametersOfGetQueries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueries, parametersOfGetQueries, methodGetQueriesParametersTypes);

            // Assert
            parametersOfGetQueries.ShouldBeNull();
            methodGetQueriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            Type [] methodGetQueriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueries, methodGetQueriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            Type [] methodGetQueriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueries, methodGetQueriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueries) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetQueryResults_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryResultsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);

            // Act
            Action executeAction = () => _queryInstance.GetQueryResults();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetQueryResults();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;
            object[] parametersOfGetQueryResults = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, methodGetQueryResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetQueryResults);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryResults.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;
            object[] parametersOfGetQueryResults = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            parametersOfGetQueryResults.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetQueryTree_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);

            // Act
            Action executeAction = () => _queryInstance.GetQueryTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetQueryTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;
            object[] parametersOfGetQueryTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, methodGetQueryTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetQueryTree);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryTree.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;
            object[] parametersOfGetQueryTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            parametersOfGetQueryTree.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetQueryData_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);

            // Act
            Action executeAction = () => _queryInstance.GetQueryData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetQueryData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            Type [] methodGetQueryDataParametersTypes = null;
            object[] parametersOfGetQueryData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryData, methodGetQueryDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetQueryData);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryData, parametersOfGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryData.ShouldBeNull();
            methodGetQueryDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            Type [] methodGetQueryDataParametersTypes = null;
            object[] parametersOfGetQueryData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryData, parametersOfGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            parametersOfGetQueryData.ShouldBeNull();
            methodGetQueryDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            Type [] methodGetQueryDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            Type [] methodGetQueryDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryData, methodGetQueryDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetHomePageQueries_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageQueriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);

            // Act
            Action executeAction = () => _queryInstance.GetHomePageQueries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageQueries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;
            object[] parametersOfGetHomePageQueries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetHomePageQueries);
            var result2 = this.GetResultOfMethod<string>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageQueries.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;
            object[] parametersOfGetHomePageQueries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            parametersOfGetHomePageQueries.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetHomePageQueriesById_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageQueriesByIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);

            // Act
            Action executeAction = () => _queryInstance.GetHomePageQueriesById();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageQueriesById();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            Type [] methodGetHomePageQueriesByIdParametersTypes = null;
            object[] parametersOfGetHomePageQueriesById = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetHomePageQueriesById);
            var result2 = this.GetResultOfMethod<string>(MethodGetHomePageQueriesById, parametersOfGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageQueriesById.ShouldBeNull();
            methodGetHomePageQueriesByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            Type [] methodGetHomePageQueriesByIdParametersTypes = null;
            object[] parametersOfGetHomePageQueriesById = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetHomePageQueriesById, parametersOfGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            parametersOfGetHomePageQueriesById.ShouldBeNull();
            methodGetHomePageQueriesByIdParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            Type [] methodGetHomePageQueriesByIdParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            Type [] methodGetHomePageQueriesByIdParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesByIdParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueriesById, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);

            // Act
            Action executeAction = () => _queryInstance.GetHomePageConfig();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageConfig();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;
            object[] parametersOfGetHomePageConfig = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetHomePageConfig);
            var result2 = this.GetResultOfMethod<string>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageConfig.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;
            object[] parametersOfGetHomePageConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            parametersOfGetHomePageConfig.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_SaveHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodSaveHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);

            // Act
            Action executeAction = () => _queryInstance.SaveHomePageConfig();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.SaveHomePageConfig();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;
            object[] parametersOfSaveHomePageConfig = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfSaveHomePageConfig);
            var result2 = this.GetResultOfMethod<string>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveHomePageConfig.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;
            object[] parametersOfSaveHomePageConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            parametersOfSaveHomePageConfig.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetBookMarks_Method_Call_Internally(Type[] types)
        {
            var methodGetBookMarksParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBookMarks, methodGetBookMarksParametersTypes);
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);

            // Act
            Action executeAction = () => _queryInstance.GetBookMarks();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetBookMarks();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            Type [] methodGetBookMarksParametersTypes = null;
            object[] parametersOfGetBookMarks = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookMarks, methodGetBookMarksParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetBookMarks);
            var result2 = this.GetResultOfMethod<string>(MethodGetBookMarks, parametersOfGetBookMarks, methodGetBookMarksParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBookMarks.ShouldBeNull();
            methodGetBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            Type [] methodGetBookMarksParametersTypes = null;
            object[] parametersOfGetBookMarks = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetBookMarks, parametersOfGetBookMarks, methodGetBookMarksParametersTypes);

            // Assert
            parametersOfGetBookMarks.ShouldBeNull();
            methodGetBookMarksParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            Type [] methodGetBookMarksParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBookMarks, methodGetBookMarksParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            Type [] methodGetBookMarksParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBookMarks, methodGetBookMarksParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBookMarksParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBookMarks) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetBookMarks_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBookMarks);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBookMarks, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_CreateBookMark_Method_Call_Internally(Type[] types)
        {
            var methodCreateBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);

            // Act
            Action executeAction = () => _queryInstance.CreateBookMark();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateBookMark();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            Type [] methodCreateBookMarkParametersTypes = null;
            object[] parametersOfCreateBookMark = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, methodCreateBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfCreateBookMark);
            var result2 = this.GetResultOfMethod<string>(MethodCreateBookMark, parametersOfCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateBookMark.ShouldBeNull();
            methodCreateBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            Type [] methodCreateBookMarkParametersTypes = null;
            object[] parametersOfCreateBookMark = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateBookMark, parametersOfCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            parametersOfCreateBookMark.ShouldBeNull();
            methodCreateBookMarkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            Type [] methodCreateBookMarkParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            Type [] methodCreateBookMarkParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveBookMark_Method_Call_Internally(Type[] types)
        {
            var methodRemoveBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);

            // Act
            Action executeAction = () => _queryInstance.RemoveBookMark();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RemoveBookMark();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            Type [] methodRemoveBookMarkParametersTypes = null;
            object[] parametersOfRemoveBookMark = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfRemoveBookMark);
            var result2 = this.GetResultOfMethod<string>(MethodRemoveBookMark, parametersOfRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRemoveBookMark.ShouldBeNull();
            methodRemoveBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            Type [] methodRemoveBookMarkParametersTypes = null;
            object[] parametersOfRemoveBookMark = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRemoveBookMark, parametersOfRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            parametersOfRemoveBookMark.ShouldBeNull();
            methodRemoveBookMarkParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            Type [] methodRemoveBookMarkParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRemoveBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            Type [] methodRemoveBookMarkParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveBookMarkParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_CreateHomePageQuery_Method_Call_Internally(Type[] types)
        {
            var methodCreateHomePageQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);

            // Act
            Action executeAction = () => _queryInstance.CreateHomePageQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateHomePageQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            Type [] methodCreateHomePageQueryParametersTypes = null;
            object[] parametersOfCreateHomePageQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfCreateHomePageQuery);
            var result2 = this.GetResultOfMethod<string>(MethodCreateHomePageQuery, parametersOfCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateHomePageQuery.ShouldBeNull();
            methodCreateHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            Type [] methodCreateHomePageQueryParametersTypes = null;
            object[] parametersOfCreateHomePageQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateHomePageQuery, parametersOfCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            parametersOfCreateHomePageQuery.ShouldBeNull();
            methodCreateHomePageQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            Type [] methodCreateHomePageQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            Type [] methodCreateHomePageQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveHomePageQuery_Method_Call_Internally(Type[] types)
        {
            var methodRemoveHomePageQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);

            // Act
            Action executeAction = () => _queryInstance.RemoveHomePageQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RemoveHomePageQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            Type [] methodRemoveHomePageQueryParametersTypes = null;
            object[] parametersOfRemoveHomePageQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfRemoveHomePageQuery);
            var result2 = this.GetResultOfMethod<string>(MethodRemoveHomePageQuery, parametersOfRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRemoveHomePageQuery.ShouldBeNull();
            methodRemoveHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            Type [] methodRemoveHomePageQueryParametersTypes = null;
            object[] parametersOfRemoveHomePageQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodRemoveHomePageQuery, parametersOfRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            parametersOfRemoveHomePageQuery.ShouldBeNull();
            methodRemoveHomePageQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            Type [] methodRemoveHomePageQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRemoveHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            Type [] methodRemoveHomePageQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveHomePageQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_SaveALLQuery_Method_Call_Internally(Type[] types)
        {
            var methodSaveALLQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);

            // Act
            Action executeAction = () => _queryInstance.SaveALLQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.SaveALLQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;
            object[] parametersOfSaveALLQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, methodSaveALLQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfSaveALLQuery);
            var result2 = this.GetResultOfMethod<string>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveALLQuery.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;
            object[] parametersOfSaveALLQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            parametersOfSaveALLQuery.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_CreateBookMark_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateBookMark = { queryId, ownerId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, methodCreateBookMarkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfCreateBookMark);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateBookMark.ShouldNotBeNull();
            parametersOfCreateBookMark.Length.ShouldBe(2);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(2);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(parametersOfCreateBookMark.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateBookMark = { queryId, ownerId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateBookMark, parametersOfCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            parametersOfCreateBookMark.ShouldNotBeNull();
            parametersOfCreateBookMark.Length.ShouldBe(2);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(2);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(parametersOfCreateBookMark.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            methodCreateBookMarkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveBookMark_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodRemoveBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveBookMark = { queryId, ownerId, deleteAll };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfRemoveBookMark);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveBookMark.ShouldNotBeNull();
            parametersOfRemoveBookMark.Length.ShouldBe(3);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(3);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveBookMark.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveBookMark = { queryId, ownerId, deleteAll };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveBookMark, parametersOfRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            parametersOfRemoveBookMark.ShouldNotBeNull();
            parametersOfRemoveBookMark.Length.ShouldBe(3);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(3);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveBookMark.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveQuery_Method_Call_Internally(Type[] types)
        {
            var methodRemoveQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveQuery, methodRemoveQueryParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveQuery_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodRemoveQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfRemoveQuery = { queryId, ownerId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveQuery, methodRemoveQueryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfRemoveQuery);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveQuery.ShouldNotBeNull();
            parametersOfRemoveQuery.Length.ShouldBe(2);
            methodRemoveQueryParametersTypes.Length.ShouldBe(2);
            methodRemoveQueryParametersTypes.Length.ShouldBe(parametersOfRemoveQuery.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveQuery_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodRemoveQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfRemoveQuery = { queryId, ownerId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveQuery, parametersOfRemoveQuery, methodRemoveQueryParametersTypes);

            // Assert
            parametersOfRemoveQuery.ShouldNotBeNull();
            parametersOfRemoveQuery.Length.ShouldBe(2);
            methodRemoveQueryParametersTypes.Length.ShouldBe(2);
            methodRemoveQueryParametersTypes.Length.ShouldBe(parametersOfRemoveQuery.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveQuery, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveQuery);
            var methodRemoveQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveQuery, methodRemoveQueryParametersTypes);

            // Assert
            methodRemoveQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveQuery) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveQuery_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveQuery, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_CreateHomePageQuery_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodCreateHomePageQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateHomePageQuery = { queryId, ownerId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfCreateHomePageQuery);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateHomePageQuery.ShouldNotBeNull();
            parametersOfCreateHomePageQuery.Length.ShouldBe(2);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(2);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(parametersOfCreateHomePageQuery.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateHomePageQuery = { queryId, ownerId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateHomePageQuery, parametersOfCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            parametersOfCreateHomePageQuery.ShouldNotBeNull();
            parametersOfCreateHomePageQuery.Length.ShouldBe(2);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(2);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(parametersOfCreateHomePageQuery.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, 1);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveHomePageQuery_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodRemoveHomePageQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveHomePageQuery = { queryId, ownerId, deleteAll };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfRemoveHomePageQuery);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveHomePageQuery.ShouldNotBeNull();
            parametersOfRemoveHomePageQuery.Length.ShouldBe(3);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(3);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(parametersOfRemoveHomePageQuery.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Void_Overloading_Of_1_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveHomePageQuery = { queryId, ownerId, deleteAll };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveHomePageQuery, parametersOfRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            parametersOfRemoveHomePageQuery.ShouldNotBeNull();
            parametersOfRemoveHomePageQuery.Length.ShouldBe(3);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(3);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(parametersOfRemoveHomePageQuery.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, 1);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Overloading_Of_1_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, 1);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_CreateMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodCreateMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodCreateMobileBookMark, methodCreateMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();

            // Act
            Action executeAction = () => _queryInstance.CreateMobileBookMark(queryId, ownerId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateMobileBookMark = { queryId, ownerId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMobileBookMark, methodCreateMobileBookMarkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfCreateMobileBookMark);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateMobileBookMark.ShouldNotBeNull();
            parametersOfCreateMobileBookMark.Length.ShouldBe(2);
            methodCreateMobileBookMarkParametersTypes.Length.ShouldBe(2);
            methodCreateMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfCreateMobileBookMark.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodCreateMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfCreateMobileBookMark = { queryId, ownerId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateMobileBookMark, parametersOfCreateMobileBookMark, methodCreateMobileBookMarkParametersTypes);

            // Assert
            parametersOfCreateMobileBookMark.ShouldNotBeNull();
            parametersOfCreateMobileBookMark.Length.ShouldBe(2);
            methodCreateMobileBookMarkParametersTypes.Length.ShouldBe(2);
            methodCreateMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfCreateMobileBookMark.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMobileBookMark, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var methodCreateMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateMobileBookMark, methodCreateMobileBookMarkParametersTypes);

            // Assert
            methodCreateMobileBookMarkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateMobileBookMark) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateMobileBookMark_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateMobileBookMark, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_RemoveMobileBookMark_Method_Call_Internally(Type[] types)
        {
            var methodRemoveMobileBookMarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveMobileBookMark_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveMobileBookMark = { queryId, ownerId, deleteAll };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfRemoveMobileBookMark);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveMobileBookMark.ShouldNotBeNull();
            parametersOfRemoveMobileBookMark.Length.ShouldBe(3);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(3);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveMobileBookMark.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveMobileBookMark_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var deleteAll = this.CreateType<bool>();
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };
            object[] parametersOfRemoveMobileBookMark = { queryId, ownerId, deleteAll };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveMobileBookMark, parametersOfRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);

            // Assert
            parametersOfRemoveMobileBookMark.ShouldNotBeNull();
            parametersOfRemoveMobileBookMark.Length.ShouldBe(3);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(3);
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(parametersOfRemoveMobileBookMark.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveMobileBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveMobileBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var methodRemoveMobileBookMarkParametersTypes = new Type[] { typeof(Guid), typeof(string), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveMobileBookMark, methodRemoveMobileBookMarkParametersTypes);

            // Assert
            methodRemoveMobileBookMarkParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveMobileBookMark) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveMobileBookMark_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveMobileBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveMobileBookMark, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsDisabledField_Method_Call_Internally(Type[] types)
        {
            var methodIsDisabledFieldParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsDisabledField, methodIsDisabledFieldParametersTypes);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var fieldName = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var methodIsDisabledFieldParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfIsDisabledField = { fieldName, navigatorEntityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsDisabledField, methodIsDisabledFieldParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsDisabledField);
            var result2 = this.GetResultOfMethod<bool>(MethodIsDisabledField, parametersOfIsDisabledField, methodIsDisabledFieldParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsDisabledField.ShouldNotBeNull();
            parametersOfIsDisabledField.Length.ShouldBe(2);
            methodIsDisabledFieldParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var fieldName = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var methodIsDisabledFieldParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfIsDisabledField = { fieldName, navigatorEntityId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsDisabledField, methodIsDisabledFieldParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsDisabledField);
            var result2 = this.GetResultOfMethod<bool>(MethodIsDisabledField, parametersOfIsDisabledField, methodIsDisabledFieldParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsDisabledField.ShouldNotBeNull();
            parametersOfIsDisabledField.Length.ShouldBe(2);
            methodIsDisabledFieldParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var fieldName = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var methodIsDisabledFieldParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfIsDisabledField = { fieldName, navigatorEntityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsDisabledField, parametersOfIsDisabledField, methodIsDisabledFieldParametersTypes);

            // Assert
            parametersOfIsDisabledField.ShouldNotBeNull();
            parametersOfIsDisabledField.Length.ShouldBe(2);
            methodIsDisabledFieldParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var methodIsDisabledFieldParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsDisabledField, methodIsDisabledFieldParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsDisabledFieldParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var currentMethodInfo = this.GetMethodInfo(MethodIsDisabledField, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsDisabledField) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsDisabledField_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsDisabledField);
            var currentMethodInfo = this.GetMethodInfo(MethodIsDisabledField, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFiltersOfSavedQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var queryParameters = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var methodGetSearchFiltersOfSavedQueryParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfGetSearchFiltersOfSavedQuery = { queryParameters, navigatorEntityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetSearchFiltersOfSavedQuery);
            var result2 = this.GetResultOfMethod<string>(MethodGetSearchFiltersOfSavedQuery, parametersOfGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFiltersOfSavedQuery.ShouldNotBeNull();
            parametersOfGetSearchFiltersOfSavedQuery.Length.ShouldBe(2);
            methodGetSearchFiltersOfSavedQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var queryParameters = this.CreateType<string>();
            var navigatorEntityId = this.CreateType<int>();
            var methodGetSearchFiltersOfSavedQueryParametersTypes = new Type[] { typeof(string), typeof(int) };
            object[] parametersOfGetSearchFiltersOfSavedQuery = { queryParameters, navigatorEntityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetSearchFiltersOfSavedQuery, parametersOfGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes);

            // Assert
            parametersOfGetSearchFiltersOfSavedQuery.ShouldNotBeNull();
            parametersOfGetSearchFiltersOfSavedQuery.Length.ShouldBe(2);
            methodGetSearchFiltersOfSavedQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var methodGetSearchFiltersOfSavedQueryParametersTypes = new Type[] { typeof(string), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFiltersOfSavedQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var methodGetSearchFiltersOfSavedQueryParametersTypes = new Type[] { typeof(string), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFiltersOfSavedQuery, methodGetSearchFiltersOfSavedQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFiltersOfSavedQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFiltersOfSavedQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFiltersOfSavedQuery) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetSearchFiltersOfSavedQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFiltersOfSavedQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFiltersOfSavedQuery, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetXml_Method_Call_Internally(Type[] types)
        {
            var methodGetXmlParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetXml, methodGetXmlParametersTypes);
        }

        #endregion

        #region Method Call : (GetXml) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetXml_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<query_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<query_view>) };
            object[] parametersOfGetXml = { list };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetXml, methodGetXmlParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetXml);
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
        public void AUT_Query_GetXml_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var list = this.CreateType<List<query_view>>();
            var methodGetXmlParametersTypes = new Type[] { typeof(List<query_view>) };
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
        public void AUT_Query_GetXml_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<query_view>) };

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
        public void AUT_Query_GetXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetXml);
            var methodGetXmlParametersTypes = new Type[] { typeof(List<query_view>) };
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
        public void AUT_Query_GetXml_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_Query_GetXml_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetQueryConfiguration) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetQueryConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryConfiguration, methodGetQueryConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var methodGetQueryConfigurationParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfGetQueryConfiguration = { entityId, userId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfiguration, methodGetQueryConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetQueryConfiguration);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryConfiguration, parametersOfGetQueryConfiguration, methodGetQueryConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryConfiguration.ShouldNotBeNull();
            parametersOfGetQueryConfiguration.Length.ShouldBe(2);
            methodGetQueryConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var methodGetQueryConfigurationParametersTypes = new Type[] { typeof(int), typeof(string) };
            object[] parametersOfGetQueryConfiguration = { entityId, userId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryConfiguration, parametersOfGetQueryConfiguration, methodGetQueryConfigurationParametersTypes);

            // Assert
            parametersOfGetQueryConfiguration.ShouldNotBeNull();
            parametersOfGetQueryConfiguration.Length.ShouldBe(2);
            methodGetQueryConfigurationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var methodGetQueryConfigurationParametersTypes = new Type[] { typeof(int), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryConfiguration, methodGetQueryConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryConfigurationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var methodGetQueryConfigurationParametersTypes = new Type[] { typeof(int), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryConfiguration, methodGetQueryConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryConfiguration) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryConfiguration, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsHomePageQuery_Method_Call_Internally(Type[] types)
        {
            var methodIsHomePageQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsHomePageQuery, methodIsHomePageQueryParametersTypes);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsHomePageQuery = { queryId, ownerId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsHomePageQuery, methodIsHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsHomePageQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsHomePageQuery, parametersOfIsHomePageQuery, methodIsHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsHomePageQuery.ShouldNotBeNull();
            parametersOfIsHomePageQuery.Length.ShouldBe(2);
            methodIsHomePageQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsHomePageQuery = { queryId, ownerId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsHomePageQuery, methodIsHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsHomePageQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsHomePageQuery, parametersOfIsHomePageQuery, methodIsHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsHomePageQuery.ShouldNotBeNull();
            parametersOfIsHomePageQuery.Length.ShouldBe(2);
            methodIsHomePageQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsHomePageQuery = { queryId, ownerId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsHomePageQuery, parametersOfIsHomePageQuery, methodIsHomePageQueryParametersTypes);

            // Assert
            parametersOfIsHomePageQuery.ShouldNotBeNull();
            parametersOfIsHomePageQuery.Length.ShouldBe(2);
            methodIsHomePageQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var methodIsHomePageQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsHomePageQuery, methodIsHomePageQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsHomePageQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsHomePageQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsHomePageQuery) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsHomePageQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsHomePageQuery, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetMaxSequenceIndex_Method_Call_Internally(Type[] types)
        {
            var methodGetMaxSequenceIndexParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var ownerId = this.CreateType<string>();
            var methodGetMaxSequenceIndexParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetMaxSequenceIndex = { ownerId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_queryInstanceFixture, parametersOfGetMaxSequenceIndex);
            var result2 = this.GetResultOfMethod<int>(MethodGetMaxSequenceIndex, parametersOfGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMaxSequenceIndex.ShouldNotBeNull();
            parametersOfGetMaxSequenceIndex.Length.ShouldBe(1);
            methodGetMaxSequenceIndexParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var ownerId = this.CreateType<string>();
            var methodGetMaxSequenceIndexParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetMaxSequenceIndex = { ownerId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_queryInstanceFixture, out exception1, parametersOfGetMaxSequenceIndex);
            var result2 = this.GetResultOfMethod<int>(MethodGetMaxSequenceIndex, parametersOfGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetMaxSequenceIndex.ShouldNotBeNull();
            parametersOfGetMaxSequenceIndex.Length.ShouldBe(1);
            methodGetMaxSequenceIndexParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var ownerId = this.CreateType<string>();
            var methodGetMaxSequenceIndexParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetMaxSequenceIndex = { ownerId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetMaxSequenceIndex, parametersOfGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes);

            // Assert
            parametersOfGetMaxSequenceIndex.ShouldNotBeNull();
            parametersOfGetMaxSequenceIndex.Length.ShouldBe(1);
            methodGetMaxSequenceIndexParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var methodGetMaxSequenceIndexParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetMaxSequenceIndex, methodGetMaxSequenceIndexParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetMaxSequenceIndexParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaxSequenceIndex, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetMaxSequenceIndex) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetMaxSequenceIndex_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetMaxSequenceIndex);
            var currentMethodInfo = this.GetMethodInfo(MethodGetMaxSequenceIndex, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsMobileBookMarkQuery_Method_Call_Internally(Type[] types)
        {
            var methodIsMobileBookMarkQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsMobileBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsMobileBookMarkQuery = { queryId, ownerId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsMobileBookMarkQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsMobileBookMarkQuery, parametersOfIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsMobileBookMarkQuery.ShouldNotBeNull();
            parametersOfIsMobileBookMarkQuery.Length.ShouldBe(2);
            methodIsMobileBookMarkQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsMobileBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsMobileBookMarkQuery = { queryId, ownerId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsMobileBookMarkQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsMobileBookMarkQuery, parametersOfIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsMobileBookMarkQuery.ShouldNotBeNull();
            parametersOfIsMobileBookMarkQuery.Length.ShouldBe(2);
            methodIsMobileBookMarkQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsMobileBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsMobileBookMarkQuery = { queryId, ownerId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsMobileBookMarkQuery, parametersOfIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes);

            // Assert
            parametersOfIsMobileBookMarkQuery.ShouldNotBeNull();
            parametersOfIsMobileBookMarkQuery.Length.ShouldBe(2);
            methodIsMobileBookMarkQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var methodIsMobileBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsMobileBookMarkQuery, methodIsMobileBookMarkQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsMobileBookMarkQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsMobileBookMarkQuery) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkQuery, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsMobileBookMarkEntity_Method_Call_Internally(Type[] types)
        {
            var methodIsMobileBookMarkEntityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var queryId = this.CreateType<Guid>();
            var methodIsMobileBookMarkEntityParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsMobileBookMarkEntity = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsMobileBookMarkEntity);
            var result2 = this.GetResultOfMethod<bool>(MethodIsMobileBookMarkEntity, parametersOfIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsMobileBookMarkEntity.ShouldNotBeNull();
            parametersOfIsMobileBookMarkEntity.Length.ShouldBe(1);
            methodIsMobileBookMarkEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var queryId = this.CreateType<Guid>();
            var methodIsMobileBookMarkEntityParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsMobileBookMarkEntity = { queryId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsMobileBookMarkEntity);
            var result2 = this.GetResultOfMethod<bool>(MethodIsMobileBookMarkEntity, parametersOfIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsMobileBookMarkEntity.ShouldNotBeNull();
            parametersOfIsMobileBookMarkEntity.Length.ShouldBe(1);
            methodIsMobileBookMarkEntityParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var queryId = this.CreateType<Guid>();
            var methodIsMobileBookMarkEntityParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsMobileBookMarkEntity = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsMobileBookMarkEntity, parametersOfIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes);

            // Assert
            parametersOfIsMobileBookMarkEntity.ShouldNotBeNull();
            parametersOfIsMobileBookMarkEntity.Length.ShouldBe(1);
            methodIsMobileBookMarkEntityParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var methodIsMobileBookMarkEntityParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsMobileBookMarkEntity, methodIsMobileBookMarkEntityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsMobileBookMarkEntityParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkEntity, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsMobileBookMarkEntity) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsMobileBookMarkEntity_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsMobileBookMarkEntity);
            var currentMethodInfo = this.GetMethodInfo(MethodIsMobileBookMarkEntity, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsBookMarkQuery_Method_Call_Internally(Type[] types)
        {
            var methodIsBookMarkQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsBookMarkQuery, methodIsBookMarkQueryParametersTypes);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsBookMarkQuery = { queryId, ownerId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBookMarkQuery, methodIsBookMarkQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsBookMarkQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsBookMarkQuery, parametersOfIsBookMarkQuery, methodIsBookMarkQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsBookMarkQuery.ShouldNotBeNull();
            parametersOfIsBookMarkQuery.Length.ShouldBe(2);
            methodIsBookMarkQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsBookMarkQuery = { queryId, ownerId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsBookMarkQuery, methodIsBookMarkQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsBookMarkQuery);
            var result2 = this.GetResultOfMethod<bool>(MethodIsBookMarkQuery, parametersOfIsBookMarkQuery, methodIsBookMarkQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsBookMarkQuery.ShouldNotBeNull();
            parametersOfIsBookMarkQuery.Length.ShouldBe(2);
            methodIsBookMarkQueryParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var queryId = this.CreateType<Guid>();
            var ownerId = this.CreateType<string>();
            var methodIsBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            object[] parametersOfIsBookMarkQuery = { queryId, ownerId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsBookMarkQuery, parametersOfIsBookMarkQuery, methodIsBookMarkQueryParametersTypes);

            // Assert
            parametersOfIsBookMarkQuery.ShouldNotBeNull();
            parametersOfIsBookMarkQuery.Length.ShouldBe(2);
            methodIsBookMarkQueryParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var methodIsBookMarkQueryParametersTypes = new Type[] { typeof(Guid), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsBookMarkQuery, methodIsBookMarkQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsBookMarkQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBookMarkQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsBookMarkQuery) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsBookMarkQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsBookMarkQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodIsBookMarkQuery, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_Internally(Type[] types)
        {
            var methodApplyPermissionForQueryParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var queryParameters = this.CreateType<string>();
            var searchFilters = this.CreateType<string>();
            var methodApplyPermissionForQueryParametersParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfApplyPermissionForQueryParameters = { queryParameters, searchFilters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfApplyPermissionForQueryParameters);
            var result2 = this.GetResultOfMethod<string>(MethodApplyPermissionForQueryParameters, parametersOfApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApplyPermissionForQueryParameters.ShouldNotBeNull();
            parametersOfApplyPermissionForQueryParameters.Length.ShouldBe(2);
            methodApplyPermissionForQueryParametersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var queryParameters = this.CreateType<string>();
            var searchFilters = this.CreateType<string>();
            var methodApplyPermissionForQueryParametersParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfApplyPermissionForQueryParameters = { queryParameters, searchFilters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodApplyPermissionForQueryParameters, parametersOfApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes);

            // Assert
            parametersOfApplyPermissionForQueryParameters.ShouldNotBeNull();
            parametersOfApplyPermissionForQueryParameters.Length.ShouldBe(2);
            methodApplyPermissionForQueryParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var methodApplyPermissionForQueryParametersParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApplyPermissionForQueryParametersParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var methodApplyPermissionForQueryParametersParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApplyPermissionForQueryParameters, methodApplyPermissionForQueryParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApplyPermissionForQueryParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyPermissionForQueryParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ApplyPermissionForQueryParameters) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ApplyPermissionForQueryParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApplyPermissionForQueryParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodApplyPermissionForQueryParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_InsertQueryRGConfig_Method_Call_Internally(Type[] types)
        {
            var methodInsertQueryRGConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertQueryRGConfig, methodInsertQueryRGConfigParametersTypes);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryRGConfig_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryRGConfig);
            var queryId = this.CreateType<Guid>();
            var isAdministrator = this.CreateType<bool>();
            var navigatorEntityId = this.CreateType<int>();
            var methodInsertQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };
            object[] parametersOfInsertQueryRGConfig = { queryId, isAdministrator, navigatorEntityId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryRGConfig, methodInsertQueryRGConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfInsertQueryRGConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertQueryRGConfig.ShouldNotBeNull();
            parametersOfInsertQueryRGConfig.Length.ShouldBe(3);
            methodInsertQueryRGConfigParametersTypes.Length.ShouldBe(3);
            methodInsertQueryRGConfigParametersTypes.Length.ShouldBe(parametersOfInsertQueryRGConfig.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryRGConfig_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryRGConfig);
            var queryId = this.CreateType<Guid>();
            var isAdministrator = this.CreateType<bool>();
            var navigatorEntityId = this.CreateType<int>();
            var methodInsertQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };
            object[] parametersOfInsertQueryRGConfig = { queryId, isAdministrator, navigatorEntityId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertQueryRGConfig, parametersOfInsertQueryRGConfig, methodInsertQueryRGConfigParametersTypes);

            // Assert
            parametersOfInsertQueryRGConfig.ShouldNotBeNull();
            parametersOfInsertQueryRGConfig.Length.ShouldBe(3);
            methodInsertQueryRGConfigParametersTypes.Length.ShouldBe(3);
            methodInsertQueryRGConfigParametersTypes.Length.ShouldBe(parametersOfInsertQueryRGConfig.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryRGConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryRGConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryRGConfig, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryRGConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryRGConfig);
            var methodInsertQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertQueryRGConfig, methodInsertQueryRGConfigParametersTypes);

            // Assert
            methodInsertQueryRGConfigParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryRGConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryRGConfig_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryRGConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryRGConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_UpdateQueryRGConfig_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryRGConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQueryRGConfig, methodUpdateQueryRGConfigParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryRGConfig_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryRGConfig);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var siteId = this.CreateType<int>();
            var isAdministrator = this.CreateType<bool>();
            var methodUpdateQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfUpdateQueryRGConfig = { queryId, entityId, userId, siteId, isAdministrator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryRGConfig, methodUpdateQueryRGConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfUpdateQueryRGConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateQueryRGConfig.ShouldNotBeNull();
            parametersOfUpdateQueryRGConfig.Length.ShouldBe(5);
            methodUpdateQueryRGConfigParametersTypes.Length.ShouldBe(5);
            methodUpdateQueryRGConfigParametersTypes.Length.ShouldBe(parametersOfUpdateQueryRGConfig.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryRGConfig_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryRGConfig);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var siteId = this.CreateType<int>();
            var isAdministrator = this.CreateType<bool>();
            var methodUpdateQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfUpdateQueryRGConfig = { queryId, entityId, userId, siteId, isAdministrator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateQueryRGConfig, parametersOfUpdateQueryRGConfig, methodUpdateQueryRGConfigParametersTypes);

            // Assert
            parametersOfUpdateQueryRGConfig.ShouldNotBeNull();
            parametersOfUpdateQueryRGConfig.Length.ShouldBe(5);
            methodUpdateQueryRGConfigParametersTypes.Length.ShouldBe(5);
            methodUpdateQueryRGConfigParametersTypes.Length.ShouldBe(parametersOfUpdateQueryRGConfig.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryRGConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryRGConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryRGConfig, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryRGConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryRGConfig);
            var methodUpdateQueryRGConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryRGConfig, methodUpdateQueryRGConfigParametersTypes);

            // Assert
            methodUpdateQueryRGConfigParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryRGConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryRGConfig_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryRGConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryRGConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_InsertQueryEntityConfig_Method_Call_Internally(Type[] types)
        {
            var methodInsertQueryEntityConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodInsertQueryEntityConfig, methodInsertQueryEntityConfigParametersTypes);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryEntityConfig_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryEntityConfig);
            var queryId = this.CreateType<Guid>();
            var isAdministrator = this.CreateType<bool>();
            var navigatorEntityId = this.CreateType<int>();
            var methodInsertQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };
            object[] parametersOfInsertQueryEntityConfig = { queryId, isAdministrator, navigatorEntityId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryEntityConfig, methodInsertQueryEntityConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfInsertQueryEntityConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfInsertQueryEntityConfig.ShouldNotBeNull();
            parametersOfInsertQueryEntityConfig.Length.ShouldBe(3);
            methodInsertQueryEntityConfigParametersTypes.Length.ShouldBe(3);
            methodInsertQueryEntityConfigParametersTypes.Length.ShouldBe(parametersOfInsertQueryEntityConfig.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryEntityConfig_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryEntityConfig);
            var queryId = this.CreateType<Guid>();
            var isAdministrator = this.CreateType<bool>();
            var navigatorEntityId = this.CreateType<int>();
            var methodInsertQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };
            object[] parametersOfInsertQueryEntityConfig = { queryId, isAdministrator, navigatorEntityId };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodInsertQueryEntityConfig, parametersOfInsertQueryEntityConfig, methodInsertQueryEntityConfigParametersTypes);

            // Assert
            parametersOfInsertQueryEntityConfig.ShouldNotBeNull();
            parametersOfInsertQueryEntityConfig.Length.ShouldBe(3);
            methodInsertQueryEntityConfigParametersTypes.Length.ShouldBe(3);
            methodInsertQueryEntityConfigParametersTypes.Length.ShouldBe(parametersOfInsertQueryEntityConfig.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryEntityConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryEntityConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryEntityConfig, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryEntityConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryEntityConfig);
            var methodInsertQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(bool), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInsertQueryEntityConfig, methodInsertQueryEntityConfigParametersTypes);

            // Assert
            methodInsertQueryEntityConfigParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InsertQueryEntityConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_InsertQueryEntityConfig_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInsertQueryEntityConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodInsertQueryEntityConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_UpdateQueryEntityConfig_Method_Call_Internally(Type[] types)
        {
            var methodUpdateQueryEntityConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateQueryEntityConfig, methodUpdateQueryEntityConfigParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryEntityConfig_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryEntityConfig);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var siteId = this.CreateType<int>();
            var isAdministrator = this.CreateType<bool>();
            var methodUpdateQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfUpdateQueryEntityConfig = { queryId, entityId, userId, siteId, isAdministrator };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryEntityConfig, methodUpdateQueryEntityConfigParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfUpdateQueryEntityConfig);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateQueryEntityConfig.ShouldNotBeNull();
            parametersOfUpdateQueryEntityConfig.Length.ShouldBe(5);
            methodUpdateQueryEntityConfigParametersTypes.Length.ShouldBe(5);
            methodUpdateQueryEntityConfigParametersTypes.Length.ShouldBe(parametersOfUpdateQueryEntityConfig.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryEntityConfig_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryEntityConfig);
            var queryId = this.CreateType<Guid>();
            var entityId = this.CreateType<int>();
            var userId = this.CreateType<string>();
            var siteId = this.CreateType<int>();
            var isAdministrator = this.CreateType<bool>();
            var methodUpdateQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };
            object[] parametersOfUpdateQueryEntityConfig = { queryId, entityId, userId, siteId, isAdministrator };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateQueryEntityConfig, parametersOfUpdateQueryEntityConfig, methodUpdateQueryEntityConfigParametersTypes);

            // Assert
            parametersOfUpdateQueryEntityConfig.ShouldNotBeNull();
            parametersOfUpdateQueryEntityConfig.Length.ShouldBe(5);
            methodUpdateQueryEntityConfigParametersTypes.Length.ShouldBe(5);
            methodUpdateQueryEntityConfigParametersTypes.Length.ShouldBe(parametersOfUpdateQueryEntityConfig.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryEntityConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryEntityConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryEntityConfig, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryEntityConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryEntityConfig);
            var methodUpdateQueryEntityConfigParametersTypes = new Type[] { typeof(Guid), typeof(int), typeof(string), typeof(int), typeof(bool) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQueryEntityConfig, methodUpdateQueryEntityConfigParametersTypes);

            // Assert
            methodUpdateQueryEntityConfigParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQueryEntityConfig) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQueryEntityConfig_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQueryEntityConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQueryEntityConfig, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_ValidateMobileBookmark_Method_Call_Internally(Type[] types)
        {
            var methodValidateMobileBookmarkParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var isAdministrator = this.CreateType<bool>();
            var updateQuery = this.CreateType<bool>();

            // Act
            Action executeAction = () => _queryInstance.ValidateMobileBookmark(isAdministrator, updateQuery);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var isAdministrator = this.CreateType<bool>();
            var updateQuery = this.CreateType<bool>();
            var returnedValue = default(List<String>);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.ValidateMobileBookmark(isAdministrator, updateQuery);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var isAdministrator = this.CreateType<bool>();
            var updateQuery = this.CreateType<bool>();
            var methodValidateMobileBookmarkParametersTypes = new Type[] { typeof(bool), typeof(bool) };
            object[] parametersOfValidateMobileBookmark = { isAdministrator, updateQuery };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<String>>(_queryInstanceFixture, parametersOfValidateMobileBookmark);
            var result2 = this.GetResultOfMethod<List<String>>(MethodValidateMobileBookmark, parametersOfValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidateMobileBookmark.ShouldNotBeNull();
            parametersOfValidateMobileBookmark.Length.ShouldBe(2);
            methodValidateMobileBookmarkParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var isAdministrator = this.CreateType<bool>();
            var updateQuery = this.CreateType<bool>();
            var methodValidateMobileBookmarkParametersTypes = new Type[] { typeof(bool), typeof(bool) };
            object[] parametersOfValidateMobileBookmark = { isAdministrator, updateQuery };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<String>>(MethodValidateMobileBookmark, parametersOfValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes);

            // Assert
            parametersOfValidateMobileBookmark.ShouldNotBeNull();
            parametersOfValidateMobileBookmark.Length.ShouldBe(2);
            methodValidateMobileBookmarkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var methodValidateMobileBookmarkParametersTypes = new Type[] { typeof(bool), typeof(bool) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateMobileBookmarkParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var methodValidateMobileBookmarkParametersTypes = new Type[] { typeof(bool), typeof(bool) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateMobileBookmark, methodValidateMobileBookmarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateMobileBookmarkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateMobileBookmark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ValidateMobileBookmark) (Return Type : List<String>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_ValidateMobileBookmark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateMobileBookmark);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateMobileBookmark, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetLboObjectName_Method_Call_Internally(Type[] types)
        {
            var methodGetLboObjectNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityId = this.CreateType<int>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetLboObjectName = { entityId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetLboObjectName);
            var result2 = this.GetResultOfMethod<string>(MethodGetLboObjectName, parametersOfGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboObjectName.ShouldNotBeNull();
            parametersOfGetLboObjectName.Length.ShouldBe(1);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var entityId = this.CreateType<int>();
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
            object[] parametersOfGetLboObjectName = { entityId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetLboObjectName, parametersOfGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            parametersOfGetLboObjectName.ShouldNotBeNull();
            parametersOfGetLboObjectName.Length.ShouldBe(1);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var methodGetLboObjectNameParametersTypes = new Type[] { typeof(int) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboObjectName, methodGetLboObjectNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboObjectNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboObjectName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetLboObjectName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboObjectName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboObjectName, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_IsQueryExist_Method_Call_Internally(Type[] types)
        {
            var methodIsQueryExistParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodIsQueryExist, methodIsQueryExistParametersTypes);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();

            // Act
            Action executeAction = () => _queryInstance.IsQueryExist(queryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, methodIsQueryExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfIsQueryExist);
            var result2 = this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, methodIsQueryExistParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfIsQueryExist);
            var result2 = this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var queryId = this.CreateType<Guid>();
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfIsQueryExist = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodIsQueryExist, parametersOfIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            parametersOfIsQueryExist.ShouldNotBeNull();
            parametersOfIsQueryExist.Length.ShouldBe(1);
            methodIsQueryExistParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var methodIsQueryExistParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIsQueryExist, methodIsQueryExistParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIsQueryExistParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (IsQueryExist) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_IsQueryExist_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIsQueryExist);
            var currentMethodInfo = this.GetMethodInfo(MethodIsQueryExist, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetProtectionMode_Method_Call_Internally(Type[] types)
        {
            var methodGetProtectionModeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProtectionMode, methodGetProtectionModeParametersTypes);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, methodGetProtectionModeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, parametersOfGetProtectionMode);
            var result2 = this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, methodGetProtectionModeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_queryInstanceFixture, out exception1, parametersOfGetProtectionMode);
            var result2 = this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var folderId = this.CreateType<string>();
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProtectionMode = { folderId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetProtectionMode, parametersOfGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            parametersOfGetProtectionMode.ShouldNotBeNull();
            parametersOfGetProtectionMode.Length.ShouldBe(1);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var methodGetProtectionModeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProtectionMode, methodGetProtectionModeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProtectionModeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProtectionMode) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetProtectionMode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProtectionMode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProtectionMode, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetRootFolder_Method_Call_Internally(Type[] types)
        {
            var methodGetRootFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var folderId = this.CreateType<string>();
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRootFolder = { folderId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, methodGetRootFolderParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetRootFolder);
            var result2 = this.GetResultOfMethod<string>(MethodGetRootFolder, parametersOfGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRootFolder.ShouldNotBeNull();
            parametersOfGetRootFolder.Length.ShouldBe(1);
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var folderId = this.CreateType<string>();
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetRootFolder = { folderId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRootFolder, parametersOfGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            parametersOfGetRootFolder.ShouldNotBeNull();
            parametersOfGetRootFolder.Length.ShouldBe(1);
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRootFolderParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var methodGetRootFolderParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRootFolder, methodGetRootFolderParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRootFolderParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRootFolder) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRootFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRootFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRootFolder, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_DeleteFolder_Method_Call_Internally(Type[] types)
        {
            var methodDeleteFolderParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteFolder, methodDeleteFolderParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteFolder_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var folderId = this.CreateType<Guid>();
            var FolderList = this.CreateType<List<XElement>>();
            var QueryList = this.CreateType<List<XElement>>();
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid), typeof(List<XElement>), typeof(List<XElement>) };
            object[] parametersOfDeleteFolder = { folderId, FolderList, QueryList };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, methodDeleteFolderParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_queryInstanceFixture, parametersOfDeleteFolder);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteFolder.ShouldNotBeNull();
            parametersOfDeleteFolder.Length.ShouldBe(3);
            methodDeleteFolderParametersTypes.Length.ShouldBe(3);
            methodDeleteFolderParametersTypes.Length.ShouldBe(parametersOfDeleteFolder.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteFolder_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var folderId = this.CreateType<Guid>();
            var FolderList = this.CreateType<List<XElement>>();
            var QueryList = this.CreateType<List<XElement>>();
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid), typeof(List<XElement>), typeof(List<XElement>) };
            object[] parametersOfDeleteFolder = { folderId, FolderList, QueryList };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteFolder, parametersOfDeleteFolder, methodDeleteFolderParametersTypes);

            // Assert
            parametersOfDeleteFolder.ShouldNotBeNull();
            parametersOfDeleteFolder.Length.ShouldBe(3);
            methodDeleteFolderParametersTypes.Length.ShouldBe(3);
            methodDeleteFolderParametersTypes.Length.ShouldBe(parametersOfDeleteFolder.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteFolder_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteFolder_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var methodDeleteFolderParametersTypes = new Type[] { typeof(Guid), typeof(List<XElement>), typeof(List<XElement>) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteFolder, methodDeleteFolderParametersTypes);

            // Assert
            methodDeleteFolderParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteFolder) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteFolder_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteFolder);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteFolder, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Query_GetRecordCount_Method_Call_Internally(Type[] types)
        {
            var methodGetRecordCountParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRecordCount, methodGetRecordCountParametersTypes);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var queryId = this.CreateType<Guid>();
            var methodGetRecordCountParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetRecordCount = { queryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecordCount, methodGetRecordCountParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryInstanceFixture, parametersOfGetRecordCount);
            var result2 = this.GetResultOfMethod<string>(MethodGetRecordCount, parametersOfGetRecordCount, methodGetRecordCountParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRecordCount.ShouldNotBeNull();
            parametersOfGetRecordCount.Length.ShouldBe(1);
            methodGetRecordCountParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var queryId = this.CreateType<Guid>();
            var methodGetRecordCountParametersTypes = new Type[] { typeof(Guid) };
            object[] parametersOfGetRecordCount = { queryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetRecordCount, parametersOfGetRecordCount, methodGetRecordCountParametersTypes);

            // Assert
            parametersOfGetRecordCount.ShouldNotBeNull();
            parametersOfGetRecordCount.Length.ShouldBe(1);
            methodGetRecordCountParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var methodGetRecordCountParametersTypes = new Type[] { typeof(Guid) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRecordCount, methodGetRecordCountParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRecordCountParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var methodGetRecordCountParametersTypes = new Type[] { typeof(Guid) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRecordCount, methodGetRecordCountParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRecordCountParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecordCount, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecordCount) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetRecordCount_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecordCount);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecordCount, 0);
            const int parametersCount = 1;

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