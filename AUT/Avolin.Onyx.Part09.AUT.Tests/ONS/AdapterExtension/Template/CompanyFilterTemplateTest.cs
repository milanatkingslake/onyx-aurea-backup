using System;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.ONS.AdapterExtension.Template;
using Shouldly;

namespace Avolin.Onyx.Part09.AUT.Tests.ONS.AdapterExtension.Template
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.ONS.AdapterExtension.Template.CompanyFilterTemplate" />)
    ///     and namespace <see cref="Onyx.ONS.AdapterExtension.Template"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CompanyFilterTemplateTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CompanyFilterTemplate" />)
        /// </summary>
        public CompanyFilterTemplateTest() : base(typeof(CompanyFilterTemplate))
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

        #region General Initializer : Class (CompanyFilterTemplate) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _companyFilterTemplateInstanceType;
        private CompanyFilterTemplate _companyFilterTemplateInstance;
        private CompanyFilterTemplate _companyFilterTemplateInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CompanyFilterTemplate" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _companyFilterTemplateInstanceType = typeof(CompanyFilterTemplate);
            _companyFilterTemplateInstanceFixture = this.Create<CompanyFilterTemplate>(false);
            _companyFilterTemplateInstance = _companyFilterTemplateInstanceFixture ?? this.Create<CompanyFilterTemplate>(true);
            CurrentInstance = _companyFilterTemplateInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CompanyFilterTemplate) Initializer

        #region Methods

        private const string MethodValidateEventData = "ValidateEventData";
        private const string MethodRemoveText = "RemoveText";
        private const string MethodDeleteChildObject = "DeleteChildObject";
        private const string MethodDiscardInvalidEvent = "DiscardInvalidEvent";
        private const string MethodPreprocessCustomImplementation = "PreprocessCustomImplementation";
        private const string MethodFilterEventDataCustomImplementation = "FilterEventDataCustomImplementation";

        #endregion

        #region Fields

        private const string Field_sSource = "_sSource";
        private const string Field_sLog = "_sLog";
        private const string Field_sEvent = "_sEvent";

        #endregion

        #endregion

        #region General Initializer : Class (CompanyFilterTemplate) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CompanyFilterTemplate_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CompanyFilterTemplate) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CompanyFilterTemplate_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CompanyFilterTemplate)

        #region General Initializer : Class (CompanyFilterTemplate) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodValidateEventData, 0)]
        [TestCase(MethodRemoveText, 0)]
        [TestCase(MethodDeleteChildObject, 0)]
        [TestCase(MethodDiscardInvalidEvent, 0)]
        [TestCase(MethodPreprocessCustomImplementation, 0)]
        [TestCase(MethodFilterEventDataCustomImplementation, 0)]
        public void AUT_CompanyFilterTemplate_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (CompanyFilterTemplate) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Field_sSource)]
        [TestCase(Field_sLog)]
        [TestCase(Field_sEvent)]
        [Category("AUT Fields")]
        public void AUT_CompanyFilterTemplate_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CompanyFilterTemplate) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompanyFilterTemplate_Is_Instance_Present_Test()
        {
            // Assert
            _companyFilterTemplateInstanceType.ShouldNotBeNull();
            _companyFilterTemplateInstance.ShouldNotBeNull();
            _companyFilterTemplateInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CompanyFilterTemplate) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CompanyFilterTemplate" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CompanyFilterTemplate_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _companyFilterTemplateInstance.ShouldBeAssignableTo<CompanyFilterTemplate>();
            _companyFilterTemplateInstanceFixture.ShouldBeAssignableTo<CompanyFilterTemplate>();
            CurrentInstance.ShouldBeAssignableTo<CompanyFilterTemplate>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CompanyFilterTemplate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompanyFilterTemplate_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            CompanyFilterTemplate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompanyFilterTemplate(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _companyFilterTemplateInstance.ShouldNotBeNull();
            _companyFilterTemplateInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<CompanyFilterTemplate>();
        }

        #endregion

        #region General Constructor : Class (CompanyFilterTemplate) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CompanyFilterTemplate_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var config = this.CreateType<XElement>();
            CompanyFilterTemplate instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new CompanyFilterTemplate(config);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _companyFilterTemplateInstance.ShouldNotBeNull();
            _companyFilterTemplateInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ValidateEventData) (Return Type : bool) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.ValidateEventData(eventData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, methodValidateEventDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, parametersOfValidateEventData);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, methodValidateEventDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, out exception1, parametersOfValidateEventData);
            var result2 = this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, methodValidateEventDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_companyFilterTemplateInstanceFixture, parametersOfValidateEventData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var eventData = this.CreateType<XElement>();
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfValidateEventData = { eventData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodValidateEventData, parametersOfValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            parametersOfValidateEventData.ShouldNotBeNull();
            parametersOfValidateEventData.Length.ShouldBe(1);
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodValidateEventDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var methodValidateEventDataParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidateEventData, methodValidateEventDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodValidateEventDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ValidateEventData) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_ValidateEventData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidateEventData);
            var currentMethodInfo = this.GetMethodInfo(MethodValidateEventData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompanyFilterTemplate_RemoveText_Method_Call_Internally(Type[] types)
        {
            var methodRemoveTextParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRemoveText, methodRemoveTextParametersTypes);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.RemoveText(eventData, actionElement);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodRemoveTextParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfRemoveText = { eventData, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveText, methodRemoveTextParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_companyFilterTemplateInstanceFixture, parametersOfRemoveText);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfRemoveText.ShouldNotBeNull();
            parametersOfRemoveText.Length.ShouldBe(2);
            methodRemoveTextParametersTypes.Length.ShouldBe(2);
            methodRemoveTextParametersTypes.Length.ShouldBe(parametersOfRemoveText.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodRemoveTextParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfRemoveText = { eventData, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodRemoveText, parametersOfRemoveText, methodRemoveTextParametersTypes);

            // Assert
            parametersOfRemoveText.ShouldNotBeNull();
            parametersOfRemoveText.Length.ShouldBe(2);
            methodRemoveTextParametersTypes.Length.ShouldBe(2);
            methodRemoveTextParametersTypes.Length.ShouldBe(parametersOfRemoveText.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveText, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var methodRemoveTextParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRemoveText, methodRemoveTextParametersTypes);

            // Assert
            methodRemoveTextParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RemoveText) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_RemoveText_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRemoveText);
            var currentMethodInfo = this.GetMethodInfo(MethodRemoveText, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_Internally(Type[] types)
        {
            var methodDeleteChildObjectParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteChildObject, methodDeleteChildObjectParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.DeleteChildObject(eventData, actionElement);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDeleteChildObjectParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDeleteChildObject = { eventData, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteChildObject, methodDeleteChildObjectParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_companyFilterTemplateInstanceFixture, parametersOfDeleteChildObject);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteChildObject.ShouldNotBeNull();
            parametersOfDeleteChildObject.Length.ShouldBe(2);
            methodDeleteChildObjectParametersTypes.Length.ShouldBe(2);
            methodDeleteChildObjectParametersTypes.Length.ShouldBe(parametersOfDeleteChildObject.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDeleteChildObjectParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDeleteChildObject = { eventData, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodDeleteChildObject, parametersOfDeleteChildObject, methodDeleteChildObjectParametersTypes);

            // Assert
            parametersOfDeleteChildObject.ShouldNotBeNull();
            parametersOfDeleteChildObject.Length.ShouldBe(2);
            methodDeleteChildObjectParametersTypes.Length.ShouldBe(2);
            methodDeleteChildObjectParametersTypes.Length.ShouldBe(parametersOfDeleteChildObject.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteChildObject, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var methodDeleteChildObjectParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteChildObject, methodDeleteChildObjectParametersTypes);

            // Assert
            methodDeleteChildObjectParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteChildObject) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DeleteChildObject_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteChildObject);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteChildObject, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_Internally(Type[] types)
        {
            var methodDiscardInvalidEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.DiscardInvalidEvent(eventData, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, parametersOfDiscardInvalidEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, out exception1, parametersOfDiscardInvalidEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfDiscardInvalidEvent = { eventData, actionElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodDiscardInvalidEvent, parametersOfDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            parametersOfDiscardInvalidEvent.ShouldNotBeNull();
            parametersOfDiscardInvalidEvent.Length.ShouldBe(2);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var methodDiscardInvalidEventParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDiscardInvalidEvent, methodDiscardInvalidEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDiscardInvalidEventParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DiscardInvalidEvent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_DiscardInvalidEvent_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDiscardInvalidEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodDiscardInvalidEvent, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_Internally(Type[] types)
        {
            var methodPreprocessCustomImplementationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPreprocessCustomImplementation, methodPreprocessCustomImplementationParametersTypes);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.PreprocessCustomImplementation(eventData, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodPreprocessCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfPreprocessCustomImplementation = { eventData, actionElement };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodPreprocessCustomImplementation, methodPreprocessCustomImplementationParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_companyFilterTemplateInstanceFixture, parametersOfPreprocessCustomImplementation);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfPreprocessCustomImplementation.ShouldNotBeNull();
            parametersOfPreprocessCustomImplementation.Length.ShouldBe(2);
            methodPreprocessCustomImplementationParametersTypes.Length.ShouldBe(2);
            methodPreprocessCustomImplementationParametersTypes.Length.ShouldBe(parametersOfPreprocessCustomImplementation.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodPreprocessCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfPreprocessCustomImplementation = { eventData, actionElement };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodPreprocessCustomImplementation, parametersOfPreprocessCustomImplementation, methodPreprocessCustomImplementationParametersTypes);

            // Assert
            parametersOfPreprocessCustomImplementation.ShouldNotBeNull();
            parametersOfPreprocessCustomImplementation.Length.ShouldBe(2);
            methodPreprocessCustomImplementationParametersTypes.Length.ShouldBe(2);
            methodPreprocessCustomImplementationParametersTypes.Length.ShouldBe(parametersOfPreprocessCustomImplementation.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var currentMethodInfo = this.GetMethodInfo(MethodPreprocessCustomImplementation, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var methodPreprocessCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPreprocessCustomImplementation, methodPreprocessCustomImplementationParametersTypes);

            // Assert
            methodPreprocessCustomImplementationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PreprocessCustomImplementation) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_PreprocessCustomImplementation_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPreprocessCustomImplementation);
            var currentMethodInfo = this.GetMethodInfo(MethodPreprocessCustomImplementation, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_Internally(Type[] types)
        {
            var methodFilterEventDataCustomImplementationParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _companyFilterTemplateInstance.FilterEventDataCustomImplementation(eventData, actionElement);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFilterEventDataCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfFilterEventDataCustomImplementation = { eventData, actionElement };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, parametersOfFilterEventDataCustomImplementation);
            var result2 = this.GetResultOfMethod<bool>(MethodFilterEventDataCustomImplementation, parametersOfFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFilterEventDataCustomImplementation.ShouldNotBeNull();
            parametersOfFilterEventDataCustomImplementation.Length.ShouldBe(2);
            methodFilterEventDataCustomImplementationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFilterEventDataCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfFilterEventDataCustomImplementation = { eventData, actionElement };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_companyFilterTemplateInstanceFixture, out exception1, parametersOfFilterEventDataCustomImplementation);
            var result2 = this.GetResultOfMethod<bool>(MethodFilterEventDataCustomImplementation, parametersOfFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfFilterEventDataCustomImplementation.ShouldNotBeNull();
            parametersOfFilterEventDataCustomImplementation.Length.ShouldBe(2);
            methodFilterEventDataCustomImplementationParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var eventData = this.CreateType<XElement>();
            var actionElement = this.CreateType<XElement>();
            var methodFilterEventDataCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            object[] parametersOfFilterEventDataCustomImplementation = { eventData, actionElement };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodFilterEventDataCustomImplementation, parametersOfFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes);

            // Assert
            parametersOfFilterEventDataCustomImplementation.ShouldNotBeNull();
            parametersOfFilterEventDataCustomImplementation.Length.ShouldBe(2);
            methodFilterEventDataCustomImplementationParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var methodFilterEventDataCustomImplementationParametersTypes = new Type[] { typeof(XElement), typeof(XElement) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodFilterEventDataCustomImplementation, methodFilterEventDataCustomImplementationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodFilterEventDataCustomImplementationParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var currentMethodInfo = this.GetMethodInfo(MethodFilterEventDataCustomImplementation, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (FilterEventDataCustomImplementation) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CompanyFilterTemplate_FilterEventDataCustomImplementation_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodFilterEventDataCustomImplementation);
            var currentMethodInfo = this.GetMethodInfo(MethodFilterEventDataCustomImplementation, 0);
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