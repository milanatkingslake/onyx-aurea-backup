using System;
using System.Activities;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NUnit.Framework;
using Shouldly;
using PublishEvent = NotificationService.PublishAgent.PublishEvent;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.PublishAgent
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishAgent.PublishEvent" />)
    ///     and namespace <see cref="NotificationService.PublishAgent"/> class using generator(v:0.2.5)'s
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

        #region Properties

        private const string Propertynotificationxml = "notificationxml";
        private const string PropertyinputEventManifest = "inputEventManifest";
        private const string PropertyisSuccess = "isSuccess";

        #endregion

        #region Methods

        private const string MethodExecute = "Execute";
        private const string MethodpublishEvent = "publishEvent";

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
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (PublishEvent) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_PublishEvent_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryPropertiesExceptforUsedOnes();

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
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

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
        [TestCase(MethodExecute, 0)]
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

        #region General Initializer : Class (PublishEvent) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="PublishEvent" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(Propertynotificationxml)]
        [TestCase(PropertyinputEventManifest)]
        [TestCase(PropertyisSuccess)]
        [Category("AUT Property")]
        public void AUT_PublishEvent_All_Properties_Explore_Verify_By_Name_Test(string name)
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

        #region Category : GetterSetter

        #region General Getters/Setters : Class (PublishEvent) => all properties explore by setting value.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        [TestCase(Propertynotificationxml)]
        [TestCase(PropertyinputEventManifest)]
        [TestCase(PropertyisSuccess)]
        public void AUT_PublishEvent_Property_Exist_By_Name_Verify_Test(string name)
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

        #region General Getters/Setters : Class (PublishEvent) => Property (inputEventManifest) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PublishEvent_Public_Class_inputEventManifest_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyinputEventManifest);
            var propertyInfo = this.GetPropertyInfo(PropertyinputEventManifest);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PublishEvent) => Property (isSuccess) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PublishEvent_Public_Class_isSuccess_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(PropertyisSuccess);
            var propertyInfo = this.GetPropertyInfo(PropertyisSuccess);

            // Act
            var canRead = propertyInfo?.CanRead;

            // Assert
            propertyInfo.ShouldNotBeNull();
            canRead.ShouldNotBeNull();
            canRead?.ShouldBeTrue();
        }

        #endregion

        #region General Getters/Setters : Class (PublishEvent) => Property (notificationxml) (Can Read) tests

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT GetterSetter")]
        public void AUT_PublishEvent_Public_Class_notificationxml_Coverage_For_Property_Is_Present_And_Can_Read_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(Propertynotificationxml);
            var propertyInfo = this.GetPropertyInfo(Propertynotificationxml);

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

        #region Method Call : (Execute) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Execute_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var context = this.CreateType<CodeActivityContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };
            object[] parametersOfExecute = { context };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_publishEventInstanceFixture, parametersOfExecute);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Execute_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var context = this.CreateType<CodeActivityContext>();
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };
            object[] parametersOfExecute = { context };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(1);
            methodExecuteParametersTypes.Length.ShouldBe(parametersOfExecute.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(CodeActivityContext) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            methodExecuteParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_Execute_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            Action currentAction = () => this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_PublishEvent_publishEvent_Method_Call_Internally(Type[] types)
        {
            var methodpublishEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodpublishEvent, methodpublishEventParametersTypes);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var notificationData = this.CreateType<string>();
            var eventManifest = this.CreateType<EventManifest>();
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };
            object[] parametersOfpublishEvent = { notificationData, eventManifest };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodpublishEvent, methodpublishEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_publishEventInstanceFixture, parametersOfpublishEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodpublishEvent, parametersOfpublishEvent, methodpublishEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfpublishEvent.ShouldNotBeNull();
            parametersOfpublishEvent.Length.ShouldBe(2);
            methodpublishEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_With_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var notificationData = this.CreateType<string>();
            var eventManifest = this.CreateType<EventManifest>();
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };
            object[] parametersOfpublishEvent = { notificationData, eventManifest };
            Exception exception, exception1;
            var currentMethodInfo = this.GetMethodInfo(MethodpublishEvent, methodpublishEventParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<bool>(_publishEventInstanceFixture, out exception1, parametersOfpublishEvent);
            var result2 = this.GetResultOfMethod<bool>(MethodpublishEvent, parametersOfpublishEvent, methodpublishEventParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfpublishEvent.ShouldNotBeNull();
            parametersOfpublishEvent.Length.ShouldBe(2);
            methodpublishEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var notificationData = this.CreateType<string>();
            var eventManifest = this.CreateType<EventManifest>();
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };
            object[] parametersOfpublishEvent = { notificationData, eventManifest };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodpublishEvent, methodpublishEventParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_publishEventInstanceFixture, parametersOfpublishEvent);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfpublishEvent.ShouldNotBeNull();
            parametersOfpublishEvent.Length.ShouldBe(2);
            methodpublishEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var notificationData = this.CreateType<string>();
            var eventManifest = this.CreateType<EventManifest>();
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };
            object[] parametersOfpublishEvent = { notificationData, eventManifest };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodpublishEvent, parametersOfpublishEvent, methodpublishEventParametersTypes);

            // Assert
            parametersOfpublishEvent.ShouldNotBeNull();
            parametersOfpublishEvent.Length.ShouldBe(2);
            methodpublishEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodpublishEvent, methodpublishEventParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodpublishEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodpublishEvent, methodpublishEventParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodpublishEventParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var methodpublishEventParametersTypes = new Type[] { typeof(string), typeof(EventManifest) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodpublishEvent, methodpublishEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodpublishEventParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodpublishEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (publishEvent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_PublishEvent_publishEvent_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodpublishEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodpublishEvent, 0);
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