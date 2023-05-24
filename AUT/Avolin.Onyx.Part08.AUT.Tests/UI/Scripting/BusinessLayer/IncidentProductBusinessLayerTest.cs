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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.IncidentProductBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class IncidentProductBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentProductBusinessLayer" />)
        /// </summary>
        public IncidentProductBusinessLayerTest() : base(typeof(IncidentProductBusinessLayer))
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

        #region General Initializer : Class (IncidentProductBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentProductBusinessLayerInstanceType;
        private IncidentProductBusinessLayer _incidentProductBusinessLayerInstance;
        private IncidentProductBusinessLayer _incidentProductBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentProductBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentProductBusinessLayerInstanceType = typeof(IncidentProductBusinessLayer);
            _incidentProductBusinessLayerInstanceFixture = this.Create<IncidentProductBusinessLayer>(false);
            _incidentProductBusinessLayerInstance = _incidentProductBusinessLayerInstanceFixture ?? this.Create<IncidentProductBusinessLayer>(true);
            CurrentInstance = _incidentProductBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentProductBusinessLayer) Initializer

        #region Methods

        private const string MethodGetActiveIncidentProducts = "GetActiveIncidentProducts";

        #endregion

        #endregion

        #region General Initializer : Class (IncidentProductBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProductBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentProductBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentProductBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentProductBusinessLayer)

        #region General Initializer : Class (IncidentProductBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetActiveIncidentProducts, 0)]
        public void AUT_IncidentProductBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (IncidentProductBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProductBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _incidentProductBusinessLayerInstanceType.ShouldNotBeNull();
            _incidentProductBusinessLayerInstance.ShouldNotBeNull();
            _incidentProductBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentProductBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentProductBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentProductBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentProductBusinessLayerInstance.ShouldBeAssignableTo<IncidentProductBusinessLayer>();
            _incidentProductBusinessLayerInstanceFixture.ShouldBeAssignableTo<IncidentProductBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<IncidentProductBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentProductBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentProductBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentProductBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var categoryType = this.CreateType<int?>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _incidentProductBusinessLayerInstance.GetActiveIncidentProducts(categoryType, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var categoryType = this.CreateType<int?>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<IncidentProductModel>);

            // Act
            Action executeAction = () => returnedValue = _incidentProductBusinessLayerInstance.GetActiveIncidentProducts(categoryType, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var categoryType = this.CreateType<int?>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveIncidentProductsParametersTypes = new Type[] { typeof(int?), typeof(List<MessageModel>) };
            object[] parametersOfGetActiveIncidentProducts = { categoryType, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveIncidentProducts, methodGetActiveIncidentProductsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<IncidentProductModel>>(_incidentProductBusinessLayerInstanceFixture, parametersOfGetActiveIncidentProducts);
            var result2 = this.GetResultOfMethod<IList<IncidentProductModel>>(MethodGetActiveIncidentProducts, parametersOfGetActiveIncidentProducts, methodGetActiveIncidentProductsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveIncidentProducts.ShouldNotBeNull();
            parametersOfGetActiveIncidentProducts.Length.ShouldBe(2);
            methodGetActiveIncidentProductsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var categoryType = this.CreateType<int?>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveIncidentProductsParametersTypes = new Type[] { typeof(int?), typeof(List<MessageModel>) };
            object[] parametersOfGetActiveIncidentProducts = { categoryType, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<IncidentProductModel>>(MethodGetActiveIncidentProducts, parametersOfGetActiveIncidentProducts, methodGetActiveIncidentProductsParametersTypes);

            // Assert
            parametersOfGetActiveIncidentProducts.ShouldNotBeNull();
            parametersOfGetActiveIncidentProducts.Length.ShouldBe(2);
            methodGetActiveIncidentProductsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var methodGetActiveIncidentProductsParametersTypes = new Type[] { typeof(int?), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveIncidentProducts, methodGetActiveIncidentProductsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveIncidentProductsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var methodGetActiveIncidentProductsParametersTypes = new Type[] { typeof(int?), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveIncidentProducts, methodGetActiveIncidentProductsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveIncidentProductsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveIncidentProducts, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveIncidentProducts) (Return Type : IList<IncidentProductModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentProductBusinessLayer_GetActiveIncidentProducts_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveIncidentProducts);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveIncidentProducts, 0);
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