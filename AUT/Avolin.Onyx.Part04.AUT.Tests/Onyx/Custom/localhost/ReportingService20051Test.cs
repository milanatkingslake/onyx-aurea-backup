using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Custom.localhost;
using Shouldly;

namespace Avolin.Onyx.Part04.AUT.Tests.Onyx.Custom.localhost
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportingService2005" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ReportingService20051Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20051Test() : base(typeof(ReportingService2005))
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

        #region General Initializer : Class (ReportingService2005) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private ReportingService2005 _reportingService2005Instance;
        private ReportingService2005 _reportingService2005InstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ReportingService2005" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _reportingService2005InstanceFixture = this.Create<ReportingService2005>(false);
            _reportingService2005Instance = _reportingService2005InstanceFixture ?? this.Create<ReportingService2005>(true);
            CurrentInstance = _reportingService2005Instance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ReportingService2005) Initializer
        
        #region Methods

        private const string MethodListSecureMethods = "ListSecureMethods";
        private const string MethodOnListSecureMethodsOperationCompleted = "OnListSecureMethodsOperationCompleted";
        private const string MethodCreateBatch = "CreateBatch";
        private const string MethodOnCreateBatchOperationCompleted = "OnCreateBatchOperationCompleted";
        private const string MethodCancelBatch = "CancelBatch";
        private const string MethodOnCancelBatchOperationCompleted = "OnCancelBatchOperationCompleted";
        private const string MethodExecuteBatch = "ExecuteBatch";
        private const string MethodOnExecuteBatchOperationCompleted = "OnExecuteBatchOperationCompleted";
        private const string MethodGetSystemProperties = "GetSystemProperties";
        private const string MethodOnGetSystemPropertiesOperationCompleted = "OnGetSystemPropertiesOperationCompleted";
        private const string MethodSetSystemProperties = "SetSystemProperties";
        private const string MethodOnSetSystemPropertiesOperationCompleted = "OnSetSystemPropertiesOperationCompleted";
        private const string MethodDeleteItem = "DeleteItem";
        private const string MethodOnDeleteItemOperationCompleted = "OnDeleteItemOperationCompleted";
        private const string MethodMoveItem = "MoveItem";
        private const string MethodOnMoveItemOperationCompleted = "OnMoveItemOperationCompleted";
        private const string MethodListChildren = "ListChildren";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (ListSecureMethods) (Return Type : string[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);

            // Act
            Action executeAction = () => _reportingService2005Instance.ListSecureMethods();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            var returnedValue = default(string[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListSecureMethods();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            Type [] methodListSecureMethodsParametersTypes = null;
            object[] parametersOfListSecureMethods = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListSecureMethods, methodListSecureMethodsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string[]>(_reportingService2005InstanceFixture, parametersOfListSecureMethods);
            var result2 = this.GetResultOfMethod<string[]>(MethodListSecureMethods, parametersOfListSecureMethods, methodListSecureMethodsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListSecureMethods.ShouldBeNull();
            methodListSecureMethodsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            Type [] methodListSecureMethodsParametersTypes = null;
            object[] parametersOfListSecureMethods = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string[]>(MethodListSecureMethods, parametersOfListSecureMethods, methodListSecureMethodsParametersTypes);

            // Assert
            parametersOfListSecureMethods.ShouldBeNull();
            methodListSecureMethodsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            Type [] methodListSecureMethodsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListSecureMethods, methodListSecureMethodsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListSecureMethodsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            Type [] methodListSecureMethodsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListSecureMethods, methodListSecureMethodsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListSecureMethodsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSecureMethods) (Return Type : string[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSecureMethods_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSecureMethods);
            var currentMethodInfo = this.GetMethodInfo(MethodListSecureMethods, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnListSecureMethodsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSecureMethodsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSecureMethodsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSecureMethodsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSecureMethodsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListSecureMethodsOperationCompleted, parametersOfOnListSecureMethodsOperationCompleted, methodOnListSecureMethodsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListSecureMethodsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSecureMethodsOperationCompleted.Length.ShouldBe(1);
            methodOnListSecureMethodsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSecureMethodsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSecureMethodsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSecureMethodsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSecureMethodsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSecureMethodsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSecureMethodsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListSecureMethodsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSecureMethodsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSecureMethodsOperationCompleted);
            var methodOnListSecureMethodsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListSecureMethodsOperationCompleted, methodOnListSecureMethodsOperationCompletedParametersTypes);

            // Assert
            methodOnListSecureMethodsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSecureMethodsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSecureMethodsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSecureMethodsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSecureMethodsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateBatch();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateBatch();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            Type [] methodCreateBatchParametersTypes = null;
            object[] parametersOfCreateBatch = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBatch, methodCreateBatchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfCreateBatch);
            var result2 = this.GetResultOfMethod<string>(MethodCreateBatch, parametersOfCreateBatch, methodCreateBatchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateBatch.ShouldBeNull();
            methodCreateBatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            Type [] methodCreateBatchParametersTypes = null;
            object[] parametersOfCreateBatch = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateBatch, parametersOfCreateBatch, methodCreateBatchParametersTypes);

            // Assert
            parametersOfCreateBatch.ShouldBeNull();
            methodCreateBatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            Type [] methodCreateBatchParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateBatch, methodCreateBatchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateBatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            Type [] methodCreateBatchParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateBatch, methodCreateBatchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateBatchParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateBatch) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateBatch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateBatch);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateBatch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnCreateBatchOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateBatchOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateBatchOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateBatchOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateBatchOperationCompleted, parametersOfOnCreateBatchOperationCompleted, methodOnCreateBatchOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateBatchOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateBatchOperationCompleted.Length.ShouldBe(1);
            methodOnCreateBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateBatchOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateBatchOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateBatchOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateBatchOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateBatchOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateBatchOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateBatchOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateBatchOperationCompleted);
            var methodOnCreateBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateBatchOperationCompleted, methodOnCreateBatchOperationCompletedParametersTypes);

            // Assert
            methodOnCreateBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateBatchOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateBatchOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateBatchOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelBatch) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelBatch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelBatch);

            // Act
            Action executeAction = () => _reportingService2005Instance.CancelBatch();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CancelBatch) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelBatch_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelBatch);
            Type [] methodCancelBatchParametersTypes = null;
            object[] parametersOfCancelBatch = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCancelBatch, methodCancelBatchParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCancelBatch);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCancelBatch.ShouldBeNull();
            methodCancelBatchParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CancelBatch) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelBatch_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelBatch);
            Type [] methodCancelBatchParametersTypes = null;
            object[] parametersOfCancelBatch = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCancelBatch, parametersOfCancelBatch, methodCancelBatchParametersTypes);

            // Assert
            parametersOfCancelBatch.ShouldBeNull();
            methodCancelBatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelBatch) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelBatch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelBatch);
            Type [] methodCancelBatchParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCancelBatch, methodCancelBatchParametersTypes);

            // Assert
            methodCancelBatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelBatch) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelBatch_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelBatch);
            var currentMethodInfo = this.GetMethodInfo(MethodCancelBatch, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnCancelBatchOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelBatchOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelBatchOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCancelBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCancelBatchOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCancelBatchOperationCompleted, parametersOfOnCancelBatchOperationCompleted, methodOnCancelBatchOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCancelBatchOperationCompleted.ShouldNotBeNull();
            parametersOfOnCancelBatchOperationCompleted.Length.ShouldBe(1);
            methodOnCancelBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCancelBatchOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCancelBatchOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCancelBatchOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelBatchOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCancelBatchOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCancelBatchOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelBatchOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelBatchOperationCompleted);
            var methodOnCancelBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCancelBatchOperationCompleted, methodOnCancelBatchOperationCompletedParametersTypes);

            // Assert
            methodOnCancelBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCancelBatchOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelBatchOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCancelBatchOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBatch) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ExecuteBatch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBatch);

            // Act
            Action executeAction = () => _reportingService2005Instance.ExecuteBatch();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteBatch) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ExecuteBatch_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBatch);
            Type [] methodExecuteBatchParametersTypes = null;
            object[] parametersOfExecuteBatch = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBatch, methodExecuteBatchParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfExecuteBatch);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecuteBatch.ShouldBeNull();
            methodExecuteBatchParametersTypes.ShouldBeNull();
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBatch) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ExecuteBatch_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBatch);
            Type [] methodExecuteBatchParametersTypes = null;
            object[] parametersOfExecuteBatch = null; // no parameter present

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecuteBatch, parametersOfExecuteBatch, methodExecuteBatchParametersTypes);

            // Assert
            parametersOfExecuteBatch.ShouldBeNull();
            methodExecuteBatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBatch) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ExecuteBatch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBatch);
            Type [] methodExecuteBatchParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteBatch, methodExecuteBatchParametersTypes);

            // Assert
            methodExecuteBatchParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBatch) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ExecuteBatch_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBatch);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBatch, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnExecuteBatchOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnExecuteBatchOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteBatchOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnExecuteBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnExecuteBatchOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnExecuteBatchOperationCompleted, parametersOfOnExecuteBatchOperationCompleted, methodOnExecuteBatchOperationCompletedParametersTypes);

            // Assert
            parametersOfOnExecuteBatchOperationCompleted.ShouldNotBeNull();
            parametersOfOnExecuteBatchOperationCompleted.Length.ShouldBe(1);
            methodOnExecuteBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnExecuteBatchOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnExecuteBatchOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnExecuteBatchOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnExecuteBatchOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnExecuteBatchOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnExecuteBatchOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnExecuteBatchOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteBatchOperationCompleted);
            var methodOnExecuteBatchOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnExecuteBatchOperationCompleted, methodOnExecuteBatchOperationCompletedParametersTypes);

            // Assert
            methodOnExecuteBatchOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnExecuteBatchOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnExecuteBatchOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnExecuteBatchOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnExecuteBatchOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetSystemProperties(Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var Properties = this.CreateType<Property[]>();
            var returnedValue = default(Property[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetSystemProperties(Properties);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var Properties = this.CreateType<Property[]>();
            var methodGetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };
            object[] parametersOfGetSystemProperties = { Properties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemProperties, methodGetSystemPropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Property[]>(_reportingService2005InstanceFixture, parametersOfGetSystemProperties);
            var result2 = this.GetResultOfMethod<Property[]>(MethodGetSystemProperties, parametersOfGetSystemProperties, methodGetSystemPropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSystemProperties.ShouldNotBeNull();
            parametersOfGetSystemProperties.Length.ShouldBe(1);
            methodGetSystemPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var Properties = this.CreateType<Property[]>();
            var methodGetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };
            object[] parametersOfGetSystemProperties = { Properties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Property[]>(MethodGetSystemProperties, parametersOfGetSystemProperties, methodGetSystemPropertiesParametersTypes);

            // Assert
            parametersOfGetSystemProperties.ShouldNotBeNull();
            parametersOfGetSystemProperties.Length.ShouldBe(1);
            methodGetSystemPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var methodGetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSystemProperties, methodGetSystemPropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSystemPropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var methodGetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSystemProperties, methodGetSystemPropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSystemPropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSystemProperties) (Return Type : Property[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetSystemProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSystemProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSystemProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetSystemPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSystemPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSystemPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSystemPropertiesOperationCompleted, parametersOfOnGetSystemPropertiesOperationCompleted, methodOnGetSystemPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSystemPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSystemPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSystemPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSystemPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPropertiesOperationCompleted);
            var methodOnGetSystemPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSystemPropertiesOperationCompleted, methodOnGetSystemPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSystemPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSystemPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSystemPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSystemPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetSystemProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetSystemProperties(Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSystemProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var Properties = this.CreateType<Property[]>();
            var methodSetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };
            object[] parametersOfSetSystemProperties = { Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemProperties, methodSetSystemPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetSystemProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSystemProperties.ShouldNotBeNull();
            parametersOfSetSystemProperties.Length.ShouldBe(1);
            methodSetSystemPropertiesParametersTypes.Length.ShouldBe(1);
            methodSetSystemPropertiesParametersTypes.Length.ShouldBe(parametersOfSetSystemProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var Properties = this.CreateType<Property[]>();
            var methodSetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };
            object[] parametersOfSetSystemProperties = { Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSystemProperties, parametersOfSetSystemProperties, methodSetSystemPropertiesParametersTypes);

            // Assert
            parametersOfSetSystemProperties.ShouldNotBeNull();
            parametersOfSetSystemProperties.Length.ShouldBe(1);
            methodSetSystemPropertiesParametersTypes.Length.ShouldBe(1);
            methodSetSystemPropertiesParametersTypes.Length.ShouldBe(parametersOfSetSystemProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSystemProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var methodSetSystemPropertiesParametersTypes = new Type[] { typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSystemProperties, methodSetSystemPropertiesParametersTypes);

            // Assert
            methodSetSystemPropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSystemProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSystemProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSystemProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSystemProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetSystemPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSystemPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSystemPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetSystemPropertiesOperationCompleted, parametersOfOnSetSystemPropertiesOperationCompleted, methodOnSetSystemPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetSystemPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSystemPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSystemPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSystemPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSystemPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetSystemPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPropertiesOperationCompleted);
            var methodOnSetSystemPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetSystemPropertiesOperationCompleted, methodOnSetSystemPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetSystemPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSystemPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSystemPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSystemPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSystemPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DeleteItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DeleteItem(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var Item = this.CreateType<string>();
            var methodDeleteItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteItem = { Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteItem, methodDeleteItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDeleteItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteItem.ShouldNotBeNull();
            parametersOfDeleteItem.Length.ShouldBe(1);
            methodDeleteItemParametersTypes.Length.ShouldBe(1);
            methodDeleteItemParametersTypes.Length.ShouldBe(parametersOfDeleteItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var Item = this.CreateType<string>();
            var methodDeleteItemParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteItem = { Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteItem, parametersOfDeleteItem, methodDeleteItemParametersTypes);

            // Assert
            parametersOfDeleteItem.ShouldNotBeNull();
            parametersOfDeleteItem.Length.ShouldBe(1);
            methodDeleteItemParametersTypes.Length.ShouldBe(1);
            methodDeleteItemParametersTypes.Length.ShouldBe(parametersOfDeleteItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteItem, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var methodDeleteItemParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteItem, methodDeleteItemParametersTypes);

            // Assert
            methodDeleteItemParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteItem);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDeleteItemOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteItemOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDeleteItemOperationCompleted, parametersOfOnDeleteItemOperationCompleted, methodOnDeleteItemOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDeleteItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteItemOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteItemOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteItemOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteItemOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteItemOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDeleteItemOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteItemOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteItemOperationCompleted);
            var methodOnDeleteItemOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDeleteItemOperationCompleted, methodOnDeleteItemOperationCompletedParametersTypes);

            // Assert
            methodOnDeleteItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteItemOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteItemOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteItemOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (MoveItem) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var Item = this.CreateType<string>();
            var Target = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.MoveItem(Item, Target);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MoveItem) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var Item = this.CreateType<string>();
            var Target = this.CreateType<string>();
            var methodMoveItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMoveItem = { Item, Target };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodMoveItem, methodMoveItemParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfMoveItem);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfMoveItem.ShouldNotBeNull();
            parametersOfMoveItem.Length.ShouldBe(2);
            methodMoveItemParametersTypes.Length.ShouldBe(2);
            methodMoveItemParametersTypes.Length.ShouldBe(parametersOfMoveItem.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (MoveItem) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var Item = this.CreateType<string>();
            var Target = this.CreateType<string>();
            var methodMoveItemParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfMoveItem = { Item, Target };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodMoveItem, parametersOfMoveItem, methodMoveItemParametersTypes);

            // Assert
            parametersOfMoveItem.ShouldNotBeNull();
            parametersOfMoveItem.Length.ShouldBe(2);
            methodMoveItemParametersTypes.Length.ShouldBe(2);
            methodMoveItemParametersTypes.Length.ShouldBe(parametersOfMoveItem.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveItem) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveItem, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MoveItem) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var methodMoveItemParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMoveItem, methodMoveItemParametersTypes);

            // Assert
            methodMoveItemParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MoveItem) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_MoveItem_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMoveItem);
            var currentMethodInfo = this.GetMethodInfo(MethodMoveItem, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnMoveItemOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnMoveItemOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnMoveItemOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnMoveItemOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnMoveItemOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnMoveItemOperationCompleted, parametersOfOnMoveItemOperationCompleted, methodOnMoveItemOperationCompletedParametersTypes);

            // Assert
            parametersOfOnMoveItemOperationCompleted.ShouldNotBeNull();
            parametersOfOnMoveItemOperationCompleted.Length.ShouldBe(1);
            methodOnMoveItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnMoveItemOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnMoveItemOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnMoveItemOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnMoveItemOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnMoveItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnMoveItemOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnMoveItemOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnMoveItemOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnMoveItemOperationCompleted);
            var methodOnMoveItemOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnMoveItemOperationCompleted, methodOnMoveItemOperationCompletedParametersTypes);

            // Assert
            methodOnMoveItemOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnMoveItemOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnMoveItemOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnMoveItemOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnMoveItemOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListChildren) (Return Type : CatalogItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListChildren_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListChildren);
            var Item = this.CreateType<string>();
            var Recursive = this.CreateType<bool>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListChildren(Item, Recursive);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #endregion

        #endregion
    }
}