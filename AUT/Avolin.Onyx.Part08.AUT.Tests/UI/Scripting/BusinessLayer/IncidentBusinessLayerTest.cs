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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.IncidentBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class IncidentBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentBusinessLayer" />)
        /// </summary>
        public IncidentBusinessLayerTest() : base(typeof(IncidentBusinessLayer))
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

        #region General Initializer : Class (IncidentBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentBusinessLayerInstanceType;
        private IncidentBusinessLayer _incidentBusinessLayerInstance;
        private IncidentBusinessLayer _incidentBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentBusinessLayerInstanceType = typeof(IncidentBusinessLayer);
            _incidentBusinessLayerInstanceFixture = this.Create<IncidentBusinessLayer>(false);
            _incidentBusinessLayerInstance = _incidentBusinessLayerInstanceFixture ?? this.Create<IncidentBusinessLayer>(true);
            CurrentInstance = _incidentBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentBusinessLayer) Initializer

        #region Methods

        private const string MethodGetIncidentInfo = "GetIncidentInfo";

        #endregion

        #endregion

        #region General Initializer : Class (IncidentBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentBusinessLayer)

        #region General Initializer : Class (IncidentBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetIncidentInfo, 0)]
        public void AUT_IncidentBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (IncidentBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _incidentBusinessLayerInstanceType.ShouldNotBeNull();
            _incidentBusinessLayerInstance.ShouldNotBeNull();
            _incidentBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentBusinessLayerInstance.ShouldBeAssignableTo<IncidentBusinessLayer>();
            _incidentBusinessLayerInstanceFixture.ShouldBeAssignableTo<IncidentBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<IncidentBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _incidentBusinessLayerInstance.GetIncidentInfo(primaryId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IncidentModel);

            // Act
            Action executeAction = () => returnedValue = _incidentBusinessLayerInstance.GetIncidentInfo(primaryId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetIncidentInfo = { primaryId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IncidentModel>(_incidentBusinessLayerInstanceFixture, parametersOfGetIncidentInfo);
            var result2 = this.GetResultOfMethod<IncidentModel>(MethodGetIncidentInfo, parametersOfGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentInfo.ShouldNotBeNull();
            parametersOfGetIncidentInfo.Length.ShouldBe(2);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetIncidentInfo = { primaryId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IncidentModel>(MethodGetIncidentInfo, parametersOfGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            parametersOfGetIncidentInfo.ShouldNotBeNull();
            parametersOfGetIncidentInfo.Length.ShouldBe(2);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentInfo, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IncidentModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentBusinessLayer_GetIncidentInfo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentInfo, 0);
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