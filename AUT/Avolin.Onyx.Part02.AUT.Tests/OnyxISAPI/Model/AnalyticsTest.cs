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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxISAPI.Model.Analytics" />)
    ///     and namespace <see cref="OnyxISAPI.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
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
        private const string MethodGetConfigFileContent = "GetConfigFileContent";
        private const string MethodGetWebTicket = "GetWebTicket";

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
        [TestCase(MethodGetConfigFileContent, 0)]
        [TestCase(MethodGetWebTicket, 0)]
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

        #endregion

        #region Category : Instance

        #region General Instance : Class (Analytics) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Analytics" />) can be created test
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

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (Analytics) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Analytics_Constructor_With_Parameter_Created_Instance_Type_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Analytics instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Analytics(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _analyticsInstance.ShouldNotBeNull();
            _analyticsInstanceFixture.ShouldNotBeNull();
            instance.ShouldBeOfType<Analytics>();
        }

        #endregion

        #region General Constructor : Class (Analytics) with Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_Analytics_Constructor_Instantiation_With_Parameter_Test()
        {
            // Arrange
            var parameterCollection = this.CreateType<Hashtable>();
            Analytics instance = null;
            Exception creationException = null;

            // Act
            Action createAction = () => instance = new Analytics(parameterCollection);
            creationException = ActionAnalyzer.GetActionException(createAction);

            // Assert
            instance.ShouldNotBeNull();
            _analyticsInstance.ShouldNotBeNull();
            _analyticsInstanceFixture.ShouldNotBeNull();
            Should.NotThrow(createAction);
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (GetAnalyticsDetail) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            Type [] methodGetAnalyticsDetailParametersTypes = null;
            object[] parametersOfGetAnalyticsDetail = null; // no parameter present

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetAnalyticsDetail, parametersOfGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            parametersOfGetAnalyticsDetail.ShouldBeNull();
            methodGetAnalyticsDetailParametersTypes.ShouldBeNull();
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Method Call : (GetAnalyticsDetail) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetAnalyticsDetail_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetAnalyticsDetail);
            Type [] methodGetAnalyticsDetailParametersTypes = null;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetAnalyticsDetail, methodGetAnalyticsDetailParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetAnalyticsDetailParametersTypes.ShouldBeNull();
        }

        #endregion
        
        #region Method Call : (GetConfigFileContent) (Return Type : XElement) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Analytics_GetConfigFileContent_Method_Call_Internally(Type[] types)
        {
            var methodGetConfigFileContentParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetConfigFileContent, methodGetConfigFileContentParametersTypes);
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var configType = this.CreateType<string>();
            var methodGetConfigFileContentParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetConfigFileContent = { configType };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigFileContent, methodGetConfigFileContentParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<XElement>(_analyticsInstanceFixture, parametersOfGetConfigFileContent);
            var result2 = this.GetResultOfMethod<XElement>(MethodGetConfigFileContent, parametersOfGetConfigFileContent, methodGetConfigFileContentParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetConfigFileContent.ShouldNotBeNull();
            parametersOfGetConfigFileContent.Length.ShouldBe(1);
            methodGetConfigFileContentParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var configType = this.CreateType<string>();
            var methodGetConfigFileContentParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfGetConfigFileContent = { configType };

            // Act
            Action currentAction = () => this.GetResultOfMethod<XElement>(MethodGetConfigFileContent, parametersOfGetConfigFileContent, methodGetConfigFileContentParametersTypes);

            // Assert
            parametersOfGetConfigFileContent.ShouldNotBeNull();
            parametersOfGetConfigFileContent.Length.ShouldBe(1);
            methodGetConfigFileContentParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var methodGetConfigFileContentParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetConfigFileContent, methodGetConfigFileContentParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetConfigFileContentParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var methodGetConfigFileContentParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetConfigFileContent, methodGetConfigFileContentParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetConfigFileContentParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigFileContent, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetConfigFileContent) (Return Type : XElement) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetConfigFileContent_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetConfigFileContent);
            var currentMethodInfo = this.GetMethodInfo(MethodGetConfigFileContent, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) private call definition

        [ExcludeFromCodeCoverage]
        private void AUT_Analytics_GetWebTicket_Method_Call_Internally(Type[] types)
        {
            var methodGetWebTicketParametersTypes = types;
            this.InvokeMethodDynamicallyWithType(MethodGetWebTicket, methodGetWebTicketParametersTypes);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var xeWebticketParam = this.CreateType<XElement>();
            var getWebticketUrl = this.CreateType<string>();
            var methodGetWebTicketParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetWebTicket = { xeWebticketParam, getWebticketUrl };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetWebTicket, methodGetWebTicketParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_analyticsInstanceFixture, parametersOfGetWebTicket);
            var result2 = this.GetResultOfMethod<string>(MethodGetWebTicket, parametersOfGetWebTicket, methodGetWebTicketParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfGetWebTicket.ShouldNotBeNull();
            parametersOfGetWebTicket.Length.ShouldBe(2);
            methodGetWebTicketParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var xeWebticketParam = this.CreateType<XElement>();
            var getWebticketUrl = this.CreateType<string>();
            var methodGetWebTicketParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            object[] parametersOfGetWebTicket = { xeWebticketParam, getWebticketUrl };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetWebTicket, parametersOfGetWebTicket, methodGetWebTicketParametersTypes);

            // Assert
            parametersOfGetWebTicket.ShouldNotBeNull();
            parametersOfGetWebTicket.Length.ShouldBe(2);
            methodGetWebTicketParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var methodGetWebTicketParametersTypes = new Type[] { typeof(XElement), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetWebTicket, methodGetWebTicketParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodGetWebTicketParametersTypes.Length.ShouldBe(2);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var methodGetWebTicketParametersTypes = new Type[] { typeof(XElement), typeof(string) };
            const int parametersCount = 2;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetWebTicket, methodGetWebTicketParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetWebTicketParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWebTicket, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (GetWebTicket) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Analytics_GetWebTicket_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetWebTicket);
            var currentMethodInfo = this.GetMethodInfo(MethodGetWebTicket, 0);
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