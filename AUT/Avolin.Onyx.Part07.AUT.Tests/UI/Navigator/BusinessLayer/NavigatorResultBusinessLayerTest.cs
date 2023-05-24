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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.BusinessLayer.NavigatorResultBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorResultBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorResultBusinessLayer" />)
        /// </summary>
        public NavigatorResultBusinessLayerTest() : base(typeof(NavigatorResultBusinessLayer))
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

        #region General Initializer : Class (NavigatorResultBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorResultBusinessLayerInstanceType;
        private NavigatorResultBusinessLayer _navigatorResultBusinessLayerInstance;
        private NavigatorResultBusinessLayer _navigatorResultBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorResultBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorResultBusinessLayerInstanceType = typeof(NavigatorResultBusinessLayer);
            _navigatorResultBusinessLayerInstanceFixture = this.Create<NavigatorResultBusinessLayer>(false);
            _navigatorResultBusinessLayerInstance = _navigatorResultBusinessLayerInstanceFixture ?? this.Create<NavigatorResultBusinessLayer>(true);
            CurrentInstance = _navigatorResultBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorResultBusinessLayer) Initializer

        #region Methods

        private const string MethodGetResults = "GetResults";
        private const string MethodWatchInsertUpdate = "WatchInsertUpdate";
        private const string MethodGetWatchRecords = "GetWatchRecords";
        private const string MethodGetResultGridProfile = "GetResultGridProfile";
        private const string MethodMergeCustomers = "MergeCustomers";
        private const string MethodGetBatchUpdateFields = "GetBatchUpdateFields";
        private const string MethodBatchUpdate = "BatchUpdate";
        private const string MethodBatchUpdateRecallDate = "BatchUpdateRecallDate";
        private const string MethodPutResultGridProfile = "PutResultGridProfile";
        private const string MethodGetGamConfiguration = "GetGamConfiguration";
        private const string MethodGetLboMappingDetails = "GetLboMappingDetails";
        private const string MethodPutRestoreDefaultResultFilter = "PutRestoreDefaultResultFilter";
        private const string MethodGetResultActionData = "GetResultActionData";
        private const string MethodDispose = "Dispose";

        #endregion

        #region Fields

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorResultBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorResultBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorResultBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorResultBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorResultBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorResultBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorResultBusinessLayer)

        #region General Initializer : Class (NavigatorResultBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorResultBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetResults, 0)]
        [TestCase(MethodWatchInsertUpdate, 0)]
        [TestCase(MethodGetWatchRecords, 0)]
        [TestCase(MethodGetResultGridProfile, 0)]
        [TestCase(MethodMergeCustomers, 0)]
        [TestCase(MethodGetBatchUpdateFields, 0)]
        [TestCase(MethodBatchUpdate, 0)]
        [TestCase(MethodBatchUpdateRecallDate, 0)]
        [TestCase(MethodPutResultGridProfile, 0)]
        [TestCase(MethodGetGamConfiguration, 0)]
        [TestCase(MethodGetLboMappingDetails, 0)]
        [TestCase(MethodPutRestoreDefaultResultFilter, 0)]
        [TestCase(MethodGetResultActionData, 0)]
        public void AUT_NavigatorResultBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NavigatorResultBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorResultBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorResultBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorResultBusinessLayerInstanceType.ShouldNotBeNull();
            _navigatorResultBusinessLayerInstance.ShouldNotBeNull();
            _navigatorResultBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorResultBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorResultBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorResultBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorResultBusinessLayerInstance.ShouldBeAssignableTo<NavigatorResultBusinessLayer>();
            _navigatorResultBusinessLayerInstanceFixture.ShouldBeAssignableTo<NavigatorResultBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorResultBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorResultBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorResultBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NavigatorResultBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetResults) (Return Type : ResultGrid) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_Internally(Type[] types)
        {
            var methodGetResultsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetResults(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ResultGrid);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetResults(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetResults = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, methodGetResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ResultGrid>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetResults);
            var result2 = this.GetResultOfMethod<ResultGrid>(MethodGetResults, parametersOfGetResults, methodGetResultsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResults.ShouldNotBeNull();
            parametersOfGetResults.Length.ShouldBe(1);
            methodGetResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetResults = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultGrid>(MethodGetResults, parametersOfGetResults, methodGetResultsParametersTypes);

            // Assert
            parametersOfGetResults.ShouldNotBeNull();
            parametersOfGetResults.Length.ShouldBe(1);
            methodGetResultsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var methodGetResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var methodGetResultsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : ResultGrid) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResults_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_Internally(Type[] types)
        {
            var methodWatchInsertUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.WatchInsertUpdate(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.WatchInsertUpdate(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfWatchInsertUpdate = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorResultBusinessLayerInstanceFixture, parametersOfWatchInsertUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodWatchInsertUpdate, parametersOfWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfWatchInsertUpdate.ShouldNotBeNull();
            parametersOfWatchInsertUpdate.Length.ShouldBe(1);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfWatchInsertUpdate = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodWatchInsertUpdate, parametersOfWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            parametersOfWatchInsertUpdate.ShouldNotBeNull();
            parametersOfWatchInsertUpdate.Length.ShouldBe(1);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_WatchInsertUpdate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_Internally(Type[] types)
        {
            var methodGetWatchRecordsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetWatchRecords(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(KeyValuePair<string, List<string>>);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetWatchRecords(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetWatchRecords = { mainfest };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<KeyValuePair<string, List<string>>>(_navigatorResultBusinessLayerInstanceFixture, out exception1, parametersOfGetWatchRecords);
            var result2 = this.GetResultOfMethod<KeyValuePair<string, List<string>>>(MethodGetWatchRecords, parametersOfGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetWatchRecords.ShouldNotBeNull();
            parametersOfGetWatchRecords.Length.ShouldBe(1);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetWatchRecords = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<KeyValuePair<string, List<string>>>(MethodGetWatchRecords, parametersOfGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            parametersOfGetWatchRecords.ShouldNotBeNull();
            parametersOfGetWatchRecords.Length.ShouldBe(1);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : KeyValuePair<string, List<string>>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetWatchRecords_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetResultGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetResultGridProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ResultAdminDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetResultGridProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetResultGridProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ResultAdminDataSource>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetResultGridProfile);
            var result2 = this.GetResultOfMethod<ResultAdminDataSource>(MethodGetResultGridProfile, parametersOfGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultGridProfile.ShouldNotBeNull();
            parametersOfGetResultGridProfile.Length.ShouldBe(1);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetResultGridProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultAdminDataSource>(MethodGetResultGridProfile, parametersOfGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            parametersOfGetResultGridProfile.ShouldNotBeNull();
            parametersOfGetResultGridProfile.Length.ShouldBe(1);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var methodGetResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultGridProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : ResultAdminDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultGridProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_Internally(Type[] types)
        {
            var methodMergeCustomersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.MergeCustomers(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.MergeCustomers(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodMergeCustomersParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfMergeCustomers = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomers, methodMergeCustomersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorResultBusinessLayerInstanceFixture, parametersOfMergeCustomers);
            var result2 = this.GetResultOfMethod<string>(MethodMergeCustomers, parametersOfMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeCustomers.ShouldNotBeNull();
            parametersOfMergeCustomers.Length.ShouldBe(1);
            methodMergeCustomersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodMergeCustomersParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfMergeCustomers = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodMergeCustomers, parametersOfMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            parametersOfMergeCustomers.ShouldNotBeNull();
            parametersOfMergeCustomers.Length.ShouldBe(1);
            methodMergeCustomersParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var methodMergeCustomersParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeCustomersParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var methodMergeCustomersParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeCustomersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_MergeCustomers_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomers, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_Internally(Type[] types)
        {
            var methodGetBatchUpdateFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetBatchUpdateFields(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<BatchUpdateField>);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetBatchUpdateFields(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetBatchUpdateFields = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<BatchUpdateField>>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetBatchUpdateFields);
            var result2 = this.GetResultOfMethod<List<BatchUpdateField>>(MethodGetBatchUpdateFields, parametersOfGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBatchUpdateFields.ShouldNotBeNull();
            parametersOfGetBatchUpdateFields.Length.ShouldBe(1);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetBatchUpdateFields = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<BatchUpdateField>>(MethodGetBatchUpdateFields, parametersOfGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdateFields.ShouldNotBeNull();
            parametersOfGetBatchUpdateFields.Length.ShouldBe(1);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var methodGetBatchUpdateFieldsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdateFieldsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : List<BatchUpdateField>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetBatchUpdateFields_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.BatchUpdate(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.BatchUpdate(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfBatchUpdate = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, methodBatchUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorResultBusinessLayerInstanceFixture, parametersOfBatchUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdate.ShouldNotBeNull();
            parametersOfBatchUpdate.Length.ShouldBe(1);
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodBatchUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfBatchUpdate = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            parametersOfBatchUpdate.ShouldNotBeNull();
            parametersOfBatchUpdate.Length.ShouldBe(1);
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var methodBatchUpdateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.BatchUpdateRecallDate(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.BatchUpdateRecallDate(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfBatchUpdateRecallDate = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_navigatorResultBusinessLayerInstanceFixture, parametersOfBatchUpdateRecallDate);
            var result2 = this.GetResultOfMethod<string>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdateRecallDate.ShouldNotBeNull();
            parametersOfBatchUpdateRecallDate.Length.ShouldBe(1);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfBatchUpdateRecallDate = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodBatchUpdateRecallDate, parametersOfBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            parametersOfBatchUpdateRecallDate.ShouldNotBeNull();
            parametersOfBatchUpdateRecallDate.Length.ShouldBe(1);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var methodBatchUpdateRecallDateParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdateRecallDate, methodBatchUpdateRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateRecallDateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdateRecallDate) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_BatchUpdateRecallDate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdateRecallDate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodPutResultGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPutResultGridProfile, methodPutResultGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.PutResultGridProfile(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<ServiceResult>);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.PutResultGridProfile(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutResultGridProfile = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPutResultGridProfile, methodPutResultGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ServiceResult>>(_navigatorResultBusinessLayerInstanceFixture, parametersOfPutResultGridProfile);
            var result2 = this.GetResultOfMethod<List<ServiceResult>>(MethodPutResultGridProfile, parametersOfPutResultGridProfile, methodPutResultGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPutResultGridProfile.ShouldNotBeNull();
            parametersOfPutResultGridProfile.Length.ShouldBe(1);
            methodPutResultGridProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutResultGridProfile = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ServiceResult>>(MethodPutResultGridProfile, parametersOfPutResultGridProfile, methodPutResultGridProfileParametersTypes);

            // Assert
            parametersOfPutResultGridProfile.ShouldNotBeNull();
            parametersOfPutResultGridProfile.Length.ShouldBe(1);
            methodPutResultGridProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var methodPutResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPutResultGridProfile, methodPutResultGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPutResultGridProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var methodPutResultGridProfileParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPutResultGridProfile, methodPutResultGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPutResultGridProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodPutResultGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutResultGridProfile) (Return Type : List<ServiceResult>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutResultGridProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodPutResultGridProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_Internally(Type[] types)
        {
            var methodGetGamConfigurationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetGamConfiguration(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(GamProfile);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetGamConfiguration(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetGamConfiguration = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<GamProfile>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetGamConfiguration);
            var result2 = this.GetResultOfMethod<GamProfile>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGamConfiguration.ShouldNotBeNull();
            parametersOfGetGamConfiguration.Length.ShouldBe(1);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetGamConfiguration = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<GamProfile>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            parametersOfGetGamConfiguration.ShouldNotBeNull();
            parametersOfGetGamConfiguration.Length.ShouldBe(1);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var methodGetGamConfigurationParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGamConfigurationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : GamProfile) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetGamConfiguration_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_Internally(Type[] types)
        {
            var methodGetLboMappingDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetLboMappingDetails(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(List<MappingsModel>);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetLboMappingDetails(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetLboMappingDetailsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetLboMappingDetails = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<MappingsModel>>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetLboMappingDetails);
            var result2 = this.GetResultOfMethod<List<MappingsModel>>(MethodGetLboMappingDetails, parametersOfGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMappingDetails.ShouldNotBeNull();
            parametersOfGetLboMappingDetails.Length.ShouldBe(1);
            methodGetLboMappingDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodGetLboMappingDetailsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfGetLboMappingDetails = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<MappingsModel>>(MethodGetLboMappingDetails, parametersOfGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            parametersOfGetLboMappingDetails.ShouldNotBeNull();
            parametersOfGetLboMappingDetails.Length.ShouldBe(1);
            methodGetLboMappingDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var methodGetLboMappingDetailsParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMappingDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var methodGetLboMappingDetailsParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMappingDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : List<MappingsModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetLboMappingDetails_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_Internally(Type[] types)
        {
            var methodPutRestoreDefaultResultFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var mainfest = this.CreateType<NavigatorManifest>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.PutRestoreDefaultResultFilter(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var returnedValue = default(ResultAdminDataSource);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.PutRestoreDefaultResultFilter(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutRestoreDefaultResultFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutRestoreDefaultResultFilter = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ResultAdminDataSource>(_navigatorResultBusinessLayerInstanceFixture, parametersOfPutRestoreDefaultResultFilter);
            var result2 = this.GetResultOfMethod<ResultAdminDataSource>(MethodPutRestoreDefaultResultFilter, parametersOfPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPutRestoreDefaultResultFilter.ShouldNotBeNull();
            parametersOfPutRestoreDefaultResultFilter.Length.ShouldBe(1);
            methodPutRestoreDefaultResultFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var mainfest = this.CreateType<NavigatorManifest>();
            var methodPutRestoreDefaultResultFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            object[] parametersOfPutRestoreDefaultResultFilter = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResultAdminDataSource>(MethodPutRestoreDefaultResultFilter, parametersOfPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes);

            // Assert
            parametersOfPutRestoreDefaultResultFilter.ShouldNotBeNull();
            parametersOfPutRestoreDefaultResultFilter.Length.ShouldBe(1);
            methodPutRestoreDefaultResultFilterParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var methodPutRestoreDefaultResultFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPutRestoreDefaultResultFilterParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var methodPutRestoreDefaultResultFilterParametersTypes = new Type[] { typeof(NavigatorManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPutRestoreDefaultResultFilter, methodPutRestoreDefaultResultFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPutRestoreDefaultResultFilterParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultResultFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PutRestoreDefaultResultFilter) (Return Type : ResultAdminDataSource) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_PutRestoreDefaultResultFilter_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPutRestoreDefaultResultFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodPutRestoreDefaultResultFilter, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_Internally(Type[] types)
        {
            var methodGetResultActionDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultActionData, methodGetResultActionDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var mainfest = this.CreateType<List<NavigatorManifest>>();

            // Act
            Action executeAction = () => _navigatorResultBusinessLayerInstance.GetResultActionData(mainfest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var returnedValue = default(List<ResultGridToolActionGroup>);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultBusinessLayerInstance.GetResultActionData(mainfest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetResultActionDataParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetResultActionData = { mainfest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionData, methodGetResultActionDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<List<ResultGridToolActionGroup>>(_navigatorResultBusinessLayerInstanceFixture, parametersOfGetResultActionData);
            var result2 = this.GetResultOfMethod<List<ResultGridToolActionGroup>>(MethodGetResultActionData, parametersOfGetResultActionData, methodGetResultActionDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultActionData.ShouldNotBeNull();
            parametersOfGetResultActionData.Length.ShouldBe(1);
            methodGetResultActionDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var mainfest = this.CreateType<List<NavigatorManifest>>();
            var methodGetResultActionDataParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            object[] parametersOfGetResultActionData = { mainfest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<ResultGridToolActionGroup>>(MethodGetResultActionData, parametersOfGetResultActionData, methodGetResultActionDataParametersTypes);

            // Assert
            parametersOfGetResultActionData.ShouldNotBeNull();
            parametersOfGetResultActionData.Length.ShouldBe(1);
            methodGetResultActionDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var methodGetResultActionDataParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultActionData, methodGetResultActionDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultActionDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var methodGetResultActionDataParametersTypes = new Type[] { typeof(List<NavigatorManifest>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultActionData, methodGetResultActionDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultActionDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultActionData) (Return Type : List<ResultGridToolActionGroup>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultBusinessLayer_GetResultActionData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultActionData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultActionData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_Dispose_Method_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #region Method Call : (Dispose) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultBusinessLayer_Dispose_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDisposeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDispose, methodDisposeParametersTypes);
        }

        #endregion

        #endregion

        #endregion
    }
}