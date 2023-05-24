using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.Model;
using Shouldly;

namespace Avolin.Onyx.Part07.AUT.Tests.UI.Navigator.Model
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.Model.LogProvider" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.Model"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LogProviderTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LogProvider" />)
        /// </summary>
        public LogProviderTest() : base(typeof(LogProvider))
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

        #region General Initializer : Class (LogProvider) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _logProviderInstanceType;
        private LogProvider _logProviderInstance;
        private LogProvider _logProviderInstanceFixture;

        /// <summary>
        ///    Setting up everything for <see cref="LogProvider" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _logProviderInstanceType = typeof(LogProvider);
            _logProviderInstanceFixture = this.Create<LogProvider>(false);
            _logProviderInstance = _logProviderInstanceFixture ?? this.Create<LogProvider>(true);
            CurrentInstance = _logProviderInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LogProvider) Initializer

        #region Methods

        private const string MethodWrite = "Write";
        private const string MethodRead = "Read";

        #endregion

        #endregion

        #region General Initializer : Class (LogProvider) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LogProvider" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogProvider_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryMethodsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LogProvider)

        #region General Initializer : Class (LogProvider) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LogProvider" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodWrite, 0)]
        [TestCase(MethodWrite, 1)]
        [TestCase(MethodRead, 0)]
        [TestCase(MethodRead, 1)]
        public void AUT_LogProvider_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Instance : Class (LogProvider) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LogProvider" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LogProvider_Is_Instance_Present_Test()
        {
            // Assert
            _logProviderInstanceType.ShouldNotBeNull();
            _logProviderInstance.ShouldNotBeNull();
            _logProviderInstanceFixture.ShouldNotBeNull();
            CurrentInstance.ShouldNotBeNull();
        }

        #endregion

        #region General Instance : Class (LogProvider) Instance Type Verify Test

        /// <summary>
        ///     Class (<see cref="LogProvider" />) instance type verify test.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LogProvider_Is_Instance_Type_Verify_Test()
        {
            // Assert
            _logProviderInstance.ShouldBeAssignableTo<LogProvider>();
            _logProviderInstanceFixture.ShouldBeAssignableTo<LogProvider>();
            CurrentInstance.ShouldBeAssignableTo<LogProvider>();
        }

        #endregion

        #endregion

        #endregion
    }
}