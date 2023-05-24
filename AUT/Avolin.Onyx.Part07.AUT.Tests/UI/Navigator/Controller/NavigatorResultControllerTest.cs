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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Controller.NavigatorResultController" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NavigatorResultControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NavigatorResultController" />)
        /// </summary>
        public NavigatorResultControllerTest() : base(typeof(NavigatorResultController))
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

        #region General Initializer : Class (NavigatorResultController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _navigatorResultControllerInstanceType;
        private NavigatorResultController _navigatorResultControllerInstance;
        private NavigatorResultController _navigatorResultControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NavigatorResultController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _navigatorResultControllerInstanceType = typeof(NavigatorResultController);
            _navigatorResultControllerInstanceFixture = this.Create<NavigatorResultController>(false);
            _navigatorResultControllerInstance = _navigatorResultControllerInstanceFixture ?? this.Create<NavigatorResultController>(true);
            CurrentInstance = _navigatorResultControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NavigatorResultController) Initializer

        #region Properties

        private const string PropertyNavigatorResultBusinessLayer = "NavigatorResultBusinessLayer";

        #endregion

        #region Methods

        private const string MethodGetGamConfiguration = "GetGamConfiguration";
        private const string MethodGetLboMappingDetails = "GetLboMappingDetails";
        private const string MethodGetWatchRecords = "GetWatchRecords";
        private const string MethodGetBatchUpdateFields = "GetBatchUpdateFields";
        private const string MethodGetResultGridProfile = "GetResultGridProfile";
        private const string MethodGetResults = "GetResults";
        private const string MethodMergeCustomers = "MergeCustomers";
        private const string MethodUpdateResultFilterProfile = "UpdateResultFilterProfile";
        private const string MethodBatchUpdate = "BatchUpdate";
        private const string MethodRecallDate = "RecallDate";
        private const string MethodWatchInsertUpdate = "WatchInsertUpdate";
        private const string MethodRestoreDefaultResultFilter = "RestoreDefaultResultFilter";
        private const string MethodGetResultToolAction = "GetResultToolAction";

        #endregion

        #endregion

        #region General Initializer : Class (NavigatorResultController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorResultController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorResultController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorResultController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (NavigatorResultController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NavigatorResultController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NavigatorResultController)

        #region General Initializer : Class (NavigatorResultController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetGamConfiguration, 0)]
        [TestCase(MethodGetLboMappingDetails, 0)]
        [TestCase(MethodGetWatchRecords, 0)]
        [TestCase(MethodGetBatchUpdateFields, 0)]
        [TestCase(MethodGetResultGridProfile, 0)]
        [TestCase(MethodGetResults, 0)]
        [TestCase(MethodMergeCustomers, 0)]
        [TestCase(MethodUpdateResultFilterProfile, 0)]
        [TestCase(MethodBatchUpdate, 0)]
        [TestCase(MethodRecallDate, 0)]
        [TestCase(MethodWatchInsertUpdate, 0)]
        [TestCase(MethodRestoreDefaultResultFilter, 0)]
        [TestCase(MethodGetResultToolAction, 0)]
        public void AUT_NavigatorResultController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (NavigatorResultController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyNavigatorResultBusinessLayer)]
        [Category("AUT Property")]
        public void AUT_NavigatorResultController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (NavigatorResultController) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorResultController_Is_Instance_Present_Test()
        {
            // Assert
            _navigatorResultControllerInstanceType.ShouldNotBeNull();
            _navigatorResultControllerInstance.ShouldNotBeNull();
            _navigatorResultControllerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NavigatorResultController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NavigatorResultController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NavigatorResultController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _navigatorResultControllerInstance.ShouldBeAssignableTo<NavigatorResultController>();
            _navigatorResultControllerInstanceFixture.ShouldBeAssignableTo<NavigatorResultController>();
            CurrentInstance.ShouldBeAssignableTo<NavigatorResultController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NavigatorResultController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorResultController_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var mock = this.CreateType<IResultBusinessLayer>();
            NavigatorResultController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorResultController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorResultControllerInstance.ShouldNotBeNull();
            _navigatorResultControllerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NavigatorResultController>();
        }

        #endregion

        #region General Constructor : Class (NavigatorResultController) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NavigatorResultController_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var mock = this.CreateType<IResultBusinessLayer>();
            NavigatorResultController instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NavigatorResultController(mock);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _navigatorResultControllerInstance.ShouldNotBeNull();
            _navigatorResultControllerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (NavigatorResultController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyNavigatorResultBusinessLayer)]
        public void AUT_NavigatorResultController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (NavigatorResultController) => Property (NavigatorResultBusinessLayer) Property Type Test Except String

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorResultController_NavigatorResultBusinessLayer_Property_Setting_String_Throw_Argument_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorResultBusinessLayer);
            var randomString = this.CreateType<string>();

            // Act
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorResultBusinessLayer);
            Action currentAction = () => propertyInfo.SetValue(_navigatorResultControllerInstance, randomString, null);

            // Assert
            propertyInfo.ShouldNotBeNull();
            Should.Throw<ArgumentException>(currentAction);
        }

        #endregion

        #region General Getters/Setters : Class (NavigatorResultController) => Property (NavigatorResultBusinessLayer) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_NavigatorResultController_Public_Class_NavigatorResultBusinessLayer_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyNavigatorResultBusinessLayer);
            var propertyInfo = this.GetPropertyInfo(PropertyNavigatorResultBusinessLayer);

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

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetGamConfiguration();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetGamConfiguration();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;
            object[] parametersOfGetGamConfiguration = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetGamConfiguration);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetGamConfiguration.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;
            object[] parametersOfGetGamConfiguration = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetGamConfiguration, parametersOfGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            parametersOfGetGamConfiguration.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            Type [] methodGetGamConfigurationParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetGamConfiguration, methodGetGamConfigurationParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetGamConfigurationParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetGamConfiguration) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetGamConfiguration_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetGamConfiguration);
            var currentMethodInfo = this.GetMethodInfo(MethodGetGamConfiguration, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_Internally(Type[] types)
        {
            var methodGetLboMappingDetailsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetLboMappingDetails();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetLboMappingDetails();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            Type [] methodGetLboMappingDetailsParametersTypes = null;
            object[] parametersOfGetLboMappingDetails = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetLboMappingDetails);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetLboMappingDetails, parametersOfGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetLboMappingDetails.ShouldBeNull();
            methodGetLboMappingDetailsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            Type [] methodGetLboMappingDetailsParametersTypes = null;
            object[] parametersOfGetLboMappingDetails = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetLboMappingDetails, parametersOfGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            parametersOfGetLboMappingDetails.ShouldBeNull();
            methodGetLboMappingDetailsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            Type [] methodGetLboMappingDetailsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetLboMappingDetailsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            Type [] methodGetLboMappingDetailsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetLboMappingDetails, methodGetLboMappingDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetLboMappingDetailsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetLboMappingDetails) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetLboMappingDetails_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetLboMappingDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetLboMappingDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetWatchRecords_Method_Call_Internally(Type[] types)
        {
            var methodGetWatchRecordsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetWatchRecords(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var entityName = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetWatchRecords(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var entityName = this.CreateType<string>();
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetWatchRecords = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetWatchRecords);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetWatchRecords, parametersOfGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWatchRecords.ShouldNotBeNull();
            parametersOfGetWatchRecords.Length.ShouldBe(1);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var entityName = this.CreateType<string>();
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetWatchRecords = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetWatchRecords, parametersOfGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            parametersOfGetWatchRecords.ShouldNotBeNull();
            parametersOfGetWatchRecords.Length.ShouldBe(1);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var methodGetWatchRecordsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWatchRecords, methodGetWatchRecordsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWatchRecordsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWatchRecords) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetWatchRecords_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWatchRecords);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWatchRecords, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_Internally(Type[] types)
        {
            var methodGetBatchUpdateFieldsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetBatchUpdateFields();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetBatchUpdateFields();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            Type [] methodGetBatchUpdateFieldsParametersTypes = null;
            object[] parametersOfGetBatchUpdateFields = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetBatchUpdateFields);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetBatchUpdateFields, parametersOfGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetBatchUpdateFields.ShouldBeNull();
            methodGetBatchUpdateFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            Type [] methodGetBatchUpdateFieldsParametersTypes = null;
            object[] parametersOfGetBatchUpdateFields = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetBatchUpdateFields, parametersOfGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            parametersOfGetBatchUpdateFields.ShouldBeNull();
            methodGetBatchUpdateFieldsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            Type [] methodGetBatchUpdateFieldsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetBatchUpdateFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            Type [] methodGetBatchUpdateFieldsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetBatchUpdateFields, methodGetBatchUpdateFieldsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetBatchUpdateFieldsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetBatchUpdateFields) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetBatchUpdateFields_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetBatchUpdateFields);
            var currentMethodInfo = this.GetMethodInfo(MethodGetBatchUpdateFields, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_Internally(Type[] types)
        {
            var methodGetResultGridProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetResultGridProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetResultGridProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            Type [] methodGetResultGridProfileParametersTypes = null;
            object[] parametersOfGetResultGridProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetResultGridProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetResultGridProfile, parametersOfGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultGridProfile.ShouldBeNull();
            methodGetResultGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            Type [] methodGetResultGridProfileParametersTypes = null;
            object[] parametersOfGetResultGridProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetResultGridProfile, parametersOfGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            parametersOfGetResultGridProfile.ShouldBeNull();
            methodGetResultGridProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            Type [] methodGetResultGridProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            Type [] methodGetResultGridProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultGridProfile, methodGetResultGridProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultGridProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultGridProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultGridProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultGridProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultGridProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetResults_Method_Call_Internally(Type[] types)
        {
            var methodGetResultsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetResults(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var entityName = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetResults(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var entityName = this.CreateType<string>();
            var methodGetResultsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResults = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, methodGetResultsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetResults);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetResults, parametersOfGetResults, methodGetResultsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResults.ShouldNotBeNull();
            parametersOfGetResults.Length.ShouldBe(1);
            methodGetResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var entityName = this.CreateType<string>();
            var methodGetResultsParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetResults = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetResults, parametersOfGetResults, methodGetResultsParametersTypes);

            // Assert
            parametersOfGetResults.ShouldNotBeNull();
            parametersOfGetResults.Length.ShouldBe(1);
            methodGetResultsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var methodGetResultsParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var methodGetResultsParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResults, methodGetResultsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResults) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResults_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResults);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResults, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_MergeCustomers_Method_Call_Internally(Type[] types)
        {
            var methodMergeCustomersParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.MergeCustomers();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.MergeCustomers();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            Type [] methodMergeCustomersParametersTypes = null;
            object[] parametersOfMergeCustomers = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomers, methodMergeCustomersParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfMergeCustomers);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodMergeCustomers, parametersOfMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfMergeCustomers.ShouldBeNull();
            methodMergeCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            Type [] methodMergeCustomersParametersTypes = null;
            object[] parametersOfMergeCustomers = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodMergeCustomers, parametersOfMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            parametersOfMergeCustomers.ShouldBeNull();
            methodMergeCustomersParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            Type [] methodMergeCustomersParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodMergeCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            Type [] methodMergeCustomersParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodMergeCustomers, methodMergeCustomersParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodMergeCustomersParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (MergeCustomers) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_MergeCustomers_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodMergeCustomers);
            var currentMethodInfo = this.GetMethodInfo(MethodMergeCustomers, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_Internally(Type[] types)
        {
            var methodUpdateResultFilterProfileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.UpdateResultFilterProfile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.UpdateResultFilterProfile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            Type [] methodUpdateResultFilterProfileParametersTypes = null;
            object[] parametersOfUpdateResultFilterProfile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfUpdateResultFilterProfile);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodUpdateResultFilterProfile, parametersOfUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateResultFilterProfile.ShouldBeNull();
            methodUpdateResultFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            Type [] methodUpdateResultFilterProfileParametersTypes = null;
            object[] parametersOfUpdateResultFilterProfile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodUpdateResultFilterProfile, parametersOfUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes);

            // Assert
            parametersOfUpdateResultFilterProfile.ShouldBeNull();
            methodUpdateResultFilterProfileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            Type [] methodUpdateResultFilterProfileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateResultFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            Type [] methodUpdateResultFilterProfileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateResultFilterProfile, methodUpdateResultFilterProfileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateResultFilterProfileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateResultFilterProfile) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_UpdateResultFilterProfile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateResultFilterProfile);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateResultFilterProfile, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_BatchUpdate_Method_Call_Internally(Type[] types)
        {
            var methodBatchUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.BatchUpdate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.BatchUpdate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;
            object[] parametersOfBatchUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, methodBatchUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfBatchUpdate);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfBatchUpdate.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;
            object[] parametersOfBatchUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodBatchUpdate, parametersOfBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            parametersOfBatchUpdate.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            Type [] methodBatchUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBatchUpdate, methodBatchUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodBatchUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (BatchUpdate) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_BatchUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBatchUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodBatchUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_RecallDate_Method_Call_Internally(Type[] types)
        {
            var methodRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRecallDate, methodRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.RecallDate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.RecallDate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            Type [] methodRecallDateParametersTypes = null;
            object[] parametersOfRecallDate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRecallDate, methodRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfRecallDate);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodRecallDate, parametersOfRecallDate, methodRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRecallDate.ShouldBeNull();
            methodRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            Type [] methodRecallDateParametersTypes = null;
            object[] parametersOfRecallDate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodRecallDate, parametersOfRecallDate, methodRecallDateParametersTypes);

            // Assert
            parametersOfRecallDate.ShouldBeNull();
            methodRecallDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            Type [] methodRecallDateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRecallDate, methodRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            Type [] methodRecallDateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRecallDate, methodRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RecallDate) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodRecallDate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_Internally(Type[] types)
        {
            var methodWatchInsertUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var entityName = this.CreateType<string>();

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.WatchInsertUpdate(entityName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var entityName = this.CreateType<string>();
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.WatchInsertUpdate(entityName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var entityName = this.CreateType<string>();
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfWatchInsertUpdate = { entityName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfWatchInsertUpdate);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodWatchInsertUpdate, parametersOfWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfWatchInsertUpdate.ShouldNotBeNull();
            parametersOfWatchInsertUpdate.Length.ShouldBe(1);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var entityName = this.CreateType<string>();
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfWatchInsertUpdate = { entityName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodWatchInsertUpdate, parametersOfWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            parametersOfWatchInsertUpdate.ShouldNotBeNull();
            parametersOfWatchInsertUpdate.Length.ShouldBe(1);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var methodWatchInsertUpdateParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodWatchInsertUpdate, methodWatchInsertUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodWatchInsertUpdateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (WatchInsertUpdate) (Return Type : IHttpActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_WatchInsertUpdate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodWatchInsertUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodWatchInsertUpdate, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_Internally(Type[] types)
        {
            var methodRestoreDefaultResultFilterParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes);
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.RestoreDefaultResultFilter();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.RestoreDefaultResultFilter();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            Type [] methodRestoreDefaultResultFilterParametersTypes = null;
            object[] parametersOfRestoreDefaultResultFilter = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfRestoreDefaultResultFilter);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodRestoreDefaultResultFilter, parametersOfRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfRestoreDefaultResultFilter.ShouldBeNull();
            methodRestoreDefaultResultFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            Type [] methodRestoreDefaultResultFilterParametersTypes = null;
            object[] parametersOfRestoreDefaultResultFilter = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodRestoreDefaultResultFilter, parametersOfRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes);

            // Assert
            parametersOfRestoreDefaultResultFilter.ShouldBeNull();
            methodRestoreDefaultResultFilterParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            Type [] methodRestoreDefaultResultFilterParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodRestoreDefaultResultFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            Type [] methodRestoreDefaultResultFilterParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodRestoreDefaultResultFilter, methodRestoreDefaultResultFilterParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodRestoreDefaultResultFilterParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (RestoreDefaultResultFilter) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_RestoreDefaultResultFilter_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodRestoreDefaultResultFilter);
            var currentMethodInfo = this.GetMethodInfo(MethodRestoreDefaultResultFilter, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_NavigatorResultController_GetResultToolAction_Method_Call_Internally(Type[] types)
        {
            var methodGetResultToolActionParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetResultToolAction, methodGetResultToolActionParametersTypes);
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);

            // Act
            Action executeAction = () => _navigatorResultControllerInstance.GetResultToolAction();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            var returnedValue = default(IHttpActionResult);

            // Act
            Action executeAction = () => returnedValue = _navigatorResultControllerInstance.GetResultToolAction();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            Type [] methodGetResultToolActionParametersTypes = null;
            object[] parametersOfGetResultToolAction = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultToolAction, methodGetResultToolActionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<IHttpActionResult>(_navigatorResultControllerInstanceFixture, parametersOfGetResultToolAction);
            var result2 = this.GetResultOfMethod<IHttpActionResult>(MethodGetResultToolAction, parametersOfGetResultToolAction, methodGetResultToolActionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetResultToolAction.ShouldBeNull();
            methodGetResultToolActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            Type [] methodGetResultToolActionParametersTypes = null;
            object[] parametersOfGetResultToolAction = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<IHttpActionResult>(MethodGetResultToolAction, parametersOfGetResultToolAction, methodGetResultToolActionParametersTypes);

            // Assert
            parametersOfGetResultToolAction.ShouldBeNull();
            methodGetResultToolActionParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            Type [] methodGetResultToolActionParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetResultToolAction, methodGetResultToolActionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetResultToolActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            Type [] methodGetResultToolActionParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetResultToolAction, methodGetResultToolActionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetResultToolActionParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetResultToolAction) (Return Type : IHttpActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NavigatorResultController_GetResultToolAction_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetResultToolAction);
            var currentMethodInfo = this.GetMethodInfo(MethodGetResultToolAction, 0);

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