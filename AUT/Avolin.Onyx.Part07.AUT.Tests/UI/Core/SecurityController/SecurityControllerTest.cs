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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Core.SecurityController.SecurityController" />)
    ///     and namespace <see cref="Onyx.UI.Core.SecurityController"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class SecurityControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="SecurityController" />)
        /// </summary>
        public SecurityControllerTest() : base(typeof(global::Onyx.UI.Core.SecurityController.SecurityController))
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

        #region General Initializer : Class (SecurityController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _securityControllerInstanceType;
        private global::Onyx.UI.Core.SecurityController.SecurityController _securityControllerInstance;
        private global::Onyx.UI.Core.SecurityController.SecurityController _securityControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="SecurityController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _securityControllerInstanceType = typeof(global::Onyx.UI.Core.SecurityController.SecurityController);
            _securityControllerInstanceFixture = this.Create<global::Onyx.UI.Core.SecurityController.SecurityController>(false);
            _securityControllerInstance = _securityControllerInstanceFixture ?? this.Create<global::Onyx.UI.Core.SecurityController.SecurityController>(true);
            CurrentInstance = _securityControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (SecurityController) Initializer

        #region Properties

        private const string PropertyOnyxUIUserContext = "OnyxUIUserContext";

        #endregion

        #region Methods

        private const string MethodAuthenticateOnyx = "AuthenticateOnyx";
        private const string MethodGetSecurityTimer = "GetSecurityTimer";

        #endregion

        #endregion

        #region General Initializer : Class (SecurityController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="SecurityController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SecurityController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SecurityController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="SecurityController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SecurityController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (SecurityController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="SecurityController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_SecurityController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (SecurityController)

        #region General Initializer : Class (SecurityController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="SecurityController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAuthenticateOnyx, 0)]
        [TestCase(MethodGetSecurityTimer, 0)]
        public void AUT_SecurityController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (SecurityController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="SecurityController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyOnyxUIUserContext)]
        [Category("AUT Property")]
        public void AUT_SecurityController_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (SecurityController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="SecurityController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SecurityController_Is_Instance_Present_Test()
        {
            // Assert
            _securityControllerInstanceType.ShouldNotBeNull();
            _securityControllerInstance.ShouldNotBeNull();
            _securityControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (SecurityController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="SecurityController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_SecurityController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _securityControllerInstance.ShouldBeAssignableTo<global::Onyx.UI.Core.SecurityController.SecurityController>();
            _securityControllerInstanceFixture.ShouldBeAssignableTo<global::Onyx.UI.Core.SecurityController.SecurityController>();
            CurrentInstance.ShouldBeAssignableTo<global::Onyx.UI.Core.SecurityController.SecurityController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (SecurityController) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_SecurityController_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            global::Onyx.UI.Core.SecurityController.SecurityController instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (SecurityController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyOnyxUIUserContext)]
        public void AUT_SecurityController_Property_Exist_By_Name_Verify_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.PropertyInfoSetValueIfNull(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Getters/Setters : Class (SecurityController) => Property (OnyxUIUserContext) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SecurityController_OnyxUIUserContext_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxUIUserContext);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxUIUserContext);
            Action currentAction = () => propertyInfo.SetValue(_securityControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (SecurityController) => Property (OnyxUIUserContext) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_SecurityController_Public_Class_OnyxUIUserContext_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyOnyxUIUserContext);
            var propertyInfo = this.GetPropertyInfo(PropertyOnyxUIUserContext);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);

            // Act
            Action executeAction = () => _securityControllerInstance.AuthenticateOnyx();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _securityControllerInstance.AuthenticateOnyx();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            Type [] methodAuthenticateOnyxParametersTypes = null;
            object[] parametersOfAuthenticateOnyx = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodAuthenticateOnyx, methodAuthenticateOnyxParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_securityControllerInstanceFixture, out exception1, parametersOfAuthenticateOnyx);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodAuthenticateOnyx, parametersOfAuthenticateOnyx, methodAuthenticateOnyxParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfAuthenticateOnyx.ShouldBeNull();
            methodAuthenticateOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            Type [] methodAuthenticateOnyxParametersTypes = null;
            object[] parametersOfAuthenticateOnyx = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodAuthenticateOnyx, methodAuthenticateOnyxParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_securityControllerInstanceFixture, parametersOfAuthenticateOnyx);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfAuthenticateOnyx.ShouldBeNull();
            methodAuthenticateOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            Type [] methodAuthenticateOnyxParametersTypes = null;
            object[] parametersOfAuthenticateOnyx = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodAuthenticateOnyx, parametersOfAuthenticateOnyx, methodAuthenticateOnyxParametersTypes);

            // Assert
            parametersOfAuthenticateOnyx.ShouldBeNull();
            methodAuthenticateOnyxParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            Type [] methodAuthenticateOnyxParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAuthenticateOnyx, methodAuthenticateOnyxParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodAuthenticateOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            Type [] methodAuthenticateOnyxParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAuthenticateOnyx, methodAuthenticateOnyxParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAuthenticateOnyxParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AuthenticateOnyx) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_AuthenticateOnyx_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAuthenticateOnyx);
            var currentMethodInfo = this.GetMethodInfo(MethodAuthenticateOnyx, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_SecurityController_GetSecurityTimer_Method_Call_Internally(Type[] types)
        {
            var methodGetSecurityTimerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSecurityTimer, methodGetSecurityTimerParametersTypes);
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);

            // Act
            Action executeAction = () => _securityControllerInstance.GetSecurityTimer();

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _securityControllerInstance.GetSecurityTimer();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            Type [] methodGetSecurityTimerParametersTypes = null;
            object[] parametersOfGetSecurityTimer = null; // no parameter present
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityTimer, methodGetSecurityTimerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_securityControllerInstanceFixture, out exception1, parametersOfGetSecurityTimer);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityTimer, parametersOfGetSecurityTimer, methodGetSecurityTimerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetSecurityTimer.ShouldBeNull();
            methodGetSecurityTimerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            Type [] methodGetSecurityTimerParametersTypes = null;
            object[] parametersOfGetSecurityTimer = null; // no parameter present
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityTimer, methodGetSecurityTimerParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_securityControllerInstanceFixture, parametersOfGetSecurityTimer);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetSecurityTimer.ShouldBeNull();
            methodGetSecurityTimerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            Type [] methodGetSecurityTimerParametersTypes = null;
            object[] parametersOfGetSecurityTimer = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSecurityTimer, parametersOfGetSecurityTimer, methodGetSecurityTimerParametersTypes);

            // Assert
            parametersOfGetSecurityTimer.ShouldBeNull();
            methodGetSecurityTimerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            Type [] methodGetSecurityTimerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSecurityTimer, methodGetSecurityTimerParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetSecurityTimerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            Type [] methodGetSecurityTimerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSecurityTimer, methodGetSecurityTimerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSecurityTimerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSecurityTimer) (Return Type : IHttpActionResult) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_SecurityController_GetSecurityTimer_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSecurityTimer);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSecurityTimer, 0);

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