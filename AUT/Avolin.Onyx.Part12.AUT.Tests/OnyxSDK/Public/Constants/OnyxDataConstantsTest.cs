using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using OnyxSDK.Public.Constants;
using Shouldly;

namespace Avolin.Onyx.Part12.AUT.Tests.OnyxSDK.Public.Constants
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="OnyxSDK.Public.Constants.OnyxDataConstants" />)
    ///     and namespace <see cref="OnyxSDK.Public.Constants"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class OnyxDataConstantsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="OnyxDataConstants" />)
        /// </summary>
        public OnyxDataConstantsTest() : base(typeof(OnyxDataConstants))
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

        #region General Initializer : Class (OnyxDataConstants) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _onyxDataConstantsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="OnyxDataConstants" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _onyxDataConstantsInstanceType = typeof(OnyxDataConstants);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (OnyxDataConstants) Initializer

        #region Fields

        private const string FieldRETURN_XML = "RETURN_XML";
        private const string FieldOTM_ID = "OTM_ID";
        private const string FieldCONTEXT = "CONTEXT";
        private const string FieldSESSION_ID = "SESSION_ID";
        private const string FieldUSER_ID = "USER_ID";
        private const string FieldPARTNER_USER = "PARTNER_USER";
        private const string FieldSITE_ID = "SITE_ID";
        private const string FieldAPPLICATION_NAME = "APPLICATION_NAME";
        private const string FieldSOURCE = "SOURCE";
        private const string FieldPREFERRED_LANGUAGE = "PREFERRED_LANGUAGE";
        private const string FieldORIGINAL_USER = "ORIGINAL_USER";
        private const string FieldPERMISSION_MASK = "PERMISSION_MASK";
        private const string FieldLOG_NAME = "LOG_NAME";
        private const string FieldLOG_SETTINGS = "LOG_SETTINGS";
        private const string FieldIMPERSONATING_USER = "IMPERSONATING_USER";
        private const string FieldSESSION_SECONDS_REMAINING = "SESSION_SECONDS_REMAINING";
        private const string FieldMETHOD_STATUS = "METHOD_STATUS";
        private const string FieldSTATUS_TYPE = "STATUS_TYPE";
        private const string FieldERROR = "ERROR";
        private const string FieldASSOCIATION_ID = "ASSOCIATION_ID";
        private const string FieldSEVERITY = "SEVERITY";
        private const string FieldERROR_NUMBER = "ERROR_NUMBER";
        private const string FieldERROR_DESCRIPTION = "ERROR_DESCRIPTION";
        private const string FieldERROR_TYPE = "ERROR_TYPE";
        private const string FieldNAT_LANG_ID = "NAT_LANG_ID";
        private const string FieldSOURCE_TYPE = "SOURCE_TYPE";
        private const string FieldSOURCE_NAME = "SOURCE_NAME";
        private const string FieldTIME_STAMP = "TIME_STAMP";
        private const string FieldPARAMETERS_RETURN = "PARAMETERS_RETURN";
        private const string FieldCUSTOM_DATA = "CUSTOM_DATA";
        private const string FieldPARAMTERS = "PARAMTERS";
        private const string FieldROW_SET = "ROW_SET";
        private const string FieldCOLUMN_DEFINITIONS = "COLUMN_DEFINITIONS";
        private const string FieldCOLUMN_DEFINITION = "COLUMN_DEFINITION";
        private const string FieldCOLUMN_NAME = "COLUMN_NAME";
        private const string FieldCOLUMN_TYPE = "COLUMN_TYPE";
        private const string FieldCOLUMN_ORDINAL = "COLUMN_ORDINAL";
        private const string FieldCOLUMN_VALUE = "COLUMN_VALUE";
        private const string FieldROWS = "ROWS";
        private const string FieldROW = "ROW";

        #endregion

        #endregion

        #region General Initializer : Class (OnyxDataConstants) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="OnyxDataConstants" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_OnyxDataConstants_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (OnyxDataConstants)

        #region General Initializer : Class (OnyxDataConstants) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="OnyxDataConstants" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldRETURN_XML)]
        [TestCase(FieldOTM_ID)]
        [TestCase(FieldCONTEXT)]
        [TestCase(FieldSESSION_ID)]
        [TestCase(FieldUSER_ID)]
        [TestCase(FieldPARTNER_USER)]
        [TestCase(FieldSITE_ID)]
        [TestCase(FieldAPPLICATION_NAME)]
        [TestCase(FieldSOURCE)]
        [TestCase(FieldPREFERRED_LANGUAGE)]
        [TestCase(FieldORIGINAL_USER)]
        [TestCase(FieldPERMISSION_MASK)]
        [TestCase(FieldLOG_NAME)]
        [TestCase(FieldLOG_SETTINGS)]
        [TestCase(FieldIMPERSONATING_USER)]
        [TestCase(FieldSESSION_SECONDS_REMAINING)]
        [TestCase(FieldMETHOD_STATUS)]
        [TestCase(FieldSTATUS_TYPE)]
        [TestCase(FieldERROR)]
        [TestCase(FieldASSOCIATION_ID)]
        [TestCase(FieldSEVERITY)]
        [TestCase(FieldERROR_NUMBER)]
        [TestCase(FieldERROR_DESCRIPTION)]
        [TestCase(FieldERROR_TYPE)]
        [TestCase(FieldNAT_LANG_ID)]
        [TestCase(FieldSOURCE_TYPE)]
        [TestCase(FieldSOURCE_NAME)]
        [TestCase(FieldTIME_STAMP)]
        [TestCase(FieldPARAMETERS_RETURN)]
        [TestCase(FieldCUSTOM_DATA)]
        [TestCase(FieldPARAMTERS)]
        [TestCase(FieldROW_SET)]
        [TestCase(FieldCOLUMN_DEFINITIONS)]
        [TestCase(FieldCOLUMN_DEFINITION)]
        [TestCase(FieldCOLUMN_NAME)]
        [TestCase(FieldCOLUMN_TYPE)]
        [TestCase(FieldCOLUMN_ORDINAL)]
        [TestCase(FieldCOLUMN_VALUE)]
        [TestCase(FieldROWS)]
        [TestCase(FieldROW)]
        [Category("AUT Fields")]
        public void AUT_OnyxDataConstants_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (OnyxDataConstants) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="OnyxDataConstants" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_OnyxDataConstants_Is_Static_Type_Present_Test()
        {
            // Assert
            _onyxDataConstantsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}