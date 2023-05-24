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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorBookMarkController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorBookMarkControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorBookMarkController" />)
        /// </summary>
        public NavigatorBookMarkControllerTest() : base(typeof(NavigatorBookMarkController))
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

        #region General Initializer : Class (NavigatorBookMarkController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorBookMarkControllerInstanceType;
        private NavigatorBookMarkController _navigatorBookMarkControllerInstance;
        private NavigatorBookMarkController _navigatorBookMarkControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorBookMarkController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorBookMarkControllerInstanceType = typeof(NavigatorBookMarkController);
            _navigatorBookMarkControllerInstanceFixture = this.Create<NavigatorBookMarkController>(false);
            _navigatorBookMarkControllerInstance = _navigatorBookMarkControllerInstanceFixture ?? this.Create<NavigatorBookMarkController>(true);
            CurrentInstance = _navigatorBookMarkControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorBookMarkController) Initializer

        #region Properties

        private const string PropertyNavigatorBookMarkBusinessLayer = "NavigatorBookMarkBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetQueryTree = "GetQueryTree";
        private const string MethodGetHomePageQueries = "GetHomePageQueries";
        private const string MethodSaveALLQuery = "SaveALLQuery";
        private const string MethodGetQueryResults = "GetQueryResults";
        private const string MethodUpdatePostionForQuery = "UpdatePostionForQuery";
        private const string MethodGetHomePageConfig = "GetHomePageConfig";
        private const string MethodSaveHomePageConfig = "SaveHomePageConfig";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorBookMarkController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorBookMarkController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorBookMarkController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorBookMarkController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorBookMarkController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorBookMarkController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorBookMarkController)

        #region General Initializer : Class (NavigatorBookMarkController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetQueryTree, 0)]
        [TestCase(MethodGetHomePageQueries, 0)]
        [TestCase(MethodSaveALLQuery, 0)]
        [TestCase(MethodGetQueryResults, 0)]
        [TestCase(MethodUpdatePostionForQuery, 0)]
        [TestCase(MethodGetHomePageConfig, 0)]
        [TestCase(MethodSaveHomePageConfig, 0)]
        public void AUT_NavigatorBookMarkController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorBookMarkController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorBookMarkBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorBookMarkController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorBookMarkController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorBookMarkController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorBookMarkControllerInstanceType.ShouldNotBeNull();
            _navigatorBookMarkControllerInstance.ShouldNotBeNull();
            _navigatorBookMarkControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorBookMarkController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorBookMarkController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorBookMarkController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorBookMarkControllerInstance.ShouldBeAssignableTo<NavigatorBookMarkController>();
            _navigatorBookMarkControllerInstanceFixture.ShouldBeAssignableTo<NavigatorBookMarkController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorBookMarkController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorBookMarkController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorBookMarkController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<IBookMarkBusinessLayer>();
            NavigatorBookMarkController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorBookMarkController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorBookMarkControllerInstance.ShouldNotBeNull();
            _navigatorBookMarkControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorBookMarkController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorBookMarkController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorBookMarkController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<IBookMarkBusinessLayer>();
            NavigatorBookMarkController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorBookMarkController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorBookMarkControllerInstance.ShouldNotBeNull();
            _navigatorBookMarkControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorBookMarkController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorBookMarkBusinessLayer)]
        public void AUT_NavigatorBookMarkController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorBookMarkController) => Property (NavigatorBookMarkBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorBookMarkController_NavigatorBookMarkBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorBookMarkBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorBookMarkBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorBookMarkControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorBookMarkController) => Property (NavigatorBookMarkBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorBookMarkController_Public_Class_NavigatorBookMarkBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorBookMarkBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorBookMarkBusinessLayer);

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

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.GetQueryTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.GetQueryTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;
            object[] parametersOfGetQueryTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, methodGetQueryTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfGetQueryTree);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryTree.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;
            object[] parametersOfGetQueryTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetQueryTree, parametersOfGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            parametersOfGetQueryTree.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            Type [] methodGetQueryTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryTree, methodGetQueryTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryTree) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageQueriesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.GetHomePageQueries();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.GetHomePageQueries();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;
            object[] parametersOfGetHomePageQueries = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfGetHomePageQueries);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageQueries.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;
            object[] parametersOfGetHomePageQueries = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetHomePageQueries, parametersOfGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            parametersOfGetHomePageQueries.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            Type [] methodGetHomePageQueriesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageQueries, methodGetHomePageQueriesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageQueriesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageQueries) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageQueries_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageQueries);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageQueries, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_Internally(Type[] types)
        {
            var methodSaveALLQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.SaveALLQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.SaveALLQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;
            object[] parametersOfSaveALLQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, methodSaveALLQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfSaveALLQuery);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveALLQuery.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;
            object[] parametersOfSaveALLQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSaveALLQuery, parametersOfSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            parametersOfSaveALLQuery.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            Type [] methodSaveALLQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveALLQuery, methodSaveALLQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveALLQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveALLQuery) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveALLQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveALLQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveALLQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_Internally(Type[] types)
        {
            var methodGetQueryResultsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.GetQueryResults();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.GetQueryResults();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;
            object[] parametersOfGetQueryResults = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, methodGetQueryResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfGetQueryResults);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetQueryResults.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;
            object[] parametersOfGetQueryResults = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetQueryResults, parametersOfGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            parametersOfGetQueryResults.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            Type [] methodGetQueryResultsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetQueryResults, methodGetQueryResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetQueryResultsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetQueryResults) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetQueryResults_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetQueryResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetQueryResults, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_Internally(Type[] types)
        {
            var methodUpdatePostionForQueryParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.UpdatePostionForQuery();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.UpdatePostionForQuery();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;
            object[] parametersOfUpdatePostionForQuery = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfUpdatePostionForQuery);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdatePostionForQuery.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;
            object[] parametersOfUpdatePostionForQuery = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdatePostionForQuery, parametersOfUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            parametersOfUpdatePostionForQuery.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            Type [] methodUpdatePostionForQueryParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdatePostionForQuery, methodUpdatePostionForQueryParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdatePostionForQueryParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdatePostionForQuery) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_UpdatePostionForQuery_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdatePostionForQuery);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdatePostionForQuery, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodGetHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.GetHomePageConfig();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.GetHomePageConfig();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;
            object[] parametersOfGetHomePageConfig = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfGetHomePageConfig);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetHomePageConfig.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;
            object[] parametersOfGetHomePageConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetHomePageConfig, parametersOfGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            parametersOfGetHomePageConfig.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            Type [] methodGetHomePageConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetHomePageConfig, methodGetHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetHomePageConfig) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_GetHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodGetHomePageConfig, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_Internally(Type[] types)
        {
            var methodSaveHomePageConfigParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);

            // Act
            Action executeAction = () => _navigatorBookMarkControllerInstance.SaveHomePageConfig();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorBookMarkControllerInstance.SaveHomePageConfig();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;
            object[] parametersOfSaveHomePageConfig = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorBookMarkControllerInstanceFixture, parametersOfSaveHomePageConfig);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfSaveHomePageConfig.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;
            object[] parametersOfSaveHomePageConfig = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodSaveHomePageConfig, parametersOfSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            parametersOfSaveHomePageConfig.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            Type [] methodSaveHomePageConfigParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSaveHomePageConfig, methodSaveHomePageConfigParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodSaveHomePageConfigParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (SaveHomePageConfig) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorBookMarkController_SaveHomePageConfig_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSaveHomePageConfig);
            var currentMethodInfo = this.GetMethodInfo(MethodSaveHomePageConfig, 0);

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