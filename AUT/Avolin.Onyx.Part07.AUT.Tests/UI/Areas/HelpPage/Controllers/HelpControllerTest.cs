using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http;
using System.Web.Mvc;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage.Controllers;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage.Controllers
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.Controllers.HelpController" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage.Controllers"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelpControllerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="HelpController" />)
        /// </summary>
        public HelpControllerTest() : base(typeof(HelpController))
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

        #region General Initializer : Class (HelpController) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helpControllerInstanceType;
        private HelpController _helpControllerInstance;
        private HelpController _helpControllerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="HelpController" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helpControllerInstanceType = typeof(HelpController);
            _helpControllerInstanceFixture = this.Create<HelpController>(false);
            _helpControllerInstance = _helpControllerInstanceFixture ?? this.Create<HelpController>(true);
            CurrentInstance = _helpControllerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (HelpController) Initializer

        #region Properties

        private const string PropertyConfiguration = "Configuration";

        #endregion

        #region Methods

        private const string MethodIndex = "Index";
        private const string MethodApi = "Api";
        private const string MethodResourceModel = "ResourceModel";

        #endregion

        #region Fields

        private const string FieldErrorViewName = "ErrorViewName";

        #endregion

        #endregion

        #region General Initializer : Class (HelpController) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpController_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpController) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpController_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (HelpController) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_HelpController_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (HelpController)

        #region General Initializer : Class (HelpController) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodIndex, 0)]
        [TestCase(MethodApi, 0)]
        [TestCase(MethodResourceModel, 0)]
        public void AUT_HelpController_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (HelpController) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyConfiguration)]
        [Category("AUT Property")]
        public void AUT_HelpController_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (HelpController) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldErrorViewName)]
        [Category("AUT Fields")]
        public void AUT_HelpController_All_Fields_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var fieldInfo = this.GetFieldInfo(name);

            // Act
            this.ExploreField(fieldInfo);

            // Assert
            fieldInfo.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion

        #region Category : Instance

        #region General Instance : Class (HelpController) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="HelpController" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_HelpController_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _helpControllerInstance.ShouldBeAssignableTo<HelpController>();
            _helpControllerInstanceFixture.ShouldBeAssignableTo<HelpController>();
            CurrentInstance.ShouldBeAssignableTo<HelpController>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (HelpController) constructors coverage gain tests by index

        /// <summary>
        ///     Class (<see cref="HelpController" />) explore and verify it's constructors by index.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        [TestCase(1)]
        public void AUT_HelpController_Constructor_Explore_By_Index_NoThrow_Exception_Thrown_Test(int constructorIndex)
        {
            // Arrange
            object currentInstance = null;

            // Act
            Action currentAction = () => currentInstance = this.GetResultOfConstructorExecuteByIndex(constructorIndex);

            // Assert
            Should.NotThrow(currentAction);
            currentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Constructor : Class (HelpController) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="HelpController" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpController_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (HelpController) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpController" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpController_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodHelpControllerParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpControllerParametersTypes);
        }

        #endregion

        #region General Constructor : Class (HelpController) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="HelpController" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_HelpController_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodHelpControllerParametersTypes = new Type[] { typeof(HttpConfiguration) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodHelpControllerParametersTypes);
        }

        #endregion

        #endregion

        #region Category : GetterSetter

        #region General Getters/Setters : Class (HelpController) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(PropertyConfiguration)]
        public void AUT_HelpController_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (HelpController) => Property (Configuration) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_HelpController_Public_Class_Configuration_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyConfiguration);
            var propertyInfo = this.GetPropertyInfo(PropertyConfiguration);

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

        #region Method Call : (Index) (Return Type : ActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);

            // Act
            Action executeAction = () => _helpControllerInstance.Index();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Index) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);
            Type [] methodIndexParametersTypes = null;
            object[] parametersOfIndex = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodIndex, methodIndexParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ActionResult>(_helpControllerInstanceFixture, parametersOfIndex);
            var result2 = this.GetResultOfMethod<ActionResult>(MethodIndex, parametersOfIndex, methodIndexParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfIndex.ShouldBeNull();
            methodIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Index) (Return Type : ActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);
            Type [] methodIndexParametersTypes = null;
            object[] parametersOfIndex = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ActionResult>(MethodIndex, parametersOfIndex, methodIndexParametersTypes);

            // Assert
            parametersOfIndex.ShouldBeNull();
            methodIndexParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Index) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);
            Type [] methodIndexParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodIndex, methodIndexParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Index) (Return Type : ActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);
            Type [] methodIndexParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodIndex, methodIndexParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodIndexParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Index) (Return Type : ActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Index_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodIndex);
            var currentMethodInfo = this.GetMethodInfo(MethodIndex, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpController_Api_Method_Call_Internally(Type[] types)
        {
            var methodApiParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodApi, methodApiParametersTypes);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var apiId = this.CreateType<string>();

            // Act
            Action executeAction = () => _helpControllerInstance.Api(apiId);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var apiId = this.CreateType<string>();
            var methodApiParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfApi = { apiId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodApi, methodApiParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ActionResult>(_helpControllerInstanceFixture, parametersOfApi);
            var result2 = this.GetResultOfMethod<ActionResult>(MethodApi, parametersOfApi, methodApiParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfApi.ShouldNotBeNull();
            parametersOfApi.Length.ShouldBe(1);
            methodApiParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var apiId = this.CreateType<string>();
            var methodApiParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfApi = { apiId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ActionResult>(MethodApi, parametersOfApi, methodApiParametersTypes);

            // Assert
            parametersOfApi.ShouldNotBeNull();
            parametersOfApi.Length.ShouldBe(1);
            methodApiParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var methodApiParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodApi, methodApiParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodApiParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var methodApiParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodApi, methodApiParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodApiParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var currentMethodInfo = this.GetMethodInfo(MethodApi, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Api) (Return Type : ActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_Api_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodApi);
            var currentMethodInfo = this.GetMethodInfo(MethodApi, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_HelpController_ResourceModel_Method_Call_Internally(Type[] types)
        {
            var methodResourceModelParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodResourceModel, methodResourceModelParametersTypes);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var modelName = this.CreateType<string>();

            // Act
            Action executeAction = () => _helpControllerInstance.ResourceModel(modelName);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var modelName = this.CreateType<string>();
            var returnedValue = default(ActionResult);

            // Act
            Action executeAction = () => returnedValue = _helpControllerInstance.ResourceModel(modelName);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var modelName = this.CreateType<string>();
            var methodResourceModelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfResourceModel = { modelName };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodResourceModel, methodResourceModelParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<ActionResult>(_helpControllerInstanceFixture, parametersOfResourceModel);
            var result2 = this.GetResultOfMethod<ActionResult>(MethodResourceModel, parametersOfResourceModel, methodResourceModelParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfResourceModel.ShouldNotBeNull();
            parametersOfResourceModel.Length.ShouldBe(1);
            methodResourceModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var modelName = this.CreateType<string>();
            var methodResourceModelParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfResourceModel = { modelName };

            // Act
            Action currentAction = () => this.GetResultOfMethod<ActionResult>(MethodResourceModel, parametersOfResourceModel, methodResourceModelParametersTypes);

            // Assert
            parametersOfResourceModel.ShouldNotBeNull();
            parametersOfResourceModel.Length.ShouldBe(1);
            methodResourceModelParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var methodResourceModelParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodResourceModel, methodResourceModelParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodResourceModelParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var methodResourceModelParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodResourceModel, methodResourceModelParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodResourceModelParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var currentMethodInfo = this.GetMethodInfo(MethodResourceModel, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ResourceModel) (Return Type : ActionResult) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_HelpController_ResourceModel_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodResourceModel);
            var currentMethodInfo = this.GetMethodInfo(MethodResourceModel, 0);
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