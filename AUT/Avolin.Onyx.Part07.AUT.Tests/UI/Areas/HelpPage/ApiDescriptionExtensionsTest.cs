using System;
using System.Diagnostics.CodeAnalysis;
using System.Web.Http.Description;
using AUT.TestProjects.Analyzer;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Areas.HelpPage;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Areas.HelpPage
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Areas.HelpPage.ApiDescriptionExtensions" />)
    ///     and namespace <see cref="Onyx.UI.Areas.HelpPage"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class ApiDescriptionExtensionsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="ApiDescriptionExtensions" />)
        /// </summary>
        public ApiDescriptionExtensionsTest() : base(typeof(ApiDescriptionExtensions))
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

        #region General Initializer : Class (ApiDescriptionExtensions) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _apiDescriptionExtensionsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="ApiDescriptionExtensions" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _apiDescriptionExtensionsInstanceType = typeof(ApiDescriptionExtensions);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (ApiDescriptionExtensions) Initializer

        #region Methods

        private const string MethodGetFriendlyId = "GetFriendlyId";

        #endregion

        #endregion

        #region General Initializer : Class (ApiDescriptionExtensions) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="ApiDescriptionExtensions" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_ApiDescriptionExtensions_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #endregion

        #region Category : Instance

        #region General Instance : Class (ApiDescriptionExtensions) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="ApiDescriptionExtensions" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_ApiDescriptionExtensions_Is_Static_Type_Present_Test()
        {
            // Assert
            _apiDescriptionExtensionsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (GetFriendlyId) (Return Type : string) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var description = this.CreateType<ApiDescription>();

            // Act
            Action executeAction = () => ApiDescriptionExtensions.GetFriendlyId(description);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) Direct Call Result Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_DirectCall_Result_ShouldNotBe_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var description = this.CreateType<ApiDescription>();
            var returnedValue = default(string);

            // Act
            Action executeAction = () => returnedValue = ApiDescriptionExtensions.GetFriendlyId(description);
            ActionAnalyzer.DoesActionThrowException(executeAction);

            // Assert
            returnedValue.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string)  Generic Method Results Results Not Null and no exception thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_With_Call_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var description = this.CreateType<ApiDescription>();
            var methodGetFriendlyIdParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetFriendlyId = { description };
            Exception exception;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFriendlyId, methodGetFriendlyIdParametersTypes, out exception);

            // Act
            var result1 = this.InvokeMethodDynamicallyWithType(MethodGetFriendlyId, methodGetFriendlyIdParametersTypes);
            var result2 = this.GetResultOfMethod<string>(MethodGetFriendlyId, parametersOfGetFriendlyId, methodGetFriendlyIdParametersTypes);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            result1.ShouldNotBeNull();
            result2.ShouldNotBeNull();
            parametersOfGetFriendlyId.ShouldNotBeNull();
            parametersOfGetFriendlyId.Length.ShouldBe(1);
            methodGetFriendlyIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(() => this.GetResultOfMethod<string>(MethodGetFriendlyId, parametersOfGetFriendlyId, methodGetFriendlyIdParametersTypes));
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_With_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var description = this.CreateType<ApiDescription>();
            var methodGetFriendlyIdParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetFriendlyId = { description };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodGetFriendlyId, methodGetFriendlyIdParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfGetFriendlyId);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfGetFriendlyId.ShouldNotBeNull();
            parametersOfGetFriendlyId.Length.ShouldBe(1);
            methodGetFriendlyIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var description = this.CreateType<ApiDescription>();
            var methodGetFriendlyIdParametersTypes = new Type[] { typeof(ApiDescription) };
            object[] parametersOfGetFriendlyId = { description };

            // Act
            Action currentAction = () => this.GetResultOfMethod<string>(MethodGetFriendlyId, parametersOfGetFriendlyId, methodGetFriendlyIdParametersTypes);

            // Assert
            parametersOfGetFriendlyId.ShouldNotBeNull();
            parametersOfGetFriendlyId.Length.ShouldBe(1);
            methodGetFriendlyIdParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) Results Not Null Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_Dynamic_Invoking_Results_Not_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var methodGetFriendlyIdParametersTypes = new Type[] { typeof(ApiDescription) };

            // Act
            var result = this.InvokeMethodDynamicallyWithType(MethodGetFriendlyId, methodGetFriendlyIdParametersTypes);

            // Assert
            result.ShouldNotBeNull();
            methodGetFriendlyIdParametersTypes.Length.ShouldBe(1);
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var methodGetFriendlyIdParametersTypes = new Type[] { typeof(ApiDescription) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodGetFriendlyId, methodGetFriendlyIdParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodGetFriendlyIdParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) without parameters value verify result should not be null.

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_Dynamic_Invoking_Results_Should_Not_Be_Null_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFriendlyId, 0);

            // Act
            var result = this.InvokeMethodDynamically(currentMethodInfo);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            result.ShouldNotBeNull();
        }

        #endregion

        #region Method Call : (GetFriendlyId) (Return Type : string) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_ApiDescriptionExtensions_GetFriendlyId_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodGetFriendlyId);
            var currentMethodInfo = this.GetMethodInfo(MethodGetFriendlyId, 0);
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