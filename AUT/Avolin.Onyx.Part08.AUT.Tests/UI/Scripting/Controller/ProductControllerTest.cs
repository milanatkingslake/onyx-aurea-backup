using System;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.ProductController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProductControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProductController" />)
        /// </summary>
        public ProductControllerTest() : base(typeof(ProductController))
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

        #region General Initializer : Class (ProductController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _productControllerInstanceType;
        private ProductController _productControllerInstance;
        private ProductController _productControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProductController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _productControllerInstanceType = typeof(ProductController);
            _productControllerInstanceFixture = this.Create<ProductController>(false);
            _productControllerInstance = _productControllerInstanceFixture ?? this.Create<ProductController>(true);
            CurrentInstance = _productControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProductController) Initializer

        #region Methods

        private const string MethodGetProducts = "GetProducts";
        private const string MethodGetProductForProductCode = "GetProductForProductCode";

        #endregion

        #endregion

        #region General Initializer : Class (ProductController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProductController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProductController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ProductController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProductController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ProductController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ProductController)

        #region General Initializer : Class (ProductController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ProductController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetProducts, 0)]
        [TestCase(MethodGetProductForProductCode, 0)]
        public void AUT_ProductController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ProductController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ProductController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProductController_Is_Instance_Present_Test()
        {
            // Assert
            _productControllerInstanceType.ShouldNotBeNull();
            _productControllerInstance.ShouldNotBeNull();
            _productControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ProductController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ProductController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProductController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _productControllerInstance.ShouldBeAssignableTo<ProductController>();
            _productControllerInstanceFixture.ShouldBeAssignableTo<ProductController>();
            CurrentInstance.ShouldBeAssignableTo<ProductController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ProductController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProductController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ProductController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();

            // Act
            Action executeAction = () => _productControllerInstance.GetProducts(parentId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _productControllerInstance.GetProducts(parentId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var methodGetProductsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProducts = { parentId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, methodGetProductsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_productControllerInstanceFixture, parametersOfGetProducts);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProducts.ShouldNotBeNull();
            parametersOfGetProducts.Length.ShouldBe(1);
            methodGetProductsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var methodGetProductsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProducts = { parentId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            parametersOfGetProducts.ShouldNotBeNull();
            parametersOfGetProducts.Length.ShouldBe(1);
            methodGetProductsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var methodGetProductsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var methodGetProductsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProducts_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProductController_GetProductForProductCode_Method_Call_Internally(Type[] types)
        {
            var methodGetProductForProductCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();

            // Act
            Action executeAction = () => _productControllerInstance.GetProductForProductCode(productCode);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _productControllerInstance.GetProductForProductCode(productCode);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProductForProductCode = { productCode };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_productControllerInstanceFixture, parametersOfGetProductForProductCode);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetProductForProductCode, parametersOfGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductForProductCode.ShouldNotBeNull();
            parametersOfGetProductForProductCode.Length.ShouldBe(1);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetProductForProductCode = { productCode };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetProductForProductCode, parametersOfGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            parametersOfGetProductForProductCode.ShouldNotBeNull();
            parametersOfGetProductForProductCode.Length.ShouldBe(1);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductForProductCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductController_GetProductForProductCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductForProductCode, 0);
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