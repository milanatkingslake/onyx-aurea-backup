using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.SecurityController;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Core.SecurityController
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.SecurityController.CoreController" />)
    ///     and namespace <see cref="Onyx.UI.Core.SecurityController"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CoreControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CoreController" />)
        /// </summary>
        public CoreControllerTest() : base(typeof(CoreController))
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

        #region General Initializer : Class (CoreController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _coreControllerInstanceType;
        private CoreController _coreControllerInstance;
        private CoreController _coreControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="CoreController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _coreControllerInstanceType = typeof(CoreController);
            _coreControllerInstanceFixture = this.Create<CoreController>(false);
            _coreControllerInstance = _coreControllerInstanceFixture ?? this.Create<CoreController>(true);
            CurrentInstance = _coreControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CoreController) Initializer

        #region Methods

        private const string MethodGetApplicationProfile = "GetApplicationProfile";

        #endregion

        #endregion

        #region General Initializer : Class (CoreController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="CoreController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CoreController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CoreController)

        #region General Initializer : Class (CoreController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="CoreController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetApplicationProfile, 0)]
        public void AUT_CoreController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (CoreController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CoreController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CoreController_Is_Instance_Present_Test()
        {
            // Assert
            _coreControllerInstanceType.ShouldNotBeNull();
            _coreControllerInstance.ShouldNotBeNull();
            _coreControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (CoreController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="CoreController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CoreController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _coreControllerInstance.ShouldBeAssignableTo<CoreController>();
            _coreControllerInstanceFixture.ShouldBeAssignableTo<CoreController>();
            CurrentInstance.ShouldBeAssignableTo<CoreController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (CoreController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_CoreController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            CoreController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);

            // Act
            Action executeAction = () => _coreControllerInstance.GetApplicationProfile();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _coreControllerInstance.GetApplicationProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            Type [] methodGetApplicationProfileParametersTypes = null;
            object[] parametersOfGetApplicationProfile = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationProfile, methodGetApplicationProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_coreControllerInstanceFixture, out exception1, parametersOfGetApplicationProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetApplicationProfile, parametersOfGetApplicationProfile, methodGetApplicationProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetApplicationProfile.ShouldBeNull();
            methodGetApplicationProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            Type [] methodGetApplicationProfileParametersTypes = null;
            object[] parametersOfGetApplicationProfile = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationProfile, methodGetApplicationProfileParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_coreControllerInstanceFixture, parametersOfGetApplicationProfile);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetApplicationProfile.ShouldBeNull();
            methodGetApplicationProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            Type [] methodGetApplicationProfileParametersTypes = null;
            object[] parametersOfGetApplicationProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetApplicationProfile, parametersOfGetApplicationProfile, methodGetApplicationProfileParametersTypes);

            // Assert
            parametersOfGetApplicationProfile.ShouldBeNull();
            methodGetApplicationProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            Type [] methodGetApplicationProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetApplicationProfile, methodGetApplicationProfileParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetApplicationProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            Type [] methodGetApplicationProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetApplicationProfile, methodGetApplicationProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetApplicationProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetApplicationProfile) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_CoreController_GetApplicationProfile_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetApplicationProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetApplicationProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}