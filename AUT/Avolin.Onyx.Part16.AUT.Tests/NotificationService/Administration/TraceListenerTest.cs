using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NotificationService.Administration;
using NUnit.Framework;
using Shouldly;

namespace Avolin.Onyx.Part16.AUT.Tests.NotificationService.Administration
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="NotificationService.Administration.TraceListener" />)
    ///     and namespace <see cref="NotificationService.Administration"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class TraceListenerTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="TraceListenerNonPublicTypeName" />) using
        ///     Using a public type <see cref="DispatchAgentManager" /> to
        ///     create a non-public type.
        /// </summary>
        public TraceListenerTest() : base(publicType: typeof(DispatchAgentManager), classNameWithNamespace: TraceListenerNonPublicTypeName)
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

        private Type _traceListenerInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string TraceListenerNonPublicTypeName = "NotificationService.Administration.TraceListener";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _traceListenerInstance;
        private object _traceListenerInstanceFixture;

        #region General Initializer : Class (TraceListener) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="TraceListener" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _traceListenerInstanceFixture = this.CreateNonPublicType(TraceListenerNonPublicTypeName);
            _traceListenerInstance = _traceListenerInstanceFixture;
            CurrentInstance = _traceListenerInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (TraceListener) Initializer

        #region Methods

        private const string MethodTrace = "Trace";
        private const string MethodLog = "Log";

        #endregion

        #region Fields

        private const string FieldiLog = "iLog";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (TraceListener)

        #region General Initializer : Class (TraceListener) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="TraceListener" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodTrace, 0)]
        [TestCase(MethodLog, 0)]
        [Category("AUT Explore")]
        public void AUT_TraceListener_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (TraceListener) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="TraceListener" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TraceListener_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (TraceListener) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="TraceListener" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldiLog)]
        [Category("AUT Fields")]
        public void AUT_TraceListener_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Initializer : Class (TraceListener) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="TraceListener" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_TraceListener_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Assert
            this.ExploreEveryFieldsExceptforUsedOnes();
        }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}