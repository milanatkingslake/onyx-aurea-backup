using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService
{
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishEvent" />)
    ///     and namespace <see cref="NotificationService"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class PublishEventTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="PublishEvent" />)
        /// </summary>
        public PublishEventTest() : base(typeof(PublishEvent))
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

        #region General Initializer : Class (PublishEvent) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _publishEventInstanceType;
        private PublishEvent _publishEventInstance;
        private PublishEvent _publishEventInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="PublishEvent" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _publishEventInstanceType = typeof(PublishEvent);
            _publishEventInstanceFixture = this.Create<PublishEvent>(false);
            _publishEventInstance = _publishEventInstanceFixture ?? this.Create<PublishEvent>(true);
            CurrentInstance = _publishEventInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (PublishEvent) Initializer

        #region Methods

        private const string MethodPublish = "Publish";
        private const string MethodGetStatus = "GetStatus";
        private const string MethodGenericPublish = "GenericPublish";

        #endregion

        #region Fields

        private const string FieldpublishingHelper = "publishingHelper";

        #endregion

        #endregion

        #region General Initializer : Class (PublishEvent) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishEvent_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PublishEvent) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishEvent_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            System.Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (PublishEvent)

        #region General Initializer : Class (PublishEvent) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodPublish, 0)]
        [TestCase(MethodGetStatus, 0)]
        public void AUT_PublishEvent_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (PublishEvent) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldpublishingHelper)]
        [Category("AUT Fields")]
        public void AUT_PublishEvent_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (PublishEvent) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PublishEvent_Is_Instance_Present_Test()
        {
            // Assert
            _publishEventInstanceType.ShouldNotBeNull();
            _publishEventInstance.ShouldNotBeNull();
            _publishEventInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (PublishEvent) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_PublishEvent_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _publishEventInstance.ShouldBeAssignableTo<PublishEvent>();
            _publishEventInstanceFixture.ShouldBeAssignableTo<PublishEvent>();
            CurrentInstance.ShouldBeAssignableTo<PublishEvent>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (PublishEvent) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_PublishEvent_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            PublishEvent instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Publish) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Publish_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<ContextData>();
            var manifest = this.CreateType<EventManifest>();

            // Act
            System.Action executeAction = () => _publishEventInstance.Publish(contextData, manifest);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Publish_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<ContextData>();
            var manifest = this.CreateType<EventManifest>();
            var returnedValue = default(string);

            // Act
            System.Action executeAction = () => returnedValue = _publishEventInstance.Publish(contextData, manifest);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Publish_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<ContextData>();
            var manifest = this.CreateType<EventManifest>();
            var methodPublishParametersTypes = new Type[] { typeof(ContextData), typeof(EventManifest) };
            object[] parametersOfPublish = { contextData, manifest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodPublish, methodPublishParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_publishEventInstanceFixture, parametersOfPublish);
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
        public void AUT_PublishEvent_Publish_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var contextData = this.CreateType<ContextData>();
            var manifest = this.CreateType<EventManifest>();
            var methodPublishParametersTypes = new Type[] { typeof(ContextData), typeof(EventManifest) };
            object[] parametersOfPublish = { contextData, manifest };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<string>(MethodPublish, parametersOfPublish, methodPublishParametersTypes);

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
        public void AUT_PublishEvent_Publish_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var methodPublishParametersTypes = new Type[] { typeof(ContextData), typeof(EventManifest) };

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
        public void AUT_PublishEvent_Publish_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublish);
            var methodPublishParametersTypes = new Type[] { typeof(ContextData), typeof(EventManifest) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPublish, methodPublishParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPublishParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Publish) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Publish_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
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
        public void AUT_PublishEvent_Publish_Method_Call_Parameters_Count_Verification_Test()
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

        #region Method Call : (GetStatus) (Return Type : PublishStatus) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PublishEvent_GetStatus_Method_Call_Internally(Type[] types)
        {
            var methodGetStatusParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<ContextData>();
            var handle = this.CreateType<string>();

            // Act
            System.Action executeAction = () => _publishEventInstance.GetStatus(contextData, handle);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<ContextData>();
            var handle = this.CreateType<string>();
            var returnedValue = default(PublishStatus);

            // Act
            System.Action executeAction = () => returnedValue = _publishEventInstance.GetStatus(contextData, handle);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<ContextData>();
            var handle = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetStatus = { contextData, handle };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, methodGetStatusParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<PublishStatus>(_publishEventInstanceFixture, out exception1, parametersOfGetStatus);
            var result2 = this.GetResultOfMethod<PublishStatus>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(2);
            methodGetStatusParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<ContextData>();
            var handle = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetStatus = { contextData, handle };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, methodGetStatusParametersTypes, out exception);

            // Act
            System.Action currentAction = () => currentMethodInfo.Invoke(_publishEventInstanceFixture, parametersOfGetStatus);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(2);
            methodGetStatusParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var contextData = this.CreateType<ContextData>();
            var handle = this.CreateType<string>();
            var methodGetStatusParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            object[] parametersOfGetStatus = { contextData, handle };

            // Act
            System.Action currentAction = () => this.GetResultOfMethod<PublishStatus>(MethodGetStatus, parametersOfGetStatus, methodGetStatusParametersTypes);

            // Assert
            parametersOfGetStatus.ShouldNotBeNull();
            parametersOfGetStatus.Length.ShouldBe(2);
            methodGetStatusParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var methodGetStatusParametersTypes = new Type[] { typeof(ContextData), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetStatusParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var methodGetStatusParametersTypes = new Type[] { typeof(ContextData), typeof(string) };
            const int parametersCount = 2;

            // Act
            System.Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetStatus, methodGetStatusParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetStatusParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetStatus);
            var currentMethodInfo = this.GetMethodInfo(MethodGetStatus, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetStatus) (Return Type : PublishStatus) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GetStatus_Method_Call_Parameters_Count_Verification_Test()
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
        private void AUT_PublishEvent_GenericPublish_Method_Call_Internally(Type[] types)
        {
            var methodGenericPublishParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGenericPublish, methodGenericPublishParametersTypes);
        }

        #endregion
        
        #region Method Call : (GenericPublish) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_GenericPublish_Method_Call_Parameters_Count_Verification_Test()
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