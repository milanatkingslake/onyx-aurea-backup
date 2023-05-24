using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Connectivity" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Connectivity.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ConnectivityTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Connectivity" />)
        /// </summary>
        public ConnectivityTest() : base(typeof(Connectivity))
        { }

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

        #region General Initializer : Class (Connectivity) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _connectivityInstanceType;
        private Connectivity _connectivityInstance;
        private Connectivity _connectivityInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Connectivity" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _connectivityInstanceType = typeof(Connectivity);
            _connectivityInstanceFixture = this.Create<Connectivity>(false);
            _connectivityInstance = _connectivityInstanceFixture ?? this.Create<Connectivity>(true);
            CurrentInstance = _connectivityInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Connectivity) Initializer

        #region Methods

        private const string MethodGetOgsInstanceDetails = "GetOgsInstanceDetails";
        private const string MethodCheckService = "CheckService";
        private const string MethodGetAppSettings = "GetAppSettings";
        private const string MethodGetEntityMappingMobile = "GetEntityMappingMobile";

        #endregion

        #region Fields

        private const string FieldApplicationId = "ApplicationId";
        private const string FieldApplicationKey = "ApplicationKey";

        #endregion

        #endregion

        #region General Initializer : Class (Connectivity) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Connectivity" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Connectivity_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (Connectivity) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="Connectivity" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Connectivity_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Connectivity)

        #region General Initializer : Class (Connectivity) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Connectivity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetOgsInstanceDetails, 0)]
        [TestCase(MethodCheckService, 0)]
        [TestCase(MethodGetAppSettings, 0)]
        [TestCase(MethodGetEntityMappingMobile, 0)]
        public void AUT_Connectivity_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (Connectivity) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="Connectivity" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldApplicationId)]
        [TestCase(FieldApplicationKey)]
        [Category("AUT Fields")]
        public void AUT_Connectivity_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (Connectivity) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Connectivity" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Connectivity_Is_Instance_Present_Test()
        {
            // Assert
            _connectivityInstanceType.ShouldNotBeNull();
            _connectivityInstance.ShouldNotBeNull();
            _connectivityInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Connectivity) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Connectivity" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Connectivity_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _connectivityInstance.ShouldBeAssignableTo<Connectivity>();
            _connectivityInstanceFixture.ShouldBeAssignableTo<Connectivity>();
            CurrentInstance.ShouldBeAssignableTo<Connectivity>();
        }

        #endregion

        #region General Constructor : Class (Connectivity) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Connectivity_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Connectivity instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _connectivityInstance.GetOgsInstanceDetails(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _connectivityInstance.GetOgsInstanceDetails(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var message = this.CreateType<Message>();
            var methodGetOgsInstanceDetailsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetOgsInstanceDetails = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetOgsInstanceDetails, methodGetOgsInstanceDetailsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_connectivityInstanceFixture, parametersOfGetOgsInstanceDetails);
            var result2 = this.GetResultOfMethod<Message>(MethodGetOgsInstanceDetails, parametersOfGetOgsInstanceDetails, methodGetOgsInstanceDetailsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetOgsInstanceDetails.ShouldNotBeNull();
            parametersOfGetOgsInstanceDetails.Length.ShouldBe(1);
            methodGetOgsInstanceDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var message = this.CreateType<Message>();
            var methodGetOgsInstanceDetailsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetOgsInstanceDetails = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetOgsInstanceDetails, parametersOfGetOgsInstanceDetails, methodGetOgsInstanceDetailsParametersTypes);

            // Assert
            parametersOfGetOgsInstanceDetails.ShouldNotBeNull();
            parametersOfGetOgsInstanceDetails.Length.ShouldBe(1);
            methodGetOgsInstanceDetailsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var methodGetOgsInstanceDetailsParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetOgsInstanceDetails, methodGetOgsInstanceDetailsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetOgsInstanceDetailsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var methodGetOgsInstanceDetailsParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetOgsInstanceDetails, methodGetOgsInstanceDetailsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetOgsInstanceDetailsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOgsInstanceDetails, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetOgsInstanceDetails) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetOgsInstanceDetails_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetOgsInstanceDetails);
            var currentMethodInfo = this.GetMethodInfo(MethodGetOgsInstanceDetails, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _connectivityInstance.CheckService(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _connectivityInstance.CheckService(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var message = this.CreateType<Message>();
            var methodCheckServiceParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCheckService = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, methodCheckServiceParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_connectivityInstanceFixture, parametersOfCheckService);
            var result2 = this.GetResultOfMethod<Message>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfCheckService.ShouldNotBeNull();
            parametersOfCheckService.Length.ShouldBe(1);
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var message = this.CreateType<Message>();
            var methodCheckServiceParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfCheckService = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodCheckService, parametersOfCheckService, methodCheckServiceParametersTypes);

            // Assert
            parametersOfCheckService.ShouldNotBeNull();
            parametersOfCheckService.Length.ShouldBe(1);
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var methodCheckServiceParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodCheckServiceParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var methodCheckServiceParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCheckService, methodCheckServiceParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCheckServiceParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CheckService) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (CheckService) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_CheckService_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCheckService);
            var currentMethodInfo = this.GetMethodInfo(MethodCheckService, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _connectivityInstance.GetAppSettings(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _connectivityInstance.GetAppSettings(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var message = this.CreateType<Message>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAppSettings = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, methodGetAppSettingsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_connectivityInstanceFixture, parametersOfGetAppSettings);
            var result2 = this.GetResultOfMethod<Message>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAppSettings.ShouldNotBeNull();
            parametersOfGetAppSettings.Length.ShouldBe(1);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var message = this.CreateType<Message>();
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAppSettings = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetAppSettings, parametersOfGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            parametersOfGetAppSettings.ShouldNotBeNull();
            parametersOfGetAppSettings.Length.ShouldBe(1);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAppSettingsParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var methodGetAppSettingsParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAppSettings, methodGetAppSettingsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAppSettingsParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAppSettings) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetAppSettings) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetAppSettings_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAppSettings);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAppSettings, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _connectivityInstance.GetEntityMappingMobile(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _connectivityInstance.GetEntityMappingMobile(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var message = this.CreateType<Message>();
            var methodGetEntityMappingMobileParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetEntityMappingMobile = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_connectivityInstanceFixture, parametersOfGetEntityMappingMobile);
            var result2 = this.GetResultOfMethod<Message>(MethodGetEntityMappingMobile, parametersOfGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEntityMappingMobile.ShouldNotBeNull();
            parametersOfGetEntityMappingMobile.Length.ShouldBe(1);
            methodGetEntityMappingMobileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var message = this.CreateType<Message>();
            var methodGetEntityMappingMobileParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetEntityMappingMobile = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetEntityMappingMobile, parametersOfGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            parametersOfGetEntityMappingMobile.ShouldNotBeNull();
            parametersOfGetEntityMappingMobile.Length.ShouldBe(1);
            methodGetEntityMappingMobileParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var methodGetEntityMappingMobileParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEntityMappingMobileParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var methodGetEntityMappingMobileParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEntityMappingMobile, methodGetEntityMappingMobileParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEntityMappingMobileParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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

        #region Method Call : (GetEntityMappingMobile) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Connectivity_GetEntityMappingMobile_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEntityMappingMobile);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEntityMappingMobile, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}