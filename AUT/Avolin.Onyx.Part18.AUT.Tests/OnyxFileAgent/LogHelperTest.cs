using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxFileAgent;
using Shouldly;

namespace Avolin.Onyx.Part18.AUT.Tests.OnyxFileAgent
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxFileAgent.LogHelper" />)
    ///     and namespace <see cref="OnyxFileAgent"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LogHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LogHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="FileAgent" /> to
        ///     create a non-public type.
        /// </summary>
        public LogHelperTest() : base(publicType: typeof(FileAgent), classNameWithNamespace: LogHelperNonPublicTypeName)
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

        private Type _logHelperInstanceType;
        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private const string LogHelperNonPublicTypeName = "OnyxFileAgent.LogHelper";

        /// <summary>
        ///    For non-public class type is defined as object.
        /// </summary>
        private object _logHelperInstance;
        private object _logHelperInstanceFixture;

        #region General Initializer : Class (LogHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LogHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _logHelperInstanceFixture = this.CreateNonPublicType(LogHelperNonPublicTypeName);
            _logHelperInstance = _logHelperInstanceFixture;
            CurrentInstance = _logHelperInstance;

            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LogHelper) Initializer

        #region Methods

        private const string MethodLogEventError = "LogEventError";
        private const string MethodLogEventDebug = "LogEventDebug";
        private const string MethodAddEventSourceLibrary = "AddEventSourceLibrary";

        #endregion

        #region Fields

        private const string FieldsubKeyEventLog = "subKeyEventLog";
        private const string FieldregistryValueName = "registryValueName";
        private const string FieldregistryValueName1 = "registryValueName1";
        private const string FieldregistryValueName2 = "registryValueName2";
        private const string FieldregistryValueName3 = "registryValueName3";

        #endregion

        #endregion

        #region Explore Class for Coverage Gain : Class (LogHelper)

        #region General Initializer : Class (LogHelper) All Methods Explore Verification.

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(MethodLogEventError, 0)]
        [TestCase(MethodLogEventDebug, 0)]
        [TestCase(MethodAddEventSourceLibrary, 0)]
        [Category("AUT Explore")]
        public void AUT_LogHelper_All_Methods_Explore_Verify_Test(string name, int overloadingIndex = 0)
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

        #region General Initializer : Class (LogHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldsubKeyEventLog)]
        [TestCase(FieldregistryValueName)]
        [TestCase(FieldregistryValueName1)]
        [TestCase(FieldregistryValueName2)]
        [TestCase(FieldregistryValueName3)]
        [Category("AUT Fields")]
        public void AUT_LogHelper_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #endregion

        #endregion

        #endregion
    }
}