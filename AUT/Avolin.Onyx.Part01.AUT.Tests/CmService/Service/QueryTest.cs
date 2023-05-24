using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Query" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Query.cs"/>
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

        private const string MethodBrowseQuery = "BrowseQuery";
        private const string MethodGetHomePageQueries = "GetHomePageQueries";
        private const string MethodGetHomePageQueriesById = "GetHomePageQueriesById";
        private const string MethodGetQueryResults = "GetQueryResults";
        private const string MethodBrowseBookmark = "BrowseBookmark";
        private const string MethodBrowseQueryTree = "BrowseQueryTree";
        private const string MethodBrowseQueryData = "BrowseQueryData";
        private const string MethodValidate = "Validate";
        private const string MethodCreateQuery = "CreateQuery";
        private const string MethodCreateBookMark = "CreateBookMark";
        private const string MethodUpdateQuery = "UpdateQuery";
        private const string MethodRenameQuery = "RenameQuery";
        private const string MethodRemoveBookMark = "RemoveBookMark";
        private const string MethodUpdatePostionForQuery = "UpdatePostionForQuery";
        private const string MethodDeleteQuery = "DeleteQuery";
        private const string MethodMoveQuery = "MoveQuery";
        private const string MethodCreateHomePageQuery = "CreateHomePageQuery";
        private const string MethodRemoveHomePageQuery = "RemoveHomePageQuery";
        private const string MethodSaveALLQuery = "SaveALLQuery";
        private const string MethodGetHomePageConfig = "GetHomePageConfig";
        private const string MethodSaveHomePageConfig = "SaveHomePageConfig";

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

        #region Explore Class for Coverage Gain : Class (Query)

        #region General Initializer : Class (Query) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Query" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodBrowseQuery, 0)]
        [TestCase(MethodGetHomePageQueries, 0)]
        [TestCase(MethodGetHomePageQueriesById, 0)]
        [TestCase(MethodGetQueryResults, 0)]
        [TestCase(MethodBrowseBookmark, 0)]
        [TestCase(MethodBrowseQueryTree, 0)]
        [TestCase(MethodBrowseQueryData, 0)]
        [TestCase(MethodValidate, 0)]
        [TestCase(MethodCreateQuery, 0)]
        [TestCase(MethodCreateBookMark, 0)]
        [TestCase(MethodUpdateQuery, 0)]
        [TestCase(MethodRenameQuery, 0)]
        [TestCase(MethodRemoveBookMark, 0)]
        [TestCase(MethodUpdatePostionForQuery, 0)]
        [TestCase(MethodDeleteQuery, 0)]
        [TestCase(MethodMoveQuery, 0)]
        [TestCase(MethodCreateHomePageQuery, 0)]
        [TestCase(MethodRemoveHomePageQuery, 0)]
        [TestCase(MethodSaveALLQuery, 0)]
        [TestCase(MethodGetHomePageConfig, 0)]
        [TestCase(MethodSaveHomePageConfig, 0)]
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

        #endregion

        #region General Instance : Class (Query) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Query" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Query_Is_Instance_Present_Test()
        {
            // Assert
            _queryInstanceType.ShouldNotBeNull();
            _queryInstance.ShouldNotBeNull();
            _queryInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Query) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Query" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
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

        #region General Constructor : Class (Query) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Query_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Query instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.BrowseQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.BrowseQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var message = this.CreateType<Message>();
            var methodBrowseQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQuery, methodBrowseQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfBrowseQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodBrowseQuery, parametersOfBrowseQuery, methodBrowseQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBrowseQuery.ShouldNotBeNull();
            parametersOfBrowseQuery.Length.ShouldBe(1);
            methodBrowseQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var message = this.CreateType<Message>();
            var methodBrowseQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBrowseQuery, parametersOfBrowseQuery, methodBrowseQueryParametersTypes);

            // Assert
            parametersOfBrowseQuery.ShouldNotBeNull();
            parametersOfBrowseQuery.Length.ShouldBe(1);
            methodBrowseQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var methodBrowseQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBrowseQuery, methodBrowseQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBrowseQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var methodBrowseQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBrowseQuery, methodBrowseQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBrowseQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.GetHomePageQueries(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageQueries(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var message = this.CreateType<Message>();
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageQueries = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfGetHomePageQueries);
            var result2 = this.GetResultOfMethod<Message>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageQueries.ShouldNotBeNull();
            parametersOfGetHomePageQueries.Length.ShouldBe(1);
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var message = this.CreateType<Message>();
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageQueries = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            parametersOfGetHomePageQueries.ShouldNotBeNull();
            parametersOfGetHomePageQueries.Length.ShouldBe(1);
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetHomePageQueries) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueries_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.GetHomePageQueriesById(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageQueriesById(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var message = this.CreateType<Message>();
            var methodGetHomePageQueriesByIdParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageQueriesById = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfGetHomePageQueriesById);
            var result2 = this.GetResultOfMethod<Message>(MethodGetHomePageQueriesById, parametersOfGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageQueriesById.ShouldNotBeNull();
            parametersOfGetHomePageQueriesById.Length.ShouldBe(1);
            methodGetHomePageQueriesByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var message = this.CreateType<Message>();
            var methodGetHomePageQueriesByIdParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageQueriesById = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetHomePageQueriesById, parametersOfGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            parametersOfGetHomePageQueriesById.ShouldNotBeNull();
            parametersOfGetHomePageQueriesById.Length.ShouldBe(1);
            methodGetHomePageQueriesByIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var methodGetHomePageQueriesByIdParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesByIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var methodGetHomePageQueriesByIdParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueriesById, methodGetHomePageQueriesByIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesByIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetHomePageQueriesById) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageQueriesById_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueriesById);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueriesById, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.GetQueryResults(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetQueryResults(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var message = this.CreateType<Message>();
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryResults = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, methodGetQueryResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfGetQueryResults);
            var result2 = this.GetResultOfMethod<Message>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryResults.ShouldNotBeNull();
            parametersOfGetQueryResults.Length.ShouldBe(1);
            methodGetQueryResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var message = this.CreateType<Message>();
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryResults = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            parametersOfGetQueryResults.ShouldNotBeNull();
            parametersOfGetQueryResults.Length.ShouldBe(1);
            methodGetQueryResultsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetQueryResults) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetQueryResults_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.BrowseBookmark(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.BrowseBookmark(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var message = this.CreateType<Message>();
            var methodBrowseBookmarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseBookmark = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseBookmark, methodBrowseBookmarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfBrowseBookmark);
            var result2 = this.GetResultOfMethod<Message>(MethodBrowseBookmark, parametersOfBrowseBookmark, methodBrowseBookmarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBrowseBookmark.ShouldNotBeNull();
            parametersOfBrowseBookmark.Length.ShouldBe(1);
            methodBrowseBookmarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var message = this.CreateType<Message>();
            var methodBrowseBookmarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseBookmark = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBrowseBookmark, parametersOfBrowseBookmark, methodBrowseBookmarkParametersTypes);

            // Assert
            parametersOfBrowseBookmark.ShouldNotBeNull();
            parametersOfBrowseBookmark.Length.ShouldBe(1);
            methodBrowseBookmarkParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var methodBrowseBookmarkParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBrowseBookmark, methodBrowseBookmarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBrowseBookmarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var methodBrowseBookmarkParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBrowseBookmark, methodBrowseBookmarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBrowseBookmarkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseBookmark, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseBookmark) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseBookmark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseBookmark);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseBookmark, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.BrowseQueryTree(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.BrowseQueryTree(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var message = this.CreateType<Message>();
            var methodBrowseQueryTreeParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQueryTree = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryTree, methodBrowseQueryTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfBrowseQueryTree);
            var result2 = this.GetResultOfMethod<Message>(MethodBrowseQueryTree, parametersOfBrowseQueryTree, methodBrowseQueryTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBrowseQueryTree.ShouldNotBeNull();
            parametersOfBrowseQueryTree.Length.ShouldBe(1);
            methodBrowseQueryTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var message = this.CreateType<Message>();
            var methodBrowseQueryTreeParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQueryTree = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBrowseQueryTree, parametersOfBrowseQueryTree, methodBrowseQueryTreeParametersTypes);

            // Assert
            parametersOfBrowseQueryTree.ShouldNotBeNull();
            parametersOfBrowseQueryTree.Length.ShouldBe(1);
            methodBrowseQueryTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var methodBrowseQueryTreeParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBrowseQueryTree, methodBrowseQueryTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBrowseQueryTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var methodBrowseQueryTreeParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBrowseQueryTree, methodBrowseQueryTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBrowseQueryTreeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQueryTree) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryTree);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.BrowseQueryData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.BrowseQueryData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var message = this.CreateType<Message>();
            var methodBrowseQueryDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQueryData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryData, methodBrowseQueryDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfBrowseQueryData);
            var result2 = this.GetResultOfMethod<Message>(MethodBrowseQueryData, parametersOfBrowseQueryData, methodBrowseQueryDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBrowseQueryData.ShouldNotBeNull();
            parametersOfBrowseQueryData.Length.ShouldBe(1);
            methodBrowseQueryDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var message = this.CreateType<Message>();
            var methodBrowseQueryDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfBrowseQueryData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodBrowseQueryData, parametersOfBrowseQueryData, methodBrowseQueryDataParametersTypes);

            // Assert
            parametersOfBrowseQueryData.ShouldNotBeNull();
            parametersOfBrowseQueryData.Length.ShouldBe(1);
            methodBrowseQueryDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var methodBrowseQueryDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBrowseQueryData, methodBrowseQueryDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBrowseQueryDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var methodBrowseQueryDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBrowseQueryData, methodBrowseQueryDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBrowseQueryDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BrowseQueryData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_BrowseQueryData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBrowseQueryData);
            var currentMethodInfo = this.GetMethodInfo(MethodBrowseQueryData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.Validate(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.Validate(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var message = this.CreateType<Message>();
            var methodValidateParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfValidate = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfValidate);
            var result2 = this.GetResultOfMethod<Message>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var message = this.CreateType<Message>();
            var methodValidateParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfValidate = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(1);
            methodValidateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Validate) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_Validate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.CreateQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var message = this.CreateType<Message>();
            var methodCreateQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQuery, methodCreateQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfCreateQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateQuery, parametersOfCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateQuery.ShouldNotBeNull();
            parametersOfCreateQuery.Length.ShouldBe(1);
            methodCreateQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var message = this.CreateType<Message>();
            var methodCreateQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateQuery, parametersOfCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            parametersOfCreateQuery.ShouldNotBeNull();
            parametersOfCreateQuery.Length.ShouldBe(1);
            methodCreateQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var methodCreateQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var methodCreateQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateQuery, methodCreateQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (CreateQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.CreateBookMark(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateBookMark(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var message = this.CreateType<Message>();
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateBookMark = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, methodCreateBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfCreateBookMark);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateBookMark, parametersOfCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateBookMark.ShouldNotBeNull();
            parametersOfCreateBookMark.Length.ShouldBe(1);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var message = this.CreateType<Message>();
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateBookMark = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateBookMark, parametersOfCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            parametersOfCreateBookMark.ShouldNotBeNull();
            parametersOfCreateBookMark.Length.ShouldBe(1);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var methodCreateBookMarkParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateBookMark, methodCreateBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateBookMarkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateBookMark) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (CreateBookMark) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBookMark, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.UpdateQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.UpdateQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var message = this.CreateType<Message>();
            var methodUpdateQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfUpdateQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQuery, methodUpdateQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfUpdateQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodUpdateQuery, parametersOfUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateQuery.ShouldNotBeNull();
            parametersOfUpdateQuery.Length.ShouldBe(1);
            methodUpdateQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var message = this.CreateType<Message>();
            var methodUpdateQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfUpdateQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodUpdateQuery, parametersOfUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            parametersOfUpdateQuery.ShouldNotBeNull();
            parametersOfUpdateQuery.Length.ShouldBe(1);
            methodUpdateQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var methodUpdateQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var methodUpdateQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateQuery, methodUpdateQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (UpdateQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdateQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.RenameQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RenameQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var message = this.CreateType<Message>();
            var methodRenameQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRenameQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRenameQuery, methodRenameQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfRenameQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodRenameQuery, parametersOfRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRenameQuery.ShouldNotBeNull();
            parametersOfRenameQuery.Length.ShouldBe(1);
            methodRenameQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var message = this.CreateType<Message>();
            var methodRenameQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRenameQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRenameQuery, parametersOfRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            parametersOfRenameQuery.ShouldNotBeNull();
            parametersOfRenameQuery.Length.ShouldBe(1);
            methodRenameQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var methodRenameQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRenameQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var methodRenameQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRenameQuery, methodRenameQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRenameQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RenameQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RenameQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RenameQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRenameQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRenameQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.RemoveBookMark(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RemoveBookMark(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var message = this.CreateType<Message>();
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRemoveBookMark = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfRemoveBookMark);
            var result2 = this.GetResultOfMethod<Message>(MethodRemoveBookMark, parametersOfRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRemoveBookMark.ShouldNotBeNull();
            parametersOfRemoveBookMark.Length.ShouldBe(1);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var message = this.CreateType<Message>();
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRemoveBookMark = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRemoveBookMark, parametersOfRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            parametersOfRemoveBookMark.ShouldNotBeNull();
            parametersOfRemoveBookMark.Length.ShouldBe(1);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var methodRemoveBookMarkParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveBookMark, methodRemoveBookMarkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveBookMarkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveBookMark) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RemoveBookMark) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveBookMark_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveBookMark);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveBookMark, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _queryInstance.UpdatePostionForQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.UpdatePostionForQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var message = this.CreateType<Stream>();
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfUpdatePostionForQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfUpdatePostionForQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdatePostionForQuery.ShouldNotBeNull();
            parametersOfUpdatePostionForQuery.Length.ShouldBe(1);
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var message = this.CreateType<Stream>();
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfUpdatePostionForQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            parametersOfUpdatePostionForQuery.ShouldNotBeNull();
            parametersOfUpdatePostionForQuery.Length.ShouldBe(1);
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (UpdatePostionForQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_UpdatePostionForQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.DeleteQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.DeleteQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var message = this.CreateType<Message>();
            var methodDeleteQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQuery, methodDeleteQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfDeleteQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodDeleteQuery, parametersOfDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteQuery.ShouldNotBeNull();
            parametersOfDeleteQuery.Length.ShouldBe(1);
            methodDeleteQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var message = this.CreateType<Message>();
            var methodDeleteQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodDeleteQuery, parametersOfDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            parametersOfDeleteQuery.ShouldNotBeNull();
            parametersOfDeleteQuery.Length.ShouldBe(1);
            methodDeleteQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var methodDeleteQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var methodDeleteQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteQuery, methodDeleteQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (DeleteQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_DeleteQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.MoveQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.MoveQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var message = this.CreateType<Message>();
            var methodMoveQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMoveQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQuery, methodMoveQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfMoveQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodMoveQuery, parametersOfMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMoveQuery.ShouldNotBeNull();
            parametersOfMoveQuery.Length.ShouldBe(1);
            methodMoveQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var message = this.CreateType<Message>();
            var methodMoveQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfMoveQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodMoveQuery, parametersOfMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            parametersOfMoveQuery.ShouldNotBeNull();
            parametersOfMoveQuery.Length.ShouldBe(1);
            methodMoveQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var methodMoveQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMoveQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var methodMoveQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMoveQuery, methodMoveQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMoveQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MoveQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (MoveQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_MoveQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.CreateHomePageQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.CreateHomePageQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var message = this.CreateType<Message>();
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateHomePageQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfCreateHomePageQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodCreateHomePageQuery, parametersOfCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateHomePageQuery.ShouldNotBeNull();
            parametersOfCreateHomePageQuery.Length.ShouldBe(1);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var message = this.CreateType<Message>();
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCreateHomePageQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCreateHomePageQuery, parametersOfCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            parametersOfCreateHomePageQuery.ShouldNotBeNull();
            parametersOfCreateHomePageQuery.Length.ShouldBe(1);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var methodCreateHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateHomePageQuery, methodCreateHomePageQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateHomePageQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (CreateHomePageQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_CreateHomePageQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateHomePageQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.RemoveHomePageQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.RemoveHomePageQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var message = this.CreateType<Message>();
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRemoveHomePageQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfRemoveHomePageQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodRemoveHomePageQuery, parametersOfRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRemoveHomePageQuery.ShouldNotBeNull();
            parametersOfRemoveHomePageQuery.Length.ShouldBe(1);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var message = this.CreateType<Message>();
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfRemoveHomePageQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodRemoveHomePageQuery, parametersOfRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            parametersOfRemoveHomePageQuery.ShouldNotBeNull();
            parametersOfRemoveHomePageQuery.Length.ShouldBe(1);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var methodRemoveHomePageQueryParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveHomePageQuery, methodRemoveHomePageQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRemoveHomePageQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (RemoveHomePageQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_RemoveHomePageQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveHomePageQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveHomePageQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _queryInstance.SaveALLQuery(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.SaveALLQuery(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var message = this.CreateType<Stream>();
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSaveALLQuery = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, methodSaveALLQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfSaveALLQuery);
            var result2 = this.GetResultOfMethod<Message>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveALLQuery.ShouldNotBeNull();
            parametersOfSaveALLQuery.Length.ShouldBe(1);
            methodSaveALLQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var message = this.CreateType<Stream>();
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSaveALLQuery = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            parametersOfSaveALLQuery.ShouldNotBeNull();
            parametersOfSaveALLQuery.Length.ShouldBe(1);
            methodSaveALLQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveALLQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveALLQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (SaveALLQuery) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveALLQuery_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryInstance.GetHomePageConfig(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.GetHomePageConfig(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var message = this.CreateType<Message>();
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageConfig = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfGetHomePageConfig);
            var result2 = this.GetResultOfMethod<Message>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageConfig.ShouldNotBeNull();
            parametersOfGetHomePageConfig.Length.ShouldBe(1);
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var message = this.CreateType<Message>();
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetHomePageConfig = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            parametersOfGetHomePageConfig.ShouldNotBeNull();
            parametersOfGetHomePageConfig.Length.ShouldBe(1);
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetHomePageConfig) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_GetHomePageConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var message = this.CreateType<Stream>();

            // Act
            Action executeAction = () => _queryInstance.SaveHomePageConfig(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var message = this.CreateType<Stream>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryInstance.SaveHomePageConfig(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var message = this.CreateType<Stream>();
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSaveHomePageConfig = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryInstanceFixture, parametersOfSaveHomePageConfig);
            var result2 = this.GetResultOfMethod<Message>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveHomePageConfig.ShouldNotBeNull();
            parametersOfSaveHomePageConfig.Length.ShouldBe(1);
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var message = this.CreateType<Stream>();
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(Stream) };
            object[] parametersOfSaveHomePageConfig = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            parametersOfSaveHomePageConfig.ShouldNotBeNull();
            parametersOfSaveHomePageConfig.Length.ShouldBe(1);
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(Stream) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(Stream) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (SaveHomePageConfig) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Query_SaveHomePageConfig_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}