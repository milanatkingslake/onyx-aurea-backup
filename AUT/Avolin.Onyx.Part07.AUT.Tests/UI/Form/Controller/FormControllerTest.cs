using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using Onyx.UI.Form.Controller;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Form.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Form.Controller.FormController" />)
    ///     and namespace <see cref="Onyx.UI.Form.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class FormControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="FormController" />)
        /// </summary>
        public FormControllerTest() : base(typeof(FormController))
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

        #region General Initializer : Class (FormController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _formControllerInstanceType;
        private FormController _formControllerInstance;
        private FormController _formControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="FormController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _formControllerInstanceType = typeof(FormController);
            _formControllerInstanceFixture = this.Create<FormController>(false);
            _formControllerInstance = _formControllerInstanceFixture ?? this.Create<FormController>(true);
            CurrentInstance = _formControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (FormController) Initializer

        #region Methods

        private const string MethodGetFormMetaData = "GetFormMetaData";
        private const string MethodGetFormData = "GetFormData";
        private const string MethodSaveFormData = "SaveFormData";
        private const string MethodGetListMetaData = "GetListMetaData";
        private const string MethodGetListFormData = "GetListFormData";

        #endregion

        #endregion

        #region General Initializer : Class (FormController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="FormController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_FormController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (FormController)

        #region General Initializer : Class (FormController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="FormController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetFormMetaData, 0)]
        [TestCase(MethodGetFormData, 0)]
        [TestCase(MethodSaveFormData, 0)]
        [TestCase(MethodGetListMetaData, 0)]
        [TestCase(MethodGetListFormData, 0)]
        public void AUT_FormController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (FormController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="FormController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FormController_Is_Instance_Present_Test()
        {
            // Assert
            _formControllerInstanceType.ShouldNotBeNull();
            _formControllerInstance.ShouldNotBeNull();
            _formControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (FormController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="FormController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_FormController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _formControllerInstance.ShouldBeAssignableTo<FormController>();
            _formControllerInstanceFixture.ShouldBeAssignableTo<FormController>();
            CurrentInstance.ShouldBeAssignableTo<FormController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (FormController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_FormController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            FormController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);

            // Act
            Action executeAction = () => _formControllerInstance.GetFormMetaData();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _formControllerInstance.GetFormMetaData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            Type [] methodGetFormMetaDataParametersTypes = null;
            object[] parametersOfGetFormMetaData = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormMetaData, methodGetFormMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_formControllerInstanceFixture, out exception1, parametersOfGetFormMetaData);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetFormMetaData, parametersOfGetFormMetaData, methodGetFormMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFormMetaData.ShouldBeNull();
            methodGetFormMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            Type [] methodGetFormMetaDataParametersTypes = null;
            object[] parametersOfGetFormMetaData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormMetaData, methodGetFormMetaDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formControllerInstanceFixture, parametersOfGetFormMetaData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFormMetaData.ShouldBeNull();
            methodGetFormMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            Type [] methodGetFormMetaDataParametersTypes = null;
            object[] parametersOfGetFormMetaData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetFormMetaData, parametersOfGetFormMetaData, methodGetFormMetaDataParametersTypes);

            // Assert
            parametersOfGetFormMetaData.ShouldBeNull();
            methodGetFormMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            Type [] methodGetFormMetaDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFormMetaData, methodGetFormMetaDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFormMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            Type [] methodGetFormMetaDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFormMetaData, methodGetFormMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFormMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetFormMetaData) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormMetaData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormController_GetFormData_Method_Call_Internally(Type[] types)
        {
            var methodGetFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetFormData, methodGetFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var postData = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _formControllerInstance.GetFormData(postData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var postData = this.CreateType<JToken>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _formControllerInstance.GetFormData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var postData = this.CreateType<JToken>();
            var methodGetFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetFormData = { postData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormData, methodGetFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_formControllerInstanceFixture, out exception1, parametersOfGetFormData);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetFormData, parametersOfGetFormData, methodGetFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFormData.ShouldNotBeNull();
            parametersOfGetFormData.Length.ShouldBe(1);
            methodGetFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var postData = this.CreateType<JToken>();
            var methodGetFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetFormData = { postData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormData, methodGetFormDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formControllerInstanceFixture, parametersOfGetFormData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFormData.ShouldNotBeNull();
            parametersOfGetFormData.Length.ShouldBe(1);
            methodGetFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var postData = this.CreateType<JToken>();
            var methodGetFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetFormData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetFormData, parametersOfGetFormData, methodGetFormDataParametersTypes);

            // Assert
            parametersOfGetFormData.ShouldNotBeNull();
            parametersOfGetFormData.Length.ShouldBe(1);
            methodGetFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var methodGetFormDataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFormData, methodGetFormDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var methodGetFormDataParametersTypes = new Type[] { typeof(JToken) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFormData, methodGetFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFormData) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFormData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormController_SaveFormData_Method_Call_Internally(Type[] types)
        {
            var methodSaveFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveFormData, methodSaveFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var postData = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _formControllerInstance.SaveFormData(postData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var postData = this.CreateType<JToken>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _formControllerInstance.SaveFormData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var postData = this.CreateType<JToken>();
            var methodSaveFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfSaveFormData = { postData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveFormData, methodSaveFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_formControllerInstanceFixture, out exception1, parametersOfSaveFormData);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSaveFormData, parametersOfSaveFormData, methodSaveFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfSaveFormData.ShouldNotBeNull();
            parametersOfSaveFormData.Length.ShouldBe(1);
            methodSaveFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var postData = this.CreateType<JToken>();
            var methodSaveFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfSaveFormData = { postData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveFormData, methodSaveFormDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formControllerInstanceFixture, parametersOfSaveFormData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSaveFormData.ShouldNotBeNull();
            parametersOfSaveFormData.Length.ShouldBe(1);
            methodSaveFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var postData = this.CreateType<JToken>();
            var methodSaveFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfSaveFormData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSaveFormData, parametersOfSaveFormData, methodSaveFormDataParametersTypes);

            // Assert
            parametersOfSaveFormData.ShouldNotBeNull();
            parametersOfSaveFormData.Length.ShouldBe(1);
            methodSaveFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var methodSaveFormDataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveFormData, methodSaveFormDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodSaveFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var methodSaveFormDataParametersTypes = new Type[] { typeof(JToken) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveFormData, methodSaveFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (SaveFormData) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_SaveFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveFormData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormController_GetListMetaData_Method_Call_Internally(Type[] types)
        {
            var methodGetListMetaDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetListMetaData, methodGetListMetaDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);

            // Act
            Action executeAction = () => _formControllerInstance.GetListMetaData();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _formControllerInstance.GetListMetaData();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            Type [] methodGetListMetaDataParametersTypes = null;
            object[] parametersOfGetListMetaData = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListMetaData, methodGetListMetaDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_formControllerInstanceFixture, out exception1, parametersOfGetListMetaData);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetListMetaData, parametersOfGetListMetaData, methodGetListMetaDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetListMetaData.ShouldBeNull();
            methodGetListMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            Type [] methodGetListMetaDataParametersTypes = null;
            object[] parametersOfGetListMetaData = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListMetaData, methodGetListMetaDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formControllerInstanceFixture, parametersOfGetListMetaData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetListMetaData.ShouldBeNull();
            methodGetListMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            Type [] methodGetListMetaDataParametersTypes = null;
            object[] parametersOfGetListMetaData = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetListMetaData, parametersOfGetListMetaData, methodGetListMetaDataParametersTypes);

            // Assert
            parametersOfGetListMetaData.ShouldBeNull();
            methodGetListMetaDataParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            Type [] methodGetListMetaDataParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListMetaData, methodGetListMetaDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetListMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            Type [] methodGetListMetaDataParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListMetaData, methodGetListMetaDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListMetaDataParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListMetaData) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListMetaData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListMetaData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListMetaData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_FormController_GetListFormData_Method_Call_Internally(Type[] types)
        {
            var methodGetListFormDataParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var postData = this.CreateType<JToken>();

            // Act
            Action executeAction = () => _formControllerInstance.GetListFormData(postData);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var postData = this.CreateType<JToken>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _formControllerInstance.GetListFormData(postData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var postData = this.CreateType<JToken>();
            var methodGetListFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetListFormData = { postData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, methodGetListFormDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_formControllerInstanceFixture, out exception1, parametersOfGetListFormData);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetListFormData, parametersOfGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetListFormData.ShouldNotBeNull();
            parametersOfGetListFormData.Length.ShouldBe(1);
            methodGetListFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var postData = this.CreateType<JToken>();
            var methodGetListFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetListFormData = { postData };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, methodGetListFormDataParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_formControllerInstanceFixture, parametersOfGetListFormData);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetListFormData.ShouldNotBeNull();
            parametersOfGetListFormData.Length.ShouldBe(1);
            methodGetListFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var postData = this.CreateType<JToken>();
            var methodGetListFormDataParametersTypes = new Type[] { typeof(JToken) };
            object[] parametersOfGetListFormData = { postData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetListFormData, parametersOfGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            parametersOfGetListFormData.ShouldNotBeNull();
            parametersOfGetListFormData.Length.ShouldBe(1);
            methodGetListFormDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var methodGetListFormDataParametersTypes = new Type[] { typeof(JToken) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetListFormDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var methodGetListFormDataParametersTypes = new Type[] { typeof(JToken) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListFormData, methodGetListFormDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListFormDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetListFormData) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_FormController_GetListFormData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListFormData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListFormData, 0);
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