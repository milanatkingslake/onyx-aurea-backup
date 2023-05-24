using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxISAPI.Model;
using Shouldly;

namespace Avolin.Onyx.Part02.AUT.Tests.OnyxISAPI.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.ApplicationData" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ApplicationDataTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ApplicationData" />)
        /// </summary>
        public ApplicationDataTest() : base(typeof(ApplicationData))
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

        #region General Initializer : Class (ApplicationData) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _applicationDataInstanceType;
        private ApplicationData _applicationDataInstance;
        private ApplicationData _applicationDataInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ApplicationData" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _applicationDataInstanceType = typeof(ApplicationData);
            _applicationDataInstanceFixture = this.Create<ApplicationData>(false);
            _applicationDataInstance = _applicationDataInstanceFixture ?? this.Create<ApplicationData>(true);
            CurrentInstance = _applicationDataInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ApplicationData) Initializer

        #region Methods

        private const string MethodGetAppSettings = "GetAppSettings";
        private const string MethodGetEntityMappingMobile = "GetEntityMappingMobile";

        #endregion

        #endregion

        #region General Initializer : Class (ApplicationData) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ApplicationData" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ApplicationData_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ApplicationData)

        #region General Initializer : Class (ApplicationData) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ApplicationData" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetAppSettings, 0)]
        [TestCase(MethodGetEntityMappingMobile, 0)]
        public void AUT_ApplicationData_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ApplicationData) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ApplicationData" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ApplicationData_Is_Instance_Present_Test()
        {
            // Assert
            _applicationDataInstanceType.ShouldNotBeNull();
            _applicationDataInstance.ShouldNotBeNull();
            _applicationDataInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ApplicationData) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ApplicationData" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ApplicationData_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _applicationDataInstance.ShouldBeAssignableTo<ApplicationData>();
            _applicationDataInstanceFixture.ShouldBeAssignableTo<ApplicationData>();
            CurrentInstance.ShouldBeAssignableTo<ApplicationData>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ApplicationData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ApplicationData_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            ApplicationData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ApplicationData(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _applicationDataInstance.ShouldNotBeNull();
            _applicationDataInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ApplicationData>();
        }

        #endregion

        #region General Constructor : Class (ApplicationData) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ApplicationData_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            ApplicationData instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ApplicationData(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _applicationDataInstance.ShouldNotBeNull();
            _applicationDataInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetAppSettings) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);

            // Act
            Action executeAction = () => _applicationDataInstance.GetAppSettings();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _applicationDataInstance.GetAppSettings();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;
            object[] parametersOfGetAppSettings = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, methodGetAppSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_applicationDataInstanceFixture, parametersOfGetAppSettings);
            var result2 = this.GetResultOfMethod<string>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAppSettings.ShouldBeNull();
            methodGetAppSettingsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            Type [] methodGetAppSettingsParametersTypes = null;
            object[] parametersOfGetAppSettings = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            parametersOfGetAppSettings.ShouldBeNull();
            methodGetAppSettingsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
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

        #region Method Call : (GetAppSettings) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
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

        #region Method Call : (GetAppSettings) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_Internally(Type[] types)
        {
            var methodGetEntityMappingMobileParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);

            // Act
            Action executeAction = () => _applicationDataInstance.GetEntityMappingMobile();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _applicationDataInstance.GetEntityMappingMobile();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            Type [] methodGetEntityMappingMobileParametersTypes = null;
            object[] parametersOfGetEntityMappingMobile = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_applicationDataInstanceFixture, parametersOfGetEntityMappingMobile);
            var result2 = this.GetResultOfMethod<string>(MethodGetEntityMappingMobile, parametersOfGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityMappingMobile.ShouldBeNull();
            methodGetEntityMappingMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            Type [] methodGetEntityMappingMobileParametersTypes = null;
            object[] parametersOfGetEntityMappingMobile = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetEntityMappingMobile, parametersOfGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            parametersOfGetEntityMappingMobile.ShouldBeNull();
            methodGetEntityMappingMobileParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            Type [] methodGetEntityMappingMobileParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityMappingMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            Type [] methodGetEntityMappingMobileParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityMappingMobileParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApplicationData_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityMappingMobile, 0);

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