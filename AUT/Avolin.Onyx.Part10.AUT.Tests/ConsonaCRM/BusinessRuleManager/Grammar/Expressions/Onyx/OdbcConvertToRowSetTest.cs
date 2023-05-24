using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx.OdbcConvertToRowSet" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Onyx"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OdbcConvertToRowSetTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OdbcConvertToRowSet" />)
        /// </summary>
        public OdbcConvertToRowSetTest() : base(typeof(OdbcConvertToRowSet))
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

        #region General Initializer : Class (OdbcConvertToRowSet) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _odbcConvertToRowSetInstanceType;
        private OdbcConvertToRowSet _odbcConvertToRowSetInstance;
        private OdbcConvertToRowSet _odbcConvertToRowSetInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OdbcConvertToRowSet" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _odbcConvertToRowSetInstanceType = typeof(OdbcConvertToRowSet);
            _odbcConvertToRowSetInstanceFixture = this.Create<OdbcConvertToRowSet>(false);
            _odbcConvertToRowSetInstance = _odbcConvertToRowSetInstanceFixture ?? this.Create<OdbcConvertToRowSet>(true);
            CurrentInstance = _odbcConvertToRowSetInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OdbcConvertToRowSet) Initializer

        #region Methods

        private const string MethodProcess = "Process";
        private const string MethodGetDataTypeName = "GetDataTypeName";

        #endregion

        #endregion

        #region General Initializer : Class (OdbcConvertToRowSet) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OdbcConvertToRowSet" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OdbcConvertToRowSet_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OdbcConvertToRowSet)

        #region General Initializer : Class (OdbcConvertToRowSet) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OdbcConvertToRowSet" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodProcess, 0)]
        [TestCase(MethodGetDataTypeName, 0)]
        public void AUT_OdbcConvertToRowSet_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OdbcConvertToRowSet) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OdbcConvertToRowSet" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OdbcConvertToRowSet_Is_Instance_Present_Test()
        {
            // Assert
            _odbcConvertToRowSetInstanceType.ShouldNotBeNull();
            _odbcConvertToRowSetInstance.ShouldNotBeNull();
            _odbcConvertToRowSetInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OdbcConvertToRowSet) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OdbcConvertToRowSet" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OdbcConvertToRowSet_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _odbcConvertToRowSetInstance.ShouldBeAssignableTo<OdbcConvertToRowSet>();
            _odbcConvertToRowSetInstanceFixture.ShouldBeAssignableTo<OdbcConvertToRowSet>();
            CurrentInstance.ShouldBeAssignableTo<OdbcConvertToRowSet>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OdbcConvertToRowSet) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OdbcConvertToRowSet_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OdbcConvertToRowSet instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Process) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();

            // Act
            Action executeAction = () => _odbcConvertToRowSetInstance.Process(pDataNode);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, methodProcessParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_odbcConvertToRowSetInstanceFixture, parametersOfProcess);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var pDataNode = this.CreateType<XmlNode>();
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };
            object[] parametersOfProcess = { pDataNode };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodProcess, parametersOfProcess, methodProcessParametersTypes);

            // Assert
            parametersOfProcess.ShouldNotBeNull();
            parametersOfProcess.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(1);
            methodProcessParametersTypes.Length.ShouldBe(parametersOfProcess.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var methodProcessParametersTypes = new Type[] { typeof(XmlNode) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodProcess, methodProcessParametersTypes);

            // Assert
            methodProcessParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Process) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_Process_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodProcess);
            var currentMethodInfo = this.GetMethodInfo(MethodProcess, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_Internally(Type[] types)
        {
            var methodGetDataTypeNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDataTypeName, methodGetDataTypeNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var pType = this.CreateType<Type>();
            var methodGetDataTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetDataTypeName = { pType };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataTypeName, methodGetDataTypeNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_odbcConvertToRowSetInstanceFixture, out exception1, parametersOfGetDataTypeName);
            var result2 = this.GetResultOfMethod<string>(MethodGetDataTypeName, parametersOfGetDataTypeName, methodGetDataTypeNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetDataTypeName.ShouldNotBeNull();
            parametersOfGetDataTypeName.Length.ShouldBe(1);
            methodGetDataTypeNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var pType = this.CreateType<Type>();
            var methodGetDataTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetDataTypeName = { pType };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataTypeName, methodGetDataTypeNameParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_odbcConvertToRowSetInstanceFixture, parametersOfGetDataTypeName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetDataTypeName.ShouldNotBeNull();
            parametersOfGetDataTypeName.Length.ShouldBe(1);
            methodGetDataTypeNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var pType = this.CreateType<Type>();
            var methodGetDataTypeNameParametersTypes = new Type[] { typeof(Type) };
            object[] parametersOfGetDataTypeName = { pType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetDataTypeName, parametersOfGetDataTypeName, methodGetDataTypeNameParametersTypes);

            // Assert
            parametersOfGetDataTypeName.ShouldNotBeNull();
            parametersOfGetDataTypeName.Length.ShouldBe(1);
            methodGetDataTypeNameParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var methodGetDataTypeNameParametersTypes = new Type[] { typeof(Type) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDataTypeName, methodGetDataTypeNameParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetDataTypeNameParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var methodGetDataTypeNameParametersTypes = new Type[] { typeof(Type) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDataTypeName, methodGetDataTypeNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDataTypeNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataTypeName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetDataTypeName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcConvertToRowSet_GetDataTypeName_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDataTypeName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDataTypeName, 0);
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