using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Scripting.BusinessLayer;
using Onyx.UI.Scripting.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Scripting.BusinessLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.ProductBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ProductBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ProductBusinessLayer" />)
        /// </summary>
        public ProductBusinessLayerTest() : base(typeof(ProductBusinessLayer))
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

        #region General Initializer : Class (ProductBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _productBusinessLayerInstanceType;
        private ProductBusinessLayer _productBusinessLayerInstance;
        private ProductBusinessLayer _productBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ProductBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _productBusinessLayerInstanceType = typeof(ProductBusinessLayer);
            _productBusinessLayerInstanceFixture = this.Create<ProductBusinessLayer>(false);
            _productBusinessLayerInstance = _productBusinessLayerInstanceFixture ?? this.Create<ProductBusinessLayer>(true);
            CurrentInstance = _productBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ProductBusinessLayer) Initializer

        #region Methods

        private const string MethodGetProducts = "GetProducts";
        private const string MethodGetProductForProductCode = "GetProductForProductCode";

        #endregion

        #endregion

        #region General Initializer : Class (ProductBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProductBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ProductBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ProductBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ProductBusinessLayer)

        #region General Initializer : Class (ProductBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetProducts, 0)]
        [TestCase(MethodGetProductForProductCode, 0)]
        public void AUT_ProductBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ProductBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProductBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _productBusinessLayerInstanceType.ShouldNotBeNull();
            _productBusinessLayerInstance.ShouldNotBeNull();
            _productBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ProductBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ProductBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ProductBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _productBusinessLayerInstance.ShouldBeAssignableTo<ProductBusinessLayer>();
            _productBusinessLayerInstanceFixture.ShouldBeAssignableTo<ProductBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<ProductBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ProductBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ProductBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ProductBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _productBusinessLayerInstance.GetProducts(parentId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<ProductModel>);

            // Act
            Action executeAction = () => returnedValue = _productBusinessLayerInstance.GetProducts(parentId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetProductsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetProducts = { parentId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, methodGetProductsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<ProductModel>>(_productBusinessLayerInstanceFixture, parametersOfGetProducts);
            var result2 = this.GetResultOfMethod<IList<ProductModel>>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProducts.ShouldNotBeNull();
            parametersOfGetProducts.Length.ShouldBe(2);
            methodGetProductsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var parentId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetProductsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetProducts = { parentId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<ProductModel>>(MethodGetProducts, parametersOfGetProducts, methodGetProductsParametersTypes);

            // Assert
            parametersOfGetProducts.ShouldNotBeNull();
            parametersOfGetProducts.Length.ShouldBe(2);
            methodGetProductsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var methodGetProductsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var methodGetProductsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProducts, methodGetProductsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetProducts) (Return Type : IList<ProductModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProducts_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProducts, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_Internally(Type[] types)
        {
            var methodGetProductForProductCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _productBusinessLayerInstance.GetProductForProductCode(productCode, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(ProductModel);

            // Act
            Action executeAction = () => returnedValue = _productBusinessLayerInstance.GetProductForProductCode(productCode, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetProductForProductCode = { productCode, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ProductModel>(_productBusinessLayerInstanceFixture, parametersOfGetProductForProductCode);
            var result2 = this.GetResultOfMethod<ProductModel>(MethodGetProductForProductCode, parametersOfGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductForProductCode.ShouldNotBeNull();
            parametersOfGetProductForProductCode.Length.ShouldBe(2);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var productCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetProductForProductCode = { productCode, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ProductModel>(MethodGetProductForProductCode, parametersOfGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            parametersOfGetProductForProductCode.ShouldNotBeNull();
            parametersOfGetProductForProductCode.Length.ShouldBe(2);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var methodGetProductForProductCodeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductForProductCode, methodGetProductForProductCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductForProductCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetProductForProductCode) (Return Type : ProductModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ProductBusinessLayer_GetProductForProductCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductForProductCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductForProductCode, 0);
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