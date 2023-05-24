using System;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.NotificationManager" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
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

        private const string MethodExecuteBusinessRule = "ExecuteBusinessRule";

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
        [TestCase(MethodExecuteBusinessRule, 0)]
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

        #endregion

        #region Category : Instance

        #region General Instance : Class (NotificationManager) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="NotificationManager" />) can be created test
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

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (NotificationManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationManager_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            NotificationManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NotificationManager(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _notificationManagerInstance.ShouldNotBeNull();
            _notificationManagerInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<NotificationManager>();
        }

        #endregion

        #region General Constructor : Class (NotificationManager) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_NotificationManager_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            NotificationManager instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new NotificationManager(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _notificationManagerInstance.ShouldNotBeNull();
            _notificationManagerInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);

            // Act
            Action executeAction = () => _notificationManagerInstance.ExecuteBusinessRule();

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            var returnedValue = default(XElement);

            // Act
            Action executeAction = () => returnedValue = _notificationManagerInstance.ExecuteBusinessRule();
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            Type [] methodExecuteBusinessRuleParametersTypes = null;
            object[] parametersOfExecuteBusinessRule = null; // no parameter present
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_notificationManagerInstanceFixture, parametersOfExecuteBusinessRule);
            var result2 = this.GetResultOfMethod<XElement>(MethodExecuteBusinessRule, parametersOfExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecuteBusinessRule.ShouldBeNull();
            methodExecuteBusinessRuleParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            Type [] methodExecuteBusinessRuleParametersTypes = null;
            object[] parametersOfExecuteBusinessRule = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodExecuteBusinessRule, parametersOfExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            parametersOfExecuteBusinessRule.ShouldBeNull();
            methodExecuteBusinessRuleParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            Type [] methodExecuteBusinessRuleParametersTypes = null;

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteBusinessRuleParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_NotificationManager_ExecuteBusinessRule_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecuteBusinessRule);
            Type [] methodExecuteBusinessRuleParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecuteBusinessRule, methodExecuteBusinessRuleParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteBusinessRuleParametersTypes.ShouldBeNull();
        }

        #endregion

        #region Method Call : (ExecuteBusinessRule) (Return Type : XElement) without parameters value verify result should be null.

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

        #endregion

        #endregion
    }
}