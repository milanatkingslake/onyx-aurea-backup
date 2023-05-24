using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxOutlookAddin;
using Shouldly;

namespace Avolin.Onyx.Part11.AUT.Tests.OnyxOutlookAddin
{
    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxOutlookAddin.LogHelper" />)
    ///     and namespace <see cref="OnyxOutlookAddin"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LogHelperTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a non-public class (<see cref="LogHelperNonPublicTypeName" />) using
        ///     Using a public type <see cref="AddContactControl" /> to
        ///     create a non-public type.
        /// </summary>
        public LogHelperTest() : base(publicType: typeof(AddContactControl), classNameWithNamespace: LogHelperNonPublicTypeName)
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
        private const string LogHelperNonPublicTypeName = "OnyxOutlookAddin.LogHelper";

        #region General Initializer : Class (LogHelper) One time setup

        /// <summary>
        ///    Setting up everything for <see cref="LogHelper" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LogHelper) Initializer

        #region Properties

        private const string PropertyLogFile = "LogFile";
        private const string PropertyuserLogLevel = "userLogLevel";

        #endregion

        #region Methods

        private const string MethodEnforceRetentionPolicy = "EnforceRetentionPolicy";
        private const string MethodlogMessage = "logMessage";
        private const string MethodlogMessageSilent = "logMessageSilent";
        private const string MethodextractErrorDescription = "extractErrorDescription";
        private const string MethodwriteToEventLog = "writeToEventLog";
        private const string MethodlogMessageToFile = "logMessageToFile";

        #endregion

        #region Fields

        private const string FieldfileWriteLock = "fileWriteLock";
        private const string FieldsourceName = "sourceName";
        private const string FieldlogFileName = "logFileName";
        private const string FieldlogFileDate = "logFileDate";
        private const string FieldlogToFile = "logToFile";
        private const string FieldlogLevel = "logLevel";

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
        [TestCase(MethodEnforceRetentionPolicy, 0)]
        [TestCase(MethodlogMessage, 0)]
        [TestCase(MethodlogMessageSilent, 0)]
        [TestCase(MethodlogMessage, 1)]
        [TestCase(MethodextractErrorDescription, 0)]
        [TestCase(MethodwriteToEventLog, 0)]
        [TestCase(MethodlogMessageToFile, 0)]
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

        #region General Initializer : Class (LogHelper) Explore Non-listed Methods

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify methods for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogHelper_Explore_Reflection_Based_NonListed_Methods_Test()
        {
            // Assert
            this.ExploreEveryMethodsExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LogHelper) All Properties Explore By Name

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify properties for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(PropertyLogFile)]
        [TestCase(PropertyuserLogLevel)]
        [Category("AUT Property")]
        public void AUT_LogHelper_All_Properties_Explore_Verify_By_Name_Test(string name)
        {
            // Arrange
            this.ValidateExecuteCondition(name);
            var propertyInfo = this.GetPropertyInfo(name);

            // Act
            this.ExploreProperty(propertyInfo);

            // Assert
            propertyInfo.ShouldNotBeNull();
        }

        #endregion

        #region General Initializer : Class (LogHelper) Explore Non-listed Properties

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify properties for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogHelper_Explore_Reflection_Based_NonListed_Properties_Test()
        {
            // Assert
            this.ExploreEveryPropertiesExceptforUsedOnes();
        }

        #endregion

        #region General Initializer : Class (LogHelper) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldfileWriteLock)]
        [TestCase(FieldsourceName)]
        [TestCase(FieldlogFileName)]
        [TestCase(FieldlogFileDate)]
        [TestCase(FieldlogToFile)]
        [TestCase(FieldlogLevel)]
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

        #region General Initializer : Class (LogHelper) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LogHelper" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LogHelper_Explore_Reflection_Based_NonListed_Fields_Test()
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