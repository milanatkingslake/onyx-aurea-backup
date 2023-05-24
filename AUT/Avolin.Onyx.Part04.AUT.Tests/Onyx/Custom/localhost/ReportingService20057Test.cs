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
    public partial class ReportingService20057Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20057Test() : base(typeof(ReportingService2005))
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

        private const string MethodOnEnableDataSourceOperationCompleted = "OnEnableDataSourceOperationCompleted";
        private const string MethodDisableDataSource = "DisableDataSource";
        private const string MethodOnDisableDataSourceOperationCompleted = "OnDisableDataSourceOperationCompleted";
        private const string MethodSetItemDataSources = "SetItemDataSources";
        private const string MethodOnSetItemDataSourcesOperationCompleted = "OnSetItemDataSourcesOperationCompleted";
        private const string MethodGetItemDataSources = "GetItemDataSources";
        private const string MethodOnGetItemDataSourcesOperationCompleted = "OnGetItemDataSourcesOperationCompleted";
        private const string MethodGetItemDataSourcePrompts = "GetItemDataSourcePrompts";
        private const string MethodOnGetItemDataSourcePromptsOperationCompleted = "OnGetItemDataSourcePromptsOperationCompleted";
        private const string MethodCreateReportHistorySnapshot = "CreateReportHistorySnapshot";
        private const string MethodOnCreateReportHistorySnapshotOperationCompleted = "OnCreateReportHistorySnapshotOperationCompleted";
        private const string MethodSetReportHistoryOptions = "SetReportHistoryOptions";
        private const string MethodOnSetReportHistoryOptionsOperationCompleted = "OnSetReportHistoryOptionsOperationCompleted";
        private const string MethodGetReportHistoryOptions = "GetReportHistoryOptions";
        private const string MethodOnGetReportHistoryOptionsOperationCompleted = "OnGetReportHistoryOptionsOperationCompleted";
        private const string MethodSetReportHistoryLimit = "SetReportHistoryLimit";
        private const string MethodOnSetReportHistoryLimitOperationCompleted = "OnSetReportHistoryLimitOperationCompleted";
        private const string MethodGetReportHistoryLimit = "GetReportHistoryLimit";
        private const string MethodOnGetReportHistoryLimitOperationCompleted = "OnGetReportHistoryLimitOperationCompleted";
        private const string MethodListReportHistory = "ListReportHistory";
        private const string MethodOnListReportHistoryOperationCompleted = "OnListReportHistoryOperationCompleted";
        private const string MethodDeleteReportHistorySnapshot = "DeleteReportHistorySnapshot";
        private const string MethodOnDeleteReportHistorySnapshotOperationCompleted = "OnDeleteReportHistorySnapshotOperationCompleted";
        private const string MethodFindItems = "FindItems";
        private const string MethodOnFindItemsOperationCompleted = "OnFindItemsOperationCompleted";
        private const string MethodCreateSchedule = "CreateSchedule";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (OnEnableDataSourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnEnableDataSourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEnableDataSourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnEnableDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnEnableDataSourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnEnableDataSourceOperationCompleted, parametersOfOnEnableDataSourceOperationCompleted, methodOnEnableDataSourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnEnableDataSourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnEnableDataSourceOperationCompleted.Length.ShouldBe(1);
            methodOnEnableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnEnableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnEnableDataSourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEnableDataSourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnEnableDataSourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEnableDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEnableDataSourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnEnableDataSourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnEnableDataSourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEnableDataSourceOperationCompleted);
            var methodOnEnableDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnEnableDataSourceOperationCompleted, methodOnEnableDataSourceOperationCompletedParametersTypes);

            // Assert
            methodOnEnableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnEnableDataSourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnEnableDataSourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnEnableDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnEnableDataSourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DisableDataSource) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var DataSource = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DisableDataSource(DataSource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DisableDataSource) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var DataSource = this.CreateType<string>();
            var methodDisableDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDisableDataSource = { DataSource };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDisableDataSource, methodDisableDataSourceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDisableDataSource);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDisableDataSource.ShouldNotBeNull();
            parametersOfDisableDataSource.Length.ShouldBe(1);
            methodDisableDataSourceParametersTypes.Length.ShouldBe(1);
            methodDisableDataSourceParametersTypes.Length.ShouldBe(parametersOfDisableDataSource.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DisableDataSource) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var DataSource = this.CreateType<string>();
            var methodDisableDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDisableDataSource = { DataSource };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDisableDataSource, parametersOfDisableDataSource, methodDisableDataSourceParametersTypes);

            // Assert
            parametersOfDisableDataSource.ShouldNotBeNull();
            parametersOfDisableDataSource.Length.ShouldBe(1);
            methodDisableDataSourceParametersTypes.Length.ShouldBe(1);
            methodDisableDataSourceParametersTypes.Length.ShouldBe(parametersOfDisableDataSource.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisableDataSource) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodDisableDataSource, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DisableDataSource) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var methodDisableDataSourceParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDisableDataSource, methodDisableDataSourceParametersTypes);

            // Assert
            methodDisableDataSourceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DisableDataSource) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DisableDataSource_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDisableDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodDisableDataSource, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDisableDataSourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDisableDataSourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDisableDataSourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDisableDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDisableDataSourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDisableDataSourceOperationCompleted, parametersOfOnDisableDataSourceOperationCompleted, methodOnDisableDataSourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDisableDataSourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnDisableDataSourceOperationCompleted.Length.ShouldBe(1);
            methodOnDisableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDisableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDisableDataSourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDisableDataSourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDisableDataSourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDisableDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDisableDataSourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDisableDataSourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDisableDataSourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDisableDataSourceOperationCompleted);
            var methodOnDisableDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDisableDataSourceOperationCompleted, methodOnDisableDataSourceOperationCompletedParametersTypes);

            // Assert
            methodOnDisableDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDisableDataSourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDisableDataSourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDisableDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDisableDataSourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetItemDataSources) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var Item = this.CreateType<string>();
            var DataSources = this.CreateType<DataSource[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetItemDataSources(Item, DataSources);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetItemDataSources) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var Item = this.CreateType<string>();
            var DataSources = this.CreateType<DataSource[]>();
            var methodSetItemDataSourcesParametersTypes = new Type[] { typeof(string), typeof(DataSource[]) };
            object[] parametersOfSetItemDataSources = { Item, DataSources };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetItemDataSources, methodSetItemDataSourcesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetItemDataSources);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetItemDataSources.ShouldNotBeNull();
            parametersOfSetItemDataSources.Length.ShouldBe(2);
            methodSetItemDataSourcesParametersTypes.Length.ShouldBe(2);
            methodSetItemDataSourcesParametersTypes.Length.ShouldBe(parametersOfSetItemDataSources.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetItemDataSources) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var Item = this.CreateType<string>();
            var DataSources = this.CreateType<DataSource[]>();
            var methodSetItemDataSourcesParametersTypes = new Type[] { typeof(string), typeof(DataSource[]) };
            object[] parametersOfSetItemDataSources = { Item, DataSources };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetItemDataSources, parametersOfSetItemDataSources, methodSetItemDataSourcesParametersTypes);

            // Assert
            parametersOfSetItemDataSources.ShouldNotBeNull();
            parametersOfSetItemDataSources.Length.ShouldBe(2);
            methodSetItemDataSourcesParametersTypes.Length.ShouldBe(2);
            methodSetItemDataSourcesParametersTypes.Length.ShouldBe(parametersOfSetItemDataSources.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetItemDataSources) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var currentMethodInfo = this.GetMethodInfo(MethodSetItemDataSources, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetItemDataSources) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var methodSetItemDataSourcesParametersTypes = new Type[] { typeof(string), typeof(DataSource[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetItemDataSources, methodSetItemDataSourcesParametersTypes);

            // Assert
            methodSetItemDataSourcesParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetItemDataSources) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetItemDataSources_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetItemDataSources);
            var currentMethodInfo = this.GetMethodInfo(MethodSetItemDataSources, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetItemDataSourcesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetItemDataSourcesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetItemDataSourcesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetItemDataSourcesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetItemDataSourcesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetItemDataSourcesOperationCompleted, parametersOfOnSetItemDataSourcesOperationCompleted, methodOnSetItemDataSourcesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetItemDataSourcesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetItemDataSourcesOperationCompleted.Length.ShouldBe(1);
            methodOnSetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetItemDataSourcesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetItemDataSourcesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetItemDataSourcesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetItemDataSourcesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetItemDataSourcesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetItemDataSourcesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetItemDataSourcesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetItemDataSourcesOperationCompleted);
            var methodOnSetItemDataSourcesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetItemDataSourcesOperationCompleted, methodOnSetItemDataSourcesOperationCompletedParametersTypes);

            // Assert
            methodOnSetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetItemDataSourcesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetItemDataSourcesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetItemDataSourcesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetItemDataSourcesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetItemDataSources(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var Item = this.CreateType<string>();
            var returnedValue = default(DataSource[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetItemDataSources(Item);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var Item = this.CreateType<string>();
            var methodGetItemDataSourcesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetItemDataSources = { Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSources, methodGetItemDataSourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataSource[]>(_reportingService2005InstanceFixture, parametersOfGetItemDataSources);
            var result2 = this.GetResultOfMethod<DataSource[]>(MethodGetItemDataSources, parametersOfGetItemDataSources, methodGetItemDataSourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetItemDataSources.ShouldNotBeNull();
            parametersOfGetItemDataSources.Length.ShouldBe(1);
            methodGetItemDataSourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var Item = this.CreateType<string>();
            var methodGetItemDataSourcesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetItemDataSources = { Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataSource[]>(MethodGetItemDataSources, parametersOfGetItemDataSources, methodGetItemDataSourcesParametersTypes);

            // Assert
            parametersOfGetItemDataSources.ShouldNotBeNull();
            parametersOfGetItemDataSources.Length.ShouldBe(1);
            methodGetItemDataSourcesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var methodGetItemDataSourcesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetItemDataSources, methodGetItemDataSourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetItemDataSourcesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var methodGetItemDataSourcesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetItemDataSources, methodGetItemDataSourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetItemDataSourcesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetItemDataSources) (Return Type : DataSource[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSources_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSources, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetItemDataSourcesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetItemDataSourcesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetItemDataSourcesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetItemDataSourcesOperationCompleted, parametersOfOnGetItemDataSourcesOperationCompleted, methodOnGetItemDataSourcesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetItemDataSourcesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetItemDataSourcesOperationCompleted.Length.ShouldBe(1);
            methodOnGetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetItemDataSourcesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemDataSourcesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcesOperationCompleted);
            var methodOnGetItemDataSourcesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetItemDataSourcesOperationCompleted, methodOnGetItemDataSourcesOperationCompletedParametersTypes);

            // Assert
            methodOnGetItemDataSourcesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemDataSourcesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var Item = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetItemDataSourcePrompts(Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var Item = this.CreateType<string>();
            var returnedValue = default(DataSourcePrompt[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetItemDataSourcePrompts(Item);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var Item = this.CreateType<string>();
            var methodGetItemDataSourcePromptsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetItemDataSourcePrompts = { Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSourcePrompts, methodGetItemDataSourcePromptsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataSourcePrompt[]>(_reportingService2005InstanceFixture, parametersOfGetItemDataSourcePrompts);
            var result2 = this.GetResultOfMethod<DataSourcePrompt[]>(MethodGetItemDataSourcePrompts, parametersOfGetItemDataSourcePrompts, methodGetItemDataSourcePromptsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetItemDataSourcePrompts.ShouldNotBeNull();
            parametersOfGetItemDataSourcePrompts.Length.ShouldBe(1);
            methodGetItemDataSourcePromptsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var Item = this.CreateType<string>();
            var methodGetItemDataSourcePromptsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetItemDataSourcePrompts = { Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataSourcePrompt[]>(MethodGetItemDataSourcePrompts, parametersOfGetItemDataSourcePrompts, methodGetItemDataSourcePromptsParametersTypes);

            // Assert
            parametersOfGetItemDataSourcePrompts.ShouldNotBeNull();
            parametersOfGetItemDataSourcePrompts.Length.ShouldBe(1);
            methodGetItemDataSourcePromptsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var methodGetItemDataSourcePromptsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetItemDataSourcePrompts, methodGetItemDataSourcePromptsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetItemDataSourcePromptsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var methodGetItemDataSourcePromptsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetItemDataSourcePrompts, methodGetItemDataSourcePromptsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetItemDataSourcePromptsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSourcePrompts, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetItemDataSourcePrompts) (Return Type : DataSourcePrompt[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetItemDataSourcePrompts_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetItemDataSourcePrompts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetItemDataSourcePrompts, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetItemDataSourcePromptsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcePromptsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcePromptsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetItemDataSourcePromptsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetItemDataSourcePromptsOperationCompleted, parametersOfOnGetItemDataSourcePromptsOperationCompleted, methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetItemDataSourcePromptsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetItemDataSourcePromptsOperationCompleted.Length.ShouldBe(1);
            methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetItemDataSourcePromptsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcePromptsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcePromptsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcePromptsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemDataSourcePromptsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcePromptsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcePromptsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcePromptsOperationCompleted);
            var methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetItemDataSourcePromptsOperationCompleted, methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes);

            // Assert
            methodOnGetItemDataSourcePromptsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetItemDataSourcePromptsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetItemDataSourcePromptsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetItemDataSourcePromptsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetItemDataSourcePromptsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateReportHistorySnapshot(Report, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateReportHistorySnapshot(Report, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var Warnings = this.CreateType<Warning[]>();
            var methodCreateReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(Warning[]) };
            object[] parametersOfCreateReportHistorySnapshot = { Report, Warnings };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReportHistorySnapshot, methodCreateReportHistorySnapshotParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfCreateReportHistorySnapshot);
            var result2 = this.GetResultOfMethod<string>(MethodCreateReportHistorySnapshot, parametersOfCreateReportHistorySnapshot, methodCreateReportHistorySnapshotParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateReportHistorySnapshot.ShouldNotBeNull();
            parametersOfCreateReportHistorySnapshot.Length.ShouldBe(2);
            methodCreateReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var Warnings = this.CreateType<Warning[]>();
            var methodCreateReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(Warning[]) };
            object[] parametersOfCreateReportHistorySnapshot = { Report, Warnings };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateReportHistorySnapshot, parametersOfCreateReportHistorySnapshot, methodCreateReportHistorySnapshotParametersTypes);

            // Assert
            parametersOfCreateReportHistorySnapshot.ShouldNotBeNull();
            parametersOfCreateReportHistorySnapshot.Length.ShouldBe(2);
            methodCreateReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var methodCreateReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(Warning[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateReportHistorySnapshot, methodCreateReportHistorySnapshotParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var methodCreateReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(Warning[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateReportHistorySnapshot, methodCreateReportHistorySnapshotParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateReportHistorySnapshotParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReportHistorySnapshot, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateReportHistorySnapshot) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReportHistorySnapshot_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReportHistorySnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReportHistorySnapshot, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateReportHistorySnapshotOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportHistorySnapshotOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportHistorySnapshotOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateReportHistorySnapshotOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateReportHistorySnapshotOperationCompleted, parametersOfOnCreateReportHistorySnapshotOperationCompleted, methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateReportHistorySnapshotOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateReportHistorySnapshotOperationCompleted.Length.ShouldBe(1);
            methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateReportHistorySnapshotOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateReportHistorySnapshotOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportHistorySnapshotOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportHistorySnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateReportHistorySnapshotOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateReportHistorySnapshotOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportHistorySnapshotOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportHistorySnapshotOperationCompleted);
            var methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateReportHistorySnapshotOperationCompleted, methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes);

            // Assert
            methodOnCreateReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateReportHistorySnapshotOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportHistorySnapshotOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportHistorySnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateReportHistorySnapshotOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetReportHistoryOptions) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var Report = this.CreateType<string>();
            var EnableManualSnapshotCreation = this.CreateType<bool>();
            var KeepExecutionSnapshots = this.CreateType<bool>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetReportHistoryOptions(Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryOptions) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var Report = this.CreateType<string>();
            var EnableManualSnapshotCreation = this.CreateType<bool>();
            var KeepExecutionSnapshots = this.CreateType<bool>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodSetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(bool), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfSetReportHistoryOptions = { Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryOptions, methodSetReportHistoryOptionsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetReportHistoryOptions);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetReportHistoryOptions.ShouldNotBeNull();
            parametersOfSetReportHistoryOptions.Length.ShouldBe(4);
            methodSetReportHistoryOptionsParametersTypes.Length.ShouldBe(4);
            methodSetReportHistoryOptionsParametersTypes.Length.ShouldBe(parametersOfSetReportHistoryOptions.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryOptions) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var Report = this.CreateType<string>();
            var EnableManualSnapshotCreation = this.CreateType<bool>();
            var KeepExecutionSnapshots = this.CreateType<bool>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodSetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(bool), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfSetReportHistoryOptions = { Report, EnableManualSnapshotCreation, KeepExecutionSnapshots, Item };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetReportHistoryOptions, parametersOfSetReportHistoryOptions, methodSetReportHistoryOptionsParametersTypes);

            // Assert
            parametersOfSetReportHistoryOptions.ShouldNotBeNull();
            parametersOfSetReportHistoryOptions.Length.ShouldBe(4);
            methodSetReportHistoryOptionsParametersTypes.Length.ShouldBe(4);
            methodSetReportHistoryOptionsParametersTypes.Length.ShouldBe(parametersOfSetReportHistoryOptions.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryOptions) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryOptions, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReportHistoryOptions) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var methodSetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(bool), typeof(ScheduleDefinitionOrReference) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetReportHistoryOptions, methodSetReportHistoryOptionsParametersTypes);

            // Assert
            methodSetReportHistoryOptionsParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryOptions) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryOptions_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryOptions, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetReportHistoryOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetReportHistoryOptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetReportHistoryOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetReportHistoryOptionsOperationCompleted, parametersOfOnSetReportHistoryOptionsOperationCompleted, methodOnSetReportHistoryOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetReportHistoryOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetReportHistoryOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnSetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetReportHistoryOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportHistoryOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryOptionsOperationCompleted);
            var methodOnSetReportHistoryOptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetReportHistoryOptionsOperationCompleted, methodOnSetReportHistoryOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnSetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportHistoryOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetReportHistoryOptions(Report, out _, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var Report = this.CreateType<string>();
            var KeepExecutionSnapshots = this.CreateType<bool>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodGetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfGetReportHistoryOptions = { Report, KeepExecutionSnapshots, Item };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryOptions, methodGetReportHistoryOptionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_reportingService2005InstanceFixture, parametersOfGetReportHistoryOptions);
            var result2 = this.GetResultOfMethod<bool>(MethodGetReportHistoryOptions, parametersOfGetReportHistoryOptions, methodGetReportHistoryOptionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetReportHistoryOptions.ShouldNotBeNull();
            parametersOfGetReportHistoryOptions.Length.ShouldBe(3);
            methodGetReportHistoryOptionsParametersTypes.Length.ShouldBe(3);
        }

        #endregion
        
        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var Report = this.CreateType<string>();
            var KeepExecutionSnapshots = this.CreateType<bool>();
            var Item = this.CreateType<ScheduleDefinitionOrReference>();
            var methodGetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(ScheduleDefinitionOrReference) };
            object[] parametersOfGetReportHistoryOptions = { Report, KeepExecutionSnapshots, Item };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGetReportHistoryOptions, parametersOfGetReportHistoryOptions, methodGetReportHistoryOptionsParametersTypes);

            // Assert
            parametersOfGetReportHistoryOptions.ShouldNotBeNull();
            parametersOfGetReportHistoryOptions.Length.ShouldBe(3);
            methodGetReportHistoryOptionsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var methodGetReportHistoryOptionsParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(ScheduleDefinitionOrReference) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReportHistoryOptions, methodGetReportHistoryOptionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReportHistoryOptionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryOptions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportHistoryOptions) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryOptions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryOptions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryOptions, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetReportHistoryOptionsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryOptionsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryOptionsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetReportHistoryOptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetReportHistoryOptionsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetReportHistoryOptionsOperationCompleted, parametersOfOnGetReportHistoryOptionsOperationCompleted, methodOnGetReportHistoryOptionsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetReportHistoryOptionsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetReportHistoryOptionsOperationCompleted.Length.ShouldBe(1);
            methodOnGetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetReportHistoryOptionsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryOptionsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryOptionsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportHistoryOptionsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryOptionsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryOptionsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryOptionsOperationCompleted);
            var methodOnGetReportHistoryOptionsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetReportHistoryOptionsOperationCompleted, methodOnGetReportHistoryOptionsOperationCompletedParametersTypes);

            // Assert
            methodOnGetReportHistoryOptionsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryOptionsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryOptionsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryOptionsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportHistoryOptionsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetReportHistoryLimit) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var Report = this.CreateType<string>();
            var UseSystem = this.CreateType<bool>();
            var HistoryLimit = this.CreateType<int>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetReportHistoryLimit(Report, UseSystem, HistoryLimit);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryLimit) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var Report = this.CreateType<string>();
            var UseSystem = this.CreateType<bool>();
            var HistoryLimit = this.CreateType<int>();
            var methodSetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };
            object[] parametersOfSetReportHistoryLimit = { Report, UseSystem, HistoryLimit };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryLimit, methodSetReportHistoryLimitParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetReportHistoryLimit);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetReportHistoryLimit.ShouldNotBeNull();
            parametersOfSetReportHistoryLimit.Length.ShouldBe(3);
            methodSetReportHistoryLimitParametersTypes.Length.ShouldBe(3);
            methodSetReportHistoryLimitParametersTypes.Length.ShouldBe(parametersOfSetReportHistoryLimit.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryLimit) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var Report = this.CreateType<string>();
            var UseSystem = this.CreateType<bool>();
            var HistoryLimit = this.CreateType<int>();
            var methodSetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };
            object[] parametersOfSetReportHistoryLimit = { Report, UseSystem, HistoryLimit };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetReportHistoryLimit, parametersOfSetReportHistoryLimit, methodSetReportHistoryLimitParametersTypes);

            // Assert
            parametersOfSetReportHistoryLimit.ShouldNotBeNull();
            parametersOfSetReportHistoryLimit.Length.ShouldBe(3);
            methodSetReportHistoryLimitParametersTypes.Length.ShouldBe(3);
            methodSetReportHistoryLimitParametersTypes.Length.ShouldBe(parametersOfSetReportHistoryLimit.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryLimit) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryLimit, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReportHistoryLimit) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var methodSetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetReportHistoryLimit, methodSetReportHistoryLimitParametersTypes);

            // Assert
            methodSetReportHistoryLimitParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportHistoryLimit) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportHistoryLimit_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportHistoryLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportHistoryLimit, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetReportHistoryLimitOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryLimitOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryLimitOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetReportHistoryLimitOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetReportHistoryLimitOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetReportHistoryLimitOperationCompleted, parametersOfOnSetReportHistoryLimitOperationCompleted, methodOnSetReportHistoryLimitOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetReportHistoryLimitOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetReportHistoryLimitOperationCompleted.Length.ShouldBe(1);
            methodOnSetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetReportHistoryLimitOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryLimitOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryLimitOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryLimitOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportHistoryLimitOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryLimitOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryLimitOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryLimitOperationCompleted);
            var methodOnSetReportHistoryLimitOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetReportHistoryLimitOperationCompleted, methodOnSetReportHistoryLimitOperationCompletedParametersTypes);

            // Assert
            methodOnSetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportHistoryLimitOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportHistoryLimitOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportHistoryLimitOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportHistoryLimitOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetReportHistoryLimit) (Return Type : int) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetReportHistoryLimit(Report, out _, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReportHistoryLimit) (Return Type : int) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var Report = this.CreateType<string>();
            var IsSystem = this.CreateType<bool>();
            var SystemLimit = this.CreateType<int>();
            var methodGetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };
            object[] parametersOfGetReportHistoryLimit = { Report, IsSystem, SystemLimit };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryLimit, methodGetReportHistoryLimitParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<int>(_reportingService2005InstanceFixture, parametersOfGetReportHistoryLimit);
            var result2 = this.GetResultOfMethod<int>(MethodGetReportHistoryLimit, parametersOfGetReportHistoryLimit, methodGetReportHistoryLimitParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetReportHistoryLimit.ShouldNotBeNull();
            parametersOfGetReportHistoryLimit.Length.ShouldBe(3);
            methodGetReportHistoryLimitParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetReportHistoryLimit) (Return Type : int) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var Report = this.CreateType<string>();
            var IsSystem = this.CreateType<bool>();
            var SystemLimit = this.CreateType<int>();
            var methodGetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };
            object[] parametersOfGetReportHistoryLimit = { Report, IsSystem, SystemLimit };

            // Act
            Action currentAction = () => this.GetResultOfMethod<int>(MethodGetReportHistoryLimit, parametersOfGetReportHistoryLimit, methodGetReportHistoryLimitParametersTypes);

            // Assert
            parametersOfGetReportHistoryLimit.ShouldNotBeNull();
            parametersOfGetReportHistoryLimit.Length.ShouldBe(3);
            methodGetReportHistoryLimitParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportHistoryLimit) (Return Type : int) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var methodGetReportHistoryLimitParametersTypes = new Type[] { typeof(string), typeof(bool), typeof(int) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReportHistoryLimit, methodGetReportHistoryLimitParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReportHistoryLimitParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReportHistoryLimit) (Return Type : int) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryLimit, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportHistoryLimit) (Return Type : int) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportHistoryLimit_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportHistoryLimit);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportHistoryLimit, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetReportHistoryLimitOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryLimitOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryLimitOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetReportHistoryLimitOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetReportHistoryLimitOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetReportHistoryLimitOperationCompleted, parametersOfOnGetReportHistoryLimitOperationCompleted, methodOnGetReportHistoryLimitOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetReportHistoryLimitOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetReportHistoryLimitOperationCompleted.Length.ShouldBe(1);
            methodOnGetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetReportHistoryLimitOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryLimitOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryLimitOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryLimitOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportHistoryLimitOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryLimitOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryLimitOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryLimitOperationCompleted);
            var methodOnGetReportHistoryLimitOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetReportHistoryLimitOperationCompleted, methodOnGetReportHistoryLimitOperationCompletedParametersTypes);

            // Assert
            methodOnGetReportHistoryLimitOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportHistoryLimitOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportHistoryLimitOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportHistoryLimitOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportHistoryLimitOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListReportHistory(Report);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var Report = this.CreateType<string>();
            var returnedValue = default(ReportHistorySnapshot[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListReportHistory(Report);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var Report = this.CreateType<string>();
            var methodListReportHistoryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListReportHistory = { Report };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListReportHistory, methodListReportHistoryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ReportHistorySnapshot[]>(_reportingService2005InstanceFixture, parametersOfListReportHistory);
            var result2 = this.GetResultOfMethod<ReportHistorySnapshot[]>(MethodListReportHistory, parametersOfListReportHistory, methodListReportHistoryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListReportHistory.ShouldNotBeNull();
            parametersOfListReportHistory.Length.ShouldBe(1);
            methodListReportHistoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var Report = this.CreateType<string>();
            var methodListReportHistoryParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListReportHistory = { Report };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ReportHistorySnapshot[]>(MethodListReportHistory, parametersOfListReportHistory, methodListReportHistoryParametersTypes);

            // Assert
            parametersOfListReportHistory.ShouldNotBeNull();
            parametersOfListReportHistory.Length.ShouldBe(1);
            methodListReportHistoryParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var methodListReportHistoryParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListReportHistory, methodListReportHistoryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListReportHistoryParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var methodListReportHistoryParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListReportHistory, methodListReportHistoryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListReportHistoryParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var currentMethodInfo = this.GetMethodInfo(MethodListReportHistory, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListReportHistory) (Return Type : ReportHistorySnapshot[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListReportHistory_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListReportHistory);
            var currentMethodInfo = this.GetMethodInfo(MethodListReportHistory, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListReportHistoryOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListReportHistoryOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListReportHistoryOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListReportHistoryOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListReportHistoryOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListReportHistoryOperationCompleted, parametersOfOnListReportHistoryOperationCompleted, methodOnListReportHistoryOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListReportHistoryOperationCompleted.ShouldNotBeNull();
            parametersOfOnListReportHistoryOperationCompleted.Length.ShouldBe(1);
            methodOnListReportHistoryOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListReportHistoryOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListReportHistoryOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListReportHistoryOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListReportHistoryOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListReportHistoryOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListReportHistoryOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListReportHistoryOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListReportHistoryOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListReportHistoryOperationCompleted);
            var methodOnListReportHistoryOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListReportHistoryOperationCompleted, methodOnListReportHistoryOperationCompletedParametersTypes);

            // Assert
            methodOnListReportHistoryOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListReportHistoryOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListReportHistoryOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListReportHistoryOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListReportHistoryOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DeleteReportHistorySnapshot(Report, HistoryID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var methodDeleteReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteReportHistorySnapshot = { Report, HistoryID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteReportHistorySnapshot, methodDeleteReportHistorySnapshotParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDeleteReportHistorySnapshot);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteReportHistorySnapshot.ShouldNotBeNull();
            parametersOfDeleteReportHistorySnapshot.Length.ShouldBe(2);
            methodDeleteReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
            methodDeleteReportHistorySnapshotParametersTypes.Length.ShouldBe(parametersOfDeleteReportHistorySnapshot.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var methodDeleteReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfDeleteReportHistorySnapshot = { Report, HistoryID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteReportHistorySnapshot, parametersOfDeleteReportHistorySnapshot, methodDeleteReportHistorySnapshotParametersTypes);

            // Assert
            parametersOfDeleteReportHistorySnapshot.ShouldNotBeNull();
            parametersOfDeleteReportHistorySnapshot.Length.ShouldBe(2);
            methodDeleteReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
            methodDeleteReportHistorySnapshotParametersTypes.Length.ShouldBe(parametersOfDeleteReportHistorySnapshot.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteReportHistorySnapshot, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var methodDeleteReportHistorySnapshotParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteReportHistorySnapshot, methodDeleteReportHistorySnapshotParametersTypes);

            // Assert
            methodDeleteReportHistorySnapshotParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteReportHistorySnapshot) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteReportHistorySnapshot_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteReportHistorySnapshot);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteReportHistorySnapshot, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDeleteReportHistorySnapshotOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteReportHistorySnapshotOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteReportHistorySnapshotOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteReportHistorySnapshotOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDeleteReportHistorySnapshotOperationCompleted, parametersOfOnDeleteReportHistorySnapshotOperationCompleted, methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDeleteReportHistorySnapshotOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteReportHistorySnapshotOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteReportHistorySnapshotOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteReportHistorySnapshotOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteReportHistorySnapshotOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteReportHistorySnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteReportHistorySnapshotOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDeleteReportHistorySnapshotOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteReportHistorySnapshotOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteReportHistorySnapshotOperationCompleted);
            var methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDeleteReportHistorySnapshotOperationCompleted, methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes);

            // Assert
            methodOnDeleteReportHistorySnapshotOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteReportHistorySnapshotOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteReportHistorySnapshotOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteReportHistorySnapshotOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteReportHistorySnapshotOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var Folder = this.CreateType<string>();
            var BooleanOperator = this.CreateType<BooleanOperatorEnum>();
            var Conditions = this.CreateType<SearchCondition[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.FindItems(Folder, BooleanOperator, Conditions);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var Folder = this.CreateType<string>();
            var BooleanOperator = this.CreateType<BooleanOperatorEnum>();
            var Conditions = this.CreateType<SearchCondition[]>();
            var returnedValue = default(CatalogItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.FindItems(Folder, BooleanOperator, Conditions);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var Folder = this.CreateType<string>();
            var BooleanOperator = this.CreateType<BooleanOperatorEnum>();
            var Conditions = this.CreateType<SearchCondition[]>();
            var methodFindItemsParametersTypes = new Type[] { typeof(string), typeof(BooleanOperatorEnum), typeof(SearchCondition[]) };
            object[] parametersOfFindItems = { Folder, BooleanOperator, Conditions };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFindItems, methodFindItemsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CatalogItem[]>(_reportingService2005InstanceFixture, parametersOfFindItems);
            var result2 = this.GetResultOfMethod<CatalogItem[]>(MethodFindItems, parametersOfFindItems, methodFindItemsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfFindItems.ShouldNotBeNull();
            parametersOfFindItems.Length.ShouldBe(3);
            methodFindItemsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var Folder = this.CreateType<string>();
            var BooleanOperator = this.CreateType<BooleanOperatorEnum>();
            var Conditions = this.CreateType<SearchCondition[]>();
            var methodFindItemsParametersTypes = new Type[] { typeof(string), typeof(BooleanOperatorEnum), typeof(SearchCondition[]) };
            object[] parametersOfFindItems = { Folder, BooleanOperator, Conditions };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CatalogItem[]>(MethodFindItems, parametersOfFindItems, methodFindItemsParametersTypes);

            // Assert
            parametersOfFindItems.ShouldNotBeNull();
            parametersOfFindItems.Length.ShouldBe(3);
            methodFindItemsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var methodFindItemsParametersTypes = new Type[] { typeof(string), typeof(BooleanOperatorEnum), typeof(SearchCondition[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodFindItems, methodFindItemsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodFindItemsParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var methodFindItemsParametersTypes = new Type[] { typeof(string), typeof(BooleanOperatorEnum), typeof(SearchCondition[]) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFindItems, methodFindItemsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFindItemsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var currentMethodInfo = this.GetMethodInfo(MethodFindItems, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FindItems) (Return Type : CatalogItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FindItems_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFindItems);
            var currentMethodInfo = this.GetMethodInfo(MethodFindItems, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnFindItemsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFindItemsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFindItemsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnFindItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnFindItemsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnFindItemsOperationCompleted, parametersOfOnFindItemsOperationCompleted, methodOnFindItemsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnFindItemsOperationCompleted.ShouldNotBeNull();
            parametersOfOnFindItemsOperationCompleted.Length.ShouldBe(1);
            methodOnFindItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnFindItemsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnFindItemsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFindItemsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFindItemsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFindItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFindItemsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnFindItemsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFindItemsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFindItemsOperationCompleted);
            var methodOnFindItemsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnFindItemsOperationCompleted, methodOnFindItemsOperationCompletedParametersTypes);

            // Assert
            methodOnFindItemsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFindItemsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFindItemsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFindItemsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFindItemsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateSchedule) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var Name = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateSchedule(Name, ScheduleDefinition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var Name = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateSchedule(Name, ScheduleDefinition);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}