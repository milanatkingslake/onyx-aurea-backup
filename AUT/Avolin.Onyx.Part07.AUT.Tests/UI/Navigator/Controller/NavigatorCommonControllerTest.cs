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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorCommonController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorCommonControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorCommonController" />)
        /// </summary>
        public NavigatorCommonControllerTest() : base(typeof(NavigatorCommonController))
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

        #region General Initializer : Class (NavigatorCommonController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorCommonControllerInstanceType;
        private NavigatorCommonController _navigatorCommonControllerInstance;
        private NavigatorCommonController _navigatorCommonControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorCommonController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorCommonControllerInstanceType = typeof(NavigatorCommonController);
            _navigatorCommonControllerInstanceFixture = this.Create<NavigatorCommonController>(false);
            _navigatorCommonControllerInstance = _navigatorCommonControllerInstanceFixture ?? this.Create<NavigatorCommonController>(true);
            CurrentInstance = _navigatorCommonControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorCommonController) Initializer

        #region Properties

        private const string PropertyNavigatorCommonBusinessLayer = "NavigatorCommonBusinessLayer";

        #endregion

        #region Methods

        private const string MethodCheckService = "CheckService";
        private const string MethodGetAllUIResources = "GetAllUIResources";
        private const string MethodGetModulePrivilige = "GetModulePrivilige";
        private const string MethodGetDockPrivilege = "GetDockPrivilege";
        private const string MethodGetRecentKeyword = "GetRecentKeyword";
        private const string MethodGetAppSettings = "GetAppSettings";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorCommonController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCommonController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCommonController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCommonController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCommonController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCommonController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorCommonController)

        #region General Initializer : Class (NavigatorCommonController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCheckService, 0)]
        [TestCase(MethodGetAllUIResources, 0)]
        [TestCase(MethodGetModulePrivilige, 0)]
        [TestCase(MethodGetDockPrivilege, 0)]
        [TestCase(MethodGetRecentKeyword, 0)]
        [TestCase(MethodGetAppSettings, 0)]
        public void AUT_NavigatorCommonController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorCommonController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorCommonBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorCommonController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorCommonController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCommonController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorCommonControllerInstanceType.ShouldNotBeNull();
            _navigatorCommonControllerInstance.ShouldNotBeNull();
            _navigatorCommonControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorCommonController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorCommonController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCommonController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorCommonControllerInstance.ShouldBeAssignableTo<NavigatorCommonController>();
            _navigatorCommonControllerInstanceFixture.ShouldBeAssignableTo<NavigatorCommonController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorCommonController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorCommonController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCommonController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<ICommonBusinessLayer>();
            NavigatorCommonController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorCommonController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorCommonControllerInstance.ShouldNotBeNull();
            _navigatorCommonControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorCommonController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorCommonController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCommonController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<ICommonBusinessLayer>();
            NavigatorCommonController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorCommonController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorCommonControllerInstance.ShouldNotBeNull();
            _navigatorCommonControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorCommonController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorCommonBusinessLayer)]
        public void AUT_NavigatorCommonController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorCommonController) => Property (NavigatorCommonBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorCommonController_NavigatorCommonBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorCommonBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorCommonBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorCommonControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorCommonController) => Property (NavigatorCommonBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorCommonController_Public_Class_NavigatorCommonBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorCommonBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorCommonBusinessLayer);

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

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.CheckService();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.CheckService();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            Type [] methodCheckServiceParametersTypes = null;
            object[] parametersOfCheckService = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, methodCheckServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfCheckService);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckService.ShouldBeNull();
            methodCheckServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            Type [] methodCheckServiceParametersTypes = null;
            object[] parametersOfCheckService = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            parametersOfCheckService.ShouldBeNull();
            methodCheckServiceParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            Type [] methodCheckServiceParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            Type [] methodCheckServiceParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckServiceParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_CheckService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_Internally(Type[] types)
        {
            var methodGetAllUIResourcesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.GetAllUIResources();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.GetAllUIResources();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;
            object[] parametersOfGetAllUIResources = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfGetAllUIResources);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAllUIResources.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;
            object[] parametersOfGetAllUIResources = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetAllUIResources, parametersOfGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            parametersOfGetAllUIResources.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            Type [] methodGetAllUIResourcesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAllUIResources, methodGetAllUIResourcesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAllUIResourcesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAllUIResources) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAllUIResources_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAllUIResources);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAllUIResources, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_Internally(Type[] types)
        {
            var methodGetModulePriviligeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.GetModulePrivilige();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.GetModulePrivilige();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            Type [] methodGetModulePriviligeParametersTypes = null;
            object[] parametersOfGetModulePrivilige = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfGetModulePrivilige);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetModulePrivilige, parametersOfGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetModulePrivilige.ShouldBeNull();
            methodGetModulePriviligeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            Type [] methodGetModulePriviligeParametersTypes = null;
            object[] parametersOfGetModulePrivilige = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetModulePrivilige, parametersOfGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            parametersOfGetModulePrivilige.ShouldBeNull();
            methodGetModulePriviligeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            Type [] methodGetModulePriviligeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetModulePriviligeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            Type [] methodGetModulePriviligeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetModulePrivilige, methodGetModulePriviligeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetModulePriviligeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetModulePrivilige) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetModulePrivilige_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetModulePrivilige);
            var currentMethodInfo = this.GetMethodInfo(MethodGetModulePrivilige, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_Internally(Type[] types)
        {
            var methodGetDockPrivilegeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.GetDockPrivilege();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.GetDockPrivilege();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            Type [] methodGetDockPrivilegeParametersTypes = null;
            object[] parametersOfGetDockPrivilege = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfGetDockPrivilege);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetDockPrivilege, parametersOfGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDockPrivilege.ShouldBeNull();
            methodGetDockPrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            Type [] methodGetDockPrivilegeParametersTypes = null;
            object[] parametersOfGetDockPrivilege = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetDockPrivilege, parametersOfGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            parametersOfGetDockPrivilege.ShouldBeNull();
            methodGetDockPrivilegeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            Type [] methodGetDockPrivilegeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDockPrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            Type [] methodGetDockPrivilegeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDockPrivilege, methodGetDockPrivilegeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDockPrivilegeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDockPrivilege) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetDockPrivilege_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDockPrivilege);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDockPrivilege, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_Internally(Type[] types)
        {
            var methodGetRecentKeywordParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.GetRecentKeyword();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.GetRecentKeyword();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            Type [] methodGetRecentKeywordParametersTypes = null;
            object[] parametersOfGetRecentKeyword = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfGetRecentKeyword);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetRecentKeyword, parametersOfGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRecentKeyword.ShouldBeNull();
            methodGetRecentKeywordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            Type [] methodGetRecentKeywordParametersTypes = null;
            object[] parametersOfGetRecentKeyword = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetRecentKeyword, parametersOfGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            parametersOfGetRecentKeyword.ShouldBeNull();
            methodGetRecentKeywordParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            Type [] methodGetRecentKeywordParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRecentKeywordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            Type [] methodGetRecentKeywordParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRecentKeyword, methodGetRecentKeywordParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRecentKeywordParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRecentKeyword) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetRecentKeyword_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRecentKeyword);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRecentKeyword, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCommonController_GetAppSettings_Method_Call_Internally(Type[] types)
        {
            var methodGetAppSettingsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);

            // Act
            Action executeAction = () => _navigatorCommonControllerInstance.GetAppSettings();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCommonControllerInstance.GetAppSettings();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;
            object[] parametersOfGetAppSettings = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, methodGetAppSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCommonControllerInstanceFixture, parametersOfGetAppSettings);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAppSettings.ShouldBeNull();
            methodGetAppSettingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;
            object[] parametersOfGetAppSettings = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            parametersOfGetAppSettings.ShouldBeNull();
            methodGetAppSettingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAppSettingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAppSettingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCommonController_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, 0);

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