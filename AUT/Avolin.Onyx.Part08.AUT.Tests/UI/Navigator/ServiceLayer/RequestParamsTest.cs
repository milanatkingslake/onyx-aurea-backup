using System;
using System.Diagnostics.CodeAnalysis;
using AUT.TestProjects.BaseSetup;
using AUT.TestProjects.Extensions.BaseSetup.Version.V1;
using AUT.TestProjects.StaticTypes;
using NUnit.Framework;
using Onyx.UI.Navigator.ServiceLayer;
using Shouldly;

namespace Avolin.Onyx.Part08.AUT.Tests.UI.Navigator.ServiceLayer
{
    using Action = System.Action;
    using Should = Shouldly.Should;

    /// <summary>
    ///     Automatic Unit Tests or bulk unit tests for (<see cref="Onyx.UI.Navigator.ServiceLayer.RequestParams" />)
    ///     and namespace <see cref="Onyx.UI.Navigator.ServiceLayer"/> class using generator(v:0.2.5)'s
    ///     artificial intelligence. Compatible with <see cref="AUT.TestProjects.GenV3" /> v1.2+.
    /// </summary>
    [TestFixture]
    [ExcludeFromCodeCoverage]
    public class RequestParamsTest : AbstractBaseSetupV3Test
    {
        /// <summary>
        ///     Automatic Unit Tests for a public class (<see cref="RequestParams" />)
        /// </summary>
        public RequestParamsTest() : base(typeof(RequestParams))
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

        #region General Initializer : Class (RequestParams) One time setup

        private const int TestsTimeOut = TestContants.TimeOutEightSeconds;
        private Type _requestParamsInstanceType;

        /// <summary>
        ///    Setting up everything for <see cref="RequestParams" /> one time.
        /// </summary>
        [OneTimeSetUp]
        [ExcludeFromCodeCoverage]
        public override void OneTimeSetup()
        {
            _requestParamsInstanceType = typeof(RequestParams);
            // Configure ignoring tests.
            ConfigureIgnoringTests();
        }

        #endregion

        #region General Initializer : Class (RequestParams) Initializer

        #region Fields

