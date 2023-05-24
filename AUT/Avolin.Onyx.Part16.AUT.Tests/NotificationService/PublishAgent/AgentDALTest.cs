using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService;
using NotificationService.DAL;
using NotificationService.PublishAgent;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.PublishAgent
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.PublishAgent.AgentDAL" />)
    ///     and namespace <see cref="NotificationService.PublishAgent"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AgentDALTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="AgentDAL" />)
        /// </summary>
        public AgentDALTest() : base(typeof(AgentDAL))
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

        #region General Initializer : Class (AgentDAL) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _agentDALInstanceType;
        private AgentDAL _agentDALInstance;
        private AgentDAL _agentDALInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="AgentDAL" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _agentDALInstanceType = typeof(AgentDAL);
            _agentDALInstanceFixture = this.Create<AgentDAL>(false);
            _agentDALInstance = _agentDALInstanceFixture ?? this.Create<AgentDAL>(true);
            CurrentInstance = _agentDALInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (AgentDAL) Initializer

        #region Methods

        private const string MethodGetListOfSubscription = "GetListOfSubscription";
        private const string MethodGetListOfSubscriptionExt = "GetListOfSubscriptionExt";
        private const string MethodGetProfileFileName = "GetProfileFileName";
        private const string MethodPublishOutlookEvent = "PublishOutlookEvent";

        #endregion

        #region Fields

        private const string FieldconnectionString = "connectionString";
        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region General Initializer : Class (AgentDAL) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="AgentDAL" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AgentDAL_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region General Initializer : Class (AgentDAL) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="AgentDAL" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_AgentDAL_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (AgentDAL)

        #region General Initializer : Class (AgentDAL) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="AgentDAL" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetListOfSubscription, 0)]
        [TestCase(MethodGetListOfSubscriptionExt, 0)]
        [TestCase(MethodGetProfileFileName, 0)]
        [TestCase(MethodPublishOutlookEvent, 0)]
        public void AUT_AgentDAL_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (AgentDAL) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="AgentDAL" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldconnectionString)]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_AgentDAL_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (AgentDAL) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="AgentDAL" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_AgentDAL_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _agentDALInstance.ShouldBeAssignableTo<AgentDAL>();
            _agentDALInstanceFixture.ShouldBeAssignableTo<AgentDAL>();
            CurrentInstance.ShouldBeAssignableTo<AgentDAL>();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var eventManifestValue = this.CreateType<EventManifest>();

            // Act
            Action executeAction = () => AgentDAL.GetListOfSubscription(eventManifestValue);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var eventManifestValue = this.CreateType<EventManifest>();
            var returnedValue = default(List<NotificationSubscription>);

            // Act
            Action executeAction = () => returnedValue = AgentDAL.GetListOfSubscription(eventManifestValue);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var eventManifestValue = this.CreateType<EventManifest>();
            var methodGetListOfSubscriptionParametersTypes = new Type[] { typeof(EventManifest) };
            object[] parametersOfGetListOfSubscription = { eventManifestValue };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscription, methodGetListOfSubscriptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscription, methodGetListOfSubscriptionParametersTypes);
            var result2 = this.GetResultOfMethod<List<NotificationSubscription>>(MethodGetListOfSubscription, parametersOfGetListOfSubscription, methodGetListOfSubscriptionParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_agentDALInstanceFixture, parametersOfGetListOfSubscription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetListOfSubscription.ShouldNotBeNull();
            parametersOfGetListOfSubscription.Length.ShouldBe(1);
            methodGetListOfSubscriptionParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var eventManifestValue = this.CreateType<EventManifest>();
            var methodGetListOfSubscriptionParametersTypes = new Type[] { typeof(EventManifest) };
            object[] parametersOfGetListOfSubscription = { eventManifestValue };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<NotificationSubscription>>(MethodGetListOfSubscription, parametersOfGetListOfSubscription, methodGetListOfSubscriptionParametersTypes);

            // Assert
            parametersOfGetListOfSubscription.ShouldNotBeNull();
            parametersOfGetListOfSubscription.Length.ShouldBe(1);
            methodGetListOfSubscriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var methodGetListOfSubscriptionParametersTypes = new Type[] { typeof(EventManifest) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscription, methodGetListOfSubscriptionParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetListOfSubscriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var methodGetListOfSubscriptionParametersTypes = new Type[] { typeof(EventManifest) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscription, methodGetListOfSubscriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListOfSubscriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListOfSubscription) (Return Type : List<NotificationSubscription>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscription);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscription, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetListOfSubscriptionExtParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var Subscription = this.CreateType<List<NotificationSubscription>>();

            // Act
            Action executeAction = () => AgentDAL.GetListOfSubscriptionExt(Subscription);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var Subscription = this.CreateType<List<NotificationSubscription>>();
            var returnedValue = default(List<NotificationSubscriptionForwarded>);

            // Act
            Action executeAction = () => returnedValue = AgentDAL.GetListOfSubscriptionExt(Subscription);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var Subscription = this.CreateType<List<NotificationSubscription>>();
            var methodGetListOfSubscriptionExtParametersTypes = new Type[] { typeof(List<NotificationSubscription>) };
            object[] parametersOfGetListOfSubscriptionExt = { Subscription };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);
            var result2 = this.GetResultOfMethod<List<NotificationSubscriptionForwarded>>(MethodGetListOfSubscriptionExt, parametersOfGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_agentDALInstanceFixture, parametersOfGetListOfSubscriptionExt);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetListOfSubscriptionExt.ShouldNotBeNull();
            parametersOfGetListOfSubscriptionExt.Length.ShouldBe(1);
            methodGetListOfSubscriptionExtParametersTypes.Length.ShouldBe(1);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var Subscription = this.CreateType<List<NotificationSubscription>>();
            var methodGetListOfSubscriptionExtParametersTypes = new Type[] { typeof(List<NotificationSubscription>) };
            object[] parametersOfGetListOfSubscriptionExt = { Subscription };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<NotificationSubscriptionForwarded>>(MethodGetListOfSubscriptionExt, parametersOfGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);

            // Assert
            parametersOfGetListOfSubscriptionExt.ShouldNotBeNull();
            parametersOfGetListOfSubscriptionExt.Length.ShouldBe(1);
            methodGetListOfSubscriptionExtParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var methodGetListOfSubscriptionExtParametersTypes = new Type[] { typeof(List<NotificationSubscription>) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetListOfSubscriptionExtParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var methodGetListOfSubscriptionExtParametersTypes = new Type[] { typeof(List<NotificationSubscription>) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetListOfSubscriptionExt, methodGetListOfSubscriptionExtParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetListOfSubscriptionExtParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscriptionExt, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetListOfSubscriptionExt) (Return Type : List<NotificationSubscriptionForwarded>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetListOfSubscriptionExt_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetListOfSubscriptionExt);
            var currentMethodInfo = this.GetMethodInfo(MethodGetListOfSubscriptionExt, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_Internally(Type[] types)
        {
            var methodGetProfileFileNameParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetProfileFileName, methodGetProfileFileNameParametersTypes);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var notificationSecondaryId = this.CreateType<int>();
            var siteid = this.CreateType<int>();

            // Act
            Action executeAction = () => AgentDAL.GetProfileFileName(notificationSecondaryId, siteid);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var notificationSecondaryId = this.CreateType<int>();
            var siteid = this.CreateType<int>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = AgentDAL.GetProfileFileName(notificationSecondaryId, siteid);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Generic Method Results Should Be Null If Not Premitive Type Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_With_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var notificationSecondaryId = this.CreateType<int>();
            var siteid = this.CreateType<int>();
            var methodGetProfileFileNameParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetProfileFileName = { notificationSecondaryId, siteid };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileFileName, methodGetProfileFileNameParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetProfileFileName, methodGetProfileFileNameParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetProfileFileName, parametersOfGetProfileFileName, methodGetProfileFileNameParametersTypes);
            Action currentAction = () => currentMethodInfo.Invoke(_agentDALInstanceFixture, parametersOfGetProfileFileName);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetProfileFileName.ShouldNotBeNull();
            parametersOfGetProfileFileName.Length.ShouldBe(2);
            methodGetProfileFileNameParametersTypes.Length.ShouldBe(2);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var notificationSecondaryId = this.CreateType<int>();
            var siteid = this.CreateType<int>();
            var methodGetProfileFileNameParametersTypes = new Type[] { typeof(int), typeof(int) };
            object[] parametersOfGetProfileFileName = { notificationSecondaryId, siteid };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetProfileFileName, parametersOfGetProfileFileName, methodGetProfileFileNameParametersTypes);

            // Assert
            parametersOfGetProfileFileName.ShouldNotBeNull();
            parametersOfGetProfileFileName.Length.ShouldBe(2);
            methodGetProfileFileNameParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var methodGetProfileFileNameParametersTypes = new Type[] { typeof(int), typeof(int) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetProfileFileName, methodGetProfileFileNameParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetProfileFileNameParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var methodGetProfileFileNameParametersTypes = new Type[] { typeof(int), typeof(int) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetProfileFileName, methodGetProfileFileNameParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetProfileFileNameParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileFileName, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetProfileFileName) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_GetProfileFileName_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetProfileFileName);
            var currentMethodInfo = this.GetMethodInfo(MethodGetProfileFileName, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_AgentDAL_PublishOutlookEvent_Static_Method_Call_Internally(Type[] types)
        {
            var methodPublishOutlookEventParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodPublishOutlookEvent, methodPublishOutlookEventParametersTypes);
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_PublishOutlookEvent_Static_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishOutlookEvent);
            var eventManifest = this.CreateType<EventManifest>();
            var eventData = this.CreateType<string>();

            // Act
            Action executeAction = () => AgentDAL.PublishOutlookEvent(eventManifest, eventData);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_PublishOutlookEvent_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishOutlookEvent);
            var eventManifest = this.CreateType<EventManifest>();
            var eventData = this.CreateType<string>();
            var methodPublishOutlookEventParametersTypes = new Type[] { typeof(EventManifest), typeof(string) };
            object[] parametersOfPublishOutlookEvent = { eventManifest, eventData };

            // Act
            Action currentAction = () => this.GetResultOfMethod<bool>(MethodPublishOutlookEvent, parametersOfPublishOutlookEvent, methodPublishOutlookEventParametersTypes);

            // Assert
            parametersOfPublishOutlookEvent.ShouldNotBeNull();
            parametersOfPublishOutlookEvent.Length.ShouldBe(2);
            methodPublishOutlookEventParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_PublishOutlookEvent_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishOutlookEvent);
            var methodPublishOutlookEventParametersTypes = new Type[] { typeof(EventManifest), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodPublishOutlookEvent, methodPublishOutlookEventParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodPublishOutlookEventParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_PublishOutlookEvent_Static_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishOutlookEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodPublishOutlookEvent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (PublishOutlookEvent) (Return Type : bool) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_AgentDAL_PublishOutlookEvent_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodPublishOutlookEvent);
            var currentMethodInfo = this.GetMethodInfo(MethodPublishOutlookEvent, 0);
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