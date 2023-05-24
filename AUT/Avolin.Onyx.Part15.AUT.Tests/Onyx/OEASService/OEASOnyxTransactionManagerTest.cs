using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OEASService;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OEASService
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OEASService.OEASOnyxTransactionManager" />)
    ///     and namespace <see cref="Onyx.OEASService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OEASOnyxTransactionManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OEASOnyxTransactionManager" />)
        /// </summary>
        public OEASOnyxTransactionManagerTest() : base(typeof(OEASOnyxTransactionManager))
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

        #region General Initializer : Class (OEASOnyxTransactionManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _oEASOnyxTransactionManagerInstanceType;
        private OEASOnyxTransactionManager _oEASOnyxTransactionManagerInstance;
        private OEASOnyxTransactionManager _oEASOnyxTransactionManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OEASOnyxTransactionManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _oEASOnyxTransactionManagerInstanceType = typeof(OEASOnyxTransactionManager);
            _oEASOnyxTransactionManagerInstanceFixture = this.Create<OEASOnyxTransactionManager>(false);
            _oEASOnyxTransactionManagerInstance = _oEASOnyxTransactionManagerInstanceFixture ?? this.Create<OEASOnyxTransactionManager>(true);
            CurrentInstance = _oEASOnyxTransactionManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OEASOnyxTransactionManager) Initializer

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodExecute2 = "Execute2";

        #endregion

        #region Fields

        private const string Field_iLog = "_iLog";
        private const string FieldonyxOEASService = "onyxOEASService";
        private const string FieldonyxContextData = "onyxContextData";

        #endregion

        #endregion

        #region General Initializer : Class (OEASOnyxTransactionManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASOnyxTransactionManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (OEASOnyxTransactionManager) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OEASOnyxTransactionManager_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OEASOnyxTransactionManager)

        #region General Initializer : Class (OEASOnyxTransactionManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodExecute2, 0)]
        public void AUT_OEASOnyxTransactionManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OEASOnyxTransactionManager) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_iLog)]
        [TestCase(FieldonyxOEASService)]
        [TestCase(FieldonyxContextData)]
        [Category("AUT Fields")]
        public void AUT_OEASOnyxTransactionManager_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (OEASOnyxTransactionManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASOnyxTransactionManager_Is_Instance_Present_Test()
        {
            // Assert
            _oEASOnyxTransactionManagerInstanceType.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstance.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OEASOnyxTransactionManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OEASOnyxTransactionManager" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OEASOnyxTransactionManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _oEASOnyxTransactionManagerInstance.ShouldBeAssignableTo<OEASOnyxTransactionManager>();
            _oEASOnyxTransactionManagerInstanceFixture.ShouldBeAssignableTo<OEASOnyxTransactionManager>();
            CurrentInstance.ShouldBeAssignableTo<OEASOnyxTransactionManager>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OEASOnyxTransactionManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEASOnyxTransactionManager_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var pOnyxContextData = this.CreateType<OnyxContextData>();
            OEASOnyxTransactionManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEASOnyxTransactionManager(pOnyxContextData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstance.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<OEASOnyxTransactionManager>();
        }

        #endregion

        #region General Constructor : Class (OEASOnyxTransactionManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OEASOnyxTransactionManager_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var pOnyxContextData = this.CreateType<OnyxContextData>();
            OEASOnyxTransactionManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new OEASOnyxTransactionManager(pOnyxContextData);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstance.ShouldNotBeNull();
            _oEASOnyxTransactionManagerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Execute) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASOnyxTransactionManagerInstance.Execute(applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASOnyxTransactionManagerInstanceFixture, parametersOfExecute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXml = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXml, customDataXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 6;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_Internally(Type[] types)
        {
            var methodExecute2ParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecute2, methodExecute2ParametersTypes);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();

            // Act
            Action executeAction = () => _oEASOnyxTransactionManagerInstance.Execute2(applicationName, logicalObjectName, logicalMethodName, ref stepPackage);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();
            var methodExecute2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute2 = { applicationName, logicalObjectName, logicalMethodName, stepPackage };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute2, methodExecute2ParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_oEASOnyxTransactionManagerInstanceFixture, parametersOfExecute2);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute2.ShouldNotBeNull();
            parametersOfExecute2.Length.ShouldBe(4);
            methodExecute2ParametersTypes.Length.ShouldBe(4);
            methodExecute2ParametersTypes.Length.ShouldBe(parametersOfExecute2.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var stepPackage = this.CreateType<string>();
            var methodExecute2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute2 = { applicationName, logicalObjectName, logicalMethodName, stepPackage };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute2, parametersOfExecute2, methodExecute2ParametersTypes);

            // Assert
            parametersOfExecute2.ShouldNotBeNull();
            parametersOfExecute2.Length.ShouldBe(4);
            methodExecute2ParametersTypes.Length.ShouldBe(4);
            methodExecute2ParametersTypes.Length.ShouldBe(parametersOfExecute2.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute2, 0);
            const int parametersCount = 4;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var methodExecute2ParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute2, methodExecute2ParametersTypes);

            // Assert
            methodExecute2ParametersTypes.Length.ShouldBe(4);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute2) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OEASOnyxTransactionManager_Execute2_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute2);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute2, 0);

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