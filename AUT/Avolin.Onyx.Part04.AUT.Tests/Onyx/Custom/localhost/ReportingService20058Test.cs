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
    public partial class ReportingService20058Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20058Test() : base(typeof(ReportingService2005))
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

        private const string MethodCreateSchedule = "CreateSchedule";
        private const string MethodOnCreateScheduleOperationCompleted = "OnCreateScheduleOperationCompleted";
        private const string MethodDeleteSchedule = "DeleteSchedule";
        private const string MethodOnDeleteScheduleOperationCompleted = "OnDeleteScheduleOperationCompleted";
        private const string MethodSetScheduleProperties = "SetScheduleProperties";
        private const string MethodOnSetSchedulePropertiesOperationCompleted = "OnSetSchedulePropertiesOperationCompleted";
        private const string MethodGetScheduleProperties = "GetScheduleProperties";
        private const string MethodOnGetSchedulePropertiesOperationCompleted = "OnGetSchedulePropertiesOperationCompleted";
        private const string MethodListScheduledReports = "ListScheduledReports";
        private const string MethodOnListScheduledReportsOperationCompleted = "OnListScheduledReportsOperationCompleted";
        private const string MethodListSchedules = "ListSchedules";
        private const string MethodOnListSchedulesOperationCompleted = "OnListSchedulesOperationCompleted";
        private const string MethodPauseSchedule = "PauseSchedule";
        private const string MethodOnPauseScheduleOperationCompleted = "OnPauseScheduleOperationCompleted";
        private const string MethodResumeSchedule = "ResumeSchedule";
        private const string MethodOnResumeScheduleOperationCompleted = "OnResumeScheduleOperationCompleted";
        private const string MethodCreateSubscription = "CreateSubscription";
        private const string MethodOnCreateSubscriptionOperationCompleted = "OnCreateSubscriptionOperationCompleted";
        private const string MethodCreateDataDrivenSubscription = "CreateDataDrivenSubscription";
        private const string MethodOnCreateDataDrivenSubscriptionOperationCompleted = "OnCreateDataDrivenSubscriptionOperationCompleted";
        private const string MethodSetSubscriptionProperties = "SetSubscriptionProperties";
        private const string MethodOnSetSubscriptionPropertiesOperationCompleted = "OnSetSubscriptionPropertiesOperationCompleted";
        private const string MethodSetDataDrivenSubscriptionProperties = "SetDataDrivenSubscriptionProperties";
        private const string MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted = "OnSetDataDrivenSubscriptionPropertiesOperationCompleted";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (CreateSchedule) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var Name = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();
            var methodCreateScheduleParametersTypes = new Type[] { typeof(string), typeof(ScheduleDefinition) };
            object[] parametersOfCreateSchedule = { Name, ScheduleDefinition };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSchedule, methodCreateScheduleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfCreateSchedule);
            var result2 = this.GetResultOfMethod<string>(MethodCreateSchedule, parametersOfCreateSchedule, methodCreateScheduleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateSchedule.ShouldNotBeNull();
            parametersOfCreateSchedule.Length.ShouldBe(2);
            methodCreateScheduleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var Name = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();
            var methodCreateScheduleParametersTypes = new Type[] { typeof(string), typeof(ScheduleDefinition) };
            object[] parametersOfCreateSchedule = { Name, ScheduleDefinition };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateSchedule, parametersOfCreateSchedule, methodCreateScheduleParametersTypes);

            // Assert
            parametersOfCreateSchedule.ShouldNotBeNull();
            parametersOfCreateSchedule.Length.ShouldBe(2);
            methodCreateScheduleParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var methodCreateScheduleParametersTypes = new Type[] { typeof(string), typeof(ScheduleDefinition) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSchedule, methodCreateScheduleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateScheduleParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var methodCreateScheduleParametersTypes = new Type[] { typeof(string), typeof(ScheduleDefinition) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSchedule, methodCreateScheduleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateScheduleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSchedule, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSchedule) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSchedule_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSchedule, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateScheduleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateScheduleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateScheduleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateScheduleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateScheduleOperationCompleted, parametersOfOnCreateScheduleOperationCompleted, methodOnCreateScheduleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateScheduleOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateScheduleOperationCompleted.Length.ShouldBe(1);
            methodOnCreateScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateScheduleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateScheduleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateScheduleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateScheduleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateScheduleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateScheduleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateScheduleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateScheduleOperationCompleted);
            var methodOnCreateScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateScheduleOperationCompleted, methodOnCreateScheduleOperationCompletedParametersTypes);

            // Assert
            methodOnCreateScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateScheduleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateScheduleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateScheduleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (DeleteSchedule) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var ScheduleID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.DeleteSchedule(ScheduleID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSchedule) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodDeleteScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteSchedule = { ScheduleID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSchedule, methodDeleteScheduleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfDeleteSchedule);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteSchedule.ShouldNotBeNull();
            parametersOfDeleteSchedule.Length.ShouldBe(1);
            methodDeleteScheduleParametersTypes.Length.ShouldBe(1);
            methodDeleteScheduleParametersTypes.Length.ShouldBe(parametersOfDeleteSchedule.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSchedule) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodDeleteScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfDeleteSchedule = { ScheduleID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteSchedule, parametersOfDeleteSchedule, methodDeleteScheduleParametersTypes);

            // Assert
            parametersOfDeleteSchedule.ShouldNotBeNull();
            parametersOfDeleteSchedule.Length.ShouldBe(1);
            methodDeleteScheduleParametersTypes.Length.ShouldBe(1);
            methodDeleteScheduleParametersTypes.Length.ShouldBe(parametersOfDeleteSchedule.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSchedule) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSchedule, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSchedule) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var methodDeleteScheduleParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSchedule, methodDeleteScheduleParametersTypes);

            // Assert
            methodDeleteScheduleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSchedule) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_DeleteSchedule_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSchedule, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnDeleteScheduleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteScheduleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteScheduleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnDeleteScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnDeleteScheduleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnDeleteScheduleOperationCompleted, parametersOfOnDeleteScheduleOperationCompleted, methodOnDeleteScheduleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnDeleteScheduleOperationCompleted.ShouldNotBeNull();
            parametersOfOnDeleteScheduleOperationCompleted.Length.ShouldBe(1);
            methodOnDeleteScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnDeleteScheduleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnDeleteScheduleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteScheduleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteScheduleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteScheduleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnDeleteScheduleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteScheduleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteScheduleOperationCompleted);
            var methodOnDeleteScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnDeleteScheduleOperationCompleted, methodOnDeleteScheduleOperationCompletedParametersTypes);

            // Assert
            methodOnDeleteScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnDeleteScheduleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnDeleteScheduleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnDeleteScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnDeleteScheduleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetScheduleProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var Name = this.CreateType<string>();
            var ScheduleID = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetScheduleProperties(Name, ScheduleID, ScheduleDefinition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetScheduleProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var Name = this.CreateType<string>();
            var ScheduleID = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();
            var methodSetSchedulePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ScheduleDefinition) };
            object[] parametersOfSetScheduleProperties = { Name, ScheduleID, ScheduleDefinition };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetScheduleProperties, methodSetSchedulePropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetScheduleProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetScheduleProperties.ShouldNotBeNull();
            parametersOfSetScheduleProperties.Length.ShouldBe(3);
            methodSetSchedulePropertiesParametersTypes.Length.ShouldBe(3);
            methodSetSchedulePropertiesParametersTypes.Length.ShouldBe(parametersOfSetScheduleProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetScheduleProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var Name = this.CreateType<string>();
            var ScheduleID = this.CreateType<string>();
            var ScheduleDefinition = this.CreateType<ScheduleDefinition>();
            var methodSetSchedulePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ScheduleDefinition) };
            object[] parametersOfSetScheduleProperties = { Name, ScheduleID, ScheduleDefinition };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetScheduleProperties, parametersOfSetScheduleProperties, methodSetSchedulePropertiesParametersTypes);

            // Assert
            parametersOfSetScheduleProperties.ShouldNotBeNull();
            parametersOfSetScheduleProperties.Length.ShouldBe(3);
            methodSetSchedulePropertiesParametersTypes.Length.ShouldBe(3);
            methodSetSchedulePropertiesParametersTypes.Length.ShouldBe(parametersOfSetScheduleProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetScheduleProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetScheduleProperties, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetScheduleProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var methodSetSchedulePropertiesParametersTypes = new Type[] { typeof(string), typeof(string), typeof(ScheduleDefinition) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetScheduleProperties, methodSetSchedulePropertiesParametersTypes);

            // Assert
            methodSetSchedulePropertiesParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetScheduleProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetScheduleProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetScheduleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetScheduleProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetSchedulePropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSchedulePropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSchedulePropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSchedulePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSchedulePropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetSchedulePropertiesOperationCompleted, parametersOfOnSetSchedulePropertiesOperationCompleted, methodOnSetSchedulePropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetSchedulePropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSchedulePropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSchedulePropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSchedulePropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSchedulePropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSchedulePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSchedulePropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetSchedulePropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSchedulePropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSchedulePropertiesOperationCompleted);
            var methodOnSetSchedulePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetSchedulePropertiesOperationCompleted, methodOnSetSchedulePropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSchedulePropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSchedulePropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSchedulePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSchedulePropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var ScheduleID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetScheduleProperties(ScheduleID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var ScheduleID = this.CreateType<string>();
            var returnedValue = default(Schedule);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetScheduleProperties(ScheduleID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var ScheduleID = this.CreateType<string>();
            var methodGetSchedulePropertiesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetScheduleProperties = { ScheduleID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScheduleProperties, methodGetSchedulePropertiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Schedule>(_reportingService2005InstanceFixture, parametersOfGetScheduleProperties);
            var result2 = this.GetResultOfMethod<Schedule>(MethodGetScheduleProperties, parametersOfGetScheduleProperties, methodGetSchedulePropertiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScheduleProperties.ShouldNotBeNull();
            parametersOfGetScheduleProperties.Length.ShouldBe(1);
            methodGetSchedulePropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var ScheduleID = this.CreateType<string>();
            var methodGetSchedulePropertiesParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetScheduleProperties = { ScheduleID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Schedule>(MethodGetScheduleProperties, parametersOfGetScheduleProperties, methodGetSchedulePropertiesParametersTypes);

            // Assert
            parametersOfGetScheduleProperties.ShouldNotBeNull();
            parametersOfGetScheduleProperties.Length.ShouldBe(1);
            methodGetSchedulePropertiesParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var methodGetSchedulePropertiesParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScheduleProperties, methodGetSchedulePropertiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSchedulePropertiesParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var methodGetSchedulePropertiesParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScheduleProperties, methodGetSchedulePropertiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSchedulePropertiesParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScheduleProperties, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScheduleProperties) (Return Type : Schedule) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetScheduleProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScheduleProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScheduleProperties, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSchedulePropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSchedulePropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSchedulePropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetSchedulePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetSchedulePropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetSchedulePropertiesOperationCompleted, parametersOfOnGetSchedulePropertiesOperationCompleted, methodOnGetSchedulePropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetSchedulePropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetSchedulePropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnGetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetSchedulePropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSchedulePropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSchedulePropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSchedulePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSchedulePropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetSchedulePropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSchedulePropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSchedulePropertiesOperationCompleted);
            var methodOnGetSchedulePropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetSchedulePropertiesOperationCompleted, methodOnGetSchedulePropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnGetSchedulePropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetSchedulePropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetSchedulePropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetSchedulePropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetSchedulePropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var ScheduleID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ListScheduledReports(ScheduleID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var ScheduleID = this.CreateType<string>();
            var returnedValue = default(CatalogItem[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListScheduledReports(ScheduleID);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var ScheduleID = this.CreateType<string>();
            var methodListScheduledReportsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListScheduledReports = { ScheduleID };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListScheduledReports, methodListScheduledReportsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<CatalogItem[]>(_reportingService2005InstanceFixture, parametersOfListScheduledReports);
            var result2 = this.GetResultOfMethod<CatalogItem[]>(MethodListScheduledReports, parametersOfListScheduledReports, methodListScheduledReportsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListScheduledReports.ShouldNotBeNull();
            parametersOfListScheduledReports.Length.ShouldBe(1);
            methodListScheduledReportsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var ScheduleID = this.CreateType<string>();
            var methodListScheduledReportsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfListScheduledReports = { ScheduleID };

            // Act
            Action currentAction = () => this.GetResultOfMethod<CatalogItem[]>(MethodListScheduledReports, parametersOfListScheduledReports, methodListScheduledReportsParametersTypes);

            // Assert
            parametersOfListScheduledReports.ShouldNotBeNull();
            parametersOfListScheduledReports.Length.ShouldBe(1);
            methodListScheduledReportsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var methodListScheduledReportsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListScheduledReports, methodListScheduledReportsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListScheduledReportsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var methodListScheduledReportsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListScheduledReports, methodListScheduledReportsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListScheduledReportsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var currentMethodInfo = this.GetMethodInfo(MethodListScheduledReports, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListScheduledReports) (Return Type : CatalogItem[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListScheduledReports_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListScheduledReports);
            var currentMethodInfo = this.GetMethodInfo(MethodListScheduledReports, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnListScheduledReportsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListScheduledReportsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListScheduledReportsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListScheduledReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListScheduledReportsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListScheduledReportsOperationCompleted, parametersOfOnListScheduledReportsOperationCompleted, methodOnListScheduledReportsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListScheduledReportsOperationCompleted.ShouldNotBeNull();
            parametersOfOnListScheduledReportsOperationCompleted.Length.ShouldBe(1);
            methodOnListScheduledReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListScheduledReportsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListScheduledReportsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListScheduledReportsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListScheduledReportsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListScheduledReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListScheduledReportsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListScheduledReportsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListScheduledReportsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListScheduledReportsOperationCompleted);
            var methodOnListScheduledReportsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListScheduledReportsOperationCompleted, methodOnListScheduledReportsOperationCompletedParametersTypes);

            // Assert
            methodOnListScheduledReportsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListScheduledReportsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListScheduledReportsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListScheduledReportsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListScheduledReportsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ListSchedules) (Return Type : Schedule[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);

            // Act
            Action executeAction = () => _reportingService2005Instance.ListSchedules();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            var returnedValue = default(Schedule[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.ListSchedules();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            Type [] methodListSchedulesParametersTypes = null;
            object[] parametersOfListSchedules = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodListSchedules, methodListSchedulesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Schedule[]>(_reportingService2005InstanceFixture, parametersOfListSchedules);
            var result2 = this.GetResultOfMethod<Schedule[]>(MethodListSchedules, parametersOfListSchedules, methodListSchedulesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfListSchedules.ShouldBeNull();
            methodListSchedulesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            Type [] methodListSchedulesParametersTypes = null;
            object[] parametersOfListSchedules = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<Schedule[]>(MethodListSchedules, parametersOfListSchedules, methodListSchedulesParametersTypes);

            // Assert
            parametersOfListSchedules.ShouldBeNull();
            methodListSchedulesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            Type [] methodListSchedulesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodListSchedules, methodListSchedulesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodListSchedulesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            Type [] methodListSchedulesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodListSchedules, methodListSchedulesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodListSchedulesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ListSchedules) (Return Type : Schedule[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ListSchedules_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodListSchedules);
            var currentMethodInfo = this.GetMethodInfo(MethodListSchedules, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (OnListSchedulesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSchedulesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSchedulesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnListSchedulesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnListSchedulesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnListSchedulesOperationCompleted, parametersOfOnListSchedulesOperationCompleted, methodOnListSchedulesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnListSchedulesOperationCompleted.ShouldNotBeNull();
            parametersOfOnListSchedulesOperationCompleted.Length.ShouldBe(1);
            methodOnListSchedulesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnListSchedulesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnListSchedulesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSchedulesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSchedulesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSchedulesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSchedulesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnListSchedulesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSchedulesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSchedulesOperationCompleted);
            var methodOnListSchedulesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnListSchedulesOperationCompleted, methodOnListSchedulesOperationCompletedParametersTypes);

            // Assert
            methodOnListSchedulesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnListSchedulesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnListSchedulesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnListSchedulesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnListSchedulesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (PauseSchedule) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var ScheduleID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.PauseSchedule(ScheduleID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PauseSchedule) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodPauseScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPauseSchedule = { ScheduleID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPauseSchedule, methodPauseScheduleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfPauseSchedule);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPauseSchedule.ShouldNotBeNull();
            parametersOfPauseSchedule.Length.ShouldBe(1);
            methodPauseScheduleParametersTypes.Length.ShouldBe(1);
            methodPauseScheduleParametersTypes.Length.ShouldBe(parametersOfPauseSchedule.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PauseSchedule) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodPauseScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfPauseSchedule = { ScheduleID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPauseSchedule, parametersOfPauseSchedule, methodPauseScheduleParametersTypes);

            // Assert
            parametersOfPauseSchedule.ShouldNotBeNull();
            parametersOfPauseSchedule.Length.ShouldBe(1);
            methodPauseScheduleParametersTypes.Length.ShouldBe(1);
            methodPauseScheduleParametersTypes.Length.ShouldBe(parametersOfPauseSchedule.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PauseSchedule) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodPauseSchedule, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PauseSchedule) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var methodPauseScheduleParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPauseSchedule, methodPauseScheduleParametersTypes);

            // Assert
            methodPauseScheduleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PauseSchedule) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_PauseSchedule_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPauseSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodPauseSchedule, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnPauseScheduleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPauseScheduleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPauseScheduleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnPauseScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnPauseScheduleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnPauseScheduleOperationCompleted, parametersOfOnPauseScheduleOperationCompleted, methodOnPauseScheduleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnPauseScheduleOperationCompleted.ShouldNotBeNull();
            parametersOfOnPauseScheduleOperationCompleted.Length.ShouldBe(1);
            methodOnPauseScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnPauseScheduleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnPauseScheduleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnPauseScheduleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPauseScheduleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPauseScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnPauseScheduleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnPauseScheduleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPauseScheduleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPauseScheduleOperationCompleted);
            var methodOnPauseScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnPauseScheduleOperationCompleted, methodOnPauseScheduleOperationCompletedParametersTypes);

            // Assert
            methodOnPauseScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnPauseScheduleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnPauseScheduleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnPauseScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnPauseScheduleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (ResumeSchedule) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var ScheduleID = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.ResumeSchedule(ScheduleID);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResumeSchedule) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodResumeScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfResumeSchedule = { ScheduleID };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSchedule, methodResumeScheduleParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfResumeSchedule);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfResumeSchedule.ShouldNotBeNull();
            parametersOfResumeSchedule.Length.ShouldBe(1);
            methodResumeScheduleParametersTypes.Length.ShouldBe(1);
            methodResumeScheduleParametersTypes.Length.ShouldBe(parametersOfResumeSchedule.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (ResumeSchedule) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var ScheduleID = this.CreateType<string>();
            var methodResumeScheduleParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfResumeSchedule = { ScheduleID };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodResumeSchedule, parametersOfResumeSchedule, methodResumeScheduleParametersTypes);

            // Assert
            parametersOfResumeSchedule.ShouldNotBeNull();
            parametersOfResumeSchedule.Length.ShouldBe(1);
            methodResumeScheduleParametersTypes.Length.ShouldBe(1);
            methodResumeScheduleParametersTypes.Length.ShouldBe(parametersOfResumeSchedule.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResumeSchedule) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSchedule, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResumeSchedule) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var methodResumeScheduleParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResumeSchedule, methodResumeScheduleParametersTypes);

            // Assert
            methodResumeScheduleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResumeSchedule) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_ResumeSchedule_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResumeSchedule);
            var currentMethodInfo = this.GetMethodInfo(MethodResumeSchedule, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnResumeScheduleOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnResumeScheduleOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnResumeScheduleOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnResumeScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnResumeScheduleOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnResumeScheduleOperationCompleted, parametersOfOnResumeScheduleOperationCompleted, methodOnResumeScheduleOperationCompletedParametersTypes);

            // Assert
            parametersOfOnResumeScheduleOperationCompleted.ShouldNotBeNull();
            parametersOfOnResumeScheduleOperationCompleted.Length.ShouldBe(1);
            methodOnResumeScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnResumeScheduleOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnResumeScheduleOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnResumeScheduleOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnResumeScheduleOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnResumeScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnResumeScheduleOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnResumeScheduleOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnResumeScheduleOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnResumeScheduleOperationCompleted);
            var methodOnResumeScheduleOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnResumeScheduleOperationCompleted, methodOnResumeScheduleOperationCompletedParametersTypes);

            // Assert
            methodOnResumeScheduleOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnResumeScheduleOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnResumeScheduleOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnResumeScheduleOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnResumeScheduleOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateSubscription(Report, ExtensionSettings, Description, EventType, MatchData, Parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateSubscription(Report, ExtensionSettings, Description, EventType, MatchData, Parameters);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodCreateSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfCreateSubscription = { Report, ExtensionSettings, Description, EventType, MatchData, Parameters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSubscription, methodCreateSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfCreateSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodCreateSubscription, parametersOfCreateSubscription, methodCreateSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateSubscription.ShouldNotBeNull();
            parametersOfCreateSubscription.Length.ShouldBe(6);
            methodCreateSubscriptionParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodCreateSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfCreateSubscription = { Report, ExtensionSettings, Description, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateSubscription, parametersOfCreateSubscription, methodCreateSubscriptionParametersTypes);

            // Assert
            parametersOfCreateSubscription.ShouldNotBeNull();
            parametersOfCreateSubscription.Length.ShouldBe(6);
            methodCreateSubscriptionParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var methodCreateSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateSubscription, methodCreateSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateSubscriptionParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var methodCreateSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateSubscription, methodCreateSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateSubscription) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateSubscription, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateSubscriptionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateSubscriptionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateSubscriptionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateSubscriptionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateSubscriptionOperationCompleted, parametersOfOnCreateSubscriptionOperationCompleted, methodOnCreateSubscriptionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateSubscriptionOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateSubscriptionOperationCompleted.Length.ShouldBe(1);
            methodOnCreateSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateSubscriptionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateSubscriptionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateSubscriptionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateSubscriptionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateSubscriptionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateSubscriptionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateSubscriptionOperationCompleted);
            var methodOnCreateSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateSubscriptionOperationCompleted, methodOnCreateSubscriptionOperationCompletedParametersTypes);

            // Assert
            methodOnCreateSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateSubscriptionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateSubscriptionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateSubscriptionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateDataDrivenSubscription(Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateDataDrivenSubscription(Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodCreateDataDrivenSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfCreateDataDrivenSubscription = { Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataDrivenSubscription, methodCreateDataDrivenSubscriptionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfCreateDataDrivenSubscription);
            var result2 = this.GetResultOfMethod<string>(MethodCreateDataDrivenSubscription, parametersOfCreateDataDrivenSubscription, methodCreateDataDrivenSubscriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateDataDrivenSubscription.ShouldNotBeNull();
            parametersOfCreateDataDrivenSubscription.Length.ShouldBe(7);
            methodCreateDataDrivenSubscriptionParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var Report = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodCreateDataDrivenSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfCreateDataDrivenSubscription = { Report, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodCreateDataDrivenSubscription, parametersOfCreateDataDrivenSubscription, methodCreateDataDrivenSubscriptionParametersTypes);

            // Assert
            parametersOfCreateDataDrivenSubscription.ShouldNotBeNull();
            parametersOfCreateDataDrivenSubscription.Length.ShouldBe(7);
            methodCreateDataDrivenSubscriptionParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var methodCreateDataDrivenSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateDataDrivenSubscription, methodCreateDataDrivenSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateDataDrivenSubscriptionParametersTypes.Length.ShouldBe(7);
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var methodCreateDataDrivenSubscriptionParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            const int parametersCount = 7;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateDataDrivenSubscription, methodCreateDataDrivenSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateDataDrivenSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataDrivenSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateDataDrivenSubscription) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateDataDrivenSubscription_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateDataDrivenSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateDataDrivenSubscription, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateDataDrivenSubscriptionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataDrivenSubscriptionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataDrivenSubscriptionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateDataDrivenSubscriptionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateDataDrivenSubscriptionOperationCompleted, parametersOfOnCreateDataDrivenSubscriptionOperationCompleted, methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateDataDrivenSubscriptionOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateDataDrivenSubscriptionOperationCompleted.Length.ShouldBe(1);
            methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateDataDrivenSubscriptionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateDataDrivenSubscriptionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataDrivenSubscriptionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataDrivenSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateDataDrivenSubscriptionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateDataDrivenSubscriptionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataDrivenSubscriptionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataDrivenSubscriptionOperationCompleted);
            var methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateDataDrivenSubscriptionOperationCompleted, methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes);

            // Assert
            methodOnCreateDataDrivenSubscriptionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateDataDrivenSubscriptionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateDataDrivenSubscriptionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateDataDrivenSubscriptionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateDataDrivenSubscriptionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetSubscriptionProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetSubscriptionProperties(SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetSubscriptionProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodSetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfSetSubscriptionProperties = { SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscriptionProperties, methodSetSubscriptionPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetSubscriptionProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetSubscriptionProperties.ShouldNotBeNull();
            parametersOfSetSubscriptionProperties.Length.ShouldBe(6);
            methodSetSubscriptionPropertiesParametersTypes.Length.ShouldBe(6);
            methodSetSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersOfSetSubscriptionProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscriptionProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var SubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValue[]>();
            var methodSetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };
            object[] parametersOfSetSubscriptionProperties = { SubscriptionID, ExtensionSettings, Description, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetSubscriptionProperties, parametersOfSetSubscriptionProperties, methodSetSubscriptionPropertiesParametersTypes);

            // Assert
            parametersOfSetSubscriptionProperties.ShouldNotBeNull();
            parametersOfSetSubscriptionProperties.Length.ShouldBe(6);
            methodSetSubscriptionPropertiesParametersTypes.Length.ShouldBe(6);
            methodSetSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersOfSetSubscriptionProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscriptionProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscriptionProperties, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetSubscriptionProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var methodSetSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(string), typeof(string), typeof(string), typeof(ParameterValue[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetSubscriptionProperties, methodSetSubscriptionPropertiesParametersTypes);

            // Assert
            methodSetSubscriptionPropertiesParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetSubscriptionProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetSubscriptionProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetSubscriptionProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetSubscriptionPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetSubscriptionPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetSubscriptionPropertiesOperationCompleted, parametersOfOnSetSubscriptionPropertiesOperationCompleted, methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetSubscriptionPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSubscriptionPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSubscriptionPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSubscriptionPropertiesOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSubscriptionPropertiesOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSubscriptionPropertiesOperationCompleted);
            var methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetSubscriptionPropertiesOperationCompleted, methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            methodOnSetSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetSubscriptionPropertiesOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetSubscriptionPropertiesOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetSubscriptionPropertiesOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetDataDrivenSubscriptionProperties(DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodSetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfSetDataDrivenSubscriptionProperties = { DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataDrivenSubscriptionProperties, methodSetDataDrivenSubscriptionPropertiesParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetDataDrivenSubscriptionProperties);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetDataDrivenSubscriptionProperties.ShouldNotBeNull();
            parametersOfSetDataDrivenSubscriptionProperties.Length.ShouldBe(7);
            methodSetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(7);
            methodSetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersOfSetDataDrivenSubscriptionProperties.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var DataDrivenSubscriptionID = this.CreateType<string>();
            var ExtensionSettings = this.CreateType<ExtensionSettings>();
            var DataRetrievalPlan = this.CreateType<DataRetrievalPlan>();
            var Description = this.CreateType<string>();
            var EventType = this.CreateType<string>();
            var MatchData = this.CreateType<string>();
            var Parameters = this.CreateType<ParameterValueOrFieldReference[]>();
            var methodSetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };
            object[] parametersOfSetDataDrivenSubscriptionProperties = { DataDrivenSubscriptionID, ExtensionSettings, DataRetrievalPlan, Description, EventType, MatchData, Parameters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetDataDrivenSubscriptionProperties, parametersOfSetDataDrivenSubscriptionProperties, methodSetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            parametersOfSetDataDrivenSubscriptionProperties.ShouldNotBeNull();
            parametersOfSetDataDrivenSubscriptionProperties.Length.ShouldBe(7);
            methodSetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(7);
            methodSetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(parametersOfSetDataDrivenSubscriptionProperties.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataDrivenSubscriptionProperties, 0);
            const int parametersCount = 7;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var methodSetDataDrivenSubscriptionPropertiesParametersTypes = new Type[] { typeof(string), typeof(ExtensionSettings), typeof(DataRetrievalPlan), typeof(string), typeof(string), typeof(string), typeof(ParameterValueOrFieldReference[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetDataDrivenSubscriptionProperties, methodSetDataDrivenSubscriptionPropertiesParametersTypes);

            // Assert
            methodSetDataDrivenSubscriptionPropertiesParametersTypes.Length.ShouldBe(7);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetDataDrivenSubscriptionProperties) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetDataDrivenSubscriptionProperties_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetDataDrivenSubscriptionProperties);
            var currentMethodInfo = this.GetMethodInfo(MethodSetDataDrivenSubscriptionProperties, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetDataDrivenSubscriptionPropertiesOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted, parametersOfOnSetDataDrivenSubscriptionPropertiesOperationCompleted, methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetDataDrivenSubscriptionPropertiesOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetDataDrivenSubscriptionPropertiesOperationCompleted.Length.ShouldBe(1);
            methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetDataDrivenSubscriptionPropertiesOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetDataDrivenSubscriptionPropertiesOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetDataDrivenSubscriptionPropertiesOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetDataDrivenSubscriptionPropertiesOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetDataDrivenSubscriptionPropertiesOperationCompleted, 0);
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