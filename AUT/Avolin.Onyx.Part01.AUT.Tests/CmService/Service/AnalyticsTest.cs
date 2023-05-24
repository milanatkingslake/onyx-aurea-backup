using System;
using System.Diagnostics.CodeAnalysis;
using System.ServiceModel.Channels;
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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="CmService.Service.Analytics" />)
    ///     and namespace <see cref="CmService.Service"/> class using generator(v:1.1)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.Configure.CrmWeb" /> v1.5.
    ///     Original source code location <see cref="\OnyxGatewayService\Service\Analytics.cs"/>
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class AnalyticsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Analytics" />)
        /// </summary>
        public AnalyticsTest() : base(typeof(Analytics))
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

        #region General Initializer : Class (Analytics) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _analyticsInstanceType;
        private Analytics _analyticsInstance;
        private Analytics _analyticsInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="Analytics" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _analyticsInstanceType = typeof(Analytics);
            _analyticsInstanceFixture = this.Create<Analytics>(false);
            _analyticsInstance = _analyticsInstanceFixture ?? this.Create<Analytics>(true);
            CurrentInstance = _analyticsInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Analytics) Initializer

        #region Methods

        private const string MethodGetAnalyticsDetail = "GetAnalyticsDetail";

        #endregion

        #endregion

        #region General Initializer : Class (Analytics) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Analytics" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Analytics_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Analytics)

        #region General Initializer : Class (Analytics) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Analytics" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodGetAnalyticsDetail, 0)]
        public void AUT_Analytics_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Analytics) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Analytics" />) can be created test
        ///     This test is used to remove the class if not valid, meaning instance cannot be created.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Analytics_Is_Instance_Present_Test()
        {
            // Assert
            _analyticsInstanceType.ShouldNotBeNull();
            _analyticsInstance.ShouldNotBeNull();
            _analyticsInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (Analytics) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="Analytics" />) instance type verify test.
        ///     This test confirms that dynamically created object is the one that we expected for this class to be tested.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Analytics_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _analyticsInstance.ShouldBeAssignableTo<Analytics>();
            _analyticsInstanceFixture.ShouldBeAssignableTo<Analytics>();
            CurrentInstance.ShouldBeAssignableTo<Analytics>();
        }

        #endregion

        #region General Constructor : Class (Analytics) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Analytics_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            Analytics instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Test Try-Catch Verify Exception Throw - Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT TryCatch")]
        public void AUT_Analytics_GetAnalyticsDetail_Try_Catch_Should_Not_Throw_Exception()
        {
            // Arrange
            var methodGetAnalyticsDetailParametersTypes = new Type[] { typeof(Message) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var message = this.CreateType<Message>();

            // Act
            Action executeAction = () => _analyticsInstance.GetAnalyticsDetail(message);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var message = this.CreateType<Message>();
            var returnedValue = default(Message);

            // Act
            Action executeAction = () => returnedValue = _analyticsInstance.GetAnalyticsDetail(message);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var message = this.CreateType<Message>();
            var methodGetAnalyticsDetailParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAnalyticsDetail = { message };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<Message>(_analyticsInstanceFixture, parametersOfGetAnalyticsDetail);
            var result2 = this.GetResultOfMethod<Message>(MethodGetAnalyticsDetail, parametersOfGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetAnalyticsDetail.ShouldNotBeNull();
            parametersOfGetAnalyticsDetail.Length.ShouldBe(1);
            methodGetAnalyticsDetailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var message = this.CreateType<Message>();
            var methodGetAnalyticsDetailParametersTypes = new Type[] { typeof(Message) };
            object[] parametersOfGetAnalyticsDetail = { message };

            // Act
            Action currentAction = () => this.GetResultOfMethod<Message>(MethodGetAnalyticsDetail, parametersOfGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            parametersOfGetAnalyticsDetail.ShouldNotBeNull();
            parametersOfGetAnalyticsDetail.Length.ShouldBe(1);
            methodGetAnalyticsDetailParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var methodGetAnalyticsDetailParametersTypes = new Type[] { typeof(Message) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetAnalyticsDetailParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var methodGetAnalyticsDetailParametersTypes = new Type[] { typeof(Message) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAnalyticsDetailParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAnalyticsDetail, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetAnalyticsDetail) (Return Type : Message) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            var currentMethodInfo = this.GetMethodInfo(MethodGetAnalyticsDetail, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion
    }
}