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
    public partial class ReportingService20054Test : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ReportingService2005" />)
        /// </summary>
        public ReportingService20054Test() : base(typeof(ReportingService2005))
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

        private const string MethodOnGetResourceContentsOperationCompleted = "OnGetResourceContentsOperationCompleted";
        private const string MethodGetReportParameters = "GetReportParameters";
        private const string MethodOnGetReportParametersOperationCompleted = "OnGetReportParametersOperationCompleted";
        private const string MethodSetReportParameters = "SetReportParameters";
        private const string MethodOnSetReportParametersOperationCompleted = "OnSetReportParametersOperationCompleted";
        private const string MethodCreateLinkedReport = "CreateLinkedReport";
        private const string MethodOnCreateLinkedReportOperationCompleted = "OnCreateLinkedReportOperationCompleted";
        private const string MethodGetReportLink = "GetReportLink";
        private const string MethodOnGetReportLinkOperationCompleted = "OnGetReportLinkOperationCompleted";
        private const string MethodSetReportLink = "SetReportLink";
        private const string MethodOnSetReportLinkOperationCompleted = "OnSetReportLinkOperationCompleted";
        private const string MethodGetRenderResource = "GetRenderResource";

        #endregion
        
        #endregion
        
        #endregion
        
        #region Category : MethodCallTest

        #region Method Call : (OnGetResourceContentsOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetResourceContentsOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetResourceContentsOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetResourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetResourceContentsOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetResourceContentsOperationCompleted, parametersOfOnGetResourceContentsOperationCompleted, methodOnGetResourceContentsOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetResourceContentsOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetResourceContentsOperationCompleted.Length.ShouldBe(1);
            methodOnGetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetResourceContentsOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetResourceContentsOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetResourceContentsOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetResourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetResourceContentsOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetResourceContentsOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetResourceContentsOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetResourceContentsOperationCompleted);
            var methodOnGetResourceContentsOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetResourceContentsOperationCompleted, methodOnGetResourceContentsOperationCompletedParametersTypes);

            // Assert
            methodOnGetResourceContentsOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetResourceContentsOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetResourceContentsOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetResourceContentsOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetResourceContentsOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var ForRendering = this.CreateType<bool>();
            var Values = this.CreateType<ParameterValue[]>();
            var Credentials = this.CreateType<DataSourceCredentials[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetReportParameters(Report, HistoryID, ForRendering, Values, Credentials);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var ForRendering = this.CreateType<bool>();
            var Values = this.CreateType<ParameterValue[]>();
            var Credentials = this.CreateType<DataSourceCredentials[]>();
            var returnedValue = default(ReportParameter[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetReportParameters(Report, HistoryID, ForRendering, Values, Credentials);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var ForRendering = this.CreateType<bool>();
            var Values = this.CreateType<ParameterValue[]>();
            var Credentials = this.CreateType<DataSourceCredentials[]>();
            var methodGetReportParametersParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(ParameterValue[]), typeof(DataSourceCredentials[]) };
            object[] parametersOfGetReportParameters = { Report, HistoryID, ForRendering, Values, Credentials };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportParameters, methodGetReportParametersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ReportParameter[]>(_reportingService2005InstanceFixture, parametersOfGetReportParameters);
            var result2 = this.GetResultOfMethod<ReportParameter[]>(MethodGetReportParameters, parametersOfGetReportParameters, methodGetReportParametersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReportParameters.ShouldNotBeNull();
            parametersOfGetReportParameters.Length.ShouldBe(5);
            methodGetReportParametersParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var Report = this.CreateType<string>();
            var HistoryID = this.CreateType<string>();
            var ForRendering = this.CreateType<bool>();
            var Values = this.CreateType<ParameterValue[]>();
            var Credentials = this.CreateType<DataSourceCredentials[]>();
            var methodGetReportParametersParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(ParameterValue[]), typeof(DataSourceCredentials[]) };
            object[] parametersOfGetReportParameters = { Report, HistoryID, ForRendering, Values, Credentials };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ReportParameter[]>(MethodGetReportParameters, parametersOfGetReportParameters, methodGetReportParametersParametersTypes);

            // Assert
            parametersOfGetReportParameters.ShouldNotBeNull();
            parametersOfGetReportParameters.Length.ShouldBe(5);
            methodGetReportParametersParametersTypes.Length.ShouldBe(5);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var methodGetReportParametersParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(ParameterValue[]), typeof(DataSourceCredentials[]) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReportParameters, methodGetReportParametersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReportParametersParametersTypes.Length.ShouldBe(5);
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var methodGetReportParametersParametersTypes = new Type[] { typeof(string), typeof(string), typeof(bool), typeof(ParameterValue[]), typeof(DataSourceCredentials[]) };
            const int parametersCount = 5;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReportParameters, methodGetReportParametersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReportParametersParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportParameters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportParameters) (Return Type : ReportParameter[]) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportParameters, 0);
            const int parametersCount = 5;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetReportParametersOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportParametersOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportParametersOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetReportParametersOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetReportParametersOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetReportParametersOperationCompleted, parametersOfOnGetReportParametersOperationCompleted, methodOnGetReportParametersOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetReportParametersOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetReportParametersOperationCompleted.Length.ShouldBe(1);
            methodOnGetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetReportParametersOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportParametersOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportParametersOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportParametersOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportParametersOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetReportParametersOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportParametersOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportParametersOperationCompleted);
            var methodOnGetReportParametersOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetReportParametersOperationCompleted, methodOnGetReportParametersOperationCompletedParametersTypes);

            // Assert
            methodOnGetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportParametersOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportParametersOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportParametersOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportParametersOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetReportParameters) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var Report = this.CreateType<string>();
            var Parameters = this.CreateType<ReportParameter[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetReportParameters(Report, Parameters);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetReportParameters) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var Report = this.CreateType<string>();
            var Parameters = this.CreateType<ReportParameter[]>();
            var methodSetReportParametersParametersTypes = new Type[] { typeof(string), typeof(ReportParameter[]) };
            object[] parametersOfSetReportParameters = { Report, Parameters };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportParameters, methodSetReportParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetReportParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetReportParameters.ShouldNotBeNull();
            parametersOfSetReportParameters.Length.ShouldBe(2);
            methodSetReportParametersParametersTypes.Length.ShouldBe(2);
            methodSetReportParametersParametersTypes.Length.ShouldBe(parametersOfSetReportParameters.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetReportParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var Report = this.CreateType<string>();
            var Parameters = this.CreateType<ReportParameter[]>();
            var methodSetReportParametersParametersTypes = new Type[] { typeof(string), typeof(ReportParameter[]) };
            object[] parametersOfSetReportParameters = { Report, Parameters };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetReportParameters, parametersOfSetReportParameters, methodSetReportParametersParametersTypes);

            // Assert
            parametersOfSetReportParameters.ShouldNotBeNull();
            parametersOfSetReportParameters.Length.ShouldBe(2);
            methodSetReportParametersParametersTypes.Length.ShouldBe(2);
            methodSetReportParametersParametersTypes.Length.ShouldBe(parametersOfSetReportParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportParameters, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReportParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var methodSetReportParametersParametersTypes = new Type[] { typeof(string), typeof(ReportParameter[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetReportParameters, methodSetReportParametersParametersTypes);

            // Assert
            methodSetReportParametersParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportParameters_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetReportParametersOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportParametersOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportParametersOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetReportParametersOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetReportParametersOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetReportParametersOperationCompleted, parametersOfOnSetReportParametersOperationCompleted, methodOnSetReportParametersOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetReportParametersOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetReportParametersOperationCompleted.Length.ShouldBe(1);
            methodOnSetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetReportParametersOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportParametersOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportParametersOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportParametersOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportParametersOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetReportParametersOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportParametersOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportParametersOperationCompleted);
            var methodOnSetReportParametersOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetReportParametersOperationCompleted, methodOnSetReportParametersOperationCompletedParametersTypes);

            // Assert
            methodOnSetReportParametersOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportParametersOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportParametersOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportParametersOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportParametersOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (CreateLinkedReport) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Link = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();

            // Act
            Action executeAction = () => _reportingService2005Instance.CreateLinkedReport(Report, Parent, Link, Properties);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CreateLinkedReport) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Link = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateLinkedReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateLinkedReport = { Report, Parent, Link, Properties };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodCreateLinkedReport, methodCreateLinkedReportParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfCreateLinkedReport);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfCreateLinkedReport.ShouldNotBeNull();
            parametersOfCreateLinkedReport.Length.ShouldBe(4);
            methodCreateLinkedReportParametersTypes.Length.ShouldBe(4);
            methodCreateLinkedReportParametersTypes.Length.ShouldBe(parametersOfCreateLinkedReport.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (CreateLinkedReport) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var Report = this.CreateType<string>();
            var Parent = this.CreateType<string>();
            var Link = this.CreateType<string>();
            var Properties = this.CreateType<Property[]>();
            var methodCreateLinkedReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };
            object[] parametersOfCreateLinkedReport = { Report, Parent, Link, Properties };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodCreateLinkedReport, parametersOfCreateLinkedReport, methodCreateLinkedReportParametersTypes);

            // Assert
            parametersOfCreateLinkedReport.ShouldNotBeNull();
            parametersOfCreateLinkedReport.Length.ShouldBe(4);
            methodCreateLinkedReportParametersTypes.Length.ShouldBe(4);
            methodCreateLinkedReportParametersTypes.Length.ShouldBe(parametersOfCreateLinkedReport.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateLinkedReport) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateLinkedReport, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateLinkedReport) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var methodCreateLinkedReportParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(Property[]) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateLinkedReport, methodCreateLinkedReportParametersTypes);

            // Assert
            methodCreateLinkedReportParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateLinkedReport) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_CreateLinkedReport_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateLinkedReport);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateLinkedReport, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnCreateLinkedReportOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateLinkedReportOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateLinkedReportOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnCreateLinkedReportOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnCreateLinkedReportOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnCreateLinkedReportOperationCompleted, parametersOfOnCreateLinkedReportOperationCompleted, methodOnCreateLinkedReportOperationCompletedParametersTypes);

            // Assert
            parametersOfOnCreateLinkedReportOperationCompleted.ShouldNotBeNull();
            parametersOfOnCreateLinkedReportOperationCompleted.Length.ShouldBe(1);
            methodOnCreateLinkedReportOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnCreateLinkedReportOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnCreateLinkedReportOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateLinkedReportOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateLinkedReportOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateLinkedReportOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateLinkedReportOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnCreateLinkedReportOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateLinkedReportOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateLinkedReportOperationCompleted);
            var methodOnCreateLinkedReportOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnCreateLinkedReportOperationCompleted, methodOnCreateLinkedReportOperationCompletedParametersTypes);

            // Assert
            methodOnCreateLinkedReportOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnCreateLinkedReportOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnCreateLinkedReportOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnCreateLinkedReportOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnCreateLinkedReportOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var Report = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetReportLink(Report);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var Report = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetReportLink(Report);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var Report = this.CreateType<string>();
            var methodGetReportLinkParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetReportLink = { Report };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportLink, methodGetReportLinkParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_reportingService2005InstanceFixture, parametersOfGetReportLink);
            var result2 = this.GetResultOfMethod<string>(MethodGetReportLink, parametersOfGetReportLink, methodGetReportLinkParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReportLink.ShouldNotBeNull();
            parametersOfGetReportLink.Length.ShouldBe(1);
            methodGetReportLinkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var Report = this.CreateType<string>();
            var methodGetReportLinkParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetReportLink = { Report };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetReportLink, parametersOfGetReportLink, methodGetReportLinkParametersTypes);

            // Assert
            parametersOfGetReportLink.ShouldNotBeNull();
            parametersOfGetReportLink.Length.ShouldBe(1);
            methodGetReportLinkParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var methodGetReportLinkParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReportLink, methodGetReportLinkParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReportLinkParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var methodGetReportLinkParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReportLink, methodGetReportLinkParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReportLinkParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportLink, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReportLink) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetReportLink_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReportLink);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReportLink, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
        
        #region Method Call : (OnGetReportLinkOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportLinkOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportLinkOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnGetReportLinkOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnGetReportLinkOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnGetReportLinkOperationCompleted, parametersOfOnGetReportLinkOperationCompleted, methodOnGetReportLinkOperationCompletedParametersTypes);

            // Assert
            parametersOfOnGetReportLinkOperationCompleted.ShouldNotBeNull();
            parametersOfOnGetReportLinkOperationCompleted.Length.ShouldBe(1);
            methodOnGetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnGetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnGetReportLinkOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportLinkOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportLinkOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportLinkOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportLinkOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnGetReportLinkOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportLinkOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportLinkOperationCompleted);
            var methodOnGetReportLinkOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnGetReportLinkOperationCompleted, methodOnGetReportLinkOperationCompletedParametersTypes);

            // Assert
            methodOnGetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnGetReportLinkOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnGetReportLinkOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnGetReportLinkOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnGetReportLinkOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (SetReportLink) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var Report = this.CreateType<string>();
            var Link = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.SetReportLink(Report, Link);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetReportLink) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var Report = this.CreateType<string>();
            var Link = this.CreateType<string>();
            var methodSetReportLinkParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetReportLink = { Report, Link };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportLink, methodSetReportLinkParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_reportingService2005InstanceFixture, parametersOfSetReportLink);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetReportLink.ShouldNotBeNull();
            parametersOfSetReportLink.Length.ShouldBe(2);
            methodSetReportLinkParametersTypes.Length.ShouldBe(2);
            methodSetReportLinkParametersTypes.Length.ShouldBe(parametersOfSetReportLink.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetReportLink) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var Report = this.CreateType<string>();
            var Link = this.CreateType<string>();
            var methodSetReportLinkParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfSetReportLink = { Report, Link };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetReportLink, parametersOfSetReportLink, methodSetReportLinkParametersTypes);

            // Assert
            parametersOfSetReportLink.ShouldNotBeNull();
            parametersOfSetReportLink.Length.ShouldBe(2);
            methodSetReportLinkParametersTypes.Length.ShouldBe(2);
            methodSetReportLinkParametersTypes.Length.ShouldBe(parametersOfSetReportLink.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportLink) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportLink, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetReportLink) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var methodSetReportLinkParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetReportLink, methodSetReportLinkParametersTypes);

            // Assert
            methodSetReportLinkParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetReportLink) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_SetReportLink_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetReportLink);
            var currentMethodInfo = this.GetMethodInfo(MethodSetReportLink, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (OnSetReportLinkOperationCompleted) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportLinkOperationCompleted_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportLinkOperationCompleted);
            var arg = this.CreateType<object>();
            var methodOnSetReportLinkOperationCompletedParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfOnSetReportLinkOperationCompleted = { arg };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodOnSetReportLinkOperationCompleted, parametersOfOnSetReportLinkOperationCompleted, methodOnSetReportLinkOperationCompletedParametersTypes);

            // Assert
            parametersOfOnSetReportLinkOperationCompleted.ShouldNotBeNull();
            parametersOfOnSetReportLinkOperationCompleted.Length.ShouldBe(1);
            methodOnSetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(1);
            methodOnSetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(parametersOfOnSetReportLinkOperationCompleted.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportLinkOperationCompleted) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportLinkOperationCompleted_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportLinkOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportLinkOperationCompleted, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (OnSetReportLinkOperationCompleted) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportLinkOperationCompleted_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportLinkOperationCompleted);
            var methodOnSetReportLinkOperationCompletedParametersTypes = new Type[] { typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodOnSetReportLinkOperationCompleted, methodOnSetReportLinkOperationCompletedParametersTypes);

            // Assert
            methodOnSetReportLinkOperationCompletedParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (OnSetReportLinkOperationCompleted) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_OnSetReportLinkOperationCompleted_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodOnSetReportLinkOperationCompleted);
            var currentMethodInfo = this.GetMethodInfo(MethodOnSetReportLinkOperationCompleted, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetRenderResource) (Return Type : byte[]) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var Format = this.CreateType<string>();
            var DeviceInfo = this.CreateType<string>();

            // Act
            Action executeAction = () => _reportingService2005Instance.GetRenderResource(Format, DeviceInfo, out _);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var Format = this.CreateType<string>();
            var DeviceInfo = this.CreateType<string>();
            var returnedValue = default(byte[]);

            // Act
            Action executeAction = () => returnedValue = _reportingService2005Instance.GetRenderResource(Format, DeviceInfo, out _);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var Format = this.CreateType<string>();
            var DeviceInfo = this.CreateType<string>();
            var MimeType = this.CreateType<string>();
            var methodGetRenderResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetRenderResource = { Format, DeviceInfo, MimeType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRenderResource, methodGetRenderResourceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<byte[]>(_reportingService2005InstanceFixture, parametersOfGetRenderResource);
            var result2 = this.GetResultOfMethod<byte[]>(MethodGetRenderResource, parametersOfGetRenderResource, methodGetRenderResourceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRenderResource.ShouldNotBeNull();
            parametersOfGetRenderResource.Length.ShouldBe(3);
            methodGetRenderResourceParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var Format = this.CreateType<string>();
            var DeviceInfo = this.CreateType<string>();
            var MimeType = this.CreateType<string>();
            var methodGetRenderResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };
            object[] parametersOfGetRenderResource = { Format, DeviceInfo, MimeType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<byte[]>(MethodGetRenderResource, parametersOfGetRenderResource, methodGetRenderResourceParametersTypes);

            // Assert
            parametersOfGetRenderResource.ShouldNotBeNull();
            parametersOfGetRenderResource.Length.ShouldBe(3);
            methodGetRenderResourceParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRenderResource) (Return Type : byte[]) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [NUnit.Framework.Category("AUT MethodCallTest")]
        public void AUT_ReportingService2005_GetRenderResource_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRenderResource);
            var methodGetRenderResourceParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRenderResource, methodGetRenderResourceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRenderResourceParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #endregion

        #endregion
    }
}