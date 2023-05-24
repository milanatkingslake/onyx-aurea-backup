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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorCacheController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorCacheControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorCacheController" />)
        /// </summary>
        public NavigatorCacheControllerTest() : base(typeof(NavigatorCacheController))
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

        #region General Initializer : Class (NavigatorCacheController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorCacheControllerInstanceType;
        private NavigatorCacheController _navigatorCacheControllerInstance;
        private NavigatorCacheController _navigatorCacheControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorCacheController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorCacheControllerInstanceType = typeof(NavigatorCacheController);
            _navigatorCacheControllerInstanceFixture = this.Create<NavigatorCacheController>(false);
            _navigatorCacheControllerInstance = _navigatorCacheControllerInstanceFixture ?? this.Create<NavigatorCacheController>(true);
            CurrentInstance = _navigatorCacheControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorCacheController) Initializer

        #region Properties

        private const string PropertyNavigatorCacheBusinessLayer = "NavigatorCacheBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetCountriesCache = "GetCountriesCache";
        private const string MethodGetRegionsCache = "GetRegionsCache";
        private const string MethodGetEmailPriority = "GetEmailPriority";
        private const string MethodGetReferenceLookUpCache = "GetReferenceLookUpCache";
        private const string MethodGetProductPicker = "GetProductPicker";
        private const string MethodGetIncidentProduct = "GetIncidentProduct";
        private const string MethodGetScriptTree = "GetScriptTree";
        private const string MethodGetDateOperator = "GetDateOperator";
        private const string MethodGetOperatorEnumerator = "GetOperatorEnumerator";
        private const string MethodGetUserTree = "GetUserTree";
        private const string MethodGetCampaignTree = "GetCampaignTree";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorCacheController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCacheController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCacheController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCacheController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorCacheController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorCacheController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorCacheController)

        #region General Initializer : Class (NavigatorCacheController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetCountriesCache, 0)]
        [TestCase(MethodGetRegionsCache, 0)]
        [TestCase(MethodGetEmailPriority, 0)]
        [TestCase(MethodGetReferenceLookUpCache, 0)]
        [TestCase(MethodGetProductPicker, 0)]
        [TestCase(MethodGetIncidentProduct, 0)]
        [TestCase(MethodGetScriptTree, 0)]
        [TestCase(MethodGetDateOperator, 0)]
        [TestCase(MethodGetOperatorEnumerator, 0)]
        [TestCase(MethodGetUserTree, 0)]
        [TestCase(MethodGetCampaignTree, 0)]
        public void AUT_NavigatorCacheController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorCacheController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorCacheBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorCacheController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorCacheController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCacheController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorCacheControllerInstanceType.ShouldNotBeNull();
            _navigatorCacheControllerInstance.ShouldNotBeNull();
            _navigatorCacheControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorCacheController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorCacheController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorCacheController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorCacheControllerInstance.ShouldBeAssignableTo<NavigatorCacheController>();
            _navigatorCacheControllerInstanceFixture.ShouldBeAssignableTo<NavigatorCacheController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorCacheController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorCacheController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCacheController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<ICacheBusinessLayer>();
            NavigatorCacheController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorCacheController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorCacheControllerInstance.ShouldNotBeNull();
            _navigatorCacheControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorCacheController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorCacheController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorCacheController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<ICacheBusinessLayer>();
            NavigatorCacheController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorCacheController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorCacheControllerInstance.ShouldNotBeNull();
            _navigatorCacheControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorCacheController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorCacheBusinessLayer)]
        public void AUT_NavigatorCacheController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorCacheController) => Property (NavigatorCacheBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorCacheController_NavigatorCacheBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorCacheBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorCacheBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorCacheControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorCacheController) => Property (NavigatorCacheBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorCacheController_Public_Class_NavigatorCacheBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorCacheBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorCacheBusinessLayer);

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

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetCountriesCache();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetCountriesCache();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            Type [] methodGetCountriesCacheParametersTypes = null;
            object[] parametersOfGetCountriesCache = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetCountriesCache);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCountriesCache, parametersOfGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCountriesCache.ShouldBeNull();
            methodGetCountriesCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            Type [] methodGetCountriesCacheParametersTypes = null;
            object[] parametersOfGetCountriesCache = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCountriesCache, parametersOfGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            parametersOfGetCountriesCache.ShouldBeNull();
            methodGetCountriesCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            Type [] methodGetCountriesCacheParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCountriesCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            Type [] methodGetCountriesCacheParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCountriesCache, methodGetCountriesCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCountriesCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCountriesCache) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCountriesCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCountriesCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCountriesCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_Internally(Type[] types)
        {
            var methodGetRegionsCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetRegionsCache();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetRegionsCache();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            Type [] methodGetRegionsCacheParametersTypes = null;
            object[] parametersOfGetRegionsCache = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetRegionsCache);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetRegionsCache, parametersOfGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetRegionsCache.ShouldBeNull();
            methodGetRegionsCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            Type [] methodGetRegionsCacheParametersTypes = null;
            object[] parametersOfGetRegionsCache = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetRegionsCache, parametersOfGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            parametersOfGetRegionsCache.ShouldBeNull();
            methodGetRegionsCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            Type [] methodGetRegionsCacheParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetRegionsCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            Type [] methodGetRegionsCacheParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetRegionsCache, methodGetRegionsCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetRegionsCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetRegionsCache) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetRegionsCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetRegionsCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetRegionsCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_Internally(Type[] types)
        {
            var methodGetEmailPriorityParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetEmailPriority();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetEmailPriority();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;
            object[] parametersOfGetEmailPriority = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetEmailPriority);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailPriority.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;
            object[] parametersOfGetEmailPriority = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetEmailPriority, parametersOfGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            parametersOfGetEmailPriority.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            Type [] methodGetEmailPriorityParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailPriority, methodGetEmailPriorityParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailPriorityParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailPriority) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetEmailPriority_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailPriority);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailPriority, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_Internally(Type[] types)
        {
            var methodGetReferenceLookUpCacheParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetReferenceLookUpCache();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetReferenceLookUpCache();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            Type [] methodGetReferenceLookUpCacheParametersTypes = null;
            object[] parametersOfGetReferenceLookUpCache = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetReferenceLookUpCache);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetReferenceLookUpCache, parametersOfGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetReferenceLookUpCache.ShouldBeNull();
            methodGetReferenceLookUpCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            Type [] methodGetReferenceLookUpCacheParametersTypes = null;
            object[] parametersOfGetReferenceLookUpCache = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetReferenceLookUpCache, parametersOfGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            parametersOfGetReferenceLookUpCache.ShouldBeNull();
            methodGetReferenceLookUpCacheParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            Type [] methodGetReferenceLookUpCacheParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetReferenceLookUpCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            Type [] methodGetReferenceLookUpCacheParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetReferenceLookUpCache, methodGetReferenceLookUpCacheParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetReferenceLookUpCacheParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetReferenceLookUpCache) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetReferenceLookUpCache_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetReferenceLookUpCache);
            var currentMethodInfo = this.GetMethodInfo(MethodGetReferenceLookUpCache, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetProductPicker_Method_Call_Internally(Type[] types)
        {
            var methodGetProductPickerParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetProductPicker();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetProductPicker();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            Type [] methodGetProductPickerParametersTypes = null;
            object[] parametersOfGetProductPicker = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductPicker, methodGetProductPickerParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetProductPicker);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetProductPicker, parametersOfGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProductPicker.ShouldBeNull();
            methodGetProductPickerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            Type [] methodGetProductPickerParametersTypes = null;
            object[] parametersOfGetProductPicker = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetProductPicker, parametersOfGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            parametersOfGetProductPicker.ShouldBeNull();
            methodGetProductPickerParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            Type [] methodGetProductPickerParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProductPickerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            Type [] methodGetProductPickerParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProductPicker, methodGetProductPickerParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProductPickerParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProductPicker) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetProductPicker_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProductPicker);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProductPicker, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_Internally(Type[] types)
        {
            var methodGetIncidentProductParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetIncidentProduct();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetIncidentProduct();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            Type [] methodGetIncidentProductParametersTypes = null;
            object[] parametersOfGetIncidentProduct = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetIncidentProduct);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetIncidentProduct, parametersOfGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetIncidentProduct.ShouldBeNull();
            methodGetIncidentProductParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            Type [] methodGetIncidentProductParametersTypes = null;
            object[] parametersOfGetIncidentProduct = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetIncidentProduct, parametersOfGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            parametersOfGetIncidentProduct.ShouldBeNull();
            methodGetIncidentProductParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            Type [] methodGetIncidentProductParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetIncidentProductParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            Type [] methodGetIncidentProductParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetIncidentProduct, methodGetIncidentProductParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetIncidentProductParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetIncidentProduct) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetIncidentProduct_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetIncidentProduct);
            var currentMethodInfo = this.GetMethodInfo(MethodGetIncidentProduct, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetScriptTree_Method_Call_Internally(Type[] types)
        {
            var methodGetScriptTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetScriptTree, methodGetScriptTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetScriptTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetScriptTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            Type [] methodGetScriptTreeParametersTypes = null;
            object[] parametersOfGetScriptTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptTree, methodGetScriptTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetScriptTree);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetScriptTree, parametersOfGetScriptTree, methodGetScriptTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetScriptTree.ShouldBeNull();
            methodGetScriptTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            Type [] methodGetScriptTreeParametersTypes = null;
            object[] parametersOfGetScriptTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetScriptTree, parametersOfGetScriptTree, methodGetScriptTreeParametersTypes);

            // Assert
            parametersOfGetScriptTree.ShouldBeNull();
            methodGetScriptTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            Type [] methodGetScriptTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetScriptTree, methodGetScriptTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetScriptTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            Type [] methodGetScriptTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetScriptTree, methodGetScriptTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetScriptTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetScriptTree) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetScriptTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetScriptTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetScriptTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetDateOperator_Method_Call_Internally(Type[] types)
        {
            var methodGetDateOperatorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetDateOperator();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetDateOperator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            Type [] methodGetDateOperatorParametersTypes = null;
            object[] parametersOfGetDateOperator = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperator, methodGetDateOperatorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetDateOperator);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetDateOperator, parametersOfGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetDateOperator.ShouldBeNull();
            methodGetDateOperatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            Type [] methodGetDateOperatorParametersTypes = null;
            object[] parametersOfGetDateOperator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetDateOperator, parametersOfGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            parametersOfGetDateOperator.ShouldBeNull();
            methodGetDateOperatorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            Type [] methodGetDateOperatorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetDateOperatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            Type [] methodGetDateOperatorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetDateOperator, methodGetDateOperatorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetDateOperatorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetDateOperator) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetDateOperator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetDateOperator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetDateOperator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_Internally(Type[] types)
        {
            var methodGetOperatorEnumeratorParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetOperatorEnumerator();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetOperatorEnumerator();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            Type [] methodGetOperatorEnumeratorParametersTypes = null;
            object[] parametersOfGetOperatorEnumerator = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetOperatorEnumerator);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetOperatorEnumerator, parametersOfGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOperatorEnumerator.ShouldBeNull();
            methodGetOperatorEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            Type [] methodGetOperatorEnumeratorParametersTypes = null;
            object[] parametersOfGetOperatorEnumerator = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetOperatorEnumerator, parametersOfGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            parametersOfGetOperatorEnumerator.ShouldBeNull();
            methodGetOperatorEnumeratorParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            Type [] methodGetOperatorEnumeratorParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOperatorEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            Type [] methodGetOperatorEnumeratorParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOperatorEnumerator, methodGetOperatorEnumeratorParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOperatorEnumeratorParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOperatorEnumerator) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetOperatorEnumerator_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOperatorEnumerator);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOperatorEnumerator, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetUserTree_Method_Call_Internally(Type[] types)
        {
            var methodGetUserTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetUserTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetUserTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            Type [] methodGetUserTreeParametersTypes = null;
            object[] parametersOfGetUserTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTree, methodGetUserTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetUserTree);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetUserTree, parametersOfGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetUserTree.ShouldBeNull();
            methodGetUserTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            Type [] methodGetUserTreeParametersTypes = null;
            object[] parametersOfGetUserTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetUserTree, parametersOfGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            parametersOfGetUserTree.ShouldBeNull();
            methodGetUserTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            Type [] methodGetUserTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetUserTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            Type [] methodGetUserTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetUserTree, methodGetUserTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetUserTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetUserTree) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetUserTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetUserTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetUserTree, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_Internally(Type[] types)
        {
            var methodGetCampaignTreeParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);

            // Act
            Action executeAction = () => _navigatorCacheControllerInstance.GetCampaignTree();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorCacheControllerInstance.GetCampaignTree();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            Type [] methodGetCampaignTreeParametersTypes = null;
            object[] parametersOfGetCampaignTree = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorCacheControllerInstanceFixture, parametersOfGetCampaignTree);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetCampaignTree, parametersOfGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetCampaignTree.ShouldBeNull();
            methodGetCampaignTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            Type [] methodGetCampaignTreeParametersTypes = null;
            object[] parametersOfGetCampaignTree = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetCampaignTree, parametersOfGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            parametersOfGetCampaignTree.ShouldBeNull();
            methodGetCampaignTreeParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            Type [] methodGetCampaignTreeParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetCampaignTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            Type [] methodGetCampaignTreeParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetCampaignTree, methodGetCampaignTreeParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetCampaignTreeParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetCampaignTree) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorCacheController_GetCampaignTree_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetCampaignTree);
            var currentMethodInfo = this.GetMethodInfo(MethodGetCampaignTree, 0);

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