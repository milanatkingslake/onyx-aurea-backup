using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Scripting.Controller;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.CustomerController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class CustomerControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CustomerController" />)
        /// </summary>
        public CustomerControllerTest() : base(typeof(CustomerController))
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

        #region General Initializer : Class (CustomerController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _customerControllerInstanceType;
        private CustomerController _customerControllerInstance;
        private CustomerController _customerControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CustomerController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _customerControllerInstanceType = typeof(CustomerController);
            _customerControllerInstanceFixture = this.Create<CustomerController>(false);
            _customerControllerInstance = _customerControllerInstanceFixture ?? this.Create<CustomerController>(true);
            CurrentInstance = _customerControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CustomerController) Initializer

        #region Methods

        private const string MethodGetCustomerInfo = "GetCustomerInfo";
        private const string MethodGetCustomerSearch = "GetCustomerSearch";

        #endregion

        #endregion

        #region General Initializer : Class (CustomerController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CustomerController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="CustomerController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (CustomerController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CustomerController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CustomerController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CustomerController)

        #region General Initializer : Class (CustomerController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CustomerController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCustomerInfo, 0)]
        [TestCase(MethodGetCustomerSearch, 0)]
        public void AUT_CustomerController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CustomerController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CustomerController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerController_Is_Instance_Present_Test()
        {
            // Assert
            _customerControllerInstanceType.ShouldNotBeNull();
            _customerControllerInstance.ShouldNotBeNull();
            _customerControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CustomerController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CustomerController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CustomerController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _customerControllerInstance.ShouldBeAssignableTo<CustomerController>();
            _customerControllerInstanceFixture.ShouldBeAssignableTo<CustomerController>();
            CurrentInstance.ShouldBeAssignableTo<CustomerController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CustomerController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CustomerController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CustomerController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var primaryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _customerControllerInstance.GetCustomerInfo(primaryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var primaryId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _customerControllerInstance.GetCustomerInfo(primaryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var primaryId = this.CreateType<string>();
            var methodGetCustomerInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCustomerInfo = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerInfo, methodGetCustomerInfoParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_customerControllerInstanceFixture, parametersOfGetCustomerInfo);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCustomerInfo, parametersOfGetCustomerInfo, methodGetCustomerInfoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCustomerInfo.ShouldNotBeNull();
            parametersOfGetCustomerInfo.Length.ShouldBe(1);
            methodGetCustomerInfoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var primaryId = this.CreateType<string>();
            var methodGetCustomerInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetCustomerInfo = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCustomerInfo, parametersOfGetCustomerInfo, methodGetCustomerInfoParametersTypes);

            // Assert
            parametersOfGetCustomerInfo.ShouldNotBeNull();
            parametersOfGetCustomerInfo.Length.ShouldBe(1);
            methodGetCustomerInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var methodGetCustomerInfoParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomerInfo, methodGetCustomerInfoParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCustomerInfoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var methodGetCustomerInfoParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomerInfo, methodGetCustomerInfoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomerInfoParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerInfo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerInfo) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerInfo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerInfo, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_CustomerController_GetCustomerSearch_Method_Call_Internally(Type[] types)
        {
            var methodGetCustomerSearchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearch, methodGetCustomerSearchParametersTypes);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var searchData = this.CreateType<Dictionary<string, string>>();

            // Act
            Action executeAction = () => _customerControllerInstance.GetCustomerSearch(searchData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var searchData = this.CreateType<Dictionary<string, string>>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _customerControllerInstance.GetCustomerSearch(searchData);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var searchData = this.CreateType<Dictionary<string, string>>();
            var methodGetCustomerSearchParametersTypes = new Type[] { typeof(Dictionary<string, string>) };
            object[] parametersOfGetCustomerSearch = { searchData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearch, methodGetCustomerSearchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_customerControllerInstanceFixture, parametersOfGetCustomerSearch);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCustomerSearch, parametersOfGetCustomerSearch, methodGetCustomerSearchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCustomerSearch.ShouldNotBeNull();
            parametersOfGetCustomerSearch.Length.ShouldBe(1);
            methodGetCustomerSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var searchData = this.CreateType<Dictionary<string, string>>();
            var methodGetCustomerSearchParametersTypes = new Type[] { typeof(Dictionary<string, string>) };
            object[] parametersOfGetCustomerSearch = { searchData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCustomerSearch, parametersOfGetCustomerSearch, methodGetCustomerSearchParametersTypes);

            // Assert
            parametersOfGetCustomerSearch.ShouldNotBeNull();
            parametersOfGetCustomerSearch.Length.ShouldBe(1);
            methodGetCustomerSearchParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var methodGetCustomerSearchParametersTypes = new Type[] { typeof(Dictionary<string, string>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearch, methodGetCustomerSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCustomerSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var methodGetCustomerSearchParametersTypes = new Type[] { typeof(Dictionary<string, string>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCustomerSearch, methodGetCustomerSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCustomerSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCustomerSearch) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CustomerController_GetCustomerSearch_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCustomerSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCustomerSearch, 0);
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