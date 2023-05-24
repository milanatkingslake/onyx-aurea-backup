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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.ServiceRequest" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class ServiceRequestTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceRequest" />)
        /// </summary>
        public ServiceRequestTest() : base(typeof(ServiceRequest))
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

        #region General Initializer : Class (ServiceRequest) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceRequestInstanceType;
        private ServiceRequest _serviceRequestInstance;
        private ServiceRequest _serviceRequestInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceRequest" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceRequestInstanceType = typeof(ServiceRequest);
            _serviceRequestInstanceFixture = this.Create<ServiceRequest>(false);
            _serviceRequestInstance = _serviceRequestInstanceFixture ?? this.Create<ServiceRequest>(true);
            CurrentInstance = _serviceRequestInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceRequest) Initializer

        #region Methods

        private const string MethodGet = "Get";
        private const string MethodGetServiceRequests = "GetServiceRequests";
        private const string MethodGetServiceRequestAssignees = "GetServiceRequestAssignees";
        private const string MethodGetServiceRequestStatusList = "GetServiceRequestStatusList";
        private const string MethodGetServiceRequestPriorityList = "GetServiceRequestPriorityList";
        private const string MethodGetServiceRequestProductList = "GetServiceRequestProductList";
        private const string MethodGetServiceRequestCustomerNames = "GetServiceRequestCustomerNames";
        private const string MethodUpdate = "Update";
        private const string MethodUpdateRecallDate = "UpdateRecallDate";

        #endregion

        #region Fields

        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceRequest) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceRequest_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (ServiceRequest) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceRequest_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceRequest)

        #region General Initializer : Class (ServiceRequest) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGet, 0)]
        [TestCase(MethodGetServiceRequests, 0)]
        [TestCase(MethodGetServiceRequestAssignees, 0)]
        [TestCase(MethodGetServiceRequestStatusList, 0)]
        [TestCase(MethodGetServiceRequestPriorityList, 0)]
        [TestCase(MethodGetServiceRequestProductList, 0)]
        [TestCase(MethodGetServiceRequestCustomerNames, 0)]
        [TestCase(MethodUpdate, 0)]
        [TestCase(MethodUpdateRecallDate, 0)]
        public void AUT_ServiceRequest_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (ServiceRequest) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [Category("AUT Fields")]
        public void AUT_ServiceRequest_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (ServiceRequest) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceRequest_Is_Instance_Present_Test()
        {
            // Assert
            _serviceRequestInstanceType.ShouldNotBeNull();
            _serviceRequestInstance.ShouldNotBeNull();
            _serviceRequestInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceRequest) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceRequest" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceRequest_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceRequestInstance.ShouldBeAssignableTo<ServiceRequest>();
            _serviceRequestInstanceFixture.ShouldBeAssignableTo<ServiceRequest>();
            CurrentInstance.ShouldBeAssignableTo<ServiceRequest>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (ServiceRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceRequest_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            ServiceRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ServiceRequest(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _serviceRequestInstance.ShouldNotBeNull();
            _serviceRequestInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<ServiceRequest>();
        }

        #endregion

        #region General Constructor : Class (ServiceRequest) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceRequest_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            ServiceRequest instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new ServiceRequest(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _serviceRequestInstance.ShouldNotBeNull();
            _serviceRequestInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Get_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGet, methodGetParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGet);
            var result2 = this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Get_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;
            object[] parametersOfGet = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGet, parametersOfGet, methodGetParametersTypes);

            // Assert
            parametersOfGet.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Get_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Get_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            Type [] methodGetParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGet, methodGetParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Get) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Get_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGet);
            var currentMethodInfo = this.GetMethodInfo(MethodGet, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequests_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestsParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequests, methodGetServiceRequestsParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequests();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequests();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            Type [] methodGetServiceRequestsParametersTypes = null;
            object[] parametersOfGetServiceRequests = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequests, methodGetServiceRequestsParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequests);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequests, parametersOfGetServiceRequests, methodGetServiceRequestsParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequests.ShouldBeNull();
            methodGetServiceRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            Type [] methodGetServiceRequestsParametersTypes = null;
            object[] parametersOfGetServiceRequests = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequests, parametersOfGetServiceRequests, methodGetServiceRequestsParametersTypes);

            // Assert
            parametersOfGetServiceRequests.ShouldBeNull();
            methodGetServiceRequestsParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            Type [] methodGetServiceRequestsParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequests, methodGetServiceRequestsParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            Type [] methodGetServiceRequestsParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequests, methodGetServiceRequestsParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestsParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequests) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequests_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequests);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequests, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestAssigneesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequestAssignees();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequestAssignees();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            Type [] methodGetServiceRequestAssigneesParametersTypes = null;
            object[] parametersOfGetServiceRequestAssignees = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequestAssignees);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequestAssignees, parametersOfGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequestAssignees.ShouldBeNull();
            methodGetServiceRequestAssigneesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            Type [] methodGetServiceRequestAssigneesParametersTypes = null;
            object[] parametersOfGetServiceRequestAssignees = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequestAssignees, parametersOfGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes);

            // Assert
            parametersOfGetServiceRequestAssignees.ShouldBeNull();
            methodGetServiceRequestAssigneesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            Type [] methodGetServiceRequestAssigneesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestAssigneesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            Type [] methodGetServiceRequestAssigneesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestAssignees, methodGetServiceRequestAssigneesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestAssigneesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestAssignees) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestAssignees_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestAssignees);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestAssignees, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestStatusListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequestStatusList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequestStatusList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            Type [] methodGetServiceRequestStatusListParametersTypes = null;
            object[] parametersOfGetServiceRequestStatusList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequestStatusList);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequestStatusList, parametersOfGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequestStatusList.ShouldBeNull();
            methodGetServiceRequestStatusListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            Type [] methodGetServiceRequestStatusListParametersTypes = null;
            object[] parametersOfGetServiceRequestStatusList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequestStatusList, parametersOfGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes);

            // Assert
            parametersOfGetServiceRequestStatusList.ShouldBeNull();
            methodGetServiceRequestStatusListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            Type [] methodGetServiceRequestStatusListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestStatusListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            Type [] methodGetServiceRequestStatusListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestStatusList, methodGetServiceRequestStatusListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestStatusListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestStatusList) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestStatusList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestStatusList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestStatusList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestPriorityListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequestPriorityList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequestPriorityList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            Type [] methodGetServiceRequestPriorityListParametersTypes = null;
            object[] parametersOfGetServiceRequestPriorityList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequestPriorityList);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequestPriorityList, parametersOfGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequestPriorityList.ShouldBeNull();
            methodGetServiceRequestPriorityListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            Type [] methodGetServiceRequestPriorityListParametersTypes = null;
            object[] parametersOfGetServiceRequestPriorityList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequestPriorityList, parametersOfGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes);

            // Assert
            parametersOfGetServiceRequestPriorityList.ShouldBeNull();
            methodGetServiceRequestPriorityListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            Type [] methodGetServiceRequestPriorityListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestPriorityListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            Type [] methodGetServiceRequestPriorityListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestPriorityList, methodGetServiceRequestPriorityListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestPriorityListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestPriorityList) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestPriorityList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestPriorityList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestPriorityList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestProductListParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequestProductList();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequestProductList();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            Type [] methodGetServiceRequestProductListParametersTypes = null;
            object[] parametersOfGetServiceRequestProductList = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequestProductList);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequestProductList, parametersOfGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequestProductList.ShouldBeNull();
            methodGetServiceRequestProductListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            Type [] methodGetServiceRequestProductListParametersTypes = null;
            object[] parametersOfGetServiceRequestProductList = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequestProductList, parametersOfGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes);

            // Assert
            parametersOfGetServiceRequestProductList.ShouldBeNull();
            methodGetServiceRequestProductListParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            Type [] methodGetServiceRequestProductListParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestProductListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            Type [] methodGetServiceRequestProductListParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestProductList, methodGetServiceRequestProductListParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestProductListParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestProductList) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestProductList_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestProductList);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestProductList, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_Internally(Type[] types)
        {
            var methodGetServiceRequestCustomerNamesParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes);
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);

            // Act
            Action executeAction = () => _serviceRequestInstance.GetServiceRequestCustomerNames();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.GetServiceRequestCustomerNames();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            Type [] methodGetServiceRequestCustomerNamesParametersTypes = null;
            object[] parametersOfGetServiceRequestCustomerNames = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfGetServiceRequestCustomerNames);
            var result2 = this.GetResultOfMethod<string>(MethodGetServiceRequestCustomerNames, parametersOfGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetServiceRequestCustomerNames.ShouldBeNull();
            methodGetServiceRequestCustomerNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            Type [] methodGetServiceRequestCustomerNamesParametersTypes = null;
            object[] parametersOfGetServiceRequestCustomerNames = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetServiceRequestCustomerNames, parametersOfGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes);

            // Assert
            parametersOfGetServiceRequestCustomerNames.ShouldBeNull();
            methodGetServiceRequestCustomerNamesParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            Type [] methodGetServiceRequestCustomerNamesParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetServiceRequestCustomerNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            Type [] methodGetServiceRequestCustomerNamesParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetServiceRequestCustomerNames, methodGetServiceRequestCustomerNamesParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetServiceRequestCustomerNamesParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetServiceRequestCustomerNames) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_GetServiceRequestCustomerNames_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetServiceRequestCustomerNames);
            var currentMethodInfo = this.GetMethodInfo(MethodGetServiceRequestCustomerNames, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_Update_Method_Call_Internally(Type[] types)
        {
            var methodUpdateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);

            // Act
            Action executeAction = () => _serviceRequestInstance.Update();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.Update();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, methodUpdateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfUpdate);
            var result2 = this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;
            object[] parametersOfUpdate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdate, parametersOfUpdate, methodUpdateParametersTypes);

            // Assert
            parametersOfUpdate.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            Type [] methodUpdateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdate, methodUpdateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Update) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_Update_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdate);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_ServiceRequest_UpdateRecallDate_Method_Call_Internally(Type[] types)
        {
            var methodUpdateRecallDateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);

            // Act
            Action executeAction = () => _serviceRequestInstance.UpdateRecallDate();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _serviceRequestInstance.UpdateRecallDate();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;
            object[] parametersOfUpdateRecallDate = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_serviceRequestInstanceFixture, parametersOfUpdateRecallDate);
            var result2 = this.GetResultOfMethod<string>(MethodUpdateRecallDate, parametersOfUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfUpdateRecallDate.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;
            object[] parametersOfUpdateRecallDate = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodUpdateRecallDate, parametersOfUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            parametersOfUpdateRecallDate.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            Type [] methodUpdateRecallDateParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodUpdateRecallDate, methodUpdateRecallDateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodUpdateRecallDateParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (UpdateRecallDate) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequest_UpdateRecallDate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodUpdateRecallDate);
            var currentMethodInfo = this.GetMethodInfo(MethodUpdateRecallDate, 0);

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