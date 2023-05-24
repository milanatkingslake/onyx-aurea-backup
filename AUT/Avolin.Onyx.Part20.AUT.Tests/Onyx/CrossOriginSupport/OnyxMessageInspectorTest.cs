using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel;
using System.ServiceModel.Channels;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CrossOriginSupport;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.CrossOriginSupport
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CrossOriginSupport.OnyxMessageInspector" />)
    ///     and namespace <see cref="Onyx.CrossOriginSupport"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxMessageInspectorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxMessageInspector" />)
        /// </summary>
        public OnyxMessageInspectorTest() : base(typeof(OnyxMessageInspector))
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

        #region General Initializer : Class (OnyxMessageInspector) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxMessageInspectorInstanceType;
        private OnyxMessageInspector _onyxMessageInspectorInstance;
        private OnyxMessageInspector _onyxMessageInspectorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxMessageInspector" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxMessageInspectorInstanceType = typeof(OnyxMessageInspector);
            _onyxMessageInspectorInstanceFixture = this.Create<OnyxMessageInspector>(false);
            _onyxMessageInspectorInstance = _onyxMessageInspectorInstanceFixture ?? this.Create<OnyxMessageInspector>(true);
            CurrentInstance = _onyxMessageInspectorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxMessageInspector) Initializer

        #region Methods

        private const string MethodAfterReceiveRequest = "AfterReceiveRequest";
        private const string MethodBeforeSendReply = "BeforeSendReply";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxMessageInspector) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMessageInspector_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region General Initializer : Class (OnyxMessageInspector) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxMessageInspector_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxMessageInspector)

        #region General Initializer : Class (OnyxMessageInspector) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodAfterReceiveRequest, 0)]
        [TestCase(MethodBeforeSendReply, 0)]
        public void AUT_OnyxMessageInspector_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (OnyxMessageInspector) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_OnyxMessageInspector_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxMessageInspector) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMessageInspector_Is_Instance_Present_Test()
        {
            // Assert
            _onyxMessageInspectorInstanceType.ShouldNotBeNull();
            _onyxMessageInspectorInstance.ShouldNotBeNull();
            _onyxMessageInspectorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxMessageInspector) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxMessageInspector" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxMessageInspector_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxMessageInspectorInstance.ShouldBeAssignableTo<OnyxMessageInspector>();
            _onyxMessageInspectorInstanceFixture.ShouldBeAssignableTo<OnyxMessageInspector>();
            CurrentInstance.ShouldBeAssignableTo<OnyxMessageInspector>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxMessageInspector) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxMessageInspector_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxMessageInspector instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (AfterReceiveRequest) (Return Type : object) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var request = this.CreateType<Message>();
            var channel = this.CreateType<IClientChannel>();
            var instanceContext = this.CreateType<InstanceContext>();

            // Act
            Action executeAction = () => _onyxMessageInspectorInstance.AfterReceiveRequest(ref request, channel, instanceContext);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (AfterReceiveRequest) (Return Type : object) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var request = this.CreateType<Message>();
            var channel = this.CreateType<IClientChannel>();
            var instanceContext = this.CreateType<InstanceContext>();
            var returnedValue = default(object);

            // Act
            Action executeAction = () => returnedValue = _onyxMessageInspectorInstance.AfterReceiveRequest(ref request, channel, instanceContext);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AfterReceiveRequest) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var request = this.CreateType<Message>();
            var channel = this.CreateType<IClientChannel>();
            var instanceContext = this.CreateType<InstanceContext>();
            var methodAfterReceiveRequestParametersTypes = new Type[] { typeof(Message), typeof(IClientChannel), typeof(InstanceContext) };
            object[] parametersOfAfterReceiveRequest = { request, channel, instanceContext };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodAfterReceiveRequest, methodAfterReceiveRequestParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<object>(_onyxMessageInspectorInstanceFixture, parametersOfAfterReceiveRequest);
            var result2 = this.GetResultOfMethod<object>(MethodAfterReceiveRequest, parametersOfAfterReceiveRequest, methodAfterReceiveRequestParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfAfterReceiveRequest.ShouldNotBeNull();
            parametersOfAfterReceiveRequest.Length.ShouldBe(3);
            methodAfterReceiveRequestParametersTypes.Length.ShouldBe(3);
        }

        #endregion
        
        #region Method Call : (AfterReceiveRequest) (Return Type : object) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var request = this.CreateType<Message>();
            var channel = this.CreateType<IClientChannel>();
            var instanceContext = this.CreateType<InstanceContext>();
            var methodAfterReceiveRequestParametersTypes = new Type[] { typeof(Message), typeof(IClientChannel), typeof(InstanceContext) };
            object[] parametersOfAfterReceiveRequest = { request, channel, instanceContext };

            // Act
            Action currentAction = () => this.GetResultOfMethod<object>(MethodAfterReceiveRequest, parametersOfAfterReceiveRequest, methodAfterReceiveRequestParametersTypes);

            // Assert
            parametersOfAfterReceiveRequest.ShouldNotBeNull();
            parametersOfAfterReceiveRequest.Length.ShouldBe(3);
            methodAfterReceiveRequestParametersTypes.Length.ShouldBe(3);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (AfterReceiveRequest) (Return Type : object) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var methodAfterReceiveRequestParametersTypes = new Type[] { typeof(Message), typeof(IClientChannel), typeof(InstanceContext) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodAfterReceiveRequest, methodAfterReceiveRequestParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodAfterReceiveRequestParametersTypes.Length.ShouldBe(3);
        }

        #endregion
        
        #region Method Call : (AfterReceiveRequest) (Return Type : object) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var methodAfterReceiveRequestParametersTypes = new Type[] { typeof(Message), typeof(IClientChannel), typeof(InstanceContext) };
            const int parametersCount = 3;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodAfterReceiveRequest, methodAfterReceiveRequestParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodAfterReceiveRequestParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (AfterReceiveRequest) (Return Type : object) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodAfterReceiveRequest, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (AfterReceiveRequest) (Return Type : object) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_AfterReceiveRequest_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodAfterReceiveRequest);
            var currentMethodInfo = this.GetMethodInfo(MethodAfterReceiveRequest, 0);
            const int parametersCount = 3;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_Internally(Type[] types)
        {
            var methodBeforeSendReplyParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodBeforeSendReply, methodBeforeSendReplyParametersTypes);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var reply = this.CreateType<Message>();
            var correlationState = this.CreateType<object>();

            // Act
            Action executeAction = () => _onyxMessageInspectorInstance.BeforeSendReply(ref reply, correlationState);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion
        
        #region Method Call : (BeforeSendReply) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var reply = this.CreateType<Message>();
            var correlationState = this.CreateType<object>();
            var methodBeforeSendReplyParametersTypes = new Type[] { typeof(Message), typeof(object) };
            object[] parametersOfBeforeSendReply = { reply, correlationState };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodBeforeSendReply, methodBeforeSendReplyParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxMessageInspectorInstanceFixture, parametersOfBeforeSendReply);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfBeforeSendReply.ShouldNotBeNull();
            parametersOfBeforeSendReply.Length.ShouldBe(2);
            methodBeforeSendReplyParametersTypes.Length.ShouldBe(2);
            methodBeforeSendReplyParametersTypes.Length.ShouldBe(parametersOfBeforeSendReply.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var reply = this.CreateType<Message>();
            var correlationState = this.CreateType<object>();
            var methodBeforeSendReplyParametersTypes = new Type[] { typeof(Message), typeof(object) };
            object[] parametersOfBeforeSendReply = { reply, correlationState };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodBeforeSendReply, parametersOfBeforeSendReply, methodBeforeSendReplyParametersTypes);

            // Assert
            parametersOfBeforeSendReply.ShouldNotBeNull();
            parametersOfBeforeSendReply.Length.ShouldBe(2);
            methodBeforeSendReplyParametersTypes.Length.ShouldBe(2);
            methodBeforeSendReplyParametersTypes.Length.ShouldBe(parametersOfBeforeSendReply.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var currentMethodInfo = this.GetMethodInfo(MethodBeforeSendReply, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var methodBeforeSendReplyParametersTypes = new Type[] { typeof(Message), typeof(object) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodBeforeSendReply, methodBeforeSendReplyParametersTypes);

            // Assert
            methodBeforeSendReplyParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (BeforeSendReply) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxMessageInspector_BeforeSendReply_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodBeforeSendReply);
            var currentMethodInfo = this.GetMethodInfo(MethodBeforeSendReply, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #endregion

        #endregion
    }
}