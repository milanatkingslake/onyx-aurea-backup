using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI;
using Shouldly;

namespace Avolin.Onyx.Part03.AUT.Tests.OnyxISAPI
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Utility" />)
    ///     and namespace <see cref="OnyxISAPI"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class UtilityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Utility" />)
        /// </summary>
        public UtilityTest() : base(typeof(Utility))
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

        #region General Initializer : Class (Utility) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _utilityInstanceType;
        private Utility _utilityInstance;
        private Utility _utilityInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Utility" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _utilityInstanceType = typeof(Utility);
            _utilityInstanceFixture = this.Create<Utility>(false);
            _utilityInstance = _utilityInstanceFixture ?? this.Create<Utility>(true);
            CurrentInstance = _utilityInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Utility) Initializer

        #region Methods

        private const string MethodSetLboParamXml = "SetLboParamXml";
        private const string MethodexecuteLbo = "executeLbo";

        #endregion

        #region Fields

        private const string Fieldparameters = "parameters";
        private const string FieldparameterCollection = "parameterCollection";
        private const string FieldLogicalObjectName = "LogicalObjectName";
        private const string FieldLogicalMethodName = "LogicalMethodName";
        private const string FieldparamXml = "paramXml";

        #endregion

        #endregion

        #region General Initializer : Class (Utility) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utility_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Utility) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Utility_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Utility)

        #region General Initializer : Class (Utility) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetLboParamXml, 0)]
        [TestCase(MethodexecuteLbo, 0)]
        public void AUT_Utility_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Utility) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Utility" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Fieldparameters)]
        [TestCase(FieldparameterCollection)]
        [TestCase(FieldLogicalObjectName)]
        [TestCase(FieldLogicalMethodName)]
        [TestCase(FieldparamXml)]
        [Category("AUT Fields")]
        public void AUT_Utility_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Utility) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Utility" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Utility_Is_Instance_Present_Test()
        {
            // Assert
            _utilityInstanceType.ShouldNotBeNull();
            _utilityInstance.ShouldNotBeNull();
            _utilityInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Utility) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Utility" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Utility_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _utilityInstance.ShouldBeAssignableTo<Utility>();
            _utilityInstanceFixture.ShouldBeAssignableTo<Utility>();
            CurrentInstance.ShouldBeAssignableTo<Utility>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Utility) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Utility_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameter = this.CreateType<Hashtable>();
            var ParameterCollection = this.CreateType<Hashtable>();
            Utility instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Utility(parameter, ParameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _utilityInstance.ShouldNotBeNull();
            _utilityInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Utility>();
        }

        #endregion

        #region General Constructor : Class (Utility) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Utility_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameter = this.CreateType<Hashtable>();
            var ParameterCollection = this.CreateType<Hashtable>();
            Utility instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Utility(parameter, ParameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _utilityInstance.ShouldNotBeNull();
            _utilityInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (SetLboParamXml) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var parameterXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _utilityInstance.SetLboParamXml(parameterXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var parameterXml = this.CreateType<string>();
            var methodSetLboParamXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetLboParamXml = { parameterXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetLboParamXml, methodSetLboParamXmlParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_utilityInstanceFixture, parametersOfSetLboParamXml);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetLboParamXml.ShouldNotBeNull();
            parametersOfSetLboParamXml.Length.ShouldBe(1);
            methodSetLboParamXmlParametersTypes.Length.ShouldBe(1);
            methodSetLboParamXmlParametersTypes.Length.ShouldBe(parametersOfSetLboParamXml.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var parameterXml = this.CreateType<string>();
            var methodSetLboParamXmlParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetLboParamXml = { parameterXml };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetLboParamXml, parametersOfSetLboParamXml, methodSetLboParamXmlParametersTypes);

            // Assert
            parametersOfSetLboParamXml.ShouldNotBeNull();
            parametersOfSetLboParamXml.Length.ShouldBe(1);
            methodSetLboParamXmlParametersTypes.Length.ShouldBe(1);
            methodSetLboParamXmlParametersTypes.Length.ShouldBe(parametersOfSetLboParamXml.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLboParamXml, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var methodSetLboParamXmlParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetLboParamXml, methodSetLboParamXmlParametersTypes);

            // Assert
            methodSetLboParamXmlParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLboParamXml) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_SetLboParamXml_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLboParamXml);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLboParamXml, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Utility_executeLbo_Method_Call_Internally(Type[] types)
        {
            var methodexecuteLboParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);

            // Act
            Action executeAction = () => _utilityInstance.executeLbo();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _utilityInstance.executeLbo();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;
            object[] parametersOfexecuteLbo = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodexecuteLbo, methodexecuteLboParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_utilityInstanceFixture, parametersOfexecuteLbo);
            var result2 = this.GetResultOfMethod<string>(MethodexecuteLbo, parametersOfexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfexecuteLbo.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;
            object[] parametersOfexecuteLbo = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodexecuteLbo, parametersOfexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            parametersOfexecuteLbo.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            Type [] methodexecuteLboParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodexecuteLbo, methodexecuteLboParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodexecuteLboParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (executeLbo) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Utility_executeLbo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodexecuteLbo);
            var currentMethodInfo = this.GetMethodInfo(MethodexecuteLbo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}