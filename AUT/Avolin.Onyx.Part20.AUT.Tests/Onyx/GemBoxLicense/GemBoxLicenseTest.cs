using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.GemBoxLicense;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.GemBoxLicense
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.GemBoxLicense.GemBoxLicense" />)
    ///     and namespace <see cref="Onyx.GemBoxLicense"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class GemBoxLicenseTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="GemBoxLicense" />)
        /// </summary>
        public GemBoxLicenseTest() : base(typeof(global::Onyx.GemBoxLicense.GemBoxLicense))
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

        #region General Initializer : Class (GemBoxLicense) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _gemBoxLicenseInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="GemBoxLicense" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _gemBoxLicenseInstanceType = typeof(global::Onyx.GemBoxLicense.GemBoxLicense);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (GemBoxLicense) Initializer

        #region Methods

        private const string MethodSetLicense = "SetLicense";

        #endregion

        #endregion

        #region General Initializer : Class (GemBoxLicense) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="GemBoxLicense" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_GemBoxLicense_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion
        
        #region Explore Class for Coverage Gain : Class (GemBoxLicense)

        #region General Initializer : Class (GemBoxLicense) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="GemBoxLicense" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodSetLicense, 0)]
        public void AUT_GemBoxLicense_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (GemBoxLicense) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="GemBoxLicense" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_GemBoxLicense_Is_Static_Type_Present_Test()
        {
            // Assert
            _gemBoxLicenseInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #region Category : MethodCallTest
        
        #region Method Call : (SetLicense) (Return Type : void) Direct Call No Exception Thrown Test

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_DirectCall_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var configurationFileName = this.CreateType<string>();

            // Act
            Action executeAction = () => global::Onyx.GemBoxLicense.GemBoxLicense.SetLicense(configurationFileName);

            // Assert
            Should.NotThrow(executeAction);
        }

        #endregion
        
        #region Method Call : (SetLicense) (Return Type : void) No Exception Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_Call_Void_With_No_Parameters_No_Exception_Thrown_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var configurationFileName = this.CreateType<string>();
            var methodSetLicenseParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetLicense = { configurationFileName };
            Exception exception = null;
            var currentMethodInfo = this.GetMethodInfo(MethodSetLicense, methodSetLicenseParametersTypes, out exception);

            // Act
            Action currentAction = () => currentMethodInfo.Invoke(null, parametersOfSetLicense);

            // Assert
            currentMethodInfo.ShouldNotBeNull();
            exception.ShouldBeNull();
            parametersOfSetLicense.ShouldNotBeNull();
            parametersOfSetLicense.Length.ShouldBe(1);
            methodSetLicenseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLicense) (Return Type : void) No Exception with encapsulation Thrown

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_Call_Void_With_No_Parameters_Call_No_Exception_Thrown_With_Encapsulation_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var configurationFileName = this.CreateType<string>();
            var methodSetLicenseParametersTypes = new Type[] { typeof(string) };
            object[] parametersOfSetLicense = { configurationFileName };

            // Act
            Action currentAction = () => this.InvokeWithTypes(MethodSetLicense, parametersOfSetLicense, methodSetLicenseParametersTypes);

            // Assert
            parametersOfSetLicense.ShouldNotBeNull();
            parametersOfSetLicense.Length.ShouldBe(1);
            methodSetLicenseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLicense) (Return Type : void) Parameters Count verify

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_Call_Parameters_Count_Verification_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLicense, 0);
            const int parametersCount = 1;

            // Act
            var parameters = currentMethodInfo.GetParameters();

            // Assert
            parameters.Length.ShouldBe(parametersCount);
        }

        #endregion

        #region Method Call : (SetLicense) (Return Type : void) Invoke Should Not Throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_Call_Dynamic_Invoking_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var methodSetLicenseParametersTypes = new Type[] { typeof(string) };

            // Act
            Action currentAction = () => this.InvokeMethodDynamicallyWithType(MethodSetLicense, methodSetLicenseParametersTypes);

            // Assert
            methodSetLicenseParametersTypes.Length.ShouldBe(1);
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Method Call : (SetLicense) (Return Type : void) Invoke without parameter types and should not throw

        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT MethodCallTest")]
        public void AUT_GemBoxLicense_SetLicense_Static_Method_Call_With_Dynamic_Invoking_Without_Parameters_Should_Not_Throw_Test()
        {
            // Arrange
            this.ValidateExecuteCondition(MethodSetLicense);
            var currentMethodInfo = this.GetMethodInfo(MethodSetLicense, 0);

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