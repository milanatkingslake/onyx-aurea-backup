using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using passencrypt;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.passencrypt
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="passencrypt.ExceptionIds" />)
    ///     and namespace <see cref="passencrypt"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ExceptionIdsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ExceptionIds" />)
        /// </summary>
        public ExceptionIdsTest() : base(typeof(ExceptionIds))
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

        #region General Initializer : Class (ExceptionIds) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _exceptionIdsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ExceptionIds" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _exceptionIdsInstanceType = typeof(ExceptionIds);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ExceptionIds) Initializer

        #region Methods

        private const string MethodExceptionDescription = "ExceptionDescription";

        #endregion

        #endregion

        #region General Initializer : Class (ExceptionIds) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ExceptionIds" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ExceptionIds_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (ExceptionIds)

        #region General Initializer : Class (ExceptionIds) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="ExceptionIds" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodExceptionDescription, 0)]
        public void AUT_ExceptionIds_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (ExceptionIds) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ExceptionIds" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ExceptionIds_Is_Static_Type_Present_Test()
        {
            // Assert
            _exceptionIdsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (ExceptionDescription) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var errorId = this.CreateType<string>();

            // Act
            Action executeAction = () => ExceptionIds.ExceptionDescription(errorId);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var errorId = this.CreateType<string>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = ExceptionIds.ExceptionDescription(errorId);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var errorId = this.CreateType<string>();
            var methodExceptionDescriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfExceptionDescription = { errorId };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionDescription, methodExceptionDescriptionParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodExceptionDescription, methodExceptionDescriptionParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodExceptionDescription, parametersOfExceptionDescription, methodExceptionDescriptionParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfExceptionDescription.ShouldNotBeNull();
            parametersOfExceptionDescription.Length.ShouldBe(1);
            methodExceptionDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodExceptionDescription, parametersOfExceptionDescription, methodExceptionDescriptionParametersTypes));
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var errorId = this.CreateType<string>();
            var methodExceptionDescriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfExceptionDescription = { errorId };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionDescription, methodExceptionDescriptionParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfExceptionDescription);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfExceptionDescription.ShouldNotBeNull();
            parametersOfExceptionDescription.Length.ShouldBe(1);
            methodExceptionDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var errorId = this.CreateType<string>();
            var methodExceptionDescriptionParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfExceptionDescription = { errorId };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodExceptionDescription, parametersOfExceptionDescription, methodExceptionDescriptionParametersTypes);

            // Assert
            parametersOfExceptionDescription.ShouldNotBeNull();
            parametersOfExceptionDescription.Length.ShouldBe(1);
            methodExceptionDescriptionParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var methodExceptionDescriptionParametersTypes = new Type[] { typeof(string) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodExceptionDescription, methodExceptionDescriptionParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodExceptionDescriptionParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var methodExceptionDescriptionParametersTypes = new Type[] { typeof(string) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodExceptionDescription, methodExceptionDescriptionParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodExceptionDescriptionParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionDescription, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (ExceptionDescription) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ExceptionIds_ExceptionDescription_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodExceptionDescription);
            var currentMethodInfo = this.GetMethodInfo(MethodExceptionDescription, 0);
            const int parametersCount = 1;

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