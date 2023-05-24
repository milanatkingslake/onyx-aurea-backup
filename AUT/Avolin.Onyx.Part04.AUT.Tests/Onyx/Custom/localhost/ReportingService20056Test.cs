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
    public partial class ReportingService20056Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20056Test() : base(typeof(ReportingService2005))
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

        private const string MethodFlushCache = "FlushCache";
        private const string MethodOnFlushCacheOperationCompleted = "OnFlushCacheOperationCompleted";
        private const string MethodListJobs = "ListJobs";
        private const string MethodOnListJobsOperationCompleted = "OnListJobsOperationCompleted";
        private const string MethodCancelJob = "CancelJob";
        private const string MethodOnCancelJobOperationCompleted = "OnCancelJobOperationCompleted";
        private const string MethodCreateDataSource = "CreateDataSource";
        private const string MethodOnCreateDataSourceOperationCompleted = "OnCreateDataSourceOperationCompleted";
        private const string MethodGetDataSourceContents = "GetDataSourceContents";
        private const string MethodOnGetDataSourceContentsOperationCompleted = "OnGetDataSourceContentsOperationCompleted";
        private const string MethodSetDataSourceContents = "SetDataSourceContents";
        private const string MethodOnSetDataSourceContentsOperationCompleted = "OnSetDataSourceContentsOperationCompleted";
        private const string MethodEnableDataSource = "EnableDataSource";
        
        #endregion

        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (FlushCache) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var Report = this.CreateType<string>();
            var methodFlushCacheParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfFlushCache = { Report };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodFlushCache, parametersOfFlushCache, methodFlushCacheParametersTypes);

            // Assert
            parametersOfFlushCache.ShouldNotBeNull();
            parametersOfFlushCache.Length.ShouldBe(1);
            methodFlushCacheParametersTypes.Length.ShouldBe(1);
            methodFlushCacheParametersTypes.Length.ShouldBe(parametersOfFlushCache.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FlushCache) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var currentMethodInfo = this.GetMethodInfo(MethodFlushCache, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FlushCache) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var methodFlushCacheParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFlushCache, methodFlushCacheParametersTypes);

            // Assert
            methodFlushCacheParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FlushCache) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_FlushCache_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFlushCache);
            var currentMethodInfo = this.GetMethodInfo(MethodFlushCache, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnFlushCacheOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFlushCacheOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFlushCacheOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnFlushCacheOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnFlushCacheOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnFlushCacheOperationCompleted, parametersOfOnFlushCacheOperationCompleted, methodOnFlushCacheOperationCompletedParametersTypes);

            // Assert
            parametersOfOnFlushCacheOperationCompleted.ShouldNotBeNull();
            parametersOfOnFlushCacheOperationCompleted.Length.ShouldBe(1);
            methodOnFlushCacheOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnFlushCacheOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnFlushCacheOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFlushCacheOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFlushCacheOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFlushCacheOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFlushCacheOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnFlushCacheOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFlushCacheOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFlushCacheOperationCompleted);
            var methodOnFlushCacheOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnFlushCacheOperationCompleted, methodOnFlushCacheOperationCompletedParametersTypes);

            // Assert
            methodOnFlushCacheOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnFlushCacheOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnFlushCacheOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnFlushCacheOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnFlushCacheOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListJobs) (Return Type : Job[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);

            // Act
            Action executeAction = () => _reportingService2005Instance.ListJobs();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            var returnedValue = default(Job[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListJobs();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            Type [] methodListJobsParametersTypes = null;
            object[] parametersOfListJobs = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListJobs, methodListJobsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Job[]>(_reportingService2005InstanceFixture, parametersOfListJobs);
            var result2 = this.GetResultOfMethod<Job[]>(MethodListJobs, parametersOfListJobs, methodListJobsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListJobs.ShouldBeNull();
            methodListJobsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            Type [] methodListJobsParametersTypes = null;
            object[] parametersOfListJobs = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Job[]>(MethodListJobs, parametersOfListJobs, methodListJobsParametersTypes);

            // Assert
            parametersOfListJobs.ShouldBeNull();
            methodListJobsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            Type [] methodListJobsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListJobs, methodListJobsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListJobsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            Type [] methodListJobsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListJobs, methodListJobsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListJobsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListJobs) (Return Type : Job[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListJobs_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListJobs);
            var currentMethodInfo = this.GetMethodInfo(MethodListJobs, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (OnListJobsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListJobsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListJobsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListJobsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListJobsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListJobsOperationCompleted, parametersOfOnListJobsOperationCompleted, methodOnListJobsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListJobsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListJobsOperationCompleted.Length.ShouldBe(1);
            methodOnListJobsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListJobsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListJobsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListJobsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListJobsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListJobsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListJobsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListJobsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListJobsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListJobsOperationCompleted);
            var methodOnListJobsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListJobsOperationCompleted, methodOnListJobsOperationCompletedParametersTypes);

            // Assert
            methodOnListJobsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListJobsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListJobsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListJobsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListJobsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CancelJob) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var JobID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CancelJob(JobID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CancelJob) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var JobID = this.CreateType<string>();
            var methodCancelJobParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCancelJob = { JobID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCancelJob, methodCancelJobParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_reportingService2005InstanceFixture, parametersOfCancelJob);
            var result2 = this.GetResultOfMethod<bool>(MethodCancelJob, parametersOfCancelJob, methodCancelJobParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfCancelJob.ShouldNotBeNull();
            parametersOfCancelJob.Length.ShouldBe(1);
            methodCancelJobParametersTypes.Length.ShouldBe(1);
        }

        #endregion
        
        #region Method Call : (CancelJob) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var JobID = this.CreateType<string>();
            var methodCancelJobParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfCancelJob = { JobID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodCancelJob, parametersOfCancelJob, methodCancelJobParametersTypes);

            // Assert
            parametersOfCancelJob.ShouldNotBeNull();
            parametersOfCancelJob.Length.ShouldBe(1);
            methodCancelJobParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CancelJob) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var methodCancelJobParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCancelJob, methodCancelJobParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCancelJobParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CancelJob) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var currentMethodInfo = this.GetMethodInfo(MethodCancelJob, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CancelJob) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CancelJob_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCancelJob);
            var currentMethodInfo = this.GetMethodInfo(MethodCancelJob, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCancelJobOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelJobOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelJobOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCancelJobOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCancelJobOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCancelJobOperationCompleted, parametersOfOnCancelJobOperationCompleted, methodOnCancelJobOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCancelJobOperationCompleted.ShouldNotBeNull();
            parametersOfOnCancelJobOperationCompleted.Length.ShouldBe(1);
            methodOnCancelJobOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCancelJobOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCancelJobOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCancelJobOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelJobOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelJobOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCancelJobOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCancelJobOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelJobOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelJobOperationCompleted);
            var methodOnCancelJobOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCancelJobOperationCompleted, methodOnCancelJobOperationCompletedParametersTypes);

            // Assert
            methodOnCancelJobOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCancelJobOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCancelJobOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCancelJobOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCancelJobOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateDataSource) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var DataSource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<DataSourceDefinition>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateDataSource(DataSource, Parent, Overwrite, Definition, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateDataSource) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var DataSource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<DataSourceDefinition>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateDataSourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(DataSourceDefinition), typeof(Property[]) };
            object[] parametersOfCreateDataSource = { DataSource, Parent, Overwrite, Definition, Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataSource, methodCreateDataSourceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCreateDataSource);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateDataSource.ShouldNotBeNull();
            parametersOfCreateDataSource.Length.ShouldBe(5);
            methodCreateDataSourceParametersTypes.Length.ShouldBe(5);
            methodCreateDataSourceParametersTypes.Length.ShouldBe(parametersOfCreateDataSource.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateDataSource) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var DataSource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<DataSourceDefinition>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateDataSourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(DataSourceDefinition), typeof(Property[]) };
            object[] parametersOfCreateDataSource = { DataSource, Parent, Overwrite, Definition, Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateDataSource, parametersOfCreateDataSource, methodCreateDataSourceParametersTypes);

            // Assert
            parametersOfCreateDataSource.ShouldNotBeNull();
            parametersOfCreateDataSource.Length.ShouldBe(5);
            methodCreateDataSourceParametersTypes.Length.ShouldBe(5);
            methodCreateDataSourceParametersTypes.Length.ShouldBe(parametersOfCreateDataSource.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDataSource) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataSource, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateDataSource) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var methodCreateDataSourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(DataSourceDefinition), typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateDataSource, methodCreateDataSourceParametersTypes);

            // Assert
            methodCreateDataSourceParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDataSource) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataSource_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataSource, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnCreateDataSourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataSourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataSourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateDataSourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateDataSourceOperationCompleted, parametersOfOnCreateDataSourceOperationCompleted, methodOnCreateDataSourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateDataSourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateDataSourceOperationCompleted.Length.ShouldBe(1);
            methodOnCreateDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateDataSourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateDataSourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateDataSourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataSourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateDataSourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateDataSourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataSourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataSourceOperationCompleted);
            var methodOnCreateDataSourceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateDataSourceOperationCompleted, methodOnCreateDataSourceOperationCompletedParametersTypes);

            // Assert
            methodOnCreateDataSourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateDataSourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataSourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataSourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateDataSourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var DataSource = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetDataSourceContents(DataSource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var returnedValue = default(DataSourceDefinition);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetDataSourceContents(DataSource);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var methodGetDataSourceContentsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDataSourceContents = { DataSource };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataSourceContents, methodGetDataSourceContentsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataSourceDefinition>(_reportingService2005InstanceFixture, parametersOfGetDataSourceContents);
            var result2 = this.GetResultOfMethod<DataSourceDefinition>(MethodGetDataSourceContents, parametersOfGetDataSourceContents, methodGetDataSourceContentsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDataSourceContents.ShouldNotBeNull();
            parametersOfGetDataSourceContents.Length.ShouldBe(1);
            methodGetDataSourceContentsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var methodGetDataSourceContentsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetDataSourceContents = { DataSource };

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataSourceDefinition>(MethodGetDataSourceContents, parametersOfGetDataSourceContents, methodGetDataSourceContentsParametersTypes);

            // Assert
            parametersOfGetDataSourceContents.ShouldNotBeNull();
            parametersOfGetDataSourceContents.Length.ShouldBe(1);
            methodGetDataSourceContentsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var methodGetDataSourceContentsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataSourceContents, methodGetDataSourceContentsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDataSourceContentsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var methodGetDataSourceContentsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataSourceContents, methodGetDataSourceContentsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataSourceContentsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataSourceContents, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDataSourceContents) (Return Type : DataSourceDefinition) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetDataSourceContents_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataSourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataSourceContents, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetDataSourceContentsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataSourceContentsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataSourceContentsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetDataSourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetDataSourceContentsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetDataSourceContentsOperationCompleted, parametersOfOnGetDataSourceContentsOperationCompleted, methodOnGetDataSourceContentsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetDataSourceContentsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetDataSourceContentsOperationCompleted.Length.ShouldBe(1);
            methodOnGetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetDataSourceContentsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetDataSourceContentsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataSourceContentsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataSourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetDataSourceContentsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetDataSourceContentsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataSourceContentsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataSourceContentsOperationCompleted);
            var methodOnGetDataSourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetDataSourceContentsOperationCompleted, methodOnGetDataSourceContentsOperationCompletedParametersTypes);

            // Assert
            methodOnGetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetDataSourceContentsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetDataSourceContentsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetDataSourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetDataSourceContentsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetDataSourceContents) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var Definition = this.CreateType<DataSourceDefinition>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetDataSourceContents(DataSource, Definition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDataSourceContents) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var Definition = this.CreateType<DataSourceDefinition>();
            var methodSetDataSourceContentsParametersTypes = new Type[] { typeof(string), typeof(DataSourceDefinition) };
            object[] parametersOfSetDataSourceContents = { DataSource, Definition };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataSourceContents, methodSetDataSourceContentsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetDataSourceContents);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDataSourceContents.ShouldNotBeNull();
            parametersOfSetDataSourceContents.Length.ShouldBe(2);
            methodSetDataSourceContentsParametersTypes.Length.ShouldBe(2);
            methodSetDataSourceContentsParametersTypes.Length.ShouldBe(parametersOfSetDataSourceContents.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetDataSourceContents) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var DataSource = this.CreateType<string>();
            var Definition = this.CreateType<DataSourceDefinition>();
            var methodSetDataSourceContentsParametersTypes = new Type[] { typeof(string), typeof(DataSourceDefinition) };
            object[] parametersOfSetDataSourceContents = { DataSource, Definition };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDataSourceContents, parametersOfSetDataSourceContents, methodSetDataSourceContentsParametersTypes);

            // Assert
            parametersOfSetDataSourceContents.ShouldNotBeNull();
            parametersOfSetDataSourceContents.Length.ShouldBe(2);
            methodSetDataSourceContentsParametersTypes.Length.ShouldBe(2);
            methodSetDataSourceContentsParametersTypes.Length.ShouldBe(parametersOfSetDataSourceContents.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataSourceContents) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataSourceContents, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDataSourceContents) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var methodSetDataSourceContentsParametersTypes = new Type[] { typeof(string), typeof(DataSourceDefinition) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDataSourceContents, methodSetDataSourceContentsParametersTypes);

            // Assert
            methodSetDataSourceContentsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataSourceContents) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataSourceContents_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataSourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataSourceContents, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetDataSourceContentsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataSourceContentsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataSourceContentsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetDataSourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetDataSourceContentsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetDataSourceContentsOperationCompleted, parametersOfOnSetDataSourceContentsOperationCompleted, methodOnSetDataSourceContentsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetDataSourceContentsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetDataSourceContentsOperationCompleted.Length.ShouldBe(1);
            methodOnSetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetDataSourceContentsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetDataSourceContentsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataSourceContentsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataSourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetDataSourceContentsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetDataSourceContentsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataSourceContentsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataSourceContentsOperationCompleted);
            var methodOnSetDataSourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetDataSourceContentsOperationCompleted, methodOnSetDataSourceContentsOperationCompletedParametersTypes);

            // Assert
            methodOnSetDataSourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetDataSourceContentsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataSourceContentsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataSourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetDataSourceContentsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (EnableDataSource) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var DataSource = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.EnableDataSource(DataSource);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (EnableDataSource) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var DataSource = this.CreateType<string>();
            var methodEnableDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEnableDataSource = { DataSource };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodEnableDataSource, methodEnableDataSourceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfEnableDataSource);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfEnableDataSource.ShouldNotBeNull();
            parametersOfEnableDataSource.Length.ShouldBe(1);
            methodEnableDataSourceParametersTypes.Length.ShouldBe(1);
            methodEnableDataSourceParametersTypes.Length.ShouldBe(parametersOfEnableDataSource.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (EnableDataSource) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var DataSource = this.CreateType<string>();
            var methodEnableDataSourceParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfEnableDataSource = { DataSource };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodEnableDataSource, parametersOfEnableDataSource, methodEnableDataSourceParametersTypes);

            // Assert
            parametersOfEnableDataSource.ShouldNotBeNull();
            parametersOfEnableDataSource.Length.ShouldBe(1);
            methodEnableDataSourceParametersTypes.Length.ShouldBe(1);
            methodEnableDataSourceParametersTypes.Length.ShouldBe(parametersOfEnableDataSource.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnableDataSource) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodEnableDataSource, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (EnableDataSource) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var methodEnableDataSourceParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodEnableDataSource, methodEnableDataSourceParametersTypes);

            // Assert
            methodEnableDataSourceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (EnableDataSource) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_EnableDataSource_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodEnableDataSource);
            var currentMethodInfo = this.GetMethodInfo(MethodEnableDataSource, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #endregion

        #endregion
    }
}