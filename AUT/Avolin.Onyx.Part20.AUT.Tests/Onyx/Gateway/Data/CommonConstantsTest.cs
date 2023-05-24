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
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.Gateway.Data.CommonConstants" />)
    ///     and namespace <see cref="Onyx.Gateway.Data"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class CommonConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="CommonConstants" />)
        /// </summary>
        public CommonConstantsTest() : base(typeof(CommonConstants))
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

        #region General Initializer : Class (CommonConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _commonConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="CommonConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _commonConstantsInstanceType = typeof(CommonConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (CommonConstants) Initializer

        #region Fields

        private const string FieldSERVICE_MODEL_CONFIGURATION_SECTION = "SERVICE_MODEL_CONFIGURATION_SECTION";
        private const string FieldPASSWORD_KEYFILE = "PASSWORD_KEYFILE";
        private const string FieldWINDOWS_SERVICE = "WINDOWS_SERVICE";
        private const string FieldSERVER_RESPONSE_HTTP_HEADERS = "SERVER_RESPONSE_HTTP_HEADERS";
        private const string FieldSERVER_REQUEST_HTTP_HEADERS = "SERVER_REQUEST_HTTP_HEADERS";
        private const string FieldEXTENSIBILITY_ASSEMBLY_FULL_NAME = "EXTENSIBILITY_ASSEMBLY_FULL_NAME";
        private const string FieldEXTENSIBILITY_TYPE_FULL_NAME = "EXTENSIBILITY_TYPE_FULL_NAME";
        private const string FieldBACKSLASH = "BACKSLASH";
        private const string FieldUNAUTHORIZED = "UNAUTHORIZED";
        private const string FieldCONTENT_XML = "CONTENT_XML";
        private const string FieldTWO_STRING_COLON = "TWO_STRING_COLON";
        private const string FieldBASIC_HEADER = "BASIC_HEADER";
        private const string FieldEXCEPTION_MESSAGE = "EXCEPTION_MESSAGE";
        private const string FieldSUCCESS_MESSAGE = "SUCCESS_MESSAGE";
        private const string FieldOGS_PROXY_FAILURE_MESSAGE = "OGS_PROXY_FAILURE_MESSAGE";
        private const string FieldCLIENT_ACCESS_POLICY = "CLIENT_ACCESS_POLICY";
        private const string FieldCROSS_DOMAIN_POLICY = "CROSS_DOMAIN_POLICY";

        #endregion

        #endregion
        
        #region General Initializer : Class (CommonConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_CommonConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (CommonConstants)

        #region General Initializer : Class (CommonConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldSERVICE_MODEL_CONFIGURATION_SECTION)]
        [TestCase(FieldPASSWORD_KEYFILE)]
        [TestCase(FieldWINDOWS_SERVICE)]
        [TestCase(FieldSERVER_RESPONSE_HTTP_HEADERS)]
        [TestCase(FieldSERVER_REQUEST_HTTP_HEADERS)]
        [TestCase(FieldEXTENSIBILITY_ASSEMBLY_FULL_NAME)]
        [TestCase(FieldEXTENSIBILITY_TYPE_FULL_NAME)]
        [TestCase(FieldBACKSLASH)]
        [TestCase(FieldUNAUTHORIZED)]
        [TestCase(FieldCONTENT_XML)]
        [TestCase(FieldTWO_STRING_COLON)]
        [TestCase(FieldBASIC_HEADER)]
        [TestCase(FieldEXCEPTION_MESSAGE)]
        [TestCase(FieldSUCCESS_MESSAGE)]
        [TestCase(FieldOGS_PROXY_FAILURE_MESSAGE)]
        [TestCase(FieldCLIENT_ACCESS_POLICY)]
        [TestCase(FieldCROSS_DOMAIN_POLICY)]
        [Category("AUT Fields")]
        public void AUT_CommonConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (CommonConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="CommonConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_CommonConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _commonConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}