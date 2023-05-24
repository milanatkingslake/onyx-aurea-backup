using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.Gateway.Data;
using Shouldly;

namespace Avolin.Onyx.Part20.AUT.Tests.Onyx.Gateway.Data
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Gateway.Data.LoggerConstants" />)
    ///     and namespace <see cref="Onyx.Gateway.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class LoggerConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="LoggerConstants" />)
        /// </summary>
        public LoggerConstantsTest() : base(typeof(LoggerConstants))
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

        #region General Initializer : Class (LoggerConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _loggerConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="LoggerConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _loggerConstantsInstanceType = typeof(LoggerConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (LoggerConstants) Initializer

        #region Fields

        private const string FieldMETHOD_EXECUTION_STARTED = "METHOD_EXECUTION_STARTED";
        private const string FieldMETHOD_EXECUTION_ENDED = "METHOD_EXECUTION_ENDED";
        private const string FieldENCODED_STRING = "ENCODED_STRING";
        private const string FieldCONCATENATED_STRING = "CONCATENATED_STRING";
        private const string FieldTWO_STRINGS = "TWO_STRINGS";
        private const string FieldTWO_STRINGS_WITHOUT_DELIMITATION = "TWO_STRINGS_WITHOUT_DELIMITATION";
        private const string FieldTWO_STRINGS_WITH_SLASH = "TWO_STRINGS_WITH_SLASH";
        private const string FieldCLASS_METHOD_DELIMITER = "CLASS_METHOD_DELIMITER";
        private const string FieldGET_URL_END_POINT_QUERY = "GET_URL_END_POINT_QUERY";
        private const string FieldRETURN_URL_END_POINT_QUERY = "RETURN_URL_END_POINT_QUERY";
        private const string FieldENCRYPTED_TEXT = "ENCRYPTED_TEXT";
        private const string FieldPASSWORD_KEY_FILE_PATH = "PASSWORD_KEY_FILE_PATH";
        private const string FieldDECRYPTED_PASSWORD_EMPTY = "DECRYPTED_PASSWORD_EMPTY";
        private const string FieldQUERY_STRING = "QUERY_STRING";
        private const string FieldOGS_SERVER_URI = "OGS_SERVER_URI";
        private const string FieldINCOMING_REQUEST_URI = "INCOMING_REQUEST_URI";
        private const string FieldUNAUTHORIZED_WEB_REQUEST = "UNAUTHORIZED_WEB_REQUEST";
        private const string FieldNO_MATCH_FOUND_URI = "NO_MATCH_FOUND_URI";

        #endregion

        #endregion
        
        #region General Initializer : Class (LoggerConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="LoggerConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_LoggerConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (LoggerConstants)

        #region General Initializer : Class (LoggerConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="LoggerConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldMETHOD_EXECUTION_STARTED)]
        [TestCase(FieldMETHOD_EXECUTION_ENDED)]
        [TestCase(FieldENCODED_STRING)]
        [TestCase(FieldCONCATENATED_STRING)]
        [TestCase(FieldTWO_STRINGS)]
        [TestCase(FieldTWO_STRINGS_WITHOUT_DELIMITATION)]
        [TestCase(FieldTWO_STRINGS_WITH_SLASH)]
        [TestCase(FieldCLASS_METHOD_DELIMITER)]
        [TestCase(FieldGET_URL_END_POINT_QUERY)]
        [TestCase(FieldRETURN_URL_END_POINT_QUERY)]
        [TestCase(FieldENCRYPTED_TEXT)]
        [TestCase(FieldPASSWORD_KEY_FILE_PATH)]
        [TestCase(FieldDECRYPTED_PASSWORD_EMPTY)]
        [TestCase(FieldQUERY_STRING)]
        [TestCase(FieldOGS_SERVER_URI)]
        [TestCase(FieldINCOMING_REQUEST_URI)]
        [TestCase(FieldUNAUTHORIZED_WEB_REQUEST)]
        [TestCase(FieldNO_MATCH_FOUND_URI)]
        [Category("AUT Fields")]
        public void AUT_LoggerConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region Category : Instance

        #region General Instance : Class (LoggerConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="LoggerConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_LoggerConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _loggerConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}