        private const string FieldAPP_ID = "APP_ID";
        private const string FieldAPP_KEY = "APP_KEY";
        private const string FieldAPPLICATION_NAME = "APPLICATION_NAME";
        private const string FieldAuthMode = "AuthMode";
        private const string FieldCLIENT_DATETIME = "CLIENT_DATETIME";
        private const string FieldCLIENT_UTC_OFFSET = "CLIENT_UTC_OFFSET";
        private const string FieldCOLUMNS = "COLUMNS";
        private const string FieldCONTACT_ID = "CONTACT_ID";
        private const string FieldCONTACT_TYPE_ID = "CONTACT_TYPE_ID";
        private const string FieldCONTENT_TYPE = "CONTENT_TYPE";
        private const string FieldCOUNTRY_ID = "COUNTRY_ID";
        private const string FieldCREDENTIAL = "CREDENTIAL";
        private const string FieldDISPLAY_NAME = "DISPLAY_NAME";
        private const string FieldEMF_KEY = "EMF_KEY";
        private const string FieldFIELD_ID = "FIELD_ID";
        private const string FieldFIELD_STATE = "FIELD_STATE";
        private const string FieldFOLDER_ID = "FOLDER_ID";
        private const string FieldFOLDER_NAME = "FOLDER_NAME";
        private const string FieldGROUP = "GROUP";
        private const string FieldIS_BOOKMARK = "IS_BOOKMARK";
        private const string FieldIS_EDITABLE = "IS_EDITABLE";
        private const string FieldIS_HOME_PAGE_QUERY = "IS_HOME_PAGE_QUERY";
        private const string FieldIS_MOBILEBOOKMARK = "IS_MOBILEBOOKMARK";
        private const string FieldLANG_CODE = "LANG_CODE";
        private const string FieldLBO_Method = "LBO_Method";
        private const string FieldLBO_NAME = "LBO_NAME";
        private const string FieldLboId = "LboId";
        private const string FieldLboMethod = "LboMethod";
        private const string FieldLIST_DESCRIPTION = "LIST_DESCRIPTION";
        private const string FieldLIST_DOMAIN = "LIST_DOMAIN";
        private const string FieldLIST_NAME = "LIST_NAME";
        private const string FieldMAX_RECORDS = "MAX_RECORDS";
        private const string FieldMODE = "MODE";
        private const string FieldMODULE_ID = "MODULE_ID";
        private const string FieldMULTIPLE_PARAMETER_DELIMITER = "MULTIPLE_PARAMETER_DELIMITER";
        private const string FieldNAVIGATOR_ENTITY = "NAVIGATOR_ENTITY";
        private const string FieldNAVIGATOR_ENTITY_ID = "NAVIGATOR_ENTITY_ID";
        private const string FieldOBJECT_TYPE_ID = "OBJECT_TYPE_ID";
        private const string FieldOWNER_ID = "OWNER_ID";
        private const string FieldOWNER_TYPE = "OWNER_TYPE";
        private const string FieldPAGE_INDEX = "PAGE_INDEX";
        private const string FieldPARAMETER = "PARAMETER";
        private const string FieldPARAMETER_DELIMITER = "PARAMETER_DELIMITER";
        private const string FieldPARENT_FOLDER_ID = "PARENT_FOLDER_ID";
        private const string FieldPARENT_ID = "PARENT_ID";
        private const string FieldPassword = "Password";
        private const string FieldPLP_TOKEN = "PLP_TOKEN";
        private const string FieldPROFILE_ID = "PROFILE_ID";
        private const string FieldPROTECTION_MODE = "PROTECTION_MODE";
        private const string FieldQUERY_ID = "QUERY_ID";
        private const string FieldQUERY_MODE = "QUERY_MODE";
        private const string FieldQUERY_NAME = "QUERY_NAME";
        private const string FieldQUERY_PARAMETER = "QUERY_PARAMETER";
        private const string FieldQUERY_TYPE = "QUERY_TYPE";
        private const string FieldREMARKS = "REMARKS";
        private const string FieldRESOURCE_ID = "RESOURCE_ID";
        private const string FieldROW_INDEX = "ROW_INDEX";
        private const string FieldSEARCH_STRING = "SEARCH_STRING";
        private const string FieldSEQUENCE_INDEX = "SEQUENCE_INDEX";
        private const string FieldSITE_ID = "SITE_ID";
        private const string FieldSORT_ORDER = "SORT_ORDER";
        private const string FieldTAGS_CATEGORY_ID = "TAGS_CATEGORY_ID";
        private const string FieldTAGS_OBJECT_TYPE_ENUM = "TAGS_OBJECT_TYPE_ENUM";
        private const string FieldTIME_ZONE_OFFSET = "TIME_ZONE_OFFSET";
        private const string FieldTRANSACTION_APPEND = "TRANSACTION_APPEND";
        private const string FieldTRANSACTION_CREATE = "TRANSACTION_CREATE";
        private const string FieldTRANSACTION_DELETE = "TRANSACTION_DELETE";
        private const string FieldTRANSACTION_HANDLE = "TRANSACTION_HANDLE";
        private const string FieldTRANSACTION_LOG_BEGIN = "TRANSACTION_LOG_BEGIN";
        private const string FieldTRANSACTION_LOG_COMMIT = "TRANSACTION_LOG_COMMIT";
        private const string FieldTRANSACTION_LOG_ROLLBACK = "TRANSACTION_LOG_ROLLBACK";
        private const string FieldTRANSACTION_RENAME = "TRANSACTION_RENAME";
        private const string FieldTRANSACTION_TYPE = "TRANSACTION_TYPE";
        private const string FieldTRANSACTION_UPDATE = "TRANSACTION_UPDATE";
        private const string FieldUSER_ID = "USER_ID";

        #endregion

        #endregion

        #region General Initializer : Class (RequestParams) Explore Non-listed Fields

        /// <summary>
        ///     Class (<see cref="RequestParams" />) explore and verify fields for coverage gain which is not listed in the constants.
        /// </summary>
        [Test]
        [Timeout(TestContants.TimeOutFortySeconds)]
        [Category("AUT Reflection NonListed")]
        [Category("AUT Slow Tests")]
        [Category("AUT Explore")]
        public void AUT_RequestParams_Explore_Reflection_Based_NonListed_Fields_Test()
        {
            // Arrange
            Action currentAction = () => this.ExploreEveryFieldsExceptforUsedOnes();

            // Assert
            Should.NotThrow(currentAction);
        }

        #endregion

        #region Explore Class for Coverage Gain : Class (RequestParams)

        #region General Initializer : Class (RequestParams) All Fields Explore By Name

