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
    public partial class ReportingService20053Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20053Test() : base(typeof(ReportingService2005))
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

        private const string MethodOnCreateFolderOperationCompleted = "OnCreateFolderOperationCompleted";
        private const string MethodCreateReport = "CreateReport";
        private const string MethodOnCreateReportOperationCompleted = "OnCreateReportOperationCompleted";
        private const string MethodGetReportDefinition = "GetReportDefinition";
        private const string MethodOnGetReportDefinitionOperationCompleted = "OnGetReportDefinitionOperationCompleted";
        private const string MethodSetReportDefinition = "SetReportDefinition";
        private const string MethodOnSetReportDefinitionOperationCompleted = "OnSetReportDefinitionOperationCompleted";
        private const string MethodCreateResource = "CreateResource";
        private const string MethodOnCreateResourceOperationCompleted = "OnCreateResourceOperationCompleted";
        private const string MethodSetResourceContents = "SetResourceContents";
        private const string MethodOnSetResourceContentsOperationCompleted = "OnSetResourceContentsOperationCompleted";
        private const string MethodGetResourceContents = "GetResourceContents";
        
        #endregion

        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (OnCreateFolderOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateFolderOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateFolderOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateFolderOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateFolderOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateFolderOperationCompleted, parametersOfOnCreateFolderOperationCompleted, methodOnCreateFolderOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateFolderOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateFolderOperationCompleted.Length.ShouldBe(1);
            methodOnCreateFolderOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateFolderOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateFolderOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateFolderOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateFolderOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateFolderOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateFolderOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateFolderOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateFolderOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateFolderOperationCompleted);
            var methodOnCreateFolderOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateFolderOperationCompleted, methodOnCreateFolderOperationCompletedParametersTypes);

            // Assert
            methodOnCreateFolderOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateFolderOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateFolderOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateFolderOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateFolderOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateReport) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateReport(Report, Parent, Overwrite, Definition, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.CreateReport(Report, Parent, Overwrite, Definition, Properties);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(Property[]) };
            object[] parametersOfCreateReport = { Report, Parent, Overwrite, Definition, Properties };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReport, methodCreateReportParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfCreateReport);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodCreateReport, parametersOfCreateReport, methodCreateReportParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCreateReport.ShouldNotBeNull();
            parametersOfCreateReport.Length.ShouldBe(5);
            methodCreateReportParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Definition = this.CreateType<byte[]>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(Property[]) };
            object[] parametersOfCreateReport = { Report, Parent, Overwrite, Definition, Properties };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodCreateReport, parametersOfCreateReport, methodCreateReportParametersTypes);

            // Assert
            parametersOfCreateReport.ShouldNotBeNull();
            parametersOfCreateReport.Length.ShouldBe(5);
            methodCreateReportParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var methodCreateReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(Property[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCreateReport, methodCreateReportParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCreateReportParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var methodCreateReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(Property[]) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateReport, methodCreateReportParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateReportParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReport, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CreateReport) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateReport_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateReport);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateReport, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnCreateReportOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateReportOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateReportOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateReportOperationCompleted, parametersOfOnCreateReportOperationCompleted, methodOnCreateReportOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateReportOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateReportOperationCompleted.Length.ShouldBe(1);
            methodOnCreateReportOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateReportOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateReportOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateReportOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateReportOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateReportOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportOperationCompleted);
            var methodOnCreateReportOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateReportOperationCompleted, methodOnCreateReportOperationCompletedParametersTypes);

            // Assert
            methodOnCreateReportOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateReportOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateReportOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateReportOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateReportOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetReportDefinition(Report);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var Report = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetReportDefinition(Report);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var Report = this.CreateType<string>();
            var methodGetReportDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetReportDefinition = { Report };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportDefinition, methodGetReportDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<byte[]>(_reportingService2005InstanceFixture, parametersOfGetReportDefinition);
            var result2 = this.GetResultOfMethod<byte[]>(MethodGetReportDefinition, parametersOfGetReportDefinition, methodGetReportDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReportDefinition.ShouldNotBeNull();
            parametersOfGetReportDefinition.Length.ShouldBe(1);
            methodGetReportDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var Report = this.CreateType<string>();
            var methodGetReportDefinitionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetReportDefinition = { Report };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodGetReportDefinition, parametersOfGetReportDefinition, methodGetReportDefinitionParametersTypes);

            // Assert
            parametersOfGetReportDefinition.ShouldNotBeNull();
            parametersOfGetReportDefinition.Length.ShouldBe(1);
            methodGetReportDefinitionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var methodGetReportDefinitionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReportDefinition, methodGetReportDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReportDefinitionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var methodGetReportDefinitionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReportDefinition, methodGetReportDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReportDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportDefinition) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportDefinition, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetReportDefinitionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetReportDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetReportDefinitionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetReportDefinitionOperationCompleted, parametersOfOnGetReportDefinitionOperationCompleted, methodOnGetReportDefinitionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetReportDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetReportDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnGetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetReportDefinitionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportDefinitionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportDefinitionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportDefinitionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetReportDefinitionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportDefinitionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportDefinitionOperationCompleted);
            var methodOnGetReportDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetReportDefinitionOperationCompleted, methodOnGetReportDefinitionOperationCompletedParametersTypes);

            // Assert
            methodOnGetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportDefinitionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportDefinitionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportDefinitionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var Report = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetReportDefinition(Report, Definition);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var Report = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var returnedValue = default(Warning[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.SetReportDefinition(Report, Definition);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var Report = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var methodSetReportDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            object[] parametersOfSetReportDefinition = { Report, Definition };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportDefinition, methodSetReportDefinitionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Warning[]>(_reportingService2005InstanceFixture, parametersOfSetReportDefinition);
            var result2 = this.GetResultOfMethod<Warning[]>(MethodSetReportDefinition, parametersOfSetReportDefinition, methodSetReportDefinitionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSetReportDefinition.ShouldNotBeNull();
            parametersOfSetReportDefinition.Length.ShouldBe(2);
            methodSetReportDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var Report = this.CreateType<string>();
            var Definition = this.CreateType<byte[]>();
            var methodSetReportDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            object[] parametersOfSetReportDefinition = { Report, Definition };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Warning[]>(MethodSetReportDefinition, parametersOfSetReportDefinition, methodSetReportDefinitionParametersTypes);

            // Assert
            parametersOfSetReportDefinition.ShouldNotBeNull();
            parametersOfSetReportDefinition.Length.ShouldBe(2);
            methodSetReportDefinitionParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var methodSetReportDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSetReportDefinition, methodSetReportDefinitionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSetReportDefinitionParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var methodSetReportDefinitionParametersTypes = new Type[] { typeof(string), typeof(byte[]) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetReportDefinition, methodSetReportDefinitionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSetReportDefinitionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportDefinition, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SetReportDefinition) (Return Type : Warning[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportDefinition_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportDefinition);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportDefinition, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnSetReportDefinitionOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportDefinitionOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportDefinitionOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetReportDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetReportDefinitionOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetReportDefinitionOperationCompleted, parametersOfOnSetReportDefinitionOperationCompleted, methodOnSetReportDefinitionOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetReportDefinitionOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetReportDefinitionOperationCompleted.Length.ShouldBe(1);
            methodOnSetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetReportDefinitionOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportDefinitionOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportDefinitionOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportDefinitionOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetReportDefinitionOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportDefinitionOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportDefinitionOperationCompleted);
            var methodOnSetReportDefinitionOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetReportDefinitionOperationCompleted, methodOnSetReportDefinitionOperationCompletedParametersTypes);

            // Assert
            methodOnSetReportDefinitionOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportDefinitionOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportDefinitionOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportDefinitionOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportDefinitionOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateResource) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var Resource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateResource(Resource, Parent, Overwrite, Contents, MimeType, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateResource) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var Resource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateResource = { Resource, Parent, Overwrite, Contents, MimeType, Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResource, methodCreateResourceParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCreateResource);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateResource.ShouldNotBeNull();
            parametersOfCreateResource.Length.ShouldBe(6);
            methodCreateResourceParametersTypes.Length.ShouldBe(6);
            methodCreateResourceParametersTypes.Length.ShouldBe(parametersOfCreateResource.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateResource) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var Resource = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Overwrite = this.CreateType<bool>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateResource = { Resource, Parent, Overwrite, Contents, MimeType, Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateResource, parametersOfCreateResource, methodCreateResourceParametersTypes);

            // Assert
            parametersOfCreateResource.ShouldNotBeNull();
            parametersOfCreateResource.Length.ShouldBe(6);
            methodCreateResourceParametersTypes.Length.ShouldBe(6);
            methodCreateResourceParametersTypes.Length.ShouldBe(parametersOfCreateResource.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateResource) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResource, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateResource) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var methodCreateResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(byte[]), typeof(string), typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateResource, methodCreateResourceParametersTypes);

            // Assert
            methodCreateResourceParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateResource) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateResource_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateResource);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateResource, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnCreateResourceOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateResourceOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateResourceOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateResourceOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateResourceOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateResourceOperationCompleted, parametersOfOnCreateResourceOperationCompleted, methodOnCreateResourceOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateResourceOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateResourceOperationCompleted.Length.ShouldBe(1);
            methodOnCreateResourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateResourceOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateResourceOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateResourceOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateResourceOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateResourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateResourceOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateResourceOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateResourceOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateResourceOperationCompleted);
            var methodOnCreateResourceOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateResourceOperationCompleted, methodOnCreateResourceOperationCompletedParametersTypes);

            // Assert
            methodOnCreateResourceOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateResourceOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateResourceOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateResourceOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateResourceOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetResourceContents) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var Resource = this.CreateType<string>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetResourceContents(Resource, Contents, MimeType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetResourceContents) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var Resource = this.CreateType<string>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();
            var methodSetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(byte[]), typeof(string) };
            object[] parametersOfSetResourceContents = { Resource, Contents, MimeType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetResourceContents, methodSetResourceContentsParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetResourceContents);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetResourceContents.ShouldNotBeNull();
            parametersOfSetResourceContents.Length.ShouldBe(3);
            methodSetResourceContentsParametersTypes.Length.ShouldBe(3);
            methodSetResourceContentsParametersTypes.Length.ShouldBe(parametersOfSetResourceContents.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetResourceContents) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var Resource = this.CreateType<string>();
            var Contents = this.CreateType<byte[]>();
            var MimeType = this.CreateType<string>();
            var methodSetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(byte[]), typeof(string) };
            object[] parametersOfSetResourceContents = { Resource, Contents, MimeType };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetResourceContents, parametersOfSetResourceContents, methodSetResourceContentsParametersTypes);

            // Assert
            parametersOfSetResourceContents.ShouldNotBeNull();
            parametersOfSetResourceContents.Length.ShouldBe(3);
            methodSetResourceContentsParametersTypes.Length.ShouldBe(3);
            methodSetResourceContentsParametersTypes.Length.ShouldBe(parametersOfSetResourceContents.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResourceContents) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResourceContents, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetResourceContents) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var methodSetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(byte[]), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetResourceContents, methodSetResourceContentsParametersTypes);

            // Assert
            methodSetResourceContentsParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetResourceContents) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetResourceContents_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetResourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodSetResourceContents, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetResourceContentsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetResourceContentsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetResourceContentsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetResourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetResourceContentsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetResourceContentsOperationCompleted, parametersOfOnSetResourceContentsOperationCompleted, methodOnSetResourceContentsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetResourceContentsOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetResourceContentsOperationCompleted.Length.ShouldBe(1);
            methodOnSetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetResourceContentsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetResourceContentsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetResourceContentsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetResourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetResourceContentsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetResourceContentsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetResourceContentsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetResourceContentsOperationCompleted);
            var methodOnSetResourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetResourceContentsOperationCompleted, methodOnSetResourceContentsOperationCompletedParametersTypes);

            // Assert
            methodOnSetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetResourceContentsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetResourceContentsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetResourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetResourceContentsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetResourceContents) (Return Type : byte[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var Resource = this.CreateType<string>();
            
            // Act
            Action executeAction = () => _reportingService2005Instance.GetResourceContents(Resource, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var Resource = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetResourceContents(Resource, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var Resource = this.CreateType<string>();
            var MimeType = this.CreateType<string>();
            var methodGetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetResourceContents = { Resource, MimeType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResourceContents, methodGetResourceContentsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<byte[]>(_reportingService2005InstanceFixture, parametersOfGetResourceContents);
            var result2 = this.GetResultOfMethod<byte[]>(MethodGetResourceContents, parametersOfGetResourceContents, methodGetResourceContentsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResourceContents.ShouldNotBeNull();
            parametersOfGetResourceContents.Length.ShouldBe(2);
            methodGetResourceContentsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var Resource = this.CreateType<string>();
            var MimeType = this.CreateType<string>();
            var methodGetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetResourceContents = { Resource, MimeType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodGetResourceContents, parametersOfGetResourceContents, methodGetResourceContentsParametersTypes);

            // Assert
            parametersOfGetResourceContents.ShouldNotBeNull();
            parametersOfGetResourceContents.Length.ShouldBe(2);
            methodGetResourceContentsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var methodGetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResourceContents, methodGetResourceContentsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResourceContentsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var methodGetResourceContentsParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResourceContents, methodGetResourceContentsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResourceContentsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResourceContents, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResourceContents) (Return Type : byte[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetResourceContents_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResourceContents);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResourceContents, 0);
            const int parametersCount = 2;

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