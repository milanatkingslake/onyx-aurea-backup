using System;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.QueryHelper" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class QueryHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryHelper" />)
        /// </summary>
        public QueryHelperTest() : base(typeof(QueryHelper))
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

        #region General Initializer : Class (QueryHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _queryHelperInstanceType;
        private QueryHelper _queryHelperInstance;
        private QueryHelper _queryHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="QueryHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _queryHelperInstanceType = typeof(QueryHelper);
            _queryHelperInstanceFixture = this.Create<QueryHelper>(false);
            _queryHelperInstance = _queryHelperInstanceFixture ?? this.Create<QueryHelper>(true);
            CurrentInstance = _queryHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (QueryHelper) Initializer

        #region Methods

        private const string MethodGetQueryProfile = "GetQueryProfile";
        private const string MethodGetQueryResult = "GetQueryResult";
        private const string MethodDeleteStagedData = "DeleteStagedData";
        private const string MethodPersistQueryProfileAndResult = "PersistQueryProfileAndResult";

        #endregion

        #region Fields

        private const string FieldservicePersistence = "servicePersistence";

        #endregion

        #endregion

        #region General Initializer : Class (QueryHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (QueryHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_QueryHelper_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (QueryHelper)

        #region General Initializer : Class (QueryHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetQueryProfile, 0)]
        [TestCase(MethodGetQueryResult, 0)]
        [TestCase(MethodDeleteStagedData, 0)]
        [TestCase(MethodPersistQueryProfileAndResult, 0)]
        public void AUT_QueryHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (QueryHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldservicePersistence)]
        [Category("AUT Fields")]
        public void AUT_QueryHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (QueryHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _queryHelperInstance.ShouldBeAssignableTo<QueryHelper>();
            _queryHelperInstanceFixture.ShouldBeAssignableTo<QueryHelper>();
            CurrentInstance.ShouldBeAssignableTo<QueryHelper>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetQueryProfile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);

            // Act
            Action executeAction = () => _queryHelperInstance.GetQueryProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.GetQueryProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            Type [] methodGetQueryProfileParametersTypes = null;
            object[] parametersOfGetQueryProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryProfile, methodGetQueryProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryHelperInstanceFixture, parametersOfGetQueryProfile);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryProfile, parametersOfGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryProfile.ShouldBeNull();
            methodGetQueryProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            Type [] methodGetQueryProfileParametersTypes = null;
            object[] parametersOfGetQueryProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryProfile, parametersOfGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            parametersOfGetQueryProfile.ShouldBeNull();
            methodGetQueryProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            Type [] methodGetQueryProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            Type [] methodGetQueryProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryHelper_GetQueryResult_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryResultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryResult, methodGetQueryResultParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);

            // Act
            Action executeAction = () => _queryHelperInstance.GetQueryResult();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.GetQueryResult();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            Type [] methodGetQueryResultParametersTypes = null;
            object[] parametersOfGetQueryResult = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResult, methodGetQueryResultParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryHelperInstanceFixture, parametersOfGetQueryResult);
            var result2 = this.GetResultOfMethod<string>(MethodGetQueryResult, parametersOfGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryResult.ShouldBeNull();
            methodGetQueryResultParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            Type [] methodGetQueryResultParametersTypes = null;
            object[] parametersOfGetQueryResult = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetQueryResult, parametersOfGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            parametersOfGetQueryResult.ShouldBeNull();
            methodGetQueryResultParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            Type [] methodGetQueryResultParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            Type [] methodGetQueryResultParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryHelper_DeleteStagedData_Method_Call_Internally(Type[] types)
        {
            var methodDeleteStagedDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);

            // Act
            Action executeAction = () => _queryHelperInstance.DeleteStagedData();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.DeleteStagedData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            Type [] methodDeleteStagedDataParametersTypes = null;
            object[] parametersOfDeleteStagedData = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_queryHelperInstanceFixture, parametersOfDeleteStagedData);
            var result2 = this.GetResultOfMethod<string>(MethodDeleteStagedData, parametersOfDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteStagedData.ShouldBeNull();
            methodDeleteStagedDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            Type [] methodDeleteStagedDataParametersTypes = null;
            object[] parametersOfDeleteStagedData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodDeleteStagedData, parametersOfDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            parametersOfDeleteStagedData.ShouldBeNull();
            methodDeleteStagedDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            Type [] methodDeleteStagedDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteStagedDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            Type [] methodDeleteStagedDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteStagedDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteStagedData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_Internally(Type[] types)
        {
            var methodPersistQueryProfileAndResultParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var doc = this.CreateType<XElement>();
            var rootNode = this.CreateType<string>();
            var recordNode = this.CreateType<string>();
            var pageSize = this.CreateType<int>();
            var pageCount = this.CreateType<int>();

            // Act
            Action executeAction = () => _queryHelperInstance.PersistQueryProfileAndResult(doc, rootNode, recordNode, pageSize, out pageCount);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var doc = this.CreateType<XElement>();
            var rootNode = this.CreateType<string>();
            var recordNode = this.CreateType<string>();
            var pageSize = this.CreateType<int>();
            var pageCount = this.CreateType<int>();
            var returnedValue = default(QueryProfile);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.PersistQueryProfileAndResult(doc, rootNode, recordNode, pageSize, out pageCount);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var doc = this.CreateType<XElement>();
            var rootNode = this.CreateType<string>();
            var recordNode = this.CreateType<string>();
            var pageSize = this.CreateType<int>();
            var pageCount = this.CreateType<int>();
            var methodPersistQueryProfileAndResultParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfPersistQueryProfileAndResult = { doc, rootNode, recordNode, pageSize, pageCount };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<QueryProfile>(_queryHelperInstanceFixture, parametersOfPersistQueryProfileAndResult);
            var result2 = this.GetResultOfMethod<QueryProfile>(MethodPersistQueryProfileAndResult, parametersOfPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPersistQueryProfileAndResult.ShouldNotBeNull();
            parametersOfPersistQueryProfileAndResult.Length.ShouldBe(5);
            methodPersistQueryProfileAndResultParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var doc = this.CreateType<XElement>();
            var rootNode = this.CreateType<string>();
            var recordNode = this.CreateType<string>();
            var pageSize = this.CreateType<int>();
            var pageCount = this.CreateType<int>();
            var methodPersistQueryProfileAndResultParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string), typeof(int), typeof(int) };
            object[] parametersOfPersistQueryProfileAndResult = { doc, rootNode, recordNode, pageSize, pageCount };

            // Act
            Action currentAction = () => this.GetResultOfMethod<QueryProfile>(MethodPersistQueryProfileAndResult, parametersOfPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes);

            // Assert
            parametersOfPersistQueryProfileAndResult.ShouldNotBeNull();
            parametersOfPersistQueryProfileAndResult.Length.ShouldBe(5);
            methodPersistQueryProfileAndResultParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var methodPersistQueryProfileAndResultParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string), typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPersistQueryProfileAndResultParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var methodPersistQueryProfileAndResultParametersTypes = new Type[] { typeof(XElement), typeof(string), typeof(string), typeof(int), typeof(int) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPersistQueryProfileAndResult, methodPersistQueryProfileAndResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPersistQueryProfileAndResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var currentMethodInfo = this.GetMethodInfo(MethodPersistQueryProfileAndResult, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PersistQueryProfileAndResult) (Return Type : QueryProfile) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_PersistQueryProfileAndResult_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPersistQueryProfileAndResult);
            var currentMethodInfo = this.GetMethodInfo(MethodPersistQueryProfileAndResult, 0);
            const int parametersCount = 5;

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