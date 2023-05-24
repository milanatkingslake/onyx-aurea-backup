using System;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part10.AUT.Tests.ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data.OdbcBase" />)
    ///     and namespace <see cref="ConsonaCRM.BusinessRuleManager.Grammar.Expressions.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OdbcBaseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OdbcBase" />)
        /// </summary>
        public OdbcBaseTest() : base(typeof(OdbcBase))
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

        #region General Initializer : Class (OdbcBase) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _odbcBaseInstanceType;
        private OdbcBase _odbcBaseInstance;
        private OdbcBase _odbcBaseInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OdbcBase" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _odbcBaseInstanceType = typeof(OdbcBase);
            _odbcBaseInstanceFixture = this.Create<OdbcBase>(false);
            _odbcBaseInstance = _odbcBaseInstanceFixture ?? this.Create<OdbcBase>(true);
            CurrentInstance = _odbcBaseInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OdbcBase) Initializer

        #region Methods

        private const string MethodGetCacheKey = "GetCacheKey";
        private const string MethodGetCachedConnection = "GetCachedConnection";
        private const string MethodGetCachedCommand = "GetCachedCommand";
        private const string MethodGetCachedDataset = "GetCachedDataset";
        private const string MethodGetCachedRow = "GetCachedRow";
        private const string MethodGetTypedValue = "GetTypedValue";

        #endregion

        #endregion

        #region General Initializer : Class (OdbcBase) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OdbcBase" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OdbcBase_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OdbcBase)

        #region General Initializer : Class (OdbcBase) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OdbcBase" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCacheKey, 0)]
        [TestCase(MethodGetCachedConnection, 0)]
        [TestCase(MethodGetCachedCommand, 0)]
        [TestCase(MethodGetCachedDataset, 0)]
        [TestCase(MethodGetCachedRow, 0)]
        [TestCase(MethodGetTypedValue, 0)]
        public void AUT_OdbcBase_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OdbcBase) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OdbcBase" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OdbcBase_Is_Instance_Present_Test()
        {
            // Assert
            _odbcBaseInstanceType.ShouldNotBeNull();
            _odbcBaseInstance.ShouldNotBeNull();
            _odbcBaseInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OdbcBase) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OdbcBase" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OdbcBase_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _odbcBaseInstance.ShouldBeAssignableTo<OdbcBase>();
            _odbcBaseInstanceFixture.ShouldBeAssignableTo<OdbcBase>();
            CurrentInstance.ShouldBeAssignableTo<OdbcBase>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OdbcBase) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OdbcBase_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OdbcBase instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCacheKey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var psSubPrefix = this.CreateType<string>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCacheKey = { psSubPrefix };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, methodGetCacheKeyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_odbcBaseInstanceFixture, parametersOfGetCacheKey);
            var result2 = this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var psSubPrefix = this.CreateType<string>();
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCacheKey = { psSubPrefix };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetCacheKey, parametersOfGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            parametersOfGetCacheKey.ShouldNotBeNull();
            parametersOfGetCacheKey.Length.ShouldBe(1);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCacheKeyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var methodGetCacheKeyParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCacheKey, methodGetCacheKeyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCacheKeyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCacheKey) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCacheKey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCacheKey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCacheKey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcBase_GetCachedConnection_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedConnectionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedConnection, methodGetCachedConnectionParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedConnection_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedConnection);
            Type [] methodGetCachedConnectionParametersTypes = null;
            object[] parametersOfGetCachedConnection = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedConnection, methodGetCachedConnectionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<System.Data.Odbc.OdbcConnection>(_odbcBaseInstanceFixture, parametersOfGetCachedConnection);
            var result2 = this.GetResultOfMethod<System.Data.Odbc.OdbcConnection>(MethodGetCachedConnection, parametersOfGetCachedConnection, methodGetCachedConnectionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedConnection.ShouldBeNull();
            methodGetCachedConnectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedConnection_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedConnection);
            Type [] methodGetCachedConnectionParametersTypes = null;
            object[] parametersOfGetCachedConnection = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<System.Data.Odbc.OdbcConnection>(MethodGetCachedConnection, parametersOfGetCachedConnection, methodGetCachedConnectionParametersTypes);

            // Assert
            parametersOfGetCachedConnection.ShouldBeNull();
            methodGetCachedConnectionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedConnection_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedConnection);
            Type [] methodGetCachedConnectionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedConnection, methodGetCachedConnectionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedConnectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedConnection_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedConnection);
            Type [] methodGetCachedConnectionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedConnection, methodGetCachedConnectionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedConnectionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedConnection) (Return Type : System.Data.Odbc.OdbcConnection) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedConnection_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedConnection);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedConnection, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcBase_GetCachedCommand_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedCommandParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedCommand, methodGetCachedCommandParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedCommand_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedCommand);
            Type [] methodGetCachedCommandParametersTypes = null;
            object[] parametersOfGetCachedCommand = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedCommand, methodGetCachedCommandParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<OdbcCommand>(_odbcBaseInstanceFixture, parametersOfGetCachedCommand);
            var result2 = this.GetResultOfMethod<OdbcCommand>(MethodGetCachedCommand, parametersOfGetCachedCommand, methodGetCachedCommandParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedCommand.ShouldBeNull();
            methodGetCachedCommandParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedCommand_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedCommand);
            Type [] methodGetCachedCommandParametersTypes = null;
            object[] parametersOfGetCachedCommand = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<OdbcCommand>(MethodGetCachedCommand, parametersOfGetCachedCommand, methodGetCachedCommandParametersTypes);

            // Assert
            parametersOfGetCachedCommand.ShouldBeNull();
            methodGetCachedCommandParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedCommand_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedCommand);
            Type [] methodGetCachedCommandParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedCommand, methodGetCachedCommandParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedCommandParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedCommand_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedCommand);
            Type [] methodGetCachedCommandParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedCommand, methodGetCachedCommandParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedCommandParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedCommand) (Return Type : OdbcCommand) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedCommand_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedCommand);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedCommand, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcBase_GetCachedDataset_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedDatasetParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedDataset, methodGetCachedDatasetParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedDataset_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedDataset);
            Type [] methodGetCachedDatasetParametersTypes = null;
            object[] parametersOfGetCachedDataset = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedDataset, methodGetCachedDatasetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataSet>(_odbcBaseInstanceFixture, parametersOfGetCachedDataset);
            var result2 = this.GetResultOfMethod<DataSet>(MethodGetCachedDataset, parametersOfGetCachedDataset, methodGetCachedDatasetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedDataset.ShouldBeNull();
            methodGetCachedDatasetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedDataset_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedDataset);
            Type [] methodGetCachedDatasetParametersTypes = null;
            object[] parametersOfGetCachedDataset = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataSet>(MethodGetCachedDataset, parametersOfGetCachedDataset, methodGetCachedDatasetParametersTypes);

            // Assert
            parametersOfGetCachedDataset.ShouldBeNull();
            methodGetCachedDatasetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedDataset_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedDataset);
            Type [] methodGetCachedDatasetParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedDataset, methodGetCachedDatasetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedDatasetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedDataset_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedDataset);
            Type [] methodGetCachedDatasetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedDataset, methodGetCachedDatasetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedDatasetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedDataset) (Return Type : DataSet) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedDataset_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedDataset);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedDataset, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcBase_GetCachedRow_Method_Call_Internally(Type[] types)
        {
            var methodGetCachedRowParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCachedRow, methodGetCachedRowParametersTypes);
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedRow_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedRow);
            Type [] methodGetCachedRowParametersTypes = null;
            object[] parametersOfGetCachedRow = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedRow, methodGetCachedRowParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<DataRow>(_odbcBaseInstanceFixture, parametersOfGetCachedRow);
            var result2 = this.GetResultOfMethod<DataRow>(MethodGetCachedRow, parametersOfGetCachedRow, methodGetCachedRowParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCachedRow.ShouldBeNull();
            methodGetCachedRowParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedRow_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedRow);
            Type [] methodGetCachedRowParametersTypes = null;
            object[] parametersOfGetCachedRow = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<DataRow>(MethodGetCachedRow, parametersOfGetCachedRow, methodGetCachedRowParametersTypes);

            // Assert
            parametersOfGetCachedRow.ShouldBeNull();
            methodGetCachedRowParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedRow_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedRow);
            Type [] methodGetCachedRowParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCachedRow, methodGetCachedRowParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCachedRowParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedRow_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedRow);
            Type [] methodGetCachedRowParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCachedRow, methodGetCachedRowParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCachedRowParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCachedRow) (Return Type : DataRow) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetCachedRow_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCachedRow);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCachedRow, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OdbcBase_GetTypedValue_Method_Call_Internally(Type[] types)
        {
            var methodGetTypedValueParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTypedValue, methodGetTypedValueParametersTypes);
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var pValue = this.CreateType<object>();
            var methodGetTypedValueParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetTypedValue = { pValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypedValue, methodGetTypedValueParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_odbcBaseInstanceFixture, parametersOfGetTypedValue);
            var result2 = this.GetResultOfMethod<string>(MethodGetTypedValue, parametersOfGetTypedValue, methodGetTypedValueParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTypedValue.ShouldNotBeNull();
            parametersOfGetTypedValue.Length.ShouldBe(1);
            methodGetTypedValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var pValue = this.CreateType<object>();
            var methodGetTypedValueParametersTypes = new Type[] { typeof(object) };
            object[] parametersOfGetTypedValue = { pValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetTypedValue, parametersOfGetTypedValue, methodGetTypedValueParametersTypes);

            // Assert
            parametersOfGetTypedValue.ShouldNotBeNull();
            parametersOfGetTypedValue.Length.ShouldBe(1);
            methodGetTypedValueParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var methodGetTypedValueParametersTypes = new Type[] { typeof(object) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTypedValue, methodGetTypedValueParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTypedValueParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var methodGetTypedValueParametersTypes = new Type[] { typeof(object) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTypedValue, methodGetTypedValueParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTypedValueParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypedValue, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTypedValue) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OdbcBase_GetTypedValue_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTypedValue);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTypedValue, 0);
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