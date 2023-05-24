using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.OGS.EMFExtension.Base;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.OGS.EMFExtension.Base
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.OGS.EMFExtension.Base.BusinessRule" />)
    ///     and namespace <see cref="Onyx.OGS.EMFExtension.Base"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class BusinessRuleTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="BusinessRule" />)
        /// </summary>
        public BusinessRuleTest() : base(typeof(BusinessRule))
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

        #region General Initializer : Class (BusinessRule) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _businessRuleInstanceType;
        private BusinessRule _businessRuleInstance;
        private BusinessRule _businessRuleInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="BusinessRule" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _businessRuleInstanceType = typeof(BusinessRule);
            _businessRuleInstanceFixture = this.Create<BusinessRule>(false);
            _businessRuleInstance = _businessRuleInstanceFixture ?? this.Create<BusinessRule>(true);
            CurrentInstance = _businessRuleInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (BusinessRule) Initializer

        #region Properties

        private const string PropertyConfig = "Config";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodPrepareInputParameters = "PrepareInputParameters";
        private const string MethodExecuteLBO = "ExecuteLBO";

        #endregion

        #endregion

        #region General Initializer : Class (BusinessRule) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRule_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BusinessRule) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRule_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (BusinessRule) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_BusinessRule_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (BusinessRule)

        #region General Initializer : Class (BusinessRule) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        [TestCase(MethodPrepareInputParameters, 0)]
        [TestCase(MethodExecuteLBO, 0)]
        public void AUT_BusinessRule_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (BusinessRule) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfig)]
        [Category("AUT Property")]
        public void AUT_BusinessRule_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (BusinessRule) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRule_Is_Instance_Present_Test()
        {
            // Assert
            _businessRuleInstanceType.ShouldNotBeNull();
            _businessRuleInstance.ShouldNotBeNull();
            _businessRuleInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (BusinessRule) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_BusinessRule_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _businessRuleInstance.ShouldBeAssignableTo<BusinessRule>();
            _businessRuleInstanceFixture.ShouldBeAssignableTo<BusinessRule>();
            CurrentInstance.ShouldBeAssignableTo<BusinessRule>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (BusinessRule) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRule_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            BusinessRule instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BusinessRule(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _businessRuleInstance.ShouldNotBeNull();
            _businessRuleInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<BusinessRule>();
        }

        #endregion

        #region General Constructor : Class (BusinessRule) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRule_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            BusinessRule instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new BusinessRule(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _businessRuleInstance.ShouldNotBeNull();
            _businessRuleInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #region General Constructor : Class (BusinessRule) instance created

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRule_Is_Created_Test()
        {
            // Assert
            _businessRuleInstance.ShouldNotBeNull();
            _businessRuleInstanceFixture.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (BusinessRule) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="BusinessRule" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(0)]
        [TestCase(1)]
        public void AUT_BusinessRule_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (BusinessRule) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="BusinessRule" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRule_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (BusinessRule) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="BusinessRule" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_BusinessRule_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodBusinessRuleParametersTypes = new Type[] { typeof(XElement) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodBusinessRuleParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (BusinessRule) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfig)]
        public void AUT_BusinessRule_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (BusinessRule) => Property (Config) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_BusinessRule_Config_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);
            Action currentAction = () => propertyInfo.SetValue(_businessRuleInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (BusinessRule) => Property (Config) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_BusinessRule_Public_Class_Config_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfig);
            var propertyInfo = this.GetPropertyInfo(PropertyConfig);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Execute) (Return Type : XElement) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _businessRuleInstance.Execute(parameterCollection, inputXml);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _businessRuleInstance.Execute(parameterCollection, inputXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodExecuteParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecute = { parameterCollection, inputXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_businessRuleInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<XElement>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodExecuteParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecute = { parameterCollection, inputXml };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_businessRuleInstanceFixture, parametersOfExecute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var methodExecuteParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecute = { parameterCollection, inputXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(2);
            methodExecuteParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_BusinessRule_PrepareInputParameters_Method_Call_Internally(Type[] types)
        {
            var methodPrepareInputParametersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPrepareInputParameters, methodPrepareInputParametersParametersTypes);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _businessRuleInstance.PrepareInputParameters(parameterCollection, inputXml, actionElement);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement), typeof(XElement) };
            object[] parametersOfPrepareInputParameters = { parameterCollection, inputXml, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, methodPrepareInputParametersParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_businessRuleInstanceFixture, parametersOfPrepareInputParameters);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPrepareInputParameters.ShouldNotBeNull();
            parametersOfPrepareInputParameters.Length.ShouldBe(3);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(3);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(parametersOfPrepareInputParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var parameterCollection = this.CreateType<Hashtable>();
            var inputXml = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement), typeof(XElement) };
            object[] parametersOfPrepareInputParameters = { parameterCollection, inputXml, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPrepareInputParameters, parametersOfPrepareInputParameters, methodPrepareInputParametersParametersTypes);

            // Assert
            parametersOfPrepareInputParameters.ShouldNotBeNull();
            parametersOfPrepareInputParameters.Length.ShouldBe(3);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(3);
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(parametersOfPrepareInputParameters.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var methodPrepareInputParametersParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPrepareInputParameters, methodPrepareInputParametersParametersTypes);

            // Assert
            methodPrepareInputParametersParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PrepareInputParameters) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_PrepareInputParameters_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPrepareInputParameters);
            var currentMethodInfo = this.GetMethodInfo(MethodPrepareInputParameters, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_BusinessRule_ExecuteLBO_Method_Call_Internally(Type[] types)
        {
            var methodExecuteLBOParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _businessRuleInstance.ExecuteLBO(parameterCollection, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _businessRuleInstance.ExecuteLBO(parameterCollection, actionElement);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecuteLBO = { parameterCollection, actionElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, methodExecuteLBOParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_businessRuleInstanceFixture, parametersOfExecuteLBO);
            var result2 = this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(2);
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var parameterCollection = this.CreateType<Hashtable>();
            var actionElement = this.CreateType<XElement>();
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            object[] parametersOfExecuteLBO = { parameterCollection, actionElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodExecuteLBO, parametersOfExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            parametersOfExecuteLBO.ShouldNotBeNull();
            parametersOfExecuteLBO.Length.ShouldBe(2);
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteLBOParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var methodExecuteLBOParametersTypes = new Type[] { typeof(Hashtable), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteLBO, methodExecuteLBOParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteLBOParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteLBO) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_BusinessRule_ExecuteLBO_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteLBO);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteLBO, 0);
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