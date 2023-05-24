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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.BusinessLayer.TrackingCodeBusinessLayer" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.BusinessLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class TrackingCodeBusinessLayerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TrackingCodeBusinessLayer" />)
        /// </summary>
        public TrackingCodeBusinessLayerTest() : base(typeof(TrackingCodeBusinessLayer))
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

        #region General Initializer : Class (TrackingCodeBusinessLayer) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _trackingCodeBusinessLayerInstanceType;
        private TrackingCodeBusinessLayer _trackingCodeBusinessLayerInstance;
        private TrackingCodeBusinessLayer _trackingCodeBusinessLayerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TrackingCodeBusinessLayer" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _trackingCodeBusinessLayerInstanceType = typeof(TrackingCodeBusinessLayer);
            _trackingCodeBusinessLayerInstanceFixture = this.Create<TrackingCodeBusinessLayer>(false);
            _trackingCodeBusinessLayerInstance = _trackingCodeBusinessLayerInstanceFixture ?? this.Create<TrackingCodeBusinessLayer>(true);
            CurrentInstance = _trackingCodeBusinessLayerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TrackingCodeBusinessLayer) Initializer

        #region Methods

        private const string MethodGetTrackingCampaignTypeCode = "GetTrackingCampaignTypeCode";
        private const string MethodGetTrackingType = "GetTrackingType";
        private const string MethodGetTrackingCampaignForPrimaryId = "GetTrackingCampaignForPrimaryId";
        private const string MethodGetTrackingCode = "GetTrackingCode";
        private const string MethodGetTrackingCampaigns = "GetTrackingCampaigns";

        #endregion

        #endregion

        #region General Initializer : Class (TrackingCodeBusinessLayer) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeBusinessLayer_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCodeBusinessLayer) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeBusinessLayer_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCodeBusinessLayer) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeBusinessLayer_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TrackingCodeBusinessLayer)

        #region General Initializer : Class (TrackingCodeBusinessLayer) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetTrackingCampaignTypeCode, 0)]
        [TestCase(MethodGetTrackingType, 0)]
        [TestCase(MethodGetTrackingCampaignForPrimaryId, 0)]
        [TestCase(MethodGetTrackingCode, 0)]
        [TestCase(MethodGetTrackingCampaigns, 0)]
        public void AUT_TrackingCodeBusinessLayer_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TrackingCodeBusinessLayer) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCodeBusinessLayer_Is_Instance_Present_Test()
        {
            // Assert
            _trackingCodeBusinessLayerInstanceType.ShouldNotBeNull();
            _trackingCodeBusinessLayerInstance.ShouldNotBeNull();
            _trackingCodeBusinessLayerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TrackingCodeBusinessLayer) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TrackingCodeBusinessLayer" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCodeBusinessLayer_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _trackingCodeBusinessLayerInstance.ShouldBeAssignableTo<TrackingCodeBusinessLayer>();
            _trackingCodeBusinessLayerInstanceFixture.ShouldBeAssignableTo<TrackingCodeBusinessLayer>();
            CurrentInstance.ShouldBeAssignableTo<TrackingCodeBusinessLayer>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TrackingCodeBusinessLayer) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TrackingCodeBusinessLayer_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TrackingCodeBusinessLayer instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _trackingCodeBusinessLayerInstance.GetTrackingCampaignTypeCode(campaignCode, trackingType, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(IList<TrackingCampaignTypeCodeModel>);

            // Act
            Action executeAction = () => returnedValue = _trackingCodeBusinessLayerInstance.GetTrackingCampaignTypeCode(campaignCode, trackingType, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaignTypeCode = { campaignCode, trackingType, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<TrackingCampaignTypeCodeModel>>(_trackingCodeBusinessLayerInstanceFixture, parametersOfGetTrackingCampaignTypeCode);
            var result2 = this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCampaignTypeCode, parametersOfGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCampaignTypeCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCode.Length.ShouldBe(3);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaignTypeCode = { campaignCode, trackingType, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCampaignTypeCode, parametersOfGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignTypeCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCode.Length.ShouldBe(3);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignTypeCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCode, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingTypeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingType, methodGetTrackingTypeParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var campaignCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingTypeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingType = { campaignCode, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingType, methodGetTrackingTypeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<TrackingCampaignTypeCodeModel>>(_trackingCodeBusinessLayerInstanceFixture, parametersOfGetTrackingType);
            var result2 = this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingType, parametersOfGetTrackingType, methodGetTrackingTypeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingType.ShouldNotBeNull();
            parametersOfGetTrackingType.Length.ShouldBe(2);
            methodGetTrackingTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var campaignCode = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingTypeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingType = { campaignCode, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingType, parametersOfGetTrackingType, methodGetTrackingTypeParametersTypes);

            // Assert
            parametersOfGetTrackingType.ShouldNotBeNull();
            parametersOfGetTrackingType.Length.ShouldBe(2);
            methodGetTrackingTypeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var methodGetTrackingTypeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingType, methodGetTrackingTypeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingTypeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var methodGetTrackingTypeParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingType, methodGetTrackingTypeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingTypeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingType, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingType) (Return Type : IList<TrackingCampaignTypeCodeModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingType_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingType);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingType, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();

            // Act
            Action executeAction = () => _trackingCodeBusinessLayerInstance.GetTrackingCampaignForPrimaryId(primaryId, messageModels);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var returnedValue = default(TrackingCampaignTypeCodeModel);

            // Act
            Action executeAction = () => returnedValue = _trackingCodeBusinessLayerInstance.GetTrackingCampaignForPrimaryId(primaryId, messageModels);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaignForPrimaryId = { primaryId, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<TrackingCampaignTypeCodeModel>(_trackingCodeBusinessLayerInstanceFixture, parametersOfGetTrackingCampaignForPrimaryId);
            var result2 = this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignForPrimaryId, parametersOfGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.ShouldNotBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.Length.ShouldBe(2);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaignForPrimaryId = { primaryId, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<TrackingCampaignTypeCodeModel>(MethodGetTrackingCampaignForPrimaryId, parametersOfGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignForPrimaryId.ShouldNotBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.Length.ShouldBe(2);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignForPrimaryId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : TrackingCampaignTypeCodeModel) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaignForPrimaryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignForPrimaryId, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCodeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCode, methodGetTrackingCodeParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCode = { campaignCode, trackingType, messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCode, methodGetTrackingCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<TrackingCampaignTypeCodeModel>>(_trackingCodeBusinessLayerInstanceFixture, parametersOfGetTrackingCode);
            var result2 = this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCode, parametersOfGetTrackingCode, methodGetTrackingCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCode.ShouldNotBeNull();
            parametersOfGetTrackingCode.Length.ShouldBe(3);
            methodGetTrackingCodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCode = { campaignCode, trackingType, messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCode, parametersOfGetTrackingCode, methodGetTrackingCodeParametersTypes);

            // Assert
            parametersOfGetTrackingCode.ShouldNotBeNull();
            parametersOfGetTrackingCode.Length.ShouldBe(3);
            methodGetTrackingCodeParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var methodGetTrackingCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCode, methodGetTrackingCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCodeParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var methodGetTrackingCodeParametersTypes = new Type[] { typeof(string), typeof(string), typeof(List<MessageModel>) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCode, methodGetTrackingCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCode, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCode) (Return Type : IList<TrackingCampaignTypeCodeModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCode, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaigns = { messageModels };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IList<TrackingCampaignTypeCodeModel>>(_trackingCodeBusinessLayerInstanceFixture, parametersOfGetTrackingCampaigns);
            var result2 = this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCampaigns, parametersOfGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCampaigns.ShouldNotBeNull();
            parametersOfGetTrackingCampaigns.Length.ShouldBe(1);
            methodGetTrackingCampaignsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var messageModels = this.CreateType<List<MessageModel>>();
            var methodGetTrackingCampaignsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            object[] parametersOfGetTrackingCampaigns = { messageModels };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IList<TrackingCampaignTypeCodeModel>>(MethodGetTrackingCampaigns, parametersOfGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes);

            // Assert
            parametersOfGetTrackingCampaigns.ShouldNotBeNull();
            parametersOfGetTrackingCampaigns.Length.ShouldBe(1);
            methodGetTrackingCampaignsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var methodGetTrackingCampaignsParametersTypes = new Type[] { typeof(List<MessageModel>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCampaignsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var methodGetTrackingCampaignsParametersTypes = new Type[] { typeof(List<MessageModel>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaigns, methodGetTrackingCampaignsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaigns, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaigns) (Return Type : IList<TrackingCampaignTypeCodeModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeBusinessLayer_GetTrackingCampaigns_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaigns);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaigns, 0);
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