using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.QueryHelper" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\QueryHelper.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class QueryHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="QueryHelper" />)
        /// </summary>
        public QueryHelperTest() : base(typeof(QueryHelper))
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

        #endregion

        #region General Instance : Class (QueryHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_QueryHelper_Is_Instance_Present_Test()
        {
            // Assert
            _queryHelperInstanceType.ShouldNotBeNull();
            _queryHelperInstance.ShouldNotBeNull();
            _queryHelperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (QueryHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="QueryHelper" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
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

        #region General Constructor : Class (QueryHelper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_QueryHelper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            QueryHelper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryHelperInstance.GetQueryProfile(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.GetQueryProfile(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var message = this.CreateType<Message>();
            var methodGetQueryProfileParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryProfile = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryProfile, methodGetQueryProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryHelperInstanceFixture, parametersOfGetQueryProfile);
            var result2 = this.GetResultOfMethod<Message>(MethodGetQueryProfile, parametersOfGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryProfile.ShouldNotBeNull();
            parametersOfGetQueryProfile.Length.ShouldBe(1);
            methodGetQueryProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var message = this.CreateType<Message>();
            var methodGetQueryProfileParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryProfile = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetQueryProfile, parametersOfGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            parametersOfGetQueryProfile.ShouldNotBeNull();
            parametersOfGetQueryProfile.Length.ShouldBe(1);
            methodGetQueryProfileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var methodGetQueryProfileParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryProfileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var methodGetQueryProfileParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryProfile, methodGetQueryProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryProfileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryProfile) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetQueryProfile) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryProfile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryProfile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryHelperInstance.GetQueryResult(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.GetQueryResult(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var message = this.CreateType<Message>();
            var methodGetQueryResultParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryResult = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResult, methodGetQueryResultParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryHelperInstanceFixture, parametersOfGetQueryResult);
            var result2 = this.GetResultOfMethod<Message>(MethodGetQueryResult, parametersOfGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryResult.ShouldNotBeNull();
            parametersOfGetQueryResult.Length.ShouldBe(1);
            methodGetQueryResultParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var message = this.CreateType<Message>();
            var methodGetQueryResultParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetQueryResult = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetQueryResult, parametersOfGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            parametersOfGetQueryResult.ShouldNotBeNull();
            parametersOfGetQueryResult.Length.ShouldBe(1);
            methodGetQueryResultParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var methodGetQueryResultParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var methodGetQueryResultParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResult, methodGetQueryResultParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetQueryResult) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (GetQueryResult) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_GetQueryResult_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResult);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResult, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _queryHelperInstance.DeleteStagedData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _queryHelperInstance.DeleteStagedData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var message = this.CreateType<Message>();
            var methodDeleteStagedDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteStagedData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_queryHelperInstanceFixture, parametersOfDeleteStagedData);
            var result2 = this.GetResultOfMethod<Message>(MethodDeleteStagedData, parametersOfDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDeleteStagedData.ShouldNotBeNull();
            parametersOfDeleteStagedData.Length.ShouldBe(1);
            methodDeleteStagedDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var message = this.CreateType<Message>();
            var methodDeleteStagedDataParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfDeleteStagedData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodDeleteStagedData, parametersOfDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            parametersOfDeleteStagedData.ShouldNotBeNull();
            parametersOfDeleteStagedData.Length.ShouldBe(1);
            methodDeleteStagedDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var methodDeleteStagedDataParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDeleteStagedDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var methodDeleteStagedDataParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteStagedData, methodDeleteStagedDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteStagedDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteStagedData) (Return Type : Message) without parameters value verify result should be null.

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

        #region Method Call : (DeleteStagedData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_QueryHelper_DeleteStagedData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteStagedData);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteStagedData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}