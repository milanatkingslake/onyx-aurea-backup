using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Survey.Controller;
using Onyx.UI.Survey.Model;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Survey.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Survey.Controller.SurveyController" />)
    ///     and namespace <see cref="Onyx.UI.Survey.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class SurveyControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SurveyController" />)
        /// </summary>
        public SurveyControllerTest() : base(typeof(SurveyController))
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

        #region General Initializer : Class (SurveyController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _surveyControllerInstanceType;
        private SurveyController _surveyControllerInstance;
        private SurveyController _surveyControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SurveyController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _surveyControllerInstanceType = typeof(SurveyController);
            _surveyControllerInstanceFixture = this.Create<SurveyController>(false);
            _surveyControllerInstance = _surveyControllerInstanceFixture ?? this.Create<SurveyController>(true);
            CurrentInstance = _surveyControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SurveyController) Initializer

        #region Methods

        private const string MethodGetSurvey = "GetSurvey";
        private const string MethodDeleteSurvey = "DeleteSurvey";
        private const string MethodUpdateSurvey = "UpdateSurvey";
        private const string MethodGetSecurityResources = "GetSecurityResources";

        #endregion

        #endregion

        #region General Initializer : Class (SurveyController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SurveyController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SurveyController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SurveyController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SurveyController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SurveyController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SurveyController)

        #region General Initializer : Class (SurveyController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SurveyController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSurvey, 0)]
        [TestCase(MethodDeleteSurvey, 0)]
        [TestCase(MethodUpdateSurvey, 0)]
        [TestCase(MethodGetSecurityResources, 0)]
        public void AUT_SurveyController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (SurveyController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SurveyController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyController_Is_Instance_Present_Test()
        {
            // Assert
            _surveyControllerInstanceType.ShouldNotBeNull();
            _surveyControllerInstance.ShouldNotBeNull();
            _surveyControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SurveyController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SurveyController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SurveyController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _surveyControllerInstance.ShouldBeAssignableTo<SurveyController>();
            _surveyControllerInstanceFixture.ShouldBeAssignableTo<SurveyController>();
            CurrentInstance.ShouldBeAssignableTo<SurveyController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SurveyController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SurveyController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            SurveyController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();

            // Act
            Action executeAction = () => _surveyControllerInstance.GetSurvey(surveyId, ownerId, ownerType);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _surveyControllerInstance.GetSurvey(surveyId, ownerId, ownerType);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            object[] parametersOfGetSurvey = { surveyId, ownerId, ownerType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, methodGetSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_surveyControllerInstanceFixture, parametersOfGetSurvey);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSurvey, parametersOfGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSurvey.ShouldNotBeNull();
            parametersOfGetSurvey.Length.ShouldBe(3);
            methodGetSurveyParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var surveyId = this.CreateType<int>();
            var ownerId = this.CreateType<string>();
            var ownerType = this.CreateType<string>();
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            object[] parametersOfGetSurvey = { surveyId, ownerId, ownerType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSurvey, parametersOfGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            parametersOfGetSurvey.ShouldNotBeNull();
            parametersOfGetSurvey.Length.ShouldBe(3);
            methodGetSurveyParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSurveyParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var methodGetSurveyParametersTypes = new Type[] { typeof(int), typeof(string), typeof(string) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSurvey, methodGetSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSurvey) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSurvey, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyController_DeleteSurvey_Method_Call_Internally(Type[] types)
        {
            var methodDeleteSurveyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();

            // Act
            Action executeAction = () => _surveyControllerInstance.DeleteSurvey(surveyOwnerAssociation);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _surveyControllerInstance.DeleteSurvey(surveyOwnerAssociation);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, methodDeleteSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_surveyControllerInstanceFixture, out exception1, parametersOfDeleteSurvey);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodDeleteSurvey, parametersOfDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(1);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, methodDeleteSurveyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_surveyControllerInstanceFixture, parametersOfDeleteSurvey);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(1);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            object[] parametersOfDeleteSurvey = { surveyOwnerAssociation };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodDeleteSurvey, parametersOfDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            parametersOfDeleteSurvey.ShouldNotBeNull();
            parametersOfDeleteSurvey.Length.ShouldBe(1);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodDeleteSurveyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var methodDeleteSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDeleteSurvey, methodDeleteSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDeleteSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (DeleteSurvey) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_DeleteSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDeleteSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodDeleteSurvey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyController_UpdateSurvey_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSurveyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();

            // Act
            Action executeAction = () => _surveyControllerInstance.UpdateSurvey(surveyOwnerAssociation);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _surveyControllerInstance.UpdateSurvey(surveyOwnerAssociation);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            object[] parametersOfUpdateSurvey = { surveyOwnerAssociation };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, methodUpdateSurveyParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_surveyControllerInstanceFixture, parametersOfUpdateSurvey);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSurvey, parametersOfUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSurvey.ShouldNotBeNull();
            parametersOfUpdateSurvey.Length.ShouldBe(1);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var surveyOwnerAssociation = this.CreateType<SurveyOwnerAssociation>();
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            object[] parametersOfUpdateSurvey = { surveyOwnerAssociation };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSurvey, parametersOfUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            parametersOfUpdateSurvey.ShouldNotBeNull();
            parametersOfUpdateSurvey.Length.ShouldBe(1);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSurveyParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var methodUpdateSurveyParametersTypes = new Type[] { typeof(SurveyOwnerAssociation) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSurvey, methodUpdateSurveyParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSurveyParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSurvey) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_UpdateSurvey_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSurvey);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSurvey, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SurveyController_GetSecurityResources_Method_Call_Internally(Type[] types)
        {
            var methodGetSecurityResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);

            // Act
            Action executeAction = () => _surveyControllerInstance.GetSecurityResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _surveyControllerInstance.GetSecurityResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;
            object[] parametersOfGetSecurityResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_surveyControllerInstanceFixture, parametersOfGetSecurityResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSecurityResources.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;
            object[] parametersOfGetSecurityResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityResources, parametersOfGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            parametersOfGetSecurityResources.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            Type [] methodGetSecurityResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecurityResources, methodGetSecurityResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecurityResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SurveyController_GetSecurityResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}