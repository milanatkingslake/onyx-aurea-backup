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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.RegionBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class RegionBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RegionBusinessLayer" />)
        /// </summary>
        public RegionBusinessLayerTest() : base(typeof(RegionBusinessLayer))
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

        #region General Initializer : Class (RegionBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _regionBusinessLayerInstanceType;
        private RegionBusinessLayer _regionBusinessLayerInstance;
        private RegionBusinessLayer _regionBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="RegionBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _regionBusinessLayerInstanceType = typeof(RegionBusinessLayer);
            _regionBusinessLayerInstanceFixture = this.Create<RegionBusinessLayer>(false);
            _regionBusinessLayerInstance = _regionBusinessLayerInstanceFixture ?? this.Create<RegionBusinessLayer>(true);
            CurrentInstance = _regionBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RegionBusinessLayer) Initializer

        #region Methods

        private const string MethodGetActiveRegions = "GetActiveRegions";

        #endregion

        #endregion

        #region General Initializer : Class (RegionBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegionBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (RegionBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RegionBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RegionBusinessLayer)

        #region General Initializer : Class (RegionBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetActiveRegions, 0)]
        [TestCase(MethodGetActiveRegions, 1)]
        public void AUT_RegionBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (RegionBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegionBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _regionBusinessLayerInstanceType.ShouldNotBeNull();
            _regionBusinessLayerInstance.ShouldNotBeNull();
            _regionBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (RegionBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="RegionBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RegionBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _regionBusinessLayerInstance.ShouldBeAssignableTo<RegionBusinessLayer>();
            _regionBusinessLayerInstanceFixture.ShouldBeAssignableTo<RegionBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<RegionBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (RegionBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_RegionBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            RegionBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _regionBusinessLayerInstance.GetActiveRegions(messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<RegionModel>);

            // Act
            Action executeAction = () => returnedValue = _regionBusinessLayerInstance.GetActiveRegions(messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveRegions = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<RegionModel>>(_regionBusinessLayerInstanceFixture, parametersOfGetActiveRegions);
            var result2 = this.GetResultOfMethod<IList<RegionModel>>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(1);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetActiveRegions = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<RegionModel>>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(1);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_RegionBusinessLayer_GetActiveRegions_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodGetActiveRegionsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _regionBusinessLayerInstance.GetActiveRegions(countryCode, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<RegionModel>);

            // Act
            Action executeAction = () => returnedValue = _regionBusinessLayerInstance.GetActiveRegions(countryCode, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetActiveRegions = { countryCode, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<RegionModel>>(_regionBusinessLayerInstanceFixture, parametersOfGetActiveRegions);
            var result2 = this.GetResultOfMethod<IList<RegionModel>>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(2);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var countryCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetActiveRegions = { countryCode, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<RegionModel>>(MethodGetActiveRegions, parametersOfGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            parametersOfGetActiveRegions.ShouldNotBeNull();
            parametersOfGetActiveRegions.Length.ShouldBe(2);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var methodGetActiveRegionsParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetActiveRegions, methodGetActiveRegionsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetActiveRegionsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 1);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetActiveRegions) (Return Type : IList<RegionModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_RegionBusinessLayer_GetActiveRegions_Method_Call_Overloading_Of_1_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetActiveRegions);
            var currentMethodInfo = this.GetMethodInfo(MethodGetActiveRegions, 1);
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