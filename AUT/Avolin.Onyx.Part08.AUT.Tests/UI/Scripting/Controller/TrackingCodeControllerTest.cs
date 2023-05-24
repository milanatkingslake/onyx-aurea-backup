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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.TrackingCodeController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class TrackingCodeControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="TrackingCodeController" />)
        /// </summary>
        public TrackingCodeControllerTest() : base(typeof(TrackingCodeController))
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

        #region General Initializer : Class (TrackingCodeController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _trackingCodeControllerInstanceType;
        private TrackingCodeController _trackingCodeControllerInstance;
        private TrackingCodeController _trackingCodeControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="TrackingCodeController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _trackingCodeControllerInstanceType = typeof(TrackingCodeController);
            _trackingCodeControllerInstanceFixture = this.Create<TrackingCodeController>(false);
            _trackingCodeControllerInstance = _trackingCodeControllerInstanceFixture ?? this.Create<TrackingCodeController>(true);
            CurrentInstance = _trackingCodeControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TrackingCodeController) Initializer

        #region Methods

        private const string MethodGetTrackingCampaignTypeCode = "GetTrackingCampaignTypeCode";
        private const string MethodGetTrackingCampaignForPrimaryId = "GetTrackingCampaignForPrimaryId";

        #endregion

        #endregion

        #region General Initializer : Class (TrackingCodeController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCodeController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (TrackingCodeController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TrackingCodeController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (TrackingCodeController)

        #region General Initializer : Class (TrackingCodeController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetTrackingCampaignTypeCode, 0)]
        [TestCase(MethodGetTrackingCampaignForPrimaryId, 0)]
        public void AUT_TrackingCodeController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (TrackingCodeController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCodeController_Is_Instance_Present_Test()
        {
            // Assert
            _trackingCodeControllerInstanceType.ShouldNotBeNull();
            _trackingCodeControllerInstance.ShouldNotBeNull();
            _trackingCodeControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (TrackingCodeController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="TrackingCodeController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_TrackingCodeController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _trackingCodeControllerInstance.ShouldBeAssignableTo<TrackingCodeController>();
            _trackingCodeControllerInstanceFixture.ShouldBeAssignableTo<TrackingCodeController>();
            CurrentInstance.ShouldBeAssignableTo<TrackingCodeController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (TrackingCodeController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_TrackingCodeController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            TrackingCodeController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();

            // Act
            Action executeAction = () => _trackingCodeControllerInstance.GetTrackingCampaignTypeCode(campaignCode, trackingType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _trackingCodeControllerInstance.GetTrackingCampaignTypeCode(campaignCode, trackingType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetTrackingCampaignTypeCode = { campaignCode, trackingType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_trackingCodeControllerInstanceFixture, parametersOfGetTrackingCampaignTypeCode);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetTrackingCampaignTypeCode, parametersOfGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCampaignTypeCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCode.Length.ShouldBe(2);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var campaignCode = this.CreateType<string>();
            var trackingType = this.CreateType<string>();
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfGetTrackingCampaignTypeCode = { campaignCode, trackingType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetTrackingCampaignTypeCode, parametersOfGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignTypeCode.ShouldNotBeNull();
            parametersOfGetTrackingCampaignTypeCode.Length.ShouldBe(2);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var methodGetTrackingCampaignTypeCodeParametersTypes = new Type[] { typeof(string), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignTypeCode, methodGetTrackingCampaignTypeCodeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignTypeCodeParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetTrackingCampaignTypeCode) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignTypeCode_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignTypeCode);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignTypeCode, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_Internally(Type[] types)
        {
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _trackingCodeControllerInstance.GetTrackingCampaignForPrimaryId(primaryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _trackingCodeControllerInstance.GetTrackingCampaignForPrimaryId(primaryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetTrackingCampaignForPrimaryId = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_trackingCodeControllerInstanceFixture, parametersOfGetTrackingCampaignForPrimaryId);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetTrackingCampaignForPrimaryId, parametersOfGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.ShouldNotBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.Length.ShouldBe(1);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var primaryId = this.CreateType<string>();
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetTrackingCampaignForPrimaryId = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetTrackingCampaignForPrimaryId, parametersOfGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            parametersOfGetTrackingCampaignForPrimaryId.ShouldNotBeNull();
            parametersOfGetTrackingCampaignForPrimaryId.Length.ShouldBe(1);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var methodGetTrackingCampaignForPrimaryIdParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetTrackingCampaignForPrimaryId, methodGetTrackingCampaignForPrimaryIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetTrackingCampaignForPrimaryIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetTrackingCampaignForPrimaryId) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_TrackingCodeController_GetTrackingCampaignForPrimaryId_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetTrackingCampaignForPrimaryId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetTrackingCampaignForPrimaryId, 0);
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