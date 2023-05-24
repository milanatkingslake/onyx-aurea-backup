using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.CommonService.Interop;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.CommonService.Interop
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.CommonService.Interop.OtmInteropHelper" />)
    ///     and namespace <see cref="NotificationService.CommonService.Interop"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    [Ignore("Candidate for hanging of Jenkins builds")]
    public class OtmInteropHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OtmInteropHelper" />)
        /// </summary>
        public OtmInteropHelperTest() : base(typeof(OtmInteropHelper))
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

        #region General Initializer : Class (OtmInteropHelper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _otmInteropHelperInstanceType;
        private OtmInteropHelper _otmInteropHelperInstance;
        private OtmInteropHelper _otmInteropHelperInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OtmInteropHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _otmInteropHelperInstanceType = typeof(OtmInteropHelper);
            _otmInteropHelperInstanceFixture = this.Create<OtmInteropHelper>(false);
            _otmInteropHelperInstance = _otmInteropHelperInstanceFixture ?? this.Create<OtmInteropHelper>(true);
            CurrentInstance = _otmInteropHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OtmInteropHelper) Initializer

        #region Methods

        private const string MethodExecute = "Execute";

        #endregion

        #endregion

        #region General Initializer : Class (OtmInteropHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OtmInteropHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OtmInteropHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OtmInteropHelper)

        #region General Initializer : Class (OtmInteropHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OtmInteropHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExecute, 0)]
        public void AUT_OtmInteropHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OtmInteropHelper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OtmInteropHelper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmInteropHelper_Is_Instance_Present_Test()
        {
            // Assert
            _otmInteropHelperInstanceType.ShouldNotBeNull();
            _otmInteropHelperInstance.ShouldNotBeNull();
            _otmInteropHelperInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OtmInteropHelper) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OtmInteropHelper" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OtmInteropHelper_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _otmInteropHelperInstance.ShouldBeAssignableTo<OtmInteropHelper>();
            _otmInteropHelperInstanceFixture.ShouldBeAssignableTo<OtmInteropHelper>();
            CurrentInstance.ShouldBeAssignableTo<OtmInteropHelper>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OtmInteropHelper) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OtmInteropHelper_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OtmInteropHelper instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Execute) (Return Type : string) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXML = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();

            // Act
            Action executeAction = () => _otmInteropHelperInstance.Execute(applicationName, logicalObjectName, logicalMethodName, sessionId, paramXML, customDataXml);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Direct Call Result be Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_DirectCall_Result_ShouldBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXML = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = _otmInteropHelperInstance.Execute(applicationName, logicalObjectName, logicalMethodName, sessionId, paramXML, customDataXml);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_With_No_Parameters_Call_Results_ShouldBe_Null_If_Not_Premitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXML = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXML, customDataXml };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, methodExecuteParametersTypes, out exception);

            // Act
            var result1 = currentMethodInfo.GetResultMethodInfo<string>(_otmInteropHelperInstanceFixture, parametersOfExecute);
            var result2 = this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldBeNull();
            result2.ShouldBeNull();
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var applicationName = this.CreateType<string>();
            var logicalObjectName = this.CreateType<string>();
            var logicalMethodName = this.CreateType<string>();
            var sessionId = this.CreateType<string>();
            var paramXML = this.CreateType<string>();
            var customDataXml = this.CreateType<string>();
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            object[] parametersOfExecute = { applicationName, logicalObjectName, logicalMethodName, sessionId, paramXML, customDataXml };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExecute, parametersOfExecute, methodExecuteParametersTypes);

            // Assert
            parametersOfExecute.ShouldNotBeNull();
            parametersOfExecute.Length.ShouldBe(6);
            methodExecuteParametersTypes.Length.ShouldBe(6);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Results Null (if not primitive type) Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_Dynamic_Invoking_Results_Null_If_Not_Primitive_Type_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            result.ShouldBeNull();
            methodExecuteParametersTypes.Length.ShouldBe(6);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var methodExecuteParametersTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(string), typeof(string) };
            const int parametersCount = 6;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExecute, methodExecuteParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExecuteParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) without parameters value verify result should be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_Dynamic_Invoking_Results_Should_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldBeNull();
        }

        #endregion

        #region Method Call : (Execute) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OtmInteropHelper_Execute_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExecute);
            var currentMethodInfo = this.GetMethodInfo(MethodExecute, 0);
            const int parametersCount = 6;

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