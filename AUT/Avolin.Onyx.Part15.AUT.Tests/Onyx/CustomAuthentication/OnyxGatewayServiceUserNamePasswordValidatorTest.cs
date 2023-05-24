using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.CustomAuthentication;
using Shouldly;

namespace Avolin.Onyx.Part15.AUT.Tests.Onyx.CustomAuthentication
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.CustomAuthentication.OnyxGatewayServiceUserNamePasswordValidator" />)
    ///     and namespace <see cref="Onyx.CustomAuthentication"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxGatewayServiceUserNamePasswordValidatorTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxGatewayServiceUserNamePasswordValidator" />)
        /// </summary>
        public OnyxGatewayServiceUserNamePasswordValidatorTest() : base(typeof(OnyxGatewayServiceUserNamePasswordValidator))
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

        #region General Initializer : Class (OnyxGatewayServiceUserNamePasswordValidator) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxGatewayServiceUserNamePasswordValidatorInstanceType;
        private OnyxGatewayServiceUserNamePasswordValidator _onyxGatewayServiceUserNamePasswordValidatorInstance;
        private OnyxGatewayServiceUserNamePasswordValidator _onyxGatewayServiceUserNamePasswordValidatorInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxGatewayServiceUserNamePasswordValidator" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxGatewayServiceUserNamePasswordValidatorInstanceType = typeof(OnyxGatewayServiceUserNamePasswordValidator);
            _onyxGatewayServiceUserNamePasswordValidatorInstanceFixture = this.Create<OnyxGatewayServiceUserNamePasswordValidator>(false);
            _onyxGatewayServiceUserNamePasswordValidatorInstance = _onyxGatewayServiceUserNamePasswordValidatorInstanceFixture ?? this.Create<OnyxGatewayServiceUserNamePasswordValidator>(true);
            CurrentInstance = _onyxGatewayServiceUserNamePasswordValidatorInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceUserNamePasswordValidator) Initializer

        #region Methods

        private const string MethodValidate = "Validate";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxGatewayServiceUserNamePasswordValidator) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceUserNamePasswordValidator" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxGatewayServiceUserNamePasswordValidator)

        #region General Initializer : Class (OnyxGatewayServiceUserNamePasswordValidator) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceUserNamePasswordValidator" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodValidate, 0)]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (OnyxGatewayServiceUserNamePasswordValidator) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceUserNamePasswordValidator" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Is_Instance_Present_Test()
        {
            // Assert
            _onyxGatewayServiceUserNamePasswordValidatorInstanceType.ShouldNotBeNull();
            _onyxGatewayServiceUserNamePasswordValidatorInstance.ShouldNotBeNull();
            _onyxGatewayServiceUserNamePasswordValidatorInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (OnyxGatewayServiceUserNamePasswordValidator) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="OnyxGatewayServiceUserNamePasswordValidator" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _onyxGatewayServiceUserNamePasswordValidatorInstance.ShouldBeAssignableTo<OnyxGatewayServiceUserNamePasswordValidator>();
            _onyxGatewayServiceUserNamePasswordValidatorInstanceFixture.ShouldBeAssignableTo<OnyxGatewayServiceUserNamePasswordValidator>();
            CurrentInstance.ShouldBeAssignableTo<OnyxGatewayServiceUserNamePasswordValidator>();
        }

        #endregion

        #endregion

        #region Category : Constructor

        #region General Constructor : Class (OnyxGatewayServiceUserNamePasswordValidator) without Parameter Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Constructor")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Instantiated_Without_Parameter_No_Throw_Exception_Test()
        {
            // Arrange
            OnyxGatewayServiceUserNamePasswordValidator instance = null;

            // Act
            var exception = CreateAnalyzer.GetThrownExceptionWhenCreate(out instance);

            // Assert
            instance.ShouldNotBeNull();
            exception.ShouldBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (Validate) (Return Type : void) Direct Call Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_DirectCall_Throw_Exception_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();

            // Act
            Action executeAction = () => _onyxGatewayServiceUserNamePasswordValidatorInstance.Validate(userName, password);

            // Assert
            Should.Throw<Exception>(executeAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_Call_Void_With_No_Parameters_Call_Throw_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfValidate = { userName, password };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, methodValidateParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(_onyxGatewayServiceUserNamePasswordValidatorInstanceFixture, parametersOfValidate);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(2);
            methodValidateParametersTypes.Length.ShouldBe(2);
            methodValidateParametersTypes.Length.ShouldBe(parametersOfValidate.Length);
            Should.Throw<Exception>(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var userName = this.CreateType<string>();
            var password = this.CreateType<string>();
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string) };
            object[] parametersOfValidate = { userName, password };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodValidate, parametersOfValidate, methodValidateParametersTypes);

            // Assert
            parametersOfValidate.ShouldNotBeNull();
            parametersOfValidate.Length.ShouldBe(2);
            methodValidateParametersTypes.Length.ShouldBe(2);
            methodValidateParametersTypes.Length.ShouldBe(parametersOfValidate.Length);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);
            const int parametersCount = 2;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var methodValidateParametersTypes = new Type[] { typeof(string), typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodValidate, methodValidateParametersTypes);

            // Assert
            methodValidateParametersTypes.Length.ShouldBe(2);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (Validate) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_OnyxGatewayServiceUserNamePasswordValidator_Validate_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodValidate);
            var currentMethodInfo = this.GetMethodInfo(MethodValidate, 0);

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