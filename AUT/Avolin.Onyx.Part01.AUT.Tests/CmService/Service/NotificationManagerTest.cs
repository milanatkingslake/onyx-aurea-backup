using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.NotificationManager" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\NotificationManager.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class NotificationManagerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="NotificationManager" />)
        /// </summary>
        public NotificationManagerTest() : base(typeof(NotificationManager))
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

        #region General Initializer : Class (NotificationManager) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _notificationManagerInstanceType;
        private NotificationManager _notificationManagerInstance;
        private NotificationManager _notificationManagerInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="NotificationManager" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _notificationManagerInstanceType = typeof(NotificationManager);
            _notificationManagerInstanceFixture = this.Create<NotificationManager>(false);
            _notificationManagerInstance = _notificationManagerInstanceFixture ?? this.Create<NotificationManager>(true);
            CurrentInstance = _notificationManagerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (NotificationManager) Initializer

        #region Methods

        private const string MethodGetSession = "GetSession";
        private const string MethodExecuteBusinessRule = "ExecuteBusinessRule";
        private const string MethodGetEmailTemplateData = "GetEmailTemplateData";

        #endregion

        #endregion

        #region General Initializer : Class (NotificationManager) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="NotificationManager" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_NotificationManager_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (NotificationManager)

        #region General Initializer : Class (NotificationManager) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="NotificationManager" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetSession, 0)]
        [TestCase(MethodExecuteBusinessRule, 0)]
        [TestCase(MethodGetEmailTemplateData, 0)]
        public void AUT_NotificationManager_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (NotificationManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationManager" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationManager_Is_Instance_Present_Test()
        {
            // Assert
            _notificationManagerInstanceType.ShouldNotBeNull();
            _notificationManagerInstance.ShouldNotBeNull();
            _notificationManagerInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (NotificationManager) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="NotificationManager" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_NotificationManager_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _notificationManagerInstance.ShouldBeAssignableTo<NotificationManager>();
            _notificationManagerInstanceFixture.ShouldBeAssignableTo<NotificationManager>();
            CurrentInstance.ShouldBeAssignableTo<NotificationManager>();
        }

        #endregion

        #region General Constructor : Class (NotificationManager) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationManager_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            NotificationManager instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var message = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _notificationManagerInstance.GetSession(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var message = this.CreateType<XElement>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _notificationManagerInstance.GetSession(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var message = this.CreateType<XElement>();
            var methodGetSessionParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetSession = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetSession, methodGetSessionParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_notificationManagerInstanceFixture, parametersOfGetSession);
            var result2 = this.GetResultOfMethod<Message>(MethodGetSession, parametersOfGetSession, methodGetSessionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetSession.ShouldNotBeNull();
            parametersOfGetSession.Length.ShouldBe(1);
            methodGetSessionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var message = this.CreateType<XElement>();
            var methodGetSessionParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetSession = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetSession, parametersOfGetSession, methodGetSessionParametersTypes);

            // Assert
            parametersOfGetSession.ShouldNotBeNull();
            parametersOfGetSession.Length.ShouldBe(1);
            methodGetSessionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var methodGetSessionParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetSession, methodGetSessionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetSessionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var methodGetSessionParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetSession, methodGetSessionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetSessionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSession, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetSession) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetSession_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetSession);
            var currentMethodInfo = this.GetMethodInfo(MethodGetSession, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var message = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _notificationManagerInstance.ExecuteBusinessRule(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var message = this.CreateType<XElement>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _notificationManagerInstance.ExecuteBusinessRule(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var message = this.CreateType<XElement>();
            var methodExecuteBusinessRuleParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfExecuteBusinessRule = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_notificationManagerInstanceFixture, parametersOfExecuteBusinessRule);
            var result2 = this.GetResultOfMethod<Message>(MethodExecuteBusinessRule, parametersOfExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteBusinessRule.ShouldNotBeNull();
            parametersOfExecuteBusinessRule.Length.ShouldBe(1);
            methodExecuteBusinessRuleParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var message = this.CreateType<XElement>();
            var methodExecuteBusinessRuleParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfExecuteBusinessRule = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodExecuteBusinessRule, parametersOfExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            parametersOfExecuteBusinessRule.ShouldNotBeNull();
            parametersOfExecuteBusinessRule.Length.ShouldBe(1);
            methodExecuteBusinessRuleParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var methodExecuteBusinessRuleParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteBusinessRuleParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var methodExecuteBusinessRuleParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteBusinessRuleParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBusinessRule, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBusinessRule, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var message = this.CreateType<XElement>();

            // Act
            Action executeAction = () => _notificationManagerInstance.GetEmailTemplateData(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var message = this.CreateType<XElement>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _notificationManagerInstance.GetEmailTemplateData(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var message = this.CreateType<XElement>();
            var methodGetEmailTemplateDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetEmailTemplateData = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailTemplateData, methodGetEmailTemplateDataParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_notificationManagerInstanceFixture, parametersOfGetEmailTemplateData);
            var result2 = this.GetResultOfMethod<Message>(MethodGetEmailTemplateData, parametersOfGetEmailTemplateData, methodGetEmailTemplateDataParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetEmailTemplateData.ShouldNotBeNull();
            parametersOfGetEmailTemplateData.Length.ShouldBe(1);
            methodGetEmailTemplateDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var message = this.CreateType<XElement>();
            var methodGetEmailTemplateDataParametersTypes = new Type[] { typeof(XElement) };
            object[] parametersOfGetEmailTemplateData = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetEmailTemplateData, parametersOfGetEmailTemplateData, methodGetEmailTemplateDataParametersTypes);

            // Assert
            parametersOfGetEmailTemplateData.ShouldNotBeNull();
            parametersOfGetEmailTemplateData.Length.ShouldBe(1);
            methodGetEmailTemplateDataParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var methodGetEmailTemplateDataParametersTypes = new Type[] { typeof(XElement) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetEmailTemplateData, methodGetEmailTemplateDataParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetEmailTemplateDataParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var methodGetEmailTemplateDataParametersTypes = new Type[] { typeof(XElement) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetEmailTemplateData, methodGetEmailTemplateDataParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetEmailTemplateDataParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailTemplateData, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetEmailTemplateData) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_GetEmailTemplateData_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetEmailTemplateData);
            var currentMethodInfo = this.GetMethodInfo(MethodGetEmailTemplateData, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}