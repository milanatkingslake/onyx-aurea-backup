using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.Extensions.BaseSetup.Version.V3;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxMessageSubsystem.SubscribeNotificationServices;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.OnyxMessageSubsystem.SubscribeNotificationServices
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxMessageSubsystem.SubscribeNotificationServices.PublishEventClient" />)
    ///     and namespace <see cref="OnyxMessageSubsystem.SubscribeNotificationServices"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public partial class PublishEventClientTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PublishEventClient" />)
        /// </summary>
        public PublishEventClientTest() : base(typeof(PublishEventClient))
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

        #region General Initializer : Class (PublishEventClient) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _publishEventClientInstanceType;
        private PublishEventClient _publishEventClientInstance;
        private PublishEventClient _publishEventClientInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PublishEventClient" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _publishEventClientInstanceType = typeof(PublishEventClient);
            _publishEventClientInstanceFixture = this.Create<PublishEventClient>(false);
            _publishEventClientInstance = _publishEventClientInstanceFixture ?? this.Create<PublishEventClient>(true);
            CurrentInstance = _publishEventClientInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PublishEventClient) Initializer

        #region Methods

        private const string MethodPublish = "Publish";
        private const string MethodGetStatus = "GetStatus";
        private const string MethodGenericPublish = "GenericPublish";

        #endregion

        #endregion

        #region General Initializer : Class (PublishEventClient) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PublishEventClient" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishEventClient_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PublishEventClient)

        #region General Initializer : Class (PublishEventClient) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PublishEventClient" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPublish, 0)]
        [TestCase(MethodGetStatus, 0)]
        [TestCase(MethodGenericPublish, 0)]
        public void AUT_PublishEventClient_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (PublishEventClient) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PublishEventClient" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PublishEventClient_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _publishEventClientInstance.ShouldBeAssignableTo<PublishEventClient>();
            _publishEventClientInstanceFixture.ShouldBeAssignableTo<PublishEventClient>();
            CurrentInstance.ShouldBeAssignableTo<PublishEventClient>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PublishEventClient) constructors coverage gain tests

        /// <summary>
        ///     Explore and verify all constructors of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_All_Constructors_Explore_Verify_Test()
        {
            // Act
            Action currentAction = this.ExploreVerifyEveryConstructorsWithoutException;

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Constructor : Class (PublishEventClient) constructors with dynamic parameters () coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_Constructors_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            Type [] methodPublishEventClientParametersTypes = null;

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPublishEventClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PublishEventClient) constructors with dynamic parameters (Overloading_Of_1_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_Constructors_Overloading_Of_1_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPublishEventClientParametersTypes = new Type[] { typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPublishEventClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PublishEventClient) constructors with dynamic parameters (Overloading_Of_2_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_Constructors_Overloading_Of_2_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPublishEventClientParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPublishEventClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PublishEventClient) constructors with dynamic parameters (Overloading_Of_3_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_Constructors_Overloading_Of_3_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPublishEventClientParametersTypes = new Type[] { typeof(string), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPublishEventClientParametersTypes);
        }

        #endregion

        #region General Constructor : Class (PublishEventClient) constructors with dynamic parameters (Overloading_Of_4_) coverage gain tests

        /// <summary>
        ///     Explore and verify constructors (with / without parameter) of Class (<see cref="PublishEventClient" />).
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEventClient_Constructors_Overloading_Of_4_With_Dynamic_Explore_Verify_Test()
        {
            // Arrange
            var methodPublishEventClientParametersTypes = new Type[] { typeof(System.ServiceModel.Channels.Binding), typeof(System.ServiceModel.EndpointAddress) };

            // Assert
            this.ExploreVerifyConstructorByGivenParametersType(methodPublishEventClientParametersTypes);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Publish) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var manifest = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest>();

            // Act
            Action executeAction = () => _publishEventClientInstance.Publish(contextData, manifest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var manifest = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _publishEventClientInstance.Publish(contextData, manifest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var manifest = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest>();
            var methodPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest) };
            object[] parametersOfPublish = { contextData, manifest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPublish, methodPublishParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_publishEventClientInstanceFixture, parametersOfPublish);
            var result2 = this.GetResultOfMethod<string>(MethodPublish, parametersOfPublish, methodPublishParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfPublish.ShouldNotBeNull();
            parametersOfPublish.Length.ShouldBe(2);
            methodPublishParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var manifest = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest>();
            var methodPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest) };
            object[] parametersOfPublish = { contextData, manifest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodPublish, parametersOfPublish, methodPublishParametersTypes);

            // Assert
            parametersOfPublish.ShouldNotBeNull();
            parametersOfPublish.Length.ShouldBe(2);
            methodPublishParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var methodPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodPublish, methodPublishParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodPublishParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var methodPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.EventManifest) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPublish, methodPublishParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPublishParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var currentMethodInfo = this.GetMethodInfo(MethodPublish, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_Publish_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var currentMethodInfo = this.GetMethodInfo(MethodPublish, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PublishEventClient_GetStatus_Method_Call_Internally(Type[] types)
        {
            var methodGetStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var handle = this.CreateType<string>();

            // Act
            Action executeAction = () => _publishEventClientInstance.GetStatus(contextData, handle);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var handle = this.CreateType<string>();
            var returnedValue = default(global::OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus);

            // Act
            Action executeAction = () => returnedValue = _publishEventClientInstance.GetStatus(contextData, handle);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var handle = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGetStatus = { contextData, handle };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, methodGetStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<global::OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus>(_publishEventClientInstanceFixture, parametersOfGetStatus);
            var result2 = this.GetResultOfMethod<global::OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(2);
            methodGetStatusParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var handle = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGetStatus = { contextData, handle };

            // Act
            Action currentAction = () => this.GetResultOfMethod<global::OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(2);
            methodGetStatusParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var methodGetStatusParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetStatusParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var methodGetStatusParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : OnyxMessageSubsystem.SubscribeNotificationServices.PublishStatus) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GetStatus_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PublishEventClient_GenericPublish_Method_Call_Internally(Type[] types)
        {
            var methodGenericPublishParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenericPublish, methodGenericPublishParametersTypes);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var eventData = this.CreateType<string>();

            // Act
            Action executeAction = () => _publishEventClientInstance.GenericPublish(contextData, eventData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var eventData = this.CreateType<string>();
            var methodGenericPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGenericPublish = { contextData, eventData };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGenericPublish, methodGenericPublishParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_publishEventClientInstanceFixture, parametersOfGenericPublish);
            var result2 = this.GetResultOfMethod<bool>(MethodGenericPublish, parametersOfGenericPublish, methodGenericPublishParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenericPublish.ShouldNotBeNull();
            parametersOfGenericPublish.Length.ShouldBe(2);
            methodGenericPublishParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var eventData = this.CreateType<string>();
            var methodGenericPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGenericPublish = { contextData, eventData };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGenericPublish, methodGenericPublishParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_publishEventClientInstanceFixture, out exception1, parametersOfGenericPublish);
            var result2 = this.GetResultOfMethod<bool>(MethodGenericPublish, parametersOfGenericPublish, methodGenericPublishParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGenericPublish.ShouldNotBeNull();
            parametersOfGenericPublish.Length.ShouldBe(2);
            methodGenericPublishParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var contextData = this.CreateType<global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData>();
            var eventData = this.CreateType<string>();
            var methodGenericPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            object[] parametersOfGenericPublish = { contextData, eventData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodGenericPublish, parametersOfGenericPublish, methodGenericPublishParametersTypes);

            // Assert
            parametersOfGenericPublish.ShouldNotBeNull();
            parametersOfGenericPublish.Length.ShouldBe(2);
            methodGenericPublishParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var methodGenericPublishParametersTypes = new Type[] { typeof(global::OnyxMessageSubsystem.SubscribeNotificationServices.ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGenericPublish, methodGenericPublishParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGenericPublishParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var currentMethodInfo = this.GetMethodInfo(MethodGenericPublish, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GenericPublish) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEventClient_GenericPublish_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGenericPublish);
            var currentMethodInfo = this.GetMethodInfo(MethodGenericPublish, 0);
            const int parametersCount = 2;

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