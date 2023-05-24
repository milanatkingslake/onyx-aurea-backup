using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.OGSOEASContract;
using OnyxSDK.Public.OGSOEASServiceContract;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.OGSOEASServiceContract
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.OGSOEASServiceContract.OnyxOGSOEASServiceContract" />)
    ///     and namespace <see cref="OnyxSDK.Public.OGSOEASServiceContract"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class OnyxOGSOEASServiceContractTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxOGSOEASServiceContract" />)
        /// </summary>
        public OnyxOGSOEASServiceContractTest() : base(typeof(OnyxOGSOEASServiceContract))
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

        #region General Initializer : Class (OnyxOGSOEASServiceContract) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxOGSOEASServiceContractInstanceType;
        private OnyxOGSOEASServiceContract _onyxOGSOEASServiceContractInstance;
        private OnyxOGSOEASServiceContract _onyxOGSOEASServiceContractInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxOGSOEASServiceContract" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxOGSOEASServiceContractInstanceType = typeof(OnyxOGSOEASServiceContract);
            _onyxOGSOEASServiceContractInstanceFixture = this.Create<OnyxOGSOEASServiceContract>(false);
            _onyxOGSOEASServiceContractInstance = _onyxOGSOEASServiceContractInstanceFixture ?? this.Create<OnyxOGSOEASServiceContract>(true);
            CurrentInstance = _onyxOGSOEASServiceContractInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASServiceContract) Initializer

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodExecuteWithResponse = "ExecuteWithResponse";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxOGSOEASServiceContract) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASServiceContract" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASServiceContract_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OnyxOGSOEASServiceContract) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASServiceContract" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxOGSOEASServiceContract_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxOGSOEASServiceContract)

        #region General Initializer : Class (OnyxOGSOEASServiceContract) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASServiceContract" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodExecuteWithResponse, 0)]
        public void AUT_OnyxOGSOEASServiceContract_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxOGSOEASServiceContract) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASServiceContract" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOGSOEASServiceContract_Is_Instance_Present_Test()
        {
            // Assert
            _onyxOGSOEASServiceContractInstanceType.ShouldNotBeNull();
            _onyxOGSOEASServiceContractInstance.ShouldNotBeNull();
            _onyxOGSOEASServiceContractInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxOGSOEASServiceContract) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxOGSOEASServiceContract" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxOGSOEASServiceContract_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxOGSOEASServiceContractInstance.ShouldBeAssignableTo<OnyxOGSOEASServiceContract>();
            _onyxOGSOEASServiceContractInstanceFixture.ShouldBeAssignableTo<OnyxOGSOEASServiceContract>();
            CurrentInstance.ShouldBeAssignableTo<OnyxOGSOEASServiceContract>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxOGSOEASServiceContract) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxOGSOEASServiceContract_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxOGSOEASServiceContract instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var requestData = this.CreateType<OGSOEASTransactionExecuteData>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceContractInstance.Execute(requestData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var requestData = this.CreateType<OGSOEASTransactionExecuteData>();
            var returnedValue = default(OGSOEASResponseData);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceContractInstance.Execute(requestData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var requestData = this.CreateType<OGSOEASTransactionExecuteData>();
            var methodExecuteParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteData) };
            object[] parametersOfExecute = { requestData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OGSOEASResponseData>(_onyxOGSOEASServiceContractInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<OGSOEASResponseData>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var requestData = this.CreateType<OGSOEASTransactionExecuteData>();
            var methodExecuteParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteData) };
            object[] parametersOfExecute = { requestData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OGSOEASResponseData>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteData) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteData) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : OGSOEASResponseData) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_Internally(Type[] types)
        {
            var methodExecuteWithResponseParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteWithResponse, methodExecuteWithResponseParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var requestData = this.CreateType<OGSOEASTransactionExecuteWithResponseData>();

            // Act
            Action executeAction = () => _onyxOGSOEASServiceContractInstance.ExecuteWithResponse(requestData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var requestData = this.CreateType<OGSOEASTransactionExecuteWithResponseData>();
            var returnedValue = default(OGSOEASResponseData);

            // Act
            Action executeAction = () => returnedValue = _onyxOGSOEASServiceContractInstance.ExecuteWithResponse(requestData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var requestData = this.CreateType<OGSOEASTransactionExecuteWithResponseData>();
            var methodExecuteWithResponseParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteWithResponseData) };
            object[] parametersOfExecuteWithResponse = { requestData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithResponse, methodExecuteWithResponseParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OGSOEASResponseData>(_onyxOGSOEASServiceContractInstanceFixture, parametersOfExecuteWithResponse);
            var result2 = this.GetResultOfMethod<OGSOEASResponseData>(MethodExecuteWithResponse, parametersOfExecuteWithResponse, methodExecuteWithResponseParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteWithResponse.ShouldNotBeNull();
            parametersOfExecuteWithResponse.Length.ShouldBe(1);
            methodExecuteWithResponseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var requestData = this.CreateType<OGSOEASTransactionExecuteWithResponseData>();
            var methodExecuteWithResponseParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteWithResponseData) };
            object[] parametersOfExecuteWithResponse = { requestData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<OGSOEASResponseData>(MethodExecuteWithResponse, parametersOfExecuteWithResponse, methodExecuteWithResponseParametersTypes);

            // Assert
            parametersOfExecuteWithResponse.ShouldNotBeNull();
            parametersOfExecuteWithResponse.Length.ShouldBe(1);
            methodExecuteWithResponseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var methodExecuteWithResponseParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteWithResponseData) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteWithResponse, methodExecuteWithResponseParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteWithResponseParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var methodExecuteWithResponseParametersTypes = new Type[] { typeof(OGSOEASTransactionExecuteWithResponseData) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteWithResponse, methodExecuteWithResponseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteWithResponseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithResponse, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteWithResponse) (Return Type : OGSOEASResponseData) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxOGSOEASServiceContract_ExecuteWithResponse_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteWithResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteWithResponse, 0);
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