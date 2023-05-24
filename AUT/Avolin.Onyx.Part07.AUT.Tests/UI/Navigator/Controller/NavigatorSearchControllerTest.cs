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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorSearchController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorSearchControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorSearchController" />)
        /// </summary>
        public NavigatorSearchControllerTest() : base(typeof(NavigatorSearchController))
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

        #region General Initializer : Class (NavigatorSearchController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorSearchControllerInstanceType;
        private NavigatorSearchController _navigatorSearchControllerInstance;
        private NavigatorSearchController _navigatorSearchControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorSearchController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorSearchControllerInstanceType = typeof(NavigatorSearchController);
            _navigatorSearchControllerInstanceFixture = this.Create<NavigatorSearchController>(false);
            _navigatorSearchControllerInstance = _navigatorSearchControllerInstanceFixture ?? this.Create<NavigatorSearchController>(true);
            CurrentInstance = _navigatorSearchControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorSearchController) Initializer

        #region Properties

        private const string PropertyNavigatorSearchBusinessLayer = "NavigatorSearchBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetSearchFilters = "GetSearchFilters";
        private const string MethodGetNavigatorEntities = "GetNavigatorEntities";
        private const string MethodGetSearchFilterProfile = "GetSearchFilterProfile";
        private const string MethodUpdateSearchFilterProfile = "UpdateSearchFilterProfile";
        private const string MethodRestoreDefaultSearchFilter = "RestoreDefaultSearchFilter";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorSearchController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorSearchController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorSearchController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorSearchController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorSearchController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorSearchController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorSearchController)

        #region General Initializer : Class (NavigatorSearchController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSearchFilters, 0)]
        [TestCase(MethodGetNavigatorEntities, 0)]
        [TestCase(MethodGetSearchFilterProfile, 0)]
        [TestCase(MethodUpdateSearchFilterProfile, 0)]
        [TestCase(MethodRestoreDefaultSearchFilter, 0)]
        public void AUT_NavigatorSearchController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorSearchController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorSearchBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorSearchController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorSearchController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorSearchController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorSearchControllerInstanceType.ShouldNotBeNull();
            _navigatorSearchControllerInstance.ShouldNotBeNull();
            _navigatorSearchControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorSearchController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorSearchController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorSearchController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorSearchControllerInstance.ShouldBeAssignableTo<NavigatorSearchController>();
            _navigatorSearchControllerInstanceFixture.ShouldBeAssignableTo<NavigatorSearchController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorSearchController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorSearchController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorSearchController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<ISearchBusinessLayer>();
            NavigatorSearchController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorSearchController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorSearchControllerInstance.ShouldNotBeNull();
            _navigatorSearchControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorSearchController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorSearchController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorSearchController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<ISearchBusinessLayer>();
            NavigatorSearchController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorSearchController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorSearchControllerInstance.ShouldNotBeNull();
            _navigatorSearchControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorSearchController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorSearchBusinessLayer)]
        public void AUT_NavigatorSearchController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorSearchController) => Property (NavigatorSearchBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorSearchController_NavigatorSearchBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorSearchBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorSearchBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorSearchControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorSearchController) => Property (NavigatorSearchBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorSearchController_Public_Class_NavigatorSearchBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorSearchBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorSearchBusinessLayer);

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

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);

            // Act
            Action executeAction = () => _navigatorSearchControllerInstance.GetSearchFilters();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchControllerInstance.GetSearchFilters();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            Type [] methodGetSearchFiltersParametersTypes = null;
            object[] parametersOfGetSearchFilters = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorSearchControllerInstanceFixture, parametersOfGetSearchFilters);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSearchFilters, parametersOfGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilters.ShouldBeNull();
            methodGetSearchFiltersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            Type [] methodGetSearchFiltersParametersTypes = null;
            object[] parametersOfGetSearchFilters = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSearchFilters, parametersOfGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            parametersOfGetSearchFilters.ShouldBeNull();
            methodGetSearchFiltersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            Type [] methodGetSearchFiltersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFiltersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            Type [] methodGetSearchFiltersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilters, methodGetSearchFiltersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFiltersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilters) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilters_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilters);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilters, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_Internally(Type[] types)
        {
            var methodGetNavigatorEntitiesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);

            // Act
            Action executeAction = () => _navigatorSearchControllerInstance.GetNavigatorEntities();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchControllerInstance.GetNavigatorEntities();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            Type [] methodGetNavigatorEntitiesParametersTypes = null;
            object[] parametersOfGetNavigatorEntities = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorSearchControllerInstanceFixture, parametersOfGetNavigatorEntities);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetNavigatorEntities, parametersOfGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetNavigatorEntities.ShouldBeNull();
            methodGetNavigatorEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            Type [] methodGetNavigatorEntitiesParametersTypes = null;
            object[] parametersOfGetNavigatorEntities = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetNavigatorEntities, parametersOfGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            parametersOfGetNavigatorEntities.ShouldBeNull();
            methodGetNavigatorEntitiesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            Type [] methodGetNavigatorEntitiesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetNavigatorEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            Type [] methodGetNavigatorEntitiesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetNavigatorEntities, methodGetNavigatorEntitiesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetNavigatorEntitiesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetNavigatorEntities) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetNavigatorEntities_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetNavigatorEntities);
            var currentMethodInfo = this.GetMethodInfo(MethodGetNavigatorEntities, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);

            // Act
            Action executeAction = () => _navigatorSearchControllerInstance.GetSearchFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchControllerInstance.GetSearchFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;
            object[] parametersOfGetSearchFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorSearchControllerInstanceFixture, parametersOfGetSearchFilterProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSearchFilterProfile.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;
            object[] parametersOfGetSearchFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetSearchFilterProfile, parametersOfGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            parametersOfGetSearchFilterProfile.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            Type [] methodGetSearchFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSearchFilterProfile, methodGetSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSearchFilterProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_GetSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodUpdateSearchFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);

            // Act
            Action executeAction = () => _navigatorSearchControllerInstance.UpdateSearchFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchControllerInstance.UpdateSearchFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;
            object[] parametersOfUpdateSearchFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorSearchControllerInstanceFixture, parametersOfUpdateSearchFilterProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSearchFilterProfile, parametersOfUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateSearchFilterProfile.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;
            object[] parametersOfUpdateSearchFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateSearchFilterProfile, parametersOfUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            parametersOfUpdateSearchFilterProfile.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            Type [] methodUpdateSearchFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateSearchFilterProfile, methodUpdateSearchFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateSearchFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateSearchFilterProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_UpdateSearchFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateSearchFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateSearchFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_Internally(Type[] types)
        {
            var methodRestoreDefaultSearchFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes);
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);

            // Act
            Action executeAction = () => _navigatorSearchControllerInstance.RestoreDefaultSearchFilter();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorSearchControllerInstance.RestoreDefaultSearchFilter();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            Type [] methodRestoreDefaultSearchFilterParametersTypes = null;
            object[] parametersOfRestoreDefaultSearchFilter = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorSearchControllerInstanceFixture, parametersOfRestoreDefaultSearchFilter);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodRestoreDefaultSearchFilter, parametersOfRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRestoreDefaultSearchFilter.ShouldBeNull();
            methodRestoreDefaultSearchFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            Type [] methodRestoreDefaultSearchFilterParametersTypes = null;
            object[] parametersOfRestoreDefaultSearchFilter = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodRestoreDefaultSearchFilter, parametersOfRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes);

            // Assert
            parametersOfRestoreDefaultSearchFilter.ShouldBeNull();
            methodRestoreDefaultSearchFilterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            Type [] methodRestoreDefaultSearchFilterParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRestoreDefaultSearchFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            Type [] methodRestoreDefaultSearchFilterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultSearchFilter, methodRestoreDefaultSearchFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRestoreDefaultSearchFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultSearchFilter) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorSearchController_RestoreDefaultSearchFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultSearchFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDefaultSearchFilter, 0);

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