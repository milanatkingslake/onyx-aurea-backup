using System;
using System.Diagnostics.CodeAnalysis;
using AUT.ConfigureTestProjects.Analyzer;
using AUT.ConfigureTestProjects.StaticTypes;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using CmService.Service;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part01.AUT.Tests.CmService.Service
{
    using Should = Shouldly.Should;
    using Action = System.Action;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="ServiceRequestInspector" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\ServiceRequestInspector.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ServiceRequestInspectorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ServiceRequestInspector" />)
        /// </summary>
        public ServiceRequestInspectorTest() : base(typeof(ServiceRequestInspector))
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

        #region General Initializer : Class (ServiceRequestInspector) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _serviceRequestInspectorInstanceType;
        private ServiceRequestInspector _serviceRequestInspectorInstance;
        private ServiceRequestInspector _serviceRequestInspectorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="ServiceRequestInspector" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _serviceRequestInspectorInstanceType = typeof(ServiceRequestInspector);
            _serviceRequestInspectorInstanceFixture = this.Create<ServiceRequestInspector>(false);
            _serviceRequestInspectorInstance = _serviceRequestInspectorInstanceFixture ?? this.Create<ServiceRequestInspector>(true);
            CurrentInstance = _serviceRequestInspectorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ServiceRequestInspector) Initializer

        #region Methods

        private const string MethodInspectIncomingRequest = "InspectIncomingRequest";

        #endregion

        #endregion

        #region General Initializer : Class (ServiceRequestInspector) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ServiceRequestInspector" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ServiceRequestInspector_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ServiceRequestInspector)

        #region General Initializer : Class (ServiceRequestInspector) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ServiceRequestInspector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodInspectIncomingRequest, 0)]
        public void AUT_ServiceRequestInspector_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ServiceRequestInspector) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ServiceRequestInspector" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceRequestInspector_Is_Instance_Present_Test()
        {
            // Assert
            _serviceRequestInspectorInstanceType.ShouldNotBeNull();
            _serviceRequestInspectorInstance.ShouldNotBeNull();
            _serviceRequestInspectorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (ServiceRequestInspector) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="ServiceRequestInspector" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ServiceRequestInspector_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _serviceRequestInspectorInstance.ShouldBeAssignableTo<ServiceRequestInspector>();
            _serviceRequestInspectorInstanceFixture.ShouldBeAssignableTo<ServiceRequestInspector>();
            CurrentInstance.ShouldBeAssignableTo<ServiceRequestInspector>();
        }

        #endregion

        #region General Constructor : Class (ServiceRequestInspector) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_ServiceRequestInspector_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            ServiceRequestInspector instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);

            // Act
            Action executeAction = () => ServiceRequestInspector.InspectIncomingRequest();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);
            var returnedValue = default(ResponseMessageFormat);

            // Act
            Action executeAction = () => returnedValue = ServiceRequestInspector.InspectIncomingRequest();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);
            Type [] methodInspectIncomingRequestParametersTypes = null;
            object[] parametersOfInspectIncomingRequest = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<ResponseMessageFormat>(MethodInspectIncomingRequest, parametersOfInspectIncomingRequest, methodInspectIncomingRequestParametersTypes);

            // Assert
            parametersOfInspectIncomingRequest.ShouldBeNull();
            methodInspectIncomingRequestParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);
            Type [] methodInspectIncomingRequestParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodInspectIncomingRequest, methodInspectIncomingRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodInspectIncomingRequestParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);
            Type [] methodInspectIncomingRequestParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodInspectIncomingRequest, methodInspectIncomingRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodInspectIncomingRequestParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (InspectIncomingRequest) (Return Type : ResponseMessageFormat) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ServiceRequestInspector_InspectIncomingRequest_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodInspectIncomingRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodInspectIncomingRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion
    }
}