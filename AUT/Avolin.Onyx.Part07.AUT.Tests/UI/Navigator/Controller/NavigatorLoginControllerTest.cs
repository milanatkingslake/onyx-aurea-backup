using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Controller;
using Onyx.UI.Navigator.Interface;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorLoginController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorLoginControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorLoginController" />)
        /// </summary>
        public NavigatorLoginControllerTest() : base(typeof(NavigatorLoginController))
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

        #region General Initializer : Class (NavigatorLoginController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorLoginControllerInstanceType;
        private NavigatorLoginController _navigatorLoginControllerInstance;
        private NavigatorLoginController _navigatorLoginControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorLoginController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorLoginControllerInstanceType = typeof(NavigatorLoginController);
            _navigatorLoginControllerInstanceFixture = this.Create<NavigatorLoginController>(false);
            _navigatorLoginControllerInstance = _navigatorLoginControllerInstanceFixture ?? this.Create<NavigatorLoginController>(true);
            CurrentInstance = _navigatorLoginControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorLoginController) Initializer

        #region Properties

        private const string PropertyNavigatorLoginBusinessLayer = "NavigatorLoginBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetUserProfile = "GetUserProfile";
        private const string MethodGetDefaultUserProfile = "GetDefaultUserProfile";
        private const string MethodGetUserPreferenceByName = "GetUserPreferenceByName";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorLoginController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorLoginController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorLoginController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorLoginController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorLoginController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorLoginController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorLoginController)

        #region General Initializer : Class (NavigatorLoginController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetUserProfile, 0)]
        [TestCase(MethodGetDefaultUserProfile, 0)]
        [TestCase(MethodGetUserPreferenceByName, 0)]
        public void AUT_NavigatorLoginController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorLoginController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorLoginBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorLoginController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorLoginController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorLoginController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorLoginControllerInstanceType.ShouldNotBeNull();
            _navigatorLoginControllerInstance.ShouldNotBeNull();
            _navigatorLoginControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorLoginController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorLoginController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorLoginController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorLoginControllerInstance.ShouldBeAssignableTo<NavigatorLoginController>();
            _navigatorLoginControllerInstanceFixture.ShouldBeAssignableTo<NavigatorLoginController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorLoginController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorLoginController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorLoginController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<ILoginBusinessLayer>();
            NavigatorLoginController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorLoginController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorLoginControllerInstance.ShouldNotBeNull();
            _navigatorLoginControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorLoginController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorLoginController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorLoginController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<ILoginBusinessLayer>();
            NavigatorLoginController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorLoginController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorLoginControllerInstance.ShouldNotBeNull();
            _navigatorLoginControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorLoginController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorLoginBusinessLayer)]
        public void AUT_NavigatorLoginController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorLoginController) => Property (NavigatorLoginBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorLoginController_NavigatorLoginBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorLoginBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorLoginBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorLoginControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorLoginController) => Property (NavigatorLoginBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorLoginController_Public_Class_NavigatorLoginBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorLoginBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorLoginBusinessLayer);

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

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);

            // Act
            Action executeAction = () => _navigatorLoginControllerInstance.GetUserProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginControllerInstance.GetUserProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;
            object[] parametersOfGetUserProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, methodGetUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorLoginControllerInstanceFixture, parametersOfGetUserProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserProfile.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;
            object[] parametersOfGetUserProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserProfile, parametersOfGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            parametersOfGetUserProfile.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            Type [] methodGetUserProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserProfile, methodGetUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetDefaultUserProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);

            // Act
            Action executeAction = () => _navigatorLoginControllerInstance.GetDefaultUserProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginControllerInstance.GetDefaultUserProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;
            object[] parametersOfGetDefaultUserProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorLoginControllerInstanceFixture, parametersOfGetDefaultUserProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDefaultUserProfile.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;
            object[] parametersOfGetDefaultUserProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetDefaultUserProfile, parametersOfGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            parametersOfGetDefaultUserProfile.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            Type [] methodGetDefaultUserProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDefaultUserProfile, methodGetDefaultUserProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDefaultUserProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDefaultUserProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetDefaultUserProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDefaultUserProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDefaultUserProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_Internally(Type[] types)
        {
            var methodGetUserPreferenceByNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);

            // Act
            Action executeAction = () => _navigatorLoginControllerInstance.GetUserPreferenceByName();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorLoginControllerInstance.GetUserPreferenceByName();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;
            object[] parametersOfGetUserPreferenceByName = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorLoginControllerInstanceFixture, parametersOfGetUserPreferenceByName);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserPreferenceByName.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;
            object[] parametersOfGetUserPreferenceByName = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserPreferenceByName, parametersOfGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            parametersOfGetUserPreferenceByName.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            Type [] methodGetUserPreferenceByNameParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserPreferenceByName, methodGetUserPreferenceByNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserPreferenceByNameParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserPreferenceByName) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorLoginController_GetUserPreferenceByName_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserPreferenceByName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserPreferenceByName, 0);

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