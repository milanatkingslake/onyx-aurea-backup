using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Core.Model;
using Onyx.UI.Form.Controller;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Form.Controller
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Form.Controller.Helper" />)
    ///     and namespace <see cref="Onyx.UI.Form.Controller"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class HelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="Helper" />)
        /// </summary>
        public HelperTest() : base(typeof(global::Onyx.UI.Form.Controller.Helper))
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

        #region General Initializer : Class (Helper) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _helperInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="Helper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _helperInstanceType = typeof(global::Onyx.UI.Form.Controller.Helper);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (Helper) Initializer

        #region Methods

        private const string MethodCreateErrorResponse = "CreateErrorResponse";

        #endregion

        #endregion

        #region General Initializer : Class (Helper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="Helper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_Helper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (Helper)

        #region General Initializer : Class (Helper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="Helper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodCreateErrorResponse, 0)]
        public void AUT_Helper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (Helper) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="Helper" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_Helper_Is_Static_Type_Present_Test()
        {
            // Assert
            _helperInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest

        #region Method Call : (CreateErrorResponse) (Return Type : List<MessageModel>) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_With_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var ex = this.CreateType<Exception>();
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(Exception) };
            object[] parametersOfCreateErrorResponse = { ex };

            // Act
            Action currentAction = () => this.GetResultOfMethod<List<MessageModel>>(MethodCreateErrorResponse, parametersOfCreateErrorResponse, methodCreateErrorResponseParametersTypes);

            // Assert
            parametersOfCreateErrorResponse.ShouldNotBeNull();
            parametersOfCreateErrorResponse.Length.ShouldBe(1);
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : List<MessageModel>) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var methodCreateErrorResponseParametersTypes = new Type[] { typeof(Exception) };
            const int parametersCount = 1;

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodCreateErrorResponse, methodCreateErrorResponseParametersTypes);

            // Assert
            Should.NotThrow(currentAction);
            methodCreateErrorResponseParametersTypes.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (CreateErrorResponse) (Return Type : List<MessageModel>) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_Helper_CreateErrorResponse_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodCreateErrorResponse);
            var currentMethodInfo = this.GetMethodInfo(MethodCreateErrorResponse, 0);
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