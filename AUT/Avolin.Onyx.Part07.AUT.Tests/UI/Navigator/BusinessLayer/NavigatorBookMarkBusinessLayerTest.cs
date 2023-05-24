using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.BusinessLayer;
using Onyx.UI.Navigator.Model;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorBookMarkBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorBookMarkBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorBookMarkBusinessLayer" />)
        /// </summary>
        public NavigatorBookMarkBusinessLayerTest() : base(typeof(NavigatorBookMarkBusinessLayer))
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

        #region General Initializer : Class (NavigatorBookMarkBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorBookMarkBusinessLayerInstanceType;
        private NavigatorBookMarkBusinessLayer _navigatorBookMarkBusinessLayerInstance;
        private NavigatorBookMarkBusinessLayer _navigatorBookMarkBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorBookMarkBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorBookMarkBusinessLayerInstanceType = typeof(NavigatorBookMarkBusinessLayer);
            _navigatorBookMarkBusinessLayerInstanceFixture = this.Create<NavigatorBookMarkBusinessLayer>(false);
            _navigatorBookMarkBusinessLayerInstance = _navigatorBookMarkBusinessLayerInstanceFixture ?? this.Create<NavigatorBookMarkBusinessLayer>(true);
            CurrentInstance = _navigatorBookMarkBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorBookMarkBusinessLayer) Initializer

        #region Methods

        private const string MethodGetQueryTree = "GetQueryTree";
        private const string MethodSaveALLQuery = "SaveALLQuery";
        private const string MethodGetHomePageQueries = "GetHomePageQueries";
        private const string MethodGetQueryResults = "GetQueryResults";
        private const string MethodUpdatePostionForQuery = "UpdatePostionForQuery";
        private const string MethodGetHomePageConfig = "GetHomePageConfig";
        private const string MethodSaveHomePageConfig = "SaveHomePageConfig";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorBookMarkBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorBookMarkBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorBookMarkBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorBookMarkBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorBookMarkBusinessLayer)

        #region General Initializer : Class (NavigatorBookMarkBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetQueryTree, 0)]
        [TestCase(MethodSaveALLQuery, 0)]
        [TestCase(MethodGetHomePageQueries, 0)]
        [TestCase(MethodGetQueryResults, 0)]
        [TestCase(MethodUpdatePostionForQuery, 0)]
        [TestCase(MethodGetHomePageConfig, 0)]
        [TestCase(MethodSaveHomePageConfig, 0)]
        public void AUT_NavigatorBookMarkBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorBookMarkBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorBookMarkBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorBookMarkBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorBookMarkBusinessLayerInstance.ShouldNotBeNull();
            _navigatorBookMarkBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorBookMarkBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorBookMarkBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorBookMarkBusinessLayerInstance.ShouldBeAssignableTo<NavigatorBookMarkBusinessLayer>();
            _navigatorBookMarkBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorBookMarkBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorBookMarkBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorBookMarkBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorBookMarkBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorBookMarkBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.GetQueryTree(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(QueryTreeDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.GetQueryTree(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetQueryTreeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetQueryTree = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, methodGetQueryTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<QueryTreeDataSource>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfGetQueryTree);
            var result2 = this.GetResultOfMethod<QueryTreeDataSource>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryTree.ShouldNotBeNull();
            parametersOfGetQueryTree.Length.ShouldBe(1);
            methodGetQueryTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetQueryTreeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetQueryTree = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<QueryTreeDataSource>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            parametersOfGetQueryTree.ShouldNotBeNull();
            parametersOfGetQueryTree.Length.ShouldBe(1);
            methodGetQueryTreeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var methodGetQueryTreeParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryTreeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var methodGetQueryTreeParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryTreeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetQueryTree) (Return Type : QueryTreeDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryTree_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_Internally(Type[] types)
        {
            var methodSaveALLQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.SaveALLQuery(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.SaveALLQuery(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfSaveALLQuery = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, methodSaveALLQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfSaveALLQuery);
            var result2 = this.GetResultOfMethod<string>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

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

        #region Method Call : (SaveALLQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfSaveALLQuery = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            parametersOfSaveALLQuery.ShouldNotBeNull();
            parametersOfSaveALLQuery.Length.ShouldBe(1);
            methodSaveALLQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveALLQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var methodSaveALLQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveALLQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (SaveALLQuery) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveALLQuery_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageQueriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.GetHomePageQueries(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<HomeQueryInfo>);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.GetHomePageQueries(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetHomePageQueries = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<HomeQueryInfo>>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfGetHomePageQueries);
            var result2 = this.GetResultOfMethod<List<HomeQueryInfo>>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

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

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetHomePageQueries = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<HomeQueryInfo>>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            parametersOfGetHomePageQueries.ShouldNotBeNull();
            parametersOfGetHomePageQueries.Length.ShouldBe(1);
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var methodGetHomePageQueriesParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetHomePageQueries) (Return Type : List<HomeQueryInfo>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageQueries_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryResultsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.GetQueryResults(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ResultGrid);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.GetQueryResults(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetQueryResults = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, methodGetQueryResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ResultGrid>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfGetQueryResults);
            var result2 = this.GetResultOfMethod<ResultGrid>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

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

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetQueryResults = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultGrid>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            parametersOfGetQueryResults.ShouldNotBeNull();
            parametersOfGetQueryResults.Length.ShouldBe(1);
            methodGetQueryResultsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var methodGetQueryResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetQueryResults) (Return Type : ResultGrid) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetQueryResults_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_Internally(Type[] types)
        {
            var methodUpdatePostionForQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.UpdatePostionForQuery(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.UpdatePostionForQuery(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUpdatePostionForQuery = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfUpdatePostionForQuery);
            var result2 = this.GetResultOfMethod<string>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

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

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfUpdatePostionForQuery = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            parametersOfUpdatePostionForQuery.ShouldNotBeNull();
            parametersOfUpdatePostionForQuery.Length.ShouldBe(1);
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var methodUpdatePostionForQueryParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdatePostionForQueryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (UpdatePostionForQuery) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_UpdatePostionForQuery_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.GetHomePageConfig(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(HomePageConfig);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.GetHomePageConfig(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetHomePageConfig = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<HomePageConfig>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfGetHomePageConfig);
            var result2 = this.GetResultOfMethod<HomePageConfig>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

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

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetHomePageConfig = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<HomePageConfig>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            parametersOfGetHomePageConfig.ShouldNotBeNull();
            parametersOfGetHomePageConfig.Length.ShouldBe(1);
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var methodGetHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageConfigParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetHomePageConfig) (Return Type : HomePageConfig) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_GetHomePageConfig_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (SaveHomePageConfig) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodSaveHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorBookMarkBusinessLayerInstance.SaveHomePageConfig(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkBusinessLayerInstance.SaveHomePageConfig(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfSaveHomePageConfig = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorBookMarkBusinessLayerInstanceFixture, parametersOfSaveHomePageConfig);
            var result2 = this.GetResultOfMethod<string>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

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

        #region Method Call : (SaveHomePageConfig) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfSaveHomePageConfig = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            parametersOfSaveHomePageConfig.ShouldNotBeNull();
            parametersOfSaveHomePageConfig.Length.ShouldBe(1);
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var methodSaveHomePageConfigParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveHomePageConfigParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (SaveHomePageConfig) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkBusinessLayer_SaveHomePageConfig_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}