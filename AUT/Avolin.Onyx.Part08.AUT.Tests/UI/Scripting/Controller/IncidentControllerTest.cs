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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Scripting.Controller.IncidentController" />)
    ///     and namespace <see cref="Onyx.UI.Scripting.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class IncidentControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="IncidentController" />)
        /// </summary>
        public IncidentControllerTest() : base(typeof(IncidentController))
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

        #region General Initializer : Class (IncidentController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _incidentControllerInstanceType;
        private IncidentController _incidentControllerInstance;
        private IncidentController _incidentControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="IncidentController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _incidentControllerInstanceType = typeof(IncidentController);
            _incidentControllerInstanceFixture = this.Create<IncidentController>(false);
            _incidentControllerInstance = _incidentControllerInstanceFixture ?? this.Create<IncidentController>(true);
            CurrentInstance = _incidentControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (IncidentController) Initializer

        #region Methods

        private const string MethodGetIncidentInfo = "GetIncidentInfo";

        #endregion

        #endregion

        #region General Initializer : Class (IncidentController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="IncidentController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="IncidentController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (IncidentController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="IncidentController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_IncidentController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (IncidentController)

        #region General Initializer : Class (IncidentController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="IncidentController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetIncidentInfo, 0)]
        public void AUT_IncidentController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (IncidentController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="IncidentController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentController_Is_Instance_Present_Test()
        {
            // Assert
            _incidentControllerInstanceType.ShouldNotBeNull();
            _incidentControllerInstance.ShouldNotBeNull();
            _incidentControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (IncidentController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="IncidentController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_IncidentController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _incidentControllerInstance.ShouldBeAssignableTo<IncidentController>();
            _incidentControllerInstanceFixture.ShouldBeAssignableTo<IncidentController>();
            CurrentInstance.ShouldBeAssignableTo<IncidentController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (IncidentController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_IncidentController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            IncidentController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();

            // Act
            Action executeAction = () => _incidentControllerInstance.GetIncidentInfo(primaryId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _incidentControllerInstance.GetIncidentInfo(primaryId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentInfo = { primaryId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_incidentControllerInstanceFixture, parametersOfGetIncidentInfo);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetIncidentInfo, parametersOfGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentInfo.ShouldNotBeNull();
            parametersOfGetIncidentInfo.Length.ShouldBe(1);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var primaryId = this.CreateType<string>();
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetIncidentInfo = { primaryId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetIncidentInfo, parametersOfGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            parametersOfGetIncidentInfo.ShouldNotBeNull();
            parametersOfGetIncidentInfo.Length.ShouldBe(1);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var methodGetIncidentInfoParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentInfo, methodGetIncidentInfoParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentInfoParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetIncidentInfo) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_IncidentController_GetIncidentInfo_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentInfo);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentInfo, 0);
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