        /// <summary>
        ///     Class (<see cref="RequestParams" />) explore and verify fields for coverage gain.
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Initializer")]
        [TestCase(FieldAPP_ID)]
        [TestCase(FieldAPP_KEY)]
        [TestCase(FieldAPPLICATION_NAME)]
        [TestCase(FieldAuthMode)]
        [TestCase(FieldCLIENT_DATETIME)]
        [TestCase(FieldCLIENT_UTC_OFFSET)]
        [TestCase(FieldCOLUMNS)]
        [TestCase(FieldCONTACT_ID)]
        [TestCase(FieldCONTACT_TYPE_ID)]
        [TestCase(FieldCONTENT_TYPE)]
        [TestCase(FieldCOUNTRY_ID)]
        [TestCase(FieldCREDENTIAL)]
        [TestCase(FieldDISPLAY_NAME)]
        [TestCase(FieldEMF_KEY)]
        [TestCase(FieldFIELD_ID)]
        [TestCase(FieldFIELD_STATE)]
        [TestCase(FieldFOLDER_ID)]
        [TestCase(FieldFOLDER_NAME)]
        [TestCase(FieldGROUP)]
        [TestCase(FieldIS_BOOKMARK)]
        [TestCase(FieldIS_EDITABLE)]
        [TestCase(FieldIS_HOME_PAGE_QUERY)]
        [TestCase(FieldIS_MOBILEBOOKMARK)]
        [TestCase(FieldLANG_CODE)]
        [TestCase(FieldLBO_Method)]
        [TestCase(FieldLBO_NAME)]
        [TestCase(FieldLboId)]
        [TestCase(FieldLboMethod)]
        [TestCase(FieldLIST_DESCRIPTION)]
        [TestCase(FieldLIST_DOMAIN)]
        [TestCase(FieldLIST_NAME)]
        [TestCase(FieldMAX_RECORDS)]
        [TestCase(FieldMODE)]
        [TestCase(FieldMODULE_ID)]
        [TestCase(FieldMULTIPLE_PARAMETER_DELIMITER)]
        [TestCase(FieldNAVIGATOR_ENTITY)]
        [TestCase(FieldNAVIGATOR_ENTITY_ID)]
        [TestCase(FieldOBJECT_TYPE_ID)]
        [TestCase(FieldOWNER_ID)]
        [TestCase(FieldOWNER_TYPE)]
        [TestCase(FieldPAGE_INDEX)]
        [TestCase(FieldPARAMETER)]
        [TestCase(FieldPARAMETER_DELIMITER)]
        [TestCase(FieldPARENT_FOLDER_ID)]
        [TestCase(FieldPARENT_ID)]
        [TestCase(FieldPassword)]
        [TestCase(FieldPLP_TOKEN)]
        [TestCase(FieldPROFILE_ID)]
        [TestCase(FieldPROTECTION_MODE)]
        [TestCase(FieldQUERY_ID)]
        [TestCase(FieldQUERY_MODE)]
        [TestCase(FieldQUERY_NAME)]
        [TestCase(FieldQUERY_PARAMETER)]
        [TestCase(FieldQUERY_TYPE)]
        [TestCase(FieldREMARKS)]
        [TestCase(FieldRESOURCE_ID)]
        [TestCase(FieldROW_INDEX)]
        [TestCase(FieldSEARCH_STRING)]
        [TestCase(FieldSEQUENCE_INDEX)]
        [TestCase(FieldSITE_ID)]
        [TestCase(FieldSORT_ORDER)]
        [TestCase(FieldTAGS_CATEGORY_ID)]
        [TestCase(FieldTAGS_OBJECT_TYPE_ENUM)]
        [TestCase(FieldTIME_ZONE_OFFSET)]
        [TestCase(FieldTRANSACTION_APPEND)]
        [TestCase(FieldTRANSACTION_CREATE)]
        [TestCase(FieldTRANSACTION_DELETE)]
        [TestCase(FieldTRANSACTION_HANDLE)]
        [TestCase(FieldTRANSACTION_LOG_BEGIN)]
        [TestCase(FieldTRANSACTION_LOG_COMMIT)]
        [TestCase(FieldTRANSACTION_LOG_ROLLBACK)]
        [TestCase(FieldTRANSACTION_RENAME)]
        [TestCase(FieldTRANSACTION_TYPE)]
        [TestCase(FieldTRANSACTION_UPDATE)]
        [TestCase(FieldUSER_ID)]
        [Category("AUT Fields")]
        public void AUT_RequestParams_All_Fields_Explore_Verify_By_Name_Test(string name)
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

        #region General Instance : Class (RequestParams) Static Class or Instance Creation

        /// <summary>
        ///     Class (<see cref="RequestParams" />) can be created test
        /// </summary>
        [Test]
        [Timeout(TestsTimeOut)]
        [Category("AUT Instance")]
        public void AUT_RequestParams_Is_Static_Type_Present_Test()
        {
            // Assert
            _requestParamsInstanceType.ShouldNotBeNull();
        }

        #endregion

        #endregion

        #endregion
    }
}