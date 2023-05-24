using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxQASIntegration.PartnerPlatform;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxQASIntegration.PartnerPlatform
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxQASIntegration.PartnerPlatform.PartnerClient" />)
    ///     and namespace <see cref="OnyxQASIntegration.PartnerPlatform"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class PartnerClientTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PartnerClient" />)
        /// </summary>
        public PartnerClientTest() : base(typeof(PartnerClient))
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

        #region General Initializer : Class (PartnerClient) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _partnerClientInstanceType;
        private PartnerClient _partnerClientInstance;
        private PartnerClient _partnerClientInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PartnerClient" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _partnerClientInstanceType = typeof(PartnerClient);
            _partnerClientInstanceFixture = this.Create<PartnerClient>(false);
            _partnerClientInstance = _partnerClientInstanceFixture ?? this.Create<PartnerClient>(true);
            CurrentInstance = _partnerClientInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PartnerClient) Initializer

        #region Methods

        private const string MethodDoEmail = "DoEmail";
        
        private const string MethodDoBatchEmail = "DoBatchEmail";
        private const string MethodDoBatchEmailAsync = "DoBatchEmailAsync";
        private const string MethodDoSearch = "DoSearch";
        private const string MethodDoSearchAsync = "DoSearchAsync";
        private const string MethodDoRefine = "DoRefine";
        private const string MethodDoRefineAsync = "DoRefineAsync";
        private const string MethodDoValidate = "DoValidate";
        private const string MethodDoValidateAsync = "DoValidateAsync";
        private const string MethodDoBatchValidate = "DoBatchValidate";
        private const string MethodDoBatchValidateAsync = "DoBatchValidateAsync";

        #endregion

        #endregion

        #region General Initializer : Class (PartnerClient) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PartnerClient" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PartnerClient_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PartnerClient)

        #region General Initializer : Class (PartnerClient) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PartnerClient" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodDoEmail, 0)]
        [TestCase(MethodDoBatchEmail, 0)]
        [TestCase(MethodDoSearch, 0)]
        [TestCase(MethodDoRefine, 0)]
        [TestCase(MethodDoValidate, 0)]
        [TestCase(MethodDoBatchValidate, 0)]
        public void AUT_PartnerClient_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (PartnerClient) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PartnerClient" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PartnerClient_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _partnerClientInstance.ShouldBeAssignableTo<PartnerClient>();
            _partnerClientInstanceFixture.ShouldBeAssignableTo<PartnerClient>();
            CurrentInstance.ShouldBeAssignableTo<PartnerClient>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PartnerClient) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (PartnerClient) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodPartnerClientParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPartnerClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PartnerClient) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPartnerClientParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPartnerClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PartnerClient) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPartnerClientParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPartnerClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PartnerClient) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPartnerClientParametersTypes = new Type[] { typeof(string), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPartnerClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PartnerClient) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PartnerClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PartnerClient_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPartnerClientParametersTypes = new Type[] { typeof(System.ServiceModel.Channels.Binding), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPartnerClientParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoEmail_Method_Call_Internally(Type[] types)
        {
            var methodDoEmailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest>();
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest) };
            object[] parametersOfDoEmail = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoEmail, methodDoEmailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoEmailResponse>(_partnerClientInstanceFixture, parametersOfDoEmail);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoEmailResponse>(MethodDoEmail, parametersOfDoEmail, methodDoEmailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoEmail.ShouldNotBeNull();
            parametersOfDoEmail.Length.ShouldBe(1);
            methodDoEmailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest>();
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest) };
            object[] parametersOfDoEmail = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoEmailResponse>(MethodDoEmail, parametersOfDoEmail, methodDoEmailParametersTypes);

            // Assert
            parametersOfDoEmail.ShouldNotBeNull();
            parametersOfDoEmail.Length.ShouldBe(1);
            methodDoEmailParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoEmailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoEmailRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoEmailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoEmailResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodDoEmail, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoEmail_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoEmailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoEmail(authenticationHeader, emailRequest, out emailResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoEmail(authenticationHeader, emailRequest, out emailResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailResponse) };
            object[] parametersOfDoEmail = { authenticationHeader, emailRequest, emailResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoEmail, methodDoEmailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoEmail);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoEmail, parametersOfDoEmail, methodDoEmailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoEmail.ShouldNotBeNull();
            parametersOfDoEmail.Length.ShouldBe(3);
            methodDoEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailRequest>();
            var emailResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.EmailResponse>();
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailResponse) };
            object[] parametersOfDoEmail = { authenticationHeader, emailRequest, emailResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoEmail, parametersOfDoEmail, methodDoEmailParametersTypes);

            // Assert
            parametersOfDoEmail.ShouldNotBeNull();
            parametersOfDoEmail.Length.ShouldBe(3);
            methodDoEmailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoEmail_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoEmail);
            var methodDoEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.EmailResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoEmail, methodDoEmailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoEmailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoBatchEmail_Method_Call_Internally(Type[] types)
        {
            var methodDoBatchEmailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest>();
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest) };
            object[] parametersOfDoBatchEmail = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchEmail, methodDoBatchEmailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse>(_partnerClientInstanceFixture, parametersOfDoBatchEmail);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse>(MethodDoBatchEmail, parametersOfDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoBatchEmail.ShouldNotBeNull();
            parametersOfDoBatchEmail.Length.ShouldBe(1);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest>();
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest) };
            object[] parametersOfDoBatchEmail = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse>(MethodDoBatchEmail, parametersOfDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            parametersOfDoBatchEmail.ShouldNotBeNull();
            parametersOfDoBatchEmail.Length.ShouldBe(1);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoBatchEmailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchEmailRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchEmailResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchEmail, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoBatchEmail_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoBatchEmailParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailBatchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoBatchEmail(authenticationHeader, emailBatchRequest, out emailBatchResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailBatchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoBatchEmail(authenticationHeader, emailBatchRequest, out emailBatchResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailBatchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse) };
            object[] parametersOfDoBatchEmail = { authenticationHeader, emailBatchRequest, emailBatchResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchEmail, methodDoBatchEmailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoBatchEmail);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoBatchEmail, parametersOfDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoBatchEmail.ShouldNotBeNull();
            parametersOfDoBatchEmail.Length.ShouldBe(3);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var emailBatchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest>();
            var emailBatchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse>();
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse) };
            object[] parametersOfDoBatchEmail = { authenticationHeader, emailBatchRequest, emailBatchResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoBatchEmail, parametersOfDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            parametersOfDoBatchEmail.ShouldNotBeNull();
            parametersOfDoBatchEmail.Length.ShouldBe(3);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoBatchEmailParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoBatchEmail) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchEmail_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchEmail);
            var methodDoBatchEmailParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchEmailResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoBatchEmail, methodDoBatchEmailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoBatchEmailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoSearch_Method_Call_Internally(Type[] types)
        {
            var methodDoSearchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest>();
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest) };
            object[] parametersOfDoSearch = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSearch, methodDoSearchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoSearchResponse>(_partnerClientInstanceFixture, parametersOfDoSearch);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoSearchResponse>(MethodDoSearch, parametersOfDoSearch, methodDoSearchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoSearch.ShouldNotBeNull();
            parametersOfDoSearch.Length.ShouldBe(1);
            methodDoSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest>();
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest) };
            object[] parametersOfDoSearch = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoSearchResponse>(MethodDoSearch, parametersOfDoSearch, methodDoSearchParametersTypes);

            // Assert
            parametersOfDoSearch.ShouldNotBeNull();
            parametersOfDoSearch.Length.ShouldBe(1);
            methodDoSearchParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoSearchParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoSearchRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.DoSearchResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var currentMethodInfo = this.GetMethodInfo(MethodDoSearch, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoSearch_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoSearchParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoSearch(authenticationHeader, lookupRequest, out lookupResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoSearch(authenticationHeader, lookupRequest, out lookupResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            object[] parametersOfDoSearch = { authenticationHeader, lookupRequest, lookupResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoSearch, methodDoSearchParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoSearch);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoSearch, parametersOfDoSearch, methodDoSearchParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoSearch.ShouldNotBeNull();
            parametersOfDoSearch.Length.ShouldBe(3);
            methodDoSearchParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            object[] parametersOfDoSearch = { authenticationHeader, lookupRequest, lookupResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoSearch, parametersOfDoSearch, methodDoSearchParametersTypes);

            // Assert
            parametersOfDoSearch.ShouldNotBeNull();
            parametersOfDoSearch.Length.ShouldBe(3);
            methodDoSearchParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoSearchParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoSearch) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoSearch_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoSearch);
            var methodDoSearchParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoSearch, methodDoSearchParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoSearchParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoRefine_Method_Call_Internally(Type[] types)
        {
            var methodDoRefineParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest>();
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest) };
            object[] parametersOfDoRefine = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRefine, methodDoRefineParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoRefineResponse>(_partnerClientInstanceFixture, parametersOfDoRefine);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoRefineResponse>(MethodDoRefine, parametersOfDoRefine, methodDoRefineParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoRefine.ShouldNotBeNull();
            parametersOfDoRefine.Length.ShouldBe(1);
            methodDoRefineParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest>();
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest) };
            object[] parametersOfDoRefine = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoRefineResponse>(MethodDoRefine, parametersOfDoRefine, methodDoRefineParametersTypes);

            // Assert
            parametersOfDoRefine.ShouldNotBeNull();
            parametersOfDoRefine.Length.ShouldBe(1);
            methodDoRefineParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoRefineParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoRefineRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRefineParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.DoRefineResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var currentMethodInfo = this.GetMethodInfo(MethodDoRefine, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoRefine_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoRefineParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoRefine(authenticationHeader, lookupRequest, out lookupResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoRefine(authenticationHeader, lookupRequest, out lookupResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            object[] parametersOfDoRefine = { authenticationHeader, lookupRequest, lookupResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoRefine, methodDoRefineParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoRefine);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoRefine, parametersOfDoRefine, methodDoRefineParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoRefine.ShouldNotBeNull();
            parametersOfDoRefine.Length.ShouldBe(3);
            methodDoRefineParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var lookupRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupRequest>();
            var lookupResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.LookupResponse>();
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            object[] parametersOfDoRefine = { authenticationHeader, lookupRequest, lookupResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoRefine, parametersOfDoRefine, methodDoRefineParametersTypes);

            // Assert
            parametersOfDoRefine.ShouldNotBeNull();
            parametersOfDoRefine.Length.ShouldBe(3);
            methodDoRefineParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoRefineParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoRefine) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoRefine_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoRefine);
            var methodDoRefineParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.LookupResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoRefine, methodDoRefineParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoRefineParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoValidate_Method_Call_Internally(Type[] types)
        {
            var methodDoValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest>();
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest) };
            object[] parametersOfDoValidate = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidate, methodDoValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoValidateResponse>(_partnerClientInstanceFixture, parametersOfDoValidate);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoValidateResponse>(MethodDoValidate, parametersOfDoValidate, methodDoValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoValidate.ShouldNotBeNull();
            parametersOfDoValidate.Length.ShouldBe(1);
            methodDoValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest>();
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest) };
            object[] parametersOfDoValidate = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoValidateResponse>(MethodDoValidate, parametersOfDoValidate, methodDoValidateParametersTypes);

            // Assert
            parametersOfDoValidate.ShouldNotBeNull();
            parametersOfDoValidate.Length.ShouldBe(1);
            methodDoValidateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoValidateRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoValidateResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoValidate_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var validateRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateRequest>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoValidate(authenticationHeader, validateRequest, out validateResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var validateRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateRequest>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoValidate(authenticationHeader, validateRequest, out validateResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var validateRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateRequest>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateResponse) };
            object[] parametersOfDoValidate = { authenticationHeader, validateRequest, validateResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoValidate, methodDoValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoValidate);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoValidate, parametersOfDoValidate, methodDoValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoValidate.ShouldNotBeNull();
            parametersOfDoValidate.Length.ShouldBe(3);
            methodDoValidateParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var validateRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateRequest>();
            var validateResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.ValidateResponse>();
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateResponse) };
            object[] parametersOfDoValidate = { authenticationHeader, validateRequest, validateResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoValidate, parametersOfDoValidate, methodDoValidateParametersTypes);

            // Assert
            parametersOfDoValidate.ShouldNotBeNull();
            parametersOfDoValidate.Length.ShouldBe(3);
            methodDoValidateParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoValidateParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoValidate_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoValidate);
            var methodDoValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.ValidateResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoValidate, methodDoValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoBatchValidate_Method_Call_Internally(Type[] types)
        {
            var methodDoBatchValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest>();
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest) };
            object[] parametersOfDoBatchValidate = { request };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchValidate, methodDoBatchValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse>(_partnerClientInstanceFixture, parametersOfDoBatchValidate);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse>(MethodDoBatchValidate, parametersOfDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoBatchValidate.ShouldNotBeNull();
            parametersOfDoBatchValidate.Length.ShouldBe(1);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var request = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest>();
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest) };
            object[] parametersOfDoBatchValidate = { request };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse>(MethodDoBatchValidate, parametersOfDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            parametersOfDoBatchValidate.ShouldNotBeNull();
            parametersOfDoBatchValidate.Length.ShouldBe(1);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoBatchValidateParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.DoBatchValidateRequest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.DoBatchValidateResponse) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchValidate, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PartnerClient_DoBatchValidate_Method_Overloading_Of_1_Call_Internally(Type[] types)
        {
            var methodDoBatchValidateParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_DirectCall_Overloading_Of_1_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();

            // Act
            Action executeAction = () => _partnerClientInstance.DoBatchValidate(authenticationHeader, batchRequest, out batchResponse);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_DirectCall_Overloading_Of_1_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();
            var returnedValue = default(global::OnyxQASIntegration.PartnerPlatform.Information);

            // Act
            Action executeAction = () => returnedValue = _partnerClientInstance.DoBatchValidate(authenticationHeader, batchRequest, out batchResponse);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Overloading_Of_1_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchResponse) };
            object[] parametersOfDoBatchValidate = { authenticationHeader, batchRequest, batchResponse };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodDoBatchValidate, methodDoBatchValidateParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxQASIntegration.PartnerPlatform.Information>(_partnerClientInstanceFixture, parametersOfDoBatchValidate);
            var result2 = this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoBatchValidate, parametersOfDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfDoBatchValidate.ShouldNotBeNull();
            parametersOfDoBatchValidate.Length.ShouldBe(3);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Overloading_Of_1_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var authenticationHeader = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader>();
            var batchRequest = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchRequest>();
            var batchResponse = this.CreateType<global::OnyxQASIntegration.PartnerPlatform.BatchResponse>();
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchResponse) };
            object[] parametersOfDoBatchValidate = { authenticationHeader, batchRequest, batchResponse };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxQASIntegration.PartnerPlatform.Information>(MethodDoBatchValidate, parametersOfDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            parametersOfDoBatchValidate.ShouldNotBeNull();
            parametersOfDoBatchValidate.Length.ShouldBe(3);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Overloading_Of_1_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchResponse) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodDoBatchValidateParametersTypes.Length.ShouldBe(3);
        }

        #endregion

        #region Method Call : (DoBatchValidate) (Return Type : OnyxQASIntegration.PartnerPlatform.Information) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PartnerClient_DoBatchValidate_Method_Call_Overloading_Of_1_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodDoBatchValidate);
            var methodDoBatchValidateParametersTypes = new Type[] { typeof(global::OnyxQASIntegration.PartnerPlatform.AuthenticationHeader), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchRequest), typeof(global::OnyxQASIntegration.PartnerPlatform.BatchResponse) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodDoBatchValidate, methodDoBatchValidateParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodDoBatchValidateParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #endregion

        #endregion
    }
}