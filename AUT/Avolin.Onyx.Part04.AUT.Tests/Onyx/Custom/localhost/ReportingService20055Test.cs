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
    using Action = Action;
    using Should = Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Custom.localhost.ReportingService2005" />)
    ///     and namespace <see cref="Onyx.Custom.localhost"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ReportingService20055Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20055Test() : base(typeof(ReportingService2005))
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

        private const string MethodGetRenderResource = "GetRenderResource";
        private const string MethodOnGetRenderResourceOperationCompleted = "OnGetRenderResourceOperationCompleted";
        private const string MethodSetExecutionOptions = "SetExecutionOptions";
        private const string MethodOnSetExecutionOptionsOperationCompleted = "OnSetExecutionOptionsOperationCompleted";
        private const string MethodGetExecutionOptions = "GetExecutionOptions";
        private const string MethodOnGetExecutionOptionsOperationCompleted = "OnGetExecutionOptionsOperationCompleted";
        private const string MethodSetCacheOptions = "SetCacheOptions";
        private const string MethodOnSetCacheOptionsOperationCompleted = "OnSetCacheOptionsOperationCompleted";
        private const string MethodGetCacheOptions = "GetCacheOptions";
        private const string MethodOnGetCacheOptionsOperationCompleted = "OnGetCacheOptionsOperationCompleted";
        private const string MethodUpdateReportExecutionSnapshot = "UpdateReportExecutionSnapshot";
        private const string MethodOnUpdateReportExecutionSnapshotOperationCompleted = "OnUpdateReportExecutionSnapshotOperationCompleted";
        private const string MethodFlushCache = "FlushCache";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (GetRenderResource) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var methodGetRenderResourceParametersTypes = new[] { typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRenderResource, methodGetRenderResourceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRenderResourceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRenderResource, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRenderResource, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetRenderResourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRenderResourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRenderResourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetRenderResourceOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnGetRenderResourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetRenderResourceOperationCompleted, parametersOfOnGetRenderResourceOperationCompleted, methodOnGetRenderResourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetRenderResourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetRenderResourceOperationCompleted.Length.ShouldBe(1);
            methodOnGetRenderResourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetRenderResourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetRenderResourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetRenderResourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRenderResourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRenderResourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetRenderResourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetRenderResourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRenderResourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRenderResourceOperationCompleted);
            var methodOnGetRenderResourceOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetRenderResourceOperationCompleted, methodOnGetRenderResourceOperationCompletedParametersTypes);

            // Assert
            methodOnGetRenderResourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetRenderResourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetRenderResourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetRenderResourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetRenderResourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetExecutionOptions) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var Report = this.CreateType<string>();
            var ExecutionSetting = this.CreateType<ExecutionSettingEnum>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetExecutionOptions(Report, ExecutionSetting, Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetExecutionOptions) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var Report = this.CreateType<string>();
            var ExecutionSetting = this.CreateType<ExecutionSettingEnum>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodSetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ExecutionSettingEnum), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfSetExecutionOptions = { Report, ExecutionSetting, Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetExecutionOptions, methodSetExecutionOptionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetExecutionOptions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetExecutionOptions.ShouldNotBeNull();
            parametersOfSetExecutionOptions.Length.ShouldBe(3);
            methodSetExecutionOptionsParametersTypes.Length.ShouldBe(3);
            methodSetExecutionOptionsParametersTypes.Length.ShouldBe(parametersOfSetExecutionOptions.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetExecutionOptions) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var Report = this.CreateType<string>();
            var ExecutionSetting = this.CreateType<ExecutionSettingEnum>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodSetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ExecutionSettingEnum), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfSetExecutionOptions = { Report, ExecutionSetting, Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetExecutionOptions, parametersOfSetExecutionOptions, methodSetExecutionOptionsParametersTypes);

            // Assert
            parametersOfSetExecutionOptions.ShouldNotBeNull();
            parametersOfSetExecutionOptions.Length.ShouldBe(3);
            methodSetExecutionOptionsParametersTypes.Length.ShouldBe(3);
            methodSetExecutionOptionsParametersTypes.Length.ShouldBe(parametersOfSetExecutionOptions.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetExecutionOptions) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetExecutionOptions, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetExecutionOptions) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var methodSetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ExecutionSettingEnum), typeof(ScheduleDefinitionOrReference) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetExecutionOptions, methodSetExecutionOptionsParametersTypes);

            // Assert
            methodSetExecutionOptionsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetExecutionOptions) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetExecutionOptions_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetExecutionOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetExecutionOptions, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetExecutionOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetExecutionOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetExecutionOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetExecutionOptionsOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnSetExecutionOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetExecutionOptionsOperationCompleted, parametersOfOnSetExecutionOptionsOperationCompleted, methodOnSetExecutionOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetExecutionOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetExecutionOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnSetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetExecutionOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetExecutionOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetExecutionOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetExecutionOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetExecutionOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetExecutionOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetExecutionOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetExecutionOptionsOperationCompleted);
            var methodOnSetExecutionOptionsOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetExecutionOptionsOperationCompleted, methodOnSetExecutionOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnSetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetExecutionOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetExecutionOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetExecutionOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetExecutionOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetExecutionOptions(Report, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var Report = this.CreateType<string>();
            var returnedValue = default(ExecutionSettingEnum);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetExecutionOptions(Report, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion
        
        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var Report = this.CreateType<string>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodGetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfGetExecutionOptions = { Report, Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ExecutionSettingEnum>(MethodGetExecutionOptions, parametersOfGetExecutionOptions, methodGetExecutionOptionsParametersTypes);

            // Assert
            parametersOfGetExecutionOptions.ShouldNotBeNull();
            parametersOfGetExecutionOptions.Length.ShouldBe(2);
            methodGetExecutionOptionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var methodGetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ScheduleDefinitionOrReference) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetExecutionOptions, methodGetExecutionOptionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetExecutionOptionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var methodGetExecutionOptionsParametersTypes = new[] { typeof(string), typeof(ScheduleDefinitionOrReference) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetExecutionOptions, methodGetExecutionOptionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetExecutionOptionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExecutionOptions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetExecutionOptions) (Return Type : ExecutionSettingEnum) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetExecutionOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetExecutionOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetExecutionOptions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetExecutionOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExecutionOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExecutionOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetExecutionOptionsOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnGetExecutionOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetExecutionOptionsOperationCompleted, parametersOfOnGetExecutionOptionsOperationCompleted, methodOnGetExecutionOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetExecutionOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetExecutionOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetExecutionOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetExecutionOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExecutionOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExecutionOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetExecutionOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetExecutionOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExecutionOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExecutionOptionsOperationCompleted);
            var methodOnGetExecutionOptionsOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetExecutionOptionsOperationCompleted, methodOnGetExecutionOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetExecutionOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetExecutionOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetExecutionOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetExecutionOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetExecutionOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetCacheOptions) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var Report = this.CreateType<string>();
            var CacheReport = this.CreateType<bool>();
            var Item = this.CreateType<ExpirationDefinition>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetCacheOptions(Report, CacheReport, Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetCacheOptions) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var Report = this.CreateType<string>();
            var CacheReport = this.CreateType<bool>();
            var Item = this.CreateType<ExpirationDefinition>();
            var methodSetCacheOptionsParametersTypes = new[] { typeof(string), typeof(bool), typeof(ExpirationDefinition) };
            object[] parametersOfSetCacheOptions = { Report, CacheReport, Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetCacheOptions, methodSetCacheOptionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetCacheOptions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetCacheOptions.ShouldNotBeNull();
            parametersOfSetCacheOptions.Length.ShouldBe(3);
            methodSetCacheOptionsParametersTypes.Length.ShouldBe(3);
            methodSetCacheOptionsParametersTypes.Length.ShouldBe(parametersOfSetCacheOptions.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetCacheOptions) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var Report = this.CreateType<string>();
            var CacheReport = this.CreateType<bool>();
            var Item = this.CreateType<ExpirationDefinition>();
            var methodSetCacheOptionsParametersTypes = new[] { typeof(string), typeof(bool), typeof(ExpirationDefinition) };
            object[] parametersOfSetCacheOptions = { Report, CacheReport, Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetCacheOptions, parametersOfSetCacheOptions, methodSetCacheOptionsParametersTypes);

            // Assert
            parametersOfSetCacheOptions.ShouldNotBeNull();
            parametersOfSetCacheOptions.Length.ShouldBe(3);
            methodSetCacheOptionsParametersTypes.Length.ShouldBe(3);
            methodSetCacheOptionsParametersTypes.Length.ShouldBe(parametersOfSetCacheOptions.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCacheOptions) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetCacheOptions, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetCacheOptions) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var methodSetCacheOptionsParametersTypes = new[] { typeof(string), typeof(bool), typeof(ExpirationDefinition) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetCacheOptions, methodSetCacheOptionsParametersTypes);

            // Assert
            methodSetCacheOptionsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetCacheOptions) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetCacheOptions_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetCacheOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetCacheOptions, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetCacheOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetCacheOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetCacheOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetCacheOptionsOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnSetCacheOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetCacheOptionsOperationCompleted, parametersOfOnSetCacheOptionsOperationCompleted, methodOnSetCacheOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetCacheOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetCacheOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnSetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetCacheOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetCacheOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetCacheOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetCacheOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetCacheOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetCacheOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetCacheOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetCacheOptionsOperationCompleted);
            var methodOnSetCacheOptionsOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetCacheOptionsOperationCompleted, methodOnSetCacheOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnSetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetCacheOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetCacheOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetCacheOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetCacheOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetCacheOptions) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetCacheOptions(Report, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCacheOptions) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var Report = this.CreateType<string>();
            var Item = this.CreateType<ExpirationDefinition>();
            var methodGetCacheOptionsParametersTypes = new[] { typeof(string), typeof(ExpirationDefinition) };
            object[] parametersOfGetCacheOptions = { Report, Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheOptions, methodGetCacheOptionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_reportingService2005InstanceFixture, parametersOfGetCacheOptions);
            var result2 = this.GetResultOfMethod<bool>(MethodGetCacheOptions, parametersOfGetCacheOptions, methodGetCacheOptionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetCacheOptions.ShouldNotBeNull();
            parametersOfGetCacheOptions.Length.ShouldBe(2);
            methodGetCacheOptionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion
        
        #region Method Call : (GetCacheOptions) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var Report = this.CreateType<string>();
            var Item = this.CreateType<ExpirationDefinition>();
            var methodGetCacheOptionsParametersTypes = new[] { typeof(string), typeof(ExpirationDefinition) };
            object[] parametersOfGetCacheOptions = { Report, Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetCacheOptions, parametersOfGetCacheOptions, methodGetCacheOptionsParametersTypes);

            // Assert
            parametersOfGetCacheOptions.ShouldNotBeNull();
            parametersOfGetCacheOptions.Length.ShouldBe(2);
            methodGetCacheOptionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheOptions) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var methodGetCacheOptionsParametersTypes = new[] { typeof(string), typeof(ExpirationDefinition) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheOptions, methodGetCacheOptionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheOptionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheOptions) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheOptions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheOptions) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetCacheOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheOptions, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetCacheOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetCacheOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetCacheOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetCacheOptionsOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnGetCacheOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetCacheOptionsOperationCompleted, parametersOfOnGetCacheOptionsOperationCompleted, methodOnGetCacheOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetCacheOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetCacheOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetCacheOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetCacheOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetCacheOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetCacheOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetCacheOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetCacheOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetCacheOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetCacheOptionsOperationCompleted);
            var methodOnGetCacheOptionsOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetCacheOptionsOperationCompleted, methodOnGetCacheOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetCacheOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetCacheOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetCacheOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetCacheOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetCacheOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.UpdateReportExecutionSnapshot(Report);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var Report = this.CreateType<string>();
            var methodUpdateReportExecutionSnapshotParametersTypes = new[] { typeof(string) };
            object[] parametersOfUpdateReportExecutionSnapshot = { Report };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateReportExecutionSnapshot, methodUpdateReportExecutionSnapshotParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfUpdateReportExecutionSnapshot);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfUpdateReportExecutionSnapshot.ShouldNotBeNull();
            parametersOfUpdateReportExecutionSnapshot.Length.ShouldBe(1);
            methodUpdateReportExecutionSnapshotParametersTypes.Length.ShouldBe(1);
            methodUpdateReportExecutionSnapshotParametersTypes.Length.ShouldBe(parametersOfUpdateReportExecutionSnapshot.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var Report = this.CreateType<string>();
            var methodUpdateReportExecutionSnapshotParametersTypes = new[] { typeof(string) };
            object[] parametersOfUpdateReportExecutionSnapshot = { Report };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodUpdateReportExecutionSnapshot, parametersOfUpdateReportExecutionSnapshot, methodUpdateReportExecutionSnapshotParametersTypes);

            // Assert
            parametersOfUpdateReportExecutionSnapshot.ShouldNotBeNull();
            parametersOfUpdateReportExecutionSnapshot.Length.ShouldBe(1);
            methodUpdateReportExecutionSnapshotParametersTypes.Length.ShouldBe(1);
            methodUpdateReportExecutionSnapshotParametersTypes.Length.ShouldBe(parametersOfUpdateReportExecutionSnapshot.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateReportExecutionSnapshot, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var methodUpdateReportExecutionSnapshotParametersTypes = new[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateReportExecutionSnapshot, methodUpdateReportExecutionSnapshotParametersTypes);

            // Assert
            methodUpdateReportExecutionSnapshotParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateReportExecutionSnapshot) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_UpdateReportExecutionSnapshot_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateReportExecutionSnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateReportExecutionSnapshot, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnUpdateReportExecutionSnapshotOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnUpdateReportExecutionSnapshotOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnUpdateReportExecutionSnapshotOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes = new[] { typeof(object) };
            object[] parametersOfOnUpdateReportExecutionSnapshotOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnUpdateReportExecutionSnapshotOperationCompleted, parametersOfOnUpdateReportExecutionSnapshotOperationCompleted, methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes);

            // Assert
            parametersOfOnUpdateReportExecutionSnapshotOperationCompleted.ShouldNotBeNull();
            parametersOfOnUpdateReportExecutionSnapshotOperationCompleted.Length.ShouldBe(1);
            methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnUpdateReportExecutionSnapshotOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnUpdateReportExecutionSnapshotOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnUpdateReportExecutionSnapshotOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnUpdateReportExecutionSnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnUpdateReportExecutionSnapshotOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnUpdateReportExecutionSnapshotOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnUpdateReportExecutionSnapshotOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnUpdateReportExecutionSnapshotOperationCompleted);
            var methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes = new[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnUpdateReportExecutionSnapshotOperationCompleted, methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes);

            // Assert
            methodOnUpdateReportExecutionSnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnUpdateReportExecutionSnapshotOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnUpdateReportExecutionSnapshotOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnUpdateReportExecutionSnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnUpdateReportExecutionSnapshotOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (FlushCache) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.FlushCache(Report);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FlushCache) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var Report = this.CreateType<string>();
            var methodFlushCacheParametersTypes = new[] { typeof(string) };
            object[] parametersOfFlushCache = { Report };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodFlushCache, methodFlushCacheParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfFlushCache);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfFlushCache.ShouldNotBeNull();
            parametersOfFlushCache.Length.ShouldBe(1);
            methodFlushCacheParametersTypes.Length.ShouldBe(1);
            methodFlushCacheParametersTypes.Length.ShouldBe(parametersOfFlushCache.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}